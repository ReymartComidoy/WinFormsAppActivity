using System.Net.Mail;
using Microsoft.Data.SqlClient;

namespace WinFormsAppActivity

{
    public partial class Form1 : Form
    {
        private decimal _total;
        private readonly OrderCalculator _calculator;
        private readonly IOrderRepository _repository;
        private readonly IEmailService _emailService;
        private readonly IPrinterService _printerService;
        private readonly Dictionary<string, IDiscountStrategy> _discountStrategies;

        public Form1()
        {
            InitializeComponent();

            _calculator = new OrderCalculator();
            _repository = new SqlOrderRepository(@"Server=.\SQLEXPRESS;Database=Orders;Integrated Security=True;TrustServerCertificate=True;");
            _emailService = new SmtpEmailService();
            _printerService = new WindowsPrinterService();

            _discountStrategies = new Dictionary<string, IDiscountStrategy>
            {
                { "None", new NoDiscount() },
                { "Student", new StudentDiscount() },
                { "Senior", new SeniorDiscount() },
                { "BlackFriday", new BlackFridayDiscount() }
            };
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var items = new List<OrderItem>();
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                if (row.Cells["Price"].Value == null || row.Cells["Qty"].Value == null) continue;

                if (decimal.TryParse(row.Cells["Price"].Value.ToString(), out decimal price) &&
                    int.TryParse(row.Cells["Qty"].Value.ToString(), out int qty))
                {
                    items.Add(new OrderItem { Price = price, Quantity = qty });
                }
            }

            string selectedDiscount = cmbDiscountType.SelectedItem?.ToString() ?? "None";
            IDiscountStrategy strategy = _discountStrategies.ContainsKey(selectedDiscount)
                ? _discountStrategies[selectedDiscount]
                : new NoDiscount();

            _total = _calculator.CalculateTotal(items, strategy);
            lblTotal.Text = _total.ToString("C");
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            _repository.SaveOrder(txtCustomerEmail.Text, _total);
            MessageBox.Show("Saved!");
        }

        private void btnEmailInvoice_Click(object sender, EventArgs e)
        {
            _emailService.SendInvoice(txtCustomerEmail.Text, _total);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            _printerService.PrintInvoice(txtCustomerEmail.Text, _total);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
