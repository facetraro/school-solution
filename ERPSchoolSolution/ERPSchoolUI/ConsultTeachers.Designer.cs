namespace ERPSchoolUI
{
    partial class ConsultTeachers
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
            this.listSubjects = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listTeachers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listSubjects
            // 
            this.listSubjects.FormattingEnabled = true;
            this.listSubjects.ItemHeight = 16;
            this.listSubjects.Location = new System.Drawing.Point(207, 452);
            this.listSubjects.Name = "listSubjects";
            this.listSubjects.Size = new System.Drawing.Size(245, 116);
            this.listSubjects.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(211, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 29);
            this.label5.TabIndex = 36;
            this.label5.Text = "Listado de Docentes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Materias que dicta: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listTeachers
            // 
            this.listTeachers.FormattingEnabled = true;
            this.listTeachers.ItemHeight = 16;
            this.listTeachers.Location = new System.Drawing.Point(111, 112);
            this.listTeachers.Name = "listTeachers";
            this.listTeachers.Size = new System.Drawing.Size(417, 276);
            this.listTeachers.TabIndex = 40;
            // 
            // ConsultTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listTeachers);
            this.Controls.Add(this.listSubjects);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Name = "ConsultTeachers";
            this.Size = new System.Drawing.Size(637, 630);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listSubjects;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listTeachers;
    }
}
