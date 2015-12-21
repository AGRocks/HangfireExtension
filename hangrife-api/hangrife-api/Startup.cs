using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using Hangfire;
using Hangfire.SQLite;

[assembly: OwinStartup(typeof(hangrife_api.Startup))]

namespace hangrife_api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            var options = new BackgroundJobServerOptions
            {
                WorkerCount = 10
            };

            GlobalConfiguration.Configuration
                .UseSQLiteStorage(@"Data Source=d:\temp\hangfire\hangfire.sqlite;Version=3;")
                .UseMsmqQueues(@".\private$\hangfire-test", "msmq");

            app.UseHangfireDashboard("/dashboard");
            app.UseHangfireServer(options);
        }
    }
}
