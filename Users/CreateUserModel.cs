using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Users
{
    public class CreateUserModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }

        /// <summary>
        /// Optional.
        /// Force user to authenticate using an openid provider.
        /// The user won't be able to set and use a password.
        /// </summary>
        public OpenIDProvider? OpenIDProvider { get; set; }
    }
}
