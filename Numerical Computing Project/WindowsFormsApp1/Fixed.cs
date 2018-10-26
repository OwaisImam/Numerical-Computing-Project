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
    public partial class Fixed : Form
    {
        public Fixed()
        {
            InitializeComponent();
            dataGridView1.DataSource = table;
            table.Columns.Add("S.NO", typeof(double));
            table.Columns.Add("Xn+1", typeof(double));
            table.Columns.Add("E=|Xn+1-Xn|", typeof(double));

        }

        DataTable table = new DataTable();
        Questions ques = new Questions();
        fix1 fix1 = new fix1();
        fix2 fix2 = new fix2();
        fix3 fix3 = new fix3();
        fix4 fix4 = new fix4();
        fix5 fix5 = new fix5();
        Double Xo, error, X, Xn1;
        string equation;
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bisectionMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 bisection = new Form1();
            bisection.Show();
            this.Hide();
        }

        private void regularFalsiMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegularFalsi regular = new RegularFalsi();
            regular.Show();
            this.Hide();
        }

        private void newtonRaphsonMEthodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Newton newton = new Newton();
            newton.Show();
            this.Hide();
        }

        private void secantMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Secant secant = new Secant();
            secant.Show();
            this.Hide();
        }

        private void fixedPointMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Section Is Already Opened!", "Window Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (questions.SelectedIndex == 4)
            {

                if (txtA.Text == "")
                {
                    txtA.Text = "1.2";
                    Xo = Convert.ToDouble(txtA.Text);
                    int row = dataGridView1.Rows.Count;
                    if (row > 0)
                    {
                        table.Rows.Clear();
                    }
                    if (Math.Abs(fix1.equation1_d(Xo)) < 1)
                    {
                        equation = "-3x^2";
                        MessageBox.Show(equation);
                        Xn1 = Convert.ToDouble(string.Format("{0:0.000}", fix1.equation1(Xo)));
                        MessageBox.Show(Xn1.ToString());
                        error = Math.Abs(Xn1 - Xo);

                        for (int i = 0; i < 50; i++)
                        {

                            if (string.Format("{0:0.000}", error) != string.Format("{0:0.000}", 0.000))
                            {
                                if (i != 0)
                                {
                                    Xo = Xn1;
                                    Xn1 = Convert.ToDouble(string.Format("{0:0.000}", fix1.equation1(Xo)));

                                    error = Math.Abs(Xn1 - Xo);

                                }

                                table.Rows.Add((i + 1).ToString(), string.Format("{0:0.000}", Xn1), string.Format("{0:0.000}", error));

                            }
                            else
                            {
                                break;
                            }

                        }
                    }
                    else if (Math.Abs(fix1.equation2_d(Xo)) < 1)
                    {

                        equation = "(3-Xn)^1/3";
                        MessageBox.Show(equation);

                        Xn1 = Convert.ToDouble(string.Format("{0:0.000}", fix1.equation2(Xo)));
                        MessageBox.Show(Xn1.ToString());
                        error = Math.Abs(Xn1 - Xo);

                        for (int i = 0; i < 50; i++)
                        {

                            if (string.Format("{0:0.000}", error) != string.Format("{0:0.000}", 0.000))
                            {
                                if (i != 0)
                                {
                                    Xo = Xn1;
                                    Xn1 = Convert.ToDouble(string.Format("{0:0.000}", fix1.equation2(Xo)));

                                    error = Math.Abs(Xn1 - Xo);

                                }

                                table.Rows.Add((i + 1).ToString(), string.Format("{0:0.000}", Xn1), string.Format("{0:0.000}", error));

                            }
                            else
                            {
                                break;
                            }

                        }
                    }
                }
                else
                {

                }

            }
            else if (questions.SelectedIndex == 0)
            {

                if (txtA.Text == "")
                {
                    int row = dataGridView1.Rows.Count;
                    if (row > 0)
                    {
                        table.Rows.Clear();
                    }

                    txtA.Text = "1";
                    Xo = Convert.ToDouble(txtA.Text);

                    if (Math.Abs(fix5.equation1_d(Xo)) < 1)
                    {
                        equation = "Sinx+10/10";
                        MessageBox.Show(equation);
                        Xn1 = Convert.ToDouble(string.Format("{0:0.000}", fix5.equation1(Xo)));
                        MessageBox.Show(Xn1.ToString());
                        error = Math.Abs(Xn1 - Xo);

                        for (int i = 0; i < 50; i++)
                        {

                            if (string.Format("{0:0.000}", error) != string.Format("{0:0.000}", 0.000))
                            {
                                if (i != 0)
                                {
                                    Xo = Xn1;
                                    Xn1 = Convert.ToDouble(string.Format("{0:0.000}", fix5.equation1(Xo)));

                                    error = Math.Abs(Xn1 - Xo);

                                }

                                table.Rows.Add((i + 1).ToString(), string.Format("{0:0.000}", Xn1), string.Format("{0:0.000}", error));

                            }
                            else
                            {
                                break;
                            }

                        }
                    }

                }

                else
                {

                }
            }
            else if (questions.SelectedIndex == 1)
            {
                if (txtA.Text == "")
                {
                    txtA.Text = "1";
                    Xo = Convert.ToDouble(txtA.Text);

                    if (Math.Abs(fix2.equation1_d(Xo)) < 1)
                    {
                        equation = "Sinx+10/10";
                        MessageBox.Show(equation);
                        Xn1 = Convert.ToDouble(string.Format("{0:0.000}", fix2.equation1(Xo)));
                        MessageBox.Show(Xn1.ToString());
                        error = Math.Abs(Xn1 - Xo);

                        for (int i = 0; i < 50; i++)
                        {

                            if (string.Format("{0:0.000}", error) != string.Format("{0:0.000}", 0.000))
                            {
                                if (i != 0)
                                {
                                    Xo = Xn1;
                                    Xn1 = Convert.ToDouble(string.Format("{0:0.000}", fix2.equation1(Xo)));

                                    error = Math.Abs(Xn1 - Xo);

                                }

                                table.Rows.Add((i + 1).ToString(), string.Format("{0:0.000}", Xn1), string.Format("{0:0.000}", error));

                            }
                            else
                            {
                                break;
                            }

                        }
                    }
                }
                else
                {

                }
            }
            else if (questions.SelectedIndex == 3)
            {

                if (txtA.Text == "")
                {
                    txtA.Text = "1";
                    Xo = Convert.ToDouble(txtA.Text);

                    if (Math.Abs(fix4.equation2_d(Xo)) < 1)
                    {
                        equation = "(100-X^2)^1/3";
                        MessageBox.Show(equation);
                        Xn1 = Convert.ToDouble(string.Format("{0:0.000}", fix4.equation2(Xo)));
                        MessageBox.Show(Xn1.ToString());
                        error = Math.Abs(Xn1 - Xo);

                        for (int i = 0; i < 50; i++)
                        {

                            if (string.Format("{0:0.000}", error) != string.Format("{0:0.000}", 0.000))
                            {
                                if (i != 0)
                                {
                                    Xo = Xn1;
                                    Xn1 = Convert.ToDouble(string.Format("{0:0.000}", fix4.equation2(Xo)));

                                    error = Math.Abs(Xn1 - Xo);

                                }

                                table.Rows.Add((i + 1).ToString(), string.Format("{0:0.000}", Xn1), string.Format("{0:0.000}", error));

                            }
                            else
                            {
                                break;
                            }

                        }


                    }
                }
            }
            else if (questions.SelectedIndex == 2)
            {

                if (txtA.Text == "")
                {
                    txtA.Text = "1";
                    Xo = Convert.ToDouble(txtA.Text);

                    if (Math.Abs(fix3.equation1_d(Xo)) < 1)
                    {
                        equation = "(arctan(e^-x))";
                        MessageBox.Show(equation);
                        Xn1 = Convert.ToDouble(string.Format("{0:0.000}", fix3.equation1(Xo)));
                        MessageBox.Show(Xn1.ToString());
                        error = Math.Abs(Xn1 - Xo);

                        for (int i = 0; i < 50; i++)
                        {

                            if (string.Format("{0:0.000}", error) != string.Format("{0:0.000}", 0.000))
                            {
                                if (i != 0)
                                {
                                    Xo = Xn1;
                                    Xn1 = Convert.ToDouble(string.Format("{0:0.000}", fix3.equation1(Xo)));

                                    error = Math.Abs(Xn1 - Xo);

                                }

                                table.Rows.Add((i + 1).ToString(), string.Format("{0:0.000}", Xn1), string.Format("{0:0.000}", error));

                            }
                            else
                            {
                                break;
                            }

                        }

                    }

                }
            
                }
            else
            {
                MessageBox.Show("Select Question First", "Question Selection Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
          
        }
    }
}
