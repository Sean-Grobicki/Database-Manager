
namespace Database_Manager
{
    partial class AddLink
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLink));
            this.linkGroupBox = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.linkTypeBox = new System.Windows.Forms.ComboBox();
            this.linkUrlBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkNameLabel = new System.Windows.Forms.Label();
            this.linkNameBox = new System.Windows.Forms.TextBox();
            this.linkGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkGroupBox
            // 
            this.linkGroupBox.Controls.Add(this.linkNameBox);
            this.linkGroupBox.Controls.Add(this.cancelButton);
            this.linkGroupBox.Controls.Add(this.addButton);
            this.linkGroupBox.Controls.Add(this.linkTypeBox);
            this.linkGroupBox.Controls.Add(this.linkUrlBox);
            this.linkGroupBox.Controls.Add(this.label2);
            this.linkGroupBox.Controls.Add(this.label1);
            this.linkGroupBox.Controls.Add(this.linkNameLabel);
            this.linkGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkGroupBox.Location = new System.Drawing.Point(0, 0);
            this.linkGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.linkGroupBox.Name = "linkGroupBox";
            this.linkGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.linkGroupBox.Size = new System.Drawing.Size(600, 366);
            this.linkGroupBox.TabIndex = 0;
            this.linkGroupBox.TabStop = false;
            this.linkGroupBox.Text = "Add Link";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(307, 241);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 32);
            this.cancelButton.TabIndex = 43;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(166, 241);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(94, 32);
            this.addButton.TabIndex = 42;
            this.addButton.Text = "Add Link";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // linkTypeBox
            // 
            this.linkTypeBox.FormattingEnabled = true;
            this.linkTypeBox.Items.AddRange(new object[] {
            "GitHub",
            "YouTube",
            "Hosting"});
            this.linkTypeBox.Location = new System.Drawing.Point(254, 124);
            this.linkTypeBox.Margin = new System.Windows.Forms.Padding(2);
            this.linkTypeBox.Name = "linkTypeBox";
            this.linkTypeBox.Size = new System.Drawing.Size(133, 25);
            this.linkTypeBox.TabIndex = 5;
            // 
            // linkUrlBox
            // 
            this.linkUrlBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkUrlBox.Location = new System.Drawing.Point(254, 175);
            this.linkUrlBox.Margin = new System.Windows.Forms.Padding(2);
            this.linkUrlBox.Name = "linkUrlBox";
            this.linkUrlBox.Size = new System.Drawing.Size(133, 25);
            this.linkUrlBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Link URL:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Link Type:";
            // 
            // linkNameLabel
            // 
            this.linkNameLabel.AutoSize = true;
            this.linkNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkNameLabel.Location = new System.Drawing.Point(153, 67);
            this.linkNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkNameLabel.Name = "linkNameLabel";
            this.linkNameLabel.Size = new System.Drawing.Size(72, 17);
            this.linkNameLabel.TabIndex = 0;
            this.linkNameLabel.Text = "Link Name:";
            // 
            // linkNameBox
            // 
            this.linkNameBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkNameBox.Location = new System.Drawing.Point(254, 64);
            this.linkNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.linkNameBox.Name = "linkNameBox";
            this.linkNameBox.Size = new System.Drawing.Size(133, 25);
            this.linkNameBox.TabIndex = 44;
            // 
            // AddLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.linkGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddLink";
            this.RightToLeftLayout = true;
            this.Text = "Add Link";
            this.linkGroupBox.ResumeLayout(false);
            this.linkGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox linkGroupBox;
        private System.Windows.Forms.TextBox linkUrlBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label linkNameLabel;
        private System.Windows.Forms.ComboBox linkTypeBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox linkNameBox;
    }
}