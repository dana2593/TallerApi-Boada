using Microsoft.AspNetCore.Mvc;
using TallerApi_Boada.Repositories;

namespace TallerApi_Boada.Controllers
{
    public class CountryControllers : Controller
    {
        private CountryRepository _repo;
        public CountryControllers()
        {
            _repo = new CountryRepository();
        }
        public async Task<IActionResult> CountryList()
        {
            var countries = await _repo.GetCountryList();
            return View(countries);
        }
    }
}
