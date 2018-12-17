using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjekt
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public bool IsAdmin { get; set; }

        public User(int id, string name, string mail, bool isAdmin)
        {
            Id = id;
            Name = name;
            Mail = mail;
            IsAdmin = isAdmin;
        }
        public User()
        {

        }
            static DateTime d = DateTime.Now;
        //Booking lend = new Booking(DateTime.Now, d.Add(new TimeSpan(7, 0, 0, 0)),);
        //Booking lend = new Booking(DateTime.Now, d.Add(new TimeSpan(7, 0, 0, 0)), new Product(2,"Harry Potter 15", false));
        public void Lend(int Duration, Product product)
        {
            User person = new User(1,"Klaus","Klaus@admin.tv", true);
            Product bog = new Product(1, "Harry Potter - 2", true);
            Booking booking = new Booking(DateTime.Now, Duration, bog);
            product.FlipAvailability();
            DAL.Lend(booking,product,person);
        }

        
        
        
    }
}
