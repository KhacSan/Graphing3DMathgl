﻿namespace Graphing3D
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2D = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxFxy = new System.Windows.Forms.TextBox();
            this.buttonPaint2D = new System.Windows.Forms.Button();
            this.textBoxXMax2D = new System.Windows.Forms.TextBox();
            this.textBoxXMin2D = new System.Windows.Forms.TextBox();
            this.textBoxInfo2D = new System.Windows.Forms.TextBox();
            this.listView2D = new System.Windows.Forms.ListView();
            this.pictureBox2D = new System.Windows.Forms.PictureBox();
            this.tabPage3D = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTurnY = new System.Windows.Forms.Button();
            this.buttonPaint3D = new System.Windows.Forms.Button();
            this.buttonTurnX = new System.Windows.Forms.Button();
            this.textBoxInfo3D = new System.Windows.Forms.TextBox();
            this.textBoxYMax3D = new System.Windows.Forms.TextBox();
            this.textBoxYMin3D = new System.Windows.Forms.TextBox();
            this.textBoxXMax3D = new System.Windows.Forms.TextBox();
            this.textBoxXMin3D = new System.Windows.Forms.TextBox();
            this.textBoxFxyz = new System.Windows.Forms.TextBox();
            this.listView3D = new System.Windows.Forms.ListView();
            this.pictureBox3D = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2D.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2D)).BeginInit();
            this.tabPage3D.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3D)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2D);
            this.tabControl1.Controls.Add(this.tabPage3D);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(824, 399);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2D
            // 
            this.tabPage2D.Controls.Add(this.label11);
            this.tabPage2D.Controls.Add(this.label10);
            this.tabPage2D.Controls.Add(this.label9);
            this.tabPage2D.Controls.Add(this.label8);
            this.tabPage2D.Controls.Add(this.textBoxFxy);
            this.tabPage2D.Controls.Add(this.buttonPaint2D);
            this.tabPage2D.Controls.Add(this.textBoxXMax2D);
            this.tabPage2D.Controls.Add(this.textBoxXMin2D);
            this.tabPage2D.Controls.Add(this.textBoxInfo2D);
            this.tabPage2D.Controls.Add(this.listView2D);
            this.tabPage2D.Controls.Add(this.pictureBox2D);
            this.tabPage2D.Location = new System.Drawing.Point(4, 22);
            this.tabPage2D.Name = "tabPage2D";
            this.tabPage2D.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2D.Size = new System.Drawing.Size(816, 373);
            this.tabPage2D.TabIndex = 0;
            this.tabPage2D.Text = "2D";
            this.tabPage2D.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Max:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Min:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "X:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "F(x,y):";
            // 
            // textBoxFxy
            // 
            this.textBoxFxy.Location = new System.Drawing.Point(6, 124);
            this.textBoxFxy.Name = "textBoxFxy";
            this.textBoxFxy.Size = new System.Drawing.Size(139, 21);
            this.textBoxFxy.TabIndex = 6;
            // 
            // buttonPaint2D
            // 
            this.buttonPaint2D.Location = new System.Drawing.Point(48, 33);
            this.buttonPaint2D.Name = "buttonPaint2D";
            this.buttonPaint2D.Size = new System.Drawing.Size(50, 30);
            this.buttonPaint2D.TabIndex = 5;
            this.buttonPaint2D.Text = "Paint";
            this.buttonPaint2D.UseVisualStyleBackColor = true;
            this.buttonPaint2D.Click += new System.EventHandler(this.buttonPaint2D_Click);
            // 
            // textBoxXMax2D
            // 
            this.textBoxXMax2D.Location = new System.Drawing.Point(64, 212);
            this.textBoxXMax2D.Name = "textBoxXMax2D";
            this.textBoxXMax2D.Size = new System.Drawing.Size(81, 21);
            this.textBoxXMax2D.TabIndex = 4;
            this.textBoxXMax2D.TextChanged += new System.EventHandler(this.textBoxXMax2D_TextChanged);
            // 
            // textBoxXMin2D
            // 
            this.textBoxXMin2D.Location = new System.Drawing.Point(64, 168);
            this.textBoxXMin2D.Name = "textBoxXMin2D";
            this.textBoxXMin2D.Size = new System.Drawing.Size(81, 21);
            this.textBoxXMin2D.TabIndex = 3;
            this.textBoxXMin2D.TextChanged += new System.EventHandler(this.textBoxXMin2D_TextChanged);
            // 
            // textBoxInfo2D
            // 
            this.textBoxInfo2D.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxInfo2D.Enabled = false;
            this.textBoxInfo2D.Location = new System.Drawing.Point(6, 329);
            this.textBoxInfo2D.Multiline = true;
            this.textBoxInfo2D.Name = "textBoxInfo2D";
            this.textBoxInfo2D.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInfo2D.Size = new System.Drawing.Size(139, 38);
            this.textBoxInfo2D.TabIndex = 2;
            // 
            // listView2D
            // 
            this.listView2D.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView2D.FullRowSelect = true;
            this.listView2D.HoverSelection = true;
            this.listView2D.Location = new System.Drawing.Point(151, 0);
            this.listView2D.Name = "listView2D";
            this.listView2D.Size = new System.Drawing.Size(150, 373);
            this.listView2D.TabIndex = 1;
            this.listView2D.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox2D
            // 
            this.pictureBox2D.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2D.Location = new System.Drawing.Point(311, 0);
            this.pictureBox2D.Name = "pictureBox2D";
            this.pictureBox2D.Size = new System.Drawing.Size(505, 373);
            this.pictureBox2D.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2D.TabIndex = 0;
            this.pictureBox2D.TabStop = false;
            // 
            // tabPage3D
            // 
            this.tabPage3D.Controls.Add(this.label7);
            this.tabPage3D.Controls.Add(this.label6);
            this.tabPage3D.Controls.Add(this.label5);
            this.tabPage3D.Controls.Add(this.label4);
            this.tabPage3D.Controls.Add(this.label3);
            this.tabPage3D.Controls.Add(this.label2);
            this.tabPage3D.Controls.Add(this.label1);
            this.tabPage3D.Controls.Add(this.buttonTurnY);
            this.tabPage3D.Controls.Add(this.buttonPaint3D);
            this.tabPage3D.Controls.Add(this.buttonTurnX);
            this.tabPage3D.Controls.Add(this.textBoxInfo3D);
            this.tabPage3D.Controls.Add(this.textBoxYMax3D);
            this.tabPage3D.Controls.Add(this.textBoxYMin3D);
            this.tabPage3D.Controls.Add(this.textBoxXMax3D);
            this.tabPage3D.Controls.Add(this.textBoxXMin3D);
            this.tabPage3D.Controls.Add(this.textBoxFxyz);
            this.tabPage3D.Controls.Add(this.listView3D);
            this.tabPage3D.Controls.Add(this.pictureBox3D);
            this.tabPage3D.Location = new System.Drawing.Point(4, 22);
            this.tabPage3D.Name = "tabPage3D";
            this.tabPage3D.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3D.Size = new System.Drawing.Size(816, 373);
            this.tabPage3D.TabIndex = 1;
            this.tabPage3D.Text = "3D";
            this.tabPage3D.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Max:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Min:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Max:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Min:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "F(z,y,z):";
            // 
            // buttonTurnY
            // 
            this.buttonTurnY.Location = new System.Drawing.Point(18, 53);
            this.buttonTurnY.Name = "buttonTurnY";
            this.buttonTurnY.Size = new System.Drawing.Size(50, 30);
            this.buttonTurnY.TabIndex = 10;
            this.buttonTurnY.Text = "Y";
            this.buttonTurnY.UseVisualStyleBackColor = true;
            // 
            // buttonPaint3D
            // 
            this.buttonPaint3D.Location = new System.Drawing.Point(50, 17);
            this.buttonPaint3D.Name = "buttonPaint3D";
            this.buttonPaint3D.Size = new System.Drawing.Size(50, 30);
            this.buttonPaint3D.TabIndex = 9;
            this.buttonPaint3D.Text = "Paint";
            this.buttonPaint3D.UseVisualStyleBackColor = true;
            this.buttonPaint3D.Click += new System.EventHandler(this.buttonPaint3D_Click);
            // 
            // buttonTurnX
            // 
            this.buttonTurnX.Location = new System.Drawing.Point(86, 53);
            this.buttonTurnX.Name = "buttonTurnX";
            this.buttonTurnX.Size = new System.Drawing.Size(50, 30);
            this.buttonTurnX.TabIndex = 8;
            this.buttonTurnX.Text = "X";
            this.buttonTurnX.UseVisualStyleBackColor = true;
            // 
            // textBoxInfo3D
            // 
            this.textBoxInfo3D.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxInfo3D.Enabled = false;
            this.textBoxInfo3D.Location = new System.Drawing.Point(6, 329);
            this.textBoxInfo3D.Multiline = true;
            this.textBoxInfo3D.Name = "textBoxInfo3D";
            this.textBoxInfo3D.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInfo3D.Size = new System.Drawing.Size(139, 38);
            this.textBoxInfo3D.TabIndex = 7;
            // 
            // textBoxYMax3D
            // 
            this.textBoxYMax3D.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxYMax3D.Location = new System.Drawing.Point(64, 292);
            this.textBoxYMax3D.Name = "textBoxYMax3D";
            this.textBoxYMax3D.Size = new System.Drawing.Size(81, 21);
            this.textBoxYMax3D.TabIndex = 6;
            this.textBoxYMax3D.TextChanged += new System.EventHandler(this.textBoxYMax3D_TextChanged);
            // 
            // textBoxYMin3D
            // 
            this.textBoxYMin3D.Location = new System.Drawing.Point(64, 256);
            this.textBoxYMin3D.Name = "textBoxYMin3D";
            this.textBoxYMin3D.Size = new System.Drawing.Size(81, 21);
            this.textBoxYMin3D.TabIndex = 5;
            this.textBoxYMin3D.TextChanged += new System.EventHandler(this.textBoxYMin3D_TextChanged);
            // 
            // textBoxXMax3D
            // 
            this.textBoxXMax3D.Location = new System.Drawing.Point(64, 212);
            this.textBoxXMax3D.Name = "textBoxXMax3D";
            this.textBoxXMax3D.Size = new System.Drawing.Size(81, 21);
            this.textBoxXMax3D.TabIndex = 4;
            this.textBoxXMax3D.TextChanged += new System.EventHandler(this.textBoxXMax3D_TextChanged);
            // 
            // textBoxXMin3D
            // 
            this.textBoxXMin3D.Location = new System.Drawing.Point(64, 168);
            this.textBoxXMin3D.Name = "textBoxXMin3D";
            this.textBoxXMin3D.Size = new System.Drawing.Size(81, 21);
            this.textBoxXMin3D.TabIndex = 3;
            this.textBoxXMin3D.TextChanged += new System.EventHandler(this.textBoxXMin3D_TextChanged);
            // 
            // textBoxFxyz
            // 
            this.textBoxFxyz.Location = new System.Drawing.Point(6, 124);
            this.textBoxFxyz.Name = "textBoxFxyz";
            this.textBoxFxyz.Size = new System.Drawing.Size(139, 21);
            this.textBoxFxyz.TabIndex = 2;
            // 
            // listView3D
            // 
            this.listView3D.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView3D.FullRowSelect = true;
            this.listView3D.HoverSelection = true;
            this.listView3D.Location = new System.Drawing.Point(151, 0);
            this.listView3D.Name = "listView3D";
            this.listView3D.Size = new System.Drawing.Size(150, 373);
            this.listView3D.TabIndex = 1;
            this.listView3D.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox3D
            // 
            this.pictureBox3D.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3D.Location = new System.Drawing.Point(311, 0);
            this.pictureBox3D.Name = "pictureBox3D";
            this.pictureBox3D.Size = new System.Drawing.Size(505, 373);
            this.pictureBox3D.TabIndex = 0;
            this.pictureBox3D.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 423);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(860, 460);
            this.Name = "Form1";
            this.Text = "Graphing Calculator 3D";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2D.ResumeLayout(false);
            this.tabPage2D.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2D)).EndInit();
            this.tabPage3D.ResumeLayout(false);
            this.tabPage3D.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3D)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3D;
        private System.Windows.Forms.TabPage tabPage2D;
        private System.Windows.Forms.PictureBox pictureBox2D;
        private System.Windows.Forms.ListView listView2D;
        private System.Windows.Forms.PictureBox pictureBox3D;
        private System.Windows.Forms.ListView listView3D;
        private System.Windows.Forms.TextBox textBoxFxy;
        private System.Windows.Forms.Button buttonPaint2D;
        private System.Windows.Forms.TextBox textBoxXMax2D;
        private System.Windows.Forms.TextBox textBoxXMin2D;
        private System.Windows.Forms.TextBox textBoxInfo2D;
        private System.Windows.Forms.Button buttonTurnY;
        private System.Windows.Forms.Button buttonPaint3D;
        private System.Windows.Forms.Button buttonTurnX;
        private System.Windows.Forms.TextBox textBoxInfo3D;
        private System.Windows.Forms.TextBox textBoxYMax3D;
        private System.Windows.Forms.TextBox textBoxYMin3D;
        private System.Windows.Forms.TextBox textBoxXMax3D;
        private System.Windows.Forms.TextBox textBoxXMin3D;
        private System.Windows.Forms.TextBox textBoxFxyz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}
