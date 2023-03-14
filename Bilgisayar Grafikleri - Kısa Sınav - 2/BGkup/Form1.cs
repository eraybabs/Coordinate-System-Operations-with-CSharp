using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGkup
{
    public partial class Form1 : Form
    {
        
        public Form1() // 1160505014 Umut ŞENTÜRK
        {
            InitializeComponent();
            
        }
        public static float x(float t)
        {
            return t * 100 + 550;
        }
        public static float y(float t)
        {
            return t * (-100) + 400;
        }
        
        
        public static float[,] eksenx = { { 0, 0, 0, 1 }, { 3.5f, 0, 0, 1 } };
        public static float[,] ekseny = { {0,0,0,1 },{ 0, 3, 0, 1 } };
        public static float[,] reeleksenx = new float[2, 4];
        public static float[,] reelekseny = new float[2, 4];
        //public static float[,] kup = new float[10, 4];
        public static float[,] Tizometrik = { { 0.707f  , -0.408f   ,0  ,0 },
                                              {0        , 0.816f    ,0  ,0 },
                                              {-0.707f  , -0.408f   ,0  ,0 },
                                              {0        , 0         ,0  ,1 } };
        public static float[,] Totele =     {   {1, 0, 0, 0},
                                                {0, 1, 0, 0},
                                                {0, 0, 1, 0},
                                                {0, 0, 0, 1},
        };
        
        public static float[,] Tolcekle =     { {1, 0, 0, 0},
                                                {0, 1, 0, 0},
                                                {0, 0, 1, 0},
                                                {0, 0, 0, 1},
        };
        public static float[,] Tyansit =     { {1, 0, 0, 0},
                                                {0, 1, 0, 0},
                                                {0, 0, 1, 0},
                                                {0, 0, 0, 1},
        };
        public static float[,] TdondurX =     {  {1, 0, 0, 0},
                                                {0, 1, 0, 0},
                                                {0, 0, 1, 0},
                                                {0, 0, 0, 1},
        };
        public static float[,] TdondurY =     {  {1, 0, 0, 0},
                                                {0, 1, 0, 0},
                                                {0, 0, 1, 0},
                                                {0, 0, 0, 1},
        };
        public static float[,] TdondurZ =     {  {1, 0, 0, 0},
                                                {0, 1, 0, 0},
                                                {0, 0, 1, 0},
                                                {0, 0, 0, 1},
        };
        public void kupYazdir()
        {
            Graphics g = this.CreateGraphics();
            Pen pRe = new Pen(Color.OrangeRed);
            float[,] kup = new float[10, 4];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    kup[i, j] = 0;
                    for (int k = 0; k < 4; k++)
                    {
                        kup[i, j] += reelkup[i, k] * Tizometrik[k, j];
                    }

                }
            }
            
            
            g.DrawLine(pRe, x(kup[0, 0]), y(kup[0, 1]), x(kup[1, 0]), y(kup[1, 1]));
            g.DrawLine(pRe, x(kup[1,0]), y(kup[1,1]), x(kup[2,0]), y(kup[2,1]));
            g.DrawLine(pRe, x(kup[2,0]), y(kup[2,1]), x(kup[3,0]), y(kup[3,1]));
            g.DrawLine(pRe, x(kup[3,0]), y(kup[3,1]), x(kup[4,0]), y(kup[4,1]));
            g.DrawLine(pRe, x(kup[2,0]), y(kup[2,1]), x(kup[4,0]), y(kup[4,1]));
            g.DrawLine(pRe, x(kup[4,0]), y(kup[4,1]), x(kup[5,0]), y(kup[5,1]));
            g.DrawLine(pRe, x(kup[5,0]), y(kup[5,1]), x(kup[0,0]), y(kup[0,1]));
            g.DrawLine(pRe, x(kup[0,0]), y(kup[0,1]), x(kup[6,0]), y(kup[6,1]));
            g.DrawLine(pRe, x(kup[1,0]), y(kup[1,1]), x(kup[7,0]), y(kup[7,1]));
            g.DrawLine(pRe, x(kup[5,0]), y(kup[5,1]), x(kup[9,0]), y(kup[9,1]));
            g.DrawLine(pRe, x(kup[3,0]), y(kup[3,1]), x(kup[8,0]), y(kup[8,1]));
            g.DrawLine(pRe, x(kup[8,0]), y(kup[8,1]), x(kup[9,0]), y(kup[9,1]));
            g.DrawLine(pRe, x(kup[9,0]), y(kup[9,1]), x(kup[6,0]), y(kup[6,1]));
            g.DrawLine(pRe, x(kup[8,0]), y(kup[8,1]), x(kup[7,0]), y(kup[7,1]));//
            g.DrawLine(pRe, x(kup[7,0]), y(kup[7,1]), x(kup[6,0]), y(kup[6,1]));
        }

        public void eksenCiz()
        {
            Graphics g = this.CreateGraphics();
            Pen pRe = new Pen(Color.Black);

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    reeleksenx[i, j] = 0;
                    
                    for (int k = 0; k < 4; k++)
                    {
                        reeleksenx[i, j] += eksenx[i, k] * Tizometrik[k, j];
                    }
                    
                }
            }
            g.DrawLine(pRe, x(0), y(0), x(reeleksenx[1,0]), y(reeleksenx[1, 1]));
            g.DrawLine(pRe, x(0), y(0), x(reeleksenx[1, 0] * (-1)), y(reeleksenx[1, 1]));
            g.DrawLine(pRe, x(0), y(0), x(ekseny[1, 0]), y(ekseny[1, 1]));
        }

        public static float[,] reelkup = {
                         {0, 1, 0, 1},
                         {1, 1, 0, 1},
                         {1, 1, 0.5f, 1},
                         {1, 0.5f, 1, 1},
                         {0.5f, 1, 1, 1},
                         {0, 1, 1, 1},
                         {0, 0, 0, 1},
                         {1, 0, 0, 1},
                         {1, 0, 1, 1},
                         {0, 0, 1, 1},
        };

        public void otele()
        {
            Graphics g = this.CreateGraphics();
            Pen pRe = new Pen(Color.DeepSkyBlue);
            float[,] kup = new float[10, 4];
            float[,] tempkup = new float[10, 4];
            if (textBox1.Text != "")
            {
                Totele[3, 0] = (float)Convert.ToDouble(textBox1.Text);
                
            }
           
            if (textBox3.Text != "")
            {
                Totele[3, 1] = (float)Convert.ToDouble(textBox3.Text);
            }
            if (textBox2.Text != "")
            {
                Totele[3, 2] = (float)Convert.ToDouble(textBox2.Text);
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    tempkup[i, j] = 0;
                    for (int k = 0; k < 4; k++)
                    {
                        tempkup[i, j] += reelkup[i, k] * Totele[k, j] ;
                    }

                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    kup[i, j] = 0;
                    for (int k = 0; k < 4; k++)
                    {
                        kup[i, j] += tempkup[i, k] * Tizometrik[k, j];
                    }

                }
            }


            g.DrawLine(pRe, x(kup[0, 0]), y(kup[0, 1]), x(kup[1, 0]), y(kup[1, 1]));
            g.DrawLine(pRe, x(kup[1, 0]), y(kup[1, 1]), x(kup[2, 0]), y(kup[2, 1]));
            g.DrawLine(pRe, x(kup[2, 0]), y(kup[2, 1]), x(kup[3, 0]), y(kup[3, 1]));
            g.DrawLine(pRe, x(kup[3, 0]), y(kup[3, 1]), x(kup[4, 0]), y(kup[4, 1]));
            g.DrawLine(pRe, x(kup[2, 0]), y(kup[2, 1]), x(kup[4, 0]), y(kup[4, 1]));
            g.DrawLine(pRe, x(kup[4, 0]), y(kup[4, 1]), x(kup[5, 0]), y(kup[5, 1]));
            g.DrawLine(pRe, x(kup[5, 0]), y(kup[5, 1]), x(kup[0, 0]), y(kup[0, 1]));
            g.DrawLine(pRe, x(kup[0, 0]), y(kup[0, 1]), x(kup[6, 0]), y(kup[6, 1]));
            g.DrawLine(pRe, x(kup[1, 0]), y(kup[1, 1]), x(kup[7, 0]), y(kup[7, 1]));
            g.DrawLine(pRe, x(kup[5, 0]), y(kup[5, 1]), x(kup[9, 0]), y(kup[9, 1]));
            g.DrawLine(pRe, x(kup[3, 0]), y(kup[3, 1]), x(kup[8, 0]), y(kup[8, 1]));
            g.DrawLine(pRe, x(kup[8, 0]), y(kup[8, 1]), x(kup[9, 0]), y(kup[9, 1]));
            g.DrawLine(pRe, x(kup[9, 0]), y(kup[9, 1]), x(kup[6, 0]), y(kup[6, 1]));
            g.DrawLine(pRe, x(kup[8, 0]), y(kup[8, 1]), x(kup[7, 0]), y(kup[7, 1]));//
            g.DrawLine(pRe, x(kup[7, 0]), y(kup[7, 1]), x(kup[6, 0]), y(kup[6, 1]));
            if (textBox1.Text != "")
            {
                Totele[3, 0] = 0;

            }
            if (textBox3.Text != "")
            {
                Totele[3, 1] = 0;
            }
            if (textBox2.Text != "")
            {
                Totele[3, 2] = 0;
            }
        }

        public void olcekle()
        {
            Graphics g = this.CreateGraphics();
            Pen pRe = new Pen(Color.DarkGreen);
            float[,] kup = new float[10, 4];
            float[,] tempkup = new float[10, 4];
            if (textBox9.Text != "")
            {
                Tolcekle[0, 0] = (float)Convert.ToDouble(textBox9.Text);

            }

            if (textBox7.Text != "")
            {
                Tolcekle[1, 1] = (float)Convert.ToDouble(textBox7.Text);
            }
            if (textBox8.Text != "")
            {
                Tolcekle[2, 2] = (float)Convert.ToDouble(textBox8.Text);
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    tempkup[i, j] = 0;
                    for (int k = 0; k < 4; k++)
                    {
                        tempkup[i, j] += reelkup[i, k] * Tolcekle[k, j];
                    }

                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    kup[i, j] = 0;
                    for (int k = 0; k < 4; k++)
                    {
                        kup[i, j] += tempkup[i, k] * Tizometrik[k, j];
                    }

                }
            }


            g.DrawLine(pRe, x(kup[0, 0]), y(kup[0, 1]), x(kup[1, 0]), y(kup[1, 1]));
            g.DrawLine(pRe, x(kup[1, 0]), y(kup[1, 1]), x(kup[2, 0]), y(kup[2, 1]));
            g.DrawLine(pRe, x(kup[2, 0]), y(kup[2, 1]), x(kup[3, 0]), y(kup[3, 1]));
            g.DrawLine(pRe, x(kup[3, 0]), y(kup[3, 1]), x(kup[4, 0]), y(kup[4, 1]));
            g.DrawLine(pRe, x(kup[2, 0]), y(kup[2, 1]), x(kup[4, 0]), y(kup[4, 1]));
            g.DrawLine(pRe, x(kup[4, 0]), y(kup[4, 1]), x(kup[5, 0]), y(kup[5, 1]));
            g.DrawLine(pRe, x(kup[5, 0]), y(kup[5, 1]), x(kup[0, 0]), y(kup[0, 1]));
            g.DrawLine(pRe, x(kup[0, 0]), y(kup[0, 1]), x(kup[6, 0]), y(kup[6, 1]));
            g.DrawLine(pRe, x(kup[1, 0]), y(kup[1, 1]), x(kup[7, 0]), y(kup[7, 1]));
            g.DrawLine(pRe, x(kup[5, 0]), y(kup[5, 1]), x(kup[9, 0]), y(kup[9, 1]));
            g.DrawLine(pRe, x(kup[3, 0]), y(kup[3, 1]), x(kup[8, 0]), y(kup[8, 1]));
            g.DrawLine(pRe, x(kup[8, 0]), y(kup[8, 1]), x(kup[9, 0]), y(kup[9, 1]));
            g.DrawLine(pRe, x(kup[9, 0]), y(kup[9, 1]), x(kup[6, 0]), y(kup[6, 1]));
            g.DrawLine(pRe, x(kup[8, 0]), y(kup[8, 1]), x(kup[7, 0]), y(kup[7, 1]));//
            g.DrawLine(pRe, x(kup[7, 0]), y(kup[7, 1]), x(kup[6, 0]), y(kup[6, 1]));
            if (textBox9.Text != "")
            {
                Tolcekle[0, 0] = 1;

            }
            if (textBox7.Text != "")
            {
                Tolcekle[1, 1] = 1;
            }
            if (textBox8.Text != "")
            {
                Tolcekle[2, 2] = 1;
            }
        }

        public void yansit()
        {
            Graphics g = this.CreateGraphics();
            Pen pRe = new Pen(Color.BlueViolet);
            float[,] kup = new float[10, 4];
            float[,] tempkup = new float[10, 4];
            int sayi = 0;
            if (checkBox1.Checked)
            {
                Tyansit[2, 2] = -1;
                sayi++;
            }

            if (checkBox2.Checked)
            {
                Tyansit[1, 1] = -1;
                sayi++;
            }
            if (checkBox3.Checked)
            {
                Tyansit[0,0] = -1;
                sayi++;
            }
            if(sayi == 1)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        tempkup[i, j] = 0;
                        for (int k = 0; k < 4; k++)
                        {
                            tempkup[i, j] += reelkup[i, k] * Tyansit[k, j];
                        }

                    }
                }
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        kup[i, j] = 0;
                        for (int k = 0; k < 4; k++)
                        {
                            kup[i, j] += tempkup[i, k] * Tizometrik[k, j];
                        }

                    }
                }


                g.DrawLine(pRe, x(kup[0, 0]), y(kup[0, 1]), x(kup[1, 0]), y(kup[1, 1]));
                g.DrawLine(pRe, x(kup[1, 0]), y(kup[1, 1]), x(kup[2, 0]), y(kup[2, 1]));
                g.DrawLine(pRe, x(kup[2, 0]), y(kup[2, 1]), x(kup[3, 0]), y(kup[3, 1]));
                g.DrawLine(pRe, x(kup[3, 0]), y(kup[3, 1]), x(kup[4, 0]), y(kup[4, 1]));
                g.DrawLine(pRe, x(kup[2, 0]), y(kup[2, 1]), x(kup[4, 0]), y(kup[4, 1]));
                g.DrawLine(pRe, x(kup[4, 0]), y(kup[4, 1]), x(kup[5, 0]), y(kup[5, 1]));
                g.DrawLine(pRe, x(kup[5, 0]), y(kup[5, 1]), x(kup[0, 0]), y(kup[0, 1]));
                g.DrawLine(pRe, x(kup[0, 0]), y(kup[0, 1]), x(kup[6, 0]), y(kup[6, 1]));
                g.DrawLine(pRe, x(kup[1, 0]), y(kup[1, 1]), x(kup[7, 0]), y(kup[7, 1]));
                g.DrawLine(pRe, x(kup[5, 0]), y(kup[5, 1]), x(kup[9, 0]), y(kup[9, 1]));
                g.DrawLine(pRe, x(kup[3, 0]), y(kup[3, 1]), x(kup[8, 0]), y(kup[8, 1]));
                g.DrawLine(pRe, x(kup[8, 0]), y(kup[8, 1]), x(kup[9, 0]), y(kup[9, 1]));
                g.DrawLine(pRe, x(kup[9, 0]), y(kup[9, 1]), x(kup[6, 0]), y(kup[6, 1]));
                g.DrawLine(pRe, x(kup[8, 0]), y(kup[8, 1]), x(kup[7, 0]), y(kup[7, 1]));//
                g.DrawLine(pRe, x(kup[7, 0]), y(kup[7, 1]), x(kup[6, 0]), y(kup[6, 1]));
            }
            Tyansit[0, 0] = 1;
            Tyansit[1, 1] = 1;
            Tyansit[2, 2] = 1;
            
        }
        public void dondur()
        {
            Graphics g = this.CreateGraphics();
            Pen pRe = new Pen(Color.DarkGoldenrod);
            float[,] kup = new float[10, 4];
            float[,] tempkup = new float[10, 4];
            if (textBox12.Text != "")
            {
                TdondurX[1, 1] = (float)Math.Cos(Math.PI * Convert.ToDouble(textBox12.Text) / 180);
                TdondurX[2, 2] = TdondurX[1, 1];

                TdondurX[1, 2] = (float)Math.Sin(Math.PI * Convert.ToDouble(textBox12.Text) / 180);
                TdondurX[2, 1] = (-1) * TdondurX[1, 2];

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        tempkup[i, j] = 0;
                        for (int k = 0; k < 4; k++)
                        {
                            tempkup[i, j] += reelkup[i, k] * TdondurX[k, j];
                        }

                    }
                }
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        kup[i, j] = 0;
                        for (int k = 0; k < 4; k++)
                        {
                            kup[i, j] += tempkup[i, k] * Tizometrik[k, j];
                        }

                    }
                }


                g.DrawLine(pRe, x(kup[0, 0]), y(kup[0, 1]), x(kup[1, 0]), y(kup[1, 1]));
                g.DrawLine(pRe, x(kup[1, 0]), y(kup[1, 1]), x(kup[2, 0]), y(kup[2, 1]));
                g.DrawLine(pRe, x(kup[2, 0]), y(kup[2, 1]), x(kup[3, 0]), y(kup[3, 1]));
                g.DrawLine(pRe, x(kup[3, 0]), y(kup[3, 1]), x(kup[4, 0]), y(kup[4, 1]));
                g.DrawLine(pRe, x(kup[2, 0]), y(kup[2, 1]), x(kup[4, 0]), y(kup[4, 1]));
                g.DrawLine(pRe, x(kup[4, 0]), y(kup[4, 1]), x(kup[5, 0]), y(kup[5, 1]));
                g.DrawLine(pRe, x(kup[5, 0]), y(kup[5, 1]), x(kup[0, 0]), y(kup[0, 1]));
                g.DrawLine(pRe, x(kup[0, 0]), y(kup[0, 1]), x(kup[6, 0]), y(kup[6, 1]));
                g.DrawLine(pRe, x(kup[1, 0]), y(kup[1, 1]), x(kup[7, 0]), y(kup[7, 1]));
                g.DrawLine(pRe, x(kup[5, 0]), y(kup[5, 1]), x(kup[9, 0]), y(kup[9, 1]));
                g.DrawLine(pRe, x(kup[3, 0]), y(kup[3, 1]), x(kup[8, 0]), y(kup[8, 1]));
                g.DrawLine(pRe, x(kup[8, 0]), y(kup[8, 1]), x(kup[9, 0]), y(kup[9, 1]));
                g.DrawLine(pRe, x(kup[9, 0]), y(kup[9, 1]), x(kup[6, 0]), y(kup[6, 1]));
                g.DrawLine(pRe, x(kup[8, 0]), y(kup[8, 1]), x(kup[7, 0]), y(kup[7, 1]));//
                g.DrawLine(pRe, x(kup[7, 0]), y(kup[7, 1]), x(kup[6, 0]), y(kup[6, 1]));

            }

            else if (textBox10.Text != "")
            {
                TdondurY[0, 0] = (float)Math.Cos(Math.PI * Convert.ToDouble(textBox10.Text) / 180);
                TdondurY[2, 2] = TdondurY[0,0];

                TdondurY[0, 2] = (float)Math.Sin(Math.PI * Convert.ToDouble(textBox10.Text) / 180);
                TdondurY[2, 0] = (-1) * TdondurY[0, 2];

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        tempkup[i, j] = 0;
                        for (int k = 0; k < 4; k++)
                        {
                            tempkup[i, j] += reelkup[i, k] * TdondurY[k, j];
                        }

                    }
                }
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        kup[i, j] = 0;
                        for (int k = 0; k < 4; k++)
                        {
                            kup[i, j] += tempkup[i, k] * Tizometrik[k, j];
                        }

                    }
                }


                g.DrawLine(pRe, x(kup[0, 0]), y(kup[0, 1]), x(kup[1, 0]), y(kup[1, 1]));
                g.DrawLine(pRe, x(kup[1, 0]), y(kup[1, 1]), x(kup[2, 0]), y(kup[2, 1]));
                g.DrawLine(pRe, x(kup[2, 0]), y(kup[2, 1]), x(kup[3, 0]), y(kup[3, 1]));
                g.DrawLine(pRe, x(kup[3, 0]), y(kup[3, 1]), x(kup[4, 0]), y(kup[4, 1]));
                g.DrawLine(pRe, x(kup[2, 0]), y(kup[2, 1]), x(kup[4, 0]), y(kup[4, 1]));
                g.DrawLine(pRe, x(kup[4, 0]), y(kup[4, 1]), x(kup[5, 0]), y(kup[5, 1]));
                g.DrawLine(pRe, x(kup[5, 0]), y(kup[5, 1]), x(kup[0, 0]), y(kup[0, 1]));
                g.DrawLine(pRe, x(kup[0, 0]), y(kup[0, 1]), x(kup[6, 0]), y(kup[6, 1]));
                g.DrawLine(pRe, x(kup[1, 0]), y(kup[1, 1]), x(kup[7, 0]), y(kup[7, 1]));
                g.DrawLine(pRe, x(kup[5, 0]), y(kup[5, 1]), x(kup[9, 0]), y(kup[9, 1]));
                g.DrawLine(pRe, x(kup[3, 0]), y(kup[3, 1]), x(kup[8, 0]), y(kup[8, 1]));
                g.DrawLine(pRe, x(kup[8, 0]), y(kup[8, 1]), x(kup[9, 0]), y(kup[9, 1]));
                g.DrawLine(pRe, x(kup[9, 0]), y(kup[9, 1]), x(kup[6, 0]), y(kup[6, 1]));
                g.DrawLine(pRe, x(kup[8, 0]), y(kup[8, 1]), x(kup[7, 0]), y(kup[7, 1]));//
                g.DrawLine(pRe, x(kup[7, 0]), y(kup[7, 1]), x(kup[6, 0]), y(kup[6, 1]));
            }
            else if (textBox11.Text != "")
            {
                TdondurZ[0, 0] = (float)Math.Cos(Math.PI * Convert.ToDouble(textBox11.Text) / 180);
                TdondurZ[1, 1] = TdondurZ[0, 0];

                TdondurZ[0, 1] = (float)Math.Sin(Math.PI * Convert.ToDouble(textBox11.Text) / 180);
                TdondurZ[1, 0] = (-1) * TdondurZ[0, 1];

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        tempkup[i, j] = 0;
                        for (int k = 0; k < 4; k++)
                        {
                            tempkup[i, j] += reelkup[i, k] * TdondurZ[k, j];
                        }

                    }
                }
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        kup[i, j] = 0;
                        for (int k = 0; k < 4; k++)
                        {
                            kup[i, j] += tempkup[i, k] * Tizometrik[k, j];
                        }

                    }
                }


                g.DrawLine(pRe, x(kup[0, 0]), y(kup[0, 1]), x(kup[1, 0]), y(kup[1, 1]));
                g.DrawLine(pRe, x(kup[1, 0]), y(kup[1, 1]), x(kup[2, 0]), y(kup[2, 1]));
                g.DrawLine(pRe, x(kup[2, 0]), y(kup[2, 1]), x(kup[3, 0]), y(kup[3, 1]));
                g.DrawLine(pRe, x(kup[3, 0]), y(kup[3, 1]), x(kup[4, 0]), y(kup[4, 1]));
                g.DrawLine(pRe, x(kup[2, 0]), y(kup[2, 1]), x(kup[4, 0]), y(kup[4, 1]));
                g.DrawLine(pRe, x(kup[4, 0]), y(kup[4, 1]), x(kup[5, 0]), y(kup[5, 1]));
                g.DrawLine(pRe, x(kup[5, 0]), y(kup[5, 1]), x(kup[0, 0]), y(kup[0, 1]));
                g.DrawLine(pRe, x(kup[0, 0]), y(kup[0, 1]), x(kup[6, 0]), y(kup[6, 1]));
                g.DrawLine(pRe, x(kup[1, 0]), y(kup[1, 1]), x(kup[7, 0]), y(kup[7, 1]));
                g.DrawLine(pRe, x(kup[5, 0]), y(kup[5, 1]), x(kup[9, 0]), y(kup[9, 1]));
                g.DrawLine(pRe, x(kup[3, 0]), y(kup[3, 1]), x(kup[8, 0]), y(kup[8, 1]));
                g.DrawLine(pRe, x(kup[8, 0]), y(kup[8, 1]), x(kup[9, 0]), y(kup[9, 1]));
                g.DrawLine(pRe, x(kup[9, 0]), y(kup[9, 1]), x(kup[6, 0]), y(kup[6, 1]));
                g.DrawLine(pRe, x(kup[8, 0]), y(kup[8, 1]), x(kup[7, 0]), y(kup[7, 1]));//
                g.DrawLine(pRe, x(kup[7, 0]), y(kup[7, 1]), x(kup[6, 0]), y(kup[6, 1]));
            }
            
            
        }

        public void Form1_Paint(object sender, PaintEventArgs e)
        {

            

         }

        private void button1_Click(object sender, EventArgs e)
        {
            eksenCiz();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kupYazdir();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            otele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            olcekle();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            yansit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dondur();
        }
    }
}
