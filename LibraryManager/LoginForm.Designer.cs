namespace LibraryManager
{
    partial class LoginForm
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
            this.FirstNameField = new System.Windows.Forms.TextBox();
            this.LastNameField = new System.Windows.Forms.TextBox();
            this.ThirdName = new System.Windows.Forms.TextBox();
            this.PhoneNumberField = new System.Windows.Forms.TextBox();
            this.AddresField = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNameField
            // 
            this.FirstNameField.Location = new System.Drawing.Point(316, 122);
            this.FirstNameField.Name = "FirstNameField";
            this.FirstNameField.Size = new System.Drawing.Size(167, 20);
            this.FirstNameField.TabIndex = 0;
            // 
            // LastNameField
            // 
            this.LastNameField.Location = new System.Drawing.Point(316, 148);
            this.LastNameField.Name = "LastNameField";
            this.LastNameField.Size = new System.Drawing.Size(167, 20);
            this.LastNameField.TabIndex = 1;
            // 
            // ThirdName
            // 
            this.ThirdName.Location = new System.Drawing.Point(316, 174);
            this.ThirdName.Name = "ThirdName";
            this.ThirdName.Size = new System.Drawing.Size(167, 20);
            this.ThirdName.TabIndex = 2;
            // 
            // PhoneNumberField
            // 
            this.PhoneNumberField.Location = new System.Drawing.Point(316, 200);
            this.PhoneNumberField.Name = "PhoneNumberField";
            this.PhoneNumberField.Size = new System.Drawing.Size(167, 20);
            this.PhoneNumberField.TabIndex = 3;
            // 
            // AddresField
            // 
            this.AddresField.Location = new System.Drawing.Point(316, 226);
            this.AddresField.Name = "AddresField";
            this.AddresField.Size = new System.Drawing.Size(167, 20);
            this.AddresField.TabIndex = 4;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(366, 303);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.AddresField);
            this.Controls.Add(this.PhoneNumberField);
            this.Controls.Add(this.ThirdName);
            this.Controls.Add(this.LastNameField);
            this.Controls.Add(this.FirstNameField);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNameField;
        private System.Windows.Forms.TextBox LastNameField;
        private System.Windows.Forms.TextBox ThirdName;
        private System.Windows.Forms.TextBox PhoneNumberField;
        private System.Windows.Forms.TextBox AddresField;
        private System.Windows.Forms.Button LoginButton;
    }
}