using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace hangrife_api.Controllers
{
    public class HangfireController : ApiController
    {
        // \api\hangfire\
        public string Get(int num)
        {
            for (int i = 0; i < num; i++)
            {
                BackgroundJob.Enqueue(() => Console.WriteLine($"Job {i} executed"));
            }

            return "started";
        }
    }
}