namespace WootenT_DrinkMch
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
            this.ColaLabel = new System.Windows.Forms.Label();
            this.colaPicture = new System.Windows.Forms.PictureBox();
            this.colaPriceLabel = new System.Windows.Forms.Label();
            this.colaQuantityLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.totalSalesLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lemonLimeQuantityLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lemonLimePicture = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.creamSodaQuantityLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.creamSodaPicture = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rootBeerQuantityLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.rootBearPicture = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.grapeSodaQuantityLabel = new System.Windows.Forms.Label();
            this.gradeSodaQuantityLabel = new System.Windows.Forms.Label();
            this.grapeSodaPicture = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.colaPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lemonLimePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creamSodaPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootBearPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grapeSodaPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ColaLabel
            // 
            this.ColaLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ColaLabel.Location = new System.Drawing.Point(26, 62);
            this.ColaLabel.Name = "ColaLabel";
            this.ColaLabel.Size = new System.Drawing.Size(265, 138);
            this.ColaLabel.TabIndex = 0;
            this.ColaLabel.Click += new System.EventHandler(this.ColaLabel_Click);
            // 
            // colaPicture
            // 
            this.colaPicture.Image = global::WootenT_DrinkMch.Properties.Resources.Cola;
            this.colaPicture.InitialImage = global::WootenT_DrinkMch.Properties.Resources.Cola;
            this.colaPicture.Location = new System.Drawing.Point(41, 74);
            this.colaPicture.Name = "colaPicture";
            this.colaPicture.Size = new System.Drawing.Size(109, 111);
            this.colaPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.colaPicture.TabIndex = 1;
            this.colaPicture.TabStop = false;
            this.colaPicture.Click += new System.EventHandler(this.colaPicture_Click);
            // 
            // colaPriceLabel
            // 
            this.colaPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colaPriceLabel.Location = new System.Drawing.Point(176, 74);
            this.colaPriceLabel.Name = "colaPriceLabel";
            this.colaPriceLabel.Size = new System.Drawing.Size(100, 34);
            this.colaPriceLabel.TabIndex = 2;
            this.colaPriceLabel.Text = "$1.00";
            this.colaPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colaQuantityLabel
            // 
            this.colaQuantityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colaQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colaQuantityLabel.Location = new System.Drawing.Point(175, 146);
            this.colaQuantityLabel.Name = "colaQuantityLabel";
            this.colaQuantityLabel.Size = new System.Drawing.Size(100, 34);
            this.colaQuantityLabel.TabIndex = 3;
            this.colaQuantityLabel.Text = "20";
            this.colaQuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.colaQuantityLabel.Click += new System.EventHandler(this.colaQuantityLabel_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Drinks Left: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(156, 11);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(274, 34);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Select a Drink";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalSalesLabel
            // 
            this.totalSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalSalesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSalesLabel.Location = new System.Drawing.Point(354, 452);
            this.totalSalesLabel.Name = "totalSalesLabel";
            this.totalSalesLabel.Size = new System.Drawing.Size(170, 34);
            this.totalSalesLabel.TabIndex = 9;
            this.totalSalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalSalesLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(353, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 34);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Sales";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(302, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 138);
            this.label5.TabIndex = 6;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(219, 540);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(137, 39);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 34);
            this.label2.TabIndex = 15;
            this.label2.Text = "Drinks Left: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lemonLimeQuantityLabel
            // 
            this.lemonLimeQuantityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lemonLimeQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lemonLimeQuantityLabel.Location = new System.Drawing.Point(175, 298);
            this.lemonLimeQuantityLabel.Name = "lemonLimeQuantityLabel";
            this.lemonLimeQuantityLabel.Size = new System.Drawing.Size(100, 34);
            this.lemonLimeQuantityLabel.TabIndex = 14;
            this.lemonLimeQuantityLabel.Text = "20";
            this.lemonLimeQuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(176, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 34);
            this.label6.TabIndex = 13;
            this.label6.Text = "$1.00";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lemonLimePicture
            // 
            this.lemonLimePicture.Image = global::WootenT_DrinkMch.Properties.Resources.LemonLime;
            this.lemonLimePicture.InitialImage = null;
            this.lemonLimePicture.Location = new System.Drawing.Point(41, 226);
            this.lemonLimePicture.Name = "lemonLimePicture";
            this.lemonLimePicture.Size = new System.Drawing.Size(109, 111);
            this.lemonLimePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lemonLimePicture.TabIndex = 12;
            this.lemonLimePicture.TabStop = false;
            this.lemonLimePicture.Click += new System.EventHandler(this.lemonLimePicture_Click);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(26, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(265, 138);
            this.label7.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 34);
            this.label3.TabIndex = 20;
            this.label3.Text = "Drinks Left: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // creamSodaQuantityLabel
            // 
            this.creamSodaQuantityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.creamSodaQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creamSodaQuantityLabel.Location = new System.Drawing.Point(175, 452);
            this.creamSodaQuantityLabel.Name = "creamSodaQuantityLabel";
            this.creamSodaQuantityLabel.Size = new System.Drawing.Size(100, 34);
            this.creamSodaQuantityLabel.TabIndex = 19;
            this.creamSodaQuantityLabel.Text = "20";
            this.creamSodaQuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(176, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 34);
            this.label9.TabIndex = 18;
            this.label9.Text = "$1.50";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // creamSodaPicture
            // 
            this.creamSodaPicture.Image = global::WootenT_DrinkMch.Properties.Resources.CreamSoda;
            this.creamSodaPicture.InitialImage = null;
            this.creamSodaPicture.Location = new System.Drawing.Point(41, 380);
            this.creamSodaPicture.Name = "creamSodaPicture";
            this.creamSodaPicture.Size = new System.Drawing.Size(109, 111);
            this.creamSodaPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.creamSodaPicture.TabIndex = 17;
            this.creamSodaPicture.TabStop = false;
            this.creamSodaPicture.Click += new System.EventHandler(this.creamSodaPicture_Click);
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(26, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(265, 138);
            this.label10.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(446, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 34);
            this.label8.TabIndex = 25;
            this.label8.Text = "Drinks Left: ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rootBeerQuantityLabel
            // 
            this.rootBeerQuantityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rootBeerQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rootBeerQuantityLabel.Location = new System.Drawing.Point(451, 146);
            this.rootBeerQuantityLabel.Name = "rootBeerQuantityLabel";
            this.rootBeerQuantityLabel.Size = new System.Drawing.Size(100, 34);
            this.rootBeerQuantityLabel.TabIndex = 24;
            this.rootBeerQuantityLabel.Text = "20";
            this.rootBeerQuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(452, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 34);
            this.label12.TabIndex = 23;
            this.label12.Text = "$1.00";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rootBearPicture
            // 
            this.rootBearPicture.Image = global::WootenT_DrinkMch.Properties.Resources.RootBeer;
            this.rootBearPicture.InitialImage = global::WootenT_DrinkMch.Properties.Resources.Cola;
            this.rootBearPicture.Location = new System.Drawing.Point(317, 74);
            this.rootBearPicture.Name = "rootBearPicture";
            this.rootBearPicture.Size = new System.Drawing.Size(109, 111);
            this.rootBearPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rootBearPicture.TabIndex = 22;
            this.rootBearPicture.TabStop = false;
            this.rootBearPicture.Click += new System.EventHandler(this.rootBearPicture_Click);
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(302, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(265, 138);
            this.label13.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(446, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 34);
            this.label11.TabIndex = 30;
            this.label11.Text = "Drinks Left: ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grapeSodaQuantityLabel
            // 
            this.grapeSodaQuantityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grapeSodaQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grapeSodaQuantityLabel.Location = new System.Drawing.Point(451, 298);
            this.grapeSodaQuantityLabel.Name = "grapeSodaQuantityLabel";
            this.grapeSodaQuantityLabel.Size = new System.Drawing.Size(100, 34);
            this.grapeSodaQuantityLabel.TabIndex = 29;
            this.grapeSodaQuantityLabel.Text = "20";
            this.grapeSodaQuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradeSodaQuantityLabel
            // 
            this.gradeSodaQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeSodaQuantityLabel.Location = new System.Drawing.Point(452, 226);
            this.gradeSodaQuantityLabel.Name = "gradeSodaQuantityLabel";
            this.gradeSodaQuantityLabel.Size = new System.Drawing.Size(100, 34);
            this.gradeSodaQuantityLabel.TabIndex = 28;
            this.gradeSodaQuantityLabel.Text = "$1.50";
            this.gradeSodaQuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grapeSodaPicture
            // 
            this.grapeSodaPicture.Image = global::WootenT_DrinkMch.Properties.Resources.GrapeSoda;
            this.grapeSodaPicture.InitialImage = global::WootenT_DrinkMch.Properties.Resources.Cola;
            this.grapeSodaPicture.Location = new System.Drawing.Point(317, 226);
            this.grapeSodaPicture.Name = "grapeSodaPicture";
            this.grapeSodaPicture.Size = new System.Drawing.Size(109, 111);
            this.grapeSodaPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.grapeSodaPicture.TabIndex = 27;
            this.grapeSodaPicture.TabStop = false;
            this.grapeSodaPicture.Click += new System.EventHandler(this.grapeSodaPicture_Click);
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Location = new System.Drawing.Point(302, 214);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(265, 138);
            this.label16.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(585, 593);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.grapeSodaQuantityLabel);
            this.Controls.Add(this.gradeSodaQuantityLabel);
            this.Controls.Add(this.grapeSodaPicture);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rootBeerQuantityLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.rootBearPicture);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.creamSodaQuantityLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.creamSodaPicture);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lemonLimeQuantityLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lemonLimePicture);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.totalSalesLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colaQuantityLabel);
            this.Controls.Add(this.colaPriceLabel);
            this.Controls.Add(this.colaPicture);
            this.Controls.Add(this.ColaLabel);
            this.Name = "Form1";
            this.Text = "Drink Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.colaPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lemonLimePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creamSodaPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootBearPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grapeSodaPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ColaLabel;
        private System.Windows.Forms.PictureBox colaPicture;
        private System.Windows.Forms.Label colaPriceLabel;
        private System.Windows.Forms.Label colaQuantityLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label totalSalesLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lemonLimeQuantityLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox lemonLimePicture;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label creamSodaQuantityLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox creamSodaPicture;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label rootBeerQuantityLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox rootBearPicture;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label grapeSodaQuantityLabel;
        private System.Windows.Forms.Label gradeSodaQuantityLabel;
        private System.Windows.Forms.PictureBox grapeSodaPicture;
        private System.Windows.Forms.Label label16;
    }
}

