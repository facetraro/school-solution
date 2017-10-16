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
            ((System.ComponentModel.ISupportInitialize)(this.numericCi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 17);
            this.label7.TabIndex = 49;
            this.label7.Text = "Materias seleccionadas:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(131, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 48;
            this.label8.Text = "Materias totales:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // removeSubject
            // 
            this.removeSubject.Location = new System.Drawing.Point(291, 497);
            this.removeSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeSubject.Name = "removeSubject";
            this.removeSubject.Size = new System.Drawing.Size(52, 23);
            this.removeSubject.TabIndex = 47;
            this.removeSubject.Text = "<-";
            this.removeSubject.UseVisualStyleBackColor = true;
            this.removeSubject.Click += new System.EventHandler(this.removeSubject_Click);
            // 
            // addSubject
            // 
            this.addSubject.Location = new System.Drawing.Point(291, 430);
            this.addSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addSubject.Name = "addSubject";
            this.addSubject.Size = new System.Drawing.Size(52, 23);
            this.addSubject.TabIndex = 46;
            this.addSubject.Text = "->";
            this.addSubject.UseVisualStyleBackColor = true;
            this.addSubject.Click += new System.EventHandler(this.addSubject_Click);
            // 
            // listSubjectsSelected
            // 
            this.listSubjectsSelected.FormattingEnabled = true;
            this.listSubjectsSelected.ItemHeight = 16;
            this.listSubjectsSelected.Location = new System.Drawing.Point(361, 386);
            this.listSubjectsSelected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listSubjectsSelected.Name = "listSubjectsSelected";
            this.listSubjectsSelected.Size = new System.Drawing.Size(181, 148);
            this.listSubjectsSelected.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Cedula de Identidad: ";
            // 
            // textLastNameStudent
            // 
            this.textLastNameStudent.Location = new System.Drawing.Point(276, 263);
            this.textLastNameStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textLastNameStudent.Name = "textLastNameStudent";
            this.textLastNameStudent.Size = new System.Drawing.Size(223, 22);
            this.textLastNameStudent.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Apellido Estudiante:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(217, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 29);
            this.label5.TabIndex = 40;
            this.label5.Text = "Modificar Estudiante";
            // 
            // textStudentNumber
            // 
            this.textStudentNumber.Location = new System.Drawing.Point(276, 118);
            this.textStudentNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textStudentNumber.Name = "textStudentNumber";
            this.textStudentNumber.ReadOnly = true;
            this.textStudentNumber.Size = new System.Drawing.Size(223, 22);
            this.textStudentNumber.TabIndex = 39;
            // 
            // textNameStudent
            // 
            this.textNameStudent.Location = new System.Drawing.Point(276, 217);
            this.textNameStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNameStudent.Name = "textNameStudent";
            this.textNameStudent.Size = new System.Drawing.Size(223, 22);
            this.textNameStudent.TabIndex = 38;
            // 
            // listSubjects
            // 
            this.listSubjects.FormattingEnabled = true;
            this.listSubjects.ItemHeight = 16;
            this.listSubjects.Location = new System.Drawing.Point(93, 386);
            this.listSubjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listSubjects.Name = "listSubjects";
            this.listSubjects.Size = new System.Drawing.Size(181, 148);
            this.listSubjects.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Materias que esta inscripto:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Numero de Estudiante:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
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
            this.backButton.Location = new System.Drawing.Point(33, 31);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(71, 71);
            this.backButton.TabIndex = 50;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(465, 556);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(105, 36);
            this.saveButton.TabIndex = 51;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // numericCi
            // 
            this.numericCi.Location = new System.Drawing.Point(276, 167);
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
            this.numericCi.TabIndex = 57;
            this.numericCi.Value = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            // 
            // numericX
            // 
            this.numericX.Location = new System.Drawing.Point(324, 314);
            this.numericX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericX.Name = "numericX";
            this.numericX.Size = new System.Drawing.Size(56, 22);
            this.numericX.TabIndex = 56;
            // 
            // numericY
            // 
            this.numericY.Location = new System.Drawing.Point(444, 314);
            this.numericY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericY.Name = "numericY";
            this.numericY.Size = new System.Drawing.Size(56, 22);
            this.numericY.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(405, 316);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 17);
            this.label11.TabIndex = 54;
            this.label11.Text = "Y";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(285, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 17);
            this.label10.TabIndex = 53;
            this.label10.Text = "X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(99, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 52;
            this.label9.Text = "Cordenadas:";
            // 
            // ModifyStudent
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
            this.Name = "ModifyStudent";
            this.Size = new System.Drawing.Size(637, 630);
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
    }
}
