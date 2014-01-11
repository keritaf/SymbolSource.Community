﻿using System;
using System.Configuration;
using System.Web;
using System.Web.Hosting;

namespace SymbolSource.Server.Basic
{
    public class BasicBackendConfiguration : IBasicBackendConfiguration
    {
        public string DataPath
        {
            get
            {
                var path = ConfigurationManager.AppSettings["dataPath"];

                if (String.IsNullOrEmpty(path))
                {
                    // Default path
                    return HostingEnvironment.MapPath("~/Data");
                }

                return path.StartsWith("~/") ? HostingEnvironment.MapPath(path) : path;
            }
        }

        public string IndexPath
        {
            get
            {
                var path = ConfigurationManager.AppSettings["indexPath"];

                if (String.IsNullOrEmpty(path))
                {
                    // Default path
                    return HostingEnvironment.MapPath("~/Index");
                }

                return path.StartsWith("~/") ? HostingEnvironment.MapPath(path) : path;
            }
        }

        public string RemotePath
        {
            get
            {
                return HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + HostingEnvironment.ApplicationVirtualPath.TrimEnd('/') + "/Data";
            }
        }
    }
}