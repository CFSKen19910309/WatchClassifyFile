namespace WatchClassifyFile
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Button_StopWatch = new System.Windows.Forms.Button();
            this.Button_StartWatch = new System.Windows.Forms.Button();
            this.ListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TextBox_DestinationFolderPath = new System.Windows.Forms.TextBox();
            this.Label_DestinationFolder = new System.Windows.Forms.Label();
            this.Label_SourceFile = new System.Windows.Forms.Label();
            this.TextBox_SourceFilePath = new System.Windows.Forms.TextBox();
            this.Button_DestinationFolderPathBrowse = new System.Windows.Forms.Button();
            this.Button_SourceFilePathBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FileSystemWatcher = new System.IO.FileSystemWatcher();
            this.EventLog = new System.Diagnostics.EventLog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileSystemWatcher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventLog)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.14429F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.13344F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.68057F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.68057F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.68057F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.68057F));
            this.tableLayoutPanel1.Controls.Add(this.Button_StopWatch, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Button_StartWatch, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ListView, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TextBox_DestinationFolderPath, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Label_DestinationFolder, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Label_SourceFile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TextBox_SourceFilePath, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Button_DestinationFolderPathBrowse, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.Button_SourceFilePathBrowse, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(844, 305);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Button_StopWatch
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Button_StopWatch, 3);
            this.Button_StopWatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_StopWatch.Location = new System.Drawing.Point(423, 83);
            this.Button_StopWatch.Name = "Button_StopWatch";
            this.Button_StopWatch.Size = new System.Drawing.Size(418, 86);
            this.Button_StopWatch.TabIndex = 6;
            this.Button_StopWatch.Text = "Stop Watch";
            this.Button_StopWatch.UseVisualStyleBackColor = true;
            this.Button_StopWatch.Click += new System.EventHandler(this.Button_StopWatch_Click);
            // 
            // Button_StartWatch
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Button_StartWatch, 3);
            this.Button_StartWatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_StartWatch.Location = new System.Drawing.Point(3, 83);
            this.Button_StartWatch.Name = "Button_StartWatch";
            this.Button_StartWatch.Size = new System.Drawing.Size(414, 86);
            this.Button_StartWatch.TabIndex = 5;
            this.Button_StartWatch.Text = "Start Watch";
            this.Button_StartWatch.UseVisualStyleBackColor = true;
            this.Button_StartWatch.Click += new System.EventHandler(this.Button_StartWatch_Click);
            // 
            // ListView
            // 
            this.ListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.tableLayoutPanel1.SetColumnSpan(this.ListView, 6);
            this.ListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView.LabelEdit = true;
            this.ListView.Location = new System.Drawing.Point(3, 215);
            this.ListView.MultiSelect = false;
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(838, 87);
            this.ListView.TabIndex = 1;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.List;
            // 
            // TextBox_DestinationFolderPath
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TextBox_DestinationFolderPath, 4);
            this.TextBox_DestinationFolderPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_DestinationFolderPath.Location = new System.Drawing.Point(198, 43);
            this.TextBox_DestinationFolderPath.Name = "TextBox_DestinationFolderPath";
            this.TextBox_DestinationFolderPath.Size = new System.Drawing.Size(499, 29);
            this.TextBox_DestinationFolderPath.TabIndex = 2;
            // 
            // Label_DestinationFolder
            // 
            this.Label_DestinationFolder.AutoSize = true;
            this.Label_DestinationFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_DestinationFolder.Location = new System.Drawing.Point(3, 40);
            this.Label_DestinationFolder.Name = "Label_DestinationFolder";
            this.Label_DestinationFolder.Size = new System.Drawing.Size(189, 40);
            this.Label_DestinationFolder.TabIndex = 0;
            this.Label_DestinationFolder.Text = "Destination Folder Path:";
            this.Label_DestinationFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_SourceFile
            // 
            this.Label_SourceFile.AutoSize = true;
            this.Label_SourceFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_SourceFile.Location = new System.Drawing.Point(3, 0);
            this.Label_SourceFile.Name = "Label_SourceFile";
            this.Label_SourceFile.Size = new System.Drawing.Size(189, 40);
            this.Label_SourceFile.TabIndex = 0;
            this.Label_SourceFile.Text = "Source File Path:";
            this.Label_SourceFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextBox_SourceFilePath
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TextBox_SourceFilePath, 4);
            this.TextBox_SourceFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_SourceFilePath.Location = new System.Drawing.Point(198, 3);
            this.TextBox_SourceFilePath.Name = "TextBox_SourceFilePath";
            this.TextBox_SourceFilePath.Size = new System.Drawing.Size(499, 29);
            this.TextBox_SourceFilePath.TabIndex = 2;
            // 
            // Button_DestinationFolderPathBrowse
            // 
            this.Button_DestinationFolderPathBrowse.Location = new System.Drawing.Point(703, 43);
            this.Button_DestinationFolderPathBrowse.Name = "Button_DestinationFolderPathBrowse";
            this.Button_DestinationFolderPathBrowse.Size = new System.Drawing.Size(129, 29);
            this.Button_DestinationFolderPathBrowse.TabIndex = 3;
            this.Button_DestinationFolderPathBrowse.Text = "Browse";
            this.Button_DestinationFolderPathBrowse.UseVisualStyleBackColor = true;
            this.Button_DestinationFolderPathBrowse.Click += new System.EventHandler(this.Button_DestinationFolderPathBrowse_Click);
            // 
            // Button_SourceFilePathBrowse
            // 
            this.Button_SourceFilePathBrowse.Location = new System.Drawing.Point(703, 3);
            this.Button_SourceFilePathBrowse.Name = "Button_SourceFilePathBrowse";
            this.Button_SourceFilePathBrowse.Size = new System.Drawing.Size(129, 29);
            this.Button_SourceFilePathBrowse.TabIndex = 3;
            this.Button_SourceFilePathBrowse.Text = "Browse";
            this.Button_SourceFilePathBrowse.UseVisualStyleBackColor = true;
            this.Button_SourceFilePathBrowse.Click += new System.EventHandler(this.Button_SourceFilePathBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 6);
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 172);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(838, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Watched Classify File";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FileSystemWatcher
            // 
            this.FileSystemWatcher.EnableRaisingEvents = true;
            this.FileSystemWatcher.NotifyFilter = System.IO.NotifyFilters.FileName;
            this.FileSystemWatcher.SynchronizingObject = this;
            this.FileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.FileSystemWatcher_Changed);
            // 
            // EventLog
            // 
            this.EventLog.SynchronizingObject = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 305);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "MainForm";
            this.Text = "Watch Classify File";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileSystemWatcher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Label_DestinationFolder;
        private System.Windows.Forms.Label Label_SourceFile;
        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.Button Button_DestinationFolderPathBrowse;
        private System.Windows.Forms.Button Button_SourceFilePathBrowse;
        private System.Windows.Forms.Button Button_StopWatch;
        private System.Windows.Forms.Button Button_StartWatch;
        private System.Windows.Forms.TextBox TextBox_DestinationFolderPath;
        private System.Windows.Forms.TextBox TextBox_SourceFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.IO.FileSystemWatcher FileSystemWatcher;
        private System.Diagnostics.EventLog EventLog;
    }
}

