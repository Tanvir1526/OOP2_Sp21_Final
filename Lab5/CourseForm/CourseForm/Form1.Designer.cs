namespace CourseForm
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCname = new System.Windows.Forms.TextBox();
            this.tbCcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.LoadData = new System.Windows.Forms.Button();
            this.DtCourses = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Name";
            // 
            // tbCname
            // 
            this.tbCname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCname.Location = new System.Drawing.Point(190, 120);
            this.tbCname.Name = "tbCname";
            this.tbCname.Size = new System.Drawing.Size(130, 29);
            this.tbCname.TabIndex = 1;
            // 
            // tbCcode
            // 
            this.tbCcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCcode.Location = new System.Drawing.Point(190, 170);
            this.tbCcode.Name = "tbCcode";
            this.tbCcode.Size = new System.Drawing.Size(130, 29);
            this.tbCcode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Course Code";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(245, 279);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // LoadData
            // 
            this.LoadData.Location = new System.Drawing.Point(71, 279);
            this.LoadData.Name = "LoadData";
            this.LoadData.Size = new System.Drawing.Size(75, 23);
            this.LoadData.TabIndex = 5;
            this.LoadData.Text = "Load";
            this.LoadData.UseVisualStyleBackColor = true;
            this.LoadData.Click += new System.EventHandler(this.LoadData_Click);
            // 
            // DtCourses
            // 
            this.DtCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtCourses.Location = new System.Drawing.Point(360, 98);
            this.DtCourses.Name = "DtCourses";
            this.DtCourses.Size = new System.Drawing.Size(324, 215);
            this.DtCourses.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Course ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 349);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DtCourses);
            this.Controls.Add(this.LoadData);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbCcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DtCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCname;
        private System.Windows.Forms.TextBox tbCcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button LoadData;
        private System.Windows.Forms.DataGridView DtCourses;
        private System.Windows.Forms.Label label3;
    }
}

