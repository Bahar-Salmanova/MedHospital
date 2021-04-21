namespace MedHospital
{
    partial class FormCallPerson
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Name = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtResponce = new System.Windows.Forms.RichTextBox();
            this.PersonId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnGet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(12, 32);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(22, 15);
            this.Name.TabIndex = 0;
            this.Name.Text = "Ad";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(12, 69);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(39, 15);
            this.Surname.TabIndex = 1;
            this.Surname.Text = "Soyad";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(12, 115);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(24, 15);
            this.Age.TabIndex = 2;
            this.Age.Text = "Yas";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(70, 34);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 23);
            this.TxtName.TabIndex = 3;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(70, 69);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(100, 23);
            this.TxtSurname.TabIndex = 4;
            // 
            // TxtAge
            // 
            this.TxtAge.Location = new System.Drawing.Point(70, 107);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(100, 23);
            this.TxtAge.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(542, 61);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(380, 79);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(461, 79);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(75, 23);
            this.btnGetAll.TabIndex = 8;
            this.btnGetAll.Text = "GET ALL";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(215, 68);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "+ ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtResponce
            // 
            this.txtResponce.Location = new System.Drawing.Point(-2, 328);
            this.txtResponce.Name = "txtResponce";
            this.txtResponce.Size = new System.Drawing.Size(784, 225);
            this.txtResponce.TabIndex = 11;
            this.txtResponce.Text = "";
            // 
            // PersonId
            // 
            this.PersonId.AutoSize = true;
            this.PersonId.Location = new System.Drawing.Point(17, 8);
            this.PersonId.Name = "PersonId";
            this.PersonId.Size = new System.Drawing.Size(17, 15);
            this.PersonId.TabIndex = 12;
            this.PersonId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(70, 5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 13;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(380, 111);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 14;
            this.BtnDelete.Text = "DELETE";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnGet
            // 
            this.BtnGet.Location = new System.Drawing.Point(461, 111);
            this.BtnGet.Name = "BtnGet";
            this.BtnGet.Size = new System.Drawing.Size(75, 23);
            this.BtnGet.TabIndex = 15;
            this.BtnGet.Text = "GET";
            this.BtnGet.UseVisualStyleBackColor = true;
            this.BtnGet.Click += new System.EventHandler(this.BtnGet_Click);
            // 
            // FormCallPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 598);
            this.Controls.Add(this.BtnGet);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.PersonId);
            this.Controls.Add(this.txtResponce);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Name);
            
            this.Text = "CallPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox txtResponce;
        private System.Windows.Forms.Label PersonId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnGet;
    }
}

