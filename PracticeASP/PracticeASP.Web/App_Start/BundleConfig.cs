using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace PracticeASP.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bootstrap/Content/css").Include(
                                          "~/Content/css/bootstrap/bootstrap.min.css",
                                         "~/Content/css/animate/animate.css",
                                         "~/Content/css/style.css"));
        }
    }
}