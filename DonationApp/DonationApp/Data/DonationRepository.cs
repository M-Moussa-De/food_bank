using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DonationApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DonationApp.Data
{
    public class DonationAppRepository : IDonationAppRepository
    {
        private readonly ApplicationDbContext _ctx;
        private readonly ILogger<DonationAppRepository> _logger;

        public DonationAppRepository(ApplicationDbContext ctx, ILogger<DonationAppRepository> logger)
        {
            _ctx = ctx;
            _logger = logger;
        }

        public IEnumerable<City> GetAllCities()
        {
            try
            {
                return _ctx.Cities.ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get all Cities: {ex}");
                return null;
            }
        }

        public IEnumerable<District> GetDistricts(int? cityId)
        {
            try
            {
                return _ctx.Districts.Where(x => x.CityId == cityId).ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get Districts: {ex}");
                return null;
            }
        }

        public IEnumerable<Entities.Donation> GetAllDonations()
        {
            return _ctx.Donations.Include("DonationAttachments").Include("User").Include("City").Include("District").ToList();

        }

        public IEnumerable<Entities.Donation> GetNewDonations()
        {
            return _ctx.Donations.Where(b => b.Status == 1).ToList();

        }

        public Entities.Donation GetDonationById(int id)
        {
            return _ctx.Donations
              .Where(o => o.Id == id)
              .FirstOrDefault();
        }

        public bool SaveAll()
        {
            return _ctx.SaveChanges() > 0;
        }

        public void AddEntity(object entity)
        {
            _ctx.Add(entity);
        }

        public IEnumerable<Entities.Donation> GetDonationsByUser(string username)
        {
            return _ctx.Donations
              .Where(o => o.User.UserName == username)
              .ToList();

        }

        public City GetCityById(int id)
        {
            return _ctx.Cities
              .Where(o => o.Id == id)
              .FirstOrDefault();
        }
    }
}
