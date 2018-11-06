namespace Projekt_C
{
    partial class UIChangeFeed
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
            this.lblNewFrequency = new System.Windows.Forms.Label();
            this.txtBoxFrequency = new System.Windows.Forms.TextBox();
            this.txtBoxUrl = new System.Windows.Forms.TextBox();
            this.lblNewURL = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblNewFeedName = new System.Windows.Forms.Label();
            this.comboBoxFeeds = new System.Windows.Forms.ComboBox();
            this.lblFeeds = new System.Windows.Forms.Label();
            this.btnConfirmChange = new System.Windows.Forms.Button();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNewFrequency
            // 
            this.lblNewFrequency.AutoSize = true;
            this.lblNewFrequency.Location = new System.Drawing.Point(113, 172);
            this.lblNewFrequency.Name = "lblNewFrequency";
            this.lblNewFrequency.Size = new System.Drawing.Size(79, 13);
            this.lblNewFrequency.TabIndex = 11;
            this.lblNewFrequency.Text = "New frequency";
            // 
            // txtBoxFrequency
            // 
            this.txtBoxFrequency.Location = new System.Drawing.Point(209, 169);
            this.txtBoxFrequency.Name = "txtBoxFrequency";
            this.txtBoxFrequency.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFrequency.TabIndex = 10;
            // 
            // txtBoxUrl
            // 
            this.txtBoxUrl.Location = new System.Drawing.Point(209, 105);
            this.txtBoxUrl.Name = "txtBoxUrl";
            this.txtBoxUrl.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUrl.TabIndex = 9;
            // 
            // lblNewURL
            // 
            this.lblNewURL.AutoSize = true;
            this.lblNewURL.Location = new System.Drawing.Point(113, 108);
            this.lblNewURL.Name = "lblNewURL";
            this.lblNewURL.Size = new System.Drawing.Size(54, 13);
            this.lblNewURL.TabIndex = 8;
            this.lblNewURL.Text = "New URL";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(209, 136);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxName.TabIndex = 7;
            // 
            // lblNewFeedName
            // 
            this.lblNewFeedName.AutoSize = true;
            this.lblNewFeedName.Location = new System.Drawing.Point(113, 139);
            this.lblNewFeedName.Name = "lblNewFeedName";
            this.lblNewFeedName.Size = new System.Drawing.Size(58, 13);
            this.lblNewFeedName.TabIndex = 6;
            this.lblNewFeedName.Text = "New name";
            // 
            // comboBoxFeeds
            // 
            this.comboBoxFeeds.FormattingEnabled = true;
            this.comboBoxFeeds.Location = new System.Drawing.Point(209, 78);
            this.comboBoxFeeds.Name = "comboBoxFeeds";
            this.comboBoxFeeds.Size = new System.Drawing.Size(100, 21);
            this.comboBoxFeeds.TabIndex = 14;
            // 
            // lblFeeds
            // 
            this.lblFeeds.AutoSize = true;
            this.lblFeeds.Location = new System.Drawing.Point(113, 81);
            this.lblFeeds.Name = "lblFeeds";
            this.lblFeeds.Size = new System.Drawing.Size(31, 13);
            this.lblFeeds.TabIndex = 13;
            this.lblFeeds.Text = "Feed";
            // 
            // btnConfirmChange
            // 
            this.btnConfirmChange.Location = new System.Drawing.Point(371, 229);
            this.btnConfirmChange.Name = "btnConfirmChange";
            this.btnConfirmChange.Size = new System.Drawing.Size(130, 23);
            this.btnConfirmChange.TabIndex = 15;
            this.btnConfirmChange.Text = "Confirm changes";
            this.btnConfirmChange.UseVisualStyleBackColor = true;
            this.btnConfirmChange.Click += new System.EventHandler(this.btnConfirmChange_Click);
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(209, 196);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(100, 21);
            this.comboBoxCategories.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "New Category";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UIChangeFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 275);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCategories);
            this.Controls.Add(this.btnConfirmChange);
            this.Controls.Add(this.comboBoxFeeds);
            this.Controls.Add(this.lblFeeds);
            this.Controls.Add(this.lblNewFrequency);
            this.Controls.Add(this.txtBoxFrequency);
            this.Controls.Add(this.txtBoxUrl);
            this.Controls.Add(this.lblNewURL);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblNewFeedName);
            this.Name = "UIChangeFeed";
            this.Text = "Change your feed here";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UIChangeFeed_FormClosing);
            this.Load += new System.EventHandler(this.UIChangeFeed_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewFrequency;
        private System.Windows.Forms.TextBox txtBoxFrequency;
        private System.Windows.Forms.TextBox txtBoxUrl;
        private System.Windows.Forms.Label lblNewURL;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblNewFeedName;
        private System.Windows.Forms.ComboBox comboBoxFeeds;
        private System.Windows.Forms.Label lblFeeds;
        private System.Windows.Forms.Button btnConfirmChange;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.Label label1;
    }
}