namespace UPC
{
    partial class FrmCourses
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
            this.gbCourseInformation = new System.Windows.Forms.GroupBox();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCareer = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.cbCareer = new System.Windows.Forms.ComboBox();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbCourseList = new System.Windows.Forms.GroupBox();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.careerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.careerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsByCoursesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.careerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.coursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gbCourseInformation.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.gbCourseList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCourseInformation
            // 
            this.gbCourseInformation.Controls.Add(this.lblCredits);
            this.gbCourseInformation.Controls.Add(this.lblArea);
            this.gbCourseInformation.Controls.Add(this.lblName);
            this.gbCourseInformation.Controls.Add(this.lblCareer);
            this.gbCourseInformation.Controls.Add(this.lblId);
            this.gbCourseInformation.Controls.Add(this.cbCareer);
            this.gbCourseInformation.Controls.Add(this.txtCredits);
            this.gbCourseInformation.Controls.Add(this.txtArea);
            this.gbCourseInformation.Controls.Add(this.txtName);
            this.gbCourseInformation.Controls.Add(this.txtId);
            this.gbCourseInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCourseInformation.Location = new System.Drawing.Point(0, 0);
            this.gbCourseInformation.Name = "gbCourseInformation";
            this.gbCourseInformation.Size = new System.Drawing.Size(554, 161);
            this.gbCourseInformation.TabIndex = 0;
            this.gbCourseInformation.TabStop = false;
            this.gbCourseInformation.Text = "Course Information";
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(6, 127);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(39, 13);
            this.lblCredits.TabIndex = 9;
            this.lblCredits.Text = "Credits";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(6, 101);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(29, 13);
            this.lblArea.TabIndex = 8;
            this.lblArea.Text = "Area";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // lblCareer
            // 
            this.lblCareer.AutoSize = true;
            this.lblCareer.Location = new System.Drawing.Point(6, 48);
            this.lblCareer.Name = "lblCareer";
            this.lblCareer.Size = new System.Drawing.Size(38, 13);
            this.lblCareer.TabIndex = 6;
            this.lblCareer.Text = "Career";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(6, 22);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "Id";
            // 
            // cbCareer
            // 
            this.cbCareer.DisplayMember = "Name";
            this.cbCareer.FormattingEnabled = true;
            this.cbCareer.Location = new System.Drawing.Point(51, 45);
            this.cbCareer.Name = "cbCareer";
            this.cbCareer.Size = new System.Drawing.Size(179, 21);
            this.cbCareer.TabIndex = 4;
            this.cbCareer.ValueMember = "Id";
            // 
            // txtCredits
            // 
            this.txtCredits.Location = new System.Drawing.Point(51, 124);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(30, 20);
            this.txtCredits.TabIndex = 3;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(51, 98);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(179, 20);
            this.txtArea.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(51, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(179, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(51, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(30, 20);
            this.txtId.TabIndex = 0;
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.btnDelete);
            this.gbOptions.Controls.Add(this.btnUpdate);
            this.gbOptions.Controls.Add(this.btnAdd);
            this.gbOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbOptions.Location = new System.Drawing.Point(0, 161);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(554, 52);
            this.gbOptions.TabIndex = 1;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(169, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(87, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbCourseList
            // 
            this.gbCourseList.Controls.Add(this.dgvCourses);
            this.gbCourseList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCourseList.Location = new System.Drawing.Point(0, 213);
            this.gbCourseList.Name = "gbCourseList";
            this.gbCourseList.Size = new System.Drawing.Size(554, 239);
            this.gbCourseList.TabIndex = 2;
            this.gbCourseList.TabStop = false;
            this.gbCourseList.Text = "Course List";
            // 
            // dgvCourses
            // 
            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.AllowUserToDeleteRows = false;
            this.dgvCourses.AutoGenerateColumns = false;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.careerIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.creditsDataGridViewTextBoxColumn,
            this.careerDataGridViewTextBoxColumn,
            this.studentsByCoursesDataGridViewTextBoxColumn,
            this.careerNameDataGridViewTextBoxColumn});
            this.dgvCourses.DataSource = this.coursBindingSource2;
            this.dgvCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCourses.Location = new System.Drawing.Point(3, 16);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourses.Size = new System.Drawing.Size(548, 220);
            this.dgvCourses.TabIndex = 0;
            this.dgvCourses.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCourses_CellMouseClick);
            // 
            // IdColumn
            // 
            this.IdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Width = 41;
            // 
            // careerIdDataGridViewTextBoxColumn
            // 
            this.careerIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.careerIdDataGridViewTextBoxColumn.DataPropertyName = "CareerId";
            this.careerIdDataGridViewTextBoxColumn.HeaderText = "CareerId";
            this.careerIdDataGridViewTextBoxColumn.Name = "careerIdDataGridViewTextBoxColumn";
            this.careerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.careerIdDataGridViewTextBoxColumn.Width = 72;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 60;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Area";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.ReadOnly = true;
            this.areaDataGridViewTextBoxColumn.Width = 54;
            // 
            // creditsDataGridViewTextBoxColumn
            // 
            this.creditsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.creditsDataGridViewTextBoxColumn.DataPropertyName = "Credits";
            this.creditsDataGridViewTextBoxColumn.HeaderText = "Credits";
            this.creditsDataGridViewTextBoxColumn.Name = "creditsDataGridViewTextBoxColumn";
            this.creditsDataGridViewTextBoxColumn.ReadOnly = true;
            this.creditsDataGridViewTextBoxColumn.Width = 64;
            // 
            // careerDataGridViewTextBoxColumn
            // 
            this.careerDataGridViewTextBoxColumn.DataPropertyName = "Career";
            this.careerDataGridViewTextBoxColumn.HeaderText = "Career";
            this.careerDataGridViewTextBoxColumn.Name = "careerDataGridViewTextBoxColumn";
            this.careerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentsByCoursesDataGridViewTextBoxColumn
            // 
            this.studentsByCoursesDataGridViewTextBoxColumn.DataPropertyName = "StudentsByCourses";
            this.studentsByCoursesDataGridViewTextBoxColumn.HeaderText = "StudentsByCourses";
            this.studentsByCoursesDataGridViewTextBoxColumn.Name = "studentsByCoursesDataGridViewTextBoxColumn";
            this.studentsByCoursesDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentsByCoursesDataGridViewTextBoxColumn.Visible = false;
            // 
            // careerNameDataGridViewTextBoxColumn
            // 
            this.careerNameDataGridViewTextBoxColumn.DataPropertyName = "CareerName";
            this.careerNameDataGridViewTextBoxColumn.HeaderText = "CareerName";
            this.careerNameDataGridViewTextBoxColumn.Name = "careerNameDataGridViewTextBoxColumn";
            this.careerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coursBindingSource2
            // 
            this.coursBindingSource2.DataSource = typeof(Entities.Cours);
            // 
            // coursBindingSource
            // 
            this.coursBindingSource.DataSource = typeof(Entities.Cours);
            // 
            // coursBindingSource1
            // 
            this.coursBindingSource1.DataSource = typeof(Entities.Cours);
            // 
            // FrmCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 452);
            this.Controls.Add(this.gbCourseList);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.gbCourseInformation);
            this.Name = "FrmCourses";
            this.Text = "FrmCourses";
            this.Load += new System.EventHandler(this.FrmCourses_Load);
            this.gbCourseInformation.ResumeLayout(false);
            this.gbCourseInformation.PerformLayout();
            this.gbOptions.ResumeLayout(false);
            this.gbCourseList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCourseInformation;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.GroupBox gbCourseList;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCareer;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cbCareer;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.BindingSource coursBindingSource;
        private System.Windows.Forms.BindingSource coursBindingSource1;
        private System.Windows.Forms.BindingSource coursBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn careerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn careerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentsByCoursesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn careerNameDataGridViewTextBoxColumn;
    }
}