
namespace Database_Manager
{
    partial class DBManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBManager));
            this.projectBox = new System.Windows.Forms.ListBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.languageBox = new System.Windows.Forms.TextBox();
            this.linksBox = new System.Windows.Forms.ListBox();
            this.linksLabel = new System.Windows.Forms.Label();
            this.linkChangeButton = new System.Windows.Forms.Button();
            this.addLinkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // projectBox
            // 
            this.projectBox.BackColor = System.Drawing.Color.White;
            this.projectBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectBox.FormattingEnabled = true;
            this.projectBox.ItemHeight = 17;
            this.projectBox.Location = new System.Drawing.Point(80, 46);
            this.projectBox.Margin = new System.Windows.Forms.Padding(4);
            this.projectBox.Name = "projectBox";
            this.projectBox.Size = new System.Drawing.Size(257, 395);
            this.projectBox.TabIndex = 0;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(496, 517);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(115, 38);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Update Project";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(631, 517);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(115, 38);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete Project";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(136, 473);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(125, 40);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add New Project";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(440, 46);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(35, 17);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Title:";
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageLabel.Location = new System.Drawing.Point(440, 147);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(68, 17);
            this.languageLabel.TabIndex = 5;
            this.languageLabel.Text = "Language:";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(440, 96);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(38, 17);
            this.typeLabel.TabIndex = 6;
            this.typeLabel.Text = "Type:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(440, 198);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(74, 17);
            this.descriptionLabel.TabIndex = 7;
            this.descriptionLabel.Text = "Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.White;
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(443, 218);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(385, 96);
            this.descriptionTextBox.TabIndex = 8;
            this.descriptionTextBox.Text = "";
            // 
            // titleBox
            // 
            this.titleBox.BackColor = System.Drawing.Color.White;
            this.titleBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBox.Location = new System.Drawing.Point(522, 38);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(306, 25);
            this.titleBox.TabIndex = 9;
            // 
            // typeBox
            // 
            this.typeBox.BackColor = System.Drawing.Color.White;
            this.typeBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeBox.Location = new System.Drawing.Point(522, 93);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(306, 25);
            this.typeBox.TabIndex = 10;
            // 
            // languageBox
            // 
            this.languageBox.BackColor = System.Drawing.Color.White;
            this.languageBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageBox.Location = new System.Drawing.Point(522, 144);
            this.languageBox.Name = "languageBox";
            this.languageBox.Size = new System.Drawing.Size(306, 25);
            this.languageBox.TabIndex = 11;
            // 
            // linksBox
            // 
            this.linksBox.BackColor = System.Drawing.Color.White;
            this.linksBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linksBox.FormattingEnabled = true;
            this.linksBox.ItemHeight = 17;
            this.linksBox.Location = new System.Drawing.Point(443, 345);
            this.linksBox.Name = "linksBox";
            this.linksBox.Size = new System.Drawing.Size(385, 106);
            this.linksBox.TabIndex = 12;
            // 
            // linksLabel
            // 
            this.linksLabel.AutoSize = true;
            this.linksLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linksLabel.Location = new System.Drawing.Point(440, 325);
            this.linksLabel.Name = "linksLabel";
            this.linksLabel.Size = new System.Drawing.Size(36, 17);
            this.linksLabel.TabIndex = 13;
            this.linksLabel.Text = "Links";
            // 
            // linkChangeButton
            // 
            this.linkChangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.linkChangeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkChangeButton.ForeColor = System.Drawing.Color.White;
            this.linkChangeButton.Location = new System.Drawing.Point(644, 457);
            this.linkChangeButton.Name = "linkChangeButton";
            this.linkChangeButton.Size = new System.Drawing.Size(102, 30);
            this.linkChangeButton.TabIndex = 14;
            this.linkChangeButton.Text = "Change Link";
            this.linkChangeButton.UseVisualStyleBackColor = false;
            // 
            // addLinkButton
            // 
            this.addLinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.addLinkButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLinkButton.ForeColor = System.Drawing.Color.White;
            this.addLinkButton.Location = new System.Drawing.Point(509, 457);
            this.addLinkButton.Name = "addLinkButton";
            this.addLinkButton.Size = new System.Drawing.Size(102, 30);
            this.addLinkButton.TabIndex = 15;
            this.addLinkButton.Text = "Add Link";
            this.addLinkButton.UseVisualStyleBackColor = false;
            // 
            // DBManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(951, 592);
            this.Controls.Add(this.addLinkButton);
            this.Controls.Add(this.linkChangeButton);
            this.Controls.Add(this.linksLabel);
            this.Controls.Add(this.linksBox);
            this.Controls.Add(this.languageBox);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.projectBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DBManager";
            this.Text = "Database Manager";
            this.TransparencyKey = System.Drawing.SystemColors.Window;
            this.Load += new System.EventHandler(this.DBManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox projectBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.TextBox languageBox;
        private System.Windows.Forms.ListBox linksBox;
        private System.Windows.Forms.Label linksLabel;
        private System.Windows.Forms.Button linkChangeButton;
        private System.Windows.Forms.Button addLinkButton;
    }
}

