using FeatureFoldersWebApp.Areas.Admin.Features.User.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeatureFoldersWebApp.Areas.Admin.Features.User
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private List<UserModel> UserList { get; set; }

        public UserController()
        {
            this.UserList = new List<UserModel>()
            {
                new UserModel()
                {
                    Id = 1,
                    Name = "John",
                    Age = 21,
                    City = "Bucharest"
                },
                new UserModel()
                {
                    Id = 2,
                    Name = "Justin",
                    Age = 44,
                    City = "New York"
                },
                new UserModel()
                {
                    Id = 3,
                    Name = "George",
                    Age = 46,
                    City = "London"
                }
            };
        }

        public IActionResult Index()
        {
            return View(this.UserList);
        }

        public IActionResult View(int? userId)
        {
            if (userId == null)
                return RedirectToAction(nameof(Index));

            var model = this.UserList.Where(c => c.Id == userId.Value).FirstOrDefault();

            if(model == null)
                return RedirectToAction(nameof(Index));

            return View(model);
        }

    }
}
