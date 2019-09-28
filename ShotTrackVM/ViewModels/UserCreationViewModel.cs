
using ShotTrackVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ShotTrackVM.ViewModels
{
    public class UserCreationViewModel
    {
        public UserModel NewUser { get; set; }

        static HttpClient client = new HttpClient();

        static async Task<Uri> CreateUserAsync(UserModel newUser)
        {
            newUser.Username = 
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri("https://localhost:44354/api/User/Verify");
                client.DefaultRequestHeaders.Accept.Clear();

            }
        }
        //Function for calling the password check endpoint
        //Function for calling the create new user endpoint





    }
}
