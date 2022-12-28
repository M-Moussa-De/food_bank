using System.Collections.Generic;
using DonationApp.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DonationApp.Data
{
    public interface IDonationAppRepository
    {
        IEnumerable<City> GetAllCities();
        IEnumerable<District> GetDistricts(int? cityId);
        IEnumerable<Entities.Donation> GetAllDonations();
        IEnumerable<Entities.Donation> GetNewDonations();
        Entities.Donation GetDonationById(int id);
        void AddEntity(object entity);
        bool SaveAll();
        IEnumerable<Entities.Donation> GetDonationsByUser(string username);
        City GetCityById(int id);
    }
}