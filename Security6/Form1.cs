using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security6
{
    public partial class Form1 : Form
    {
        Bob bob;
        Alice alice;
        public Form1()
        {
            InitializeComponent();
            alice = new Alice();
            bob = new Bob();

            for(int i = 1000; i < 2001; i++)
            {
                if (GFG.isPrime(i))
                    p.Items.Add(i);
            }
            p.Update();
        }


        private void p_SelectedIndexChanged(object sender, EventArgs e)
        {
            alice.p = int.Parse(p.Text);
            var res = alice.calcA();
            aList.Items.Clear();
            foreach (var a in res)
            {
                aList.Items.Add(a);
            }
            aList.Update();
        }

        private void genX_Click(object sender, EventArgs e)
        {
            alice.genX();
            x.Text = alice.x.ToString();
        }

        private void genY_Click(object sender, EventArgs e)
        {
            bob.genY();
            y.Text = bob.y.ToString();
        }

        private void check_Click(object sender, EventArgs e)
        {
            alice.send_a_p(bob);
            alice.calcX();
            outAliceX.Text = $"X = {alice.X}";
            outAliceX.Visible = true;
            alice.sendX(bob);
            bob.calcY();
            outBobY.Text = $"Y = {bob.Y}";
            outBobY.Visible = true;
            bob.sendY(alice);
            alice.CalcK();
            bob.CalcK();

            outAliceK.Text = $"K = {alice.k}";
            outBobK.Text = $"K = {bob.k}";
            outAliceK.Visible = true;
            outBobK.Visible = true;
        }

        private void aList_SelectedIndexChanged(object sender, EventArgs e)
        {
            alice.a = int.Parse(aList.Text);
        }
    }
}
