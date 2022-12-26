using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DonationApp.Data;
using DonationApp.Models;
using Microsoft.Extensions.Logging;
using DonationApp.Data.Entities;

namespace DonationApp.Controllers
{
    public class DonationsController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IDonationAppRepository _repository;
        private readonly ILogger<DonationsController> _logger;
        private readonly IMapper _mapper;

        public DonationsController(IDonationAppRepository repository,
          ILogger<DonationsController> logger,
          IMapper mapper,
          UserManager<ApplicationUser> userManager)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
            _userManager = userManager;
        }


        public async Task<IActionResult> Index()
        {
            var results = _repository.GetAllDonations();
            return View(_mapper.Map<IEnumerable<DonationViewModel>>(results));
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var Donation = _repository.GetDonationById(id);
            if (Donation != null) return Ok(_mapper.Map<IEnumerable<DonationViewModel>>(Donation));
            return NotFound();
        }

        [HttpGet]
        [Route("api/Donations")]
        public IActionResult Get()
        {
            //var Donations = _repository.GetAllDonations();
            //if (Donations != null)
            //{
            //    return Ok(_mapper.Map<IEnumerable<DonationViewModel>>(Donations));
            //}
            //return NotFound();

            try
            {
                //var username = User.Identity.Name;

                var results = _repository.GetAllDonations();

                return Ok(_mapper.Map<IEnumerable<DonationViewModel>>(results));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to return Donations: {ex}");
                return BadRequest($"Failed to return Donations");
            }
        }

        [HttpGet]
        [Route("api/Donations/GetNewDonations")]
        public IActionResult GetNewDonations()
        {
            //var Donations = _repository.GetAllDonations();
            //if (Donations != null)
            //{
            //    return Ok(_mapper.Map<IEnumerable<DonationViewModel>>(Donations));
            //}
            //return NotFound();

            try
            {
                //var username = User.Identity.Name;

                var results = _repository.GetNewDonations();

                return Ok(_mapper.Map<IEnumerable<DonationViewModel>>(results));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to return Donations: {ex}");
                return BadRequest($"Failed to return Donations");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] DonationViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var newDonation = _mapper.Map<DonationApp.Data.Entities.Donation>(model);

                    var currentUser = await _userManager.FindByNameAsync(User.Identity.Name);
                    newDonation.User = currentUser;

                    _repository.AddEntity(newDonation);
                    if (_repository.SaveAll())
                    {
                        return Created($"/api/Donations/{newDonation.Id}", _mapper.Map<DonationViewModel>(newDonation));
                    }
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to save new Donation: {ex}");
            }

            return BadRequest("Failed to save new Donation.");
        }

    }
}