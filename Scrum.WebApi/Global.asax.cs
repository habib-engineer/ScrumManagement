using Autofac;
using Scrum.WebApi.Controllers;
using Scrum.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Scrum.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<RetrospectiveRepository>()
                .As<IRetrospectiveRepository>()
                .InstancePerLifetimeScope();

            containerBuilder.RegisterType<FeedbackRepository>()
            .As<IFeedbackRepository>()
            .InstancePerLifetimeScope();

            containerBuilder.RegisterType<RetrospectivesController>()
                .As<RetrospectivesController>();

            containerBuilder.RegisterType<FeedbacksController>()
                .As<FeedbacksController>();

            GlobalConfiguration.Configuration.DependencyResolver = new AutoFacDependencyResolver(containerBuilder.Build());
        }
    }
}
