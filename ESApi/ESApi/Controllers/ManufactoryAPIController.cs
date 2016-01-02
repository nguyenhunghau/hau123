﻿using ESApi.Models.Code;
using ESApi.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ESApi.Controllers
{
    public class ManufactoryAPIController : ApiController
    {
        public ManufactoryCode Manu = new ManufactoryCode();

        [HttpGet]
        [Route("api/Manufactory/all")]
        public IHttpActionResult GetAllProducts()
        {
            return Ok(Manu.GetListNSX());
        }

        [HttpGet]
        [Route("api/Manufactory/AllManu")]
        public IHttpActionResult GetAllManu()
        {
            return Ok(Manu.GetAllNSX());
        }
    }
}
