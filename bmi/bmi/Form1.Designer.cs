﻿namespace bmi
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
            this.label2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.weightB = new System.Windows.Forms.TextBox();
            this.heightB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add meg a testsúlyod!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add meg a magasságod!";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(69, 243);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // weightB
            // 
            this.weightB.Location = new System.Drawing.Point(75, 72);
            this.weightB.Name = "weightB";
            this.weightB.Size = new System.Drawing.Size(100, 20);
            this.weightB.TabIndex = 4;
            // 
            // heightB
            // 
            this.heightB.Location = new System.Drawing.Point(75, 154);
            this.heightB.Name = "heightB";
            this.heightB.Size = new System.Drawing.Size(100, 20);
            this.heightB.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 309);
            this.Controls.Add(this.heightB);
            this.Controls.Add(this.weightB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox weightB;
        private System.Windows.Forms.TextBox heightB;
    }
}

