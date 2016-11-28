namespace ESAtestsApp
{
    partial class ScoreForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NomsTests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Facile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Difficile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitreLb
            // 
            this.TitreLb.AutoSize = true;
            this.TitreLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreLb.Location = new System.Drawing.Point(228, 15);
            this.TitreLb.Name = "TitreLb";
            this.TitreLb.Size = new System.Drawing.Size(204, 29);
            this.TitreLb.TabIndex = 13;
            this.TitreLb.Text = "Test ESA—Scores";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomsTests,
            this.Facile,
            this.Difficile});
            this.dataGridView1.Location = new System.Drawing.Point(24, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(633, 150);
            this.dataGridView1.TabIndex = 14;
            // 
            // NomsTests
            // 
            this.NomsTests.HeaderText = "";
            this.NomsTests.Name = "NomsTests";
            // 
            // Facile
            // 
            this.Facile.HeaderText = "Facile";
            this.Facile.Name = "Facile";
            // 
            // Difficile
            // 
            this.Difficile.HeaderText = "Difficile";
            this.Difficile.Name = "Difficile";
            // 
            // MenuBtn
            // 
            this.MenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBtn.Location = new System.Drawing.Point(12, 427);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(108, 23);
            this.MenuBtn.TabIndex = 15;
            this.MenuBtn.Text = "Menu Principal";
            this.MenuBtn.UseVisualStyleBackColor = true;
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.MenuBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TitreLb);
            this.Name = "ScoreForm";
            this.Text = "Test ESA - Nom du test";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitreLb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomsTests;
        private System.Windows.Forms.DataGridViewTextBoxColumn Facile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Difficile;
        private System.Windows.Forms.Button MenuBtn;
    }
}