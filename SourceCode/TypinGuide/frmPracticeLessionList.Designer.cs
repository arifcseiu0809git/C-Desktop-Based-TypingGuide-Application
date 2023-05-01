namespace prjTypinGuide
{
    partial class frmPracticeLessionList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPracticeLessionList));
            this.dgvLessonList = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLessonUpload = new System.Windows.Forms.Button();
            this.btnLessonDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLessonList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLessonList
            // 
            this.dgvLessonList.AllowUserToAddRows = false;
            this.dgvLessonList.AllowUserToDeleteRows = false;
            this.dgvLessonList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLessonList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.FileContent});
            this.dgvLessonList.Location = new System.Drawing.Point(11, 0);
            this.dgvLessonList.Name = "dgvLessonList";
            this.dgvLessonList.ReadOnly = true;
            this.dgvLessonList.RowHeadersVisible = false;
            this.dgvLessonList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLessonList.Size = new System.Drawing.Size(582, 394);
            this.dgvLessonList.TabIndex = 0;
            // 
            // FileName
            // 
            this.FileName.DataPropertyName = "FileName";
            this.FileName.HeaderText = "File Name";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Width = 270;
            // 
            // FileContent
            // 
            this.FileContent.DataPropertyName = "FileContent";
            this.FileContent.HeaderText = "File Content";
            this.FileContent.Name = "FileContent";
            this.FileContent.ReadOnly = true;
            this.FileContent.Width = 300;
            // 
            // btnLessonUpload
            // 
            this.btnLessonUpload.FlatAppearance.BorderSize = 0;
            this.btnLessonUpload.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLessonUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLessonUpload.Location = new System.Drawing.Point(604, 10);
            this.btnLessonUpload.Name = "btnLessonUpload";
            this.btnLessonUpload.Size = new System.Drawing.Size(116, 41);
            this.btnLessonUpload.TabIndex = 1;
            this.btnLessonUpload.Text = "Upload Lession";
            this.btnLessonUpload.UseVisualStyleBackColor = true;
            this.btnLessonUpload.Click += new System.EventHandler(this.btnLessonUpload_Click);
            this.btnLessonUpload.Paint += new System.Windows.Forms.PaintEventHandler(this.btnLessonUpload_Paint);
            // 
            // btnLessonDel
            // 
            this.btnLessonDel.Location = new System.Drawing.Point(604, 61);
            this.btnLessonDel.Name = "btnLessonDel";
            this.btnLessonDel.Size = new System.Drawing.Size(118, 41);
            this.btnLessonDel.TabIndex = 2;
            this.btnLessonDel.Text = "Delete";
            this.btnLessonDel.UseVisualStyleBackColor = true;
            this.btnLessonDel.Click += new System.EventHandler(this.btnLessonDel_Click);
            this.btnLessonDel.Paint += new System.Windows.Forms.PaintEventHandler(this.btnLessonUpload_Paint);
            // 
            // frmPracticeLessionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 403);
            this.Controls.Add(this.btnLessonDel);
            this.Controls.Add(this.btnLessonUpload);
            this.Controls.Add(this.dgvLessonList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPracticeLessionList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Typing Guide";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPracticeLessionList_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLessonList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLessonList;
        private System.Windows.Forms.Button btnLessonUpload;
        private System.Windows.Forms.Button btnLessonDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileContent;
    }
}