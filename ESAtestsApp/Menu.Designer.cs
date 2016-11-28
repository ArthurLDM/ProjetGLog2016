namespace ESAtestsApp
{
    partial class MenuForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitreLb = new System.Windows.Forms.Label();
            this.Consigne1Lb = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.EffectueLb = new System.Windows.Forms.Label();
            this.FacileLb = new System.Windows.Forms.Label();
            this.DifficileLb = new System.Windows.Forms.Label();
            this.Test1FCheckB = new System.Windows.Forms.CheckBox();
            this.Test1DCheckB = new System.Windows.Forms.CheckBox();
            this.Test2FCheckB = new System.Windows.Forms.CheckBox();
            this.Test3FCheckB = new System.Windows.Forms.CheckBox();
            this.Test4FCheckB = new System.Windows.Forms.CheckBox();
            this.Test5FCheckB = new System.Windows.Forms.CheckBox();
            this.Test2DCheckB = new System.Windows.Forms.CheckBox();
            this.Test3DCheckB = new System.Windows.Forms.CheckBox();
            this.Test4DCheckB = new System.Windows.Forms.CheckBox();
            this.Test5DCheckB = new System.Windows.Forms.CheckBox();
            this.Consigne2Lb = new System.Windows.Forms.Label();
            this.FacileBtn = new System.Windows.Forms.Button();
            this.DifficileBtn = new System.Windows.Forms.Button();
            this.OKBtn = new System.Windows.Forms.Button();
            this.ScoresBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitreLb
            // 
            this.TitreLb.AutoSize = true;
            this.TitreLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreLb.Location = new System.Drawing.Point(207, 15);
            this.TitreLb.Name = "TitreLb";
            this.TitreLb.Size = new System.Drawing.Size(292, 29);
            this.TitreLb.TabIndex = 0;
            this.TitreLb.Text = "Test ESA - Menu principal";
            // 
            // Consigne1Lb
            // 
            this.Consigne1Lb.AutoSize = true;
            this.Consigne1Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consigne1Lb.Location = new System.Drawing.Point(46, 98);
            this.Consigne1Lb.Name = "Consigne1Lb";
            this.Consigne1Lb.Size = new System.Drawing.Size(211, 20);
            this.Consigne1Lb.TabIndex = 1;
            this.Consigne1Lb.Text = "Choisir une catégorie de test";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Perception et mémoire associative",
            "Attention et concentration",
            "Calcul mental",
            "Problèmes mathématiques",
            "Problèmes physiques"});
            this.checkedListBox1.Location = new System.Drawing.Point(50, 143);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(317, 89);
            this.checkedListBox1.TabIndex = 2;
            // 
            // EffectueLb
            // 
            this.EffectueLb.AutoSize = true;
            this.EffectueLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EffectueLb.Location = new System.Drawing.Point(460, 98);
            this.EffectueLb.Name = "EffectueLb";
            this.EffectueLb.Size = new System.Drawing.Size(115, 16);
            this.EffectueLb.TabIndex = 3;
            this.EffectueLb.Text = "Test(s) effectué(s)";
            // 
            // FacileLb
            // 
            this.FacileLb.AutoSize = true;
            this.FacileLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacileLb.Location = new System.Drawing.Point(445, 118);
            this.FacileLb.Name = "FacileLb";
            this.FacileLb.Size = new System.Drawing.Size(45, 16);
            this.FacileLb.TabIndex = 4;
            this.FacileLb.Text = "Facile";
            // 
            // DifficileLb
            // 
            this.DifficileLb.AutoSize = true;
            this.DifficileLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficileLb.Location = new System.Drawing.Point(546, 118);
            this.DifficileLb.Name = "DifficileLb";
            this.DifficileLb.Size = new System.Drawing.Size(51, 16);
            this.DifficileLb.TabIndex = 5;
            this.DifficileLb.Text = "Difficile";
            // 
            // Test1FCheckB
            // 
            this.Test1FCheckB.AutoCheck = false;
            this.Test1FCheckB.AutoSize = true;
            this.Test1FCheckB.Location = new System.Drawing.Point(463, 143);
            this.Test1FCheckB.Name = "Test1FCheckB";
            this.Test1FCheckB.Size = new System.Drawing.Size(15, 14);
            this.Test1FCheckB.TabIndex = 6;
            this.Test1FCheckB.UseCompatibleTextRendering = true;
            this.Test1FCheckB.UseVisualStyleBackColor = true;
            // 
            // Test1DCheckB
            // 
            this.Test1DCheckB.AutoCheck = false;
            this.Test1DCheckB.AutoSize = true;
            this.Test1DCheckB.Location = new System.Drawing.Point(562, 143);
            this.Test1DCheckB.Name = "Test1DCheckB";
            this.Test1DCheckB.Size = new System.Drawing.Size(15, 14);
            this.Test1DCheckB.TabIndex = 7;
            this.Test1DCheckB.UseVisualStyleBackColor = true;
            // 
            // Test2FCheckB
            // 
            this.Test2FCheckB.AutoCheck = false;
            this.Test2FCheckB.AutoSize = true;
            this.Test2FCheckB.Location = new System.Drawing.Point(463, 163);
            this.Test2FCheckB.Name = "Test2FCheckB";
            this.Test2FCheckB.Size = new System.Drawing.Size(15, 14);
            this.Test2FCheckB.TabIndex = 8;
            this.Test2FCheckB.UseVisualStyleBackColor = true;
            // 
            // Test3FCheckB
            // 
            this.Test3FCheckB.AutoCheck = false;
            this.Test3FCheckB.AutoSize = true;
            this.Test3FCheckB.Location = new System.Drawing.Point(463, 183);
            this.Test3FCheckB.Name = "Test3FCheckB";
            this.Test3FCheckB.Size = new System.Drawing.Size(15, 14);
            this.Test3FCheckB.TabIndex = 9;
            this.Test3FCheckB.UseVisualStyleBackColor = true;
            // 
            // Test4FCheckB
            // 
            this.Test4FCheckB.AutoCheck = false;
            this.Test4FCheckB.AutoSize = true;
            this.Test4FCheckB.Location = new System.Drawing.Point(463, 204);
            this.Test4FCheckB.Name = "Test4FCheckB";
            this.Test4FCheckB.Size = new System.Drawing.Size(15, 14);
            this.Test4FCheckB.TabIndex = 10;
            this.Test4FCheckB.UseVisualStyleBackColor = true;
            // 
            // Test5FCheckB
            // 
            this.Test5FCheckB.AutoCheck = false;
            this.Test5FCheckB.AutoSize = true;
            this.Test5FCheckB.Location = new System.Drawing.Point(463, 225);
            this.Test5FCheckB.Name = "Test5FCheckB";
            this.Test5FCheckB.Size = new System.Drawing.Size(15, 14);
            this.Test5FCheckB.TabIndex = 11;
            this.Test5FCheckB.UseVisualStyleBackColor = true;
            // 
            // Test2DCheckB
            // 
            this.Test2DCheckB.AutoCheck = false;
            this.Test2DCheckB.AutoSize = true;
            this.Test2DCheckB.Location = new System.Drawing.Point(562, 164);
            this.Test2DCheckB.Name = "Test2DCheckB";
            this.Test2DCheckB.Size = new System.Drawing.Size(15, 14);
            this.Test2DCheckB.TabIndex = 12;
            this.Test2DCheckB.UseVisualStyleBackColor = true;
            // 
            // Test3DCheckB
            // 
            this.Test3DCheckB.AutoCheck = false;
            this.Test3DCheckB.AutoSize = true;
            this.Test3DCheckB.Location = new System.Drawing.Point(562, 183);
            this.Test3DCheckB.Name = "Test3DCheckB";
            this.Test3DCheckB.Size = new System.Drawing.Size(15, 14);
            this.Test3DCheckB.TabIndex = 13;
            this.Test3DCheckB.UseVisualStyleBackColor = true;
            // 
            // Test4DCheckB
            // 
            this.Test4DCheckB.AutoCheck = false;
            this.Test4DCheckB.AutoSize = true;
            this.Test4DCheckB.Location = new System.Drawing.Point(562, 204);
            this.Test4DCheckB.Name = "Test4DCheckB";
            this.Test4DCheckB.Size = new System.Drawing.Size(15, 14);
            this.Test4DCheckB.TabIndex = 14;
            this.Test4DCheckB.UseVisualStyleBackColor = true;
            // 
            // Test5DCheckB
            // 
            this.Test5DCheckB.AutoCheck = false;
            this.Test5DCheckB.AutoSize = true;
            this.Test5DCheckB.Location = new System.Drawing.Point(562, 225);
            this.Test5DCheckB.Name = "Test5DCheckB";
            this.Test5DCheckB.Size = new System.Drawing.Size(15, 14);
            this.Test5DCheckB.TabIndex = 15;
            this.Test5DCheckB.UseVisualStyleBackColor = true;
            // 
            // Consigne2Lb
            // 
            this.Consigne2Lb.AutoSize = true;
            this.Consigne2Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consigne2Lb.Location = new System.Drawing.Point(46, 270);
            this.Consigne2Lb.Name = "Consigne2Lb";
            this.Consigne2Lb.Size = new System.Drawing.Size(151, 20);
            this.Consigne2Lb.TabIndex = 16;
            this.Consigne2Lb.Text = "Choisir une difficulté";
            // 
            // FacileBtn
            // 
            this.FacileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacileBtn.Location = new System.Drawing.Point(96, 318);
            this.FacileBtn.Name = "FacileBtn";
            this.FacileBtn.Size = new System.Drawing.Size(75, 23);
            this.FacileBtn.TabIndex = 17;
            this.FacileBtn.Text = "Facile";
            this.FacileBtn.UseVisualStyleBackColor = true;
            // 
            // DifficileBtn
            // 
            this.DifficileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficileBtn.Location = new System.Drawing.Point(262, 318);
            this.DifficileBtn.Name = "DifficileBtn";
            this.DifficileBtn.Size = new System.Drawing.Size(75, 23);
            this.DifficileBtn.TabIndex = 18;
            this.DifficileBtn.Text = "Difficile";
            this.DifficileBtn.UseVisualStyleBackColor = true;
            // 
            // OKBtn
            // 
            this.OKBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKBtn.Location = new System.Drawing.Point(463, 381);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(119, 48);
            this.OKBtn.TabIndex = 19;
            this.OKBtn.Text = "Lancer le test";
            this.OKBtn.UseVisualStyleBackColor = true;
            // 
            // ScoresBtn
            // 
            this.ScoresBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoresBtn.Location = new System.Drawing.Point(50, 387);
            this.ScoresBtn.Name = "ScoresBtn";
            this.ScoresBtn.Size = new System.Drawing.Size(95, 36);
            this.ScoresBtn.TabIndex = 20;
            this.ScoresBtn.Text = "Scores";
            this.ScoresBtn.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.ScoresBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.DifficileBtn);
            this.Controls.Add(this.FacileBtn);
            this.Controls.Add(this.Consigne2Lb);
            this.Controls.Add(this.Test5DCheckB);
            this.Controls.Add(this.Test4DCheckB);
            this.Controls.Add(this.Test3DCheckB);
            this.Controls.Add(this.Test2DCheckB);
            this.Controls.Add(this.Test5FCheckB);
            this.Controls.Add(this.Test4FCheckB);
            this.Controls.Add(this.Test3FCheckB);
            this.Controls.Add(this.Test2FCheckB);
            this.Controls.Add(this.Test1DCheckB);
            this.Controls.Add(this.Test1FCheckB);
            this.Controls.Add(this.DifficileLb);
            this.Controls.Add(this.FacileLb);
            this.Controls.Add(this.EffectueLb);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.Consigne1Lb);
            this.Controls.Add(this.TitreLb);
            this.Name = "MenuForm";
            this.Text = "Menu principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitreLb;
        private System.Windows.Forms.Label Consigne1Lb;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label EffectueLb;
        private System.Windows.Forms.Label FacileLb;
        private System.Windows.Forms.Label DifficileLb;
        private System.Windows.Forms.CheckBox Test1FCheckB;
        private System.Windows.Forms.CheckBox Test1DCheckB;
        private System.Windows.Forms.CheckBox Test2FCheckB;
        private System.Windows.Forms.CheckBox Test3FCheckB;
        private System.Windows.Forms.CheckBox Test4FCheckB;
        private System.Windows.Forms.CheckBox Test5FCheckB;
        private System.Windows.Forms.CheckBox Test2DCheckB;
        private System.Windows.Forms.CheckBox Test3DCheckB;
        private System.Windows.Forms.CheckBox Test4DCheckB;
        private System.Windows.Forms.CheckBox Test5DCheckB;
        private System.Windows.Forms.Label Consigne2Lb;
        private System.Windows.Forms.Button FacileBtn;
        private System.Windows.Forms.Button DifficileBtn;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button ScoresBtn;
    }
}

