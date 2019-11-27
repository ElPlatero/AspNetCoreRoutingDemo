using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreRoutingDemo.Controllers.Areas.Dashboards {
    public class AnlagedetailsController : ControllerBase {
        public IActionResult GetAnlagedetails(int dashboardId, int widgetId) => Ok("Dashboard_" + dashboardId + "_Widgetparams_" + widgetId + "_Anlagedetails");
    }
}