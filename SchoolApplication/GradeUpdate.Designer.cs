namespace SchoolApplication
{
    partial class GradeUpdate
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
            this.btnUpdateCourse = new System.Windows.Forms.Button();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.nudGradeNumber = new System.Windows.Forms.NumericUpDown();
            this.lblGradeNumber = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudGradeNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateCourse
            // 
            this.btnUpdateCourse.Location = new System.Drawing.Point(132, 95);
            this.btnUpdateCourse.Name = "btnUpdateCourse";
            this.btnUpdateCourse.Size = new System.Drawing.Size(121, 23);
            this.btnUpdateCourse.TabIndex = 9;
            this.btnUpdateCourse.Text = "Update Grade";
            this.btnUpdateCourse.UseVisualStyleBackColor = true;
            this.btnUpdateCourse.Click += new System.EventHandler(this.btnUpdateCourse_Click);
            // 
            // cmbSection
            // 
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(132, 67);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(121, 21);
            this.cmbSection.TabIndex = 8;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Location = new System.Drawing.Point(71, 70);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(43, 13);
            this.lblSection.TabIndex = 7;
            this.lblSection.Text = "Section";
            // 
            // nudGradeNumber
            // 
            this.nudGradeNumber.Location = new System.Drawing.Point(132, 34);
            this.nudGradeNumber.Name = "nudGradeNumber";
            this.nudGradeNumber.Size = new System.Drawing.Size(120, 20);
            this.nudGradeNumber.TabIndex = 6;
            this.nudGradeNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblGradeNumber
            // 
            this.lblGradeNumber.AutoSize = true;
            this.lblGradeNumber.Location = new System.Drawing.Point(78, 36);
            this.lblGradeNumber.Name = "lblGradeNumber";
            this.lblGradeNumber.Size = new System.Drawing.Size(36, 13);
            this.lblGradeNumber.TabIndex = 5;
            this.lblGradeNumber.Text = "Grade";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(131, 129);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete Grade";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // GradeUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 164);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdateCourse);
            this.Controls.Add(this.cmbSection);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.nudGradeNumber);
            this.Controls.Add(this.lblGradeNumber);
            this.Name = "GradeUpdate";
            this.Text = "GradeUpdate";
            ((System.ComponentModel.ISupportInitialize)(this.nudGradeNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateCourse;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.NumericUpDown nudGradeNumber;
        private System.Windows.Forms.Label lblGradeNumber;
        private System.Windows.Forms.Button btnDelete;
    }
}