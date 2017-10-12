namespace ERPSchoolUI
{
    partial class RemoveSubject
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.addSubject = new System.Windows.Forms.Button();
            this.listSubjectsSelected = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listSubjects = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 17);
            this.label7.TabIndex = 57;
            this.label7.Text = "Materias a eliminar: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 56;
            this.label8.Text = "Materias totales:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 23);
            this.button1.TabIndex = 55;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // addSubject
            // 
            this.addSubject.Location = new System.Drawing.Point(279, 246);
            this.addSubject.Name = "addSubject";
            this.addSubject.Size = new System.Drawing.Size(52, 23);
            this.addSubject.TabIndex = 54;
            this.addSubject.Text = "->";
            this.addSubject.UseVisualStyleBackColor = true;
            // 
            // listSubjectsSelected
            // 
            this.listSubjectsSelected.FormattingEnabled = true;
            this.listSubjectsSelected.ItemHeight = 16;
            this.listSubjectsSelected.Location = new System.Drawing.Point(350, 202);
            this.listSubjectsSelected.Name = "listSubjectsSelected";
            this.listSubjectsSelected.Size = new System.Drawing.Size(181, 196);
            this.listSubjectsSelected.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(217, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 29);
            this.label5.TabIndex = 52;
            this.label5.Text = "Eliminar Materia";
            // 
            // listSubjects
            // 
            this.listSubjects.FormattingEnabled = true;
            this.listSubjects.ItemHeight = 16;
            this.listSubjects.Location = new System.Drawing.Point(83, 202);
            this.listSubjects.Name = "listSubjects";
            this.listSubjects.Size = new System.Drawing.Size(181, 196);
            this.listSubjects.TabIndex = 51;
            // 
            // RemoveSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addSubject);
            this.Controls.Add(this.listSubjectsSelected);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listSubjects);
            this.Name = "RemoveSubject";
            this.Size = new System.Drawing.Size(637, 630);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addSubject;
        private System.Windows.Forms.ListBox listSubjectsSelected;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listSubjects;
    }
}
