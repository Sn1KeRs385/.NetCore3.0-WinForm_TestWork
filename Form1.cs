using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TestProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_OpenInputDialog_Click(object sender, EventArgs e)
        {
            TextBox_OpenInputDialog.Text = FolderBrowserDialogOpen();
        }

        private void Run_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryWorker DirWorker = new DirectoryWorker();
                DirWorker.DefaultDirectoryToLoad = TextBox_OpenInputDialog.Text;
                DirWorker.DefaultDirectoryToSave = TextBox_OpenOutputDialog.Text;
                DirWorker.Top = Convert.ToInt32(TextBox_top.Text);
                DirWorker.CreateOutFile();
                DirWorker.SaveFiles();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_OpenOutputDialog_Click(object sender, EventArgs e)
        {
            TextBox_OpenOutputDialog.Text = FolderBrowserDialogOpen();
        }
        
        private string FolderBrowserDialogOpen()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            return dialog.SelectedPath;
        }
    }
}
