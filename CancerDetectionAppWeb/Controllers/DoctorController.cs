using Microsoft.AspNetCore.Mvc;

namespace CancerDetectionAppWeb.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult PatientsPage()
        {
            return View();
        }

        public IActionResult PatientResultDetail()
        {
            return View();
        }
    }
}
