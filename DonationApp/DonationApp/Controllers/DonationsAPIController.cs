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
    public class DonationsAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;

        public DonationsAPIController(ApplicationDbContext context,
          IMapper mapper,
          UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
        }

        // GET: api/DonationsAPI
        [HttpGet]
        public async Task<IEnumerable<DonationViewModel>> GetDonationViewModel()
        {
            var results = await _context.Donations.Include("DonationAttachments").Include("User").Include("City").Include("District").ToListAsync();
            return _mapper.Map<IEnumerable<DonationViewModel>>(results);
        }


        [HttpGet]
        [Route("GetNewDonations")]
        public async Task<IEnumerable<DonationViewModel>> GetNewDonations()
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

                var results = await _context.Donations.Include("DonationAttachments").Include("User").Include("City").Include("District").Where(x=>x.Status==1).ToListAsync();

                return _mapper.Map<IEnumerable<DonationViewModel>>(results);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        // GET: api/DonationsAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DonationViewModel>> GetDonationViewModel(int id)
        {
            var donation = await _context.Donations.Include("DonationAttachments").Include("User").Include("City").Include("District").FirstOrDefaultAsync(x => x.Id == id);

            if (donation == null)
            {
                return NotFound();
            }

            return _mapper.Map<DonationViewModel>(donation);
        }

        // PUT: api/DonationsAPI/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDonationViewModel(int id, DonationViewModel DonationViewModel)
        {
            if (id != DonationViewModel.Id)
            {
                return BadRequest();
            }
            var donation = _mapper.Map<Data.Entities.Donation>(DonationViewModel);
            _context.Entry(donation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DonationViewModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/DonationsAPI
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DonationViewModel>> Post([FromForm] DonationViewModel donationVM)
        {
            donationVM.DonationAttachmentViewModels = new List<DonationAttachmentViewModel>();
            foreach (var file in donationVM.Files)
            {
                DonationAttachmentViewModel dAttachmentVM = new DonationAttachmentViewModel();
                using (MemoryStream ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                    dAttachmentVM.Src = Utilities.Compression.Compress(ms.ToArray());
                }
                donationVM.DonationAttachmentViewModels.Add(dAttachmentVM);
            }

            var donation = _mapper.Map<Data.Entities.Donation>(donationVM);
            donation.CreatedOn = DateTime.Now;
            donation.Status = 1;
            _context.Donations.Add(donation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = donationVM.Id }, donationVM);
        }

        // DELETE: api/DonationsAPI/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DonationViewModel>> Delete(int id)
        {
            var donation = await _context.Donations.FindAsync(id);
            if (donation == null)
            {
                return NotFound();
            }

            _context.Donations.Remove(donation);
            await _context.SaveChangesAsync();

            return _mapper.Map<DonationViewModel>(donation);
        }

        private bool DonationViewModelExists(int id)
        {
            return _context.Donations.Any(e => e.Id == id);
        }
    }
}
