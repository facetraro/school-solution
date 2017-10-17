namespace ERPSchoolUI
{
    partial class RemoveTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveTeacher));
            this.Docen = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.unselectTeacher = new System.Windows.Forms.Button();
            this.selectTeacher = new System.Windows.Forms.Button();
            this.listTeachersSelected = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listTeachers = new System.Windows.Forms.ListBox();
            this.backButton = new System.Windows.Forms.Button();
            this.confirmRemoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Docen
            // 
            this.Docen.AutoSize = true;
            this.Docen.Location = new System.Drawing.Point(282, 153);
            this.Docen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Docen.Name = "Docen";
            this.Docen.Size = new System.Drawing.Size(103, 13);
            this.Docen.TabIndex = 65;
            this.Docen.Text = "Docentes a eliminar:";
            this.Docen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 153);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "Todos los docentes:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // unselectTeacher
            // 
            this.unselectTeacher.Location = new System.Drawing.Point(214, 264);
            this.unselectTeacher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.unselectTeacher.Name = "unselectTeacher";
            this.unselectTeacher.Size = new System.Drawing.Size(39, 19);
            this.unselectTeacher.TabIndex = 63;
            this.unselectTeacher.Text = "<-";
            this.unselectTeacher.UseVisualStyleBackColor = true;
            this.unselectTeacher.Click += new System.EventHandler(this.unselectTeacher_Click);
            // 
            // selectTeacher
            // 
            this.selectTeacher.Location = new System.Drawing.Point(214, 210);
            this.selectTeacher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectTeacher.Name = "selectTeacher";
            this.selectTeacher.Size = new System.Drawing.Size(39, 19);
            this.selectTeacher.TabIndex = 62;
            this.selectTeacher.Text = "->";
            this.selectTeacher.UseVisualStyleBackColor = true;
            this.selectTeacher.Click += new System.EventHandler(this.selectTeacher_Click);
            // 
            // listTeachersSelected
            // 
            this.listTeachersSelected.FormattingEnabled = true;
            this.listTeachersSelected.Location = new System.Drawing.Point(268, 174);
            this.listTeachersSelected.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listTeachersSelected.Name = "listTeachersSelected";
            this.listTeachersSelected.Size = new System.Drawing.Size(137, 160);
            this.listTeachersSelected.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(168, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 24);
            this.label5.TabIndex = 60;
            this.label5.Text = "Eliminar Docente";
            // 
            // listTeachers
            // 
            this.listTeachers.FormattingEnabled = true;
            this.listTeachers.Location = new System.Drawing.Point(68, 174);
            this.listTeachers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listTeachers.Name = "listTeachers";
            this.listTeachers.Size = new System.Drawing.Size(137, 160);
            this.listTeachers.TabIndex = 59;
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
            this.backButton.Location = new System.Drawing.Point(15, 29);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(69, 68);
            this.backButton.TabIndex = 66;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // confirmRemoveButton
            // 
            this.confirmRemoveButton.Location = new System.Drawing.Point(343, 446);
            this.confirmRemoveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirmRemoveButton.Name = "confirmRemoveButton";
            this.confirmRemoveButton.Size = new System.Drawing.Size(79, 29);
            this.confirmRemoveButton.TabIndex = 75;
            this.confirmRemoveButton.Text = "Confirmar";
            this.confirmRemoveButton.UseVisualStyleBackColor = true;
            this.confirmRemoveButton.Click += new System.EventHandler(this.confirmRemoveButton_Click);
            // 
            // RemoveTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.confirmRemoveButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.Docen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.unselectTeacher);
            this.Controls.Add(this.selectTeacher);
            this.Controls.Add(this.listTeachersSelected);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listTeachers);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RemoveTeacher";
            this.Size = new System.Drawing.Size(478, 512);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Docen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button unselectTeacher;
        private System.Windows.Forms.Button selectTeacher;
        private System.Windows.Forms.ListBox listTeachersSelected;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listTeachers;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button confirmRemoveButton;
    }
}
