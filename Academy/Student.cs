using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Academy
{
	internal class Student
	{
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string BirthDate { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public int Group { get; set; }
		public Image Photo { get; set; }
		public Student() { }
		public Student(string last_name, string first_name, string middle_name, string birth_date, string email, string phone, int group, Image photo)
		{
			LastName = last_name;
			FirstName = first_name;
			MiddleName = middle_name;
			BirthDate = birth_date;
			Email = email;
			Phone = phone;
			Group = group;
			Photo = photo;
			//Photo = SerializePhoto(photo);
		}
		public byte[] SerializePhoto()
		{
			MemoryStream ms = new MemoryStream();
			Photo.Save(ms, Photo.RawFormat);
			return ms.ToArray();
		}

		public override string ToString()
		{
			return $"N'{LastName}',N'{FirstName}',N'{MiddleName}','{BirthDate}',N'{Email}',N'{Phone}',{Group}";
		}
		public string ToStringUpdate()
		{
			return $@"
                        last_name=N'{LastName}',
                        first_name=N'{FirstName}',
                        middle_name=N'{MiddleName}',
                        birth_date='{BirthDate}',
                        email=N'{Email}',
                        phone=N'{Phone}',
                        [group]={Group}
                    ";
		}

	}
}
