using API_Inventory.Interface.IMS;
using API_Inventory.Models.Entities.IMS;
using Inventory_API.Controllers;
using Inventory_API.Interface;
using Inventory_API.Models.Entities;
using Inventory_API.Models.Utilities;
using log4net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Inventory.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        readonly IConfiguration _configuration;
        private readonly ILogger<ReportController> _logger;
        ILoggerInfo _ilog;
        IReport _report;

        public ReportController(ILogger<ReportController> logger, ILoggerInfo loggerInfo, IConfiguration configuration, IReport report)
        {
            _logger = logger;
            _ilog = loggerInfo;
            _configuration = configuration;
            _report = report;
        }

        /// <summary>
        /// Get Daily Report
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetDailyReport")]
        public async Task<ActionResult<DailyReportRes>> GetDailyReport(DailyReportReq req)
        {
            DailyReportRes model = new DailyReportRes();
            try
            {
                model = _report.GetDailyReportBC(req);
            }
            catch (Exception ex)
            {
                model.status = Constants.STATUS_ERROR;
                model.message = ex.Message;
                _ilog.Info("Fatal Message : " + ex.Message);
                _ilog.Info("Exception StackTrace : " + ex.StackTrace);

                if (ex.InnerException != null)
                {
                    _ilog.Info("InnerException Message : " + ex.InnerException.Message);
                    _ilog.Info("InnerException StackTrace : " + ex.InnerException.StackTrace);
                }
            }

            return model;
        }

        /// <summary>
        /// Get Movement Report
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetMovementReport")]
        public async Task<ActionResult<MovementReportRes>> GetMovementReport(MovementReportReq req)
        {
            MovementReportRes model = new MovementReportRes();
            try
            {
                model = _report.GetMovementReportBC(req);   
            }
            catch (Exception ex)
            {
                model.status = Constants.STATUS_ERROR;
                model.message = ex.Message;
                _ilog.Info("Fatal Message : " + ex.Message);
                _ilog.Info("Exception StackTrace : " + ex.StackTrace);

                if (ex.InnerException != null)
                {
                    _ilog.Info("InnerException Message : " + ex.InnerException.Message);
                    _ilog.Info("InnerException StackTrace : " + ex.InnerException.StackTrace);
                }
            }

            return model;
        }

        /// <summary>
        /// Get Advance Report
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetAdvanceReport")]
        public async Task<ActionResult<AdvanceReportRes>> GetAdvanceReport(AdvanceReportReq req)
        {
            AdvanceReportRes model = new AdvanceReportRes();
            try
            {
                model = _report.GetAdvanceReportBC(req);
            }
            catch (Exception ex)
            {
                model.status = Constants.STATUS_ERROR;
                model.message = ex.Message;
                _ilog.Info("Fatal Message : " + ex.Message);
                _ilog.Info("Exception StackTrace : " + ex.StackTrace);

                if (ex.InnerException != null)
                {
                    _ilog.Info("InnerException Message : " + ex.InnerException.Message);
                    _ilog.Info("InnerException StackTrace : " + ex.InnerException.StackTrace);
                }
            }

            return model;
        }

    }
}
