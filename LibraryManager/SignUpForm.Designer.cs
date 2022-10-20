namespace LibraryManager
{
    partial class SignUpForm
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.AddresField = new System.Windows.Forms.TextBox();
            this.PhoneNumberField = new System.Windows.Forms.TextBox();
            this.ThirdName = new System.Windows.Forms.TextBox();
            this.LastNameField = new System.Windows.Forms.TextBox();
            this.FirstNameField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(331, 324);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(126, 23);
            this.LoginButton.TabIndex = 11;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // AddresField
            // 
            this.AddresField.Location = new System.Drawing.Point(317, 227);
            this.AddresField.Name = "AddresField";
            this.AddresField.Size = new System.Drawing.Size(167, 20);
            this.AddresField.TabIndex = 10;
            // 
            // PhoneNumberField
            // 
            this.PhoneNumberField.Location = new System.Drawing.Point(317, 201);
            this.PhoneNumberField.Name = "PhoneNumberField";
            this.PhoneNumberField.Size = new System.Drawing.Size(167, 20);
            this.PhoneNumberField.TabIndex = 9;
            // 
            // ThirdName
            // 
            this.ThirdName.Location = new System.Drawing.Point(317, 175);
            this.ThirdName.Name = "ThirdName";
            this.ThirdName.Size = new System.Drawing.Size(167, 20);
            this.ThirdName.TabIndex = 8;
            // 
            // LastNameField
            // 
            this.LastNameField.Location = new System.Drawing.Point(317, 149);
            this.LastNameField.Name = "LastNameField";
            this.LastNameField.Size = new System.Drawing.Size(167, 20);
            this.LastNameField.TabIndex = 7;
            // 
            // FirstNameField
            // 
            this.FirstNameField.Location = new System.Drawing.Point(317, 123);
            this.FirstNameField.Name = "FirstNameField";
            this.FirstNameField.Size = new System.Drawing.Size(167, 20);
            this.FirstNameField.TabIndex = 6;
            // 
            // SignUpForm
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
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox AddresField;
        private System.Windows.Forms.TextBox PhoneNumberField;
        private System.Windows.Forms.TextBox ThirdName;
        private System.Windows.Forms.TextBox LastNameField;
        private System.Windows.Forms.TextBox FirstNameField;
    }
}