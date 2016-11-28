namespace ESAtestsApp.TestQuestion
{
    partial class Test3QuestionForm
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
            this.MenuPrincipalBtn = new System.Windows.Forms.Button();
            this.NumQuestionLb = new System.Windows.Forms.Label();
            this.EnnonceQuestionLb = new System.Windows.Forms.Label();
            this.OKBtn = new System.Windows.Forms.Button();
            this.ReponseLb = new System.Windows.Forms.Label();
            this.ReponseTextB = new System.Windows.Forms.TextBox();
            this.ReponseGrB = new System.Windows.Forms.GroupBox();
            this.ReponseGrB.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitreLb
            // 
            this.TitreLb.AutoSize = true;
            this.TitreLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreLb.Location = new System.Drawing.Point(194, 23);
            this.TitreLb.Name = "TitreLb";
            this.TitreLb.Size = new System.Drawing.Size(251, 25);
            this.TitreLb.TabIndex = 2;
            this.TitreLb.Text = "Test ESA - Calcul mental";
            // 
            // MenuPrincipalBtn
            // 
            this.MenuPrincipalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPrincipalBtn.Location = new System.Drawing.Point(29, 406);
            this.MenuPrincipalBtn.Name = "MenuPrincipalBtn";
            this.MenuPrincipalBtn.Size = new System.Drawing.Size(135, 29);
            this.MenuPrincipalBtn.TabIndex = 5;
            this.MenuPrincipalBtn.Text = "Menu principal";
            this.MenuPrincipalBtn.UseVisualStyleBackColor = true;
            // 
            // NumQuestionLb
            // 
            this.NumQuestionLb.AutoSize = true;
            this.NumQuestionLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumQuestionLb.Location = new System.Drawing.Point(67, 87);
            this.NumQuestionLb.Name = "NumQuestionLb";
            this.NumQuestionLb.Size = new System.Drawing.Size(97, 20);
            this.NumQuestionLb.TabIndex = 6;
            this.NumQuestionLb.Text = "Question ../..";
            // 
            // EnnonceQuestionLb
            // 
            this.EnnonceQuestionLb.AutoSize = true;
            this.EnnonceQuestionLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnnonceQuestionLb.Location = new System.Drawing.Point(237, 164);
            this.EnnonceQuestionLb.Name = "EnnonceQuestionLb";
            this.EnnonceQuestionLb.Size = new System.Drawing.Size(208, 16);
            this.EnnonceQuestionLb.TabIndex = 7;
            this.EnnonceQuestionLb.Text = "Ennonce blablablablablablablabl";
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(565, 406);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(75, 23);
            this.OKBtn.TabIndex = 8;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = true;
            // 
            // ReponseLb
            // 
            this.ReponseLb.AutoSize = true;
            this.ReponseLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReponseLb.Location = new System.Drawing.Point(11, 45);
            this.ReponseLb.Name = "ReponseLb";
            this.ReponseLb.Size = new System.Drawing.Size(82, 20);
            this.ReponseLb.TabIndex = 9;
            this.ReponseLb.Text = "Réponse :";
            // 
            // ReponseTextB
            // 
            this.ReponseTextB.Location = new System.Drawing.Point(190, 47);
            this.ReponseTextB.Name = "ReponseTextB";
            this.ReponseTextB.Size = new System.Drawing.Size(100, 20);
            this.ReponseTextB.TabIndex = 10;
            // 
            // ReponseGrB
            // 
            this.ReponseGrB.Controls.Add(this.ReponseLb);
            this.ReponseGrB.Controls.Add(this.ReponseTextB);
            this.ReponseGrB.Location = new System.Drawing.Point(71, 238);
            this.ReponseGrB.Name = "ReponseGrB";
            this.ReponseGrB.Size = new System.Drawing.Size(465, 103);
            this.ReponseGrB.TabIndex = 11;
            this.ReponseGrB.TabStop = false;
            this.ReponseGrB.Visible = false;
            // 
            // Test3QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.ReponseGrB);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.EnnonceQuestionLb);
            this.Controls.Add(this.NumQuestionLb);
            this.Controls.Add(this.MenuPrincipalBtn);
            this.Controls.Add(this.TitreLb);
            this.Name = "Test3QuestionForm";
            this.Text = "Test ESA - Calcul mental";
            this.ReponseGrB.ResumeLayout(false);
            this.ReponseGrB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitreLb;
        private System.Windows.Forms.Button MenuPrincipalBtn;
        private System.Windows.Forms.Label NumQuestionLb;
        private System.Windows.Forms.Label EnnonceQuestionLb;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Label ReponseLb;
        private System.Windows.Forms.TextBox ReponseTextB;
        private System.Windows.Forms.GroupBox ReponseGrB;
    }
}