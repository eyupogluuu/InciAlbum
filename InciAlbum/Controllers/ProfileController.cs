using InciAlbum.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace InciAlbum.Controllers
{

	public class ProfileController : Controller
	{
		private readonly UserManager<IdentityUser> userManager;

		public ProfileController(UserManager<IdentityUser> userManager)
		{
			this.userManager = userManager;
		}
		[HttpGet]
		public async Task<IActionResult> Index()
		{
			var values = await userManager.FindByNameAsync(User.Identity.Name);
			UserEditViewModel userEdit = new UserEditViewModel();
			userEdit.mail = values.Email;
			userEdit.phone = values.PhoneNumber;
			; return View(userEdit);
		}
		[HttpPost]
		public async Task<IActionResult> Index(UserEditViewModel userEdit)
		{
            var values = await userManager.FindByNameAsync(User.Identity.Name);
			if (userEdit.password== userEdit.password)
			{
                values.PhoneNumber = userEdit.phone;
                values.Email = userEdit.mail;
                values.PasswordHash = userManager.PasswordHasher.HashPassword(values, userEdit.password);
                var result = await userManager.UpdateAsync(values);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
            }
			return View();
			
        }
	}
}
