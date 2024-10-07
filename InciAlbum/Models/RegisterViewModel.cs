using System.ComponentModel.DataAnnotations;

namespace InciAlbum.Models
{
	public class RegisterViewModel
	{
        [Required(ErrorMessage ="Lütfen Kullanıcı Adını Giriniz")]
        public string username { get; set; }

		[Required(ErrorMessage = "Lütfen Mail Adresinizi Giriniz")]
		public string mail { get; set; }

		[Required(ErrorMessage = "Lütfen Şifrenizi Giriniz")]
		public string password { get; set; }

		[Required(ErrorMessage = "Lütfen Şifrenizi Tekrar Giriniz")]
		[Compare("password",ErrorMessage = "Lütfen Şifre Uyumluluğunu Kontrol Ediniz")]
		public string confirmPassword { get; set; }
    }
}
