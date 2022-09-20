using Auction.Models;
using Auction.Models.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Auction.Controllers
{
    [Authorize]
    public class LotController : Controller
    {
        IWebHostEnvironment _webHostEnviroment;
        ILotService _service;
        IUserService _userService;
        public LotController(IWebHostEnvironment webHostEnviroment, ILotService service, IUserService userService) 
        {
            _webHostEnviroment = webHostEnviroment;
            _service = service;
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Create()
        {
            return await Task.FromResult(View());
        }
        [HttpPost]
        public async Task<IActionResult> Create(Lot lot)
        {
            var email = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress").Value;
            if (lot.Picture != null)
            {
                string folder = "Images/" + Guid.NewGuid().ToString() + lot.Picture.FileName;//defining the name of the file uniquely
                string serverFolder = Path.Combine(_webHostEnviroment.WebRootPath, folder);//path of the project with the folder

                await lot.Picture.CopyToAsync(new FileStream(serverFolder, FileMode.Create));//copying file into the wwwroot folder

                lot.PictureUrl = folder;
            }
            lot.UserId = _userService.GetUserId(email);
            await _service.AddAsynnc(lot);
            return RedirectToAction("Index", "Home");
        }
    }
}
