namespace ERPSchoolUI
{
    partial class RemoveStudent
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
            this.Docen = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.unselectStudent = new System.Windows.Forms.Button();
            this.selectStudent = new System.Windows.Forms.Button();
            this.listStudentsSelected = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listStudents = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Docen
            // 
            this.Docen.AutoSize = true;
            this.Docen.Location = new System.Drawing.Point(371, 176);
            this.Docen.Name = "Docen";
            this.Docen.Size = new System.Drawing.Size(155, 17);
            this.Docen.TabIndex = 72;
            this.Docen.Text = "Estudiantes a eliminar: ";
            this.Docen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(102, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 17);
            this.label8.TabIndex = 71;
            this.label8.Text = "Todos los estudiantes: ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // unselectStudent
            // 
            this.unselectStudent.Location = new System.Drawing.Point(283, 313);
            this.unselectStudent.Name = "unselectStudent";
            this.unselectStudent.Size = new System.Drawing.Size(52, 23);
            this.unselectStudent.TabIndex = 70;
            this.unselectStudent.Text = "<-";
            this.unselectStudent.UseVisualStyleBackColor = true;
            // 
            // selectStudent
            // 
            this.selectStudent.Location = new System.Drawing.Point(283, 246);
            this.selectStudent.Name = "selectStudent";
            this.selectStudent.Size = new System.Drawing.Size(52, 23);
            this.selectStudent.TabIndex = 69;
            this.selectStudent.Text = "->";
            this.selectStudent.UseVisualStyleBackColor = true;
            // 
            // listStudentsSelected
            // 
            this.listStudentsSelected.FormattingEnabled = true;
            this.listStudentsSelected.ItemHeight = 16;
            this.listStudentsSelected.Location = new System.Drawing.Point(354, 202);
            this.listStudentsSelected.Name = "listStudentsSelected";
            this.listStudentsSelected.Size = new System.Drawing.Size(181, 196);
            this.listStudentsSelected.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(221, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 29);
            this.label5.TabIndex = 67;
            this.label5.Text = "Eliminar Estudiante";
            // 
            // listStudents
            // 
            this.listStudents.FormattingEnabled = true;
            this.listStudents.ItemHeight = 16;
            this.listStudents.Location = new System.Drawing.Point(87, 202);
            this.listStudents.Name = "listStudents";
            this.listStudents.Size = new System.Drawing.Size(181, 196);
            this.listStudents.TabIndex = 66;
            // 
            // RemoveStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Docen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.unselectStudent);
            this.Controls.Add(this.selectStudent);
            this.Controls.Add(this.listStudentsSelected);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listStudents);
            this.Name = "RemoveStudent";
            this.Size = new System.Drawing.Size(637, 630);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Docen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button unselectStudent;
        private System.Windows.Forms.Button selectStudent;
        private System.Windows.Forms.ListBox listStudentsSelected;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listStudents;
    }
}
