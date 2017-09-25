namespace szarendszer
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.onB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ocB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ncB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nnB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kérem adja meg az átszámítani kívánt számot!";
            // 
            // onB
            // 
            this.onB.Location = new System.Drawing.Point(34, 68);
            this.onB.Name = "onB";
            this.onB.Size = new System.Drawing.Size(299, 20);
            this.onB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kérem adja meg hanyas az eredeti sz.rend.! (2-36)";
            // 
            // ocB
            // 
            this.ocB.Location = new System.Drawing.Point(34, 146);
            this.ocB.Name = "ocB";
            this.ocB.Size = new System.Drawing.Size(299, 20);
            this.ocB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(378, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kérem adja meg hanyas számredszerben szeretné visszakapni a számot! (2-36)";
            // 
            // ncB
            // 
            this.ncB.Location = new System.Drawing.Point(34, 236);
            this.ncB.Name = "ncB";
            this.ncB.Size = new System.Drawing.Size(299, 20);
            this.ncB.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nnB
            // 
            this.nnB.Location = new System.Drawing.Point(139, 334);
            this.nnB.Name = "nnB";
            this.nnB.Size = new System.Drawing.Size(100, 20);
            this.nnB.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::szarendszer.Properties.Resources.szallas_koberc_panzio_bozsva_08;
            this.ClientSize = new System.Drawing.Size(408, 382);
            this.Controls.Add(this.nnB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ncB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ocB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.onB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Átváltás számrendszerek között";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox onB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ocB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ncB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nnB;
    }
}

