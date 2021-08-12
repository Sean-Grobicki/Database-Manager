
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
            this.errorMessage = new System.Windows.Forms.Label();
            this.linkNameBox = new System.Windows.Forms.TextBox();
            this.linkNameLabel = new System.Windows.Forms.Label();
            this.linkTypeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkUrlBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.linkGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkGroupBox
            // 
            this.linkGroupBox.Controls.Add(this.linkNameBox);
            this.linkGroupBox.Controls.Add(this.linkNameLabel);
            this.linkGroupBox.Controls.Add(this.linkTypeBox);
            this.linkGroupBox.Controls.Add(this.label1);
            this.linkGroupBox.Controls.Add(this.label2);
            this.linkGroupBox.Controls.Add(this.linkUrlBox);
            this.linkGroupBox.Controls.Add(this.cancelButton);
            this.linkGroupBox.Controls.Add(this.addButton);
            this.linkGroupBox.Controls.Add(this.errorMessage);
            this.linkGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkGroupBox.Location = new System.Drawing.Point(0, 0);
            this.linkGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.linkGroupBox.Name = "linkGroupBox";
            this.linkGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.linkGroupBox.Size = new System.Drawing.Size(563, 385);
            this.linkGroupBox.TabIndex = 0;
            this.linkGroupBox.TabStop = false;
            this.linkGroupBox.Text = "Add Link";
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage.Location = new System.Drawing.Point(207, 298);
            this.errorMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 25);
            this.errorMessage.TabIndex = 45;
            // 
            // linkNameBox
            // 
            this.linkNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkNameBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkNameBox.Location = new System.Drawing.Point(279, 94);
            this.linkNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.linkNameBox.Name = "linkNameBox";
            this.linkNameBox.Size = new System.Drawing.Size(133, 25);
            this.linkNameBox.TabIndex = 52;
            // 
            // linkNameLabel
            // 
            this.linkNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkNameLabel.AutoSize = true;
            this.linkNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkNameLabel.Location = new System.Drawing.Point(150, 97);
            this.linkNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkNameLabel.Name = "linkNameLabel";
            this.linkNameLabel.Size = new System.Drawing.Size(72, 17);
            this.linkNameLabel.TabIndex = 47;
            this.linkNameLabel.Text = "Link Name:";
            // 
            // linkTypeBox
            // 
            this.linkTypeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkTypeBox.FormattingEnabled = true;
            this.linkTypeBox.Items.AddRange(new object[] {
            "GitHub",
            "YouTube",
            "Hosting"});
            this.linkTypeBox.Location = new System.Drawing.Point(279, 148);
            this.linkTypeBox.Margin = new System.Windows.Forms.Padding(2);
            this.linkTypeBox.Name = "linkTypeBox";
            this.linkTypeBox.Size = new System.Drawing.Size(133, 25);
            this.linkTypeBox.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "Link Type:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "Link URL:";
            // 
            // linkUrlBox
            // 
            this.linkUrlBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkUrlBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkUrlBox.Location = new System.Drawing.Point(279, 208);
            this.linkUrlBox.Margin = new System.Windows.Forms.Padding(2);
            this.linkUrlBox.Name = "linkUrlBox";
            this.linkUrlBox.Size = new System.Drawing.Size(133, 25);
            this.linkUrlBox.TabIndex = 50;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(308, 280);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 32);
            this.cancelButton.TabIndex = 54;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(153, 280);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(86, 32);
            this.addButton.TabIndex = 53;
            this.addButton.Text = "Add Link";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // AddLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(563, 385);
            this.Controls.Add(this.linkGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(750, 500);
            this.MinimumSize = new System.Drawing.Size(450, 350);
            this.Name = "AddLink";
            this.RightToLeftLayout = true;
            this.Text = "Add Link";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddLink_FormClosed);
            this.linkGroupBox.ResumeLayout(false);
            this.linkGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox linkGroupBox;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.TextBox linkNameBox;
        private System.Windows.Forms.Label linkNameLabel;
        private System.Windows.Forms.ComboBox linkTypeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox linkUrlBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
    }
}