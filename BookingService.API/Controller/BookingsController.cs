﻿using BookingService.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingService.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private IBookingsService manageBookings;
        public BookingsController(IBookingsService agentService)
        {
            this.manageBookings = agentService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await manageBookings.GetAllElement()); // 200 + retrieved data 
        }
    }
}
