
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
            this.lastNamelable = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.firstNameInsLabel = new System.Windows.Forms.Label();
            this.firstNameInsText = new System.Windows.Forms.TextBox();
            this.lastNameInsLabel = new System.Windows.Forms.Label();
            this.lastNameInsText = new System.Windows.Forms.TextBox();
            this.emailAddressInsLabel = new System.Windows.Forms.Label();
            this.emailAddressInsText = new System.Windows.Forms.TextBox();
            this.phoneNumberInsLabel = new System.Windows.Forms.Label();
            this.phoneNumberInsText = new System.Windows.Forms.TextBox();
            this.insertRecordButton = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // peopleFoundListbox
            // 
            this.peopleFoundListbox.FormattingEnabled = true;
            this.peopleFoundListbox.ItemHeight = 25;
            this.peopleFoundListbox.Location = new System.Drawing.Point(54, 102);
            this.peopleFoundListbox.Name = "peopleFoundListbox";
            this.peopleFoundListbox.Size = new System.Drawing.Size(498, 104);
            this.peopleFoundListbox.TabIndex = 4;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(193, 45);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(151, 31);
            this.lastNameText.TabIndex = 1;
            // 
            // lastNamelable
            // 
            this.lastNamelable.AutoSize = true;
            this.lastNamelable.Location = new System.Drawing.Point(49, 51);
            this.lastNamelable.Name = "lastNamelable";
            this.lastNamelable.Size = new System.Drawing.Size(115, 25);
            this.lastNamelable.TabIndex = 2;
            this.lastNamelable.Text = "Last Name";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(350, 45);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(88, 31);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // firstNameInsLabel
            // 
            this.firstNameInsLabel.AutoSize = true;
            this.firstNameInsLabel.Location = new System.Drawing.Point(49, 262);
            this.firstNameInsLabel.Name = "firstNameInsLabel";
            this.firstNameInsLabel.Size = new System.Drawing.Size(116, 25);
            this.firstNameInsLabel.TabIndex = 6;
            this.firstNameInsLabel.Text = "First Name";
            // 
            // firstNameInsText
            // 
            this.firstNameInsText.Location = new System.Drawing.Point(193, 256);
            this.firstNameInsText.Name = "firstNameInsText";
            this.firstNameInsText.Size = new System.Drawing.Size(151, 31);
            this.firstNameInsText.TabIndex = 5;
            // 
            // lastNameInsLabel
            // 
            this.lastNameInsLabel.AutoSize = true;
            this.lastNameInsLabel.Location = new System.Drawing.Point(38, 315);
            this.lastNameInsLabel.Name = "lastNameInsLabel";
            this.lastNameInsLabel.Size = new System.Drawing.Size(115, 25);
            this.lastNameInsLabel.TabIndex = 8;
            this.lastNameInsLabel.Text = "Last Name";
            // 
            // lastNameInsText
            // 
            this.lastNameInsText.Location = new System.Drawing.Point(193, 315);
            this.lastNameInsText.Name = "lastNameInsText";
            this.lastNameInsText.Size = new System.Drawing.Size(151, 31);
            this.lastNameInsText.TabIndex = 7;
            // 
            // emailAddressInsLabel
            // 
            this.emailAddressInsLabel.AutoSize = true;
            this.emailAddressInsLabel.Location = new System.Drawing.Point(38, 365);
            this.emailAddressInsLabel.Name = "emailAddressInsLabel";
            this.emailAddressInsLabel.Size = new System.Drawing.Size(150, 25);
            this.emailAddressInsLabel.TabIndex = 10;
            this.emailAddressInsLabel.Text = "Email Address";
            // 
            // emailAddressInsText
            // 
            this.emailAddressInsText.Location = new System.Drawing.Point(193, 365);
            this.emailAddressInsText.Name = "emailAddressInsText";
            this.emailAddressInsText.Size = new System.Drawing.Size(151, 31);
            this.emailAddressInsText.TabIndex = 9;
            // 
            // phoneNumberInsLabel
            // 
            this.phoneNumberInsLabel.AutoSize = true;
            this.phoneNumberInsLabel.Location = new System.Drawing.Point(38, 413);
            this.phoneNumberInsLabel.Name = "phoneNumberInsLabel";
            this.phoneNumberInsLabel.Size = new System.Drawing.Size(155, 25);
            this.phoneNumberInsLabel.TabIndex = 12;
            this.phoneNumberInsLabel.Text = "Phone Number";
            // 
            // phoneNumberInsText
            // 
            this.phoneNumberInsText.Location = new System.Drawing.Point(193, 413);
            this.phoneNumberInsText.Name = "phoneNumberInsText";
            this.phoneNumberInsText.Size = new System.Drawing.Size(151, 31);
            this.phoneNumberInsText.TabIndex = 11;
            // 
            // insertRecordButton
            // 
            this.insertRecordButton.Location = new System.Drawing.Point(193, 478);
            this.insertRecordButton.Name = "insertRecordButton";
            this.insertRecordButton.Size = new System.Drawing.Size(88, 33);
            this.insertRecordButton.TabIndex = 13;
            this.insertRecordButton.Text = "Insert";
            this.insertRecordButton.UseVisualStyleBackColor = true;
            this.insertRecordButton.Click += new System.EventHandler(this.insertRecordButton_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(202, 582);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 25);
            this.message.TabIndex = 14;
            this.message.Click += new System.EventHandler(this.label1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 690);
            this.Controls.Add(this.message);
            this.Controls.Add(this.insertRecordButton);
            this.Controls.Add(this.phoneNumberInsLabel);
            this.Controls.Add(this.phoneNumberInsText);
            this.Controls.Add(this.emailAddressInsLabel);
            this.Controls.Add(this.emailAddressInsText);
            this.Controls.Add(this.lastNameInsLabel);
            this.Controls.Add(this.lastNameInsText);
            this.Controls.Add(this.firstNameInsLabel);
            this.Controls.Add(this.firstNameInsText);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lastNamelable);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.peopleFoundListbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "SQl Data Access Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleFoundListbox;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label lastNamelable;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label firstNameInsLabel;
        private System.Windows.Forms.TextBox firstNameInsText;
        private System.Windows.Forms.Label lastNameInsLabel;
        private System.Windows.Forms.TextBox lastNameInsText;
        private System.Windows.Forms.Label emailAddressInsLabel;
        private System.Windows.Forms.TextBox emailAddressInsText;
        private System.Windows.Forms.Label phoneNumberInsLabel;
        private System.Windows.Forms.TextBox phoneNumberInsText;
        private System.Windows.Forms.Button insertRecordButton;
        private System.Windows.Forms.Label message;
    }
}

