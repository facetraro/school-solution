namespace ERPSchoolUI
{
    partial class AddStudent
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.textLastNameStudent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textStudentNumber = new System.Windows.Forms.TextBox();
            this.listSubjects = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listSubjectsSelected = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.removeSubject = new System.Windows.Forms.Button();
            this.addSubject = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericY = new System.Windows.Forms.NumericUpDown();
            this.numericX = new System.Windows.Forms.NumericUpDown();
            this.textNameStudent = new System.Windows.Forms.TextBox();
            this.numericCi = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCi)).BeginInit();
            this.SuspendLayout();
            // 
            // textLastNameStudent
            // 
            this.textLastNameStudent.Location = new System.Drawing.Point(277, 263);
            this.textLastNameStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textLastNameStudent.Name = "textLastNameStudent";
            this.textLastNameStudent.Size = new System.Drawing.Size(223, 22);
            this.textLastNameStudent.TabIndex = 26;
            this.textLastNameStudent.TextChanged += new System.EventHandler(this.textLastNameStudent_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Apellido Estudiante:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(219, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 29);
            this.label5.TabIndex = 24;
            this.label5.Text = "Agregar un Alumno";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textStudentNumber
            // 
            this.textStudentNumber.Location = new System.Drawing.Point(277, 110);
            this.textStudentNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textStudentNumber.Name = "textStudentNumber";
            this.textStudentNumber.ReadOnly = true;
            this.textStudentNumber.Size = new System.Drawing.Size(223, 22);
            this.textStudentNumber.TabIndex = 23;
            this.textStudentNumber.TextChanged += new System.EventHandler(this.textStudentNumber_TextChanged);
            // 
            // listSubjects
            // 
            this.listSubjects.FormattingEnabled = true;
            this.listSubjects.ItemHeight = 16;
            this.listSubjects.Location = new System.Drawing.Point(72, 390);
            this.listSubjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listSubjects.Name = "listSubjects";
            this.listSubjects.Size = new System.Drawing.Size(181, 180);
            this.listSubjects.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Materias que esta inscripto:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Numero de Estudiante:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre Estudiante:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Cedula de Identidad: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // listSubjectsSelected
            // 
            this.listSubjectsSelected.FormattingEnabled = true;
            this.listSubjectsSelected.ItemHeight = 16;
            this.listSubjectsSelected.Location = new System.Drawing.Point(363, 390);
            this.listSubjectsSelected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listSubjectsSelected.Name = "listSubjectsSelected";
            this.listSubjectsSelected.Size = new System.Drawing.Size(181, 180);
            this.listSubjectsSelected.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(371, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Materias seleccionadas:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Materias totales:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // removeSubject
            // 
            this.removeSubject.Location = new System.Drawing.Point(291, 489);
            this.removeSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeSubject.Name = "removeSubject";
            this.removeSubject.Size = new System.Drawing.Size(52, 23);
            this.removeSubject.TabIndex = 31;
            this.removeSubject.Text = "<-";
            this.removeSubject.UseVisualStyleBackColor = true;
            this.removeSubject.Click += new System.EventHandler(this.removeSubject_Click);
            // 
            // addSubject
            // 
            this.addSubject.Location = new System.Drawing.Point(291, 422);
            this.addSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addSubject.Name = "addSubject";
            this.addSubject.Size = new System.Drawing.Size(52, 23);
            this.addSubject.TabIndex = 30;
            this.addSubject.Text = "->";
            this.addSubject.UseVisualStyleBackColor = true;
            this.addSubject.Click += new System.EventHandler(this.addSubject_Click);
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.Color.Transparent;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(31, 23);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(83, 71);
            this.backButton.TabIndex = 34;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(500, 576);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(105, 36);
            this.saveButton.TabIndex = 37;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(100, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "Cordenadas:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(287, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 17);
            this.label10.TabIndex = 41;
            this.label10.Text = "X";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(407, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 17);
            this.label11.TabIndex = 42;
            this.label11.Text = "Y";
            // 
            // numericY
            // 
            this.numericY.Location = new System.Drawing.Point(445, 306);
            this.numericY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericY.Name = "numericY";
            this.numericY.Size = new System.Drawing.Size(56, 22);
            this.numericY.TabIndex = 43;
            // 
            // numericX
            // 
            this.numericX.Location = new System.Drawing.Point(325, 306);
            this.numericX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericX.Name = "numericX";
            this.numericX.Size = new System.Drawing.Size(56, 22);
            this.numericX.TabIndex = 44;
            // 
            // textNameStudent
            // 
            this.textNameStudent.Location = new System.Drawing.Point(277, 209);
            this.textNameStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNameStudent.Name = "textNameStudent";
            this.textNameStudent.Size = new System.Drawing.Size(223, 22);
            this.textNameStudent.TabIndex = 22;
            this.textNameStudent.TextChanged += new System.EventHandler(this.textNameStudent_TextChanged);
            // 
            // numericCi
            // 
            this.numericCi.Location = new System.Drawing.Point(277, 160);
            this.numericCi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericCi.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericCi.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericCi.Name = "numericCi";
            this.numericCi.Size = new System.Drawing.Size(224, 22);
            this.numericCi.TabIndex = 45;
            this.numericCi.Value = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericCi);
            this.Controls.Add(this.numericX);
            this.Controls.Add(this.numericY);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.removeSubject);
            this.Controls.Add(this.addSubject);
            this.Controls.Add(this.listSubjectsSelected);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textLastNameStudent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textStudentNumber);
            this.Controls.Add(this.textNameStudent);
            this.Controls.Add(this.listSubjects);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddStudent";
            this.Size = new System.Drawing.Size(637, 630);
            this.Load += new System.EventHandler(this.AddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textLastNameStudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textStudentNumber;
        private System.Windows.Forms.ListBox listSubjects;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listSubjectsSelected;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button removeSubject;
        private System.Windows.Forms.Button addSubject;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericY;
        private System.Windows.Forms.NumericUpDown numericX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textNameStudent;
        private System.Windows.Forms.NumericUpDown numericCi;
    }
}
