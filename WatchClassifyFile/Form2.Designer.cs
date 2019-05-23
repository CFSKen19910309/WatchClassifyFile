namespace WatchClassifyFile
{
    partial class InputIMEIForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_IEMI = new System.Windows.Forms.TextBox();
            this.Button_OK = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TextBox_IEMI, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Button_OK, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(293, 131);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "IMEI:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox_IEMI
            // 
            this.TextBox_IEMI.AcceptsReturn = true;
            this.TextBox_IEMI.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBox_IEMI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_IEMI.Location = new System.Drawing.Point(149, 3);
            this.TextBox_IEMI.Name = "TextBox_IEMI";
            this.TextBox_IEMI.Size = new System.Drawing.Size(141, 29);
            this.TextBox_IEMI.TabIndex = 1;
            this.TextBox_IEMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_IEMI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_IEMI_KeyDown);
            // 
            // Button_OK
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Button_OK, 2);
            this.Button_OK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_OK.Location = new System.Drawing.Point(3, 43);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(287, 85);
            this.Button_OK.TabIndex = 2;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // InputIMEIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 131);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "InputIMEIForm";
            this.Text = "Input IMEI";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_IEMI;
        private System.Windows.Forms.Button Button_OK;
    }
}