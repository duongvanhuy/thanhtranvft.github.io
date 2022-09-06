﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace VFT.CMS.Web.Areas.Admin.Controllers
{
    [Authorize]
    public class RegisterRecieveInfoController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
