using API_Inventory.Models.Entities.IMS;

namespace API_Inventory.Interface.IMS
{
    public interface IReport
    {
        DailyReportRes GetDailyReportBC(DailyReportReq req);
        MovementReportRes GetMovementReportBC(MovementReportReq req);
        AdvanceReportRes GetAdvanceReportBC(AdvanceReportReq req);

    }
}
