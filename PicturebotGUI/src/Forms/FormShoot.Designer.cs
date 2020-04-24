﻿namespace PicturebotGUI
{
    partial class FormShoot
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
            this.lbRaw = new System.Windows.Forms.ListBox();
            this.dtShoot = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.bgwBackup = new System.ComponentModel.BackgroundWorker();
            this.bgwConvert = new System.ComponentModel.BackgroundWorker();
            this.bgwHash = new System.ComponentModel.BackgroundWorker();
            this.bgwMove = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutAddShoot = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutAddInformation = new System.Windows.Forms.TableLayoutPanel();
            this.pbSaveShoot = new System.Windows.Forms.PictureBox();
            this.panelAddPictures = new System.Windows.Forms.Panel();
            this.panelLabelAddPictures = new System.Windows.Forms.Panel();
            this.lblAddPictures = new System.Windows.Forms.Label();
            this.tableLayoutAddShoot.SuspendLayout();
            this.tableLayoutAddInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSaveShoot)).BeginInit();
            this.panelAddPictures.SuspendLayout();
            this.panelLabelAddPictures.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbRaw
            // 
            this.lbRaw.AllowDrop = true;
            this.lbRaw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            this.lbRaw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbRaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRaw.Enabled = false;
            this.lbRaw.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbRaw.ForeColor = System.Drawing.Color.White;
            this.lbRaw.FormattingEnabled = true;
            this.lbRaw.ItemHeight = 17;
            this.lbRaw.Location = new System.Drawing.Point(0, 42);
            this.lbRaw.Name = "lbRaw";
            this.lbRaw.Size = new System.Drawing.Size(310, 347);
            this.lbRaw.TabIndex = 1;
            this.lbRaw.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbRaw_DragDrop);
            this.lbRaw.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbRaw_DragEnter);
            // 
            // dtShoot
            // 
            this.dtShoot.CustomFormat = "dd-MM-yyyy";
            this.dtShoot.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtShoot.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtShoot.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtShoot.Location = new System.Drawing.Point(69, 37);
            this.dtShoot.Name = "dtShoot";
            this.dtShoot.Size = new System.Drawing.Size(169, 25);
            this.dtShoot.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            this.txtName.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(69, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(169, 25);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(3, 42);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(60, 17);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(3, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // bgwBackup
            // 
            this.bgwBackup.WorkerReportsProgress = true;
            this.bgwBackup.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwBackup_DoWork);
            this.bgwBackup.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwBackup_ProgressChanged);
            this.bgwBackup.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwBackup_RunWorkerCompleted);
            // 
            // bgwConvert
            // 
            this.bgwConvert.WorkerReportsProgress = true;
            this.bgwConvert.WorkerSupportsCancellation = true;
            this.bgwConvert.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwConvert_DoWork);
            this.bgwConvert.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwConvert_ProgressChanged);
            this.bgwConvert.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwConvert_RunWorkerCompleted);
            // 
            // bgwHash
            // 
            this.bgwHash.WorkerReportsProgress = true;
            this.bgwHash.WorkerSupportsCancellation = true;
            this.bgwHash.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwHash_DoWork);
            this.bgwHash.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwHash_ProgressChanged);
            this.bgwHash.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwHash_RunWorkerCompleted);
            // 
            // bgwMove
            // 
            this.bgwMove.WorkerReportsProgress = true;
            this.bgwMove.WorkerSupportsCancellation = true;
            this.bgwMove.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMove_DoWork);
            this.bgwMove.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwMove_ProgressChanged);
            this.bgwMove.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMove_RunWorkerCompleted);
            // 
            // tableLayoutAddShoot
            // 
            this.tableLayoutAddShoot.ColumnCount = 2;
            this.tableLayoutAddShoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.02913F));
            this.tableLayoutAddShoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.97087F));
            this.tableLayoutAddShoot.Controls.Add(this.tableLayoutAddInformation, 0, 0);
            this.tableLayoutAddShoot.Controls.Add(this.pbSaveShoot, 1, 1);
            this.tableLayoutAddShoot.Controls.Add(this.panelAddPictures, 1, 0);
            this.tableLayoutAddShoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutAddShoot.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutAddShoot.Name = "tableLayoutAddShoot";
            this.tableLayoutAddShoot.RowCount = 2;
            this.tableLayoutAddShoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.16666F));
            this.tableLayoutAddShoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.tableLayoutAddShoot.Size = new System.Drawing.Size(618, 500);
            this.tableLayoutAddShoot.TabIndex = 3;
            // 
            // tableLayoutAddInformation
            // 
            this.tableLayoutAddInformation.ColumnCount = 2;
            this.tableLayoutAddInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.42991F));
            this.tableLayoutAddInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.57009F));
            this.tableLayoutAddInformation.Controls.Add(this.dtShoot, 1, 1);
            this.tableLayoutAddInformation.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutAddInformation.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutAddInformation.Controls.Add(this.lblDate, 0, 1);
            this.tableLayoutAddInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutAddInformation.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutAddInformation.Name = "tableLayoutAddInformation";
            this.tableLayoutAddInformation.RowCount = 3;
            this.tableLayoutAddInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutAddInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutAddInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tableLayoutAddInformation.Size = new System.Drawing.Size(296, 389);
            this.tableLayoutAddInformation.TabIndex = 0;
            // 
            // pbSaveShoot
            // 
            this.pbSaveShoot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSaveShoot.BackgroundImage = global::PicturebotGUI.Properties.Resources.Save;
            this.pbSaveShoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbSaveShoot.Location = new System.Drawing.Point(305, 422);
            this.pbSaveShoot.Name = "pbSaveShoot";
            this.pbSaveShoot.Size = new System.Drawing.Size(310, 50);
            this.pbSaveShoot.TabIndex = 2;
            this.pbSaveShoot.TabStop = false;
            this.pbSaveShoot.Click += new System.EventHandler(this.pbSaveShoot_Click);
            // 
            // panelAddPictures
            // 
            this.panelAddPictures.Controls.Add(this.lbRaw);
            this.panelAddPictures.Controls.Add(this.panelLabelAddPictures);
            this.panelAddPictures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddPictures.Location = new System.Drawing.Point(305, 3);
            this.panelAddPictures.Name = "panelAddPictures";
            this.panelAddPictures.Size = new System.Drawing.Size(310, 389);
            this.panelAddPictures.TabIndex = 3;
            // 
            // panelLabelAddPictures
            // 
            this.panelLabelAddPictures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.panelLabelAddPictures.Controls.Add(this.lblAddPictures);
            this.panelLabelAddPictures.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLabelAddPictures.Location = new System.Drawing.Point(0, 0);
            this.panelLabelAddPictures.Name = "panelLabelAddPictures";
            this.panelLabelAddPictures.Size = new System.Drawing.Size(310, 42);
            this.panelLabelAddPictures.TabIndex = 0;
            // 
            // lblAddPictures
            // 
            this.lblAddPictures.AutoSize = true;
            this.lblAddPictures.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAddPictures.Font = new System.Drawing.Font("Tahoma", 21F);
            this.lblAddPictures.Location = new System.Drawing.Point(0, 0);
            this.lblAddPictures.Name = "lblAddPictures";
            this.lblAddPictures.Size = new System.Drawing.Size(180, 34);
            this.lblAddPictures.TabIndex = 0;
            this.lblAddPictures.Text = "RAW pictures";
            // 
            // FormShoot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(618, 500);
            this.Controls.Add(this.tableLayoutAddShoot);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormShoot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add a new shoot";
            this.tableLayoutAddShoot.ResumeLayout(false);
            this.tableLayoutAddInformation.ResumeLayout(false);
            this.tableLayoutAddInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSaveShoot)).EndInit();
            this.panelAddPictures.ResumeLayout(false);
            this.panelLabelAddPictures.ResumeLayout(false);
            this.panelLabelAddPictures.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lbRaw;
        private System.Windows.Forms.DateTimePicker dtShoot;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblName;
        private System.ComponentModel.BackgroundWorker bgwBackup;
        private System.ComponentModel.BackgroundWorker bgwConvert;
        private System.ComponentModel.BackgroundWorker bgwHash;
        private System.ComponentModel.BackgroundWorker bgwMove;
        private System.Windows.Forms.TableLayoutPanel tableLayoutAddShoot;
        private System.Windows.Forms.TableLayoutPanel tableLayoutAddInformation;
        private System.Windows.Forms.PictureBox pbSaveShoot;
        private System.Windows.Forms.Panel panelAddPictures;
        private System.Windows.Forms.Panel panelLabelAddPictures;
        private System.Windows.Forms.Label lblAddPictures;
    }
}