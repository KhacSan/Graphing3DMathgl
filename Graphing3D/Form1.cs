using DevExpress.Utils.Svg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Graphing3D
{
     public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private double xMin,xMax ,yMin,yMax ;
        SvgBitmap btm;
        Paint paint = null;
        double xoayX = 33.0, xoayY = 24.0;

        public Form1()
        {
            InitializeComponent();
            listView2D.View = View.Details;
            listView2D.Columns.Add("X");
            listView2D.Columns.Add("Y");
            listView3D.View = View.Details;
            listView3D.Columns.Add("X");
            listView3D.Columns.Add("Y");
            listView3D.Columns.Add("Z");
            Control.CheckForIllegalCrossThreadCalls = false;
        }

       

        private void textBoxXMax2D_TextChanged(object sender, EventArgs e)
        {
            if (!Double.TryParse(textBoxXMax2D.Text, out xMax) && !textBoxXMax2D.Text.Equals(""))
            {
                textBoxXMax2D.Focus();
                textBoxInfo2D.Text = "Lỗi nhập sai kiểu dữ liệu, vui lòng nhập số!";
            }
            else
            {
                if (textBoxXMax2D.Text.Equals("")) textBoxInfo2D.Text = "Vui lòng nhập số!";
                else
                {
                    if (!textBoxXMin2D.Text.Equals("") && xMin >= xMax)
                    {
                        textBoxXMax2D.Focus();
                        textBoxInfo2D.Text = "Lỗi giá trị Min >= Max!";
                    }
                    else textBoxInfo2D.Text = "XMax = " + xMax.ToString();
                }
            }
        }

     

        private void textBoxXMin2D_TextChanged(object sender, EventArgs e)
        {
            if (!Double.TryParse(textBoxXMin2D.Text, out xMin) && !textBoxXMin2D.Text.Equals(""))
            {
                textBoxXMin2D.Focus();
                textBoxInfo2D.Text = "Lỗi nhập sai kiểu dữ liệu, vui lòng nhập số!";
            }
            else
            {
                if (textBoxXMin2D.Text.Equals("")) textBoxInfo2D.Text = "Vui lòng nhập số!";
                else
                {
                    if (!textBoxXMax2D.Text.Equals("") && xMin >= xMax)
                    {
                        textBoxXMin2D.Focus();
                        textBoxInfo2D.Text = "Lỗi giá trị Min >= Max!";
                    }
                    else textBoxInfo2D.Text = "XMin = " + xMin.ToString();
                }   
            }
        }


        private void textBoxXMin3D_TextChanged(object sender, EventArgs e)
        {
            if (!Double.TryParse(textBoxXMin3D.Text, out xMin) && !textBoxXMin3D.Text.Equals(""))
            {
                textBoxXMin3D.Focus();
                textBoxInfo3D.Text = "Lỗi nhập sai kiểu dữ liệu, vui lòng nhập số!";
            }
            else
            {
                if (textBoxXMin3D.Text.Equals("")) textBoxInfo3D.Text = "Vui lòng nhập số!";
                else
                {
                    if (!textBoxXMax3D.Text.Equals("") && xMin >= xMax)
                    {
                        textBoxXMin3D.Focus();
                        textBoxInfo3D.Text = "Lỗi giá trị Min >= Max!";
                    }
                    else textBoxInfo3D.Text = "XMin = " + xMin.ToString();
                }
            }
        }

        private void buttonPaint2D_Click(object sender, EventArgs e)
        {
            if(textBoxFxy.Text.Equals("") || textBoxXMin2D.Text.Equals("") || textBoxXMax2D.Text.Equals(""))
            {
                const string message = "Vui lòng nhập đủ thông tin!";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
                if(result == DialogResult.OK)
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
                if(!Double.TryParse(textBoxXMin2D.Text,out xMin) || !Double.TryParse(textBoxXMax2D.Text, out xMax))
                {
                    const string message = "Vui lòng nhập số!";
                    const string caption = "Error";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                        if (!Double.TryParse(textBoxXMin2D.Text, out xMin))
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
                    if(xMin >= xMax)
                    {
                        MessageBox.Show("Vui lòng nhập X: Min < Max !");
                        textBoxXMin2D.Focus();
                    }
                    else
                    {
                        Thread thread = new Thread(paint2d);
                        thread.IsBackground = true;
                        thread.Start();
                    }     
                }
            }
        }

        private void paint2d()
        {
            paint = new Paint();
            paint.Paint2D(xMin, xMax, listView2D, textBoxFxy.Text);
            btm = SvgBitmap.FromFile(@"C:\Users\San\Desktop\Graphing3D\Graphing3D\bin\Debug\demo2d.svg");
            pictureBox2D.Image = btm.Render(null, 1);
        }

        private void paint3d()
        {
            paint = new Paint();
            paint.Paint3D(xMin, xMax, yMin, yMax, listView3D, textBoxFxyz.Text, xoayX, xoayY);
            btm = SvgBitmap.FromFile(@"C:\Users\San\Desktop\Graphing3D\Graphing3D\bin\Debug\demo3d.svg");
            pictureBox3D.Image = btm.Render(null, 1);
        }

        private void buttonPaint3D_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(paint3d);
            thread.IsBackground = true;
            thread.Start();
        }

        private void textBoxXMax3D_TextChanged(object sender, EventArgs e)
        {
            if (!Double.TryParse(textBoxXMax3D.Text, out xMax) && !textBoxXMax3D.Text.Equals(""))
            {
                textBoxXMax3D.Focus();
                textBoxInfo3D.Text = "Lỗi nhập sai kiểu dữ liệu, vui lòng nhập số!";
            }
            else
            {
                if (textBoxXMax3D.Text.Equals("")) textBoxInfo3D.Text = "Vui lòng nhập số!";
                else
                {
                    if (!textBoxXMin3D.Text.Equals("") && xMin >= xMax)
                    {
                        textBoxXMax3D.Focus();
                        textBoxInfo3D.Text = "Lỗi giá trị Min >= Max!";
                    }
                    else textBoxInfo3D.Text = "XMax = " + xMax.ToString();
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
