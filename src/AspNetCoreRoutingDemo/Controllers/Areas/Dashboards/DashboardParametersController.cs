using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreRoutingDemo.Controllers.Areas.Dashboards {
    public class DashboardParametersController : ControllerBase {
        public IActionResult GetParams(int dashboardId) => Ok("Dashboardparams_"+ dashboardId);
    }
}