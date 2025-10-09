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
using System.Configuration;
using System.Runtime.InteropServices;


namespace DataSet
{
	public partial class MainForm : Form
	{
		string connectionString = "";
		SqlConnection connection = null;
		System.Data.DataSet GroupsRelatedData = null;
		public MainForm()
		{
			InitializeComponent();
			connectionString = ConfigurationManager.ConnectionStrings["PD_321_HW"].ConnectionString;
			connection = new SqlConnection(connectionString);

			//1) Создаем DataSet:
			GroupsRelatedData = new System.Data.DataSet(nameof(GroupsRelatedData));

			//2) Добавляем таблицы в DataSet:
			const string dsTable_Directions				  = "Directions";
			const string dstDirections_col_direction_id	  = "direction_id";
			const string dstDirections_col_direction_name = "direction_name";

			GroupsRelatedData.Tables.Add(dsTable_Directions);
			//Добавляем поля в таблицу:
			GroupsRelatedData.Tables[dsTable_Directions].Columns.Add(dstDirections_col_direction_id);
			GroupsRelatedData.Tables[dsTable_Directions].Columns.Add(dstDirections_col_direction_name);
			//Выбираем первичный ключ из существующих полей:
			GroupsRelatedData.Tables[dsTable_Directions].PrimaryKey =
				new DataColumn[] { GroupsRelatedData.Tables[dsTable_Directions].Columns[dstDirections_col_direction_id] };

			const string dsTable_Groups				 = "Groups";
			const string dstGroups_col_group_id		 = "group_id";
			const string dstGroups_col_group_name	 = "group_name";
			const string dstGroups_col_direction	 = "direction";
			const string dstGroups_col_learning_days = "learning_days";
			const string dstGroups_col_start_time	 = "start_time";

            GroupsRelatedData.Tables.Add(dsTable_Groups);
            //Добавляем поля в таблицу:
            GroupsRelatedData.Tables[dsTable_Groups].Columns.Add(dstGroups_col_group_id);
            GroupsRelatedData.Tables[dsTable_Groups].Columns.Add(dstGroups_col_group_name);
            GroupsRelatedData.Tables[dsTable_Groups].Columns.Add(dstGroups_col_direction);
            GroupsRelatedData.Tables[dsTable_Groups].Columns.Add(dstGroups_col_learning_days);
            GroupsRelatedData.Tables[dsTable_Groups].Columns.Add(dstGroups_col_start_time);
            //Выбираем первичный ключ из существующих полей:
            GroupsRelatedData.Tables[dsTable_Groups].PrimaryKey =
                new DataColumn[] { GroupsRelatedData.Tables[dsTable_Groups].Columns[dstGroups_col_group_id] };

			//3) Строим связи между таблицами:
			string dsRelation_GroupsDirections = "GroupsDiretions";
			GroupsRelatedData.Relations.Add
				(
					dsRelation_GroupsDirections,
					GroupsRelatedData.Tables[dsTable_Directions].Columns[dstDirections_col_direction_id],	//Parent field (Primary key)
					GroupsRelatedData.Tables[dsTable_Groups].Columns[dstGroups_col_direction]				//Child field (Foreig key)
				);

			//4) Загружаем данные в таблицу:
			string directions_cmd	= "SELECT * FROM Directions";
			string groups_cmd		= "SELECT * FROM Groups";

			SqlDataAdapter directionsAdapter = new SqlDataAdapter(directions_cmd, connection);
			SqlDataAdapter groupsAdapter = new SqlDataAdapter(groups_cmd, connection);

			directionsAdapter.Fill(GroupsRelatedData.Tables[dsTable_Directions]);
			groupsAdapter.Fill(GroupsRelatedData.Tables[dsTable_Groups]);

			AllocConsole();
			foreach(DataRow row in GroupsRelatedData.Tables[dsTable_Directions].Rows)
			{
				Console.WriteLine($"{row[dstDirections_col_direction_id]}\t{row[dstDirections_col_direction_name]}");
			}
			Console.WriteLine("\n=================================================\n");
			
			DataRow[] RPO = GroupsRelatedData.Tables[dsTable_Directions].Rows[0].GetChildRows(dsRelation_GroupsDirections);
            for (int i = 0; i < RPO.Length; i++)
			{
				for (int j = 0; j < RPO[i].ItemArray.Length; j++)
				{
					Console.Write($"{RPO[i].ItemArray[j]}\t\t");
				}
				Console.WriteLine();
			}
			comboBoxStudentsGroups.DataSource = GroupsRelatedData.Tables[dsTable_Groups];
			comboBoxStudentsGroups.DisplayMember = GroupsRelatedData.Tables[dsTable_Groups].Columns[dstGroups_col_group_name].ToString();
			comboBoxStudentsGroups.ValueMember = GroupsRelatedData.Tables[dsTable_Groups].Columns[dstGroups_col_group_id].ToString();

            comboBoxStudentsDirections.DataSource = GroupsRelatedData.Tables[dsTable_Directions];
            comboBoxStudentsDirections.DisplayMember = GroupsRelatedData.Tables[dsTable_Directions].Columns[dstDirections_col_direction_name].ToString();
            comboBoxStudentsDirections.ValueMember = GroupsRelatedData.Tables[dsTable_Directions].Columns[dstDirections_col_direction_id].ToString();

			comboBoxStudentsGroups.SelectedIndexChanged += new EventHandler(GetKeyValue);
			comboBoxStudentsDirections.SelectedIndexChanged += new EventHandler(GetKeyValue);


        }
		void GetKeyValue(object sender, EventArgs e)
		{
			Console.WriteLine($"{(sender as ComboBox).Name}:\t{(sender as ComboBox).SelectedValue}");
		}

		[DllImport("kernel32.dll")]
		public static extern bool AllocConsole();
		[DllImport("kernel32.dll")]
		public static extern bool FreeConsole();

		private void comboBoxStudentsDirections_SelectedIndexChanged(object sender, EventArgs e)
		{
			comboBoxStudentsGroups.DataSource = 
				GroupsRelatedData.Tables["Groups"].Select
				(
					$"direction={comboBoxStudentsDirections.SelectedValue}"
				).CopyToDataTable();
		}
	}
}
