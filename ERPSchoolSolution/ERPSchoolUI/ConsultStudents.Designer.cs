namespace ERPSchoolUI
{
    partial class ConsultStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultStudents));
            this.listStudents = new System.Windows.Forms.ListBox();
            this.listSubjects = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.buttonLookSubjects = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listStudents
            // 
            this.listStudents.FormattingEnabled = true;
            this.listStudents.Location = new System.Drawing.Point(82, 95);
            this.listStudents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listStudents.Name = "listStudents";
            this.listStudents.Size = new System.Drawing.Size(314, 225);
            this.listStudents.TabIndex = 44;
            // 
            // listSubjects
            // 
            this.listSubjects.FormattingEnabled = true;
            this.listSubjects.Location = new System.Drawing.Point(80, 382);
            this.listSubjects.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listSubjects.Name = "listSubjects";
            this.listSubjects.Size = new System.Drawing.Size(316, 95);
            this.listSubjects.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(158, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 24);
            this.label5.TabIndex = 42;
            this.label5.Text = "Listado de Alumnos";
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
            this.backButton.Location = new System.Drawing.Point(17, 16);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(70, 75);
            this.backButton.TabIndex = 45;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // buttonLookSubjects
            // 
            this.buttonLookSubjects.Location = new System.Drawing.Point(201, 343);
            this.buttonLookSubjects.Name = "buttonLookSubjects";
            this.buttonLookSubjects.Size = new System.Drawing.Size(75, 23);
            this.buttonLookSubjects.TabIndex = 46;
            this.buttonLookSubjects.Text = "Ver Materias";
            this.buttonLookSubjects.UseVisualStyleBackColor = true;
            this.buttonLookSubjects.Click += new System.EventHandler(this.buttonLookSubjects_Click);
            // 
            // ConsultStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonLookSubjects);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.listStudents);
            this.Controls.Add(this.listSubjects);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConsultStudents";
            this.Size = new System.Drawing.Size(478, 512);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listStudents;
        private System.Windows.Forms.ListBox listSubjects;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button buttonLookSubjects;
    }
}
