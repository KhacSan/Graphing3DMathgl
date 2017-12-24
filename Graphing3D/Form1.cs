
using DevExpress.Utils.Svg;
using SharpVectors.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Graphing3D
{
    unsafe public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        [DllImport("D:\\DoAn2Mathgl\\Debug\\Example.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double* plotting1DArrays(string function, double xMin, double xMax);

        [DllImport("D:\\DoAn2Mathgl\\Debug\\Example.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double* plotting2DArrays(string function, double xMin, double xMax,
            double yMin, double yMax, double TetX, double TetZ, double TetY);

        [DllImport("D:\\DoAn2Mathgl\\Debug\\Example.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double* plotting3DArrays(string function, double xMin, double xMax,
            double yMin, double yMax, double zMin, double zMax, double TetX, double TetZ, double TetY);

        private double xMin2D, xMax2D, xMin3D, xMax3D, yMin, yMax, zMin, zMax;
        SvgBitmap btm;
        private int check;
        private double xoayQuanhOx = 50, xoayQuanhOz = 50;
        private Bitmap bitmap = null;
        private Bitmap bitmap2d = null;
        public Form1()
        {
            InitializeComponent();
            listView2D.View = View.Details;
            listView2D.Columns.Add("X", 70);
            listView2D.Columns.Add("Y", 70);
            listView3D.View = View.Details;
            listView3D.Columns.Add("X", 50);
            listView3D.Columns.Add("Y", 50);
            listView3D.Columns.Add("Z", 50);
            Double.TryParse(textBoxXMin2D.Text, out xMin2D);
            Double.TryParse(textBoxXMax2D.Text, out xMax2D);
            Double.TryParse(textBoxXMin3D.Text, out xMin3D);
            Double.TryParse(textBoxXMax3D.Text, out xMax3D);
            Double.TryParse(textBoxYMin3D.Text, out yMin);
            Double.TryParse(textBoxYMax3D.Text, out yMax);
            Double.TryParse(textBoxZMin.Text, out zMin);
            Double.TryParse(textBoxZMax.Text, out zMax);
            textBoxZMin.Visible = false;
            textBoxZMax.Visible = false;
            labelZ.Visible = false;
            labelZmin.Visible = false;
            labelZmax.Visible = false;
            check = 0;
        }

        private void textBoxXMax2D_TextChanged(object sender, EventArgs e)
        {
            if (!Double.TryParse(textBoxXMax2D.Text, out xMax2D) && !textBoxXMax2D.Text.Equals(""))
            {
                textBoxXMax2D.Focus();
                textBoxInfo2D.Text = "Lỗi nhập sai kiểu dữ liệu, vui lòng nhập số!";
            }
            else
            {
                if (textBoxXMax2D.Text.Equals("")) textBoxInfo2D.Text = "Vui lòng nhập số!";
                else
                {
                    if (!textBoxXMin2D.Text.Equals("") && xMin2D >= xMax2D)
                    {
                        textBoxXMax2D.Focus();
                        textBoxInfo2D.Text = "Lỗi giá trị Min >= Max!";
                    }
                    else textBoxInfo2D.Text = "XMax = " + xMax2D.ToString();
                }
            }
        }

        private void textBoxXMin2D_TextChanged(object sender, EventArgs e)
        {
            if (!Double.TryParse(textBoxXMin2D.Text, out xMin2D) && !textBoxXMin2D.Text.Equals(""))
            {
                textBoxXMin2D.Focus();
                textBoxInfo2D.Text = "Lỗi nhập sai kiểu dữ liệu, vui lòng nhập số!";
            }
            else
            {
                if (textBoxXMin2D.Text.Equals("")) textBoxInfo2D.Text = "Vui lòng nhập số!";
                else
                {
                    if (!textBoxXMax2D.Text.Equals("") && xMin2D >= xMax2D)
                    {
                        textBoxXMin2D.Focus();
                        textBoxInfo2D.Text = "Lỗi giá trị Min >= Max!";
                    }
                    else textBoxInfo2D.Text = "XMin = " + xMin2D.ToString();
                }
            }
        }


        private void textBoxXMin3D_TextChanged(object sender, EventArgs e)
        {
            if (!Double.TryParse(textBoxXMin3D.Text, out xMin3D) && !textBoxXMin3D.Text.Equals(""))
            {
                textBoxXMin3D.Focus();
                textBoxInfo3D.Text = "Lỗi nhập sai kiểu dữ liệu, vui lòng nhập số!";
            }
            else
            {
                if (textBoxXMin3D.Text.Equals("")) textBoxInfo3D.Text = "Vui lòng nhập số!";
                else
                {
                    if (!textBoxXMax3D.Text.Equals("") && xMin3D >= xMax3D)
                    {
                        textBoxXMin3D.Focus();
                        textBoxInfo3D.Text = "Lỗi giá trị Min >= Max!";
                    }
                    else textBoxInfo3D.Text = "XMin = " + xMin3D.ToString();
                }
            }
        }

        public void renderPicture2D()
        {
            try
            {
                bitmap2d = (Bitmap)Image.FromFile(Application.StartupPath + "\\test1d.bmp", true);
                pictureBox2D.Image = bitmap2d;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("There was an error." +
                    "Check the path to the image file.");
            }

        }

        public void renderPicture3D(double* data, int type)
        {
            try
            {
                bitmap = new Bitmap(Application.StartupPath + "\\test3d.bmp", true);
                pictureBox3D.Image = bitmap;
                if (check == 0 & type == 0)
                {
                    double step1 = (xMax3D - xMin3D) / (101 - 1.0);
                    double step2 = (yMax - yMin) / (101 - 1.0);
                    double step3 = (zMax - zMin) / (100 - 1.0);
                    for (int i = 0; i < 101; i++)
                        for (int j = 0; j < 101; j++)
                            for (int k = 0; k < 100; k++)
                            {
                                int i0 = i + 101 * (j + 101 * k);
                                if (-0.01 <= data[i0] && data[i0] <= 0.01)
                                {//sai so =0.01
                                    loadListView(xMin3D + i * step1, yMin + j * step2, zMin + k * step3);
                                }
                            }
                }
                if (check == 0 && type == 1)
                {
                    double step1 = (xMax3D - xMin3D) / (101 - 1.0);
                    double step2 = (yMax - yMin) / (101 - 1.0);
                    for (int i = 0; i < 101; i += 5)
                        for (int j = 0; j < 101; j += 5)
                        {
                            int i0 = i * 101 + j;
                            loadListView(xMin3D + i * step1, yMin + j * step2, data[i0]);
                        }
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("There was an error." +
                    "Check the path to the image file.");
            }
        }

        private void buttonPaint2D_Click(object sender, EventArgs e)
        {
            if (textBoxFxy.Text.Equals("") || textBoxXMin2D.Text.Equals("") || textBoxXMax2D.Text.Equals(""))
            {
                const string message = "Vui lòng nhập đủ thông tin!";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    if (textBoxFxy.Text.Equals(""))
                    {
                        textBoxFxy.Focus();
                    }
                    else
                    {
                        if (textBoxXMin2D.Text.Equals(""))
                        {
                            textBoxXMin2D.Focus();
                        }
                        else
                        {
                            textBoxXMax2D.Focus();
                        }
                    }
                }
            }
            else
            {
                if (!Double.TryParse(textBoxXMin2D.Text, out xMin2D) || !Double.TryParse(textBoxXMax2D.Text, out xMax2D))
                {
                    const string message = "Vui lòng nhập số!";
                    const string caption = "Error";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                        if (!Double.TryParse(textBoxXMin2D.Text, out xMin2D))
                        {
                            textBoxXMin2D.Focus();
                            textBoxXMin2D.Text = "";
                        }
                        else
                        {
                            textBoxXMax2D.Focus();
                            textBoxXMax2D.Text = "";
                        }
                    }
                }
                else
                {
                    if (xMin2D >= xMax2D)
                    {
                        MessageBox.Show("Vui lòng nhập X: Min < Max !");
                        textBoxXMin2D.Focus();
                    }
                    else
                    {
                        listView2D.Items.Clear();
                        paint2d();
                    }
                }
            }
        }

        private void xoayXNguoc_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                xoayQuanhOz -= 20.0;
                paint3d();
            }
        }

        private void xoayYNguoc_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                xoayQuanhOx -= 10.0;
                paint3d();
            }
        }

        private void xoayYXuoi_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                xoayQuanhOx += 10.0;
                paint3d();
            }
        }


        private void xoayXXuoi_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                xoayQuanhOz += 10.0;
                paint3d();
            }
        }

        private void textBoxFxyz_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFxyz.Text.Contains("z") || textBoxFxyz.Text.Contains("Z"))
            {
                textBoxZMin.Visible = true;
                textBoxZMax.Visible = true;
                labelZ.Visible = true;
                labelZmin.Visible = true;
                labelZmax.Visible = true;
            }
            else
            {
                textBoxZMin.Visible = false;
                textBoxZMax.Visible = false;
                labelZ.Visible = false;
                labelZmin.Visible = false;
                labelZmax.Visible = false;
            }
        }

        private void textBoxZMin_TextChanged(object sender, EventArgs e)
        {
            if (!Double.TryParse(textBoxZMin.Text, out zMin) && !textBoxZMin.Text.Equals(""))
            {
                textBoxZMin.Focus();
                textBoxInfo3D.Text = "Lỗi nhập sai kiểu dữ liệu, vui lòng nhập số!";
            }
            else
            {
                if (textBoxZMin.Text.Equals("")) textBoxInfo3D.Text = "Vui lòng nhập số!";
                else
                {
                    if (!textBoxZMin.Text.Equals("") && zMin >= zMax)
                    {
                        textBoxZMin.Focus();
                        textBoxInfo3D.Text = "Lỗi giá trị Min >= Max!";
                    }
                    else textBoxInfo3D.Text = "XMin = " + zMin.ToString();
                }
            }
        }

        private void textBoxZMax_TextChanged(object sender, EventArgs e)
        {
            if (!Double.TryParse(textBoxZMax.Text, out zMax) && !textBoxZMax.Text.Equals(""))
            {
                textBoxZMax.Focus();
                textBoxInfo3D.Text = "Lỗi nhập sai kiểu dữ liệu, vui lòng nhập số!";
            }
            else
            {
                if (textBoxZMax.Text.Equals("")) textBoxInfo3D.Text = "Vui lòng nhập số!";
                else
                {
                    if (!textBoxZMax.Text.Equals("") && zMin >= zMax)
                    {
                        textBoxZMax.Focus();
                        textBoxInfo3D.Text = "Lỗi giá trị Min >= Max!";
                    }
                    else textBoxInfo3D.Text = "XMin = " + zMax.ToString();
                }
            }
        }
        private void loadListView(double x, double y)
        {
            String[] row = { x.ToString(), y.ToString() };
            ListViewItem item = new ListViewItem(row);
            listView2D.Items.Add(item);
        }
        private void loadListView(double x, double y, double z)
        {
            String[] row = { x.ToString(), y.ToString(), z.ToString() };
            ListViewItem item = new ListViewItem(row);
            listView3D.Items.Add(item);
        }

        private void paint2d()
        {
            if (bitmap2d != null)
            {
                bitmap2d.Dispose();
            }
            double* data = plotting1DArrays(textBoxFxy.Text.ToString(), xMin2D, xMax2D);
            renderPicture2D();
            double xx = (xMax2D - xMin2D) / 100;
            for (int i = 0; i < 101; i++)
            {
                loadListView(xMin2D + i * xx, data[i]);
            }
        }

        private void paint3d()
        {
            if (bitmap != null)
            {
                bitmap.Dispose();
            }

            if (textBoxFxyz.Text.Contains("z") || textBoxFxyz.Text.Contains("Z"))
            {
                double* data = plotting3DArrays(textBoxFxyz.Text, xMin3D, xMax3D, yMin, yMax, zMin, zMax, xoayQuanhOx, xoayQuanhOz, 0);
                renderPicture3D(data, 0);
            }
            else
            {
                double* data = plotting2DArrays(textBoxFxyz.Text, xMin3D, xMax3D, yMin, yMax, xoayQuanhOx, xoayQuanhOz, 0);
                renderPicture3D(data, 1);
            }
            check = 1;
        }

        private void buttonPaint3D_Click(object sender, EventArgs e)
        {

            if (textBoxFxyz.Text.Equals("") || textBoxXMin3D.Text.Equals("") || textBoxXMax3D.Text.Equals("")
                || textBoxYMin3D.Text.Equals("") || textBoxYMax3D.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !");
            }
            else
            {
                if (!Double.TryParse(textBoxXMin3D.Text, out xMin3D) || !Double.TryParse(textBoxXMax3D.Text, out xMax3D)
                   || !Double.TryParse(textBoxYMin3D.Text, out yMin) || !Double.TryParse(textBoxYMax3D.Text, out yMax))
                {
                    MessageBox.Show("Lỗi nhập sai kiểu dữ liệu !");
                }
                else
                {
                    if (xMin3D >= xMax3D || yMin >= yMax)
                    {
                        MessageBox.Show("Lỗi nhập giá trị Min >= Max !");
                    }
                    else
                    {
                        check = 0;
                        listView3D.Items.Clear();
                        paint3d();
                    }
                }
            }
        }

        private void textBoxXMax3D_TextChanged(object sender, EventArgs e)
        {
            if (!Double.TryParse(textBoxXMax3D.Text, out xMax3D) && !textBoxXMax3D.Text.Equals(""))
            {
                textBoxXMax3D.Focus();
                textBoxInfo3D.Text = "Lỗi nhập sai kiểu dữ liệu, vui lòng nhập số!";
            }
            else
            {
                if (textBoxXMax3D.Text.Equals("")) textBoxInfo3D.Text = "Vui lòng nhập số!";
                else
                {
                    if (!textBoxXMin3D.Text.Equals("") && xMin3D >= xMax3D)
                    {
                        textBoxXMax3D.Focus();
                        textBoxInfo3D.Text = "Lỗi giá trị Min >= Max!";
                    }
                    else textBoxInfo3D.Text = "XMax = " + xMax3D.ToString();
                }
            }
        }

        private void textBoxYMin3D_TextChanged(object sender, EventArgs e)
        {
            if (!Double.TryParse(textBoxYMin3D.Text, out yMin) && !textBoxYMin3D.Text.Equals(""))
            {
                textBoxYMin3D.Focus();
                textBoxInfo3D.Text = "Lỗi nhập sai kiểu dữ liệu, vui lòng nhập số!";
            }
            else
            {
                if (textBoxYMin3D.Text.Equals("")) textBoxInfo3D.Text = "Vui lòng nhập số!";
                else
                {
                    if (!textBoxYMax3D.Text.Equals("") && yMin >= yMax)
                    {
                        textBoxYMin3D.Focus();
                        textBoxInfo3D.Text = "Lỗi giá trị Min >= Max!";
                    }
                    else textBoxInfo3D.Text = "YMin = " + yMin.ToString();
                }
            }
        }

        private void textBoxYMax3D_TextChanged(object sender, EventArgs e)
        {
            if (!Double.TryParse(textBoxYMax3D.Text, out yMax) && !textBoxYMax3D.Text.Equals(""))
            {
                textBoxYMax3D.Focus();
                textBoxInfo3D.Text = "Lỗi nhập sai kiểu dữ liệu, vui lòng nhập số!";
            }
            else
            {
                if (textBoxYMax3D.Text.Equals("")) textBoxInfo3D.Text = "Vui lòng nhập số!";
                else
                {
                    if (!textBoxYMin3D.Text.Equals("") && yMin >= yMax)
                    {
                        textBoxYMax3D.Focus();
                        textBoxInfo3D.Text = "Lỗi giá trị Min >= Max!";
                    }
                    else textBoxInfo3D.Text = "YMax = " + yMax.ToString();
                }
            }
        }
    }
}
