namespace Projekt_C
{
    partial class UIchangeCategory
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
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtBoxNewName = new System.Windows.Forms.TextBox();
            this.lblNewFeedName = new System.Windows.Forms.Label();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.btnConfirmNewName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(68, 116);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Category";
            // 
            // txtBoxNewName
            // 
            this.txtBoxNewName.Location = new System.Drawing.Point(146, 147);
            this.txtBoxNewName.Name = "txtBoxNewName";
            this.txtBoxNewName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNewName.TabIndex = 7;
            // 
            // lblNewFeedName
            // 
            this.lblNewFeedName.AutoSize = true;
            this.lblNewFeedName.Location = new System.Drawing.Point(64, 147);
            this.lblNewFeedName.Name = "lblNewFeedName";
            this.lblNewFeedName.Size = new System.Drawing.Size(58, 13);
            this.lblNewFeedName.TabIndex = 6;
            this.lblNewFeedName.Text = "New name";
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(146, 116);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategories.TabIndex = 12;
            // 
            // btnConfirmNewName
            // 
            this.btnConfirmNewName.Location = new System.Drawing.Point(282, 177);
            this.btnConfirmNewName.Name = "btnConfirmNewName";
            this.btnConfirmNewName.Size = new System.Drawing.Size(107, 23);
            this.btnConfirmNewName.TabIndex = 13;
            this.btnConfirmNewName.Text = "Confirm change";
            this.btnConfirmNewName.UseVisualStyleBackColor = true;
            this.btnConfirmNewName.Click += new System.EventHandler(this.btnConfirmNewName_Click);
            // 
            // UIchangeCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 207);
            this.Controls.Add(this.btnConfirmNewName);
            this.Controls.Add(this.comboBoxCategories);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtBoxNewName);
            this.Controls.Add(this.lblNewFeedName);
            this.Name = "UIchangeCategory";
            this.Text = "Change a category";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UIchangeCategory_FormClosing);
            this.Load += new System.EventHandler(this.UIchangeCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtBoxNewName;
        private System.Windows.Forms.Label lblNewFeedName;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.Button btnConfirmNewName;
    }
}