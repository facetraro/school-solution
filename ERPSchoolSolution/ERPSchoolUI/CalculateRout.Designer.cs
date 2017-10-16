namespace ERPSchoolUI
{
    partial class CalculateRout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateRout));
            this.label5 = new System.Windows.Forms.Label();
            this.listSchoolVans = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listRoutes = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.buttonLookRoutes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(235, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Calcular Rutas";
            // 
            // listSchoolVans
            // 
            this.listSchoolVans.FormattingEnabled = true;
            this.listSchoolVans.ItemHeight = 16;
            this.listSchoolVans.Location = new System.Drawing.Point(148, 110);
            this.listSchoolVans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listSchoolVans.Name = "listSchoolVans";
            this.listSchoolVans.Size = new System.Drawing.Size(351, 228);
            this.listSchoolVans.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Listado de camionetas";
            // 
            // listRoutes
            // 
            this.listRoutes.FormattingEnabled = true;
            this.listRoutes.ItemHeight = 16;
            this.listRoutes.Location = new System.Drawing.Point(148, 428);
            this.listRoutes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listRoutes.Name = "listRoutes";
            this.listRoutes.Size = new System.Drawing.Size(351, 148);
            this.listRoutes.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Rutas a realizar";
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
            this.backButton.Location = new System.Drawing.Point(35, 18);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(79, 76);
            this.backButton.TabIndex = 37;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // buttonLookRoutes
            // 
            this.buttonLookRoutes.Location = new System.Drawing.Point(256, 356);
            this.buttonLookRoutes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLookRoutes.Name = "buttonLookRoutes";
            this.buttonLookRoutes.Size = new System.Drawing.Size(147, 47);
            this.buttonLookRoutes.TabIndex = 48;
            this.buttonLookRoutes.Text = "Ver Rutas de la Camioneta";
            this.buttonLookRoutes.UseVisualStyleBackColor = true;
            this.buttonLookRoutes.Click += new System.EventHandler(this.buttonLookRoutes_Click);
            // 
            // CalculateRout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonLookRoutes);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listRoutes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listSchoolVans);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CalculateRout";
            this.Size = new System.Drawing.Size(637, 630);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listSchoolVans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listRoutes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button buttonLookRoutes;
    }
}
