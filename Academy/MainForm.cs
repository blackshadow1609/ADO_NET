using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Academy
{
	public partial class MainForm : Form
	{
			string connectionString = "Data Source=DESKTOP-I644S2M\\SQLEXPRESS;Initial Catalog=PD_321_HW;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
			SqlConnection connection;
		public MainForm()
		{
			InitializeComponent();
			connection = new SqlConnection(connectionString);
			LoadDirections();
		}
		void LoadDirections()
		{
			string cmd = "SELECT * FROM Directions";
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			DataTable table = new DataTable();
			for (int i = 0; i < reader.FieldCount; i++)
				table.Columns.Add(reader.GetName(i));
			while (reader.Read())
			{
				DataRow row = table.NewRow();
				for (int i = 0; i < reader.FieldCount; i++)
					row[i] = reader[i];
				table.Rows.Add(row);
			}
			reader.Close();
			connection.Close();
			dataGridViewDirections.DataSource = table;
		}
	}
}
