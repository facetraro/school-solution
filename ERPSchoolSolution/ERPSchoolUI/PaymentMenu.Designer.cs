namespace ERPSchoolUI
{
    partial class PaymentMenu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.removeActivity = new System.Windows.Forms.Button();
            this.modifyActivity = new System.Windows.Forms.Button();
            this.addActivity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDescription
            // 
            this.labelDescription.Location = new System.Drawing.Point(1, 60);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(637, 28);
            this.labelDescription.TabIndex = 16;
            this.labelDescription.Text = "labelDescription";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(0, 21);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(637, 25);
            this.labelTitle.TabIndex = 15;
            this.labelTitle.Text = "labelTitle";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // removeActivity
            // 
            this.removeActivity.Location = new System.Drawing.Point(237, 410);
            this.removeActivity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeActivity.Name = "removeActivity";
            this.removeActivity.Size = new System.Drawing.Size(163, 55);
            this.removeActivity.TabIndex = 14;
            this.removeActivity.Text = "Ver Pagos";
            this.removeActivity.UseVisualStyleBackColor = true;
            // 
            // modifyActivity
            // 
            this.modifyActivity.Location = new System.Drawing.Point(237, 286);
            this.modifyActivity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modifyActivity.Name = "modifyActivity";
            this.modifyActivity.Size = new System.Drawing.Size(163, 55);
            this.modifyActivity.TabIndex = 13;
            this.modifyActivity.Text = "Agregar pago Couta";
            this.modifyActivity.UseVisualStyleBackColor = true;
            this.modifyActivity.Click += new System.EventHandler(this.modifyActivity_Click);
            // 
            // addActivity
            // 
            this.addActivity.Location = new System.Drawing.Point(237, 165);
            this.addActivity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addActivity.Name = "addActivity";
            this.addActivity.Size = new System.Drawing.Size(163, 55);
            this.addActivity.TabIndex = 12;
            this.addActivity.Text = "Agregar pago Actividad";
            this.addActivity.UseVisualStyleBackColor = true;
            this.addActivity.Click += new System.EventHandler(this.addActivity_Click);
            // 
            // PaymentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.removeActivity);
            this.Controls.Add(this.modifyActivity);
            this.Controls.Add(this.addActivity);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PaymentMenu";
            this.Size = new System.Drawing.Size(637, 630);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button removeActivity;
        private System.Windows.Forms.Button modifyActivity;
        private System.Windows.Forms.Button addActivity;
    }
}
