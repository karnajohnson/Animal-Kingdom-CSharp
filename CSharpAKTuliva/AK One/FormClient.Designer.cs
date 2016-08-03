namespace AK_One
{
    partial class FormClient
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
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lstAnimalToCreate = new System.Windows.Forms.ListBox();
            this.lblAnimalToCreate = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.picAnimal = new System.Windows.Forms.PictureBox();
            this.grpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.btnExit);
            this.grpLogin.Controls.Add(this.txtPassword);
            this.grpLogin.Controls.Add(this.lblPassword);
            this.grpLogin.Controls.Add(this.btnSubmit);
            this.grpLogin.Controls.Add(this.lstAnimalToCreate);
            this.grpLogin.Controls.Add(this.lblAnimalToCreate);
            this.grpLogin.Controls.Add(this.txtFirstName);
            this.grpLogin.Controls.Add(this.txtLastName);
            this.grpLogin.Controls.Add(this.lblFirstName);
            this.grpLogin.Controls.Add(this.lblLastName);
            this.grpLogin.Location = new System.Drawing.Point(12, 24);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(285, 207);
            this.grpLogin.TabIndex = 0;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login Information";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(10, 178);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(268, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(128, 81);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(150, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 84);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(10, 107);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(268, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Log in";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lstAnimalToCreate
            // 
            this.lstAnimalToCreate.Enabled = false;
            this.lstAnimalToCreate.FormattingEnabled = true;
            this.lstAnimalToCreate.Items.AddRange(new object[] {
            "Duck",
            "Trout",
            "Human"});
            this.lstAnimalToCreate.Location = new System.Drawing.Point(153, 142);
            this.lstAnimalToCreate.Name = "lstAnimalToCreate";
            this.lstAnimalToCreate.ScrollAlwaysVisible = true;
            this.lstAnimalToCreate.Size = new System.Drawing.Size(120, 30);
            this.lstAnimalToCreate.TabIndex = 4;
            this.lstAnimalToCreate.SelectedIndexChanged += new System.EventHandler(this.lstAnimalToCreate_SelectedIndexChanged);
            // 
            // lblAnimalToCreate
            // 
            this.lblAnimalToCreate.AutoSize = true;
            this.lblAnimalToCreate.Location = new System.Drawing.Point(7, 142);
            this.lblAnimalToCreate.Name = "lblAnimalToCreate";
            this.lblAnimalToCreate.Size = new System.Drawing.Size(141, 13);
            this.lblAnimalToCreate.TabIndex = 4;
            this.lblAnimalToCreate.Text = "Enter The Animal To Create:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(127, 55);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(151, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(128, 29);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(150, 20);
            this.txtLastName.TabIndex = 0;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(7, 55);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(113, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Enter Your First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(7, 29);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(114, 13);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Enter Your Last Name:";
            // 
            // picAnimal
            // 
            this.picAnimal.Location = new System.Drawing.Point(323, 24);
            this.picAnimal.Name = "picAnimal";
            this.picAnimal.Size = new System.Drawing.Size(273, 207);
            this.picAnimal.TabIndex = 1;
            this.picAnimal.TabStop = false;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.BackgroundImage = global::AK_One.Properties.Resources.Poison_Green_Forest;
            this.ClientSize = new System.Drawing.Size(616, 265);
            this.Controls.Add(this.picAnimal);
            this.Controls.Add(this.grpLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(632, 303);
            this.MinimumSize = new System.Drawing.Size(632, 303);
            this.Name = "FormClient";
            this.Text = "Animal Kingdom";
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListBox lstAnimalToCreate;
        private System.Windows.Forms.Label lblAnimalToCreate;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.PictureBox picAnimal;
        private System.Windows.Forms.Button btnExit;
    }
}