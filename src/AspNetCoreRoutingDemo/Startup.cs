using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreRoutingDemo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc(routes => {
                routes.MapAreaRoute("dashboards_default",               "dashboards", "api/dashboards/{dashboardId}", new {controller = "Dashboards", action = "GetDashboard"});
                routes.MapAreaRoute("dashboards_params",                "dashboards", "api/dashboards/{dashboardId}/params", new {controller = "DashboardParameters", action = "GetParams"});
                routes.MapAreaRoute("dashboards_widgets",               "dashboards", "api/dashboards/{dashboardId}/widgets/{widgetId}", new {controller = "Widgets", action = "GetWidget"});
                routes.MapAreaRoute("dashboards_widgetparams",          "dashboards", "api/dashboards/{dashboardId}/widgets/{widgetId}/params", new {controller = "WidgetParameters", action = "GetParams" });
                routes.MapAreaRoute("dashboards_widgetanlagedetails",   "dashboards", "api/dashboards/{dashboardId}/widgets/{widgetId}/anlagedetails", new {controller = "Anlagedetails", action = "GetAnlagedetails" });
            });
        }
    }
}
