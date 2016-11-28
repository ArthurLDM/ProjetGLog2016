namespace ESAtestsApp.TestQuestion
{
    partial class Test2QuestionForm
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
            this.NumQuestionLb = new System.Windows.Forms.Label();
            this.EnnonceQuestionLb = new System.Windows.Forms.Label();
            this.MenuPrincipalBtn = new System.Windows.Forms.Button();
            this.Choix1Btn = new System.Windows.Forms.Button();
            this.Choix2Btn = new System.Windows.Forms.Button();
            this.Choix3Btn = new System.Windows.Forms.Button();
            this.QuestionGrB = new System.Windows.Forms.GroupBox();
            this.QuestionGrB.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitreLb
            // 
            this.TitreLb.AutoSize = true;
            this.TitreLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreLb.Location = new System.Drawing.Point(151, 15);
            this.TitreLb.Name = "TitreLb";
            this.TitreLb.Size = new System.Drawing.Size(366, 25);
            this.TitreLb.TabIndex = 1;
            this.TitreLb.Text = "Test ESA - Attention et concentration";
            // 
            // NumQuestionLb
            // 
            this.NumQuestionLb.AutoSize = true;
            this.NumQuestionLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumQuestionLb.Location = new System.Drawing.Point(56, 91);
            this.NumQuestionLb.Name = "NumQuestionLb";
            this.NumQuestionLb.Size = new System.Drawing.Size(97, 20);
            this.NumQuestionLb.TabIndex = 2;
            this.NumQuestionLb.Text = "Question ../..";
            // 
            // EnnonceQuestionLb
            // 
            this.EnnonceQuestionLb.AutoSize = true;
            this.EnnonceQuestionLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnnonceQuestionLb.Location = new System.Drawing.Point(57, 133);
            this.EnnonceQuestionLb.Name = "EnnonceQuestionLb";
            this.EnnonceQuestionLb.Size = new System.Drawing.Size(220, 16);
            this.EnnonceQuestionLb.TabIndex = 3;
            this.EnnonceQuestionLb.Text = "Ennonce Butt1 = ... Butt2 = .. Butt 3 = ..";
            // 
            // MenuPrincipalBtn
            // 
            this.MenuPrincipalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPrincipalBtn.Location = new System.Drawing.Point(60, 396);
            this.MenuPrincipalBtn.Name = "MenuPrincipalBtn";
            this.MenuPrincipalBtn.Size = new System.Drawing.Size(135, 29);
            this.MenuPrincipalBtn.TabIndex = 4;
            this.MenuPrincipalBtn.Text = "Menu principal";
            this.MenuPrincipalBtn.UseVisualStyleBackColor = true;
            // 
            // Choix1Btn
            // 
            this.Choix1Btn.Location = new System.Drawing.Point(450, 35);
            this.Choix1Btn.Name = "Choix1Btn";
            this.Choix1Btn.Size = new System.Drawing.Size(75, 23);
            this.Choix1Btn.TabIndex = 5;
            this.Choix1Btn.Text = "Butt1";
            this.Choix1Btn.UseVisualStyleBackColor = true;
            this.Choix1Btn.Visible = false;
            // 
            // Choix2Btn
            // 
            this.Choix2Btn.Location = new System.Drawing.Point(450, 79);
            this.Choix2Btn.Name = "Choix2Btn";
            this.Choix2Btn.Size = new System.Drawing.Size(75, 23);
            this.Choix2Btn.TabIndex = 6;
            this.Choix2Btn.Text = "Butt2";
            this.Choix2Btn.UseVisualStyleBackColor = true;
            this.Choix2Btn.Visible = false;
            // 
            // Choix3Btn
            // 
            this.Choix3Btn.Location = new System.Drawing.Point(450, 127);
            this.Choix3Btn.Name = "Choix3Btn";
            this.Choix3Btn.Size = new System.Drawing.Size(75, 23);
            this.Choix3Btn.TabIndex = 7;
            this.Choix3Btn.Text = "Butt3";
            this.Choix3Btn.UseVisualStyleBackColor = true;
            // 
            // QuestionGrB
            // 
            this.QuestionGrB.Controls.Add(this.Choix1Btn);
            this.QuestionGrB.Controls.Add(this.Choix3Btn);
            this.QuestionGrB.Controls.Add(this.Choix2Btn);
            this.QuestionGrB.Location = new System.Drawing.Point(60, 177);
            this.QuestionGrB.Name = "QuestionGrB";
            this.QuestionGrB.Size = new System.Drawing.Size(564, 191);
            this.QuestionGrB.TabIndex = 8;
            this.QuestionGrB.TabStop = false;
            // 
            // Test2QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.QuestionGrB);
            this.Controls.Add(this.MenuPrincipalBtn);
            this.Controls.Add(this.EnnonceQuestionLb);
            this.Controls.Add(this.NumQuestionLb);
            this.Controls.Add(this.TitreLb);
            this.Name = "Test2QuestionForm";
            this.Text = "Test ESA - Attention et concentration";
            this.QuestionGrB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitreLb;
        private System.Windows.Forms.Label NumQuestionLb;
        private System.Windows.Forms.Label EnnonceQuestionLb;
        private System.Windows.Forms.Button MenuPrincipalBtn;
        private System.Windows.Forms.Button Choix1Btn;
        private System.Windows.Forms.Button Choix2Btn;
        private System.Windows.Forms.Button Choix3Btn;
        private System.Windows.Forms.GroupBox QuestionGrB;
    }
}