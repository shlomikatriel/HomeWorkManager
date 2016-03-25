namespace HomeWorkManager
{
    partial class frmMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaster));
            this.gboAddAssignment = new System.Windows.Forms.GroupBox();
            this.lblDateSelect = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.btnAddAssignment = new System.Windows.Forms.Button();
            this.lblAssignmentName = new System.Windows.Forms.Label();
            this.txtAssigmentName = new System.Windows.Forms.TextBox();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gboAssignmentList = new System.Windows.Forms.GroupBox();
            this.pnlAssignmentList = new System.Windows.Forms.Panel();
            this.lblAssignmentList = new System.Windows.Forms.Label();
            this.btnFinishAssignment = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblChooseAssignment = new System.Windows.Forms.Label();
            this.cboChooseAssignment = new System.Windows.Forms.ComboBox();
            this.gboAddAssignment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gboAssignmentList.SuspendLayout();
            this.pnlAssignmentList.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboAddAssignment
            // 
            this.gboAddAssignment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gboAddAssignment.Controls.Add(this.lblDateSelect);
            this.gboAddAssignment.Controls.Add(this.txtCourseName);
            this.gboAddAssignment.Controls.Add(this.lblCourseName);
            this.gboAddAssignment.Controls.Add(this.btnAddAssignment);
            this.gboAddAssignment.Controls.Add(this.lblAssignmentName);
            this.gboAddAssignment.Controls.Add(this.txtAssigmentName);
            this.gboAddAssignment.Controls.Add(this.calendar);
            this.gboAddAssignment.Location = new System.Drawing.Point(9, 12);
            this.gboAddAssignment.Name = "gboAddAssignment";
            this.gboAddAssignment.Padding = new System.Windows.Forms.Padding(10);
            this.gboAddAssignment.Size = new System.Drawing.Size(259, 304);
            this.gboAddAssignment.TabIndex = 0;
            this.gboAddAssignment.TabStop = false;
            this.gboAddAssignment.Text = "הוסף מטלה";
            // 
            // lblDateSelect
            // 
            this.lblDateSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateSelect.AutoSize = true;
            this.lblDateSelect.Location = new System.Drawing.Point(170, 69);
            this.lblDateSelect.Name = "lblDateSelect";
            this.lblDateSelect.Padding = new System.Windows.Forms.Padding(5);
            this.lblDateSelect.Size = new System.Drawing.Size(76, 23);
            this.lblDateSelect.TabIndex = 6;
            this.lblDateSelect.Text = "בחר תאריך:";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCourseName.Location = new System.Drawing.Point(16, 26);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(153, 20);
            this.txtCourseName.TabIndex = 3;
            // 
            // lblCourseName
            // 
            this.lblCourseName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(185, 23);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Padding = new System.Windows.Forms.Padding(5);
            this.lblCourseName.Size = new System.Drawing.Size(61, 23);
            this.lblCourseName.TabIndex = 4;
            this.lblCourseName.Text = "שם קורס";
            // 
            // btnAddAssignment
            // 
            this.btnAddAssignment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAssignment.Location = new System.Drawing.Point(168, 267);
            this.btnAddAssignment.Name = "btnAddAssignment";
            this.btnAddAssignment.Size = new System.Drawing.Size(75, 23);
            this.btnAddAssignment.TabIndex = 1;
            this.btnAddAssignment.Text = "הוסף";
            this.btnAddAssignment.UseVisualStyleBackColor = true;
            this.btnAddAssignment.Click += new System.EventHandler(this.btnAddAssignment_Click);
            // 
            // lblAssignmentName
            // 
            this.lblAssignmentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAssignmentName.AutoSize = true;
            this.lblAssignmentName.Location = new System.Drawing.Point(175, 46);
            this.lblAssignmentName.Name = "lblAssignmentName";
            this.lblAssignmentName.Padding = new System.Windows.Forms.Padding(5);
            this.lblAssignmentName.Size = new System.Drawing.Size(71, 23);
            this.lblAssignmentName.TabIndex = 2;
            this.lblAssignmentName.Text = "שם המטלה";
            // 
            // txtAssigmentName
            // 
            this.txtAssigmentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAssigmentName.Location = new System.Drawing.Point(16, 49);
            this.txtAssigmentName.Name = "txtAssigmentName";
            this.txtAssigmentName.Size = new System.Drawing.Size(153, 20);
            this.txtAssigmentName.TabIndex = 5;
            // 
            // calendar
            // 
            this.calendar.AllowDrop = true;
            this.calendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.calendar.Location = new System.Drawing.Point(16, 97);
            this.calendar.Margin = new System.Windows.Forms.Padding(5);
            this.calendar.MaxSelectionCount = 1;
            this.calendar.MinDate = new System.DateTime(1769, 7, 6, 0, 0, 0, 0);
            this.calendar.Name = "calendar";
            this.calendar.RightToLeftLayout = true;
            this.calendar.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.Location = new System.Drawing.Point(707, 290);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "צא";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(594, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // gboAssignmentList
            // 
            this.gboAssignmentList.Controls.Add(this.pnlAssignmentList);
            this.gboAssignmentList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gboAssignmentList.Location = new System.Drawing.Point(279, 12);
            this.gboAssignmentList.Name = "gboAssignmentList";
            this.gboAssignmentList.Size = new System.Drawing.Size(309, 304);
            this.gboAssignmentList.TabIndex = 3;
            this.gboAssignmentList.TabStop = false;
            this.gboAssignmentList.Text = "רשימת המטלות";
            // 
            // pnlAssignmentList
            // 
            this.pnlAssignmentList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAssignmentList.AutoScroll = true;
            this.pnlAssignmentList.Controls.Add(this.lblAssignmentList);
            this.pnlAssignmentList.Location = new System.Drawing.Point(6, 19);
            this.pnlAssignmentList.Name = "pnlAssignmentList";
            this.pnlAssignmentList.Size = new System.Drawing.Size(297, 279);
            this.pnlAssignmentList.TabIndex = 4;
            // 
            // lblAssignmentList
            // 
            this.lblAssignmentList.AutoSize = true;
            this.lblAssignmentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAssignmentList.Location = new System.Drawing.Point(94, 10);
            this.lblAssignmentList.Margin = new System.Windows.Forms.Padding(10);
            this.lblAssignmentList.Name = "lblAssignmentList";
            this.lblAssignmentList.Size = new System.Drawing.Size(141, 13);
            this.lblAssignmentList.TabIndex = 0;
            this.lblAssignmentList.Text = "כאן תופיע רשימת המטלות";
            // 
            // btnFinishAssignment
            // 
            this.btnFinishAssignment.Location = new System.Drawing.Point(707, 182);
            this.btnFinishAssignment.Name = "btnFinishAssignment";
            this.btnFinishAssignment.Size = new System.Drawing.Size(75, 23);
            this.btnFinishAssignment.TabIndex = 1;
            this.btnFinishAssignment.Text = "סיים מטלה";
            this.btnFinishAssignment.UseVisualStyleBackColor = true;
            this.btnFinishAssignment.Click += new System.EventHandler(this.btnFinishAssignment_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(594, 182);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "הגש מטלה";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblChooseAssignment
            // 
            this.lblChooseAssignment.AutoSize = true;
            this.lblChooseAssignment.Location = new System.Drawing.Point(594, 208);
            this.lblChooseAssignment.Name = "lblChooseAssignment";
            this.lblChooseAssignment.Size = new System.Drawing.Size(61, 13);
            this.lblChooseAssignment.TabIndex = 4;
            this.lblChooseAssignment.Text = "בחר מטלה:";
            // 
            // cboChooseAssignment
            // 
            this.cboChooseAssignment.FormattingEnabled = true;
            this.cboChooseAssignment.Location = new System.Drawing.Point(598, 225);
            this.cboChooseAssignment.MaxDropDownItems = 10;
            this.cboChooseAssignment.Name = "cboChooseAssignment";
            this.cboChooseAssignment.Size = new System.Drawing.Size(184, 21);
            this.cboChooseAssignment.TabIndex = 5;
            // 
            // frmMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 325);
            this.ControlBox = false;
            this.Controls.Add(this.cboChooseAssignment);
            this.Controls.Add(this.lblChooseAssignment);
            this.Controls.Add(this.gboAssignmentList);
            this.Controls.Add(this.btnFinishAssignment);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gboAddAssignment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMaster";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "מנהל מטלות              ע\"י שלומי כתריאל";
            this.gboAddAssignment.ResumeLayout(false);
            this.gboAddAssignment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gboAssignmentList.ResumeLayout(false);
            this.pnlAssignmentList.ResumeLayout(false);
            this.pnlAssignmentList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboAddAssignment;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label lblAssignmentName;
        private System.Windows.Forms.Button btnAddAssignment;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblDateSelect;
        private System.Windows.Forms.TextBox txtAssigmentName;
        private System.Windows.Forms.GroupBox gboAssignmentList;
        private System.Windows.Forms.Label lblAssignmentList;
        private System.Windows.Forms.Button btnFinishAssignment;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel pnlAssignmentList;
        private System.Windows.Forms.Label lblChooseAssignment;
        private System.Windows.Forms.ComboBox cboChooseAssignment;
    }
}

