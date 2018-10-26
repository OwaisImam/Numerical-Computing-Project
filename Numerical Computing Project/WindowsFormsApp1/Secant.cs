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
    public partial class Secant : Form
    {
        public Secant()
        {
            InitializeComponent();
            dataGridView1.DataSource = table;
            table.Columns.Add("S.NO", typeof(double));
            table.Columns.Add("Xn-1", typeof(double));
            table.Columns.Add("Xn", typeof(double));
            table.Columns.Add("F(Xn-1)", typeof(double));
            table.Columns.Add("F(Xn)", typeof(double));
            table.Columns.Add("Xn+1 = Xn-( (f(Xn)(Xn-Xn-1) / f(Xn)-f(Xn-1) )", typeof(double));
            table.Columns.Add("E=| Xn+1 - Xn |", typeof(double));
          
        }

        Questions ques = new Questions();
        DataTable table = new DataTable();

        Double Xn, Xn1, X0, X1, error;

        private void secantMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Section Is Already Opened!","Window Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
        }

        private void fixedPointMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fixed fix = new Fixed();
            fix.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newtonRaphsonMEthodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Newton newton = new Newton();
            newton.Show();
            this.Hide();
        }

        private void regularFalsiMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegularFalsi regular = new RegularFalsi();
            regular.Show();
            this.Hide();
        }

        private void bisectionMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 bisect = new Form1();
            bisect.Show();
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (questions.SelectedIndex == 0)
            {
                if (txtA.Text == "" && txtB.Text == "")
                {


                    txtA.Text = "0.2";
                    txtB.Text = "0.3";
                    int row = dataGridView1.Rows.Count;
                    if (row > 0)
                    {
                        table.Rows.Clear();
                    }

                    X0 = Convert.ToDouble(txtA.Text);
                    X1 = Convert.ToDouble(txtB.Text);

                    Xn1 = Convert.ToDouble(string.Format("{0:0.000}", X1 - ((ques.secant1(X1) * (X1 - X0)) / (ques.secant1(X1) - (ques.secant1(X0))))));
                    error = Math.Abs(Xn1 - X1);

                    for (int i = 0; i < 50; i++)
                    {

                        if (string.Format("{0:0.000}", error) != string.Format("{0:0.000}", 0.000))
                        {
                            if (i != 0)
                            {

                                X0 = X1;
                                X1 = Xn1;
                                Xn1 = Convert.ToDouble(string.Format("{0:0.000}", X1 - ((ques.secant1(X1) * (X1 - X0)) / (ques.secant1(X1) - (ques.secant1(X0))))));

                                error = Math.Abs(Xn1 - X1);
                            }


                            table.Rows.Add((i + 1).ToString(), string.Format("{0:0.000}", X0), string.Format("{0:0.000}", X1), string.Format("{0:0.000}", ques.secant1(X0)), string.Format("{0:0.000}", ques.secant1(X1)), Xn1.ToString(), string.Format("{0:0.000}", error));

                        }
                        else
                        {
                            break;
                        }


                    }
                }
                else
                {
                   
                    int row = dataGridView1.Rows.Count;
                    if (row > 0)
                    {
                        table.Rows.Clear();
                    }

                    X0 = Convert.ToDouble(txtA.Text);
                    X1 = Convert.ToDouble(txtB.Text);

                
                    Xn1 = Convert.ToDouble(string.Format("{0:0.000}", X1 - ((ques.secant1(X1) * (X1 - X0)) / (ques.secant1(X1) - (ques.secant1(X0))))));
                    error = Math.Abs(Xn1 - X1);

                    for (int i = 0; i < 50; i++)
                    {

                        if (string.Format("{0:0.000}", error) != string.Format("{0:0.000}", 0.000))
                        {
                            if (i != 0)
                            {

                                X0 = X1;
                                X1 = Xn1;
                                Xn1 = Convert.ToDouble(string.Format("{0:0.000}", X1 - ((ques.secant1(X1) * (X1 - X0)) / (ques.secant1(X1) - (ques.secant1(X0))))));

                                error = Math.Abs(Xn1 - X1);
                            }


                            table.Rows.Add((i + 1).ToString(), string.Format("{0:0.000}", X0), string.Format("{0:0.000}", X1), string.Format("{0:0.000}", ques.secant1(X0)), string.Format("{0:0.000}", ques.secant1(X1)), Xn1.ToString(), string.Format("{0:0.000}", error));

                        }
                        else
                        {
                            break;
                        }


                    }

                }

            }
            else if (questions.SelectedIndex == 1)
            {
                if (txtA.Text == "" && txtB.Text == "")
                {

                    txtA.Text = "1.2";
                    txtB.Text = "1.3";
                    int row = dataGridView1.Rows.Count;
                    if (row > 0)
                    {
                        table.Rows.Clear();
                    }

                    X0 = Convert.ToDouble(txtA.Text);
                    X1 = Convert.ToDouble(txtB.Text);

                    MessageBox.Show(X0.ToString());

                    MessageBox.Show(X1.ToString());
                    Xn1 = Convert.ToDouble(string.Format("{0:0.000}", X1 - ((ques.secant2(X1) * (X1 - X0)) / (ques.secant2(X1) - (ques.secant2(X0))))));
                    error = Math.Abs(Xn1 - X1);

                    for (int i = 0; i < 50; i++)
                    {

                        if (string.Format("{0:0.000}", error) != string.Format("{0:0.000}", 0.000))
                        {
                            if (i != 0)
                            {

                                X0 = X1;
                                X1 = Xn1;
                                Xn1 = Convert.ToDouble(string.Format("{0:0.000}", X1 - ((ques.secant2(X1) * (X1 - X0)) / (ques.secant2(X1) - (ques.secant2(X0))))));

                                error = Math.Abs(Xn1 - X1);
                            }


                            table.Rows.Add((i + 1).ToString(), string.Format("{0:0.000}", X0), string.Format("{0:0.000}", X1), string.Format("{0:0.000}", ques.secant3(X0)), string.Format("{0:0.000}", ques.secant3(X1)), Xn1.ToString(), string.Format("{0:0.000}", error));


                        }
                        else
                        {
                            break;
                        }


                    }
                }
                else
                {
                   
                    int row = dataGridView1.Rows.Count;
                    if (row > 0)
                    {
                        table.Rows.Clear();
                    }

                    X0 = Convert.ToDouble(txtA.Text);
                    X1 = Convert.ToDouble(txtB.Text);

                    MessageBox.Show(X0.ToString());

                    MessageBox.Show(X1.ToString());
                    Xn1 = Convert.ToDouble(string.Format("{0:0.000}", X1 - ((ques.secant2(X1) * (X1 - X0)) / (ques.secant2(X1) - (ques.secant2(X0))))));
                    error = Math.Abs(Xn1 - X1);

                    for (int i = 0; i < 50; i++)
                    {

                        if (string.Format("{0:0.000}", error) != string.Format("{0:0.000}", 0.000))
                        {
                            if (i != 0)
                            {

                                X0 = X1;
                                X1 = Xn1;
                                Xn1 = Convert.ToDouble(string.Format("{0:0.000}", X1 - ((ques.secant2(X1) * (X1 - X0)) / (ques.secant2(X1) - (ques.secant2(X0))))));

                                error = Math.Abs(Xn1 - X1);
                            }


                            table.Rows.Add((i + 1).ToString(), string.Format("{0:0.000}", X0), string.Format("{0:0.000}", X1), string.Format("{0:0.000}", ques.secant3(X0)), string.Format("{0:0.000}", ques.secant3(X1)), Xn1.ToString(), string.Format("{0:0.000}", error));


                        }
                        else
                        {
                            break;
                        }


                    }

                }

            }
            else if (questions.SelectedIndex == 2)
            {
                if (txtA.Text == "" && txtB.Text == "")
                {

                    txtA.Text = "0.2";
                    txtB.Text = "0.3";
                    int row = dataGridView1.Rows.Count;
                    if (row > 0)
                    {
                        table.Rows.Clear();
                    }

                    X0 = Convert.ToDouble(txtA.Text);
                    X1 = Convert.ToDouble(txtB.Text);

                    MessageBox.Show(X0.ToString());

                    MessageBox.Show(X1.ToString());
                    Xn1 = Convert.ToDouble(string.Format("{0:0.000}", X1 - ((ques.secant3(X1) * (X1 - X0)) / (ques.secant3(X1) - (ques.secant3(X0))))));
                    error = Math.Abs(Xn1 - X1);

                    for (int i = 0; i < 50; i++)
                    {

                        if (string.Format("{0:0.000}", error) != string.Format("{0:0.000}", 0.000))
                        {
                            if (i != 0)
                            {

                                X0 = X1;
                                X1 = Xn1;
                                Xn1 = Convert.ToDouble(string.Format("{0:0.000}", X1 - ((ques.secant3(X1) * (X1 - X0)) / (ques.secant3(X1) - (ques.secant3(X0))))));

                                error = Math.Abs(Xn1 - X1);
                            }


                            table.Rows.Add((i + 1).ToString(), string.Format("{0:0.000}", X0), string.Format("{0:0.000}", X1), string.Format("{0:0.000}", ques.secant3(X0)), string.Format("{0:0.000}", ques.secant3(X1)), Xn1.ToString(), string.Format("{0:0.000}", error));





                        }
                        else
                        {
                            break;
                        }


                    }
                }
                else
                {
                    
                    int row = dataGridView1.Rows.Count;
                    if (row > 0)
                    {
                        table.Rows.Clear();
                    }

                    X0 = Convert.ToDouble(txtA.Text);
                    X1 = Convert.ToDouble(txtB.Text);

                    MessageBox.Show(X0.ToString());

                    MessageBox.Show(X1.ToString());
                    Xn1 = Convert.ToDouble(string.Format("{0:0.000}", X1 - ((ques.secant3(X1) * (X1 - X0)) / (ques.secant3(X1) - (ques.secant3(X0))))));
                    error = Math.Abs(Xn1 - X1);

                    for (int i = 0; i < 50; i++)
                    {

                        if (string.Format("{0:0.000}", error) != string.Format("{0:0.000}", 0.000))
                        {
                            if (i != 0)
                            {

                                X0 = X1;
                                X1 = Xn1;
                                Xn1 = Convert.ToDouble(string.Format("{0:0.000}", X1 - ((ques.secant3(X1) * (X1 - X0)) / (ques.secant3(X1) - (ques.secant3(X0))))));

                                error = Math.Abs(Xn1 - X1);
                            }


                            table.Rows.Add((i + 1).ToString(), string.Format("{0:0.000}", X0), string.Format("{0:0.000}", X1), string.Format("{0:0.000}", ques.secant3(X0)), string.Format("{0:0.000}", ques.secant3(X1)), Xn1.ToString(), string.Format("{0:0.000}", error));





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
                MessageBox.Show("Select Question First","Question Error", MessageBoxButtons.OKCancel);
            }
        }
    }
}
