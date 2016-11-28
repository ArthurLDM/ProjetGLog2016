namespace ESAtestsApp
{
    partial class SerieForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuBtn = new System.Windows.Forms.Button();
            this.LancerBtn = new System.Windows.Forms.Button();
            this.TitreLb = new System.Windows.Forms.Label();
            this.NumSerieLb = new System.Windows.Forms.Label();
            this.Consigne1Lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MenuBtn
            // 
            this.MenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBtn.Location = new System.Drawing.Point(12, 427);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(109, 23);
            this.MenuBtn.TabIndex = 9;
            this.MenuBtn.Text = "Menu Principal";
            this.MenuBtn.UseVisualStyleBackColor = true;
            // 
            // LancerBtn
            // 
            this.LancerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LancerBtn.Location = new System.Drawing.Point(574, 427);
            this.LancerBtn.Name = "LancerBtn";
            this.LancerBtn.Size = new System.Drawing.Size(98, 23);
            this.LancerBtn.TabIndex = 10;
            this.LancerBtn.Text = "Lancer le test";
            this.LancerBtn.UseVisualStyleBackColor = true;
            // 
            // TitreLb
            // 
            this.TitreLb.AutoSize = true;
            this.TitreLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreLb.Location = new System.Drawing.Point(224, 15);
            this.TitreLb.Name = "TitreLb";
            this.TitreLb.Size = new System.Drawing.Size(257, 29);
            this.TitreLb.TabIndex = 11;
            this.TitreLb.Text = "Test ESA—Nom du test";
            // 
            // NumSerieLb
            // 
            this.NumSerieLb.AutoSize = true;
            this.NumSerieLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumSerieLb.Location = new System.Drawing.Point(293, 139);
            this.NumSerieLb.Name = "NumSerieLb";
            this.NumSerieLb.Size = new System.Drawing.Size(128, 31);
            this.NumSerieLb.TabIndex = 12;
            this.NumSerieLb.Text = "Serie N°x";
            // 
            // Consigne1Lb
            // 
            this.Consigne1Lb.AutoSize = true;
            this.Consigne1Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consigne1Lb.Location = new System.Drawing.Point(36, 216);
            this.Consigne1Lb.Name = "Consigne1Lb";
            this.Consigne1Lb.Size = new System.Drawing.Size(140, 16);
            this.Consigne1Lb.TabIndex = 13;
            this.Consigne1Lb.Text = "Règle pour cette série";
            // 
            // SerieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.Consigne1Lb);
            this.Controls.Add(this.NumSerieLb);
            this.Controls.Add(this.TitreLb);
            this.Controls.Add(this.LancerBtn);
            this.Controls.Add(this.MenuBtn);
            this.Name = "SerieForm";
            this.Text = "Test ESA - Nom du test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MenuBtn;
        private System.Windows.Forms.Button LancerBtn;
        private System.Windows.Forms.Label TitreLb;
        private System.Windows.Forms.Label NumSerieLb;
        private System.Windows.Forms.Label Consigne1Lb;
    }
}