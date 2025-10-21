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
	internal class Student : Human
	{
		public int Group { get; set; }
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
		}
		public override string ToString()
		{
			return $"{base.ToString()},{Group}";
		}
		public override string ToStringUpdate()
		{
			return $"{base.ToStringUpdate()},[group]={Group}";
		}
	}
}
