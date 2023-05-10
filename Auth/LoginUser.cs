using System.ComponentModel.DataAnnotations;

namespace WebApiTrainingDetail.Auth
{
    public class LoginUser
    {
       
        public string? UserName { get; set; }
        public string? Password { get; set; }
    }
}
