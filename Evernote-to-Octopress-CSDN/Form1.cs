using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Evernote_to_Octopress_CSDN;

namespace Evernote_to_Octopress_CSDN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string folder_name;
        private string evernote_file_path;
        private string octopress_title;
        private string octopress_categories;
        private string octopress_tags;

        RunCmd runcmd = new RunCmd();

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string file_path = fileDialog.FileName;
                tbEvernoteFilePath.Text = file_path;
            }
        }

        private void btnEvernoteToOctopress_Click(object sender, EventArgs e)
        {
            evernote_file_path = tbEvernoteFilePath.Text;
            folder_name = tbFolderName.Text;
            octopress_title = tbOctopressTitle.Text;
            octopress_categories = tbOctopressCategories.Text;
            octopress_tags = tbOctopressTags.Text;

            string python35_path = @"C:\Users\AOBO\AppData\Local\Programs\Python\Python35\python.exe";
            string evernoteToOctopressBlog_py_path = @"D:\WorkSpace\python_ws\Evernote_Automatic_format_conversion\script\evernoteToOctopressBlog.py";
            string commond, output;
            commond = python35_path + " " + evernoteToOctopressBlog_py_path + " -f \"" + folder_name
                + "\" -p \"" + evernote_file_path + "\" -T \"" + octopress_title + "\" -c \"" + octopress_categories
                + "\" -t \"" + octopress_tags + "\"";
            runcmd.run(commond, out output);
            MessageBox.Show(output);
        }
    }
}
