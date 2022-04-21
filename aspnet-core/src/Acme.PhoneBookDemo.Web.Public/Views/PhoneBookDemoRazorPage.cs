﻿using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Acme.PhoneBookDemo.Web.Public.Views
{
    public abstract class PhoneBookDemoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected PhoneBookDemoRazorPage()
        {
            LocalizationSourceName = PhoneBookDemoConsts.LocalizationSourceName;
        }
    }
}
