using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using ReadTxt.Models;

namespace ReadTxt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpPost]
        public ActionResult Index(HttpPostedFileWrapper inputArquivo)
        {
            List<Customer> customers = new List<Customer>();

            var lines = Services.FilesServices.GetFileLines(inputArquivo);
            return Ok(customers);
        }
    }
}
