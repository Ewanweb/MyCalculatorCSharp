namespace MyCalculater
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
            this.txtN1 = new System.Windows.Forms.NumericUpDown();
            this.txtN2 = new System.Windows.Forms.NumericUpDown();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnDevide = new System.Windows.Forms.Button();
            this.btnMultiple = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtN1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtN2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "عدد اول:";
            // 
            // label2
            // 
            this.label2.AccessibleDescription = "عدد دوم";
            this.label2.AccessibleName = "عدد دوم";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "عدد دوم:";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(39, 52);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(312, 21);
            this.txtN1.TabIndex = 2;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(38, 89);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(312, 21);
            this.txtN2.TabIndex = 3;
            // 
            // btnPlus
            // 
            this.btnPlus.AccessibleName = "btnPlus";
            this.btnPlus.Location = new System.Drawing.Point(38, 116);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnDevide
            // 
            this.btnDevide.AccessibleName = "btnDevide";
            this.btnDevide.Location = new System.Drawing.Point(281, 117);
            this.btnDevide.Name = "btnDevide";
            this.btnDevide.Size = new System.Drawing.Size(75, 23);
            this.btnDevide.TabIndex = 5;
            this.btnDevide.Text = "/";
            this.btnDevide.UseVisualStyleBackColor = true;
            this.btnDevide.Click += new System.EventHandler(this.btnDevide_Click);
            // 
            // btnMultiple
            // 
            this.btnMultiple.AccessibleName = "btnMultiple";
            this.btnMultiple.Location = new System.Drawing.Point(200, 117);
            this.btnMultiple.Name = "btnMultiple";
            this.btnMultiple.Size = new System.Drawing.Size(75, 23);
            this.btnMultiple.TabIndex = 6;
            this.btnMultiple.Text = "*";
            this.btnMultiple.UseVisualStyleBackColor = true;
            this.btnMultiple.Click += new System.EventHandler(this.btnMultiple_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.AccessibleName = "btnMinus";
            this.btnMinus.Location = new System.Drawing.Point(119, 117);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 23);
            this.btnMinus.TabIndex = 7;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 218);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnMultiple);
            this.Controls.Add(this.btnDevide);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ماشین حساب من";
            ((System.ComponentModel.ISupportInitialize)(this.txtN1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtN2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtN1;
        private System.Windows.Forms.NumericUpDown txtN2;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnDevide;
        private System.Windows.Forms.Button btnMultiple;
        private System.Windows.Forms.Button btnMinus;
    }
}

