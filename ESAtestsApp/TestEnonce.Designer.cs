namespace ESAtestsApp
{
    partial class EnonceForm
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
            this.TitreLb = new System.Windows.Forms.Label();
            this.Consigne1Lb = new System.Windows.Forms.Label();
            this.Consigne2Lb = new System.Windows.Forms.Label();
            this.Consigne3Lb = new System.Windows.Forms.Label();
            this.ExempleImg = new System.Windows.Forms.PictureBox();
            this.Consigne4Lb = new System.Windows.Forms.Label();
            this.LancerBtn = new System.Windows.Forms.Button();
            this.MenuBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ExempleImg)).BeginInit();
            this.SuspendLayout();
            // 
            // TitreLb
            // 
            this.TitreLb.AutoSize = true;
            this.TitreLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreLb.Location = new System.Drawing.Point(245, 15);
            this.TitreLb.Name = "TitreLb";
            this.TitreLb.Size = new System.Drawing.Size(210, 29);
            this.TitreLb.TabIndex = 0;
            this.TitreLb.Text = "Test ESA—Enoncé";
            // 
            // Consigne1Lb
            // 
            this.Consigne1Lb.AutoSize = true;
            this.Consigne1Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consigne1Lb.Location = new System.Drawing.Point(324, 80);
            this.Consigne1Lb.Name = "Consigne1Lb";
            this.Consigne1Lb.Size = new System.Drawing.Size(72, 20);
            this.Consigne1Lb.TabIndex = 1;
            this.Consigne1Lb.Text = "Enoncé :";
            // 
            // Consigne2Lb
            // 
            this.Consigne2Lb.AutoSize = true;
            this.Consigne2Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consigne2Lb.Location = new System.Drawing.Point(12, 123);
            this.Consigne2Lb.Name = "Consigne2Lb";
            this.Consigne2Lb.Size = new System.Drawing.Size(206, 16);
            this.Consigne2Lb.TabIndex = 3;
            this.Consigne2Lb.Text = "Enoncé génére automatiquement";
            // 
            // Consigne3Lb
            // 
            this.Consigne3Lb.AutoSize = true;
            this.Consigne3Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consigne3Lb.Location = new System.Drawing.Point(324, 198);
            this.Consigne3Lb.Name = "Consigne3Lb";
            this.Consigne3Lb.Size = new System.Drawing.Size(78, 20);
            this.Consigne3Lb.TabIndex = 4;
            this.Consigne3Lb.Text = "Exemple :";
            // 
            // ExempleImg
            // 
            this.ExempleImg.Location = new System.Drawing.Point(278, 221);
            this.ExempleImg.Name = "ExempleImg";
            this.ExempleImg.Size = new System.Drawing.Size(177, 144);
            this.ExempleImg.TabIndex = 5;
            this.ExempleImg.TabStop = false;
            // 
            // Consigne4Lb
            // 
            this.Consigne4Lb.AutoSize = true;
            this.Consigne4Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consigne4Lb.Location = new System.Drawing.Point(12, 385);
            this.Consigne4Lb.Name = "Consigne4Lb";
            this.Consigne4Lb.Size = new System.Drawing.Size(147, 16);
            this.Consigne4Lb.TabIndex = 6;
            this.Consigne4Lb.Text = "Difficulté :  facile donc ….";
            // 
            // LancerBtn
            // 
            this.LancerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LancerBtn.Location = new System.Drawing.Point(568, 427);
            this.LancerBtn.Name = "LancerBtn";
            this.LancerBtn.Size = new System.Drawing.Size(104, 23);
            this.LancerBtn.TabIndex = 7;
            this.LancerBtn.Text = "Lancer le test";
            this.LancerBtn.UseVisualStyleBackColor = true;
            // 
            // MenuBtn
            // 
            this.MenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBtn.Location = new System.Drawing.Point(13, 426);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(110, 23);
            this.MenuBtn.TabIndex = 8;
            this.MenuBtn.Text = "Menu Principal";
            this.MenuBtn.UseVisualStyleBackColor = true;
            // 
            // EnonceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.MenuBtn);
            this.Controls.Add(this.LancerBtn);
            this.Controls.Add(this.Consigne4Lb);
            this.Controls.Add(this.ExempleImg);
            this.Controls.Add(this.Consigne3Lb);
            this.Controls.Add(this.Consigne2Lb);
            this.Controls.Add(this.Consigne1Lb);
            this.Controls.Add(this.TitreLb);
            this.Name = "EnonceForm";
            this.Text = "Test ESA - Nom du test";
            ((System.ComponentModel.ISupportInitialize)(this.ExempleImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitreLb;
        private System.Windows.Forms.Label Consigne1Lb;
        private System.Windows.Forms.Label Consigne2Lb;
        private System.Windows.Forms.Label Consigne3Lb;
        private System.Windows.Forms.PictureBox ExempleImg;
        private System.Windows.Forms.Label Consigne4Lb;
        private System.Windows.Forms.Button LancerBtn;
        private System.Windows.Forms.Button MenuBtn;
    }
}