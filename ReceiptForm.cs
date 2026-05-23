using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
namespace SimpleBankingSystem
{
    public partial class ReceiptForm : Form
    {
        public ReceiptForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        public string AccountNumber;
        public string TransactionType;
        public decimal Amount;
        public decimal Balance;
        public string Date;
        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            lblAccountValue.Text =
    AccountNumber;

            lblTypeValue.Text =
                TransactionType;

            lblAmountValue.Text =
                Amount.ToString();

            lblBalanceValue.Text =
                Balance.ToString();

            lblDateValue.Text =
                Date;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog save =
    new SaveFileDialog();

            save.Filter =
                "PDF File|*.pdf";

            save.FileName =
                "Receipt.pdf";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Document document =
                    new Document();

                PdfWriter.GetInstance(
                    document,
                    new FileStream(
                        save.FileName,
                        FileMode.Create));

                document.Open();

                document.Add(
                    new Paragraph(
                        "BANK RECEIPT"));

                document.Add(
                    new Paragraph(
                        " "));

                document.Add(
                    new Paragraph(
                        "Account: " +
                        lblAccountValue.Text));

                document.Add(
                    new Paragraph(
                        "Type: " +
                        lblTypeValue.Text));

                document.Add(
                    new Paragraph(
                        "Amount: " +
                        lblAmountValue.Text));

                document.Add(
                    new Paragraph(
                        "Balance: " +
                        lblBalanceValue.Text));

                document.Add(
                    new Paragraph(
                        "Date: " +
                        lblDateValue.Text));

                document.Close();

                MessageBox.Show(
                    "Receipt Downloaded!");
            }
        }

        private void ButtonHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.BackColor = Color.DarkBlue;
        }

        private void ButtonLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.BackColor = Color.SteelBlue;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
