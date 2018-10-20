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

            /*  int[] tomb = new int[10];

              for (int i = 0; i < tomb.Length;i++) {
                  Console.WriteLine("Kérem adjon meg az " + i  +  " egész számot!");

                  tomb[i] = Int32.Parse(Console.ReadLine());


              }

              Console.ReadLine();
              Console.WriteLine(tomb.Max());

      

            Console.WriteLine("Kérem adja meg a tömb méretét! ");
            int n = Int32.Parse(Console.ReadLine());

            int[] tomb2 = new int[n];


            for (int i = 0; i < tomb2.Length; i++)
            {
                Console.WriteLine("Kérem adjon meg az " + i + " egész számot!");

                tomb2[i] = Int32.Parse(Console.ReadLine());


            }

            Console.ReadLine();
            Console.WriteLine(tomb2.Max());
           

            Console.WriteLine("Kérem adja meg a tömb méretét! ");
            int m = Int32.Parse(Console.ReadLine());

            int[] tomb3 = new int[m];


            for (int i = 0; i < tomb3.Length; i++)
            {
                Console.WriteLine("Kérem adjon meg az " + i + " egész számot!");

                tomb3[i] = Int32.Parse(Console.ReadLine());


            }

            Console.ReadLine();
            Console.WriteLine(tomb3.Max());
            Console.WriteLine(tomb3.Min());


     */


            Console.WriteLine("Kérem adja meg a tömb méretét! ");
            int v = Int32.Parse(Console.ReadLine());

            int[] tomb4 = new int[v];


            for (int i = 0; i < tomb4.Length; i++)
            {
                Console.WriteLine("Kérem adjon meg az " + i + " egész számot!");
                if (tomb4[i] > 0 && tomb4[i] % 2 == 0)
                {
                    tomb4[i] = Int32.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Hibás adat kérem próbálja meg újra! ");

                }

            }

            Console.ReadLine();
            Console.WriteLine(tomb4.Max());
            Console.WriteLine(tomb4.Min());



        }
    }
}
