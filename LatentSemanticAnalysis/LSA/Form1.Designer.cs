
namespace LSA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.open_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dictionaryOPENED = new System.Windows.Forms.RichTextBox();
            this.dictionaryTXT1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dictionaryTXT2 = new System.Windows.Forms.RichTextBox();
            this.dictionaryTXT3 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.matrixU = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cosLABELtxt1 = new System.Windows.Forms.Label();
            this.cosLABELtxt2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cosLABELtxt3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.matrixV = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.matrixMBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // open_button
            // 
            this.open_button.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.open_button.Location = new System.Drawing.Point(12, 42);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(101, 36);
            this.open_button.TabIndex = 0;
            this.open_button.Text = "Open";
            this.open_button.UseVisualStyleBackColor = true;
            this.open_button.Click += new System.EventHandler(this.open_button_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(134, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Opened file";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(13, 185);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(480, 148);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(519, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dictionary";
            // 
            // dictionaryOPENED
            // 
            this.dictionaryOPENED.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dictionaryOPENED.Location = new System.Drawing.Point(519, 185);
            this.dictionaryOPENED.Name = "dictionaryOPENED";
            this.dictionaryOPENED.ReadOnly = true;
            this.dictionaryOPENED.Size = new System.Drawing.Size(214, 148);
            this.dictionaryOPENED.TabIndex = 5;
            this.dictionaryOPENED.Text = "";
            // 
            // dictionaryTXT1
            // 
            this.dictionaryTXT1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dictionaryTXT1.Location = new System.Drawing.Point(765, 87);
            this.dictionaryTXT1.Name = "dictionaryTXT1";
            this.dictionaryTXT1.ReadOnly = true;
            this.dictionaryTXT1.Size = new System.Drawing.Size(214, 145);
            this.dictionaryTXT1.TabIndex = 7;
            this.dictionaryTXT1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(765, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Text1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1008, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Text2";
            // 
            // dictionaryTXT2
            // 
            this.dictionaryTXT2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dictionaryTXT2.Location = new System.Drawing.Point(1008, 87);
            this.dictionaryTXT2.Name = "dictionaryTXT2";
            this.dictionaryTXT2.ReadOnly = true;
            this.dictionaryTXT2.Size = new System.Drawing.Size(214, 145);
            this.dictionaryTXT2.TabIndex = 7;
            this.dictionaryTXT2.Text = "";
            // 
            // dictionaryTXT3
            // 
            this.dictionaryTXT3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dictionaryTXT3.Location = new System.Drawing.Point(1262, 87);
            this.dictionaryTXT3.Name = "dictionaryTXT3";
            this.dictionaryTXT3.ReadOnly = true;
            this.dictionaryTXT3.Size = new System.Drawing.Size(214, 145);
            this.dictionaryTXT3.TabIndex = 9;
            this.dictionaryTXT3.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1262, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Text2";
            // 
            // matrixU
            // 
            this.matrixU.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.matrixU.Location = new System.Drawing.Point(765, 357);
            this.matrixU.Name = "matrixU";
            this.matrixU.ReadOnly = true;
            this.matrixU.Size = new System.Drawing.Size(756, 159);
            this.matrixU.TabIndex = 10;
            this.matrixU.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(765, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 27);
            this.label6.TabIndex = 11;
            this.label6.Text = "Matrix U";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(765, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 27);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cosine:";
            // 
            // cosLABELtxt1
            // 
            this.cosLABELtxt1.AutoSize = true;
            this.cosLABELtxt1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cosLABELtxt1.Location = new System.Drawing.Point(874, 247);
            this.cosLABELtxt1.Name = "cosLABELtxt1";
            this.cosLABELtxt1.Size = new System.Drawing.Size(25, 27);
            this.cosLABELtxt1.TabIndex = 15;
            this.cosLABELtxt1.Text = "_";
            // 
            // cosLABELtxt2
            // 
            this.cosLABELtxt2.AutoSize = true;
            this.cosLABELtxt2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cosLABELtxt2.Location = new System.Drawing.Point(1117, 247);
            this.cosLABELtxt2.Name = "cosLABELtxt2";
            this.cosLABELtxt2.Size = new System.Drawing.Size(25, 27);
            this.cosLABELtxt2.TabIndex = 17;
            this.cosLABELtxt2.Text = "_";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(1008, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 27);
            this.label10.TabIndex = 16;
            this.label10.Text = "Cosine:";
            // 
            // cosLABELtxt3
            // 
            this.cosLABELtxt3.AutoSize = true;
            this.cosLABELtxt3.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cosLABELtxt3.Location = new System.Drawing.Point(1371, 247);
            this.cosLABELtxt3.Name = "cosLABELtxt3";
            this.cosLABELtxt3.Size = new System.Drawing.Size(25, 27);
            this.cosLABELtxt3.TabIndex = 19;
            this.cosLABELtxt3.Text = "_";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(1262, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 27);
            this.label12.TabIndex = 18;
            this.label12.Text = "Cosine:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(765, 541);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 27);
            this.label7.TabIndex = 21;
            this.label7.Text = "Matrix V^T";
            // 
            // matrixV
            // 
            this.matrixV.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.matrixV.Location = new System.Drawing.Point(765, 583);
            this.matrixV.Name = "matrixV";
            this.matrixV.ReadOnly = true;
            this.matrixV.Size = new System.Drawing.Size(756, 159);
            this.matrixV.TabIndex = 20;
            this.matrixV.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 27);
            this.label9.TabIndex = 23;
            this.label9.Text = "Matrix M";
            // 
            // matrixMBox
            // 
            this.matrixMBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.matrixMBox.Location = new System.Drawing.Point(12, 394);
            this.matrixMBox.Name = "matrixMBox";
            this.matrixMBox.ReadOnly = true;
            this.matrixMBox.Size = new System.Drawing.Size(721, 348);
            this.matrixMBox.TabIndex = 22;
            this.matrixMBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 754);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.matrixMBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.matrixV);
            this.Controls.Add(this.cosLABELtxt3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cosLABELtxt2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cosLABELtxt1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.matrixU);
            this.Controls.Add(this.dictionaryTXT3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dictionaryTXT2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dictionaryTXT1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dictionaryOPENED);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.open_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox dictionaryOPENED;
        private System.Windows.Forms.RichTextBox dictionaryTXT1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox dictionaryTXT2;
        private System.Windows.Forms.RichTextBox dictionaryTXT3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox matrixU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label cosLABELtxt1;
        private System.Windows.Forms.Label cosLABELtxt2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label cosLABELtxt3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox matrixV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox matrixMBox;
    }
}

