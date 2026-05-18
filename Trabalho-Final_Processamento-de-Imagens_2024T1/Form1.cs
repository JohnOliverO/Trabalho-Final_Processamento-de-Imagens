using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageLoader
{
    public partial class Form1 : Form
    {

        Bitmap img1;
        Bitmap img2;
        Bitmap img3;
        Bitmap img4;
        Bitmap img5;
        byte[,] vImg1Gray;

        byte[,] vImg1R;
        byte[,] vImg1G;
        byte[,] vImg1B;
        byte[,] vImg1A;

        public Form1()
        {
            InitializeComponent();
        }
        /*
        private void btCarregarImagem_Click(object sender, EventArgs e)
        {
            // Configurações iniciais da OpenFileDialogBox
            var filePath = string.Empty;
            openFileDialog1.InitialDirectory = "C:\\Matlab";
            openFileDialog1.Filter = "TIFF image (*.tif)|*.tif|JPG image (*.jpg)|*.jpg|BMP image (*.bmp)|*.bmp|PNG image (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            // Se um arquivo foi localizado com sucesso...
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Armnazena o path do arquivo de imagem
                filePath = openFileDialog1.FileName;


                bool bLoadImgOK = false;
                try
                {
                    img1 = new Bitmap(filePath);
                    img2 = new Bitmap(img1.Width, img1.Height);
                    bLoadImgOK = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao abrir imagem...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bLoadImgOK = false;
                }

                // Se a imagem carregou perfeitamente...
                if (bLoadImgOK == true)
                {
                    // Adiciona imagem na PictureBox
                    pictureBox1.Image = img1;
                    vImg1Gray = new byte[img1.Width, img1.Height];
                    vImg1R = new byte[img1.Width, img1.Height];
                    vImg1G = new byte[img1.Width, img1.Height];
                    vImg1B = new byte[img1.Width, img1.Height];
                    vImg1A = new byte[img1.Width, img1.Height];

                    // Percorre todos os pixels da imagem...
                    for (int i = 0; i < img1.Width; i++)
                    {
                        for (int j = 0; j < img1.Height; j++)
                        {
                            Color pixel = img1.GetPixel(i, j);

                            // Para imagens em escala de cinza, extrair o valor do pixel com...
                            //byte pixelIntensity = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);
                            byte pixelIntensity = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);
                            vImg1Gray[i, j] = pixelIntensity;

                            // Para imagens RGB, extrair o valor do pixel com...
                            byte R = pixel.R;
                            byte G = pixel.G;
                            byte B = pixel.B;
                            byte A = pixel.A;

                            vImg1R[i, j] = R;
                            vImg1G[i, j] = G;
                            vImg1B[i, j] = B;
                            vImg1A[i, j] = A;

                            Color cor = Color.FromArgb(
                                255,
                                vImg1Gray[i, j],
                                vImg1Gray[i, j],
                                vImg1Gray[i, j]);

                            img2.SetPixel(i, j, cor);
                        }
                    }

                    pictureBox3.Image = img2;
                }

            }
        }

        private void btSalvarImagem_Click(object sender, EventArgs e)
        {
            if (img2 == null)
                return;

            // Configurações iniciais da saveFileDialog1
            var filePath = string.Empty;
            saveFileDialog1.InitialDirectory = "c:\\";
            saveFileDialog1.Filter = "TIFF image (*.tif)|*.tif|JPG image (*.jpg)|*.jpg|BMP image (*.bmp)|*.bmp|PNG image (*.png)|*.png|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;


            ImageFormat format = img2.RawFormat;

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveFileDialog1.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                    case ".tif":
                        format = ImageFormat.Tiff;
                        break;
                    case ".png":
                        format = ImageFormat.Png;
                        break;
                }

                //pictureBox3.Image.Save(saveFileDialog1.FileName, format);
                img2.Save(saveFileDialog1.FileName, format);
            }
        }
        */
        private void btCarregarImagem_Click(object sender, EventArgs e)
        {
            // Configurações iniciais da OpenFileDialogBox
            var filePath = string.Empty;
            openFileDialog1.InitialDirectory = "C:\\Matlab";
            openFileDialog1.Filter = "TIFF image (*.tif)|*.tif|JPG image (*.jpg)|*.jpg|BMP image (*.bmp)|*.bmp|PNG image (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            // Se um arquivo foi localizado com sucesso...
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Armnazena o path do arquivo de imagem
                filePath = openFileDialog1.FileName;


                bool bLoadImgOK = false;
                try
                {
                    img1 = new Bitmap(filePath);
                    bLoadImgOK = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao abrir imagem...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bLoadImgOK = false;
                }

                // Se a imagem carregou perfeitamente...
                if (bLoadImgOK == true)
                {
                    // Adiciona imagem na PictureBox
                    pictureBox1.Image = img1;
                }

            }
        }

        private void btSalvarImagem_Click(object sender, EventArgs e)
        {
            if (img3 == null)
                return;

            // Configurações iniciais da saveFileDialog1
            var filePath = string.Empty;
            saveFileDialog1.InitialDirectory = "c:\\";
            saveFileDialog1.Filter = "TIFF image (*.tif)|*.tif|JPG image (*.jpg)|*.jpg|BMP image (*.bmp)|*.bmp|PNG image (*.png)|*.png|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;


            ImageFormat format = img3.RawFormat;

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveFileDialog1.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                    case ".tif":
                        format = ImageFormat.Tiff;
                        break;
                    case ".png":
                        format = ImageFormat.Png;
                        break;
                }

                //pictureBox3.Image.Save(saveFileDialog1.FileName, format);
                img3.Save(saveFileDialog1.FileName, format);
            }
        }

        private void btCarregarImagem2_Click(object sender, EventArgs e)
        {
            // Configurações iniciais da OpenFileDialogBox
            var filePath = string.Empty;
            openFileDialog1.InitialDirectory = "C:\\Matlab";
            openFileDialog1.Filter = "TIFF image (*.tif)|*.tif|JPG image (*.jpg)|*.jpg|BMP image (*.bmp)|*.bmp|PNG image (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            // Se um arquivo foi localizado com sucesso...
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Armnazena o path do arquivo de imagem
                filePath = openFileDialog1.FileName;


                bool bLoadImgOK = false;
                try
                {
                    img2 = new Bitmap(filePath);
                    bLoadImgOK = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao abrir imagem...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bLoadImgOK = false;
                }

                // Se a imagem carregou perfeitamente...
                if (bLoadImgOK == true)
                {
                    // Adiciona imagem na PictureBox
                    pictureBox2.Image = img2;
                }

            }
        }

        private void Somar_Img_Click(object sender, EventArgs e)
        {
            img3 = new Bitmap(img1.Width, img1.Height);

            vImg1A = new byte[img1.Width, img1.Height];
            vImg1R = new byte[img1.Width, img1.Height];
            vImg1G = new byte[img1.Width, img1.Height];
            vImg1B = new byte[img1.Width, img1.Height];

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    if (img1 == null)
                    {
                        MessageBox.Show("img1 está null");
                        return;
                    }
                    if (img2 == null)
                    {
                        MessageBox.Show("img2 está null");
                        return;
                    }
                    Color pixel = img1.GetPixel(i, j);
                    Color pixel2 = img2.GetPixel(i, j);

                    if (pixel.A + pixel2.A > 255)
                    {
                        vImg1A[i, j] = 255;
                    }
                    else
                    {
                        vImg1A[i, j] = Convert.ToByte(pixel.A + pixel2.A);
                    }
                    if (pixel.R + pixel2.R > 255)
                    {
                        vImg1R[i, j] = 255;
                    }
                    else
                    {
                        vImg1R[i, j] = Convert.ToByte(pixel.R + pixel2.R);
                    }
                    if (pixel.G + pixel2.G > 255)
                    {
                        vImg1G[i, j] = 255;
                    }
                    else
                    {
                        vImg1G[i, j] = Convert.ToByte(pixel.G + pixel2.G);
                    }
                    if (pixel.B + pixel2.B > 255)
                    {
                        vImg1B[i, j] = 255;
                    }
                    else
                    {
                        vImg1B[i, j] = Convert.ToByte(pixel.B + pixel2.B);
                    }

                    Color cor = Color.FromArgb(
                        vImg1A[i, j],
                        vImg1R[i, j],
                        vImg1G[i, j],
                        vImg1B[i, j]);

                    img3.SetPixel(i, j, cor);
                }
            }

            pictureBox3.Image = img3;
        }

        private void Subtrair_Img_Click(object sender, EventArgs e)
        {
            img3 = new Bitmap(img1.Width, img1.Height);

            vImg1A = new byte[img1.Width, img1.Height];
            vImg1R = new byte[img1.Width, img1.Height];
            vImg1G = new byte[img1.Width, img1.Height];
            vImg1B = new byte[img1.Width, img1.Height];

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    if (img1 == null)
                    {
                        MessageBox.Show("img1 está null");
                        return;
                    }
                    if (img2 == null)
                    {
                        MessageBox.Show("img2 está null");
                        return;
                    }
                    Color pixel = img1.GetPixel(i, j);
                    Color pixel2 = img2.GetPixel(i, j);
                    if (pixel.R - pixel2.R < 0)
                    {
                        vImg1R[i, j] = 0;
                    }
                    else
                    {
                        vImg1R[i, j] = Convert.ToByte(pixel.R - pixel2.R);
                    }
                    if (pixel.G - pixel2.G < 0)
                    {
                        vImg1G[i, j] = 0;
                    }
                    else
                    {
                        vImg1G[i, j] = Convert.ToByte(pixel.G - pixel2.G);
                    }
                    if (pixel.B - pixel2.B < 0)
                    {
                        vImg1B[i, j] = 0;
                    }
                    else
                    {
                        vImg1B[i, j] = Convert.ToByte(pixel.B - pixel2.B);
                    }

                    Color cor = Color.FromArgb(
                        vImg1R[i, j],
                        vImg1G[i, j],
                        vImg1B[i, j]);

                    img3.SetPixel(i, j, cor);
                }
            }

            pictureBox3.Image = img3;
        }

        private void bt_add_Brightness_Click(object sender, EventArgs e)
        {
            img3 = new Bitmap(img1.Width, img1.Height);

            vImg1A = new byte[img1.Width, img1.Height];
            vImg1R = new byte[img1.Width, img1.Height];
            vImg1G = new byte[img1.Width, img1.Height];
            vImg1B = new byte[img1.Width, img1.Height];

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    if (img1 == null)
                    {
                        MessageBox.Show("img1 está null");
                        return;
                    }

                    Color pixel = img1.GetPixel(i, j);

                    if (pixel.R + Brightness_Up.Value > 255)
                    {
                        vImg1R[i, j] = 255;
                    }
                    else
                    {
                        vImg1R[i, j] = Convert.ToByte(pixel.R + Brightness_Up.Value);
                    }
                    if (pixel.G + Brightness_Up.Value > 255)
                    {
                        vImg1G[i, j] = 255;
                    }
                    else
                    {
                        vImg1G[i, j] = Convert.ToByte(pixel.G + Brightness_Up.Value);
                    }
                    if (pixel.B + Brightness_Up.Value > 255)
                    {
                        vImg1B[i, j] = 255;
                    }
                    else
                    {
                        vImg1B[i, j] = Convert.ToByte(pixel.B + Brightness_Up.Value);
                    }

                    Color cor = Color.FromArgb(
                        vImg1R[i, j],
                        vImg1G[i, j],
                        vImg1B[i, j]);

                    img3.SetPixel(i, j, cor);
                }
            }

            pictureBox3.Image = img3;
        }

        private void bt_sub_Brightness_Click(object sender, EventArgs e)
        {
            img3 = new Bitmap(img1.Width, img1.Height);

            vImg1A = new byte[img1.Width, img1.Height];
            vImg1R = new byte[img1.Width, img1.Height];
            vImg1G = new byte[img1.Width, img1.Height];
            vImg1B = new byte[img1.Width, img1.Height];

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    if (img1 == null)
                    {
                        MessageBox.Show("img1 está null");
                        return;
                    }

                    Color pixel = img1.GetPixel(i, j);

                    if (pixel.R - Brightness_Down.Value < 0)
                    {
                        vImg1R[i, j] = 0;
                    }
                    else
                    {
                        vImg1R[i, j] = Convert.ToByte(pixel.R - Brightness_Down.Value);
                    }
                    if (pixel.G - Brightness_Down.Value < 0)
                    {
                        vImg1G[i, j] = 0;
                    }
                    else
                    {
                        vImg1G[i, j] = Convert.ToByte(pixel.G - Brightness_Down.Value);
                    }
                    if (pixel.B - Brightness_Down.Value < 0)
                    {
                        vImg1B[i, j] = 0;
                    }
                    else
                    {
                        vImg1B[i, j] = Convert.ToByte(pixel.B - Brightness_Down.Value);
                    }

                    Color cor = Color.FromArgb(
                        vImg1R[i, j],
                        vImg1G[i, j],
                        vImg1B[i, j]);

                    img3.SetPixel(i, j, cor);
                }
            }

            pictureBox3.Image = img3;
        }

        private void bt_mult_Brightness_Click(object sender, EventArgs e)
        {
            img3 = new Bitmap(img1.Width, img1.Height);

            vImg1A = new byte[img1.Width, img1.Height];
            vImg1R = new byte[img1.Width, img1.Height];
            vImg1G = new byte[img1.Width, img1.Height];
            vImg1B = new byte[img1.Width, img1.Height];

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    if (img1 == null)
                    {
                        MessageBox.Show("img1 está null");
                        return;
                    }

                    Color pixel = img1.GetPixel(i, j);

                    if (pixel.R * Brightness_Mult.Value > 255)
                    {
                        vImg1R[i, j] = 255;
                    }
                    else
                    {
                        vImg1R[i, j] = Convert.ToByte(pixel.R * Brightness_Mult.Value);
                    }
                    if (pixel.G * Brightness_Mult.Value > 255)
                    {
                        vImg1G[i, j] = 255;
                    }
                    else
                    {
                        vImg1G[i, j] = Convert.ToByte(pixel.G * Brightness_Mult.Value);
                    }
                    if (pixel.B * Brightness_Mult.Value > 255)
                    {
                        vImg1B[i, j] = 255;
                    }
                    else
                    {
                        vImg1B[i, j] = Convert.ToByte(pixel.B * Brightness_Mult.Value);
                    }

                    Color cor = Color.FromArgb(
                        vImg1R[i, j],
                        vImg1G[i, j],
                        vImg1B[i, j]);

                    img3.SetPixel(i, j, cor);
                }
            }

            pictureBox3.Image = img3;
        }

        private void bt_div_Brightness_Click(object sender, EventArgs e)
        {
            img3 = new Bitmap(img1.Width, img1.Height);

            vImg1A = new byte[img1.Width, img1.Height];
            vImg1R = new byte[img1.Width, img1.Height];
            vImg1G = new byte[img1.Width, img1.Height];
            vImg1B = new byte[img1.Width, img1.Height];

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    if (img1 == null)
                    {
                        MessageBox.Show("img1 está null");
                        return;
                    }

                    Color pixel = img1.GetPixel(i, j);

                    if (Brightness_Div.Value <= 0)
                    {
                        vImg1R[i, j] = 255;
                        vImg1G[i, j] = 255;
                        vImg1B[i, j] = 255;
                    }
                    else
                    {
                        if (pixel.R / Brightness_Div.Value < 0)
                        {
                            vImg1R[i, j] = 0;
                        }
                        else if (pixel.R / Brightness_Div.Value > 255)
                        {
                            vImg1R[i, j] = 255;
                        }
                        else
                        {
                            vImg1R[i, j] = Convert.ToByte(pixel.R / Brightness_Div.Value);
                        }
                        if (pixel.G / Brightness_Div.Value < 0)
                        {
                            vImg1G[i, j] = 0;
                        }
                        else if (pixel.G / Brightness_Div.Value > 255)
                        {
                            vImg1G[i, j] = 255;
                        }
                        else
                        {
                            vImg1G[i, j] = Convert.ToByte(pixel.G / Brightness_Div.Value);
                        }
                        if (pixel.B / Brightness_Div.Value < 0)
                        {
                            vImg1B[i, j] = 0;
                        }
                        else if (pixel.B / Brightness_Div.Value > 255)
                        {
                            vImg1B[i, j] = 255;
                        }
                        else
                        {
                            vImg1B[i, j] = Convert.ToByte(pixel.B / Brightness_Div.Value);
                        }
                    }

                    Color cor = Color.FromArgb(
                        vImg1R[i, j],
                        vImg1G[i, j],
                        vImg1B[i, j]);

                    img3.SetPixel(i, j, cor);
                }
            }

            pictureBox3.Image = img3;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Brightness_Mult_ValueChanged(object sender, EventArgs e)
        {

        }
        private void bt_Overlay_Click(object sender, EventArgs e)
        {
            img3 = new Bitmap(img1.Width, img1.Height);

            vImg1A = new byte[img1.Width, img1.Height];
            vImg1R = new byte[img1.Width, img1.Height];
            vImg1G = new byte[img1.Width, img1.Height];
            vImg1B = new byte[img1.Width, img1.Height];

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    if (img1 == null)
                    {
                        MessageBox.Show("img1 está null");
                        return;
                    }
                    if (img2 == null)
                    {
                        MessageBox.Show("img2 está null");
                        return;
                    }
                    Color pixel = img1.GetPixel(i, j);
                    Color pixel2 = img2.GetPixel(i, j);

                    double alpha = Convert.ToDouble(pixel2.A) / 255;

                    if (pixel2.R * alpha + pixel.R * (1 - alpha) > 255)
                    {
                        vImg1R[i, j] = 255;
                    }
                    else
                    {
                        vImg1R[i, j] = Convert.ToByte(pixel2.R * alpha + pixel.R * (1 - alpha));
                    }
                    if (pixel2.G * alpha + pixel.G * (1 - alpha) > 255)
                    {
                        vImg1G[i, j] = 255;
                    }
                    else
                    {
                        vImg1G[i, j] = Convert.ToByte(pixel2.G * alpha + pixel.G * (1 - alpha));
                    }
                    if (pixel2.B * alpha + pixel.B * (1 - alpha) > 255)
                    {
                        vImg1B[i, j] = 255;
                    }
                    else
                    {
                        vImg1B[i, j] = Convert.ToByte(pixel2.B * alpha + pixel.B * (1 - alpha));
                    }

                    Color cor = Color.FromArgb(
                        vImg1A[i, j],
                        vImg1R[i, j],
                        vImg1G[i, j],
                        vImg1B[i, j]);

                    img3.SetPixel(i, j, cor);
                }
            }

            pictureBox3.Image = img3;
        }

        private void btFlipR_Click(object sender, EventArgs e)
        {
            img3 = new Bitmap(img1.Width, img1.Height);

            vImg1A = new byte[img1.Width, img1.Height];
            vImg1R = new byte[img1.Width, img1.Height];
            vImg1G = new byte[img1.Width, img1.Height];
            vImg1B = new byte[img1.Width, img1.Height];

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    if (img1 == null)
                    {
                        MessageBox.Show("img1 está null");
                        return;
                    }

                    Color pixel = img1.GetPixel(i, j);

                    vImg1A[i, j] = pixel.A;
                    vImg1R[i, j] = pixel.R;
                    vImg1G[i, j] = pixel.G;
                    vImg1B[i, j] = pixel.B;

                    Color cor = Color.FromArgb(
                        vImg1A[i, j],
                        vImg1R[i, j],
                        vImg1G[i, j],
                        vImg1B[i, j]);

                    img3.SetPixel(img1.Width -i -1, j, cor);
                }
            }

            pictureBox3.Image = img3;
        }

        private void btFlipUpDown_Click(object sender, EventArgs e)
        {
            img3 = new Bitmap(img1.Width, img1.Height);

            vImg1A = new byte[img1.Width, img1.Height];
            vImg1R = new byte[img1.Width, img1.Height];
            vImg1G = new byte[img1.Width, img1.Height];
            vImg1B = new byte[img1.Width, img1.Height];

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    if (img1 == null)
                    {
                        MessageBox.Show("img1 está null");
                        return;
                    }

                    Color pixel = img1.GetPixel(i, j);

                    vImg1A[i, j] = pixel.A;
                    vImg1R[i, j] = pixel.R;
                    vImg1G[i, j] = pixel.G;
                    vImg1B[i, j] = pixel.B;

                    Color cor = Color.FromArgb(
                        vImg1A[i, j],
                        vImg1R[i, j],
                        vImg1G[i, j],
                        vImg1B[i, j]);

                    img3.SetPixel(i, img1.Height - j - 1, cor);
                }
            }

            pictureBox3.Image = img3;
        }

        private void btGray_Click(object sender, EventArgs e)
        {
            img3 = new Bitmap(img1.Width, img1.Height);

            vImg1Gray = new byte[img1.Width, img1.Height];
            vImg1A = new byte[img1.Width, img1.Height];

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    if (img1 == null)
                    {
                        MessageBox.Show("img1 está null");
                        return;
                    }
                    
                    Color pixel = img1.GetPixel(i, j);

                    vImg1Gray[i, j] = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);

                    vImg1A[i, j] = pixel.A;

                    Color cor = Color.FromArgb(
                        vImg1A[i, j],
                        vImg1Gray[i, j],
                        vImg1Gray[i, j],
                        vImg1Gray[i, j]);
                    img3.SetPixel(i, j, cor);
                }
            }

            pictureBox3.Image = img3;
        }

        private void bt_Subt_2_Click(object sender, EventArgs e)
        {
            img3 = new Bitmap(img1.Width, img1.Height);
            img4 = new Bitmap(img1.Width, img1.Height);
            img5 = new Bitmap(img1.Width, img1.Height);

            vImg1A = new byte[img1.Width, img1.Height];
            vImg1R = new byte[img1.Width, img1.Height];
            vImg1G = new byte[img1.Width, img1.Height];
            vImg1B = new byte[img1.Width, img1.Height];

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    if (img1 == null)
                    {
                        MessageBox.Show("img1 está null");
                        return;
                    }
                    if (img2 == null)
                    {
                        MessageBox.Show("img2 está null");
                        return;
                    }

                    Color pixel = img1.GetPixel(i, j);
                    Color pixel2 = img2.GetPixel(i, j);

                    if (pixel.R - pixel2.R < 0)
                    {
                        vImg1R[i, j] = 0;
                    }
                    else
                    {
                        vImg1R[i, j] = Convert.ToByte(pixel.R - pixel2.R);
                    }
                    if (pixel.G - pixel2.G < 0)
                    {
                        vImg1G[i, j] = 0;
                    }
                    else
                    {
                        vImg1G[i, j] = Convert.ToByte(pixel.G - pixel2.G);
                    }
                    if (pixel.B - pixel2.B < 0)
                    {
                        vImg1B[i, j] = 0;
                    }
                    else
                    {
                        vImg1B[i, j] = Convert.ToByte(pixel.B - pixel2.B);
                    }

                    Color cor = Color.FromArgb(
                        vImg1R[i, j],
                        vImg1G[i, j],
                        vImg1B[i, j]);

                    img3.SetPixel(i, j, cor);
                }
            }

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    if (img1 == null)
                    {
                        MessageBox.Show("img1 está null");
                        return;
                    }
                    if (img2 == null)
                    {
                        MessageBox.Show("img2 está null");
                        return;
                    }

                    Color pixel = img2.GetPixel(i, j);

                    Color pixel2 = img1.GetPixel(i, j);

                    if (pixel.R - pixel2.R < 0)
                    {
                        vImg1R[i, j] = 0;
                    }
                    else
                    {
                        vImg1R[i, j] = Convert.ToByte(pixel.R - pixel2.R);
                    }
                    if (pixel.G - pixel2.G < 0)
                    {
                        vImg1G[i, j] = 0;
                    }
                    else
                    {
                        vImg1G[i, j] = Convert.ToByte(pixel.G - pixel2.G);
                    }
                    if (pixel.B - pixel2.B < 0)
                    {
                        vImg1B[i, j] = 0;
                    }
                    else
                    {
                        vImg1B[i, j] = Convert.ToByte(pixel.B - pixel2.B);
                    }

                    Color cor = Color.FromArgb(
                        vImg1R[i, j],
                        vImg1G[i, j],
                        vImg1B[i, j]);

                    img4.SetPixel(i, j, cor);
                }
            }

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    if (img3 == null)
                    {
                        MessageBox.Show("img3 está null");
                        return;
                    }
                    if (img4 == null)
                    {
                        MessageBox.Show("img4 está null");
                        return;
                    }
                    Color pixel = img3.GetPixel(i, j);
                    Color pixel2 = img4.GetPixel(i, j);

                    if (pixel.A + pixel2.A > 255)
                    {
                        vImg1A[i, j] = 255;
                    }
                    else
                    {
                        vImg1A[i, j] = Convert.ToByte(pixel.A + pixel2.A);
                    }
                    if (pixel.R + pixel2.R > 255)
                    {
                        vImg1R[i, j] = 255;
                    }
                    else
                    {
                        vImg1R[i, j] = Convert.ToByte(pixel.R + pixel2.R);
                    }
                    if (pixel.G + pixel2.G > 255)
                    {
                        vImg1G[i, j] = 255;
                    }
                    else
                    {
                        vImg1G[i, j] = Convert.ToByte(pixel.G + pixel2.G);
                    }
                    if (pixel.B + pixel2.B > 255)
                    {
                        vImg1B[i, j] = 255;
                    }
                    else
                    {
                        vImg1B[i, j] = Convert.ToByte(pixel.B + pixel2.B);
                    }

                    Color cor = Color.FromArgb(
                        vImg1A[i, j],
                        vImg1R[i, j],
                        vImg1G[i, j],
                        vImg1B[i, j]);

                    img5.SetPixel(i, j, cor);
                }
            }

            pictureBox3.Image = img5;
        }
    }
}
