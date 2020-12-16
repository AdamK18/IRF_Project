namespace IRF_Project
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
            this.list_students = new System.Windows.Forms.ListBox();
            this.label_students = new System.Windows.Forms.Label();
            this.label_shape = new System.Windows.Forms.Label();
            this.button_grade = new System.Windows.Forms.Button();
            this.button_export = new System.Windows.Forms.Button();
            this.label_grade = new System.Windows.Forms.Label();
            this.textbox_grade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // list_students
            // 
            this.list_students.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.list_students.ForeColor = System.Drawing.Color.White;
            this.list_students.FormattingEnabled = true;
            this.list_students.Location = new System.Drawing.Point(12, 41);
            this.list_students.Name = "list_students";
            this.list_students.Size = new System.Drawing.Size(140, 394);
            this.list_students.TabIndex = 0;
            this.list_students.SelectedIndexChanged += new System.EventHandler(this.list_students_SelectedIndexChanged);
            // 
            // label_students
            // 
            this.label_students.AutoSize = true;
            this.label_students.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_students.ForeColor = System.Drawing.Color.White;
            this.label_students.Location = new System.Drawing.Point(47, 9);
            this.label_students.Name = "label_students";
            this.label_students.Size = new System.Drawing.Size(74, 29);
            this.label_students.TabIndex = 1;
            this.label_students.Text = "Students";
            // 
            // label_shape
            // 
            this.label_shape.AutoSize = true;
            this.label_shape.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.label_shape.ForeColor = System.Drawing.Color.White;
            this.label_shape.Location = new System.Drawing.Point(416, 9);
            this.label_shape.Name = "label_shape";
            this.label_shape.Size = new System.Drawing.Size(56, 29);
            this.label_shape.TabIndex = 2;
            this.label_shape.Text = "Shape";
            this.label_shape.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_grade
            // 
            this.button_grade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.button_grade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(201)))), ((int)(((byte)(14)))));
            this.button_grade.Location = new System.Drawing.Point(31, 450);
            this.button_grade.Name = "button_grade";
            this.button_grade.Size = new System.Drawing.Size(100, 30);
            this.button_grade.TabIndex = 3;
            this.button_grade.Text = "Add grade";
            this.button_grade.UseVisualStyleBackColor = false;
            this.button_grade.Click += new System.EventHandler(this.button_grade_Click);
            // 
            // button_export
            // 
            this.button_export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.button_export.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(201)))), ((int)(((byte)(14)))));
            this.button_export.Location = new System.Drawing.Point(31, 519);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(100, 30);
            this.button_export.TabIndex = 4;
            this.button_export.Text = "Export to Excel";
            this.button_export.UseVisualStyleBackColor = false;
            this.button_export.Click += new System.EventHandler(this.button_export_Click);
            // 
            // label_grade
            // 
            this.label_grade.AutoSize = true;
            this.label_grade.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.label_grade.ForeColor = System.Drawing.Color.White;
            this.label_grade.Location = new System.Drawing.Point(714, 9);
            this.label_grade.Name = "label_grade";
            this.label_grade.Size = new System.Drawing.Size(58, 29);
            this.label_grade.TabIndex = 5;
            this.label_grade.Text = "Grade:";
            // 
            // textbox_grade
            // 
            this.textbox_grade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.textbox_grade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(201)))), ((int)(((byte)(14)))));
            this.textbox_grade.Location = new System.Drawing.Point(52, 486);
            this.textbox_grade.Name = "textbox_grade";
            this.textbox_grade.Size = new System.Drawing.Size(55, 20);
            this.textbox_grade.TabIndex = 6;
            this.textbox_grade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.textbox_grade);
            this.Controls.Add(this.label_grade);
            this.Controls.Add(this.button_export);
            this.Controls.Add(this.button_grade);
            this.Controls.Add(this.label_shape);
            this.Controls.Add(this.label_students);
            this.Controls.Add(this.list_students);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_students;
        private System.Windows.Forms.Label label_students;
        private System.Windows.Forms.Label label_shape;
        private System.Windows.Forms.Button button_grade;
        private System.Windows.Forms.Button button_export;
        private System.Windows.Forms.Label label_grade;
        private System.Windows.Forms.TextBox textbox_grade;
    }
}

