﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VenusTicariOtomasyon.Helpers
{
    public static class HtmlHelpers
    {
        public static string ActivePage(this HtmlHelper helper, string controller, string action)
        {
            string classValue = "";
            string currentController = helper.ViewContext.Controller.ValueProvider.GetValue("controller").RawValue.ToString();
            string currentAction = helper.ViewContext.Controller.ValueProvider.GetValue("action").RawValue.ToString();
            if (currentController == controller && currentAction == action)
            {
                classValue = "active";
            }
            return classValue;
        }

        public static string OpenModule(this HtmlHelper helper, string controller)
        {
            string classValue = "";
            string currentController = helper.ViewContext.Controller.ValueProvider.GetValue("controller").RawValue.ToString();
            if (currentController == controller)
            {
                classValue = "menu-open";
            }
            return classValue;
        }

        public static string ActiveModule(this HtmlHelper helper, string controller)
        {
            string classValue = "";
            string currentController = helper.ViewContext.Controller.ValueProvider.GetValue("controller").RawValue.ToString();
            if (currentController == controller)
            {
                classValue = "active";
            }
            return classValue;
        }
    }
}