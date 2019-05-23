using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchClassifyFile
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
            FileSystemWatcher.Created += FileSystemWatcher_Changed;
        }

        private void Button_StartWatch_Click(object sender, EventArgs e)
        {
            if(System.IO.File.Exists(TextBox_SourceFilePath.Text) == false)
            {
                MessageBox.Show("Source Folder is not Exists");
                return;
            }
            if (System.IO.Directory.Exists(TextBox_DestinationFolderPath.Text) == false)
            {
                MessageBox.Show("Destination Folder is not Exists");
                return;
            }

            string t_SourceRootDirectory = System.IO.Path.GetDirectoryName(TextBox_SourceFilePath.Text);
            string t_SourceFileName = System.IO.Path.GetFileName(TextBox_SourceFilePath.Text);
            FileSystemWatcher.Path = t_SourceRootDirectory;
            FileSystemWatcher.Filter = t_SourceFileName;
            FileSystemWatcher.EnableRaisingEvents = true;

            Button_SourceFilePathBrowse.Enabled = false;
            Button_DestinationFolderPathBrowse.Enabled = false;
            TextBox_SourceFilePath.Enabled = false;
            TextBox_DestinationFolderPath.Enabled = false;
            Button_StartWatch.Enabled = false;
            Button_StopWatch.Enabled = true;

        }

        private void Button_StopWatch_Click(object sender, EventArgs e)
        {
            Button_SourceFilePathBrowse.Enabled = true;
            Button_DestinationFolderPathBrowse.Enabled = true;
            TextBox_SourceFilePath.Enabled = true;
            TextBox_DestinationFolderPath.Enabled = true;
            Button_StartWatch.Enabled = true;
            Button_StopWatch.Enabled = false;
            FileSystemWatcher.EnableRaisingEvents = false;
        }

       
        private void Button_SourceFilePathBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog t_OpenFileDialog = new OpenFileDialog();
            if (t_OpenFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            TextBox_SourceFilePath.Text = t_OpenFileDialog.FileName;

        }

        private void Button_DestinationFolderPathBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog t_FolderBrowserDialog = new FolderBrowserDialog();
            if (t_FolderBrowserDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            TextBox_DestinationFolderPath.Text = t_FolderBrowserDialog.SelectedPath;
        }

        private void FileSystemWatcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            if(e.ChangeType == System.IO.WatcherChangeTypes.Created)
            {
                InputIMEIForm t_InputIMEIForm = new InputIMEIForm();
                if(t_InputIMEIForm.ShowDialog() == DialogResult.OK)
                {
                    string t_FileName = System.IO.Path.GetFileNameWithoutExtension(TextBox_SourceFilePath.Text);
                    string t_Extension = System.IO.Path.GetExtension(TextBox_SourceFilePath.Text);
                    string t_DestinationFilePath = System.IO.Path.Combine(TextBox_DestinationFolderPath.Text, t_FileName + "-" + t_InputIMEIForm.m_IMEI + t_Extension);
                    System.IO.File.Move(TextBox_SourceFilePath.Text, t_DestinationFilePath);
                    System.IO.File.Delete(TextBox_SourceFilePath.Text);
                    
                }
            }

            
        }
    }
}
