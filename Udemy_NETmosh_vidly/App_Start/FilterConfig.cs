﻿using System.Web;
using System.Web.Mvc;

namespace Udemy_NETmosh_vidly
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
