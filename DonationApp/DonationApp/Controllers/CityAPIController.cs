using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DonationApp.Data;
using DonationApp.Data.Entities;
using DonationApp.Models;
using System.IO;

namespace DonationApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;

        public CityAPIController(ApplicationDbContext context,
          IMapper mapper,
          UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
        }

        // GET: api/DonationsAPI
        [HttpGet]
        [Route("GetCities")]
        public async Task<IEnumerable<CityViewModel>> Get()
        {
            var results = await _context.Cities.ToListAsync();
            return _mapper.Map<IEnumerable<CityViewModel>>(_mapper.Map<IEnumerable<CityViewModel>>(results));
        }


    }
}
