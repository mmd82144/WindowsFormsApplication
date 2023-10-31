using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
 
       
             public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }
            private int[] addad = new int[20];
            private int shomaresh = 0;
            public void button1_Click(object sender, EventArgs e)
            {
                try
                {


                    int a = int.Parse(textBox1.Text);
                    if (shomaresh < addad.Length)
                    {
                        addad[shomaresh] = a;
                        shomaresh++;
                    }
                    int sum = 0;
                    for (int i = 0; i < shomaresh; i++)
                    {
                        sum += addad[i];
                    }
                    double avg = sum / shomaresh;
                    label3.Text = avg.ToString();
                    if (shomaresh > 19)
                    {
                        MessageBox.Show("behade nesab resid lotfan CLEAR ro bezan");
                        return;
                    }
                    else
                    {
                        listBox1.Items.Add(a);
                    }
                    textBox1.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            private void button2_Click(object sender, EventArgs e)
            {
                listBox1.Items.Clear();
                shomaresh = 0;
                label3.Text = "";
            }
        }
    }

    
