namespace ERPSchoolUI
{
    partial class ModifySchoolVan
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
            this.numericMaxCapacity = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textIdSchoolVan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // numericMaxCapacity
            // 
            this.numericMaxCapacity.Location = new System.Drawing.Point(293, 198);
            this.numericMaxCapacity.Name = "numericMaxCapacity";
            this.numericMaxCapacity.Size = new System.Drawing.Size(120, 22);
            this.numericMaxCapacity.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Capacidad maxima: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(195, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 29);
            this.label5.TabIndex = 37;
            this.label5.Text = "Modificar Camioneta";
            // 
            // textIdSchoolVan
            // 
            this.textIdSchoolVan.Location = new System.Drawing.Point(293, 128);
            this.textIdSchoolVan.Name = "textIdSchoolVan";
            this.textIdSchoolVan.ReadOnly = true;
            this.textIdSchoolVan.Size = new System.Drawing.Size(168, 22);
            this.textIdSchoolVan.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Id Camioneta: ";
            // 
            // ModifySchoolVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericMaxCapacity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textIdSchoolVan);
            this.Controls.Add(this.label2);
            this.Name = "ModifySchoolVan";
            this.Size = new System.Drawing.Size(637, 630);
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericMaxCapacity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textIdSchoolVan;
        private System.Windows.Forms.Label label2;
    }
}
