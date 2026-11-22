//using System;
//using Microsoft.AspNet.Identity;
//using Microsoft.Owin;
//using Owin;
//using MvcForum.Core.Interfaces.Services;
//using System.Collections.Generic;
//using Unity.Extension;
//using static Unity.UnityContainerExtensions;

//namespace CMS.Web
//{
//    public partial class Startup
//    {
//        // For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
//        public void ConfigureAuth(IAppBuilder app)
//        {
//            //ConfigureAuth(app);
//            //// System.Web.Http.GlobalConfiguration.Configure(WebApiConfig.Register);
//            ////FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

//            //// Start unity
//            //MvcForum.Core.Ioc.UnityHelper.InitialiseUnityContainer();

//            //// Make DB update to latest migration
//            //// Database.SetInitializer(new MigrateDatabaseToLatestVersion<MvcForumContext, Configuration>());

//            //// Set the rest of the Ioc
//            //MvcForum.Core.Ioc.UnityHelper.BuildUnityContainer();

//            //// Grab the container as we will need to use it
//            //var unityContainer = MvcForum.Core.Ioc.UnityHelper.Container;

//            //// Set Hangfire to use SQL Server and the connection string
//            //// GlobalConfiguration.Configuration.UseSqlServerStorage(ForumConfiguration.Instance.MvcForumContext);

//            //// Make hangfire use unity container
//            ////   GlobalConfiguration.Configuration.UseUnityActivator(unityContainer);

//            //// Add Hangfire
//            //// TODO - Do I need this dashboard?
//            ////app.UseHangfireDashboard();
//            //// app.UseHangfireServer();

//            //// Get services needed
//            ////var mvcForumContext = unityContainer.Resolve<IMvcForumContext>();
//            //var badgeService = unityContainer.Resolve<IBadgeService>();
//            //var loggingService = unityContainer.Resolve<ILoggingService>();
//            //var assemblyProvider = unityContainer.Resolve<MvcForum.Core.Interfaces.IAssemblyProvider>();

//            //unityContainer.Resolve<ILoggingService>();
//            //// Routes


//            //// If the same carry on as normal            
//            //var logFileSize = MvcForum.Core.ForumConfiguration.Instance.LogFileMaxSizeBytes;
//            //loggingService.Initialise(logFileSize > 100000 ? logFileSize : 100000);
//            //loggingService.Error("START APP");

//            //// Find the plugin, pipeline and badge assemblies
//            //var assemblies = (List<System.Reflection.Assembly>)assemblyProvider.GetAssemblies(MvcForum.Core.ForumConfiguration.Instance.PluginSearchLocations);
//            //MvcForum.Core.Reflection.ImplementationManager.SetAssemblies(assemblies);

//            //// Do the badge processing
//            //try
//            //{
//            //    //  badgeService.SyncBadges(assemblies);
//            //    //   mvcForumContext.SaveChanges();
//            //}
//            //catch (Exception ex)
//            //{
//            //    loggingService.Error($"Error processing badge classes: {ex.Message}");
//            //}

//            //var theme = "Metro";
//            //// var settings = mvcForumContext.Setting.FirstOrDefault();
//            ////if (settings != null)
//            ////{
//            ////    theme = settings.Theme;
//            ////}

//            //// Set the view engine
//            ////  ViewEngines.Engines.Clear();
//            ////   ViewEngines.Engines.Add(new ForumViewEngine(theme));

//            //// Initialise the events
//            //MvcForum.Core.Events.EventManager.Instance.Initialize(loggingService, assemblies);
//        }
//    }
//}