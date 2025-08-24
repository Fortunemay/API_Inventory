using System.ComponentModel.DataAnnotations;

namespace Inventory_API.Models.Entities
{
    public class LoginModel
    {
        public string? status { get; set; }
        public string? message { get; set; }
        public string? token { get; set; }
    }

    public class LoginReq
    {
        [Required] public string? username { get; set; }
        [Required] public string? password { get; set; }
    }
    public class GetConnectTokenModel
    {
        public string? access_token { get; set; }
        public int? expires_in { get; set; }
        public string? token_type { get; set; }
        public string? error { get; set; }
        public string? error_description { get; set; }
    }

    public class EmployeeInfoReq
    {
        public string employeeId { get; set; }
    }

    public class EmployeeInfoResp
    {
        public int? contactid { get; set; }
        public string? employeeID { get; set; }
        public string? personId { get; set; }
        public string? prefix { get; set; }
        public string? gender { get; set; }
        public string? firstName { get; set; }
        public string? LastName { get; set; }
        public string? alt1FirstName { get; set; }
        public string? alt1LastName { get; set; }
        public DateTime? dateOfBirth { get; set; }
        public string? position { get; set; }
        public string? positionTitle { get; set; }
        public string? pisitionTitleTH { get; set; }
        public string? costCentreCode { get; set; }
        public string? costCenterNameTH { get; set; }
        public string? companyGroupCode { get; set; }
        public string? companyCode { get; set; }
        public string? companyName { get; set; }
        public string? companyNameTH { get; set; }
        public string? groupCode { get; set; }
        public string? groupName { get; set; }
        public string? groupNameTH { get; set; }
        public string? bUSUCode { get; set; }
        public string? bUSUName { get; set; }
        public string? bUSUNameTH { get; set; }
        public string? divisionCode { get; set; }
        public string? divisionName { get; set; }
        public string? divisionNameTH { get; set; }
        public string? departmentCode { get; set; }
        public string? departmentName { get; set; }
        public string? departmentNameTH { get; set; }
        public string? functionCode { get; set; }
        public string? functionName { get; set; }
        public string? functionNameTH { get; set; }
        public string? sectionCode { get; set; }
        public string? sectionName { get; set; }
        public string? sectionNameTH { get; set; }
        public string? unitCode { get; set; }
        public string? unitName { get; set; }
        public string? unitNameTH { get; set; }
        public string? eMail { get; set; }
        public string? personalLevel { get; set; }
        public string? tel { get; set; }
        public int? empManagerID { get; set; }
        public string? workStatusCode { get; set; }
        public DateTime? employDate { get; set; }
        public string? departDate { get; set; }
        public DateTime? probationEndDate { get; set; }
        public string? manager1 { get; set; }
        public string? manager2 { get; set; }
        public string? manager3 { get; set; }
        public string? manager4 { get; set; }
        public string? manager5 { get; set; }
        public string? manager6 { get; set; }
        public string? manager7 { get; set; }
        public string? manager8 { get; set; }
        public string? manager9 { get; set; }
        public string? manager10 { get; set; }
        public string? hCBP { get; set; }
        public string? hCBPMgr { get; set; }
        public string? companyCountry { get; set; }
    }
}
