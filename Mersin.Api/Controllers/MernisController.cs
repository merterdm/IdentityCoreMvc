﻿using Mersin.Api.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Mersin.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class MernisController : ControllerBase
    {
        private readonly MernisContext context;

        public MernisController(MernisContext context)
        {
            this.context = context;
        }

        [HttpGet]

        public IActionResult Get()
        {

            //DateTime start = DateTime.Now;


            var result = context.Citizens.Take(10).ToList();


            //DateTime stop = DateTime.Now;
            //TimeSpan timeSpan = stop - start;

            //var sonuc = timeSpan.Milliseconds;


            if (result.Count > 0)
            {
                return Ok(result);
            }
            else
            {
                return NoContent();
            }

        }

        [HttpGet("{tcno}")]
        public IActionResult GetbyTcNo(string tcno)
        {

            var result = context.Citizens.FirstOrDefault(p => p.NationalIdentifier == tcno);

            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();

            }


        }


    }
}
