using System.Collections.Generic;

namespace mluvii.ApiModels.Users
{
    public class UserModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public bool Enabled { get; set; }

        public ICollection<int> Departments { get; set; }

        public ICollection<string> GlobalRoles { get; set; }
    }
}
