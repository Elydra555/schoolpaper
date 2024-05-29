using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class People
    {
        public class User
        {
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            public string Name { get; set; }
            public string Age { get; set; }
            public string City { get; set; }
            public string Position { get; set; }
            public string Hobby { get; set; }

            public User()
            {
            }

            public User(string sor)
            {
                string[] t = sor.Split(';');
                Name = t[0];
                Age = t[1];
                City = t[2];
                Position = t[3];
                Hobby = t[4];
            }

            public override string? ToString()
            {
                return $"{Name}, neve a(z) {City} városban lakik, {Position}-ként dolgozik, {Age} éves, hobbija: {Hobby}.";
            }
        }
    }
}
