using System.Web.Optimization;

namespace Affecto.AngularJS.TypeScript.BusyIndication
{
    public class BusyIndicationBundle
    {
        public static Bundle CreateScriptBundle(string virtualPath)
        {
            return new ScriptBundle(virtualPath)
                .IncludeDirectory("~/App/Packages/BusyIndication/Constants", "*.js")
                .IncludeDirectory("~/App/Packages/BusyIndication/Directives", "*.js")
                .IncludeDirectory("~/App/Packages/BusyIndication/Services", "*.js")
                .IncludeDirectory("~/App/Packages/BusyIndication", "*.js");
        }

        public static string GetStyleBundleVirtualPath()
        {
            return "~/Content/Packages/BusyIndication/BusyIndication.css";
        }
    }
}