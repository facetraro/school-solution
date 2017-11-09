namespace ERPSchoolUI
{
    partial class RemoveActivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveActivity));
            this.confirmRemoveButton = new System.Windows.Forms.Button();
            this.Docen = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.unselectSchoolVan = new System.Windows.Forms.Button();
            this.selectSchoolVan = new System.Windows.Forms.Button();
            this.listActivitiesSelected = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listActivities = new System.Windows.Forms.ListBox();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // confirmRemoveButton
            // 
            this.confirmRemoveButton.Location = new System.Drawing.Point(452, 541);
            this.confirmRemoveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmRemoveButton.Name = "confirmRemoveButton";
            this.confirmRemoveButton.Size = new System.Drawing.Size(105, 36);
            this.confirmRemoveButton.TabIndex = 82;
            this.confirmRemoveButton.Text = "Confirmar";
            this.confirmRemoveButton.UseVisualStyleBackColor = true;
            this.confirmRemoveButton.Click += new System.EventHandler(this.confirmRemoveButton_Click);
            // 
            // Docen
            // 
            this.Docen.AutoSize = true;
            this.Docen.Location = new System.Drawing.Point(357, 163);
            this.Docen.Name = "Docen";
            this.Docen.Size = new System.Drawing.Size(149, 17);
            this.Docen.TabIndex = 81;
            this.Docen.Text = "Actividades a eliminar:";
            this.Docen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 17);
            this.label8.TabIndex = 80;
            this.label8.Text = "Todas las actividades:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // unselectSchoolVan
            // 
            this.unselectSchoolVan.Location = new System.Drawing.Point(275, 300);
            this.unselectSchoolVan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unselectSchoolVan.Name = "unselectSchoolVan";
            this.unselectSchoolVan.Size = new System.Drawing.Size(52, 23);
            this.unselectSchoolVan.TabIndex = 79;
            this.unselectSchoolVan.Text = "<-";
            this.unselectSchoolVan.UseVisualStyleBackColor = true;
            // 
            // selectSchoolVan
            // 
            this.selectSchoolVan.Location = new System.Drawing.Point(275, 233);
            this.selectSchoolVan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectSchoolVan.Name = "selectSchoolVan";
            this.selectSchoolVan.Size = new System.Drawing.Size(52, 23);
            this.selectSchoolVan.TabIndex = 78;
            this.selectSchoolVan.Text = "->";
            this.selectSchoolVan.UseVisualStyleBackColor = true;
            // 
            // listActivitiesSelected
            // 
            this.listActivitiesSelected.FormattingEnabled = true;
            this.listActivitiesSelected.ItemHeight = 16;
            this.listActivitiesSelected.Location = new System.Drawing.Point(345, 189);
            this.listActivitiesSelected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listActivitiesSelected.Name = "listActivitiesSelected";
            this.listActivitiesSelected.Size = new System.Drawing.Size(181, 196);
            this.listActivitiesSelected.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(215, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 29);
            this.label5.TabIndex = 76;
            this.label5.Text = "Eliminar Actividad";
            // 
            // listActivities
            // 
            this.listActivities.FormattingEnabled = true;
            this.listActivities.ItemHeight = 16;
            this.listActivities.Location = new System.Drawing.Point(79, 189);
            this.listActivities.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listActivities.Name = "listActivities";
            this.listActivities.Size = new System.Drawing.Size(181, 196);
            this.listActivities.TabIndex = 75;
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
            this.backButton.Location = new System.Drawing.Point(39, 31);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(91, 80);
            this.backButton.TabIndex = 83;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // RemoveActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.confirmRemoveButton);
            this.Controls.Add(this.Docen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.unselectSchoolVan);
            this.Controls.Add(this.selectSchoolVan);
            this.Controls.Add(this.listActivitiesSelected);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listActivities);
            this.Name = "RemoveActivity";
            this.Size = new System.Drawing.Size(637, 630);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmRemoveButton;
        private System.Windows.Forms.Label Docen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button unselectSchoolVan;
        private System.Windows.Forms.Button selectSchoolVan;
        private System.Windows.Forms.ListBox listActivitiesSelected;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listActivities;
        private System.Windows.Forms.Button backButton;
    }
}
