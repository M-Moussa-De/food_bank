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
    public class DistrictAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;

        public DistrictAPIController(ApplicationDbContext context,
          IMapper mapper,
          UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
        }

        // GET: api/DonationsAPI
        [HttpGet]
        [Route("GetDistricts")]
        public async Task<IEnumerable<DistrictViewModel>> Get(int cityId)
        {
            var results = await _context.Districts.Where(d => d.CityId == cityId).ToListAsync();
            return _mapper.Map<IEnumerable<DistrictViewModel>>(_mapper.Map<IEnumerable<DistrictViewModel>>(results));
        }


    }
}
