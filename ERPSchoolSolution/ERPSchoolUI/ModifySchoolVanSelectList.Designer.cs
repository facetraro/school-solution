namespace ERPSchoolUI
{
    partial class ModifySchoolVanSelectList
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listSchoolVans = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Seleccione una camioneta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(208, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 29);
            this.label5.TabIndex = 41;
            this.label5.Text = "Gestionar camioneta";
            // 
            // listSchoolVans
            // 
            this.listSchoolVans.FormattingEnabled = true;
            this.listSchoolVans.ItemHeight = 16;
            this.listSchoolVans.Location = new System.Drawing.Point(190, 168);
            this.listSchoolVans.Name = "listSchoolVans";
            this.listSchoolVans.Size = new System.Drawing.Size(265, 388);
            this.listSchoolVans.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(505, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 32);
            this.button1.TabIndex = 43;
            this.button1.Text = "Continuar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModifySchoolVanSelectList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listSchoolVans);
            this.Name = "ModifySchoolVanSelectList";
            this.Size = new System.Drawing.Size(637, 630);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listSchoolVans;
        private System.Windows.Forms.Button button1;
    }
}
