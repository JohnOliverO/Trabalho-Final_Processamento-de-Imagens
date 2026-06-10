using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ImageLoader
{
    public partial class Form1 : Form
    {

        Bitmap img1;
        Bitmap img2;
        Bitmap img3;
        Bitmap imgR;

        Bitmap imgbinary1;
        Bitmap imgbinary2;

        int[] histogram1;
        int[] histogram2;
        int[] CFD;

        byte[,] vImg1Gray;

        byte[,] vImg1R;
        byte[,] vImg1G;
        byte[,] vImg1B;
        byte[,] vImg1A;

        int[,] Mask;

        int[,] StructuringElement;

        enum PaddingMode
        {
            Zero,       // preenche com 0 (preto)
            Replicate,  // repete bordas
            Reflect,    // espelha (sem repetir a borda)
            Mirror,     // espelha (repetindo a borda)
            Wrap        // efeito "tile" (loop)
        }

        public Form1()
        {
            InitializeComponent();
        }

        /*Funções*/

        void Tx_Resolution_Update()
        {
            if (pictureBox1.Image != null)
            {
                Tx_Resolution1.Text = $"{pictureBox1.Image.Width}x{pictureBox1.Image.Height}";
            }
            if (pictureBox2.Image != null)
            {
                Tx_Resolution2.Text = $"{pictureBox2.Image.Width}x{pictureBox2.Image.Height}";
            }
            if (pictureBox3.Image != null)
            {
                Tx_Resolution3.Text = $"{pictureBox3.Image.Width}x{pictureBox3.Image.Height}";
            }
        }
        void Resolution_Verification(Bitmap image1, Bitmap image2)
        {
            if (image1.Width != image2.Width || image1.Height != image2.Height)
            {
                throw new ArgumentException("image1 e image2 devem ter a mesma resolução.");
            }
        }
        Bitmap Crop_Image_Edges(Bitmap image, int numero)
        {
            if (numero <= 0) { 
                return image;
            }
            if (image.Width <= numero*2 || image.Height <= numero * 2)
            {
                throw new ArgumentException("Valor muito grande para o tamanho da imagem.", nameof(numero));
            }
            Bitmap newImage = new Bitmap(image.Width - numero * 2, image.Height - numero * 2);

            for (int i = numero; i < image.Width - numero; i++)
            {
                for (int j = numero; j < image.Height - numero; j++)
                {
                    newImage.SetPixel(i - numero, j - numero, image.GetPixel(i, j));
                }
            }

            return newImage;
        }
        Bitmap Crop_Image_Edges(Bitmap image, int left, int right, int top, int bottom)
        {
            if (left < 0 || right < 0 || top < 0 || bottom < 0)
                throw new ArgumentException("Os valores de corte não podem ser negativos.");

            int newWidth = image.Width - left - right;
            int newHeight = image.Height - top - bottom;

            if (newWidth <= 0 || newHeight <= 0)
                throw new ArgumentException("Os valores de corte são maiores que o tamanho da imagem.");

            Bitmap newImage = new Bitmap(newWidth, newHeight);

            for (int i = 0; i < newWidth; i++)
            {
                for (int j = 0; j < newHeight; j++)
                {
                    Color pixel = image.GetPixel(i + left, j + top);
                    newImage.SetPixel(i, j, pixel);
                }
            }

            return newImage;
        }
        Bitmap Add_Padding_To_Image(Bitmap image, int numero, string mode)
        {
            if (!Enum.TryParse<PaddingMode>(mode, true, out PaddingMode paddingMode))
                throw new ArgumentException("Modo de padding inválido.");

            switch (paddingMode)
            {
                case PaddingMode.Zero:
                    return PadImage_With_Zeros(image, numero);

                case PaddingMode.Replicate:
                    return PadImage_Replicate_Edges(image, numero);

                case PaddingMode.Reflect:
                    return PadImage_Reflect(image, numero);

                case PaddingMode.Mirror:
                    return PadImage_Mirror(image, numero);

                case PaddingMode.Wrap:
                    return PadImage_Wrap(image, numero);

                default:
                    throw new ArgumentException("Modo de padding inválido.");
            }
        }
        Bitmap PadImage_With_Zeros(Bitmap image, int numero)
        {
            int newWidth = image.Width + numero * 2;
            int newHeight = image.Height + numero * 2;

            Bitmap newImage = new Bitmap(newWidth, newHeight);

            for (int i = 0; i < newWidth; i++)
            {
                for (int j = 0; j < newHeight; j++)
                {
                    int srcI = i - numero;
                    int srcJ = j - numero;

                    if (srcI >= 0 && srcI < image.Width &&
                        srcJ >= 0 && srcJ < image.Height)
                    {
                        newImage.SetPixel(i, j, image.GetPixel(srcI, srcJ));
                    }
                    else
                    {
                        newImage.SetPixel(i, j, Color.Black);
                    }
                }
            }

            return newImage;
        }
        Bitmap PadImage_Replicate_Edges(Bitmap image, int numero)
        {
            int newWidth = image.Width + numero * 2;
            int newHeight = image.Height + numero * 2;

            Bitmap newImage = new Bitmap(newWidth, newHeight);

            for (int i = 0; i < newWidth; i++)
            {
                for (int j = 0; j < newHeight; j++)
                {
                    int srcX = i - numero;
                    int srcY = j - numero;

                    srcX = Math.Max(0, Math.Min(srcX, image.Width - 1));
                    srcY = Math.Max(0, Math.Min(srcY, image.Height - 1));

                    newImage.SetPixel(i, j, image.GetPixel(srcX, srcY));
                }
            }

            return newImage;
        }
        Bitmap PadImage_Reflect(Bitmap image, int numero)
        {
            int newWidth = image.Width + numero * 2;
            int newHeight = image.Height + numero * 2;

            Bitmap newImage = new Bitmap(newWidth, newHeight);

            for (int i = 0; i < newWidth; i++)
            {
                for (int j = 0; j < newHeight; j++)
                {
                    int srcX = i - numero;
                    int srcY = j - numero;

                    while (srcX < 0 || srcX >= image.Width)
                    {
                        if (srcX < 0)
                            srcX = -srcX;
                        else
                            srcX = 2 * image.Width - srcX - 2;
                    }

                    while (srcY < 0 || srcY >= image.Height)
                    {
                        if (srcY < 0)
                            srcY = -srcY;
                        else
                            srcY = 2 * image.Height - srcY - 2;
                    }

                    newImage.SetPixel(i, j, image.GetPixel(srcX, srcY));
                }
            }

            return newImage;
        }
        Bitmap PadImage_Mirror(Bitmap image, int numero)
        {
            int newWidth = image.Width + numero * 2;
            int newHeight = image.Height + numero * 2;

            Bitmap newImage = new Bitmap(newWidth, newHeight);

            for (int i = 0; i < newWidth; i++)
            {
                for (int j = 0; j < newHeight; j++)
                {
                    int srcX = i - numero;
                    int srcY = j - numero;

                    while (srcX < 0 || srcX >= image.Width)
                    {
                        if (srcX < 0)
                            srcX = -srcX - 1;
                        else
                            srcX = 2 * image.Width - srcX - 1;
                    }

                    while (srcY < 0 || srcY >= image.Height)
                    {
                        if (srcY < 0)
                            srcY = -srcY - 1;
                        else
                            srcY = 2 * image.Height - srcY - 1;
                    }

                    newImage.SetPixel(i, j, image.GetPixel(srcX, srcY));
                }
            }

            return newImage;
        }
        Bitmap PadImage_Wrap(Bitmap image, int numero)
        {
            int newWidth = image.Width + numero * 2;
            int newHeight = image.Height + numero * 2;

            Bitmap newImage = new Bitmap(newWidth, newHeight);

            for (int i = 0; i < newWidth; i++)
            {
                for (int j = 0; j < newHeight; j++)
                {
                    int srcX = i - numero;
                    int srcY = j - numero;

                    srcX = ((srcX % image.Width) + image.Width) % image.Width;
                    srcY = ((srcY % image.Height) + image.Height) % image.Height;

                    newImage.SetPixel(i, j, image.GetPixel(srcX, srcY));
                }
            }

            return newImage;
        }
        Bitmap Add_Image(Bitmap image1,Bitmap image2)
        {
            Resolution_Verification(image1, image2);

            Bitmap newImage = new Bitmap(image1.Width, image1.Height);

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    Color pixel1 = image1.GetPixel(i, j);
                    Color pixel2 = image2.GetPixel(i, j);

                    byte A = (Byte)Math.Min(pixel1.A + pixel2.A, 255);
                    byte R = (Byte)Math.Min(pixel1.R + pixel2.R, 255);
                    byte G = (Byte)Math.Min(pixel1.G + pixel2.G, 255);
                    byte B = (Byte)Math.Min(pixel1.B + pixel2.B, 255);

                    Color cor = Color.FromArgb(A,R,G,B);

                    newImage.SetPixel(i, j, cor);
                }
            }
            return newImage;
        }
        Bitmap Sub_Image(Bitmap image1, Bitmap image2)
        {
            Resolution_Verification(image1, image2);

            Bitmap newImage = new Bitmap(image1.Width, image1.Height);

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    Color pixel1 = image1.GetPixel(i, j);
                    Color pixel2 = image2.GetPixel(i, j);

                    byte A = pixel1.A;
                    byte R = (Byte)Math.Max(pixel1.R - pixel2.R, 0);
                    byte G = (Byte)Math.Max(pixel1.G - pixel2.G, 0);
                    byte B = (Byte)Math.Max(pixel1.B - pixel2.B, 0);

                    Color cor = Color.FromArgb(A, R, G, B);

                    newImage.SetPixel(i, j, cor);
                }
            }
            return newImage;
        }
        Bitmap Add_Brightness_Image(Bitmap image1)
        {
            Bitmap newImage = new Bitmap(image1.Width, image1.Height);

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    Color pixel1 = image1.GetPixel(i, j);

                    byte A = pixel1.A;
                    byte R = (Byte)Math.Min(pixel1.R + Brightness_Up.Value, 255);
                    byte G = (Byte)Math.Min(pixel1.G + Brightness_Up.Value, 255);
                    byte B = (Byte)Math.Min(pixel1.B + Brightness_Up.Value, 255);

                    Color cor = Color.FromArgb(A, R, G, B);

                    newImage.SetPixel(i, j, cor);
                }
            }
            return newImage;
        }
        Bitmap Sub_Brightness_Image(Bitmap image1)
        {
            Bitmap newImage = new Bitmap(image1.Width, image1.Height);

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    Color pixel1 = image1.GetPixel(i, j);

                    byte A = pixel1.A;
                    byte R = (Byte)Math.Max(pixel1.R - Brightness_Down.Value, 0);
                    byte G = (Byte)Math.Max(pixel1.G - Brightness_Down.Value, 0);
                    byte B = (Byte)Math.Max(pixel1.B - Brightness_Down.Value, 0);

                    Color cor = Color.FromArgb(A, R, G, B);

                    newImage.SetPixel(i, j, cor);
                }
            }
            return newImage;
        }
        Bitmap Mult_Brightness_Image(Bitmap image1)
        {
            Bitmap newImage = new Bitmap(image1.Width, image1.Height);

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    Color pixel1 = image1.GetPixel(i, j);

                    byte A = pixel1.A;
                    byte R = (Byte)Math.Min(pixel1.R * Brightness_Mult.Value, 255);
                    byte G = (Byte)Math.Min(pixel1.G * Brightness_Mult.Value, 255);
                    byte B = (Byte)Math.Min(pixel1.B * Brightness_Mult.Value, 255);

                    Color cor = Color.FromArgb(A, R, G, B);

                    newImage.SetPixel(i, j, cor);
                }
            }
            return newImage;
        }
        Bitmap Div_Brightness_Image(Bitmap image1)
        {
            Bitmap newImage = new Bitmap(image1.Width, image1.Height);

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    Color pixel = image1.GetPixel(i, j);

                    byte A = pixel.A;
                    byte R, G, B;

                    if (Brightness_Div.Value == 0)
                    {
                        R = 255;
                        G = 255;
                        B = 255;
                    }
                    else
                    {
                        R = (byte)(pixel.R / Brightness_Div.Value);
                        G = (byte)(pixel.G / Brightness_Div.Value);
                        B = (byte)(pixel.B / Brightness_Div.Value);
                    }

                    Color cor = Color.FromArgb(A, R, G, B);

                    newImage.SetPixel(i, j, cor);
                }
            }

            return newImage;
        }
        Bitmap Flip_90_Right_Image(Bitmap image1)
        {
            Bitmap newImage = new Bitmap(image1.Height, image1.Width);

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    Color pixel = image1.GetPixel(i, j);

                    newImage.SetPixel(image1.Height - j - 1, i, pixel);
                }
            }

            return newImage;
        }
        Bitmap Flip_90_Left_Image(Bitmap image1)
        {
            Bitmap newImage = new Bitmap(image1.Height, image1.Width);

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    Color pixel = image1.GetPixel(i, j);

                    newImage.SetPixel(j, image1.Width - i - 1, pixel);
                }
            }

            return newImage;
        }
        Bitmap Flip_Horizontal_Image(Bitmap image1)
        {
            Bitmap newImage = new Bitmap(image1.Width, image1.Height);

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    Color pixel = image1.GetPixel(i, j);

                    newImage.SetPixel(image1.Width - i - 1, j, pixel);
                }
            }

            return newImage;
        }
        Bitmap Flip_Vertical_Image(Bitmap image1)
        {
            Bitmap newImage = new Bitmap(image1.Width, image1.Height);

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    Color pixel = image1.GetPixel(i, j);

                    newImage.SetPixel(i, image1.Height - j - 1, pixel);
                }
            }

            return newImage;
        }
        Bitmap GrayScale_Average_Image(Bitmap image1)
        {
            Bitmap newImage = new Bitmap(image1.Width, image1.Height);

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    Color pixel = image1.GetPixel(i, j);

                    int value = (pixel.R + pixel.G + pixel.B) / 3;

                    Color escala = Color.FromArgb(pixel.A, value, value, value);

                    newImage.SetPixel(i, j, escala);
                }
            }

            return newImage;
        }
        Bitmap GrayScale_Luminance_Image(Bitmap image1)
        {
            Bitmap newImage = new Bitmap(image1.Width, image1.Height);

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    Color pixel = image1.GetPixel(i, j);

                    int value = (int)(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B);

                    Color escala = Color.FromArgb(pixel.A, value, value, value);

                    newImage.SetPixel(i, j, escala);
                }
            }

            return newImage;
        }
        Bitmap Difference_Image(Bitmap image1, Bitmap image2)
        {
            Resolution_Verification(image1, image2);

            Bitmap newImage = new Bitmap(image1.Width, image1.Height);

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    Color pixel1 = image1.GetPixel(i, j);
                    Color pixel2 = image2.GetPixel(i, j);

                    byte A = pixel1.A;
                    byte R = (byte)Math.Abs(pixel1.R - pixel2.R);
                    byte G = (byte)Math.Abs(pixel1.G - pixel2.G);
                    byte B = (byte)Math.Abs(pixel1.B - pixel2.B);

                    Color cor = Color.FromArgb(A, R, G, B);
                    newImage.SetPixel(i, j, cor);
                }
            }

            return newImage;
        }
        Bitmap Negative_Image(Bitmap image1)
        {
            Bitmap newImage = new Bitmap(image1.Width, image1.Height);

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    Color pixel = image1.GetPixel(i, j);

                    Color cor = Color.FromArgb(
                        pixel.A, 
                        (byte)(255 - pixel.R),
                        (byte)(255 - pixel.G),
                        (byte)(255 - pixel.B));

                    newImage.SetPixel(i, j, cor);
                }
            }

            return newImage;
        }
        Bitmap Blend_Image(Bitmap image1, Bitmap image2)
        {
            Resolution_Verification(image1, image2);

            Bitmap newImage = new Bitmap(image1.Width, image1.Height);

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    Color pixel1 = image1.GetPixel(i, j);
                    Color pixel2 = image2.GetPixel(i, j);

                    byte A = 255;
                    byte R = (Byte)((Blend_Mult.Value * pixel1.R) + ((1 - Blend_Mult.Value) * pixel2.R));
                    byte G = (Byte)((Blend_Mult.Value * pixel1.G) + ((1 - Blend_Mult.Value) * pixel2.G));
                    byte B = (Byte)((Blend_Mult.Value * pixel1.B) + ((1 - Blend_Mult.Value) * pixel2.B));

                    Color cor = Color.FromArgb(A, R, G, B);

                    newImage.SetPixel(i, j, cor);
                }
            }
            return newImage;
        }
        Bitmap Overlay_Image(Bitmap image1, Bitmap image2)
        {
            Resolution_Verification(image1, image2);

            Bitmap newImage = new Bitmap(image1.Width, image1.Height);

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    Color pixel1 = image1.GetPixel(i, j);
                    Color pixel2 = image2.GetPixel(i, j);

                    double alpha = pixel2.A / 255.0;

                    byte R = (byte)(
                        pixel2.R * alpha +
                        pixel1.R * (1 - alpha));

                    byte G = (byte)(
                        pixel2.G * alpha +
                        pixel1.G * (1 - alpha));

                    byte B = (byte)(
                        pixel2.B * alpha +
                        pixel1.B * (1 - alpha));

                    byte A = (byte)(
                        pixel2.A +
                        pixel1.A * (1 - alpha));

                    Color cor = Color.FromArgb(A, R, G, B);

                    newImage.SetPixel(i, j, cor);
                }
            }

            return newImage;
        }
        Bitmap MEAN_Image(Bitmap image1)
        {
            Bitmap newImage = new Bitmap(image1.Width, image1.Height);

            image1 = GrayScale_Average_Image(image1);

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    if(i == 0 || j == 0 || i == image1.Width - 1 || j == image1.Height - 1)
                    {
                        newImage.SetPixel(i, j, Color.Black);
                    }
                    else
                    {
                        int Soma = 0;

                        for (int k = 1; k <= 3; k++)
                        {
                            for (int l = 1; l <= 3; l++)
                            {
                                Color pixel = image1.GetPixel(i - 2 + k, j - 2 + l);
                                Soma += pixel.R;
                            }
                        }
                        int media = Soma / 9;

                        Color cor = Color.FromArgb(255, media, media, media);

                        newImage.SetPixel(i, j, cor);
                    }
                }
            }
            return newImage;
        }
        Bitmap MAX_Image(Bitmap image1)
        {
            Bitmap newImage = new Bitmap(image1.Width, image1.Height);

            image1 = GrayScale_Average_Image(image1);

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    if (i == 0 || j == 0 || i == image1.Width - 1 || j == image1.Height - 1)
                    {
                        newImage.SetPixel(i, j, Color.Black);
                    }
                    else
                    {
                        int Max = 0;
                        for (int k = 0; k < 3; k++)
                        {
                            for (int l = 0; l < 3; l++)
                            {
                                Color pixel = image1.GetPixel(i - 1 + k, j - 1 + l);
                                Max = Math.Max(Max,pixel.R);
                            }
                        }
                        Color cor = Color.FromArgb(255, Max, Max, Max);

                        newImage.SetPixel(i, j, cor);
                    }
                }
            }
            return newImage;
        }
        Bitmap MIN_Image(Bitmap image1)
        {
            Bitmap newImage = new Bitmap(image1.Width, image1.Height);

            image1 = GrayScale_Average_Image(image1);

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    if (i == 0 || j == 0 || i == image1.Width - 1 || j == image1.Height - 1)
                    {
                        newImage.SetPixel(i, j, Color.Black);
                    }
                    else
                    {
                        int Min = 255;
                        for (int k = 1; k <= 3; k++)
                        {
                            for (int l = 1; l <= 3; l++)
                            {
                                Color pixel = image1.GetPixel(i - 2 + k, j - 2 + l);
                                Min = Math.Min(Min, pixel.R);
                            }
                        }
                        Color cor = Color.FromArgb(255, Min, Min, Min);

                        newImage.SetPixel(i, j, cor);
                    }
                }
            }
            return newImage;
        }
        Bitmap Average_Image(Bitmap image1,Bitmap image2)
        {
            Resolution_Verification(image1, image2);

            Bitmap newImage = new Bitmap(image1.Width, image1.Height);

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    Color pixel = image1.GetPixel(i, j);
                    Color pixel2 = image2.GetPixel(i, j);

                    int R = (int)((pixel.R + pixel2.R) * 0.5);
                    int G = (int)((pixel.G + pixel2.G) * 0.5);
                    int B = (int)((pixel.B + pixel2.B) * 0.5);


                    Color cor = Color.FromArgb(R,G,B);

                    newImage.SetPixel(i, j, cor);
                }
            }
            return newImage;
        }
        Bitmap Median_Image(Bitmap image1)
        {
            Bitmap newImage = new Bitmap(image1.Width, image1.Height);

            image1 = GrayScale_Average_Image(image1);

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    if (i == 0 || j == 0 || i == image1.Width - 1 || j == image1.Height - 1)
                    {
                        newImage.SetPixel(i, j, Color.Black);
                    }
                    else
                    {
                        int[] matriz = new int[9];
                        int n = 0;

                        for (int k = 0; k < 3; k++)
                        {
                            for (int l = 1; l <= 3; l++)
                            {
                                Color pixel = image1.GetPixel(i - 1 + k, j - 2 + l);
                                matriz[n] = pixel.R;
                                n++;
                            }
                        }

                        Array.Sort(matriz);

                        Color cor = Color.FromArgb(255, matriz[4], matriz[4], matriz[4]);

                        newImage.SetPixel(i, j, cor);

                    }
                    
                }
            }
            return newImage;
        }
        Bitmap Order_Image(Bitmap image1)
        {
            Bitmap newImage = new Bitmap(image1.Width, image1.Height);

            image1 = GrayScale_Average_Image(image1);

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    if (i == 0 || j == 0 || i == image1.Width - 1 || j == image1.Height - 1)
                    {
                        newImage.SetPixel(i, j, Color.Black);
                    }
                    else
                    {
                        int[] matriz = new int[9];
                        int n = 0;

                        for (int k = 0; k < 3; k++)
                        {
                            for (int l = 1; l <= 3; l++)
                            {
                                Color pixel = image1.GetPixel(i - 1 + k, j - 2 + l);
                                matriz[n] = pixel.R;
                                n++;
                            }
                        }
                        int ordem = Convert.ToInt16(nudOrder.Value);

                        Array.Sort(matriz);

                        Color cor = Color.FromArgb(255, matriz[ordem], matriz[ordem], matriz[ordem]);

                        newImage.SetPixel(i, j, cor);

                    }

                }
            }
            return newImage;
        }
        Bitmap Smooth_Image(Bitmap image1)
        {
            Bitmap newImage = new Bitmap(image1.Width, image1.Height);

            image1 = GrayScale_Average_Image(image1);

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    if (i == 0 || j == 0 || i == image1.Width - 1 || j == image1.Height - 1)
                    {
                        newImage.SetPixel(i, j, Color.Black);
                    }
                    else
                    {
                        int[] matriz = new int[8];
                        int n = 0;
                        int ancora = 0;

                        for (int k = 0; k < 3; k++)
                        {
                            for (int l = 1; l <= 3; l++)
                            {
                                Color pixel = image1.GetPixel(i - 1 + k, j - 2 + l);
                                if(k == 1 && l == 2)
                                {
                                    ancora = pixel.R;
                                }
                                else
                                {
                                    matriz[n] = pixel.R;
                                    n++;
                                }
                            }
                        }
                        int ordem = Convert.ToInt16(nudOrder.Value);

                        Array.Sort(matriz);

                        if (matriz[0] > ancora)
                        {
                            ancora = matriz[0];
                        }
                        else if (matriz[7] < ancora)
                        {
                            ancora = matriz[7];
                        }

                        Color cor = Color.FromArgb(255, ancora, ancora, ancora);

                        newImage.SetPixel(i, j, cor);

                    }

                }
            }
            return newImage;
        }
        Bitmap Gaussian_Image(Bitmap image1)
        {
            Bitmap newImage = new Bitmap(image1.Width, image1.Height);

            int[,] kernel =
            {
                { 1, 2, 1 },
                { 2, 4, 2 },
                { 1, 2, 1 }
            };  

            int divisor = 16;

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    if (i == 0 || j == 0 ||
                        i == image1.Width - 1 ||
                        j == image1.Height - 1)
                    {
                        newImage.SetPixel(i, j, image1.GetPixel(i, j));
                    }
                    else
                    {
                        int somaR = 0;
                        int somaG = 0;
                        int somaB = 0;

                        for (int k = 0; k < 3; k++)
                        {
                            for (int l = 0; l < 3; l++)
                            {
                                Color pixel = image1.GetPixel(
                                    i - 1 + k,
                                    j - 1 + l);

                                somaR += pixel.R * kernel[k, l];
                                somaG += pixel.G * kernel[k, l];
                                somaB += pixel.B * kernel[k, l];
                            }
                        }

                        byte R = (byte)(somaR / divisor);
                        byte G = (byte)(somaG / divisor);
                        byte B = (byte)(somaB / divisor);

                        newImage.SetPixel(i, j,
                            Color.FromArgb(R, G, B));
                    }
                }
            }

            return newImage;
        }
        Bitmap Prewitt_Image(Bitmap image1)
        {
            Bitmap newImage = new Bitmap(image1.Width, image1.Height);

            image1 = GrayScale_Average_Image(image1);

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    if (i == 0 || j == 0 || i == image1.Width - 1 || j == image1.Height - 1)
                    {
                        newImage.SetPixel(i, j, Color.Black);
                    }
                    else
                    {
                        double Gx = 0;
                        double Gy = 0;

                        for (int k = 0; k < 3; k++)
                        {
                            for (int l = 0; l < 3; l++)
                            {
                                Color pixel = image1.GetPixel(i - 1 + k, j - 1 + l);
                                
                                if(k == 0)
                                {
                                    Gy += pixel.R * (-1);
                                }
                                else if(k == 2)
                                {
                                    Gy += pixel.R;
                                }
                                if (l == 0)
                                {
                                    Gx += pixel.R * (-1);
                                }
                                else if (l == 2)
                                {
                                    Gx += pixel.R;
                                }
                            }
                        }

                        int V = (int)Math.Round(Math.Pow(Gx * Gx + Gy * Gy,0.5));

                        if (V > 255)
                            V = 255;
                        if (V < 0)
                            V = 0;

                        Color cor = Color.FromArgb(255, V, V, V);

                        newImage.SetPixel(i, j, cor);

                    }

                }
            }
            return newImage;
        }
        Bitmap Sobel_Image(Bitmap image1)
        {
            Bitmap newImage = new Bitmap(image1.Width, image1.Height);

            image1 = GrayScale_Average_Image(image1);

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    if (i == 0 || j == 0 || i == image1.Width - 1 || j == image1.Height - 1)
                    {
                        newImage.SetPixel(i, j, Color.Black);
                    }
                    else
                    {
                        double Gx = 0;
                        double Gy = 0;

                        for (int k = 0; k < 3; k++)
                        {
                            for (int l = 0; l < 3; l++)
                            {
                                Color pixel = image1.GetPixel(i - 1 + k, j - 1 + l);

                                if (k == 0)
                                {
                                    if (l == 1)
                                    {
                                        Gy += pixel.R * (-2);
                                    }
                                    else
                                    {
                                        Gy += pixel.R * (-1);
                                    }
                                }
                                else if (k == 2)
                                {
                                    if (l == 1)
                                    {
                                        Gy += pixel.R * 2;
                                    }
                                    else
                                    {
                                        Gy += pixel.R;
                                    }
                                }
                                if (l == 0)
                                {
                                    if(k == 1)
                                    {
                                        Gx += pixel.R * (-2);
                                    }
                                    else
                                    {
                                        Gx += pixel.R * (-1);
                                    }
                                }
                                else if (l == 2)
                                {
                                    if (k == 1)
                                    {
                                        Gx += pixel.R * 2;
                                    }
                                    else
                                    {
                                        Gx += pixel.R;
                                    }
                                }
                            }
                        }

                        int V = (int)Math.Round(Math.Pow(Gx * Gx + Gy * Gy, 0.5));

                        if (V > 255)
                            V = 255;

                        if (V < 0)
                            V = 0;

                            Color cor = Color.FromArgb(255, V, V, V);

                        newImage.SetPixel(i, j, cor);

                    }

                }
            }
            return newImage;
        }
        Bitmap Laplace_Mask1_Image(Bitmap image1)
        {
            Bitmap newImage = new Bitmap(image1.Width, image1.Height);

            image1 = GrayScale_Average_Image(image1);

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    if (i == 0 || j == 0 || i == image1.Width - 1 || j == image1.Height - 1)
                    {
                        newImage.SetPixel(i, j, Color.Black);
                    }
                    else
                    {
                        int Gx = 0;
                        int Gy = 0;
                        for (int k = 0; k < 3; k++)
                        {
                            for (int l = 0; l < 3; l++)
                            {
                                Color pixel = image1.GetPixel(i - 1 + k, j - 1 + l);

                                if(k == 1 || l == 1)
                                {
                                    if(k == 1 && l == 1)
                                    {
                                        Gx += pixel.R * (-4);
                                    }
                                    else
                                    {
                                        Gx += pixel.R;
                                    }
                                }
                                if (k == 1 || l == 1)
                                {
                                    if (k == 1 && l == 1)
                                    {
                                        Gy += pixel.R * 4;
                                    }
                                    else
                                    {
                                        Gy += pixel.R * (-1);
                                    }
                                }
                            }
                        }
                        int V = (int)Math.Round(Math.Pow(Gx * Gx + Gy * Gy, 0.5));

                        if (V > 255)
                            V = 255;

                        if (V < 0)
                            V = 0;

                        Color cor = Color.FromArgb(255, V, V, V);

                        newImage.SetPixel(i, j, cor);

                    }

                }
            }
            return newImage;
        }
        Bitmap Laplace_Mask2_Image(Bitmap image1)
        {
            Bitmap newImage = new Bitmap(image1.Width, image1.Height);

            image1 = GrayScale_Average_Image(image1);

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    if (i == 0 || j == 0 || i == image1.Width - 1 || j == image1.Height - 1)
                    {
                        newImage.SetPixel(i, j, Color.Black);
                    }
                    else
                    {
                        int Gx = 0;
                        int Gy = 0;
                        for (int k = 0; k < 3; k++)
                        {
                            for (int l = 0; l < 3; l++)
                            {
                                Color pixel = image1.GetPixel(i - 1 + k, j - 1 + l);

                                if (k == 1 && l == 1)
                                {
                                    Gx += pixel.R * (-8);
                                }
                                else
                                {
                                    Gx += pixel.R;
                                }
                                if (k == 1 && l == 1)
                                {
                                    Gy += pixel.R * 8;
                                }
                                else
                                {
                                    Gy += pixel.R * (-1);
                                }
                            }
                        }
                        int V = (int)Math.Round(Math.Pow(Gx * Gx + Gy * Gy, 0.5));

                        if (V > 255)
                            V = 255;

                        if (V < 0)
                            V = 0;

                        Color cor = Color.FromArgb(255, V, V, V);

                        newImage.SetPixel(i, j, cor);

                    }

                }
            }
            return newImage;
        }
        Bitmap Dilatation_Image(Bitmap image1)
        {
            Bitmap newImage = new Bitmap(image1.Width, image1.Height);

            Bitmap binary1 = BinarizarImagem(image1);

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    if (i == 0 || j == 0 || i == image1.Width - 1 || j == image1.Height - 1)
                    {
                        newImage.SetPixel(i, j, Color.Black);
                    }
                    else
                    {
                        bool Tem = false;

                        for (int k = 0; k < Mask.GetLength(0); k++)
                        {
                            for (int l = 0; l < Mask.GetLength(1); l++)
                            {
                                Color pixel = binary1.GetPixel(i - 1 + k, j - 1 + l);

                                if (pixel.R == 255 && Mask[k, l] == 255)
                                {
                                    Tem = true;
                                    break;
                                }
                            }
                            if (Tem)
                                break;
                        }
                        if (Tem)
                        {
                            newImage.SetPixel(i, j, Color.White);
                        }
                        else
                        {
                            newImage.SetPixel(i, j, Color.Black);
                        }
                    }
                }
            }
            return newImage;
        }
        Bitmap Erosion_Image(Bitmap image1)
        {
            Bitmap newImage = new Bitmap(image1.Width, image1.Height);

            Bitmap binary1 = BinarizarImagem(image1);

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    if (i == 0 || j == 0 || i == image1.Width - 1 || j == image1.Height - 1)
                    {
                        newImage.SetPixel(i, j, Color.Black);
                    }
                    else
                    {
                        bool Tem = true;

                        for (int k = 0; k < Mask.GetLength(0); k++)
                        {
                            for (int l = 0; l < Mask.GetLength(1); l++)
                            {
                                Color pixel = binary1.GetPixel(i - 1 + k, j - 1 + l);

                                if (pixel.R == 0 && Mask[k, l] == 255)
                                {
                                    Tem = false;
                                    break;
                                }
                            }
                            if (!Tem)
                                break;
                        }
                        if (Tem)
                        {
                            newImage.SetPixel(i, j, Color.White);
                        }
                        else
                        {
                            newImage.SetPixel(i, j, Color.Black);
                        }
                    }
                }
            }
            return newImage;
        }
        Bitmap Opening_Image(Bitmap image1)
        {
            return Dilatation_Image(Erosion_Image(image1));
        }
        Bitmap Closing_Image(Bitmap image1)
        {
            return Erosion_Image(Dilatation_Image(image1));
        }
        Bitmap Contour_Image(Bitmap image1)
        {
            return Sub_Image(image1, Erosion_Image(image1));
        }
        Bitmap ExternalContour_Image(Bitmap image1)
        {
            return Sub_Image(Dilatation_Image(image1), image1);
        }
        Bitmap MorphologicalGradient_Image(Bitmap image1)
        {
            return Sub_Image(
                Dilatation_Image(image1),
                Erosion_Image(image1)
            );
        }

        /*==============================================================================================================================================================================
        Botões
        ===============================================================================================================================================================================*/
        private void btCarregarImagem_Click(object sender, EventArgs e)
        {
            // Configurações iniciais da OpenFileDialogBox
            var filePath = string.Empty;
            openFileDialog1.InitialDirectory = "C:\\Matlab";
            openFileDialog1.Filter = "TIFF image (*.tif)|*.tif|JPG image (*.jpg)|*.jpg|BMP image (*.bmp)|*.bmp|PNG image (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 5;
            openFileDialog1.RestoreDirectory = true;

            // Se um arquivo foi localizado com sucesso...
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Armazena o path do arquivo de imagem
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
                    Tx_Resolution_Update();
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
            openFileDialog1.FilterIndex = 5;
            openFileDialog1.RestoreDirectory = true;

            // Se um arquivo foi localizado com sucesso...
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Armazena o path do arquivo de imagem
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
                    Tx_Resolution_Update();
                }

            }
        }
        private void Somar_Img_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("img1 está nula");
                return;
            }
            if (img2 == null)
            {
                MessageBox.Show("img2 está nula");
                return;
            }

            try
            {
                img3 = Add_Image(img1, img2);
                pictureBox3.Image = img3;
                Tx_Resolution_Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Subtrair_Img_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("img1 está nula");
                return;
            }
            if (img2 == null)
            {
                MessageBox.Show("img2 está nula");
                return;
            }

            try
            {
                img3 = Sub_Image(img1, img2);
                pictureBox3.Image = img3;
                Tx_Resolution_Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_add_Brightness_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("img1 está nula");
                return;
            }

            try
            {
                img3 = Add_Brightness_Image(img1);
                pictureBox3.Image = img3;
                Tx_Resolution_Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_sub_Brightness_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("img1 está nula");
                return;
            }

            try
            {
                img3 = Sub_Brightness_Image(img1);
                pictureBox3.Image = img3;
                Tx_Resolution_Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_mult_Brightness_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("img1 está nula");
                return;
            }

            try
            {
                img3 = Mult_Brightness_Image(img1);
                pictureBox3.Image = img3;
                Tx_Resolution_Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_div_Brightness_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("img1 está nula");
                return;
            }

            try
            {
                img3 = Div_Brightness_Image(img1);
                pictureBox3.Image = img3;
                Tx_Resolution_Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btFlip_90_R_Click(object sender, EventArgs e)
        {
            if (img3 == null)
            {
                if (img1 == null)
                {
                    MessageBox.Show("img1 está nula");
                    return;
                }

                try
                {
                    img3 = Flip_90_Right_Image(img1);
                    pictureBox3.Image = img3;
                    Tx_Resolution_Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                try
                {
                    img3 = Flip_90_Right_Image(img3);
                    pictureBox3.Image = img3;
                    Tx_Resolution_Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btFlip_90_L_Click(object sender, EventArgs e)
        {
            if (img3 == null)
            {
                if (img1 == null)
                {
                    MessageBox.Show("img1 está nula");
                    return;
                }

                try
                {
                    img3 = Flip_90_Left_Image(img1);
                    pictureBox3.Image = img3;
                    Tx_Resolution_Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                try
                {
                    img3 = Flip_90_Left_Image(img3);
                    pictureBox3.Image = img3;
                    Tx_Resolution_Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btFlipUpDown_Click(object sender, EventArgs e)
        {
            if (img3 == null)
            {
                if (img1 == null)
                {
                    MessageBox.Show("img1 está nula");
                    return;
                }

                try
                {
                    img3 = Flip_Vertical_Image(img1);
                    pictureBox3.Image = img3;
                    Tx_Resolution_Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                try
                {
                    img3 = Flip_Vertical_Image(img3);
                    pictureBox3.Image = img3;
                    Tx_Resolution_Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btFlip_Horizontal_Click(object sender, EventArgs e)
        {
            if (img3 == null)
            {
                if (img1 == null)
                {
                    MessageBox.Show("img1 está nula");
                    return;
                }

                try
                {
                    img3 = Flip_Horizontal_Image(img1);
                    pictureBox3.Image = img3;
                    Tx_Resolution_Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                try
                {
                    img3 = Flip_Horizontal_Image(img3);
                    pictureBox3.Image = img3;
                    Tx_Resolution_Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btGray_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("img1 está nula");
                return;
            }

            try
            {
                img3 = GrayScale_Average_Image(img1);
                pictureBox3.Image = img3;
                Tx_Resolution_Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bt_Difference_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("img1 está nula");
                return;
            }
            if (img2 == null)
            {
                MessageBox.Show("img2 está nula");
                return;
            }

            try
            {
                img3 = Difference_Image(img1, img2);
                pictureBox3.Image = img3;
                Tx_Resolution_Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btN_Click(object sender, EventArgs e)
        {
            if (img3 == null)
            {
                if (img1 == null)
                {
                    MessageBox.Show("img1 está nula");
                    return;
                }

                try
                {
                    img3 = Negative_Image(img1);
                    pictureBox3.Image = img3;
                    Tx_Resolution_Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                try
                {
                    img3 = Negative_Image(img3);
                    pictureBox3.Image = img3;
                    Tx_Resolution_Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btBlend_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("img1 está nula");
                return;
            }
            if (img2 == null)
            {
                MessageBox.Show("img2 está nula");
                return;
            }

            try
            {
                img3 = Blend_Image(img1, img2);
                pictureBox3.Image = img3;
                Tx_Resolution_Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btOverlay_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("img1 está nula");
                return;
            }
            if (img2 == null)
            {
                MessageBox.Show("img2 está nula");
                return;
            }

            try
            {
                img3 = Overlay_Image(img1, img2);
                pictureBox3.Image = img3;
                Tx_Resolution_Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btMAX_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("img1 está nula");
                return;
            }

            try
            {
                img3 = MAX_Image(img1);
                pictureBox3.Image = img3;
                Tx_Resolution_Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btMIN_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("img1 está nula");
                return;
            }

            try
            {
                img3 = MIN_Image(img1);
                pictureBox3.Image = img3;
                Tx_Resolution_Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btMean_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("img1 está nula");
                return;
            }

            try
            {
                img3 = MEAN_Image(img1);
                pictureBox3.Image = img3;
                Tx_Resolution_Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btMedian_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("img1 está nula");
                return;
            }

            try
            {
                img3 = Median_Image(img1);
                pictureBox3.Image = img3;
                Tx_Resolution_Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void brOrder_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("img1 está nula");
                return;
            }

            try
            {
                img3 = Order_Image(img1);
                pictureBox3.Image = img3;
                Tx_Resolution_Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btSmooth_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("img1 está nula");
                return;
            }

            try
            {
                img3 = Smooth_Image(img1);
                pictureBox3.Image = img3;
                Tx_Resolution_Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btPrewitt_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("img1 está nula");
                return;
            }

            try
            {
                img3 = Prewitt_Image(img1);
                pictureBox3.Image = img3;
                Tx_Resolution_Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btSobel_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("img1 está nula");
                return;
            }

            try
            {
                img3 = Sobel_Image(img1);
                pictureBox3.Image = img3;
                Tx_Resolution_Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btLaplace1_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("img1 está nula");
                return;
            }

            try
            {
                img3 = Laplace_Mask1_Image(img1);
                pictureBox3.Image = img3;
                Tx_Resolution_Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btLaplace2_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("img1 está nula");
                return;
            }

            try
            {
                img3 = Laplace_Mask2_Image(img1);
                pictureBox3.Image = img3;
                Tx_Resolution_Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btPadding_Click(object sender, EventArgs e)
        {
            String mode = cbPadding.Text;
            int numero = (int)nudPadding.Value;

            if (img3 == null)
            {
                if (img1 == null)
                {
                    MessageBox.Show("img1 está nula");
                    return;
                }

                try
                {
                    img3 = Add_Padding_To_Image(img1,numero, mode);
                    pictureBox3.Image = img3;
                    Tx_Resolution_Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                try
                {
                    img3 = Add_Padding_To_Image(img3, numero, mode);
                    pictureBox3.Image = img3;
                    Tx_Resolution_Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btDilatation_Click(object sender, EventArgs e)
        {
            if (img3 == null)
            {
                if (img1 == null)
                {
                    MessageBox.Show("img1 está nula");
                    return;
                }

                try
                {
                    img3 = Dilatation_Image(img1);
                    pictureBox3.Image = img3;
                    Tx_Resolution_Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                try
                {
                    img3 = Dilatation_Image(img3);
                    pictureBox3.Image = img3;
                    Tx_Resolution_Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btErosion_Click(object sender, EventArgs e)
        {
            if (img3 == null)
            {
                if (img1 == null)
                {
                    MessageBox.Show("img1 está nula");
                    return;
                }

                try
                {
                    img3 = Erosion_Image(img1);
                    pictureBox3.Image = img3;
                    Tx_Resolution_Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                try
                {
                    img3 = Erosion_Image(img3);
                    pictureBox3.Image = img3;
                    Tx_Resolution_Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btOpening_Click(object sender, EventArgs e)
        {
            if (img3 == null)
            {
                if (img1 == null)
                {
                    MessageBox.Show("img1 está nula");
                    return;
                }

                try
                {
                    img3 = Opening_Image(img1);
                    pictureBox3.Image = img3;
                    Tx_Resolution_Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                try
                {
                    img3 = Opening_Image(img3);
                    pictureBox3.Image = img3;
                    Tx_Resolution_Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btClosing_Click(object sender, EventArgs e)
        {
            if (img3 == null)
            {
                if (img1 == null)
                {
                    MessageBox.Show("img1 está nula");
                    return;
                }

                try
                {
                    img3 = Closing_Image(img1);
                    pictureBox3.Image = img3;
                    Tx_Resolution_Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                try
                {
                    img3 = Closing_Image(img3);
                    pictureBox3.Image = img3;
                    Tx_Resolution_Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btContour_Click(object sender, EventArgs e)
        {
            if (img3 == null)
            {
                if (img1 == null)
                {
                    MessageBox.Show("img1 está nula");
                    return;
                }

                try
                {
                    img3 = Contour_Image(img1);
                    pictureBox3.Image = img3;
                    Tx_Resolution_Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                try
                {
                    img3 = Contour_Image(img3);
                    pictureBox3.Image = img3;
                    Tx_Resolution_Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btExternalContour_Click(object sender, EventArgs e)
        {
            if (img3 == null)
            {
                if (img1 == null)
                {
                    MessageBox.Show("img1 está nula");
                    return;
                }

                try
                {
                    img3 = ExternalContour_Image(img1);
                    pictureBox3.Image = img3;
                    Tx_Resolution_Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                try
                {
                    img3 = ExternalContour_Image(img3);
                    pictureBox3.Image = img3;
                    Tx_Resolution_Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btMorphologicalGradient_Click(object sender, EventArgs e)
        {
            if (img3 == null)
            {
                if (img1 == null)
                {
                    MessageBox.Show("img1 está nula");
                    return;
                }

                try
                {
                    img3 = MorphologicalGradient_Image(img1);
                    pictureBox3.Image = img3;
                    Tx_Resolution_Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                try
                {
                    img3 = MorphologicalGradient_Image(img3);
                    pictureBox3.Image = img3;
                    Tx_Resolution_Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btAverage_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("img1 está nula");
                return;
            }
            if (img2 == null)
            {
                MessageBox.Show("img2 está nula");
                return;
            }

            try
            {
                img3 = Average_Image(img1, img2);
                pictureBox3.Image = img3;
                Tx_Resolution_Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static Bitmap BinarizarImagem(Bitmap imagemOriginal, int limiar = 128)
        {
            int largura = imagemOriginal.Width;
            int altura = imagemOriginal.Height;
            Bitmap imagemBinaria = new Bitmap(largura, altura);

            for (int i = 0; i < altura; i++)
            {
                for (int j = 0; j < largura; j++)
                {
                    Color corOriginal = imagemOriginal.GetPixel(j,i);

                    int intensidade = (int)((corOriginal.R + corOriginal.G + corOriginal.B) / 3);

                    Color novaCor = (intensidade > limiar) ? Color.White : Color.Black;
                    imagemBinaria.SetPixel(j, i, novaCor);
                    
                }
            }
            return imagemBinaria;
        }
        private void btBin_Click(object sender, EventArgs e)
        {
            img3 = new Bitmap(img1.Width, img1.Height);

            imgbinary1 = new Bitmap(img1.Width, img1.Height);

            if (img1 == null)
            {
                MessageBox.Show("img1 está null");
                return;
            }

            img3 = BinarizarImagem(img1);

            pictureBox3.Image = img3;
            Tx_Resolution_Update();
        }

        private void btAnd_Click(object sender, EventArgs e)
        {
            img3 = new Bitmap(img1.Width, img1.Height);

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

            imgbinary1 = BinarizarImagem(img1);
            imgbinary2 = BinarizarImagem(img2);

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {

                    Color pixel = imgbinary1.GetPixel(i, j);
                    Color pixel2 = imgbinary2.GetPixel(i, j);

                    Color cor = Color.Aqua;

                    if (pixel.R == 255 && pixel2.R == 255)
                    {
                        cor = Color.White;
                    }
                    else
                    {
                        cor = Color.Black;
                    }

                    img3.SetPixel(i, j, cor);
                }
            }

            pictureBox3.Image = img3;
            Tx_Resolution_Update();
        }

        private void btOR_Click(object sender, EventArgs e)
        {
            img3 = new Bitmap(img1.Width, img1.Height);

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

            imgbinary1 = BinarizarImagem(img1);
            imgbinary2 = BinarizarImagem(img2);

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    Color p1 = imgbinary1.GetPixel(i, j);
                    Color p2 = imgbinary2.GetPixel(i, j);

                    if (p1.R == 255 || p2.R == 255)
                        img3.SetPixel(i, j, Color.White);
                    else
                        img3.SetPixel(i, j, Color.Black);
                }
            }

            pictureBox3.Image = img3;
            Tx_Resolution_Update();
        }

        private void btNot_Click(object sender, EventArgs e)
        {
            img3 = new Bitmap(img1.Width, img1.Height);

            if (img1 == null)
            {
                MessageBox.Show("img1 está null");
                return;
            }

            imgbinary1 = BinarizarImagem(img1);

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {

                    Color pixel = imgbinary1.GetPixel(i, j);

                    Color cor = Color.Aqua;

                    if (pixel.R == 255)
                    {
                        cor = Color.Black;
                    }
                    else
                    {
                        cor = Color.White;
                    }

                    img3.SetPixel(i, j, cor);
                }
            }

            pictureBox3.Image = img3;
            Tx_Resolution_Update();
        }

        private void btXor_Click(object sender, EventArgs e)
        {
            img3 = new Bitmap(img1.Width, img1.Height);

            if (img1 == null)
            {
                MessageBox.Show("img1 está null");
                return;
            }

            imgbinary1 = BinarizarImagem(img1);

            if (img2 == null)
            {
                MessageBox.Show("img2 está null");
                return;
            }

            imgbinary2 = BinarizarImagem(img2);

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {

                    Color pixel = imgbinary1.GetPixel(i, j);
                    Color pixel2 = imgbinary2.GetPixel(i, j);

                    Color cor = Color.Aqua;

                    if ((pixel.R == 255 && pixel2.R != 255) || (pixel.R != 255 && pixel2.R == 255))
                    {
                        cor = Color.White;
                    }
                    else
                    {
                        cor = Color.Black;
                    }

                    img3.SetPixel(i, j, cor);
                }
            }

            pictureBox3.Image = img3;
            Tx_Resolution_Update();
        }

        private void btSwap_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                imgR = new Bitmap(img1.Width, img1.Height);
                imgR = img1;
                img1 = img2;
                img2 = imgR;
            }
            else if (img2 != null)
            {
                imgR = new Bitmap(img2.Width, img2.Height);
                imgR = img2;
                img2 = img1;
                img1 = imgR;
            }

            pictureBox1.Image = img1;
            pictureBox2.Image = img2;
            Tx_Resolution_Update();
        }

        private void btSwitch3to1_Click(object sender, EventArgs e)
        {
            img1 = img3;

            pictureBox1.Image = img1;
            Tx_Resolution_Update();
        }

        private void btFlip90R_Click(object sender, EventArgs e)
        {
            if (img3 == null)
            {
                img3 = new Bitmap(img1.Height,img1.Width);

                if (img1 == null)
                {
                    MessageBox.Show("img1 está null");
                    return;
                }

                for (int i = 0; i < img1.Height; i++)
                {
                    for (int j = 0; j < img1.Width; j++)
                    {
                        Color pixel = img1.GetPixel(j, i);

                        Color cor = Color.FromArgb(
                            pixel.A,
                            pixel.R,
                            pixel.G,
                            pixel.B);

                        img3.SetPixel(img1.Height - i - 1, j, cor);
                    }
                }

                pictureBox3.Image = img3;
                Tx_Resolution_Update();
            }
            else
            {
                imgR = new Bitmap(img3.Height, img3.Width);

                for (int i = 0; i < img3.Height; i++)
                {
                    for (int j = 0; j < img3.Width; j++)
                    {
                        Color pixel = img3.GetPixel(j, i);

                        Color cor = Color.FromArgb(
                            pixel.A,
                            pixel.R,
                            pixel.G,
                            pixel.B);

                        imgR.SetPixel(img3.Height - i - 1, j, cor);
                    }
                }
                img3 = imgR;
                pictureBox3.Image = img3;
                Tx_Resolution_Update();
            }
        }

        private void btFlip90L_Click(object sender, EventArgs e)
        {
            if (img3 == null)
            {
                img3 = new Bitmap(img1.Height, img1.Width);

                if (img1 == null)
                {
                    MessageBox.Show("img1 está null");
                    return;
                }

                for (int i = 0; i < img1.Height; i++)
                {
                    for (int j = 0; j < img1.Width; j++)
                    {
                        Color pixel = img1.GetPixel(j, i);

                        Color cor = Color.FromArgb(
                            pixel.A,
                            pixel.R,
                            pixel.G,
                            pixel.B);

                        img3.SetPixel(i, img1.Width - j - 1, cor);
                    }
                }

                pictureBox3.Image = img3;
                Tx_Resolution_Update();
            }
            else
            {
                imgR = new Bitmap(img3.Height, img3.Width);

                for (int i = 0; i < img3.Height; i++)
                {
                    for (int j = 0; j < img3.Width; j++)
                    {
                        Color pixel = img3.GetPixel(j, i);

                        Color cor = Color.FromArgb(
                            pixel.A,
                            pixel.R,
                            pixel.G,
                            pixel.B);

                        imgR.SetPixel(i, img3.Width - j - 1, cor);
                    }
                }
                img3 = imgR;
                pictureBox3.Image = img3;
                Tx_Resolution_Update();
            }
        }

        private void btEqualize_Click(object sender, EventArgs e)
        {
            img3 = new Bitmap(img1.Width, img1.Height);

            histogram1 = new int[256];
            histogram2 = new int[256];
            CFD = new int[256];

            for (int i = 0; i < img1.Height; i++)
            {
                for (int j = 0; j < img1.Width; j++)
                {
                    Color pixel = img1.GetPixel(j, i);

                    int value = (pixel.R + pixel.G + pixel.B)/3;

                    histogram1[value]++;
                }
            }

            UpdateHistogramChart();

            for (int i = 0; i < 256; i++)
            {
                if(i == 0)
                {
                    CFD[i] = histogram1[i];
                }
                else
                {
                    CFD[i] = CFD[i - 1] + histogram1[i];
                }
            }

            for (int i = 0; i < img1.Height; i++)
            {
                for (int j = 0; j < img1.Width; j++)
                {
                    Color pixel = img1.GetPixel(j, i);

                    int value = (pixel.R + pixel.G + pixel.B) / 3;

                    int v = (int)Math.Floor((double)(CFD[value] - CFD[0]) / ((img1.Height * img1.Width) - CFD[0]) * 255);

                    Color cor = Color.FromArgb(v,v,v);

                    img3.SetPixel(j, i, cor);
                }
            }

            for (int i = 0; i < img3.Height; i++)
            {
                for (int j = 0; j < img3.Width; j++)
                {
                    Color pixel = img3.GetPixel(j, i);

                    int value = (pixel.R + pixel.G + pixel.B) / 3;

                    histogram2[value]++;
                }
            }

            UpdateHistogramChart2();
            pictureBox3.Image = img3;
            Tx_Resolution_Update();
        }

        void UpdateHistogramChart()
        {
            chHistogram1.Series.Clear();

            var serie = new System.Windows.Forms.DataVisualization.Charting.Series();
            serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            for (int i = 0; i < 256; i++)
            {
                serie.Points.AddXY(i, histogram1[i]);
            }

            chHistogram1.Series.Add(serie);
        }

        void UpdateHistogramChart2()
        {
            chHistogram2.Series.Clear();

            var serie = new System.Windows.Forms.DataVisualization.Charting.Series();
            serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            for (int i = 0; i < 256; i++)
            {
                serie.Points.AddXY(i, histogram2[i]);
            }

            chHistogram2.Series.Add(serie);
        }

        
    }
}