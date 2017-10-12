namespace ERPSchoolUI
{
    partial class AddSchoolVan
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textIdSchoolVan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericMaxCapacity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Capacidad maxima: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(204, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 29);
            this.label5.TabIndex = 31;
            this.label5.Text = "Agregar una Camioneta";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textIdSchoolVan
            // 
            this.textIdSchoolVan.Location = new System.Drawing.Point(302, 124);
            this.textIdSchoolVan.Name = "textIdSchoolVan";
            this.textIdSchoolVan.ReadOnly = true;
            this.textIdSchoolVan.Size = new System.Drawing.Size(168, 22);
            this.textIdSchoolVan.TabIndex = 30;
            this.textIdSchoolVan.TextChanged += new System.EventHandler(this.textStudentNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Id Camioneta: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // numericMaxCapacity
            // 
            this.numericMaxCapacity.Location = new System.Drawing.Point(302, 194);
            this.numericMaxCapacity.Name = "numericMaxCapacity";
            this.numericMaxCapacity.Size = new System.Drawing.Size(120, 22);
            this.numericMaxCapacity.TabIndex = 34;
            // 
            // AddSchoolVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericMaxCapacity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textIdSchoolVan);
            this.Controls.Add(this.label2);
            this.Name = "AddSchoolVan";
            this.Size = new System.Drawing.Size(637, 630);
            this.Load += new System.EventHandler(this.AddSchoolVan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textIdSchoolVan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericMaxCapacity;
    }
}
