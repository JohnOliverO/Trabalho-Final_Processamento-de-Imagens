namespace ImageLoader
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
            this.btCarregarImagem = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btSalvarImagem = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btCarregarImagem2 = new System.Windows.Forms.Button();
            this.Add_Img = new System.Windows.Forms.Button();
            this.Sub_Img = new System.Windows.Forms.Button();
            this.Brightness_Mult = new System.Windows.Forms.NumericUpDown();
            this.bt_add_Brightness = new System.Windows.Forms.Button();
            this.bt_sub_Brightness = new System.Windows.Forms.Button();
            this.Brightness_Up = new System.Windows.Forms.NumericUpDown();
            this.bt_div_Brightness = new System.Windows.Forms.Button();
            this.bt_mult_Brightness = new System.Windows.Forms.Button();
            this.Brightness_Down = new System.Windows.Forms.NumericUpDown();
            this.Brightness_Div = new System.Windows.Forms.NumericUpDown();
            this.Image_Frame_1 = new System.Windows.Forms.GroupBox();
            this.Image_Frame_2 = new System.Windows.Forms.GroupBox();
            this.Image_Frame_3 = new System.Windows.Forms.GroupBox();
            this.Overlay_Img = new System.Windows.Forms.Button();
            this.btFlipR = new System.Windows.Forms.Button();
            this.btFlipUpDown = new System.Windows.Forms.Button();
            this.btGray = new System.Windows.Forms.Button();
            this.bt_Subt_2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brightness_Mult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brightness_Up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brightness_Down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brightness_Div)).BeginInit();
            this.Image_Frame_1.SuspendLayout();
            this.Image_Frame_2.SuspendLayout();
            this.Image_Frame_3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCarregarImagem
            // 
            this.btCarregarImagem.Location = new System.Drawing.Point(29, 187);
            this.btCarregarImagem.Name = "btCarregarImagem";
            this.btCarregarImagem.Size = new System.Drawing.Size(163, 37);
            this.btCarregarImagem.TabIndex = 0;
            this.btCarregarImagem.Text = "Carregar Imagem";
            this.btCarregarImagem.UseVisualStyleBackColor = true;
            this.btCarregarImagem.Click += new System.EventHandler(this.btCarregarImagem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(10, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.Location = new System.Drawing.Point(10, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(201, 163);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // btSalvarImagem
            // 
            this.btSalvarImagem.Location = new System.Drawing.Point(29, 187);
            this.btSalvarImagem.Name = "btSalvarImagem";
            this.btSalvarImagem.Size = new System.Drawing.Size(163, 37);
            this.btSalvarImagem.TabIndex = 3;
            this.btSalvarImagem.Text = "Salvar Imagem";
            this.btSalvarImagem.UseVisualStyleBackColor = true;
            this.btSalvarImagem.Click += new System.EventHandler(this.btSalvarImagem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Location = new System.Drawing.Point(10, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 163);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btCarregarImagem2
            // 
            this.btCarregarImagem2.Location = new System.Drawing.Point(29, 187);
            this.btCarregarImagem2.Name = "btCarregarImagem2";
            this.btCarregarImagem2.Size = new System.Drawing.Size(163, 37);
            this.btCarregarImagem2.TabIndex = 5;
            this.btCarregarImagem2.Text = "Carregar Imagem";
            this.btCarregarImagem2.UseVisualStyleBackColor = true;
            this.btCarregarImagem2.Click += new System.EventHandler(this.btCarregarImagem2_Click);
            // 
            // Add_Img
            // 
            this.Add_Img.Location = new System.Drawing.Point(479, 4);
            this.Add_Img.Name = "Add_Img";
            this.Add_Img.Size = new System.Drawing.Size(163, 37);
            this.Add_Img.TabIndex = 6;
            this.Add_Img.Text = "Somar Img";
            this.Add_Img.UseVisualStyleBackColor = true;
            this.Add_Img.Click += new System.EventHandler(this.Somar_Img_Click);
            // 
            // Sub_Img
            // 
            this.Sub_Img.Location = new System.Drawing.Point(479, 47);
            this.Sub_Img.Name = "Sub_Img";
            this.Sub_Img.Size = new System.Drawing.Size(163, 37);
            this.Sub_Img.TabIndex = 7;
            this.Sub_Img.Text = "Subtrair Img";
            this.Sub_Img.UseVisualStyleBackColor = true;
            this.Sub_Img.Click += new System.EventHandler(this.Subtrair_Img_Click);
            // 
            // Brightness_Mult
            // 
            this.Brightness_Mult.DecimalPlaces = 2;
            this.Brightness_Mult.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.Brightness_Mult.Location = new System.Drawing.Point(574, 186);
            this.Brightness_Mult.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Brightness_Mult.Name = "Brightness_Mult";
            this.Brightness_Mult.Size = new System.Drawing.Size(68, 20);
            this.Brightness_Mult.TabIndex = 9;
            this.Brightness_Mult.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Brightness_Mult.ValueChanged += new System.EventHandler(this.Brightness_Mult_ValueChanged);
            // 
            // bt_add_Brightness
            // 
            this.bt_add_Brightness.Location = new System.Drawing.Point(479, 90);
            this.bt_add_Brightness.Name = "bt_add_Brightness";
            this.bt_add_Brightness.Size = new System.Drawing.Size(81, 37);
            this.bt_add_Brightness.TabIndex = 10;
            this.bt_add_Brightness.Text = "Somar Brilho";
            this.bt_add_Brightness.UseVisualStyleBackColor = true;
            this.bt_add_Brightness.Click += new System.EventHandler(this.bt_add_Brightness_Click);
            // 
            // bt_sub_Brightness
            // 
            this.bt_sub_Brightness.Location = new System.Drawing.Point(479, 133);
            this.bt_sub_Brightness.Name = "bt_sub_Brightness";
            this.bt_sub_Brightness.Size = new System.Drawing.Size(81, 37);
            this.bt_sub_Brightness.TabIndex = 11;
            this.bt_sub_Brightness.Text = "Subtrair Brilho";
            this.bt_sub_Brightness.UseVisualStyleBackColor = true;
            this.bt_sub_Brightness.Click += new System.EventHandler(this.bt_sub_Brightness_Click);
            // 
            // Brightness_Up
            // 
            this.Brightness_Up.Location = new System.Drawing.Point(574, 100);
            this.Brightness_Up.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Brightness_Up.Name = "Brightness_Up";
            this.Brightness_Up.Size = new System.Drawing.Size(68, 20);
            this.Brightness_Up.TabIndex = 12;
            // 
            // bt_div_Brightness
            // 
            this.bt_div_Brightness.Location = new System.Drawing.Point(479, 220);
            this.bt_div_Brightness.Name = "bt_div_Brightness";
            this.bt_div_Brightness.Size = new System.Drawing.Size(81, 37);
            this.bt_div_Brightness.TabIndex = 14;
            this.bt_div_Brightness.Text = "Dividir Brilho";
            this.bt_div_Brightness.UseVisualStyleBackColor = true;
            this.bt_div_Brightness.Click += new System.EventHandler(this.bt_div_Brightness_Click);
            // 
            // bt_mult_Brightness
            // 
            this.bt_mult_Brightness.Location = new System.Drawing.Point(479, 176);
            this.bt_mult_Brightness.Name = "bt_mult_Brightness";
            this.bt_mult_Brightness.Size = new System.Drawing.Size(81, 37);
            this.bt_mult_Brightness.TabIndex = 13;
            this.bt_mult_Brightness.Text = "Multiplicar Brilho";
            this.bt_mult_Brightness.UseVisualStyleBackColor = true;
            this.bt_mult_Brightness.Click += new System.EventHandler(this.bt_mult_Brightness_Click);
            // 
            // Brightness_Down
            // 
            this.Brightness_Down.Location = new System.Drawing.Point(574, 143);
            this.Brightness_Down.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Brightness_Down.Name = "Brightness_Down";
            this.Brightness_Down.Size = new System.Drawing.Size(68, 20);
            this.Brightness_Down.TabIndex = 15;
            // 
            // Brightness_Div
            // 
            this.Brightness_Div.DecimalPlaces = 2;
            this.Brightness_Div.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.Brightness_Div.Location = new System.Drawing.Point(574, 230);
            this.Brightness_Div.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Brightness_Div.Name = "Brightness_Div";
            this.Brightness_Div.Size = new System.Drawing.Size(68, 20);
            this.Brightness_Div.TabIndex = 16;
            this.Brightness_Div.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Image_Frame_1
            // 
            this.Image_Frame_1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Image_Frame_1.Controls.Add(this.pictureBox1);
            this.Image_Frame_1.Controls.Add(this.btCarregarImagem);
            this.Image_Frame_1.Location = new System.Drawing.Point(6, 4);
            this.Image_Frame_1.Name = "Image_Frame_1";
            this.Image_Frame_1.Size = new System.Drawing.Size(221, 229);
            this.Image_Frame_1.TabIndex = 17;
            this.Image_Frame_1.TabStop = false;
            this.Image_Frame_1.Text = "Imagem 1";
            // 
            // Image_Frame_2
            // 
            this.Image_Frame_2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Image_Frame_2.Controls.Add(this.btCarregarImagem2);
            this.Image_Frame_2.Controls.Add(this.pictureBox2);
            this.Image_Frame_2.Location = new System.Drawing.Point(233, 4);
            this.Image_Frame_2.Name = "Image_Frame_2";
            this.Image_Frame_2.Size = new System.Drawing.Size(221, 229);
            this.Image_Frame_2.TabIndex = 18;
            this.Image_Frame_2.TabStop = false;
            this.Image_Frame_2.Text = "Imagem 2";
            // 
            // Image_Frame_3
            // 
            this.Image_Frame_3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Image_Frame_3.Controls.Add(this.btSalvarImagem);
            this.Image_Frame_3.Controls.Add(this.pictureBox3);
            this.Image_Frame_3.Location = new System.Drawing.Point(974, 4);
            this.Image_Frame_3.Name = "Image_Frame_3";
            this.Image_Frame_3.Size = new System.Drawing.Size(221, 229);
            this.Image_Frame_3.TabIndex = 19;
            this.Image_Frame_3.TabStop = false;
            this.Image_Frame_3.Text = "Imagem 3";
            this.Image_Frame_3.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Overlay_Img
            // 
            this.Overlay_Img.Location = new System.Drawing.Point(384, 439);
            this.Overlay_Img.Name = "Overlay_Img";
            this.Overlay_Img.Size = new System.Drawing.Size(163, 37);
            this.Overlay_Img.TabIndex = 20;
            this.Overlay_Img.Text = "Sobrepor";
            this.Overlay_Img.UseVisualStyleBackColor = true;
            this.Overlay_Img.Click += new System.EventHandler(this.bt_Overlay_Click);
            // 
            // btFlipR
            // 
            this.btFlipR.Location = new System.Drawing.Point(658, 4);
            this.btFlipR.Name = "btFlipR";
            this.btFlipR.Size = new System.Drawing.Size(106, 37);
            this.btFlipR.TabIndex = 21;
            this.btFlipR.Text = "Espelhar";
            this.btFlipR.UseVisualStyleBackColor = true;
            this.btFlipR.Click += new System.EventHandler(this.btFlipR_Click);
            // 
            // btFlipUpDown
            // 
            this.btFlipUpDown.Location = new System.Drawing.Point(658, 47);
            this.btFlipUpDown.Name = "btFlipUpDown";
            this.btFlipUpDown.Size = new System.Drawing.Size(106, 37);
            this.btFlipUpDown.TabIndex = 22;
            this.btFlipUpDown.Text = "Inverter";
            this.btFlipUpDown.UseVisualStyleBackColor = true;
            this.btFlipUpDown.Click += new System.EventHandler(this.btFlipUpDown_Click);
            // 
            // btGray
            // 
            this.btGray.Location = new System.Drawing.Point(479, 263);
            this.btGray.Name = "btGray";
            this.btGray.Size = new System.Drawing.Size(163, 37);
            this.btGray.TabIndex = 23;
            this.btGray.Text = "Escala de Cinza";
            this.btGray.UseVisualStyleBackColor = true;
            this.btGray.Click += new System.EventHandler(this.btGray_Click);
            // 
            // bt_Subt_2
            // 
            this.bt_Subt_2.Location = new System.Drawing.Point(658, 90);
            this.bt_Subt_2.Name = "bt_Subt_2";
            this.bt_Subt_2.Size = new System.Drawing.Size(106, 37);
            this.bt_Subt_2.TabIndex = 24;
            this.bt_Subt_2.Text = "Diferença";
            this.bt_Subt_2.UseVisualStyleBackColor = true;
            this.bt_Subt_2.Click += new System.EventHandler(this.bt_Subt_2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 501);
            this.Controls.Add(this.bt_Subt_2);
            this.Controls.Add(this.btGray);
            this.Controls.Add(this.btFlipUpDown);
            this.Controls.Add(this.btFlipR);
            this.Controls.Add(this.Overlay_Img);
            this.Controls.Add(this.Image_Frame_3);
            this.Controls.Add(this.Image_Frame_2);
            this.Controls.Add(this.Image_Frame_1);
            this.Controls.Add(this.Brightness_Div);
            this.Controls.Add(this.Brightness_Down);
            this.Controls.Add(this.bt_div_Brightness);
            this.Controls.Add(this.bt_mult_Brightness);
            this.Controls.Add(this.Brightness_Up);
            this.Controls.Add(this.bt_sub_Brightness);
            this.Controls.Add(this.bt_add_Brightness);
            this.Controls.Add(this.Brightness_Mult);
            this.Controls.Add(this.Sub_Img);
            this.Controls.Add(this.Add_Img);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brightness_Mult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brightness_Up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brightness_Down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brightness_Div)).EndInit();
            this.Image_Frame_1.ResumeLayout(false);
            this.Image_Frame_2.ResumeLayout(false);
            this.Image_Frame_3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCarregarImagem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btSalvarImagem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btCarregarImagem2;
        private System.Windows.Forms.Button Add_Img;
        private System.Windows.Forms.Button Sub_Img;
        private System.Windows.Forms.NumericUpDown Brightness_Mult;
        private System.Windows.Forms.Button bt_add_Brightness;
        private System.Windows.Forms.Button bt_sub_Brightness;
        private System.Windows.Forms.NumericUpDown Brightness_Up;
        private System.Windows.Forms.Button bt_div_Brightness;
        private System.Windows.Forms.Button bt_mult_Brightness;
        private System.Windows.Forms.NumericUpDown Brightness_Down;
        private System.Windows.Forms.NumericUpDown Brightness_Div;
        private System.Windows.Forms.GroupBox Image_Frame_1;
        private System.Windows.Forms.GroupBox Image_Frame_2;
        private System.Windows.Forms.GroupBox Image_Frame_3;
        private System.Windows.Forms.Button Overlay_Img;
        private System.Windows.Forms.Button btFlipR;
        private System.Windows.Forms.Button btFlipUpDown;
        private System.Windows.Forms.Button btGray;
        private System.Windows.Forms.Button bt_Subt_2;
    }
}

