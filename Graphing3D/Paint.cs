using Ciloci.Flee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphing3D
{
    unsafe class Paint
    {
        [DllImport("C:\\Users\\San\\Desktop\\plplot\\build\\dll\\Debug\\plplot.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void c_plinit();
        [DllImport("C:\\Users\\San\\Desktop\\plplot\\build\\dll\\Debug\\plplot.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void plMinMax2dGrid(double** z, int nx, int ny, ref double fmax, ref double fmin);
        [DllImport("C:\\Users\\San\\Desktop\\plplot\\build\\dll\\Debug\\plplot.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void c_plscmap1n(int ncol1);
        [DllImport("C:\\Users\\San\\Desktop\\plplot\\build\\dll\\Debug\\plplot.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void c_plscmap1l(int itype, int npts, double[] intensity,
             double[] coord1, double[] coord2, double[] coord3, int[] alt_hue_path);
        [DllImport("C:\\Users\\San\\Desktop\\plplot\\build\\dll\\Debug\\plplot.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void c_pladv(int page);
        [DllImport("C:\\Users\\San\\Desktop\\plplot\\build\\dll\\Debug\\plplot.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void c_plcol0(int icol0);
        [DllImport("C:\\Users\\San\\Desktop\\plplot\\build\\dll\\Debug\\plplot.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void c_plvpor(double xmin, double xmax, double ymin, double ymax);
        [DllImport("C:\\Users\\San\\Desktop\\plplot\\build\\dll\\Debug\\plplot.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void c_plwind(double xmin, double xmax, double ymin, double ymax);
        [DllImport("C:\\Users\\San\\Desktop\\plplot\\build\\dll\\Debug\\plplot.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void c_plw3d(double basex, double basey, double height, double xmin, double xmax,
                                                            double ymin, double ymax, double zmin, double zmax, double alt, double az);
        [DllImport("C:\\Users\\San\\Desktop\\plplot\\build\\dll\\Debug\\plplot.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void c_plbox3(string xopt, string xlabel, double xtick, int nxsub,
                                                              string yopt, string ylabel, double ytick, int nysub,
                                                              string zopt, string zlabel, double ztick, int nzsub);
        [DllImport("C:\\Users\\San\\Desktop\\plplot\\build\\dll\\Debug\\plplot.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void c_plmeshc(double[] x, double[] y, double** z, int nx, int ny, int opt, double[] clevel, int nlevel);
        [DllImport("C:\\Users\\San\\Desktop\\plplot\\build\\dll\\Debug\\plplot.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void c_plmtex(string side, double disp, double pos, double just, string text);
        [DllImport("C:\\Users\\San\\Desktop\\plplot\\build\\dll\\Debug\\plplot.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void c_plend();

        [DllImport("C:\\Users\\San\\Desktop\\plplot\\build\\dll\\Debug\\plplot.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void c_plsdev(string devname);

        [DllImport("C:\\Users\\San\\Desktop\\plplot\\build\\dll\\Debug\\plplot.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void plFree2dGrid(double** f, int nx, int ny);

        [DllImport("C:\\Users\\San\\Desktop\\plplot\\build\\dll\\Debug\\plplot.dll", CallingConvention = CallingConvention.Cdecl)]
        protected static extern int plAlloc2dGrid(ref double** f, int nx, int ny);

        [DllImport("C:\\Users\\San\\Desktop\\plplot\\build\\dll\\Debug\\plplot.dll", CallingConvention = CallingConvention.Cdecl)]
        protected static extern int c_plsfnam(String fnam);

        [DllImport("C:\\Users\\San\\Desktop\\plplot-5.13.0\\Build_New\\dll\\Debug\\plplot.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void c_plline(int n, double[] x, double[] y);

        [DllImport("C:\\Users\\San\\Desktop\\plplot-5.13.0\\Build_New\\dll\\Debug\\plplot.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void c_plenv(double xmin, double xmax, double ymin, double ymax, int just, int axis);

        [DllImport("C:\\Users\\San\\Desktop\\plplot-5.13.0\\Build_New\\dll\\Debug\\plplot.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void c_pllab(string xlabel, string ylabel, string tlabel);

        const int LEVELS = 5;
        const int DRAW_LINEXY = 3; // draw lines parallel to both the X and Y axis
        const int MAG_COLOR = 4;  // draw the mesh with a color dependent of the magnitude
        const int BASE_CONT = 8; // draw contour plot at bottom xy plane

        static void cmap1_init()
        {
            double[] i = new double[2]; double[] h = new double[2];
            double[] l = new double[2]; double[] s = new double[2];

            i[0] = 0.0;         // left boundary
            i[1] = 1.0;         // right boundary

            h[0] = 240;         // blue -> green -> yellow ->
            h[1] = 0;           // -> red

            l[0] = 0.6;
            l[1] = 0.6;

            s[0] = 0.8;
            s[1] = 0.8;

            c_plscmap1n(256);
            c_plscmap1l(0, 2, i, h, l, s, null);
        }


        public void Paint2D(double xMin,double xMax,ListView list,String funtion2D)
        {
            double yMin = 10000, yMax = -10000;
            int NSIZE = (int)(xMax - xMin) * 10;
            double[] x = new double[NSIZE];
            double[] y = new double[NSIZE];

            double step = (double)(xMax - xMin) / (double)NSIZE;

            int i;
            for (i = 0; i < NSIZE; i++)
            {
                x[i] = xMin + (double)(i) * step;
                // Define the context of our expression
                ExpressionContext context = new ExpressionContext();
                // Allow the expression to use all static public methods of System.Math
                context.Imports.AddType(typeof(Math));
                // Define an int variable
                context.Variables["x"] = x[i];
                IGenericExpression<double> eGeneric = context.CompileGeneric<double>(funtion2D);
                // Evaluate the expressions
                y[i] = eGeneric.Evaluate();

                loadListView(x[i], y[i], list);

                if (yMax < y[i]) yMax = y[i];
                if (yMin > y[i]) yMin = y[i];
            }
            c_plsfnam("demo2d.svg");
            c_plsdev("svg");
            c_plinit();

            //c_pladv(1);
            c_plcol0(1);

            c_plenv(xMin, xMax, yMin, yMax, 0, 0);
            c_pllab("x", "y=100 x#u2#d", "Simple PLplot demo of a 2D line plot");

            // Plot the data that was prepared above.
            c_plline(NSIZE, x, y);

            // Close PLplot library
            c_plend();

        }

        public void Paint3D(double xmin, double xmax, double ymin, double ymax,ListView list, String funtion3D, double xoayX, double xoayY)
        {
            int XPTS = (int)((xmax - xmin) * 2);          // so diem muon ve tren truc x
            int YPTS = (int)((ymax - ymin) * 2);           //
            int i, j;
            int nlevel = LEVELS;
            double[] clevel = new double[LEVELS];
            double zmin = 1;
            double zmax = 1;
            double step = 0;

            double[] x = new double[XPTS];
            double[] y = new double[YPTS];
            double** z = null;
            plAlloc2dGrid(ref z, XPTS, YPTS);

            double stepx = (xmax - xmin) / XPTS;
            double stepy = (ymax - ymin) / YPTS;
            for (i = 0; i < XPTS; i++)
            {
                x[i] = xmin + i * stepx;
            }

            for (i = 0; i < YPTS; i++)
            {
                y[i] = ymin + i * stepy;
            }

            for (i = 0; i < XPTS; i++)
            {
                for (j = 0; j < YPTS; j++)
                {
                    ExpressionContext context = new ExpressionContext();
                    // Allow the expression to use all static public methods of System.Math
                    context.Imports.AddType(typeof(Math));
                    // Define an int variable
                    context.Variables["x"] = x[i];
                    context.Variables["y"] = y[j];
                    IGenericExpression<double> eGeneric = context.CompileGeneric<double>(funtion3D);
                    // Evaluate the expressions
                    z[i][j] = (double)eGeneric.Evaluate();

                    loadListView(x[i], y[i], z[i][j],list);
                }
            }
            plMinMax2dGrid(z, XPTS, YPTS, ref zmax, ref zmin);
            step = (zmax - zmin) / (nlevel + 1);
            for (i = 0; i < nlevel; i++)

            c_plsfnam("demo3d.svg");
            c_plsdev("svg");
            c_plinit();
            cmap1_init();

            c_plcol0(7);
            c_plenv(-1, 1, -0.7, 1.3, 0, -2);
            c_plw3d(1.0, 1.0, 1.0, xmin, xmax, ymin, ymax, zmin, zmax, xoayX, xoayY);

            c_plcol0(7);
            c_plbox3("bnstu", "x axis", 0.0, 0, "bnstu", "y axis", 0.0, 0, "bcdmnstuv", "z axis", 0.0, 4);
            c_plmeshc(x, y, z, XPTS, YPTS, DRAW_LINEXY | MAG_COLOR | BASE_CONT, clevel, nlevel);

            c_plcol0(15);
            c_plmtex("t", 1, 0.5, 0.5, "#frDo thi: z=" + funtion3D);

            plFree2dGrid(z, XPTS, YPTS);
            c_plend();
        }

        private void loadListView(double x, double y, ListView list)
        {
            ListViewItem item = new ListViewItem();
            item.Text = x.ToString();
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = y.ToString() });
            list.Items.Add(item);
        }

        private void loadListView(double x, double y, double z, ListView list)
        {
            ListViewItem item = new ListViewItem();
            item.Text = x.ToString();
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = y.ToString() });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = z.ToString() });
            list.Items.Add(item);
        }
    }
}
