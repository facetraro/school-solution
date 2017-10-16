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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveStudent));
            this.Docen = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.unselectStudent = new System.Windows.Forms.Button();
            this.selectStudent = new System.Windows.Forms.Button();
            this.listStudentsSelected = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listStudents = new System.Windows.Forms.ListBox();
            this.backButton = new System.Windows.Forms.Button();
            this.confirmRemoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Docen
            // 
            this.Docen.AutoSize = true;
            this.Docen.Location = new System.Drawing.Point(278, 143);
            this.Docen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Docen.Name = "Docen";
            this.Docen.Size = new System.Drawing.Size(115, 13);
            this.Docen.TabIndex = 72;
            this.Docen.Text = "Estudiantes a eliminar: ";
            this.Docen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 143);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 71;
            this.label8.Text = "Todos los estudiantes: ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // unselectStudent
            // 
            this.unselectStudent.Location = new System.Drawing.Point(212, 254);
            this.unselectStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.unselectStudent.Name = "unselectStudent";
            this.unselectStudent.Size = new System.Drawing.Size(39, 19);
            this.unselectStudent.TabIndex = 70;
            this.unselectStudent.Text = "<-";
            this.unselectStudent.UseVisualStyleBackColor = true;
            this.unselectStudent.Click += new System.EventHandler(this.unselectStudent_Click);
            // 
            // selectStudent
            // 
            this.selectStudent.Location = new System.Drawing.Point(212, 200);
            this.selectStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectStudent.Name = "selectStudent";
            this.selectStudent.Size = new System.Drawing.Size(39, 19);
            this.selectStudent.TabIndex = 69;
            this.selectStudent.Text = "->";
            this.selectStudent.UseVisualStyleBackColor = true;
            this.selectStudent.Click += new System.EventHandler(this.selectStudent_Click);
            // 
            // listStudentsSelected
            // 
            this.listStudentsSelected.FormattingEnabled = true;
            this.listStudentsSelected.Location = new System.Drawing.Point(266, 164);
            this.listStudentsSelected.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listStudentsSelected.Name = "listStudentsSelected";
            this.listStudentsSelected.Size = new System.Drawing.Size(137, 160);
            this.listStudentsSelected.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(166, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 24);
            this.label5.TabIndex = 67;
            this.label5.Text = "Eliminar Alumno";
            // 
            // listStudents
            // 
            this.listStudents.FormattingEnabled = true;
            this.listStudents.Location = new System.Drawing.Point(65, 164);
            this.listStudents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listStudents.Name = "listStudents";
            this.listStudents.Size = new System.Drawing.Size(137, 160);
            this.listStudents.TabIndex = 66;
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
            this.backButton.Location = new System.Drawing.Point(28, 25);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(53, 58);
            this.backButton.TabIndex = 73;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // confirmRemoveButton
            // 
            this.confirmRemoveButton.Location = new System.Drawing.Point(362, 458);
            this.confirmRemoveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirmRemoveButton.Name = "confirmRemoveButton";
            this.confirmRemoveButton.Size = new System.Drawing.Size(79, 29);
            this.confirmRemoveButton.TabIndex = 75;
            this.confirmRemoveButton.Text = "Confirmar";
            this.confirmRemoveButton.UseVisualStyleBackColor = true;
            this.confirmRemoveButton.Click += new System.EventHandler(this.confirmRemoveButton_Click);
            // 
            // RemoveStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.confirmRemoveButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.Docen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.unselectStudent);
            this.Controls.Add(this.selectStudent);
            this.Controls.Add(this.listStudentsSelected);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listStudents);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RemoveStudent";
            this.Size = new System.Drawing.Size(478, 512);
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
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button confirmRemoveButton;
    }
}
