namespace Projekt_C
{
    partial class Form1
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
            this.btnAddFeed = new System.Windows.Forms.Button();
            this.txtBoxUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowFeedInfo = new System.Windows.Forms.Button();
            this.btnRemoveFeed = new System.Windows.Forms.Button();
            this.btnShowFeed = new System.Windows.Forms.Button();
            this.comboBoxFeeds = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxFrequency = new System.Windows.Forms.TextBox();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.grpBoxCategory = new System.Windows.Forms.GroupBox();
            this.txtBoxNewCategory = new System.Windows.Forms.TextBox();
            this.lblNewCategory = new System.Windows.Forms.Label();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnChangeCategory = new System.Windows.Forms.Button();
            this.comboBoxShowCategories = new System.Windows.Forms.ComboBox();
            this.btnShowCategory = new System.Windows.Forms.Button();
            this.lblCategories = new System.Windows.Forms.Label();
            this.btnChangeFeed = new System.Windows.Forms.Button();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblNameOfFeed = new System.Windows.Forms.Label();
            this.txtBoxNameOfFeed = new System.Windows.Forms.TextBox();
            this.tabCtrlFeeds = new System.Windows.Forms.TabControl();
            this.groupBox1.SuspendLayout();
            this.grpBoxCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddFeed
            // 
            this.btnAddFeed.Location = new System.Drawing.Point(176, 213);
            this.btnAddFeed.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddFeed.Name = "btnAddFeed";
            this.btnAddFeed.Size = new System.Drawing.Size(85, 25);
            this.btnAddFeed.TabIndex = 4;
            this.btnAddFeed.Text = "Add feed";
            this.btnAddFeed.UseVisualStyleBackColor = true;
            this.btnAddFeed.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBoxUrl
            // 
            this.txtBoxUrl.Location = new System.Drawing.Point(140, 54);
            this.txtBoxUrl.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxUrl.Name = "txtBoxUrl";
            this.txtBoxUrl.Size = new System.Drawing.Size(117, 20);
            this.txtBoxUrl.TabIndex = 0;
            this.txtBoxUrl.TextChanged += new System.EventHandler(this.txtBoxUrl_TextChanged);
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(21, 57);
            this.lblUrl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(32, 13);
            this.lblUrl.TabIndex = 1;
            this.lblUrl.Text = "URL ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.btnShowFeedInfo);
            this.groupBox1.Controls.Add(this.btnRemoveFeed);
            this.groupBox1.Controls.Add(this.btnShowFeed);
            this.groupBox1.Controls.Add(this.comboBoxFeeds);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBoxFrequency);
            this.groupBox1.Controls.Add(this.lblFrequency);
            this.groupBox1.Controls.Add(this.grpBoxCategory);
            this.groupBox1.Controls.Add(this.btnChangeFeed);
            this.groupBox1.Controls.Add(this.comboBoxCategories);
            this.groupBox1.Controls.Add(this.lblCategory);
            this.groupBox1.Controls.Add(this.lblNameOfFeed);
            this.groupBox1.Controls.Add(this.txtBoxNameOfFeed);
            this.groupBox1.Controls.Add(this.btnAddFeed);
            this.groupBox1.Controls.Add(this.txtBoxUrl);
            this.groupBox1.Controls.Add(this.lblUrl);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 566);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // btnShowFeedInfo
            // 
            this.btnShowFeedInfo.AutoSize = true;
            this.btnShowFeedInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowFeedInfo.Location = new System.Drawing.Point(26, 297);
            this.btnShowFeedInfo.Name = "btnShowFeedInfo";
            this.btnShowFeedInfo.Size = new System.Drawing.Size(88, 23);
            this.btnShowFeedInfo.TabIndex = 25;
            this.btnShowFeedInfo.Text = "Show feed info";
            this.btnShowFeedInfo.UseVisualStyleBackColor = true;
            this.btnShowFeedInfo.Click += new System.EventHandler(this.btnShowFeedInfo_Click);
            // 
            // btnRemoveFeed
            // 
            this.btnRemoveFeed.BackColor = System.Drawing.Color.Crimson;
            this.btnRemoveFeed.Location = new System.Drawing.Point(258, 263);
            this.btnRemoveFeed.Name = "btnRemoveFeed";
            this.btnRemoveFeed.Size = new System.Drawing.Size(37, 33);
            this.btnRemoveFeed.TabIndex = 9;
            this.btnRemoveFeed.Text = "X";
            this.btnRemoveFeed.UseVisualStyleBackColor = false;
            this.btnRemoveFeed.Click += new System.EventHandler(this.btnRemoveFeed_Click);
            // 
            // btnShowFeed
            // 
            this.btnShowFeed.Location = new System.Drawing.Point(26, 268);
            this.btnShowFeed.Name = "btnShowFeed";
            this.btnShowFeed.Size = new System.Drawing.Size(75, 23);
            this.btnShowFeed.TabIndex = 24;
            this.btnShowFeed.Text = "Display feed";
            this.btnShowFeed.UseVisualStyleBackColor = true;
            this.btnShowFeed.Click += new System.EventHandler(this.btnShowFeed_Click);
            // 
            // comboBoxFeeds
            // 
            this.comboBoxFeeds.FormattingEnabled = true;
            this.comboBoxFeeds.Location = new System.Drawing.Point(131, 270);
            this.comboBoxFeeds.Name = "comboBoxFeeds";
            this.comboBoxFeeds.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFeeds.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Your feeds";
            // 
            // txtBoxFrequency
            // 
            this.txtBoxFrequency.Location = new System.Drawing.Point(140, 173);
            this.txtBoxFrequency.Name = "txtBoxFrequency";
            this.txtBoxFrequency.Size = new System.Drawing.Size(117, 20);
            this.txtBoxFrequency.TabIndex = 21;
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Location = new System.Drawing.Point(21, 173);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(57, 13);
            this.lblFrequency.TabIndex = 20;
            this.lblFrequency.Text = "Frequency";
            // 
            // grpBoxCategory
            // 
            this.grpBoxCategory.Controls.Add(this.txtBoxNewCategory);
            this.grpBoxCategory.Controls.Add(this.lblNewCategory);
            this.grpBoxCategory.Controls.Add(this.btnRemoveCategory);
            this.grpBoxCategory.Controls.Add(this.btnAddCategory);
            this.grpBoxCategory.Controls.Add(this.btnChangeCategory);
            this.grpBoxCategory.Controls.Add(this.comboBoxShowCategories);
            this.grpBoxCategory.Controls.Add(this.btnShowCategory);
            this.grpBoxCategory.Controls.Add(this.lblCategories);
            this.grpBoxCategory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpBoxCategory.Location = new System.Drawing.Point(3, 328);
            this.grpBoxCategory.Name = "grpBoxCategory";
            this.grpBoxCategory.Size = new System.Drawing.Size(300, 235);
            this.grpBoxCategory.TabIndex = 19;
            this.grpBoxCategory.TabStop = false;
            // 
            // txtBoxNewCategory
            // 
            this.txtBoxNewCategory.Location = new System.Drawing.Point(139, 89);
            this.txtBoxNewCategory.Name = "txtBoxNewCategory";
            this.txtBoxNewCategory.Size = new System.Drawing.Size(110, 20);
            this.txtBoxNewCategory.TabIndex = 8;
            // 
            // lblNewCategory
            // 
            this.lblNewCategory.AutoSize = true;
            this.lblNewCategory.Location = new System.Drawing.Point(20, 89);
            this.lblNewCategory.Name = "lblNewCategory";
            this.lblNewCategory.Size = new System.Drawing.Size(114, 13);
            this.lblNewCategory.TabIndex = 7;
            this.lblNewCategory.Text = "Name of new category";
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.BackColor = System.Drawing.Color.Crimson;
            this.btnRemoveCategory.Location = new System.Drawing.Point(255, 168);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(37, 33);
            this.btnRemoveCategory.TabIndex = 6;
            this.btnRemoveCategory.Text = "X";
            this.btnRemoveCategory.UseVisualStyleBackColor = false;
            this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(172, 127);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(84, 23);
            this.btnAddCategory.TabIndex = 5;
            this.btnAddCategory.Text = "Add category";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnChangeCategory
            // 
            this.btnChangeCategory.Location = new System.Drawing.Point(23, 204);
            this.btnChangeCategory.Name = "btnChangeCategory";
            this.btnChangeCategory.Size = new System.Drawing.Size(99, 23);
            this.btnChangeCategory.TabIndex = 4;
            this.btnChangeCategory.Text = "Change category";
            this.btnChangeCategory.UseVisualStyleBackColor = true;
            this.btnChangeCategory.Click += new System.EventHandler(this.btnChangeCategory_Click);
            // 
            // comboBoxShowCategories
            // 
            this.comboBoxShowCategories.FormattingEnabled = true;
            this.comboBoxShowCategories.Location = new System.Drawing.Point(139, 175);
            this.comboBoxShowCategories.Name = "comboBoxShowCategories";
            this.comboBoxShowCategories.Size = new System.Drawing.Size(110, 21);
            this.comboBoxShowCategories.TabIndex = 3;
            // 
            // btnShowCategory
            // 
            this.btnShowCategory.Location = new System.Drawing.Point(22, 175);
            this.btnShowCategory.Name = "btnShowCategory";
            this.btnShowCategory.Size = new System.Drawing.Size(99, 23);
            this.btnShowCategory.TabIndex = 2;
            this.btnShowCategory.Text = "Display category";
            this.btnShowCategory.UseVisualStyleBackColor = true;
            this.btnShowCategory.Click += new System.EventHandler(this.btnShowCategory_Click);
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategories.Location = new System.Drawing.Point(82, 39);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(96, 20);
            this.lblCategories.TabIndex = 0;
            this.lblCategories.Text = "Categories";
            // 
            // btnChangeFeed
            // 
            this.btnChangeFeed.Location = new System.Drawing.Point(24, 213);
            this.btnChangeFeed.Name = "btnChangeFeed";
            this.btnChangeFeed.Size = new System.Drawing.Size(85, 25);
            this.btnChangeFeed.TabIndex = 10;
            this.btnChangeFeed.Text = "Change Feed";
            this.btnChangeFeed.UseVisualStyleBackColor = true;
            this.btnChangeFeed.Click += new System.EventHandler(this.btnChangeFeed_Click);
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(140, 130);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(117, 21);
            this.comboBoxCategories.TabIndex = 9;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(21, 133);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(55, 13);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Category :";
            // 
            // lblNameOfFeed
            // 
            this.lblNameOfFeed.AutoSize = true;
            this.lblNameOfFeed.Location = new System.Drawing.Point(21, 94);
            this.lblNameOfFeed.Name = "lblNameOfFeed";
            this.lblNameOfFeed.Size = new System.Drawing.Size(38, 13);
            this.lblNameOfFeed.TabIndex = 6;
            this.lblNameOfFeed.Text = "Name ";
            // 
            // txtBoxNameOfFeed
            // 
            this.txtBoxNameOfFeed.Location = new System.Drawing.Point(140, 94);
            this.txtBoxNameOfFeed.Name = "txtBoxNameOfFeed";
            this.txtBoxNameOfFeed.Size = new System.Drawing.Size(117, 20);
            this.txtBoxNameOfFeed.TabIndex = 5;
            // 
            // tabCtrlFeeds
            // 
            this.tabCtrlFeeds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlFeeds.Location = new System.Drawing.Point(326, 60);
            this.tabCtrlFeeds.Name = "tabCtrlFeeds";
            this.tabCtrlFeeds.SelectedIndex = 0;
            this.tabCtrlFeeds.Size = new System.Drawing.Size(545, 566);
            this.tabCtrlFeeds.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 646);
            this.Controls.Add(this.tabCtrlFeeds);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Podcast - collector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBoxCategory.ResumeLayout(false);
            this.grpBoxCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddFeed;
        private System.Windows.Forms.TextBox txtBoxUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabCtrlFeeds;
        private System.Windows.Forms.Label lblNameOfFeed;
        private System.Windows.Forms.TextBox txtBoxNameOfFeed;
        private System.Windows.Forms.GroupBox grpBoxCategory;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnShowCategory;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.Button btnChangeFeed;
        private System.Windows.Forms.ComboBox comboBoxShowCategories;
        private System.Windows.Forms.Button btnChangeCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnRemoveCategory;
        private System.Windows.Forms.TextBox txtBoxFrequency;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.TextBox txtBoxNewCategory;
        private System.Windows.Forms.Label lblNewCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowFeed;
        private System.Windows.Forms.ComboBox comboBoxFeeds;
        private System.Windows.Forms.Button btnRemoveFeed;
        private System.Windows.Forms.Button btnShowFeedInfo;
    }
}

