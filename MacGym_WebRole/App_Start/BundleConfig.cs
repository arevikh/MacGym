using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MacGym_WebRole
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/lib/jquery-1.9.1.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/bootstrap.min.js"));

            var lessBundle = new Bundle("~/styles/less").IncludeDirectory("~/styles/less", "*.less");
            lessBundle.Transforms.Add(new LessTransform());
            bundles.Add(lessBundle);

            BundleTable.EnableOptimizations = false;
        }
    }
}