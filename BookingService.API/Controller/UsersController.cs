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
    public class UsersController : ControllerBase
    {
        IUsersService manageUsers;
        public UsersController(IUsersService usersService)
        {
            manageUsers = usersService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await manageUsers.GetAllElement()); // 200 + retrieved data 
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetFistName(int id)
        {
            var user = manageUsers.GetElementById(id);
            var fistname =  manageUsers.GetUserFirstName(await user);
            return Ok(fistname); // 200 + retrieved data 
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetLastName(int id)
        {
            var user = manageUsers.GetElementById(id);
            var lastname = manageUsers.GetUserLastName(await user);
            return Ok(lastname); // 200 + retrieved data 
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetEmail(int id)
        {
            var user = manageUsers.GetElementById(id);
            var email = manageUsers.GetUserEmail(await user);
            return Ok(email); // 200 + retrieved data 
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetPhoneNo(int id)
        {
            var user = manageUsers.GetElementById(id);
            var phoneno = manageUsers.GetUserPhoneNo(await user);
            return Ok(phoneno); // 200 + retrieved data 
        }
    }
}
