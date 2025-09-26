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
            LoadGroups();
            LoadDirectionsToComboBox();
        }
        //Direction--------------------------------------------------
        void LoadDirections()
        {
            string cmd =
                @"
					SELECT direction_id AS N'ID', direction_name AS N'Направление обучения', COUNT(group_id) AS N'Количество групп'
					FROM Groups
					RIGHT JOIN Directions ON (direction=direction_id)
					GROUP BY direction_id, direction_name;
				";

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
        //Groups-------------------------------------------------------
        void LoadGroups()
        {
            string cmd =
                @"
					SELECT group_id AS N'ID', group_name AS N'Группа', COUNT(stud_id) AS N'Количество студентов',direction_name AS N'Направление обучения'
					FROM Students 
                    RIGHT JOIN Groups ON ([group]=group_id)
                    JOIN Directions ON (direction=direction_id)
					GROUP BY group_id, group_name, direction, direction_name;
				";

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
            dataGridViewGroups.DataSource = table;
        }
        void LoadDirectionsToComboBox()
        {
            string cmd = "SELECT * FROM Directions";
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBoxGroupsDirection.Items.Add(reader[1]);
            }
            reader.Close();
            connection.Close();
        }

        //Disciplines-----------------------------------------------------
    }
}
