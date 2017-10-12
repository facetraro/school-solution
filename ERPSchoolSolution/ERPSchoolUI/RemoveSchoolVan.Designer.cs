namespace ERPSchoolUI
{
    partial class RemoveSchoolVan
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
            this.unselectSchoolVan = new System.Windows.Forms.Button();
            this.selectSchoolVan = new System.Windows.Forms.Button();
            this.listSchoolVansSelected = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listSchoolVan = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Docen
            // 
            this.Docen.AutoSize = true;
            this.Docen.Location = new System.Drawing.Point(369, 160);
            this.Docen.Name = "Docen";
            this.Docen.Size = new System.Drawing.Size(151, 17);
            this.Docen.TabIndex = 72;
            this.Docen.Text = "Camionetas a eliminar:";
            this.Docen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(102, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 17);
            this.label8.TabIndex = 71;
            this.label8.Text = "Todas las camionetas:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // unselectSchoolVan
            // 
            this.unselectSchoolVan.Location = new System.Drawing.Point(279, 297);
            this.unselectSchoolVan.Name = "unselectSchoolVan";
            this.unselectSchoolVan.Size = new System.Drawing.Size(52, 23);
            this.unselectSchoolVan.TabIndex = 70;
            this.unselectSchoolVan.Text = "<-";
            this.unselectSchoolVan.UseVisualStyleBackColor = true;
            // 
            // selectSchoolVan
            // 
            this.selectSchoolVan.Location = new System.Drawing.Point(279, 230);
            this.selectSchoolVan.Name = "selectSchoolVan";
            this.selectSchoolVan.Size = new System.Drawing.Size(52, 23);
            this.selectSchoolVan.TabIndex = 69;
            this.selectSchoolVan.Text = "->";
            this.selectSchoolVan.UseVisualStyleBackColor = true;
            // 
            // listSchoolVansSelected
            // 
            this.listSchoolVansSelected.FormattingEnabled = true;
            this.listSchoolVansSelected.ItemHeight = 16;
            this.listSchoolVansSelected.Location = new System.Drawing.Point(350, 186);
            this.listSchoolVansSelected.Name = "listSchoolVansSelected";
            this.listSchoolVansSelected.Size = new System.Drawing.Size(181, 196);
            this.listSchoolVansSelected.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(218, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 29);
            this.label5.TabIndex = 67;
            this.label5.Text = "Eliminar Camioneta";
            // 
            // listSchoolVan
            // 
            this.listSchoolVan.FormattingEnabled = true;
            this.listSchoolVan.ItemHeight = 16;
            this.listSchoolVan.Location = new System.Drawing.Point(83, 186);
            this.listSchoolVan.Name = "listSchoolVan";
            this.listSchoolVan.Size = new System.Drawing.Size(181, 196);
            this.listSchoolVan.TabIndex = 66;
            // 
            // RemoveSchoolVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Docen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.unselectSchoolVan);
            this.Controls.Add(this.selectSchoolVan);
            this.Controls.Add(this.listSchoolVansSelected);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listSchoolVan);
            this.Name = "RemoveSchoolVan";
            this.Size = new System.Drawing.Size(637, 630);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Docen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button unselectSchoolVan;
        private System.Windows.Forms.Button selectSchoolVan;
        private System.Windows.Forms.ListBox listSchoolVansSelected;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listSchoolVan;
    }
}
