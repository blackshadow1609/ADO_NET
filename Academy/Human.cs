using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Academy
{
    internal class Human
	{
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Image Photo { get; set; }
        public Human() { }
        public Human(string last_name, string first_name, string middle_name, string birth_date, string email, string phone, Image photo)
        {
            LastName = last_name;
            FirstName = first_name;
            MiddleName = middle_name;
            BirthDate = birth_date;
            Email = email;
            Phone = phone;
            Photo = photo;
        }
        public byte[] SerializePhoto()
        {
            MemoryStream ms = new MemoryStream();
            Photo.Save(ms, Photo.RawFormat);
            return ms.ToArray();
        }

        public override string ToString()
        {
            return $"N'{LastName}',N'{FirstName}',N'{MiddleName}','{BirthDate}',N'{Email}',N'{Phone}'";
        }
        public virtual string ToStringUpdate()
        {
            return $@"
                        last_name=N'{LastName}',
                        first_name=N'{FirstName}',
                        middle_name=N'{MiddleName}',
                        birth_date='{BirthDate}',
                        email=N'{Email}',
                        phone=N'{Phone}'
                    ";
        }
    }
}
