using Microsoft.AspNetCore.Mvc;
using Stuffmanagement2.Models;
using Stuffmanagement2.ViewModels;

namespace Stuffmanagement2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStaffRepository _staffRepository;

        public HomeController(IStaffRepository staffRepository)
        {
            _staffRepository = staffRepository;
        }
        public ViewResult Index()
        {
            var model = _staffRepository.GetAll();
            HomeIndexViewModel indexViewModel = new()
            {
                Staffs = _staffRepository.GetAll()
            };
            return View(indexViewModel);
        }

        public JsonResult Data()
        {
            return Json(new { id = 17, firstname = "Hoji", lastname = "nimadur" });
        }

        public ViewResult Details()
        {
            HomeDetailsViewModel viewModel = new HomeDetailsViewModel()
            {
                Staff = _staffRepository.Get(3),
                Title = "STAFFFFFFFF"
            };



            return View(viewModel);
        }

        public string Staff()
        {
            return _staffRepository.Get(3)?.Email;
        }
    }
}
