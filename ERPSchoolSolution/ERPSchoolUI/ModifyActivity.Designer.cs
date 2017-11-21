namespace ERPSchoolUI
{
    partial class ModifyActivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyActivity));
            this.textCostActivity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textNameActivity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textIDActivity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textCostActivity
            // 
            this.textCostActivity.Location = new System.Drawing.Point(251, 290);
            this.textCostActivity.Name = "textCostActivity";
            this.textCostActivity.Size = new System.Drawing.Size(119, 22);
            this.textCostActivity.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 69;
            this.label6.Text = "Costo:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(251, 236);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(261, 22);
            this.dateTimePicker1.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 67;
            this.label4.Text = "Fecha:";
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.Color.Transparent;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(23, 13);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(104, 92);
            this.backButton.TabIndex = 66;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(211, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 29);
            this.label5.TabIndex = 60;
            this.label5.Text = "Modificar Actividad";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textNameActivity
            // 
            this.textNameActivity.Location = new System.Drawing.Point(251, 183);
            this.textNameActivity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNameActivity.Name = "textNameActivity";
            this.textNameActivity.Size = new System.Drawing.Size(223, 22);
            this.textNameActivity.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "Nombre Actividad:";
            // 
            // textIDActivity
            // 
            this.textIDActivity.Location = new System.Drawing.Point(251, 135);
            this.textIDActivity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textIDActivity.Name = "textIDActivity";
            this.textIDActivity.ReadOnly = true;
            this.textIDActivity.Size = new System.Drawing.Size(119, 22);
            this.textIDActivity.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Id:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(466, 549);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(105, 36);
            this.saveButton.TabIndex = 71;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ModifyActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.textCostActivity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textNameActivity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textIDActivity);
            this.Controls.Add(this.label2);
            this.Name = "ModifyActivity";
            this.Size = new System.Drawing.Size(637, 630);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCostActivity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNameActivity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textIDActivity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveButton;
    }
}
