﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HiBlogs.Application.Admin;
using Talk.OAuthClient;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HiBlogs.Web.Areas.Admin.Controllers
{
    /// <summary>
    /// 帐户管理
    /// </summary>
    public class AccountController : AdminBaseController
    {
        private readonly AccountAppService accountAppService;
        public AccountController()
        {
            accountAppService = new AccountAppService();
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <returns></returns>
        public IActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <returns></returns>
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult GetOAuthQQUrl()
        {
            var url = accountAppService.GetOAuthClient(AuthType.QQ).GetAuthUrl();
            return Redirect(url);
        }

        public IActionResult GetOAuthSinaUrl()
        {
            var url = accountAppService.GetOAuthClient(AuthType.Sina).GetAuthUrl();
            return Redirect(url);
        }
    }
}
