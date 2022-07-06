using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WebAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BindingSource bsBets = new BindingSource();
        double input = 0;
        
        int[] odd= {1,3,5,7,9,12,15,17,19,21,23,25,27,29,31,33,35};
        int[] even= {2,4,6,8,10,12,14,16,18,20,22,24,26,28,30,32,34,36};
        public void RefreshData()
        {
            Bets bt = new Bets();
            bsBets.DataSource = bt.GetAllBets();
            dgvPayout.DataSource = bsBets;
        }
        private void payoutTextBox_TextChanged(object sender, EventArgs e)
        {
            input = double.Parse(txtInput.Text);
            Thread spin = new Thread(() =>
            {
                for (int i = 0; i < input; i++)
                {
                    Thread.Sleep(1000);

                }
            });
            spin.Start();
        }

        private void SpinBtn_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bets selectedBet = (Bets)bsBets.Current;
            int selectedID = selectedBet.PlaceBetID;
            Bets bt = new Bets();
            bsBets.DataSource = bt.getSpecificBet(selectedID);
            dgvPayout.DataSource = bsBets;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bets bt = new Bets();
            bsBets.DataSource = bt.GetAllBets();
            dgvPayout.DataSource = bsBets;
        }

        private void txtInput_TextChanged(object sender, EventArgs e)//Each bet which is placed will be displayed on the DataGridView inorder for the user to be able to view their bets on one page
        {
            int spin = int.Parse(txtInput.Text);
            double payoutOutput = double.Parse(dgvPayout.Text);
            double betAmountInput = double.Parse(txtInput.Text);

            Bets bt = new Bets();
            bt.Insert(spin,betAmountInput, payoutOutput);
            bsBets.DataSource = bt.GetAllBets();
            dgvPayout.DataSource = bsBets;

            RefreshData();
            txtInput.Clear();
            dgvPayout.ClearSelection();
        }

        private void lblCountUp_Click(object sender, EventArgs e)
        {

        }

        private void lblCountDown_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            input = int.Parse(txtInput.Text);
            Thread tOdd = new Thread(() =>
            {
                for (int i = 0; i < input; i++)
                {
                    Thread.Sleep(1000);
                    odd++;
                    SolveCrossThreadProbs();
                }
            });
            tOdd.Start();

            Thread tEven = new Thread(() =>
            {
                input = int.Parse(txtInput.Text);
                for (double i = input; i > 0; i--)
                {
                    Thread.Sleep(1000);
                    even--;
                    SolveSecondThread();
                }
            });
            tEven.Start();
        }
        delegate void action();
        public void SolveCrossThreadProbs()
        {
            if (this.lblOdds.InvokeRequired)
            {
                action ac = new action(SolveCrossThreadProbs);
                this.Invoke(ac);
            }
            else
            {
                lblOdds.Text = odd.ToString();
            }
        }
        public void SolveSecondThread()
        {
            if (this.lblPayout.InvokeRequired)
            {
                action ac = new action(SolveSecondThread);
                this.Invoke(ac);
            }
            else
            {
                lblPayout.Text = even.ToString();
            }
        }

        public void rouletteCal()
        {
          

        }
    }
}
