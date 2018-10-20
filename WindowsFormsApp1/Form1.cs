using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            int[] tomb = new int[10];

            for (int i = 0; i < tomb.Length;i++) {
                Console.WriteLine("Kérem adjon meg az " + i  +  " egész számot!");

                tomb[i] = Int32.Parse(Console.ReadLine());


            }

            Console.ReadLine();
            Console.WriteLine(tomb.Max());


        }
    }
}
