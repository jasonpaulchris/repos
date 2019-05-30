using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreVideo.Controllers
{
    [Route("company/[controller]/[action]")]
    public class EmployeeController : Controller
    {

        public ContentResult Name()
        {
            return Content("Jonas");
        }


        public ContentResult Country()
        {
            return Content("US");
        }

        public ContentResult Index()
        {
            return Content("Hello from employee");
        }
    }
}
