﻿using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace server.ApiExtensions
{
    public class RequestHandler
    {
        public static BadRequestObjectResult BadRequest(string message)
        {
            return new BadRequestObjectResult(new { message });
        }

        public static BadRequestObjectResult Unauthorized()
        {
            return new BadRequestObjectResult(new { message = "An error occoured when validating your identity" });
        }
    }
}