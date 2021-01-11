using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountSim
{
    public partial class Form1 : Form
    {
        private BankAccount bankAccount = new BankAccount(1000, 0);
        public Form1()
        {
            InitializeComponent();
            balanceLabel.Text = bankAccount.Balance.ToString("c");
            creditLabel.Text = bankAccount.CreditBalance.ToString("c");
            MessageBox.Show("Interest of credit: 30% Deposit prioritize paying credit");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            double amount;

            if(double.TryParse(depositTextbox.Text, out amount))
            {
                if(bankAccount.CreditBalance > 0)
                {
                    bankAccount.SetCreditBalance(-amount);
                    //bankAccount.Credit(-amount/1.3);
                    //bankAccount.deposit(amount / 1.3);
                    if(bankAccount.CreditBalance < 0)
                    {
                        bankAccount.deposit(-bankAccount.CreditBalance);
                        bankAccount.SetCreditBalance(-bankAccount.CreditBalance);
                    }
                    creditLabel.Text = bankAccount.CreditBalance.ToString("c");
                    balanceLabel.Text = bankAccount.Balance.ToString("c");
                    depositTextbox.Clear();
                }
                else
                {
                    bankAccount.deposit(amount);
                    balanceLabel.Text = bankAccount.Balance.ToString("c");
                    depositTextbox.Clear();
                }

            }
            else
            {
                MessageBox.Show("Invalid amount");
                depositTextbox.Clear();
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            double amount;

            if (double.TryParse(withdrawTextbox.Text, out amount))
            {
                if(amount > bankAccount.Balance)
                {
                    MessageBox.Show("Can't take credit");
                    withdrawTextbox.Clear();
                    return;
                }
                bankAccount.withdraw(amount);
                balanceLabel.Text = bankAccount.Balance.ToString("c");
                withdrawTextbox.Clear();
            }
            else
            {
                MessageBox.Show("Invalid amount");
                withdrawTextbox.Clear();
            }
        }

        private void creditButton_Click(object sender, EventArgs e)
        {
            double amount;

            if (double.TryParse(creditTextbox.Text, out amount))
            {
                bankAccount.Credit(amount);
                balanceLabel.Text = bankAccount.Balance.ToString("c");
                creditLabel.Text = bankAccount.CreditBalance.ToString("c");
                creditTextbox.Clear();
            }
            else
            {
                MessageBox.Show("Invalid amount");
                creditTextbox.Clear();
            }
        }
    }
}
