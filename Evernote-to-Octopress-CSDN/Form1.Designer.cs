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
            this.tbEvernoteFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEvernoteFolder);
            this.groupBox1.Controls.Add(this.tbEvernoteFolder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 188);
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
            // tbEvernoteFolder
            // 
            this.tbEvernoteFolder.Location = new System.Drawing.Point(189, 27);
            this.tbEvernoteFolder.Name = "tbEvernoteFolder";
            this.tbEvernoteFolder.Size = new System.Drawing.Size(487, 21);
            this.tbEvernoteFolder.TabIndex = 1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 213);
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
        private System.Windows.Forms.TextBox tbEvernoteFolder;
        private System.Windows.Forms.Label label1;
    }
}

