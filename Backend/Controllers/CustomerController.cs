﻿using BusinessLogic.BOs;
using BusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Backend.Controllers
{
    public class CustomerController : ApiController
    {
        [Route("api/customer/")]
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            return Request.CreateResponse(HttpStatusCode.OK, CustomerServices.GetAll());
        }

        [Route("api/customer/{id}")]
        [HttpGet]
        public HttpResponseMessage GetById(int id)
        {
            var data = CustomerServices.GetById(id);
            if (data == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }

        }

        [Route("api/customer/create")]
        [HttpPost]
        public HttpResponseMessage Create(CustomerModel t)
        {
            var res = CustomerServices.Create(t);
            return Request.CreateResponse(HttpStatusCode.OK, res);
        }

        [Route("api/customer/update")]
        [HttpPost]
        public HttpResponseMessage Update(CustomerModel t)
        {
            var res = CustomerServices.Update(t);
            return Request.CreateResponse(HttpStatusCode.OK, res);
        }

        [Route("api/customer/delete/{id}")]
        [HttpPost]
        public HttpResponseMessage Delete(int id)
        {
            var res = CustomerServices.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, res);
        }
    }
}
