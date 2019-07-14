﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace LanguageFeatures.Models{

    public class MyAsyncMethods{

        public async static Task<long?> GetPageLength(){

            HttpClient client = new HttpClient();

            var httpTask =  await client.GetAsync("http://apress.com");

            return httpTask.Content.Headers.ContentLength;
            }
        }
    }

