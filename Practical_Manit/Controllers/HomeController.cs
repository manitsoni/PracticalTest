using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practical_Manit.Models;
namespace Practical_Manit.Controllers
{
    public class HomeController : Controller
    {
        List<User> usermodel = new List<User>();
        private bool Add = true;
        public void AddData()
        {        
            User user = new User();
            user.UserId = 1;
            user.Name = "Manit";
            user.DisplayOrder = 1;
            usermodel.Add(user);

            user = new User();
            user.UserId = 2;
            user.Name = "Parth";
            user.DisplayOrder = 2;
            usermodel.Add(user);

            user = new User();
            user.UserId = 3;
            user.Name = "Hem";
            user.DisplayOrder = 3;
            usermodel.Add(user);

            user = new User();
            user.UserId = 4;
            user.Name = "Jay";
            user.DisplayOrder = 4;
            usermodel.Add(user);

            user = new User();
            user.UserId = 5;
            user.Name = "Pavan";
            user.DisplayOrder = 5;
            usermodel.Add(user);
        }
        public ActionResult Index()
        {
            AddData();
            TempData["msg"] = "";
            ViewBag.userlist = usermodel.OrderBy(m => m.DisplayOrder).ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Index(int[] txtId, string[] txtName, int[] txtOrder)
        {
            int cntr = txtId.Count();
            List<User> usermodel = new List<User>();
            User user = new User();
            for (int i = 0; i < cntr; i++)
            {
                user = new User();
                user.UserId = txtId[i];
                user.Name = txtName[i];
                user.DisplayOrder = txtOrder[i];
                usermodel.Add(user);
            }
            TempData["msg"] = "Update user's data success";
            ViewBag.userlist = usermodel.OrderBy(m => m.DisplayOrder).ToList();
            return View();
        }
       
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}