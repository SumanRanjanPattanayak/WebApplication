using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        UserBLL userbll = new UserBLL();
        public ActionResult Index()
        {
            UserDTO dto = new UserDTO();
            return View(dto);
        }
        [HttpPost]
        public ActionResult Index(UserDTO model)
        {
            UserDTO user = userbll.GetUserWithUserNameAndPassword(model);
            return View(model);
        }
    }
}