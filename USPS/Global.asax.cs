﻿using System;
using System.Threading;
using Juice.Framework;
using USPS.Code;

namespace USPS
{
    public class Global : System.Web.HttpApplication
    {
        private Thread _sipThread;
        void Application_Start(object sender, EventArgs e)
        {
            CssManager.CssResourceMapping.AddDefinition("juice-ui", new CssResourceDefinition
            {
                Path = "~/Content/themes/Supercharged/jquery-ui-1.9.0.custom.css",
            });
            ServiceManager.LoadServices(Server.MapPath("Resources\\Services\\"));
            ServiceManager.LoadConditions(Server.MapPath("Resources\\Conditions\\Conditions.xml"));
            SIPHandler sh = new SIPHandler();
            _sipThread = new Thread(new ThreadStart(sh.Start));
            _sipThread.Start();
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown
            _sipThread.Abort();
        }

        void Application_EndRequest(object sender, EventArgs e)
        {
            //  Code that runs after the page code is executed
        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }

        void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started

        }

        void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.

        }
    }
}
