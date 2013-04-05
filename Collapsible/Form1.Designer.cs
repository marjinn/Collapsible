﻿namespace Collapsible
{
    partial class CP
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CP));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelFileDownloadSize = new System.Windows.Forms.Label();
            this.labelProgressPercentage = new System.Windows.Forms.Label();
            this.bottomLabelProgress = new System.Windows.Forms.Label();
            this.topLabelProgress = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Details = new System.Windows.Forms.Label();
            this.textBoxDetail = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Maroon;
            this.progressBar1.Location = new System.Drawing.Point(15, 20);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(493, 23);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.UseWaitCursor = true;
            // 
            // labelFileDownloadSize
            // 
            this.labelFileDownloadSize.AutoSize = true;
            this.labelFileDownloadSize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelFileDownloadSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileDownloadSize.ForeColor = System.Drawing.Color.White;
            this.labelFileDownloadSize.Location = new System.Drawing.Point(527, 95);
            this.labelFileDownloadSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFileDownloadSize.Name = "labelFileDownloadSize";
            this.labelFileDownloadSize.Size = new System.Drawing.Size(151, 16);
            this.labelFileDownloadSize.TabIndex = 15;
            this.labelFileDownloadSize.Text = "1024000/1024000 MB";
            this.labelFileDownloadSize.UseWaitCursor = true;
            // 
            // labelProgressPercentage
            // 
            this.labelProgressPercentage.AutoSize = true;
            this.labelProgressPercentage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelProgressPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgressPercentage.ForeColor = System.Drawing.Color.White;
            this.labelProgressPercentage.Location = new System.Drawing.Point(635, 18);
            this.labelProgressPercentage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProgressPercentage.Name = "labelProgressPercentage";
            this.labelProgressPercentage.Size = new System.Drawing.Size(49, 16);
            this.labelProgressPercentage.TabIndex = 14;
            this.labelProgressPercentage.Text = "100 %";
            this.labelProgressPercentage.UseWaitCursor = true;
            // 
            // bottomLabelProgress
            // 
            this.bottomLabelProgress.AutoSize = true;
            this.bottomLabelProgress.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bottomLabelProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomLabelProgress.ForeColor = System.Drawing.Color.White;
            this.bottomLabelProgress.Location = new System.Drawing.Point(199, 95);
            this.bottomLabelProgress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bottomLabelProgress.Name = "bottomLabelProgress";
            this.bottomLabelProgress.Size = new System.Drawing.Size(142, 16);
            this.bottomLabelProgress.TabIndex = 11;
            this.bottomLabelProgress.Text = "CheckThisSpace ...";
            this.bottomLabelProgress.UseWaitCursor = true;
            // 
            // topLabelProgress
            // 
            this.topLabelProgress.AutoSize = true;
            this.topLabelProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabelProgress.ForeColor = System.Drawing.Color.White;
            this.topLabelProgress.Location = new System.Drawing.Point(171, 18);
            this.topLabelProgress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.topLabelProgress.Name = "topLabelProgress";
            this.topLabelProgress.Size = new System.Drawing.Size(468, 16);
            this.topLabelProgress.TabIndex = 10;
            this.topLabelProgress.Text = "Staples® EasyTech™ SBC Performance Optimization In Progress... ";
            this.topLabelProgress.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Location = new System.Drawing.Point(161, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 57);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(14, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 85);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 67);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCollapse);
            this.groupBox3.Controls.Add(this.bottomLabelProgress);
            this.groupBox3.Controls.Add(this.labelFileDownloadSize);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(6, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(690, 122);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // btnCollapse
            // 
            this.btnCollapse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCollapse.FlatAppearance.BorderSize = 0;
            this.btnCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollapse.ForeColor = System.Drawing.Color.Transparent;
            this.btnCollapse.Image = global::Collapsible.Properties.Resources.downarrowfw;
            this.btnCollapse.Location = new System.Drawing.Point(170, 91);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(24, 24);
            this.btnCollapse.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnCollapse, "More Details");
            this.btnCollapse.UseVisualStyleBackColor = true;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            this.btnCollapse.MouseEnter += new System.EventHandler(this.btnCollapse_MouseEnter);
            this.btnCollapse.MouseLeave += new System.EventHandler(this.btnCollapse_MouseLeave);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolTip1.ForeColor = System.Drawing.Color.White;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox4.Controls.Add(this.textBoxDetail);
            this.groupBox4.Controls.Add(this.Details);
            this.groupBox4.Location = new System.Drawing.Point(6, 125);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(690, 227);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            // 
            // Details
            // 
            this.Details.AutoSize = true;
            this.Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Details.ForeColor = System.Drawing.Color.White;
            this.Details.Location = new System.Drawing.Point(569, 51);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(94, 16);
            this.Details.TabIndex = 2;
            this.Details.Text = "View Details";
            // 
            // textBoxDetail
            // 
            this.textBoxDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.textBoxDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDetail.ForeColor = System.Drawing.Color.White;
            this.textBoxDetail.Location = new System.Drawing.Point(13, 37);
            this.textBoxDetail.Multiline = true;
            this.textBoxDetail.Name = "textBoxDetail";
            this.textBoxDetail.ReadOnly = true;
            this.textBoxDetail.Size = new System.Drawing.Size(662, 102);
            this.textBoxDetail.TabIndex = 3;
            // 
            // CP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(702, 430);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.labelProgressPercentage);
            this.Controls.Add(this.topLabelProgress);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CP";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelFileDownloadSize;
        private System.Windows.Forms.Label labelProgressPercentage;
        private System.Windows.Forms.Label bottomLabelProgress;
        private System.Windows.Forms.Label topLabelProgress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxDetail;
        private System.Windows.Forms.Label Details;
    }
}

