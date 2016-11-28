namespace ESAtestsApp
{
    partial class Test3OperationFrom
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
            this.AdditionBtn = new System.Windows.Forms.Button();
            this.SoustractionBtn = new System.Windows.Forms.Button();
            this.DivisionBtn = new System.Windows.Forms.Button();
            this.Multiplicationbtn = new System.Windows.Forms.Button();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitreLb
            // 
            this.TitreLb.AutoSize = true;
            this.TitreLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreLb.Location = new System.Drawing.Point(196, 15);
            this.TitreLb.Name = "TitreLb";
            this.TitreLb.Size = new System.Drawing.Size(273, 29);
            this.TitreLb.TabIndex = 15;
            this.TitreLb.Text = "Test ESA—Calcul mental";
            // 
            // Consigne1Lb
            // 
            this.Consigne1Lb.AutoSize = true;
            this.Consigne1Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consigne1Lb.Location = new System.Drawing.Point(59, 131);
            this.Consigne1Lb.Name = "Consigne1Lb";
            this.Consigne1Lb.Size = new System.Drawing.Size(119, 16);
            this.Consigne1Lb.TabIndex = 16;
            this.Consigne1Lb.Text = "Vous voulez faire : ";
            // 
            // AdditionBtn
            // 
            this.AdditionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionBtn.Location = new System.Drawing.Point(287, 176);
            this.AdditionBtn.Name = "AdditionBtn";
            this.AdditionBtn.Size = new System.Drawing.Size(75, 27);
            this.AdditionBtn.TabIndex = 17;
            this.AdditionBtn.Text = "+";
            this.AdditionBtn.UseVisualStyleBackColor = true;
            // 
            // SoustractionBtn
            // 
            this.SoustractionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoustractionBtn.Location = new System.Drawing.Point(287, 224);
            this.SoustractionBtn.Name = "SoustractionBtn";
            this.SoustractionBtn.Size = new System.Drawing.Size(75, 27);
            this.SoustractionBtn.TabIndex = 18;
            this.SoustractionBtn.Text = "-";
            this.SoustractionBtn.UseVisualStyleBackColor = true;
            // 
            // DivisionBtn
            // 
            this.DivisionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionBtn.Location = new System.Drawing.Point(287, 331);
            this.DivisionBtn.Name = "DivisionBtn";
            this.DivisionBtn.Size = new System.Drawing.Size(75, 27);
            this.DivisionBtn.TabIndex = 19;
            this.DivisionBtn.Text = "/";
            this.DivisionBtn.UseVisualStyleBackColor = true;
            // 
            // Multiplicationbtn
            // 
            this.Multiplicationbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplicationbtn.Location = new System.Drawing.Point(287, 279);
            this.Multiplicationbtn.Name = "Multiplicationbtn";
            this.Multiplicationbtn.Size = new System.Drawing.Size(75, 27);
            this.Multiplicationbtn.TabIndex = 20;
            this.Multiplicationbtn.Text = "x";
            this.Multiplicationbtn.UseVisualStyleBackColor = true;
            // 
            // MenuBtn
            // 
            this.MenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBtn.Location = new System.Drawing.Point(12, 427);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(108, 23);
            this.MenuBtn.TabIndex = 23;
            this.MenuBtn.Text = "Menu Principal";
            this.MenuBtn.UseVisualStyleBackColor = true;
            // 
            // Test3OperationFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.MenuBtn);
            this.Controls.Add(this.Multiplicationbtn);
            this.Controls.Add(this.DivisionBtn);
            this.Controls.Add(this.SoustractionBtn);
            this.Controls.Add(this.AdditionBtn);
            this.Controls.Add(this.Consigne1Lb);
            this.Controls.Add(this.TitreLb);
            this.Name = "Test3OperationFrom";
            this.Text = "Test ESA - Calcul mental";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitreLb;
        private System.Windows.Forms.Label Consigne1Lb;
        private System.Windows.Forms.Button AdditionBtn;
        private System.Windows.Forms.Button SoustractionBtn;
        private System.Windows.Forms.Button DivisionBtn;
        private System.Windows.Forms.Button Multiplicationbtn;
        private System.Windows.Forms.Button MenuBtn;
    }
}