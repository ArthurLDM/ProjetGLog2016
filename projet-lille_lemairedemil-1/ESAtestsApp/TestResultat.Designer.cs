namespace ESAtestsApp
{
    partial class ResultatForm
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
            this.MenuBtn = new System.Windows.Forms.Button();
            this.OKBtn = new System.Windows.Forms.Button();
            this.ResultatsLb = new System.Windows.Forms.Label();
            this.BonneRepLb = new System.Windows.Forms.Label();
            this.MauvaiseRepLb = new System.Windows.Forms.Label();
            this.ReussiteLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitreLb
            // 
            this.TitreLb.AutoSize = true;
            this.TitreLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreLb.Location = new System.Drawing.Point(214, 15);
            this.TitreLb.Name = "TitreLb";
            this.TitreLb.Size = new System.Drawing.Size(257, 29);
            this.TitreLb.TabIndex = 12;
            this.TitreLb.Text = "Test ESA—Nom du test";
            // 
            // MenuBtn
            // 
            this.MenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBtn.Location = new System.Drawing.Point(12, 427);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(108, 23);
            this.MenuBtn.TabIndex = 13;
            this.MenuBtn.Text = "Menu Principal";
            this.MenuBtn.UseVisualStyleBackColor = true;
            // 
            // OKBtn
            // 
            this.OKBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKBtn.Location = new System.Drawing.Point(597, 427);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(75, 23);
            this.OKBtn.TabIndex = 14;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = true;
            // 
            // ResultatsLb
            // 
            this.ResultatsLb.AutoSize = true;
            this.ResultatsLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultatsLb.Location = new System.Drawing.Point(278, 135);
            this.ResultatsLb.Name = "ResultatsLb";
            this.ResultatsLb.Size = new System.Drawing.Size(144, 31);
            this.ResultatsLb.TabIndex = 15;
            this.ResultatsLb.Text = "Résultats :";
            // 
            // BonneRepLb
            // 
            this.BonneRepLb.AutoSize = true;
            this.BonneRepLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BonneRepLb.Location = new System.Drawing.Point(44, 204);
            this.BonneRepLb.Name = "BonneRepLb";
            this.BonneRepLb.Size = new System.Drawing.Size(122, 16);
            this.BonneRepLb.TabIndex = 16;
            this.BonneRepLb.Text = "x bonnes réponses";
            // 
            // MauvaiseRepLb
            // 
            this.MauvaiseRepLb.AutoSize = true;
            this.MauvaiseRepLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MauvaiseRepLb.Location = new System.Drawing.Point(44, 239);
            this.MauvaiseRepLb.Name = "MauvaiseRepLb";
            this.MauvaiseRepLb.Size = new System.Drawing.Size(144, 16);
            this.MauvaiseRepLb.TabIndex = 17;
            this.MauvaiseRepLb.Text = "y mauvaises réponses";
            // 
            // ReussiteLb
            // 
            this.ReussiteLb.AutoSize = true;
            this.ReussiteLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReussiteLb.Location = new System.Drawing.Point(44, 309);
            this.ReussiteLb.Name = "ReussiteLb";
            this.ReussiteLb.Size = new System.Drawing.Size(116, 20);
            this.ReussiteLb.TabIndex = 18;
            this.ReussiteLb.Text = "X% de réussite";
            // 
            // ResultatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.ReussiteLb);
            this.Controls.Add(this.MauvaiseRepLb);
            this.Controls.Add(this.BonneRepLb);
            this.Controls.Add(this.ResultatsLb);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.MenuBtn);
            this.Controls.Add(this.TitreLb);
            this.Name = "ResultatForm";
            this.Text = "Test ESA - Nom du test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitreLb;
        private System.Windows.Forms.Button MenuBtn;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Label ResultatsLb;
        private System.Windows.Forms.Label BonneRepLb;
        private System.Windows.Forms.Label MauvaiseRepLb;
        private System.Windows.Forms.Label ReussiteLb;
    }
}