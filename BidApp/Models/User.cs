using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BidApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public User(int id, string name, string password, string email)
        {
            Id = id;
            Name = name;

            //TODO Hash this password
            Password = password;
            Email = email;
        }

        public User() { }


    }
}