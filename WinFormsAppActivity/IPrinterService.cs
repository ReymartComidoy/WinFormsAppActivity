using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppActivity
{
    public class WindowsPrinterService : IPrinterService
    {
        public void PrintInvoice(string recipientEmail, decimal total)
        {
            System.Windows.Forms.MessageBox.Show($"Invoice for {recipientEmail}: {total:C}");
        }
    }
}
