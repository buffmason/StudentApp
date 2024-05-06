namespace StudentApp
{
    partial class MainForm
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
            this.dataTab = new System.Windows.Forms.TabControl();
            this.tbStudentInfo = new System.Windows.Forms.TabPage();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.tbStudentGrade = new System.Windows.Forms.TabPage();
            this.btnExport = new System.Windows.Forms.Button();
            this.lstData = new System.Windows.Forms.ListBox();
            this.dataTab.SuspendLayout();
            this.tbStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.tbStudentGrade.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTab
            // 
            this.dataTab.Controls.Add(this.tbStudentInfo);
            this.dataTab.Controls.Add(this.tbStudentGrade);
            this.dataTab.Location = new System.Drawing.Point(130, 53);
            this.dataTab.Name = "dataTab";
            this.dataTab.SelectedIndex = 0;
            this.dataTab.Size = new System.Drawing.Size(833, 483);
            this.dataTab.TabIndex = 0;
            this.dataTab.SelectedIndexChanged += new System.EventHandler(this.dataTab_SelectedIndexChanged);
            // 
            // tbStudentInfo
            // 
            this.tbStudentInfo.Controls.Add(this.btnDisplay);
            this.tbStudentInfo.Controls.Add(this.btnInsert);
            this.tbStudentInfo.Controls.Add(this.grdData);
            this.tbStudentInfo.Controls.Add(this.txtScore);
            this.tbStudentInfo.Controls.Add(this.lblScore);
            this.tbStudentInfo.Controls.Add(this.txtName);
            this.tbStudentInfo.Controls.Add(this.lblName);
            this.tbStudentInfo.Controls.Add(this.txtId);
            this.tbStudentInfo.Controls.Add(this.lblId);
            this.tbStudentInfo.Location = new System.Drawing.Point(4, 29);
            this.tbStudentInfo.Name = "tbStudentInfo";
            this.tbStudentInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbStudentInfo.Size = new System.Drawing.Size(825, 450);
            this.tbStudentInfo.TabIndex = 0;
            this.tbStudentInfo.Text = "Student Info";
            this.tbStudentInfo.UseVisualStyleBackColor = true;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(216, 321);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(138, 50);
            this.btnDisplay.TabIndex = 8;
            this.btnDisplay.Text = "Display Data";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(23, 321);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(121, 50);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert Data";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // grdData
            // 
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Location = new System.Drawing.Point(389, 34);
            this.grdData.Name = "grdData";
            this.grdData.RowHeadersWidth = 62;
            this.grdData.RowTemplate.Height = 28;
            this.grdData.Size = new System.Drawing.Size(430, 358);
            this.grdData.TabIndex = 6;
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(229, 205);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(138, 31);
            this.txtScore.TabIndex = 5;
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(18, 205);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(194, 34);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Enter Student Score";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(229, 127);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(138, 31);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(18, 127);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(194, 34);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Enter Student Name";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(229, 51);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(138, 31);
            this.txtId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(33, 51);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(151, 34);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Enter Student ID";
            // 
            // tbStudentGrade
            // 
            this.tbStudentGrade.Controls.Add(this.btnExport);
            this.tbStudentGrade.Controls.Add(this.lstData);
            this.tbStudentGrade.Location = new System.Drawing.Point(4, 29);
            this.tbStudentGrade.Name = "tbStudentGrade";
            this.tbStudentGrade.Padding = new System.Windows.Forms.Padding(3);
            this.tbStudentGrade.Size = new System.Drawing.Size(825, 450);
            this.tbStudentGrade.TabIndex = 1;
            this.tbStudentGrade.Text = "Student Grade";
            this.tbStudentGrade.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(331, 40);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(145, 48);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export Data";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lstData
            // 
            this.lstData.FormattingEnabled = true;
            this.lstData.ItemHeight = 20;
            this.lstData.Location = new System.Drawing.Point(39, 111);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(744, 324);
            this.lstData.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 593);
            this.Controls.Add(this.dataTab);
            this.Name = "MainForm";
            this.Text = "Student App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.dataTab.ResumeLayout(false);
            this.tbStudentInfo.ResumeLayout(false);
            this.tbStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.tbStudentGrade.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl dataTab;
        private System.Windows.Forms.TabPage tbStudentInfo;
        private System.Windows.Forms.TabPage tbStudentGrade;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ListBox lstData;
        private System.Windows.Forms.Button btnExport;
    }
}

