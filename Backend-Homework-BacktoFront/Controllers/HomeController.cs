using Backend_Homework_BacktoFront.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Homework_BacktoFront.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Slider> sliders = new List<Slider>()
            {
                new Slider
                {
                    //shekil backgrounddadi deye ~/ edib cagiranda alinmirdi, ona gore url linki ile yazdim.
                    Image="https://oceanvisions.org/wp-content/uploads/2021/09/joseph-barrientos-oQl0eVYd_n8-unsplash-Custom.jpg",
                    Title="Ocean",
                    SubTitle="Be bold, be you. Celebrate pride with the adidas x Kris Andrew Small collab.",
                    Link="http://www.facebook.com"
                },
                new Slider
                {
                    Image="https://img.freepik.com/free-vector/sunset-sunrise-ocean-nature-landscape_33099-2244.jpg",
                    Title="Sunset",
                    SubTitle="Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptatum ipsam rem quia possimus ea, eius a iste nisi ducimus adipisci.",
                    Link="http://www.shazam.com"
                },
                new Slider
                {
                    Image="https://ychef.files.bbci.co.uk/976x549/p07ryyyj.jpg",
                    Title="Cat",
                    SubTitle="Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptatum ipsam rem quia possimus ea, eius a iste nisi ",
                    Link="http://www.youtube.com"
                }


            };
            return View(sliders);
        }
    }
}
