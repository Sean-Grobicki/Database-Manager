
namespace Database_Manager
{
    partial class AddProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProject));
            this.projectGroupBox = new System.Windows.Forms.GroupBox();
            this.errorMessage = new System.Windows.Forms.Label();
            this.languageBox = new System.Windows.Forms.TextBox();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.addLinkButton = new System.Windows.Forms.Button();
            this.linkChangeButton = new System.Windows.Forms.Button();
            this.linksLabel = new System.Windows.Forms.Label();
            this.linksBox = new System.Windows.Forms.ListBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.projectGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectGroupBox
            // 
            this.projectGroupBox.Controls.Add(this.errorMessage);
            this.projectGroupBox.Controls.Add(this.languageBox);
            this.projectGroupBox.Controls.Add(this.typeBox);
            this.projectGroupBox.Controls.Add(this.cancelButton);
            this.projectGroupBox.Controls.Add(this.addButton);
            this.projectGroupBox.Controls.Add(this.addLinkButton);
            this.projectGroupBox.Controls.Add(this.linkChangeButton);
            this.projectGroupBox.Controls.Add(this.linksLabel);
            this.projectGroupBox.Controls.Add(this.linksBox);
            this.projectGroupBox.Controls.Add(this.titleBox);
            this.projectGroupBox.Controls.Add(this.descriptionTextBox);
            this.projectGroupBox.Controls.Add(this.descriptionLabel);
            this.projectGroupBox.Controls.Add(this.typeLabel);
            this.projectGroupBox.Controls.Add(this.languageLabel);
            this.projectGroupBox.Controls.Add(this.titleLabel);
            this.projectGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectGroupBox.Location = new System.Drawing.Point(0, 0);
            this.projectGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.projectGroupBox.Name = "projectGroupBox";
            this.projectGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.projectGroupBox.Size = new System.Drawing.Size(734, 482);
            this.projectGroupBox.TabIndex = 29;
            this.projectGroupBox.TabStop = false;
            this.projectGroupBox.Text = "Add Project";
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage.Location = new System.Drawing.Point(148, 450);
            this.errorMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 25);
            this.errorMessage.TabIndex = 47;
            // 
            // languageBox
            // 
            this.languageBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageBox.Location = new System.Drawing.Point(244, 106);
            this.languageBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.languageBox.Name = "languageBox";
            this.languageBox.Size = new System.Drawing.Size(230, 25);
            this.languageBox.TabIndex = 46;
            // 
            // typeBox
            // 
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "Education",
            "Personal"});
            this.typeBox.Location = new System.Drawing.Point(244, 67);
            this.typeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(230, 25);
            this.typeBox.TabIndex = 45;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(346, 403);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 32);
            this.cancelButton.TabIndex = 44;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(226, 403);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(94, 32);
            this.addButton.TabIndex = 41;
            this.addButton.Text = "Add Project";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addLinkButton
            // 
            this.addLinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.addLinkButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLinkButton.ForeColor = System.Drawing.Color.White;
            this.addLinkButton.Location = new System.Drawing.Point(235, 360);
            this.addLinkButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addLinkButton.Name = "addLinkButton";
            this.addLinkButton.Size = new System.Drawing.Size(76, 24);
            this.addLinkButton.TabIndex = 40;
            this.addLinkButton.Text = "Add Link";
            this.addLinkButton.UseVisualStyleBackColor = false;
            this.addLinkButton.Click += new System.EventHandler(this.addLinkButton_Click);
            // 
            // linkChangeButton
            // 
            this.linkChangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.linkChangeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkChangeButton.ForeColor = System.Drawing.Color.White;
            this.linkChangeButton.Location = new System.Drawing.Point(336, 360);
            this.linkChangeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.linkChangeButton.Name = "linkChangeButton";
            this.linkChangeButton.Size = new System.Drawing.Size(76, 24);
            this.linkChangeButton.TabIndex = 39;
            this.linkChangeButton.Text = "Change Link";
            this.linkChangeButton.UseVisualStyleBackColor = false;
            this.linkChangeButton.Click += new System.EventHandler(this.linkChangeButton_Click);
            // 
            // linksLabel
            // 
            this.linksLabel.AutoSize = true;
            this.linksLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linksLabel.Location = new System.Drawing.Point(183, 253);
            this.linksLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linksLabel.Name = "linksLabel";
            this.linksLabel.Size = new System.Drawing.Size(36, 17);
            this.linksLabel.TabIndex = 38;
            this.linksLabel.Text = "Links";
            // 
            // linksBox
            // 
            this.linksBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linksBox.FormattingEnabled = true;
            this.linksBox.ItemHeight = 17;
            this.linksBox.Location = new System.Drawing.Point(185, 269);
            this.linksBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.linksBox.Name = "linksBox";
            this.linksBox.Size = new System.Drawing.Size(290, 72);
            this.linksBox.TabIndex = 37;
            // 
            // titleBox
            // 
            this.titleBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBox.Location = new System.Drawing.Point(244, 24);
            this.titleBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(230, 25);
            this.titleBox.TabIndex = 34;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(185, 166);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(290, 79);
            this.descriptionTextBox.TabIndex = 33;
            this.descriptionTextBox.Text = "";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(183, 150);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(74, 17);
            this.descriptionLabel.TabIndex = 32;
            this.descriptionLabel.Text = "Description";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(183, 67);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(38, 17);
            this.typeLabel.TabIndex = 31;
            this.typeLabel.Text = "Type:";
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageLabel.Location = new System.Drawing.Point(183, 108);
            this.languageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(68, 17);
            this.languageLabel.TabIndex = 30;
            this.languageLabel.Text = "Language:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(183, 26);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(35, 17);
            this.titleLabel.TabIndex = 29;
            this.titleLabel.Text = "Title:";
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(734, 482);
            this.Controls.Add(this.projectGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(750, 600);
            this.MinimumSize = new System.Drawing.Size(550, 500);
            this.Name = "AddProject";
            this.Text = "Add Project";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddProject_FormClosed);
            this.projectGroupBox.ResumeLayout(false);
            this.projectGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox projectGroupBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button addLinkButton;
        private System.Windows.Forms.Button linkChangeButton;
        private System.Windows.Forms.Label linksLabel;
        private System.Windows.Forms.ListBox linksBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox languageBox;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Label errorMessage;
    }
}