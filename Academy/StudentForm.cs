using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
	public partial class StudentForm : Form
	{
		internal Student Student {  get; set; }
		Connector connector;
		public StudentForm()
		{
			InitializeComponent();
			connector = new Connector();
			DataTable groups = connector.Select("*", "Groups");
			comboBoxGroup.DataSource = groups;
			comboBoxGroup.DisplayMember = groups.Columns[1].ToString();
			comboBoxGroup.ValueMember = groups.Columns[0].ToString();

			InitForm();
        }
		public StudentForm(DataRow row) : this()
		{
			int stud_id = Convert.ToInt32(row[0]);
			DataTable student = connector.Select("*", "Students", $"stud_id={stud_id}");

			textBoxLastName.Text = student.Rows[0][1].ToString();
			textBoxFirstName.Text = student.Rows[0][2].ToString();
			textBoxMiddleName.Text = student.Rows[0][3].ToString();

			dateTimePickerBirthDate.Value = Convert.ToDateTime(student.Rows[0][4]);

			textBoxEmail.Text = student.Rows[0][5].ToString();
			textBoxPhone.Text = student.Rows[0][6].ToString();

			comboBoxGroup.SelectedValue = student.Rows[0][8].ToString();
			labelID.Visible = true;
			labelID.Text = $"ID: {student.Rows[0][0].ToString()}";
        }
		void InitForm()
		{
            textBoxLastName.Text = "Леонтьева";
            textBoxFirstName.Text = "Шарлотта";
            textBoxMiddleName.Text = "Владимировна";
			dateTimePickerBirthDate.Value = new DateTime(2007, 07, 08);
            textBoxEmail.Text = "sharlotta@gmail.com";
            textBoxPhone.Text = "+7(123)4567788";
            comboBoxGroup.SelectedIndex = 10;
        }
		void Compress()
		{
			Student.LastName = textBoxLastName.Text;
			Student.FirstName = textBoxFirstName.Text;
			Student.MiddleName = textBoxMiddleName.Text;
			Student.Email = textBoxEmail.Text;
			Student.Phone = textBoxPhone.Text;
			Student.Group = Convert.ToInt32(comboBoxGroup.SelectedValue);
		}
		private void buttonOK_Click(object sender, EventArgs e)
		{
			Student = new Student
				(
					textBoxLastName.Text,
					textBoxFirstName.Text,
					textBoxMiddleName.Text,
					dateTimePickerBirthDate.Text,
					textBoxEmail.Text,
					textBoxPhone.Text,
                    Convert.ToInt32(comboBoxGroup.SelectedValue)
                );
		}
	}
}
