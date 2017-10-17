namespace ERPSchoolUI
{
    partial class ModifyStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyStudent));
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.removeSubject = new System.Windows.Forms.Button();
            this.addSubject = new System.Windows.Forms.Button();
            this.listSubjectsSelected = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textLastNameStudent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textStudentNumber = new System.Windows.Forms.TextBox();
            this.textNameStudent = new System.Windows.Forms.TextBox();
            this.listSubjects = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.numericCi = new System.Windows.Forms.NumericUpDown();
            this.numericX = new System.Windows.Forms.NumericUpDown();
            this.numericY = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericCi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 292);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Materias seleccionadas:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 292);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Materias totales:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // removeSubject
            // 
            this.removeSubject.Location = new System.Drawing.Point(218, 404);
            this.removeSubject.Margin = new System.Windows.Forms.Padding(2);
            this.removeSubject.Name = "removeSubject";
            this.removeSubject.Size = new System.Drawing.Size(39, 19);
            this.removeSubject.TabIndex = 47;
            this.removeSubject.Text = "<-";
            this.removeSubject.UseVisualStyleBackColor = true;
            this.removeSubject.Click += new System.EventHandler(this.removeSubject_Click);
            // 
            // addSubject
            // 
            this.addSubject.Location = new System.Drawing.Point(218, 349);
            this.addSubject.Margin = new System.Windows.Forms.Padding(2);
            this.addSubject.Name = "addSubject";
            this.addSubject.Size = new System.Drawing.Size(39, 19);
            this.addSubject.TabIndex = 46;
            this.addSubject.Text = "->";
            this.addSubject.UseVisualStyleBackColor = true;
            this.addSubject.Click += new System.EventHandler(this.addSubject_Click);
            // 
            // listSubjectsSelected
            // 
            this.listSubjectsSelected.FormattingEnabled = true;
            this.listSubjectsSelected.Location = new System.Drawing.Point(271, 314);
            this.listSubjectsSelected.Margin = new System.Windows.Forms.Padding(2);
            this.listSubjectsSelected.Name = "listSubjectsSelected";
            this.listSubjectsSelected.Size = new System.Drawing.Size(137, 121);
            this.listSubjectsSelected.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Cedula de Identidad: ";
            // 
            // textLastNameStudent
            // 
            this.textLastNameStudent.Location = new System.Drawing.Point(207, 214);
            this.textLastNameStudent.Margin = new System.Windows.Forms.Padding(2);
            this.textLastNameStudent.Name = "textLastNameStudent";
            this.textLastNameStudent.Size = new System.Drawing.Size(168, 20);
            this.textLastNameStudent.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Apellido Estudiante:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(163, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 24);
            this.label5.TabIndex = 40;
            this.label5.Text = "Modificar Estudiante";
            // 
            // textStudentNumber
            // 
            this.textStudentNumber.Location = new System.Drawing.Point(207, 96);
            this.textStudentNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textStudentNumber.Name = "textStudentNumber";
            this.textStudentNumber.ReadOnly = true;
            this.textStudentNumber.Size = new System.Drawing.Size(168, 20);
            this.textStudentNumber.TabIndex = 39;
            // 
            // textNameStudent
            // 
            this.textNameStudent.Location = new System.Drawing.Point(207, 176);
            this.textNameStudent.Margin = new System.Windows.Forms.Padding(2);
            this.textNameStudent.Name = "textNameStudent";
            this.textNameStudent.Size = new System.Drawing.Size(168, 20);
            this.textNameStudent.TabIndex = 38;
            // 
            // listSubjects
            // 
            this.listSubjects.FormattingEnabled = true;
            this.listSubjects.Location = new System.Drawing.Point(70, 314);
            this.listSubjects.Margin = new System.Windows.Forms.Padding(2);
            this.listSubjects.Name = "listSubjects";
            this.listSubjects.Size = new System.Drawing.Size(137, 121);
            this.listSubjects.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 279);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Materias que esta inscripto:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Numero de Estudiante:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nombre Estudiante:";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.Color.Transparent;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(18, 19);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(69, 69);
            this.backButton.TabIndex = 50;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(349, 452);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(79, 29);
            this.saveButton.TabIndex = 51;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // numericCi
            // 
            this.numericCi.Location = new System.Drawing.Point(207, 136);
            this.numericCi.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericCi.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericCi.Name = "numericCi";
            this.numericCi.Size = new System.Drawing.Size(168, 20);
            this.numericCi.TabIndex = 57;
            this.numericCi.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // numericX
            // 
            this.numericX.Location = new System.Drawing.Point(243, 255);
            this.numericX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericX.Name = "numericX";
            this.numericX.Size = new System.Drawing.Size(42, 20);
            this.numericX.TabIndex = 56;
            // 
            // numericY
            // 
            this.numericY.Location = new System.Drawing.Point(333, 255);
            this.numericY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericY.Name = "numericY";
            this.numericY.Size = new System.Drawing.Size(42, 20);
            this.numericY.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(304, 257);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "Y";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(214, 257);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 257);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Cordenadas:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(210, 159);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 12);
            this.label12.TabIndex = 58;
            this.label12.Text = "*Formato de CI [Ej: 47915349]";
            // 
            // ModifyStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label12);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModifyStudent";
            this.Size = new System.Drawing.Size(478, 512);
            ((System.ComponentModel.ISupportInitialize)(this.numericCi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button removeSubject;
        private System.Windows.Forms.Button addSubject;
        private System.Windows.Forms.ListBox listSubjectsSelected;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textLastNameStudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textStudentNumber;
        private System.Windows.Forms.TextBox textNameStudent;
        private System.Windows.Forms.ListBox listSubjects;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.NumericUpDown numericCi;
        private System.Windows.Forms.NumericUpDown numericX;
        private System.Windows.Forms.NumericUpDown numericY;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
    }
}
