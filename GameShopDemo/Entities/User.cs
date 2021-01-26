using System;
using System.Collections.Generic;
using System.Text;

namespace GameShopDemo.Entities
{
    //Sistemi kullanacak kullanıcı ve özellikleri.
    public class User 
    {
        public int UserId { get; set; }
        public string NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
