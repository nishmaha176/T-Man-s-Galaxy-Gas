using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace T_Man_s_Galaxy_Gas
{
    public partial class Form1 : Form
    {//setting variables
        double galaxyGas;
        double mask;
        double dispenser;
        double galaxyGasPrice = 30;
        double maskPrice = 20;
        double dispenserPrice = 40;
        double subtotal;
        double tax = 0.13;
        double taxAmount;
        double total;
        double tendered;
        double change;


        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try //for the program to not crash when a letter is input instead of a number
            {
                galaxyGas = Convert.ToDouble(galaxyGasInput.Text);
                mask = Convert.ToDouble(maskInput.Text);
                dispenser = Convert.ToDouble(dispenserInput.Text);
                subtotal = (dispenser * dispenserPrice) + (mask * maskPrice) + (galaxyGas * galaxyGasPrice);
                taxAmount = (subtotal * tax);
                total = (taxAmount + subtotal);
                subtotalOutput.Text = $"{subtotal.ToString("C")}";
                taxOutput.Text = $"{taxAmount.ToString("C")}";
                totalOutput.Text = $"{total.ToString("C")}";
            }
            catch
            {
                subtotalOutput.Text = "ERROR";
                taxOutput.Text = "ERROR";
                totalOutput.Text = "ERROR";
                //to display errors when a letter is input instead of numbers
            }




        }

        private void payButton_Click(object sender, EventArgs e)
        { try
            {
                tendered = Convert.ToDouble(tenderedInput.Text);
                change = (tendered - total);
                changeOutput.Text = $"{change.ToString("C")}";

            }
            catch
            {
                changeOutput.Text = "ERROR";
            }
        }


        private void receiptButton_Click(object sender, EventArgs e)
        {
            receiptOutput.Text = $"Your Receipt";
            Refresh();
            Thread.Sleep(1000);
            receiptOutput.Text += $"\n\nStrawberry Galaxy Gas:    {galaxyGas} @ {galaxyGasPrice}";
            Refresh();
            Thread.Sleep(1000);
            receiptOutput.Text += $"\nMascot Mask:              {mask} @ {maskPrice}";
            Refresh();
            Thread.Sleep(1000);
            receiptOutput.Text += $"\nWhipped Cream Dispenser:  {dispenser} @ {dispenserPrice}";
            Refresh();
            Thread.Sleep(1000);
            receiptOutput.Text += $"\n\nsubtotal                  {subtotal.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            receiptOutput.Text += $"\ntax                       {taxAmount.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            receiptOutput.Text += $"\ntotal                     {total.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            receiptOutput.Text += $"\n\ntendered                 {tendered.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            receiptOutput.Text += $"\nchange                    {change.ToString("C")}";





        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            galaxyGasInput.Text = $"";
            maskInput.Text = $"";
            dispenserInput.Text = $"";
            subtotalOutput.Text = $"";
            taxOutput.Text = $"";
            totalOutput.Text = $"";
            changeOutput.Text = "";
            tenderedInput.Text = $"";
            receiptOutput.Text = $"";




        }
    }
}
