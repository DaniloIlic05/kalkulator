namespace kalkulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rbr = new System.Windows.Forms.RadioButton();
            this.rbk = new System.Windows.Forms.RadioButton();
            this.rbd = new System.Windows.Forms.RadioButton();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.ulaz = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rbr
            // 
            this.rbr.AutoSize = true;
            this.rbr.Location = new System.Drawing.Point(34, 13);
            this.rbr.Margin = new System.Windows.Forms.Padding(4);
            this.rbr.Name = "rbr";
            this.rbr.Size = new System.Drawing.Size(111, 23);
            this.rbr.TabIndex = 0;
            this.rbr.TabStop = true;
            this.rbr.Text = "Rimski brojevi";
            this.rbr.UseVisualStyleBackColor = true;
            // 
            // rbk
            // 
            this.rbk.AutoSize = true;
            this.rbk.Location = new System.Drawing.Point(153, 13);
            this.rbk.Margin = new System.Windows.Forms.Padding(4);
            this.rbk.Name = "rbk";
            this.rbk.Size = new System.Drawing.Size(142, 23);
            this.rbk.TabIndex = 1;
            this.rbk.TabStop = true;
            this.rbk.Text = "Kompleksni brojevi";
            this.rbk.UseVisualStyleBackColor = true;
            // 
            // rbd
            // 
            this.rbd.AutoSize = true;
            this.rbd.Location = new System.Drawing.Point(303, 13);
            this.rbd.Margin = new System.Windows.Forms.Padding(4);
            this.rbd.Name = "rbd";
            this.rbd.Size = new System.Drawing.Size(101, 23);
            this.rbd.TabIndex = 2;
            this.rbd.TabStop = true;
            this.rbd.Text = "Dugi brojevi";
            this.rbd.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(34, 405);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(66, 70);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "+";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(110, 405);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(66, 70);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "-";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(186, 405);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(66, 70);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "*";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(262, 405);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(66, 70);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "/";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(338, 405);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(66, 70);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "=";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // ulaz
            // 
            this.ulaz.Location = new System.Drawing.Point(34, 43);
            this.ulaz.Multiline = true;
            this.ulaz.Name = "ulaz";
            this.ulaz.Size = new System.Drawing.Size(370, 356);
            this.ulaz.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(444, 498);
            this.Controls.Add(this.ulaz);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.rbd);
            this.Controls.Add(this.rbk);
            this.Controls.Add(this.rbr);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbr;
        private System.Windows.Forms.RadioButton rbk;
        private System.Windows.Forms.RadioButton rbd;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.TextBox ulaz;
    }
}

