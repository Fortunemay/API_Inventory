using System.ComponentModel.DataAnnotations;

namespace Inventory_API.Models.Entities
{
    public class CustomerOntradeModel
    {
        public string? status { get; set; }
        public string? message { get; set; }
        public List<CustomerOntradeResp> customerOntradeResps { get; set; }
    }

    public class CustomerOntradeReq
    {
        [Required] public string? regionCode { get; set; }
    }
    public class CustomerOntradeResp
    {
        public string? SurveyName { get; set; }

    }
}
