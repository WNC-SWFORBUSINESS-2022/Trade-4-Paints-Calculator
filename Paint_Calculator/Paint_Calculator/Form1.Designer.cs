
namespace Paint_Calculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button19 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button20 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Javanese Text", 11F);
            this.button1.Location = new System.Drawing.Point(112, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Metres";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Javanese Text", 11F);
            this.textBox1.Location = new System.Drawing.Point(12, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 41);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Javanese Text", 11F);
            this.textBox2.Location = new System.Drawing.Point(12, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(94, 41);
            this.textBox2.TabIndex = 2;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Javanese Text", 11F);
            this.button2.Location = new System.Drawing.Point(113, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Metres";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Javanese Text", 11F);
            this.button18.Location = new System.Drawing.Point(12, 171);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(94, 41);
            this.button18.TabIndex = 19;
            this.button18.Text = "Enter";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Javanese Text", 11F);
            this.button19.Location = new System.Drawing.Point(291, 225);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(94, 41);
            this.button19.TabIndex = 23;
            this.button19.Text = "Calculate";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 34);
            this.label2.TabIndex = 24;
            this.label2.Text = "Insert surface area (m²):";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Javanese Text", 11F);
            this.textBox4.Location = new System.Drawing.Point(190, 225);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(95, 41);
            this.textBox4.TabIndex = 25;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox5.Font = new System.Drawing.Font("Javanese Text", 11F);
            this.textBox5.Location = new System.Drawing.Point(404, 46);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(95, 41);
            this.textBox5.TabIndex = 26;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(398, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 34);
            this.label3.TabIndex = 27;
            this.label3.Text = "Small Paint Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(520, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 34);
            this.label4.TabIndex = 28;
            this.label4.Text = "Small Paint Trade Price";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Javanese Text", 11F);
            this.textBox6.Location = new System.Drawing.Point(525, 46);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(95, 41);
            this.textBox6.TabIndex = 29;
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Javanese Text", 11F);
            this.textBox7.Location = new System.Drawing.Point(404, 127);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(95, 41);
            this.textBox7.TabIndex = 33;
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(520, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 34);
            this.label5.TabIndex = 32;
            this.label5.Text = "Large Paint Trade Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(398, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 34);
            this.label6.TabIndex = 31;
            this.label6.Text = "Large Paint Size";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Javanese Text", 11F);
            this.textBox8.Location = new System.Drawing.Point(526, 127);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(95, 41);
            this.textBox8.TabIndex = 30;
            this.textBox8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox8_KeyPress);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(436, 265);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(94, 41);
            this.button20.TabIndex = 34;
            this.button20.Text = "Save";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(548, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(690, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 34);
            this.label7.TabIndex = 39;
            this.label7.Text = "Large Paint Dom Price";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Javanese Text", 11F);
            this.textBox9.Location = new System.Drawing.Point(696, 124);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(95, 41);
            this.textBox9.TabIndex = 38;
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Javanese Text", 11F);
            this.textBox10.Location = new System.Drawing.Point(696, 46);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(95, 41);
            this.textBox10.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(690, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 34);
            this.label8.TabIndex = 36;
            this.label8.Text = "Small Paint Dom Price";
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(411, 181);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(147, 44);
            this.checkBox1.TabIndex = 40;
            this.checkBox1.Text = "Enable Trade Price";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(445, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 34);
            this.label9.TabIndex = 41;
            this.label9.Text = "Disabled";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 34);
            this.label1.TabIndex = 42;
            this.label1.Text = "Height";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 34);
            this.label10.TabIndex = 43;
            this.label10.Text = "Width";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 369);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button18;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
    }
}

