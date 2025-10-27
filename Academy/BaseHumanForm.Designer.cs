namespace Academy
{
	partial class BaseHumanForm
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
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonBrowsPhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(430, 12);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(253, 324);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto.TabIndex = 44;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(145, 162);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(238, 22);
            this.dateTimePickerBirthDate.TabIndex = 43;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(145, 262);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(238, 22);
            this.textBoxPhone.TabIndex = 42;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(145, 212);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(238, 22);
            this.textBoxEmail.TabIndex = 41;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(145, 112);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(238, 22);
            this.textBoxMiddleName.TabIndex = 40;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(145, 62);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(238, 22);
            this.textBoxFirstName.TabIndex = 39;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(145, 12);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(238, 22);
            this.textBoxLastName.TabIndex = 38;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(71, 265);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(49, 16);
            this.labelPhone.TabIndex = 37;
            this.labelPhone.Text = "Phone:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(72, 215);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 16);
            this.labelEmail.TabIndex = 36;
            this.labelEmail.Text = "E-mail:";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(11, 165);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(109, 16);
            this.labelBirthDate.TabIndex = 35;
            this.labelBirthDate.Text = "Дата рождения:";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(47, 115);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(73, 16);
            this.labelMiddleName.TabIndex = 34;
            this.labelMiddleName.Text = "Отчество:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(84, 65);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(36, 16);
            this.labelFirstName.TabIndex = 33;
            this.labelFirstName.Text = "Имя:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(51, 15);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(69, 16);
            this.labelLastName.TabIndex = 32;
            this.labelLastName.Text = "Фамилия:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelID.Location = new System.Drawing.Point(22, 389);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(33, 25);
            this.labelID.TabIndex = 48;
            this.labelID.Text = "ID";
            this.labelID.Visible = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(603, 386);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(80, 30);
            this.buttonCancel.TabIndex = 47;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(430, 386);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(80, 30);
            this.buttonOK.TabIndex = 46;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonBrowsPhoto
            // 
            this.buttonBrowsPhoto.Location = new System.Drawing.Point(603, 342);
            this.buttonBrowsPhoto.Name = "buttonBrowsPhoto";
            this.buttonBrowsPhoto.Size = new System.Drawing.Size(80, 30);
            this.buttonBrowsPhoto.TabIndex = 45;
            this.buttonBrowsPhoto.Text = "Обзор...";
            this.buttonBrowsPhoto.UseVisualStyleBackColor = true;
            // 
            // BaseHumanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 453);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonBrowsPhoto);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.dateTimePickerBirthDate);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelLastName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BaseHumanForm";
            this.Text = "BaseHumanForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		protected System.Windows.Forms.PictureBox pictureBoxPhoto;
		protected System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
		protected System.Windows.Forms.TextBox textBoxPhone;
		protected System.Windows.Forms.TextBox textBoxEmail;
		protected System.Windows.Forms.TextBox textBoxMiddleName;
		protected System.Windows.Forms.TextBox textBoxFirstName;
		protected System.Windows.Forms.TextBox textBoxLastName;
		protected System.Windows.Forms.Label labelPhone;
		protected System.Windows.Forms.Label labelEmail;
		protected System.Windows.Forms.Label labelBirthDate;
		protected System.Windows.Forms.Label labelMiddleName;
		protected System.Windows.Forms.Label labelFirstName;
        protected System.Windows.Forms.Label labelLastName;
        protected System.Windows.Forms.Label labelID;
		protected System.Windows.Forms.Button buttonCancel;
		protected System.Windows.Forms.Button buttonOK;
		protected System.Windows.Forms.Button buttonBrowsPhoto;
	}
}