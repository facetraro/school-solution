namespace ERPSchoolUI
{
    partial class AddTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTeacher));
            this.label5 = new System.Windows.Forms.Label();
            this.textCode = new System.Windows.Forms.TextBox();
            this.textNameTeacher = new System.Windows.Forms.TextBox();
            this.listSubjects = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textLastNameTeacher = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listSubjectsSelected = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(209, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Agregar un Docente";
            // 
            // textCode
            // 
            this.textCode.Location = new System.Drawing.Point(268, 126);
            this.textCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCode.Name = "textCode";
            this.textCode.ReadOnly = true;
            this.textCode.Size = new System.Drawing.Size(168, 22);
            this.textCode.TabIndex = 14;
            // 
            // textNameTeacher
            // 
            this.textNameTeacher.Location = new System.Drawing.Point(268, 176);
            this.textNameTeacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNameTeacher.Name = "textNameTeacher";
            this.textNameTeacher.Size = new System.Drawing.Size(223, 22);
            this.textNameTeacher.TabIndex = 13;
            // 
            // listSubjects
            // 
            this.listSubjects.FormattingEnabled = true;
            this.listSubjects.ItemHeight = 16;
            this.listSubjects.Location = new System.Drawing.Point(99, 352);
            this.listSubjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listSubjects.Name = "listSubjects";
            this.listSubjects.Size = new System.Drawing.Size(181, 164);
            this.listSubjects.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Materias que dicta: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Id del docente: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textLastNameTeacher
            // 
            this.textLastNameTeacher.Location = new System.Drawing.Point(268, 224);
            this.textLastNameTeacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textLastNameTeacher.Name = "textLastNameTeacher";
            this.textLastNameTeacher.Size = new System.Drawing.Size(223, 22);
            this.textLastNameTeacher.TabIndex = 17;
            this.textLastNameTeacher.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Apellido:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // listSubjectsSelected
            // 
            this.listSubjectsSelected.FormattingEnabled = true;
            this.listSubjectsSelected.ItemHeight = 16;
            this.listSubjectsSelected.Location = new System.Drawing.Point(363, 352);
            this.listSubjectsSelected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listSubjectsSelected.Name = "listSubjectsSelected";
            this.listSubjectsSelected.Size = new System.Drawing.Size(181, 164);
            this.listSubjectsSelected.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 420);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 482);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "<-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Materias totales:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Materias seleccionadas:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.backButton.Location = new System.Drawing.Point(24, 30);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(82, 75);
            this.backButton.TabIndex = 35;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(459, 538);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(105, 36);
            this.saveButton.TabIndex = 38;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listSubjectsSelected);
            this.Controls.Add(this.textLastNameTeacher);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textCode);
            this.Controls.Add(this.textNameTeacher);
            this.Controls.Add(this.listSubjects);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddTeacher";
            this.Size = new System.Drawing.Size(637, 630);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.TextBox textNameTeacher;
        private System.Windows.Forms.ListBox listSubjects;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textLastNameTeacher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listSubjectsSelected;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveButton;
    }
}
