﻿using System.Web;
using System.Web.Mvc;

namespace Zero_Hunger_Mid
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
