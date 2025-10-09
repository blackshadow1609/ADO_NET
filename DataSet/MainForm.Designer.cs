namespace DataSet
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.comboBoxStudentsGroups = new System.Windows.Forms.ComboBox();
            this.comboBoxStudentsDirections = new System.Windows.Forms.ComboBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPageDisciplines = new System.Windows.Forms.TabPage();
            this.comboBoxDisciplinesForDirection = new System.Windows.Forms.ComboBox();
            this.dataGridViewDisciplines = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageDisciplines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisciplines)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxStudentsGroups
            // 
            this.comboBoxStudentsGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStudentsGroups.FormattingEnabled = true;
            this.comboBoxStudentsGroups.Location = new System.Drawing.Point(7, 8);
            this.comboBoxStudentsGroups.Name = "comboBoxStudentsGroups";
            this.comboBoxStudentsGroups.Size = new System.Drawing.Size(237, 24);
            this.comboBoxStudentsGroups.TabIndex = 0;
            // 
            // comboBoxStudentsDirections
            // 
            this.comboBoxStudentsDirections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStudentsDirections.FormattingEnabled = true;
            this.comboBoxStudentsDirections.Location = new System.Drawing.Point(259, 8);
            this.comboBoxStudentsDirections.Name = "comboBoxStudentsDirections";
            this.comboBoxStudentsDirections.Size = new System.Drawing.Size(385, 24);
            this.comboBoxStudentsDirections.TabIndex = 1;
            this.comboBoxStudentsDirections.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudentsDirections_SelectedIndexChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPageDisciplines);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 407);
            this.tabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBoxStudentsGroups);
            this.tabPage1.Controls.Add(this.comboBoxStudentsDirections);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 378);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 378);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPageDisciplines
            // 
            this.tabPageDisciplines.Controls.Add(this.dataGridViewDisciplines);
            this.tabPageDisciplines.Controls.Add(this.comboBoxDisciplinesForDirection);
            this.tabPageDisciplines.Location = new System.Drawing.Point(4, 25);
            this.tabPageDisciplines.Name = "tabPageDisciplines";
            this.tabPageDisciplines.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDisciplines.Size = new System.Drawing.Size(768, 378);
            this.tabPageDisciplines.TabIndex = 3;
            this.tabPageDisciplines.Text = "Disciplines";
            this.tabPageDisciplines.UseVisualStyleBackColor = true;
            // 
            // comboBoxDisciplinesForDirection
            // 
            this.comboBoxDisciplinesForDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDisciplinesForDirection.FormattingEnabled = true;
            this.comboBoxDisciplinesForDirection.Location = new System.Drawing.Point(210, 6);
            this.comboBoxDisciplinesForDirection.Name = "comboBoxDisciplinesForDirection";
            this.comboBoxDisciplinesForDirection.Size = new System.Drawing.Size(393, 24);
            this.comboBoxDisciplinesForDirection.TabIndex = 0;
            this.comboBoxDisciplinesForDirection.SelectedIndexChanged += new System.EventHandler(this.comboBoxDisciplinesForDirection_SelectedIndexChanged);
            // 
            // dataGridViewDisciplines
            // 
            this.dataGridViewDisciplines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDisciplines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisciplines.Location = new System.Drawing.Point(7, 39);
            this.dataGridViewDisciplines.Name = "dataGridViewDisciplines";
            this.dataGridViewDisciplines.RowHeadersWidth = 51;
            this.dataGridViewDisciplines.RowTemplate.Height = 24;
            this.dataGridViewDisciplines.Size = new System.Drawing.Size(755, 333);
            this.dataGridViewDisciplines.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPageDisciplines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisciplines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxStudentsGroups;
		private System.Windows.Forms.ComboBox comboBoxStudentsDirections;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPageDisciplines;
		private System.Windows.Forms.ComboBox comboBoxDisciplinesForDirection;
		private System.Windows.Forms.DataGridView dataGridViewDisciplines;
	}
}

