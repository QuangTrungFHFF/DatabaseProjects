namespace FormUI
{
    partial class Dashboard
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
            this.peopleFoundListbox = new System.Windows.Forms.ListBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNameLable = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.firstName = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameInText = new System.Windows.Forms.TextBox();
            this.emailLable = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.genderLable = new System.Windows.Forms.Label();
            this.genderText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.creditcardText = new System.Windows.Forms.TextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peopleFoundListbox
            // 
            this.peopleFoundListbox.FormattingEnabled = true;
            this.peopleFoundListbox.ItemHeight = 25;
            this.peopleFoundListbox.Location = new System.Drawing.Point(53, 193);
            this.peopleFoundListbox.Name = "peopleFoundListbox";
            this.peopleFoundListbox.Size = new System.Drawing.Size(404, 354);
            this.peopleFoundListbox.TabIndex = 0;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(190, 105);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(267, 31);
            this.lastNameText.TabIndex = 1;
            // 
            // lastNameLable
            // 
            this.lastNameLable.AutoSize = true;
            this.lastNameLable.Location = new System.Drawing.Point(53, 108);
            this.lastNameLable.Name = "lastNameLable";
            this.lastNameLable.Size = new System.Drawing.Size(121, 25);
            this.lastNameLable.TabIndex = 2;
            this.lastNameLable.Text = "Last Name:";
            this.lastNameLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(541, 105);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 31);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(693, 105);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(122, 25);
            this.firstName.TabIndex = 5;
            this.firstName.Text = "First Name:";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(830, 102);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(267, 31);
            this.firstNameText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(693, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name:";
            // 
            // lastNameInText
            // 
            this.lastNameInText.Location = new System.Drawing.Point(830, 160);
            this.lastNameInText.Name = "lastNameInText";
            this.lastNameInText.Size = new System.Drawing.Size(267, 31);
            this.lastNameInText.TabIndex = 6;
            // 
            // emailLable
            // 
            this.emailLable.AutoSize = true;
            this.emailLable.Location = new System.Drawing.Point(693, 223);
            this.emailLable.Name = "emailLable";
            this.emailLable.Size = new System.Drawing.Size(71, 25);
            this.emailLable.TabIndex = 9;
            this.emailLable.Text = "Email:";
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(830, 220);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(267, 31);
            this.emailText.TabIndex = 8;
            // 
            // genderLable
            // 
            this.genderLable.AutoSize = true;
            this.genderLable.Location = new System.Drawing.Point(693, 278);
            this.genderLable.Name = "genderLable";
            this.genderLable.Size = new System.Drawing.Size(89, 25);
            this.genderLable.TabIndex = 11;
            this.genderLable.Text = "Gender:";
            // 
            // genderText
            // 
            this.genderText.Location = new System.Drawing.Point(830, 275);
            this.genderText.Name = "genderText";
            this.genderText.Size = new System.Drawing.Size(267, 31);
            this.genderText.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(693, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Credit card:";
            // 
            // creditcardText
            // 
            this.creditcardText.Location = new System.Drawing.Point(830, 332);
            this.creditcardText.Name = "creditcardText";
            this.creditcardText.Size = new System.Drawing.Size(267, 31);
            this.creditcardText.TabIndex = 12;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(1194, 99);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(100, 31);
            this.insertButton.TabIndex = 14;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.creditcardText);
            this.Controls.Add(this.genderLable);
            this.Controls.Add(this.genderText);
            this.Controls.Add(this.emailLable);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastNameInText);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lastNameLable);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.peopleFoundListbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Dashboard";
            this.Text = "SQL Data Access";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleFoundListbox;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label lastNameLable;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastNameInText;
        private System.Windows.Forms.Label emailLable;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label genderLable;
        private System.Windows.Forms.TextBox genderText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox creditcardText;
        private System.Windows.Forms.Button insertButton;
    }
}

