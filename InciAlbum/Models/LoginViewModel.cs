using System.ComponentModel.DataAnnotations;

namespace InciAlbum.Models
{
	public class LoginViewModel
	{
        [Required(ErrorMessage ="Lütfen Kullanıcı Adı Giriniz")]
        public string username { get; set; }
		[Required(ErrorMessage = "Lütfen Şifre  Giriniz")]
		public string password { get; set; }
    }
}
