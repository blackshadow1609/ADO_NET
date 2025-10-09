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
            this.SuspendLayout();
            // 
            // comboBoxStudentsGroups
            // 
            this.comboBoxStudentsGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStudentsGroups.FormattingEnabled = true;
            this.comboBoxStudentsGroups.Location = new System.Drawing.Point(12, 12);
            this.comboBoxStudentsGroups.Name = "comboBoxStudentsGroups";
            this.comboBoxStudentsGroups.Size = new System.Drawing.Size(370, 24);
            this.comboBoxStudentsGroups.TabIndex = 0;
            // 
            // comboBoxStudentsDirections
            // 
            this.comboBoxStudentsDirections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStudentsDirections.FormattingEnabled = true;
            this.comboBoxStudentsDirections.Location = new System.Drawing.Point(405, 12);
            this.comboBoxStudentsDirections.Name = "comboBoxStudentsDirections";
            this.comboBoxStudentsDirections.Size = new System.Drawing.Size(383, 24);
            this.comboBoxStudentsDirections.TabIndex = 1;
            this.comboBoxStudentsDirections.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudentsDirections_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxStudentsDirections);
            this.Controls.Add(this.comboBoxStudentsGroups);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxStudentsGroups;
		private System.Windows.Forms.ComboBox comboBoxStudentsDirections;
	}
}

