﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers{
    public class HomeController : Controller{

        public ViewResult Index() {
            return View("Index", new string[] { "Bob", "Joe", "Alice" });

        }
        }
    }

