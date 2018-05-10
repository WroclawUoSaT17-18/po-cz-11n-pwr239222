namespace Milionerzy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.polnapol = new System.Windows.Forms.PictureBox();
            this.tabelawygranych = new System.Windows.Forms.PictureBox();
            this.zamianapytania = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.polnapol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelawygranych)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamianapytania)).BeginInit();
            this.SuspendLayout();
            // 
            // polnapol
            // 
            this.polnapol.Image = ((System.Drawing.Image)(resources.GetObject("polnapol.Image")));
            this.polnapol.Location = new System.Drawing.Point(782, 12);
            this.polnapol.Name = "polnapol";
            this.polnapol.Size = new System.Drawing.Size(110, 66);
            this.polnapol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.polnapol.TabIndex = 1;
            this.polnapol.TabStop = false;
            this.polnapol.Click += new System.EventHandler(this.polnapol_Click);
            // 
            // tabelawygranych
            // 
            this.tabelawygranych.BackColor = System.Drawing.Color.White;
            this.tabelawygranych.Image = ((System.Drawing.Image)(resources.GetObject("tabelawygranych.Image")));
            this.tabelawygranych.Location = new System.Drawing.Point(782, 151);
            this.tabelawygranych.Margin = new System.Windows.Forms.Padding(0);
            this.tabelawygranych.Name = "tabelawygranych";
            this.tabelawygranych.Size = new System.Drawing.Size(342, 314);
            this.tabelawygranych.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tabelawygranych.TabIndex = 0;
            this.tabelawygranych.TabStop = false;
            this.tabelawygranych.Click += new System.EventHandler(this.tabelawygranych_Click);
            // 
            // zamianapytania
            // 
            this.zamianapytania.Image = ((System.Drawing.Image)(resources.GetObject("zamianapytania.Image")));
            this.zamianapytania.Location = new System.Drawing.Point(978, 12);
            this.zamianapytania.Name = "zamianapytania";
            this.zamianapytania.Size = new System.Drawing.Size(146, 80);
            this.zamianapytania.TabIndex = 5;
            this.zamianapytania.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "0 plnn.png");
            this.imageList1.Images.SetKeyName(1, "500 pln.png");
            this.imageList1.Images.SetKeyName(2, "1000 pln.png");
            this.imageList1.Images.SetKeyName(3, "2000 pln.png");
            this.imageList1.Images.SetKeyName(4, "10000 pln.png");
            this.imageList1.Images.SetKeyName(5, "milion.png");
            this.imageList1.Images.SetKeyName(6, "20000 pln.png");
            this.imageList1.Images.SetKeyName(7, "40000 pln.png");
            this.imageList1.Images.SetKeyName(8, "75000 pln.png");
            this.imageList1.Images.SetKeyName(9, "250000 pln.png");
            this.imageList1.Images.SetKeyName(10, "500000 pln.png");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "kolo-.png");
            this.imageList2.Images.SetKeyName(1, "kolo+.png");
            this.imageList2.Images.SetKeyName(2, "zamiana-.png");
            this.imageList2.Images.SetKeyName(3, "zamiana+.png");
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(50, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 79);
            this.button1.TabIndex = 15;
            this.button1.Text = "A";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(443, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 79);
            this.button2.TabIndex = 16;
            this.button2.Text = "B";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(50, 378);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(254, 79);
            this.button3.TabIndex = 17;
            this.button3.Text = "C";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(443, 378);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(254, 79);
            this.button4.TabIndex = 18;
            this.button4.Text = "D";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(814, 111);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "50:50";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1013, 111);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 20;
            this.button6.Text = "Zamiana pytania";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Lime;
            this.textBox1.Location = new System.Drawing.Point(105, 111);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(548, 167);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(270, 29);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(202, 63);
            this.button7.TabIndex = 22;
            this.button7.Text = "Start";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1147, 476);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zamianapytania);
            this.Controls.Add(this.polnapol);
            this.Controls.Add(this.tabelawygranych);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Piłkarski quiz";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.polnapol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelawygranych)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamianapytania)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox polnapol;
        private System.Windows.Forms.PictureBox tabelawygranych;
        private System.Windows.Forms.PictureBox zamianapytania;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button7;


    }
}

