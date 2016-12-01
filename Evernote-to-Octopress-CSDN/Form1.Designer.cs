namespace Evernote_to_Octopress_CSDN
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEvernoteFolder = new System.Windows.Forms.Button();
            this.tbEvernoteFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFolderName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOctopressTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOctopressCategories = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOctopressTags = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEvernoteToOctopress = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbOctopressTags);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbOctopressCategories);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbOctopressTitle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbFolderName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnEvernoteFolder);
            this.groupBox1.Controls.Add(this.tbEvernoteFilePath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "马克飞象笔记 转为 Octopress";
            // 
            // btnEvernoteFolder
            // 
            this.btnEvernoteFolder.Location = new System.Drawing.Point(692, 25);
            this.btnEvernoteFolder.Name = "btnEvernoteFolder";
            this.btnEvernoteFolder.Size = new System.Drawing.Size(75, 23);
            this.btnEvernoteFolder.TabIndex = 2;
            this.btnEvernoteFolder.Text = "浏览...";
            this.btnEvernoteFolder.UseVisualStyleBackColor = true;
            this.btnEvernoteFolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbEvernoteFilePath
            // 
            this.tbEvernoteFilePath.Location = new System.Drawing.Point(189, 27);
            this.tbEvernoteFilePath.Name = "tbEvernoteFilePath";
            this.tbEvernoteFilePath.Size = new System.Drawing.Size(487, 21);
            this.tbEvernoteFilePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "马克飞象笔记(.md)所在路径:";
            // 
            // tbFolderName
            // 
            this.tbFolderName.Location = new System.Drawing.Point(189, 54);
            this.tbFolderName.Name = "tbFolderName";
            this.tbFolderName.Size = new System.Drawing.Size(487, 21);
            this.tbFolderName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "转换后的Octopress博文名字:";
            // 
            // tbOctopressTitle
            // 
            this.tbOctopressTitle.Location = new System.Drawing.Point(189, 81);
            this.tbOctopressTitle.Name = "tbOctopressTitle";
            this.tbOctopressTitle.Size = new System.Drawing.Size(487, 21);
            this.tbOctopressTitle.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Octopress博文的title:";
            // 
            // tbOctopressCategories
            // 
            this.tbOctopressCategories.Location = new System.Drawing.Point(189, 108);
            this.tbOctopressCategories.Name = "tbOctopressCategories";
            this.tbOctopressCategories.Size = new System.Drawing.Size(487, 21);
            this.tbOctopressCategories.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Octopress博文的categories:";
            // 
            // tbOctopressTags
            // 
            this.tbOctopressTags.Location = new System.Drawing.Point(189, 135);
            this.tbOctopressTags.Name = "tbOctopressTags";
            this.tbOctopressTags.Size = new System.Drawing.Size(487, 21);
            this.tbOctopressTags.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Octopress博文的tags:";
            // 
            // btnEvernoteToOctopress
            // 
            this.btnEvernoteToOctopress.Location = new System.Drawing.Point(439, 203);
            this.btnEvernoteToOctopress.Name = "btnEvernoteToOctopress";
            this.btnEvernoteToOctopress.Size = new System.Drawing.Size(146, 23);
            this.btnEvernoteToOctopress.TabIndex = 1;
            this.btnEvernoteToOctopress.Text = "马克飞象转Octopress";
            this.btnEvernoteToOctopress.UseVisualStyleBackColor = true;
            this.btnEvernoteToOctopress.Click += new System.EventHandler(this.btnEvernoteToOctopress_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 238);
            this.Controls.Add(this.btnEvernoteToOctopress);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEvernoteFolder;
        private System.Windows.Forms.TextBox tbEvernoteFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOctopressTags;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbOctopressCategories;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbOctopressTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFolderName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEvernoteToOctopress;
    }
}

