using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreRoutingDemo.Controllers.Areas.Dashboards {
    public class WidgetParametersController : ControllerBase {
        public IActionResult GetParams(int dashboardId, int widgetId) => Ok("Dashboard_" + dashboardId + "_Widgetparams_" + widgetId);
    }
}