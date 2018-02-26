using FeatureFoldersWebApp.Features.Event.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeatureFoldersWebApp.Features.Event
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            var model = new EventListModel()
            {
                EventList = new List<EventModel>() {
                    new EventModel ()
                    {
                        Id = 1,
                        Name = "Event 1",
                        Value = 100
                    },
                    new EventModel ()
                    {
                        Id = 2,
                        Name = "Event 2",
                        Value = 200
                    },
                    new EventModel ()
                    {
                        Id = 3,
                        Name = "Event 3",
                        Value = 300
                    },
                    new EventModel ()
                    {
                        Id = 4,
                        Name = "Event 4",
                        Value = 400
                    }
                }
            };
            return View(model);
        }
    }
}
