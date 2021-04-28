using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace lab17zavd1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] f = new string[5];

            for (int i = 0; i < f.Length; i++)
            {
            re:

                f[i] = Interaction.InputBox($"Bвeдiть {i+1}  друга ", "Baедення"); 
                if (f[i] == "")
                    if (MessageBox.Show("Назва не введена\n\nповторити?", "eror", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        goto re;

                    else return;
            }
              
            File.WriteAllLines("D:\\Stytsun.txt", f); 
            if (File.Exists("H:\\Stytsun.txt"))
                File.Delete("H:\\Stytsun.txt");

            File.Copy("D:\\Stytsun.txt", "H:\\Stytsun.txt"); 

            MessageBox.Show("Данні збережені", "Pеsультaт", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
