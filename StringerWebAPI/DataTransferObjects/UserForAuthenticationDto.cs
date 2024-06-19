using System.ComponentModel.DataAnnotations;

namespace StringerWebAPI.DataTransferObjects
{
    public class UserForAuthenticationDto
    {
        //DTO used when logging in
        [Required(ErrorMessage = "Username is required.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }
    }
}
