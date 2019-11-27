using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreRoutingDemo.Controllers.Areas.Dashboards {
    public class WidgetsController : ControllerBase {
        public IActionResult GetWidget(int dashboardId, int widgetId) => Ok("Dashboard_" + dashboardId + "_Widget_" + widgetId);
    }
}