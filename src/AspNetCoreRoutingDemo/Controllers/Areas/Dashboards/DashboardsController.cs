using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreRoutingDemo.Controllers.Areas.Dashboards {
    public class DashboardsController : ControllerBase {
        public IActionResult GetDashboard(int dashboardId) => Ok("Dashboard_" + dashboardId);
    }
}
