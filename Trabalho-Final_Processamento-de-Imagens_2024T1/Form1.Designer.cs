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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.Tx_Resolution1 = new System.Windows.Forms.Label();
            this.Image_Frame_2 = new System.Windows.Forms.GroupBox();
            this.Tx_Resolution2 = new System.Windows.Forms.Label();
            this.Image_Frame_3 = new System.Windows.Forms.GroupBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.Tx_Resolution3 = new System.Windows.Forms.Label();
            this.btFlip90R = new System.Windows.Forms.Button();
            this.btSwitch3to1 = new System.Windows.Forms.Button();
            this.btFlip90L = new System.Windows.Forms.Button();
            this.btOverlay = new System.Windows.Forms.Button();
            this.btFlipR = new System.Windows.Forms.Button();
            this.btFlipUpDown = new System.Windows.Forms.Button();
            this.btGray = new System.Windows.Forms.Button();
            this.bt_Difference = new System.Windows.Forms.Button();
            this.btN = new System.Windows.Forms.Button();
            this.Blend_Mult = new System.Windows.Forms.NumericUpDown();
            this.btBlend = new System.Windows.Forms.Button();
            this.btAverage = new System.Windows.Forms.Button();
            this.btAnd = new System.Windows.Forms.Button();
            this.btOR = new System.Windows.Forms.Button();
            this.btNot = new System.Windows.Forms.Button();
            this.btXor = new System.Windows.Forms.Button();
            this.btBin = new System.Windows.Forms.Button();
            this.btSwap = new System.Windows.Forms.Button();
            this.btEqualize = new System.Windows.Forms.Button();
            this.chHistogram1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chHistogram2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btMAX = new System.Windows.Forms.Button();
            this.btMIN = new System.Windows.Forms.Button();
            this.btMean = new System.Windows.Forms.Button();
            this.btMedian = new System.Windows.Forms.Button();
            this.brOrder = new System.Windows.Forms.Button();
            this.nudOrder = new System.Windows.Forms.NumericUpDown();
            this.btSmooth = new System.Windows.Forms.Button();
            this.cbPadding = new System.Windows.Forms.ComboBox();
            this.btPadding = new System.Windows.Forms.Button();
            this.btPrewitt = new System.Windows.Forms.Button();
            this.btSobel = new System.Windows.Forms.Button();
            this.btLaplace1 = new System.Windows.Forms.Button();
            this.btLaplace2 = new System.Windows.Forms.Button();
            this.btDilatation = new System.Windows.Forms.Button();
            this.gbMorphologicalOperations = new System.Windows.Forms.GroupBox();
            this.btMorphologicalGradient = new System.Windows.Forms.Button();
            this.btExternalContour = new System.Windows.Forms.Button();
            this.btContour = new System.Windows.Forms.Button();
            this.btClosing = new System.Windows.Forms.Button();
            this.btOpening = new System.Windows.Forms.Button();
            this.btErosion = new System.Windows.Forms.Button();
            this.nudPadding = new System.Windows.Forms.NumericUpDown();
            this.gbOperationsBetweenImages = new System.Windows.Forms.GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.Blend_Mult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chHistogram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chHistogram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder)).BeginInit();
            this.gbMorphologicalOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPadding)).BeginInit();
            this.gbOperationsBetweenImages.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCarregarImagem
            // 
            this.btCarregarImagem.Location = new System.Drawing.Point(10, 201);
            this.btCarregarImagem.Name = "btCarregarImagem";
            this.btCarregarImagem.Size = new System.Drawing.Size(201, 37);
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
            this.pictureBox1.Location = new System.Drawing.Point(10, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.Location = new System.Drawing.Point(10, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(201, 163);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // btSalvarImagem
            // 
            this.btSalvarImagem.Location = new System.Drawing.Point(10, 201);
            this.btSalvarImagem.Name = "btSalvarImagem";
            this.btSalvarImagem.Size = new System.Drawing.Size(201, 37);
            this.btSalvarImagem.TabIndex = 3;
            this.btSalvarImagem.Text = "Salvar Imagem";
            this.btSalvarImagem.UseVisualStyleBackColor = true;
            this.btSalvarImagem.Click += new System.EventHandler(this.btSalvarImagem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Location = new System.Drawing.Point(10, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 163);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btCarregarImagem2
            // 
            this.btCarregarImagem2.Location = new System.Drawing.Point(10, 201);
            this.btCarregarImagem2.Name = "btCarregarImagem2";
            this.btCarregarImagem2.Size = new System.Drawing.Size(201, 37);
            this.btCarregarImagem2.TabIndex = 5;
            this.btCarregarImagem2.Text = "Carregar Imagem";
            this.btCarregarImagem2.UseVisualStyleBackColor = true;
            this.btCarregarImagem2.Click += new System.EventHandler(this.btCarregarImagem2_Click);
            // 
            // Add_Img
            // 
            this.Add_Img.Location = new System.Drawing.Point(6, 20);
            this.Add_Img.Name = "Add_Img";
            this.Add_Img.Size = new System.Drawing.Size(81, 29);
            this.Add_Img.TabIndex = 6;
            this.Add_Img.Text = "Somar Img";
            this.Add_Img.UseVisualStyleBackColor = true;
            this.Add_Img.Click += new System.EventHandler(this.Somar_Img_Click);
            // 
            // Sub_Img
            // 
            this.Sub_Img.Location = new System.Drawing.Point(108, 19);
            this.Sub_Img.Name = "Sub_Img";
            this.Sub_Img.Size = new System.Drawing.Size(86, 29);
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
            this.Image_Frame_1.Controls.Add(this.Tx_Resolution1);
            this.Image_Frame_1.Controls.Add(this.pictureBox1);
            this.Image_Frame_1.Controls.Add(this.btCarregarImagem);
            this.Image_Frame_1.Location = new System.Drawing.Point(6, 4);
            this.Image_Frame_1.Name = "Image_Frame_1";
            this.Image_Frame_1.Size = new System.Drawing.Size(221, 271);
            this.Image_Frame_1.TabIndex = 17;
            this.Image_Frame_1.TabStop = false;
            this.Image_Frame_1.Text = "Imagem1";
            // 
            // Tx_Resolution1
            // 
            this.Tx_Resolution1.AutoSize = true;
            this.Tx_Resolution1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Tx_Resolution1.Location = new System.Drawing.Point(3, 16);
            this.Tx_Resolution1.Name = "Tx_Resolution1";
            this.Tx_Resolution1.Size = new System.Drawing.Size(24, 13);
            this.Tx_Resolution1.TabIndex = 38;
            this.Tx_Resolution1.Text = "0x0";
            // 
            // Image_Frame_2
            // 
            this.Image_Frame_2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Image_Frame_2.Controls.Add(this.Tx_Resolution2);
            this.Image_Frame_2.Controls.Add(this.btCarregarImagem2);
            this.Image_Frame_2.Controls.Add(this.pictureBox2);
            this.Image_Frame_2.Location = new System.Drawing.Point(233, 4);
            this.Image_Frame_2.Name = "Image_Frame_2";
            this.Image_Frame_2.Size = new System.Drawing.Size(221, 271);
            this.Image_Frame_2.TabIndex = 18;
            this.Image_Frame_2.TabStop = false;
            this.Image_Frame_2.Text = "Imagem2";
            // 
            // Tx_Resolution2
            // 
            this.Tx_Resolution2.AutoSize = true;
            this.Tx_Resolution2.Dock = System.Windows.Forms.DockStyle.Left;
            this.Tx_Resolution2.Location = new System.Drawing.Point(3, 16);
            this.Tx_Resolution2.Name = "Tx_Resolution2";
            this.Tx_Resolution2.Size = new System.Drawing.Size(24, 13);
            this.Tx_Resolution2.TabIndex = 39;
            this.Tx_Resolution2.Text = "0x0";
            // 
            // Image_Frame_3
            // 
            this.Image_Frame_3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Image_Frame_3.Controls.Add(this.btDelete);
            this.Image_Frame_3.Controls.Add(this.Tx_Resolution3);
            this.Image_Frame_3.Controls.Add(this.btSalvarImagem);
            this.Image_Frame_3.Controls.Add(this.pictureBox3);
            this.Image_Frame_3.Controls.Add(this.btFlip90R);
            this.Image_Frame_3.Controls.Add(this.btSwitch3to1);
            this.Image_Frame_3.Controls.Add(this.btFlip90L);
            this.Image_Frame_3.Location = new System.Drawing.Point(974, 4);
            this.Image_Frame_3.Name = "Image_Frame_3";
            this.Image_Frame_3.Size = new System.Drawing.Size(221, 271);
            this.Image_Frame_3.TabIndex = 19;
            this.Image_Frame_3.TabStop = false;
            this.Image_Frame_3.Text = "Imagem 3";
            // 
            // btDelete
            // 
            this.btDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDelete.BackgroundImage")));
            this.btDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDelete.Location = new System.Drawing.Point(184, 240);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(32, 28);
            this.btDelete.TabIndex = 41;
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // Tx_Resolution3
            // 
            this.Tx_Resolution3.AutoSize = true;
            this.Tx_Resolution3.Dock = System.Windows.Forms.DockStyle.Left;
            this.Tx_Resolution3.Location = new System.Drawing.Point(3, 16);
            this.Tx_Resolution3.Name = "Tx_Resolution3";
            this.Tx_Resolution3.Size = new System.Drawing.Size(24, 13);
            this.Tx_Resolution3.TabIndex = 40;
            this.Tx_Resolution3.Text = "0x0";
            // 
            // btFlip90R
            // 
            this.btFlip90R.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btFlip90R.BackgroundImage")));
            this.btFlip90R.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btFlip90R.Location = new System.Drawing.Point(67, 240);
            this.btFlip90R.Name = "btFlip90R";
            this.btFlip90R.Size = new System.Drawing.Size(25, 25);
            this.btFlip90R.TabIndex = 35;
            this.btFlip90R.UseVisualStyleBackColor = true;
            this.btFlip90R.Click += new System.EventHandler(this.btFlip_90_R_Click);
            // 
            // btSwitch3to1
            // 
            this.btSwitch3to1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSwitch3to1.BackgroundImage")));
            this.btSwitch3to1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSwitch3to1.Location = new System.Drawing.Point(98, 240);
            this.btSwitch3to1.Name = "btSwitch3to1";
            this.btSwitch3to1.Size = new System.Drawing.Size(25, 25);
            this.btSwitch3to1.TabIndex = 37;
            this.btSwitch3to1.UseVisualStyleBackColor = true;
            this.btSwitch3to1.Click += new System.EventHandler(this.btSwitch3to1_Click);
            // 
            // btFlip90L
            // 
            this.btFlip90L.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btFlip90L.BackgroundImage")));
            this.btFlip90L.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btFlip90L.Location = new System.Drawing.Point(129, 240);
            this.btFlip90L.Name = "btFlip90L";
            this.btFlip90L.Size = new System.Drawing.Size(25, 25);
            this.btFlip90L.TabIndex = 36;
            this.btFlip90L.UseVisualStyleBackColor = true;
            this.btFlip90L.Click += new System.EventHandler(this.btFlip_90_L_Click);
            // 
            // btOverlay
            // 
            this.btOverlay.Location = new System.Drawing.Point(108, 54);
            this.btOverlay.Name = "btOverlay";
            this.btOverlay.Size = new System.Drawing.Size(73, 27);
            this.btOverlay.TabIndex = 20;
            this.btOverlay.Text = "Sobrepor";
            this.btOverlay.UseVisualStyleBackColor = true;
            this.btOverlay.Click += new System.EventHandler(this.btOverlay_Click);
            // 
            // btFlipR
            // 
            this.btFlipR.Location = new System.Drawing.Point(974, 301);
            this.btFlipR.Name = "btFlipR";
            this.btFlipR.Size = new System.Drawing.Size(106, 37);
            this.btFlipR.TabIndex = 21;
            this.btFlipR.Text = "Espelhar";
            this.btFlipR.UseVisualStyleBackColor = true;
            this.btFlipR.Click += new System.EventHandler(this.btFlip_Horizontal_Click);
            // 
            // btFlipUpDown
            // 
            this.btFlipUpDown.Location = new System.Drawing.Point(974, 344);
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
            // bt_Difference
            // 
            this.bt_Difference.Location = new System.Drawing.Point(12, 55);
            this.bt_Difference.Name = "bt_Difference";
            this.bt_Difference.Size = new System.Drawing.Size(75, 30);
            this.bt_Difference.TabIndex = 24;
            this.bt_Difference.Text = "Diferença";
            this.bt_Difference.UseVisualStyleBackColor = true;
            this.bt_Difference.Click += new System.EventHandler(this.bt_Difference_Click);
            // 
            // btN
            // 
            this.btN.Location = new System.Drawing.Point(1081, 301);
            this.btN.Name = "btN";
            this.btN.Size = new System.Drawing.Size(109, 37);
            this.btN.TabIndex = 25;
            this.btN.Text = "Negativo";
            this.btN.UseVisualStyleBackColor = true;
            this.btN.Click += new System.EventHandler(this.btN_Click);
            // 
            // Blend_Mult
            // 
            this.Blend_Mult.DecimalPlaces = 2;
            this.Blend_Mult.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.Blend_Mult.Location = new System.Drawing.Point(113, 91);
            this.Blend_Mult.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Blend_Mult.Name = "Blend_Mult";
            this.Blend_Mult.Size = new System.Drawing.Size(68, 20);
            this.Blend_Mult.TabIndex = 26;
            this.Blend_Mult.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btBlend
            // 
            this.btBlend.Location = new System.Drawing.Point(12, 91);
            this.btBlend.Name = "btBlend";
            this.btBlend.Size = new System.Drawing.Size(63, 30);
            this.btBlend.TabIndex = 27;
            this.btBlend.Text = "Misturar";
            this.btBlend.UseVisualStyleBackColor = true;
            this.btBlend.Click += new System.EventHandler(this.btBlend_Click);
            // 
            // btAverage
            // 
            this.btAverage.Location = new System.Drawing.Point(91, 114);
            this.btAverage.Name = "btAverage";
            this.btAverage.Size = new System.Drawing.Size(90, 23);
            this.btAverage.TabIndex = 28;
            this.btAverage.Text = "Media";
            this.btAverage.UseVisualStyleBackColor = true;
            this.btAverage.Click += new System.EventHandler(this.btAverage_Click);
            // 
            // btAnd
            // 
            this.btAnd.Location = new System.Drawing.Point(658, 396);
            this.btAnd.Name = "btAnd";
            this.btAnd.Size = new System.Drawing.Size(44, 23);
            this.btAnd.TabIndex = 29;
            this.btAnd.Text = "AND";
            this.btAnd.UseVisualStyleBackColor = true;
            this.btAnd.Click += new System.EventHandler(this.btAnd_Click);
            // 
            // btOR
            // 
            this.btOR.Location = new System.Drawing.Point(708, 396);
            this.btOR.Name = "btOR";
            this.btOR.Size = new System.Drawing.Size(44, 23);
            this.btOR.TabIndex = 30;
            this.btOR.Text = "OR";
            this.btOR.UseVisualStyleBackColor = true;
            this.btOR.Click += new System.EventHandler(this.btOR_Click);
            // 
            // btNot
            // 
            this.btNot.Location = new System.Drawing.Point(658, 425);
            this.btNot.Name = "btNot";
            this.btNot.Size = new System.Drawing.Size(44, 23);
            this.btNot.TabIndex = 31;
            this.btNot.Text = "NOT";
            this.btNot.UseVisualStyleBackColor = true;
            this.btNot.Click += new System.EventHandler(this.btNot_Click);
            // 
            // btXor
            // 
            this.btXor.Location = new System.Drawing.Point(708, 425);
            this.btXor.Name = "btXor";
            this.btXor.Size = new System.Drawing.Size(44, 23);
            this.btXor.TabIndex = 32;
            this.btXor.Text = "XOR";
            this.btXor.UseVisualStyleBackColor = true;
            this.btXor.Click += new System.EventHandler(this.btXor_Click);
            // 
            // btBin
            // 
            this.btBin.Location = new System.Drawing.Point(479, 439);
            this.btBin.Name = "btBin";
            this.btBin.Size = new System.Drawing.Size(163, 37);
            this.btBin.TabIndex = 33;
            this.btBin.Text = "limiarizar";
            this.btBin.UseVisualStyleBackColor = true;
            this.btBin.Click += new System.EventHandler(this.btBin_Click);
            // 
            // btSwap
            // 
            this.btSwap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSwap.BackgroundImage")));
            this.btSwap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSwap.Location = new System.Drawing.Point(219, 248);
            this.btSwap.Name = "btSwap";
            this.btSwap.Size = new System.Drawing.Size(21, 21);
            this.btSwap.TabIndex = 34;
            this.btSwap.UseVisualStyleBackColor = true;
            this.btSwap.Click += new System.EventHandler(this.btSwap_Click);
            // 
            // btEqualize
            // 
            this.btEqualize.Location = new System.Drawing.Point(479, 306);
            this.btEqualize.Name = "btEqualize";
            this.btEqualize.Size = new System.Drawing.Size(163, 37);
            this.btEqualize.TabIndex = 38;
            this.btEqualize.Text = "Equalizar";
            this.btEqualize.UseVisualStyleBackColor = true;
            this.btEqualize.Click += new System.EventHandler(this.btEqualize_Click);
            // 
            // chHistogram1
            // 
            chartArea5.Name = "ChartArea1";
            this.chHistogram1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chHistogram1.Legends.Add(legend5);
            this.chHistogram1.Location = new System.Drawing.Point(6, 281);
            this.chHistogram1.Name = "chHistogram1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chHistogram1.Series.Add(series5);
            this.chHistogram1.Size = new System.Drawing.Size(448, 127);
            this.chHistogram1.TabIndex = 39;
            this.chHistogram1.Text = "chart1";
            // 
            // chHistogram2
            // 
            chartArea6.Name = "ChartArea1";
            this.chHistogram2.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chHistogram2.Legends.Add(legend6);
            this.chHistogram2.Location = new System.Drawing.Point(6, 410);
            this.chHistogram2.Name = "chHistogram2";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chHistogram2.Series.Add(series6);
            this.chHistogram2.Size = new System.Drawing.Size(448, 127);
            this.chHistogram2.TabIndex = 40;
            this.chHistogram2.Text = "chart2";
            // 
            // btMAX
            // 
            this.btMAX.Location = new System.Drawing.Point(658, 147);
            this.btMAX.Name = "btMAX";
            this.btMAX.Size = new System.Drawing.Size(44, 23);
            this.btMAX.TabIndex = 41;
            this.btMAX.Text = "Max";
            this.btMAX.UseVisualStyleBackColor = true;
            this.btMAX.Click += new System.EventHandler(this.btMAX_Click);
            // 
            // btMIN
            // 
            this.btMIN.Location = new System.Drawing.Point(708, 147);
            this.btMIN.Name = "btMIN";
            this.btMIN.Size = new System.Drawing.Size(44, 23);
            this.btMIN.TabIndex = 42;
            this.btMIN.Text = "Min";
            this.btMIN.UseVisualStyleBackColor = true;
            this.btMIN.Click += new System.EventHandler(this.btMIN_Click);
            // 
            // btMean
            // 
            this.btMean.Location = new System.Drawing.Point(658, 176);
            this.btMean.Name = "btMean";
            this.btMean.Size = new System.Drawing.Size(44, 23);
            this.btMean.TabIndex = 43;
            this.btMean.Text = "Mean";
            this.btMean.UseVisualStyleBackColor = true;
            this.btMean.Click += new System.EventHandler(this.btMean_Click);
            // 
            // btMedian
            // 
            this.btMedian.Location = new System.Drawing.Point(658, 205);
            this.btMedian.Name = "btMedian";
            this.btMedian.Size = new System.Drawing.Size(94, 23);
            this.btMedian.TabIndex = 44;
            this.btMedian.Text = "Mediana";
            this.btMedian.UseVisualStyleBackColor = true;
            this.btMedian.Click += new System.EventHandler(this.btMedian_Click);
            // 
            // brOrder
            // 
            this.brOrder.Location = new System.Drawing.Point(658, 234);
            this.brOrder.Name = "brOrder";
            this.brOrder.Size = new System.Drawing.Size(94, 23);
            this.brOrder.TabIndex = 45;
            this.brOrder.Text = "Ordem";
            this.brOrder.UseVisualStyleBackColor = true;
            this.brOrder.Click += new System.EventHandler(this.brOrder_Click);
            // 
            // nudOrder
            // 
            this.nudOrder.Location = new System.Drawing.Point(767, 234);
            this.nudOrder.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudOrder.Name = "nudOrder";
            this.nudOrder.Size = new System.Drawing.Size(33, 20);
            this.nudOrder.TabIndex = 46;
            this.nudOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btSmooth
            // 
            this.btSmooth.Location = new System.Drawing.Point(658, 263);
            this.btSmooth.Name = "btSmooth";
            this.btSmooth.Size = new System.Drawing.Size(94, 23);
            this.btSmooth.TabIndex = 47;
            this.btSmooth.Text = "Suavização";
            this.btSmooth.UseVisualStyleBackColor = true;
            this.btSmooth.Click += new System.EventHandler(this.btSmooth_Click);
            // 
            // cbPadding
            // 
            this.cbPadding.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPadding.FormattingEnabled = true;
            this.cbPadding.Items.AddRange(new object[] {
            "Zero",
            "Replicate",
            "Reflect",
            "Mirror",
            "Wrap"});
            this.cbPadding.Location = new System.Drawing.Point(584, 482);
            this.cbPadding.Name = "cbPadding";
            this.cbPadding.Size = new System.Drawing.Size(58, 21);
            this.cbPadding.TabIndex = 48;
            // 
            // btPadding
            // 
            this.btPadding.Location = new System.Drawing.Point(479, 480);
            this.btPadding.Name = "btPadding";
            this.btPadding.Size = new System.Drawing.Size(99, 23);
            this.btPadding.TabIndex = 49;
            this.btPadding.Text = "Preenchimento";
            this.btPadding.UseVisualStyleBackColor = true;
            this.btPadding.Click += new System.EventHandler(this.btPadding_Click);
            // 
            // btPrewitt
            // 
            this.btPrewitt.Location = new System.Drawing.Point(786, 470);
            this.btPrewitt.Name = "btPrewitt";
            this.btPrewitt.Size = new System.Drawing.Size(94, 23);
            this.btPrewitt.TabIndex = 50;
            this.btPrewitt.Text = "Prewitt";
            this.btPrewitt.UseVisualStyleBackColor = true;
            this.btPrewitt.Click += new System.EventHandler(this.btPrewitt_Click);
            // 
            // btSobel
            // 
            this.btSobel.Location = new System.Drawing.Point(786, 499);
            this.btSobel.Name = "btSobel";
            this.btSobel.Size = new System.Drawing.Size(94, 23);
            this.btSobel.TabIndex = 51;
            this.btSobel.Text = "Sobel";
            this.btSobel.UseVisualStyleBackColor = true;
            this.btSobel.Click += new System.EventHandler(this.btSobel_Click);
            // 
            // btLaplace1
            // 
            this.btLaplace1.Location = new System.Drawing.Point(886, 470);
            this.btLaplace1.Name = "btLaplace1";
            this.btLaplace1.Size = new System.Drawing.Size(94, 23);
            this.btLaplace1.TabIndex = 52;
            this.btLaplace1.Text = "Laplace1";
            this.btLaplace1.UseVisualStyleBackColor = true;
            this.btLaplace1.Click += new System.EventHandler(this.btLaplace1_Click);
            // 
            // btLaplace2
            // 
            this.btLaplace2.Location = new System.Drawing.Point(886, 499);
            this.btLaplace2.Name = "btLaplace2";
            this.btLaplace2.Size = new System.Drawing.Size(94, 23);
            this.btLaplace2.TabIndex = 53;
            this.btLaplace2.Text = "Laplace2";
            this.btLaplace2.UseVisualStyleBackColor = true;
            this.btLaplace2.Click += new System.EventHandler(this.btLaplace2_Click);
            // 
            // btDilatation
            // 
            this.btDilatation.Location = new System.Drawing.Point(0, 19);
            this.btDilatation.Name = "btDilatation";
            this.btDilatation.Size = new System.Drawing.Size(100, 23);
            this.btDilatation.TabIndex = 54;
            this.btDilatation.Text = "Dilatação";
            this.btDilatation.UseVisualStyleBackColor = true;
            this.btDilatation.Click += new System.EventHandler(this.btDilatation_Click);
            // 
            // gbMorphologicalOperations
            // 
            this.gbMorphologicalOperations.Controls.Add(this.btMorphologicalGradient);
            this.gbMorphologicalOperations.Controls.Add(this.btExternalContour);
            this.gbMorphologicalOperations.Controls.Add(this.btContour);
            this.gbMorphologicalOperations.Controls.Add(this.btClosing);
            this.gbMorphologicalOperations.Controls.Add(this.btOpening);
            this.gbMorphologicalOperations.Controls.Add(this.btErosion);
            this.gbMorphologicalOperations.Controls.Add(this.btDilatation);
            this.gbMorphologicalOperations.Location = new System.Drawing.Point(990, 410);
            this.gbMorphologicalOperations.Name = "gbMorphologicalOperations";
            this.gbMorphologicalOperations.Size = new System.Drawing.Size(200, 127);
            this.gbMorphologicalOperations.TabIndex = 55;
            this.gbMorphologicalOperations.TabStop = false;
            this.gbMorphologicalOperations.Text = "Operações Morfológicas";
            // 
            // btMorphologicalGradient
            // 
            this.btMorphologicalGradient.Location = new System.Drawing.Point(46, 105);
            this.btMorphologicalGradient.Name = "btMorphologicalGradient";
            this.btMorphologicalGradient.Size = new System.Drawing.Size(100, 23);
            this.btMorphologicalGradient.TabIndex = 60;
            this.btMorphologicalGradient.Text = "Gradiente morfológico";
            this.btMorphologicalGradient.UseVisualStyleBackColor = true;
            this.btMorphologicalGradient.Click += new System.EventHandler(this.btMorphologicalGradient_Click);
            // 
            // btExternalContour
            // 
            this.btExternalContour.Location = new System.Drawing.Point(100, 76);
            this.btExternalContour.Name = "btExternalContour";
            this.btExternalContour.Size = new System.Drawing.Size(100, 23);
            this.btExternalContour.TabIndex = 59;
            this.btExternalContour.Text = "Contorno externo";
            this.btExternalContour.UseVisualStyleBackColor = true;
            this.btExternalContour.Click += new System.EventHandler(this.btExternalContour_Click);
            // 
            // btContour
            // 
            this.btContour.Location = new System.Drawing.Point(0, 76);
            this.btContour.Name = "btContour";
            this.btContour.Size = new System.Drawing.Size(100, 23);
            this.btContour.TabIndex = 58;
            this.btContour.Text = "Contorno";
            this.btContour.UseVisualStyleBackColor = true;
            this.btContour.Click += new System.EventHandler(this.btContour_Click);
            // 
            // btClosing
            // 
            this.btClosing.Location = new System.Drawing.Point(100, 47);
            this.btClosing.Name = "btClosing";
            this.btClosing.Size = new System.Drawing.Size(100, 23);
            this.btClosing.TabIndex = 57;
            this.btClosing.Text = "Fechamento";
            this.btClosing.UseVisualStyleBackColor = true;
            this.btClosing.Click += new System.EventHandler(this.btClosing_Click);
            // 
            // btOpening
            // 
            this.btOpening.Location = new System.Drawing.Point(0, 47);
            this.btOpening.Name = "btOpening";
            this.btOpening.Size = new System.Drawing.Size(100, 23);
            this.btOpening.TabIndex = 56;
            this.btOpening.Text = "Abertura";
            this.btOpening.UseVisualStyleBackColor = true;
            this.btOpening.Click += new System.EventHandler(this.btOpening_Click);
            // 
            // btErosion
            // 
            this.btErosion.Location = new System.Drawing.Point(100, 19);
            this.btErosion.Name = "btErosion";
            this.btErosion.Size = new System.Drawing.Size(100, 23);
            this.btErosion.TabIndex = 55;
            this.btErosion.Text = "Erosão";
            this.btErosion.UseVisualStyleBackColor = true;
            this.btErosion.Click += new System.EventHandler(this.btErosion_Click);
            // 
            // nudPadding
            // 
            this.nudPadding.Location = new System.Drawing.Point(479, 509);
            this.nudPadding.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudPadding.Name = "nudPadding";
            this.nudPadding.Size = new System.Drawing.Size(33, 20);
            this.nudPadding.TabIndex = 56;
            this.nudPadding.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gbOperationsBetweenImages
            // 
            this.gbOperationsBetweenImages.Controls.Add(this.btOverlay);
            this.gbOperationsBetweenImages.Controls.Add(this.Sub_Img);
            this.gbOperationsBetweenImages.Controls.Add(this.Add_Img);
            this.gbOperationsBetweenImages.Controls.Add(this.bt_Difference);
            this.gbOperationsBetweenImages.Controls.Add(this.btBlend);
            this.gbOperationsBetweenImages.Controls.Add(this.Blend_Mult);
            this.gbOperationsBetweenImages.Controls.Add(this.btAverage);
            this.gbOperationsBetweenImages.Location = new System.Drawing.Point(680, 4);
            this.gbOperationsBetweenImages.Name = "gbOperationsBetweenImages";
            this.gbOperationsBetweenImages.Size = new System.Drawing.Size(200, 137);
            this.gbOperationsBetweenImages.TabIndex = 57;
            this.gbOperationsBetweenImages.TabStop = false;
            this.gbOperationsBetweenImages.Text = "Operações entre duas imagens";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 549);
            this.Controls.Add(this.gbOperationsBetweenImages);
            this.Controls.Add(this.nudPadding);
            this.Controls.Add(this.gbMorphologicalOperations);
            this.Controls.Add(this.btSwap);
            this.Controls.Add(this.btLaplace2);
            this.Controls.Add(this.btLaplace1);
            this.Controls.Add(this.btSobel);
            this.Controls.Add(this.btPrewitt);
            this.Controls.Add(this.btPadding);
            this.Controls.Add(this.cbPadding);
            this.Controls.Add(this.btSmooth);
            this.Controls.Add(this.nudOrder);
            this.Controls.Add(this.brOrder);
            this.Controls.Add(this.btMedian);
            this.Controls.Add(this.btMean);
            this.Controls.Add(this.btMIN);
            this.Controls.Add(this.btMAX);
            this.Controls.Add(this.chHistogram2);
            this.Controls.Add(this.chHistogram1);
            this.Controls.Add(this.btEqualize);
            this.Controls.Add(this.btBin);
            this.Controls.Add(this.btXor);
            this.Controls.Add(this.btNot);
            this.Controls.Add(this.btOR);
            this.Controls.Add(this.btAnd);
            this.Controls.Add(this.btN);
            this.Controls.Add(this.btGray);
            this.Controls.Add(this.btFlipUpDown);
            this.Controls.Add(this.btFlipR);
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
            this.Image_Frame_1.PerformLayout();
            this.Image_Frame_2.ResumeLayout(false);
            this.Image_Frame_2.PerformLayout();
            this.Image_Frame_3.ResumeLayout(false);
            this.Image_Frame_3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Blend_Mult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chHistogram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chHistogram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder)).EndInit();
            this.gbMorphologicalOperations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPadding)).EndInit();
            this.gbOperationsBetweenImages.ResumeLayout(false);
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
        private System.Windows.Forms.Button btOverlay;
        private System.Windows.Forms.Button btFlipR;
        private System.Windows.Forms.Button btFlipUpDown;
        private System.Windows.Forms.Button btGray;
        private System.Windows.Forms.Button bt_Difference;
        private System.Windows.Forms.Button btN;
        private System.Windows.Forms.NumericUpDown Blend_Mult;
        private System.Windows.Forms.Button btBlend;
        private System.Windows.Forms.Button btAverage;
        private System.Windows.Forms.Button btAnd;
        private System.Windows.Forms.Button btOR;
        private System.Windows.Forms.Button btNot;
        private System.Windows.Forms.Button btXor;
        private System.Windows.Forms.Button btBin;
        private System.Windows.Forms.Button btSwap;
        private System.Windows.Forms.Button btFlip90R;
        private System.Windows.Forms.Button btFlip90L;
        private System.Windows.Forms.Button btSwitch3to1;
        private System.Windows.Forms.Label Tx_Resolution1;
        private System.Windows.Forms.Label Tx_Resolution2;
        private System.Windows.Forms.Label Tx_Resolution3;
        private System.Windows.Forms.Button btEqualize;
        private System.Windows.Forms.DataVisualization.Charting.Chart chHistogram1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chHistogram2;
        private System.Windows.Forms.Button btMAX;
        private System.Windows.Forms.Button btMIN;
        private System.Windows.Forms.Button btMean;
        private System.Windows.Forms.Button btMedian;
        private System.Windows.Forms.Button brOrder;
        private System.Windows.Forms.NumericUpDown nudOrder;
        private System.Windows.Forms.Button btSmooth;
        private System.Windows.Forms.ComboBox cbPadding;
        private System.Windows.Forms.Button btPadding;
        private System.Windows.Forms.Button btPrewitt;
        private System.Windows.Forms.Button btSobel;
        private System.Windows.Forms.Button btLaplace1;
        private System.Windows.Forms.Button btLaplace2;
        private System.Windows.Forms.Button btDilatation;
        private System.Windows.Forms.GroupBox gbMorphologicalOperations;
        private System.Windows.Forms.Button btErosion;
        private System.Windows.Forms.Button btMorphologicalGradient;
        private System.Windows.Forms.Button btExternalContour;
        private System.Windows.Forms.Button btContour;
        private System.Windows.Forms.Button btClosing;
        private System.Windows.Forms.Button btOpening;
        private System.Windows.Forms.NumericUpDown nudPadding;
        private System.Windows.Forms.GroupBox gbOperationsBetweenImages;
        private System.Windows.Forms.Button btDelete;
    }
}

