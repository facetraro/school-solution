namespace ERPSchoolUI
{
    partial class AddActivityPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddActivityPayment));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listStudents = new System.Windows.Forms.ListBox();
            this.backButton = new System.Windows.Forms.Button();
            this.listActivities = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(201, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nuevo pago de actividad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Seleccione estudiante a pagar actividad:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listStudents
            // 
            this.listStudents.FormattingEnabled = true;
            this.listStudents.ItemHeight = 16;
            this.listStudents.Location = new System.Drawing.Point(182, 352);
            this.listStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listStudents.Name = "listStudents";
            this.listStudents.Size = new System.Drawing.Size(310, 196);
            this.listStudents.TabIndex = 22;
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
            this.backButton.Location = new System.Drawing.Point(24, 21);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(95, 90);
            this.backButton.TabIndex = 36;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // listActivities
            // 
            this.listActivities.FormattingEnabled = true;
            this.listActivities.ItemHeight = 16;
            this.listActivities.Location = new System.Drawing.Point(151, 107);
            this.listActivities.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listActivities.Name = "listActivities";
            this.listActivities.Size = new System.Drawing.Size(364, 196);
            this.listActivities.TabIndex = 37;
            this.listActivities.SelectedIndexChanged += new System.EventHandler(this.listActivities_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Lista de Actividades:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(257, 562);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 36);
            this.saveButton.TabIndex = 39;
            this.saveButton.Text = "Marcar como paga";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AddActivityPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listActivities);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listStudents);
            this.Controls.Add(this.label5);
            this.Name = "AddActivityPayment";
            this.Size = new System.Drawing.Size(637, 630);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listStudents;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ListBox listActivities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
    }
}
