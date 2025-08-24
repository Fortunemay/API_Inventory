using Inventory_API.Helper;
using Inventory_API.Interface;
using Inventory_API.Interface.Auth;
using Inventory_API.Models.Entities;
using Inventory_API.Models.Utilities;
using log4net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI;
using System.Net.Http.Headers;

namespace Inventory_API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        readonly IConfiguration _configuration;
        private readonly ILogger<AuthController> _logger;
        ILoggerInfo _ilog;
        private readonly IJwtAuth jwtAuth;
        static HttpClient client = new HttpClient();

        static IConfiguration conf = (new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build());
        public static string urlConnectToken = conf["AppSettings:URL_CONNECT_TOKEN"].ToString();
        public static string urlEmpInfo = conf["AppSettings:URL_EMP_INFO"].ToString();

        public AuthController(ILogger<AuthController> logger, ILoggerInfo loggerInfo, IConfiguration configuration,IJwtAuth jwtAuth)
        {
            _logger = logger;
            _ilog = loggerInfo;
            _configuration = configuration;
            this.jwtAuth = jwtAuth;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<LoginModel>> Login(LoginReq req)
        {
            LoginModel loginModel = new LoginModel();
            try
            {
                //LoginReq loginReq = new LoginReq();
                //var hashedPassword = new PasswordHasher<LoginReq>().HashPassword(loginReq, req.password);

                //loginModel.loginReq.username = req.username;
                //loginModel.loginReq.password = hashedPassword;


                GetConnectTokenModel getConnectTokenModel = null;

                using (var multiPartStream = new MultipartFormDataContent())
                {
                    multiPartStream.Add(new StringContent("password"), "grant_type");
                    multiPartStream.Add(new StringContent("emppoint_client"), "client_id");
                    multiPartStream.Add(new StringContent("thaibev.privilege.readonly user.readonly"), "scope");
                    multiPartStream.Add(new StringContent("Th@ib3v"), "client_secret");
                    multiPartStream.Add(new StringContent(req.username), "username");
                    multiPartStream.Add(new StringContent(req.password), "password");

                    var res = await client.PostAsync(urlConnectToken, multiPartStream);
                    var strinResp = await res.Content.ReadAsStringAsync();

                    getConnectTokenModel = new GetConnectTokenModel();
                    getConnectTokenModel = Helper.Helper.DeserializeObject<GetConnectTokenModel>(strinResp);

                }

                List<EmployeeInfoResp> employeeInfoResps = new List<EmployeeInfoResp>();

                if (string.IsNullOrEmpty(getConnectTokenModel.error))
                {
                    EmployeeInfoReq employeeInfoReq = new EmployeeInfoReq();
                    employeeInfoReq.employeeId = req.username;
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(getConnectTokenModel.token_type, getConnectTokenModel.access_token);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var resInfo = await client.PostAsJsonAsync(urlEmpInfo, employeeInfoReq);
                    var strinRespInfo = await resInfo.Content.ReadAsStringAsync();

                    employeeInfoResps = new List<EmployeeInfoResp>();
                    employeeInfoResps = Helper.Helper.DeserializeObject<List<EmployeeInfoResp>>(strinRespInfo);
                }
                else
                    throw new Exception(getConnectTokenModel.error_description.Replace("invalid_username_or_password", "รหัสพนักงานหรือรหัสผ่านผิด"));

                loginModel.token = jwtAuth.Authentication(employeeInfoResps[0].employeeID, employeeInfoResps[0].eMail);
                loginModel.status = Constants.STATUS_SUCCESS;
            }
            catch (Exception ex)
            {
                loginModel.status = Constants.STATUS_ERROR;
                loginModel.message = ex.Message;

                _logger.LogInformation("Fatal Message : " + ex.Message);
                _logger.LogInformation("Exception StackTrace : " + ex.StackTrace);

                if (ex.InnerException != null)
                {
                    _logger.LogInformation("InnerException Message : " + ex.InnerException.Message);
                    _logger.LogInformation("InnerException StackTrace : " + ex.InnerException.StackTrace);
                }
            }
            return loginModel;
        }
    }
}
