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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveSchoolVan));
            this.Docen = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.unselectSchoolVan = new System.Windows.Forms.Button();
            this.selectSchoolVan = new System.Windows.Forms.Button();
            this.listSchoolVansSelected = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listSchoolVan = new System.Windows.Forms.ListBox();
            this.backButton = new System.Windows.Forms.Button();
            this.confirmRemoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Docen
            // 
            this.Docen.AutoSize = true;
            this.Docen.Location = new System.Drawing.Point(277, 130);
            this.Docen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Docen.Name = "Docen";
            this.Docen.Size = new System.Drawing.Size(112, 13);
            this.Docen.TabIndex = 72;
            this.Docen.Text = "Camionetas a eliminar:";
            this.Docen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 130);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 71;
            this.label8.Text = "Todas las camionetas:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // unselectSchoolVan
            // 
            this.unselectSchoolVan.Location = new System.Drawing.Point(209, 241);
            this.unselectSchoolVan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.unselectSchoolVan.Name = "unselectSchoolVan";
            this.unselectSchoolVan.Size = new System.Drawing.Size(39, 19);
            this.unselectSchoolVan.TabIndex = 70;
            this.unselectSchoolVan.Text = "<-";
            this.unselectSchoolVan.UseVisualStyleBackColor = true;
            // 
            // selectSchoolVan
            // 
            this.selectSchoolVan.Location = new System.Drawing.Point(209, 187);
            this.selectSchoolVan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectSchoolVan.Name = "selectSchoolVan";
            this.selectSchoolVan.Size = new System.Drawing.Size(39, 19);
            this.selectSchoolVan.TabIndex = 69;
            this.selectSchoolVan.Text = "->";
            this.selectSchoolVan.UseVisualStyleBackColor = true;
            // 
            // listSchoolVansSelected
            // 
            this.listSchoolVansSelected.FormattingEnabled = true;
            this.listSchoolVansSelected.Location = new System.Drawing.Point(262, 151);
            this.listSchoolVansSelected.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listSchoolVansSelected.Name = "listSchoolVansSelected";
            this.listSchoolVansSelected.Size = new System.Drawing.Size(137, 160);
            this.listSchoolVansSelected.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(164, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 24);
            this.label5.TabIndex = 67;
            this.label5.Text = "Eliminar Camioneta";
            // 
            // listSchoolVan
            // 
            this.listSchoolVan.FormattingEnabled = true;
            this.listSchoolVan.Location = new System.Drawing.Point(62, 151);
            this.listSchoolVan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listSchoolVan.Name = "listSchoolVan";
            this.listSchoolVan.Size = new System.Drawing.Size(137, 160);
            this.listSchoolVan.TabIndex = 66;
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
            this.backButton.Location = new System.Drawing.Point(31, 27);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(53, 58);
            this.backButton.TabIndex = 73;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // confirmRemoveButton
            // 
            this.confirmRemoveButton.Location = new System.Drawing.Point(358, 462);
            this.confirmRemoveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirmRemoveButton.Name = "confirmRemoveButton";
            this.confirmRemoveButton.Size = new System.Drawing.Size(79, 29);
            this.confirmRemoveButton.TabIndex = 74;
            this.confirmRemoveButton.Text = "Confirmar";
            this.confirmRemoveButton.UseVisualStyleBackColor = true;
            this.confirmRemoveButton.Click += new System.EventHandler(this.confirmRemoveButton_Click);
            // 
            // RemoveSchoolVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.confirmRemoveButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.Docen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.unselectSchoolVan);
            this.Controls.Add(this.selectSchoolVan);
            this.Controls.Add(this.listSchoolVansSelected);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listSchoolVan);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RemoveSchoolVan";
            this.Size = new System.Drawing.Size(478, 512);
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
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button confirmRemoveButton;
    }
}
