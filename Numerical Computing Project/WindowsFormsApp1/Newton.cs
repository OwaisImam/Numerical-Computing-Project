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
    public partial class Newton : Form
    {
        public Newton()
        {
            InitializeComponent();
            dataGridView1.DataSource = table;
            table.Columns.Add("S.NO", typeof(double));
            table.Columns.Add("Xn", typeof(double));
            table.Columns.Add("F(Xn)", typeof(double));
            table.Columns.Add("F'(Xn)", typeof(double));
            table.Columns.Add("Xn+1 = Xn-( (f(Xn) / f'(Xn))", typeof(double));
            table.Columns.Add("E=| Xn+1 - Xn |", typeof(double));

        }

        
        DataTable table = new DataTable();
        newton3 newton3 = new newton3();
        newton2 newton2 = new newton2();
        newton1 newton1 = new newton1();

        Double Xn, Xn1, Xo, X1, error;
    


        private void bisectionMethodToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1 bisect = new Form1();
            bisect.Show();
            this.Hide();
        }

        private void regularFalsiMethodToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RegularFalsi regular = new RegularFalsi();
            regular.Show();
            this.Hide();
        }

        private void newtonRaphsonMEthodToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("This Section Is Already Opened!", "Window Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void secantMethodToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Secant secant = new Secant();
            secant.Show();
            this.Hide();
        }

        private void fixedPointMethodToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Fixed fix = new Fixed();
            fix.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      


    

        private void btnSubmit_Click(object sender, EventArgs e)
        {


            if (questions.SelectedIndex == 0)
            {
                txtA.Text = "";
                if (txtA.Text == "")
                {
                    int row = dataGridView1.Rows.Count;
                    if (row > 0)
                    {
                        table.Rows.Clear();
                    }
                    txtA.Text = "2.1";

                    Xo = Convert.ToDouble(txtA.Text);

                    Xn = Xo;

                   

                    Xn1 = Convert.ToDouble(string.Format("{0:0.000}", Xn - ((newton1.fx(Xn) / (newton1.fxd(Xn))))));
                    error = Math.Abs(Xn1 - Xn);

                    for (int i = 0; i < 50; i++)
                    {

                        if (string.Format("{0:0.000}", error) != string.Format("{0:0.000}", 0.000))
                        {
                            if (i != 0)
                            {

                                Xn = Xn1;
                                Xn1 = Convert.ToDouble(string.Format("{0:0.000}", Xn - ((newton1.fx(Xn) / (newton1.fxd(Xn))))));

                                error = Math.Abs(Xn1 - Xn);
                            }


                            table.Rows.Add((i + 1).ToString(), string.Format("{0:0.000}", Xn), string.Format("{0:0.000}", newton1.fx(Xn)), string.Format("{0:0.000}", newton1.fxd(Xn)), Xn1.ToString(), string.Format("{0:0.000}", error));

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

                    Xo = Convert.ToDouble(txtA.Text);

                    Xn = Xo;

                    Xn1 = Convert.ToDouble(string.Format("{0:0.000}", Xn - ((newton1.fx(Xn) / (newton1.fxd(Xn))))));
                    error = Math.Abs(Xn1 - Xn);

                    for (int i = 0; i < 50; i++)
                    {

                        if (string.Format("{0:0.000}", error) != string.Format("{0:0.000}", 0.000))
                        {
                            if (i != 0)
                            {

                                Xn = Xn1;
                                Xn1 = Convert.ToDouble(string.Format("{0:0.000}", Xn - ((newton1.fx(Xn) / (newton1.fxd(Xn))))));

                                error = Math.Abs(Xn1 - Xn);
                            }


                            table.Rows.Add((i + 1).ToString(), string.Format("{0:0.000}", Xn), string.Format("{0:0.000}", newton1.fx(Xn)), string.Format("{0:0.000}", newton1.fxd(Xn)), Xn1.ToString(), string.Format("{0:0.000}", error));

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
                txtA.Text = "";
                if (txtA.Text == "")
                {
                    int row = dataGridView1.Rows.Count;
                    if (row > 0)
                    {
                        table.Rows.Clear();
                    }
                    txtA.Text = "1";

                    Xo = Convert.ToDouble(txtA.Text);

                    Xn = Xo;

                

                    Xn1 = Convert.ToDouble(string.Format("{0:0.000}", Xn - ((newton2.fx(Xn) / (newton2.fxd(Xn))))));
                    error = Math.Abs(Xn1 - Xn);

                    for (int i = 0; i < 50; i++)
                    {

                        if (string.Format("{0:0.000}", error) != string.Format("{0:0.000}", 0.000))
                        {
                            if (i != 0)
                            {

                                Xn = Xn1;
                                Xn1 = Convert.ToDouble(string.Format("{0:0.000}", Xn - ((newton2.fx(Xn) / (newton2.fxd(Xn))))));

                                error = Math.Abs(Xn1 - Xn);
                            }


                            table.Rows.Add((i + 1).ToString(), string.Format("{0:0.000}", Xn), string.Format("{0:0.000}", newton2.fx(Xn)), string.Format("{0:0.000}", newton2.fxd(Xn)), Xn1.ToString(), string.Format("{0:0.000}", error));

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

                    Xo = Convert.ToDouble(txtA.Text);

                    Xn = Xo;


                    Xn1 = Convert.ToDouble(string.Format("{0:0.000}", Xn - ((newton2.fx(Xn) / (newton2.fxd(Xn))))));
                    error = Math.Abs(Xn1 - Xn);

                    for (int i = 0; i < 50; i++)
                    {

                        if (string.Format("{0:0.000}", error) != string.Format("{0:0.000}", 0.000))
                        {
                            if (i != 0)
                            {

                                Xn = Xn1;
                                Xn1 = Convert.ToDouble(string.Format("{0:0.000}", Xn - ((newton2.fx(Xn) / (newton2.fxd(Xn))))));

                                error = Math.Abs(Xn1 - Xn);
                            }


                            table.Rows.Add((i + 1).ToString(), string.Format("{0:0.000}", Xn), string.Format("{0:0.000}", newton2.fx(Xn)), string.Format("{0:0.000}", newton2.fxd(Xn)), Xn1.ToString(), string.Format("{0:0.000}", error));

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
                txtA.Text = "";
                if (txtA.Text == "")
                {
                    int row = dataGridView1.Rows.Count;
                    if (row > 0)
                    {
                        table.Rows.Clear();
                    }

                    txtA.Text = "1";

                    Xo = Convert.ToDouble(txtA.Text);

                    Xn = Xo;

                 

                    Xn1 = Convert.ToDouble(string.Format("{0:0.000}", Xn - ((newton3.fx(Xn) / (newton3.fxd(Xn))))));
                    error = Math.Abs(Xn1 - Xn);

                    for (int i = 0; i < 50; i++)
                    {

                        if (string.Format("{0:0.000}", error) != string.Format("{0:0.000}", 0.000))
                        {
                            if (i != 0)
                            {

                                Xn = Xn1;
                                Xn1 = Convert.ToDouble(string.Format("{0:0.000}", Xn - ((newton3.fx(Xn) / (newton3.fxd(Xn))))));

                                error = Math.Abs(Xn1 - Xn);
                            }


                            table.Rows.Add((i + 1).ToString(), string.Format("{0:0.000}", Xn), string.Format("{0:0.000}", newton3.fx(Xn)), string.Format("{0:0.000}", newton3.fxd(Xn)), Xn1.ToString(), string.Format("{0:0.000}", error));

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
                    Xo = Convert.ToDouble(txtA.Text);

                    Xn = Xo;

                 

                    Xn1 = Convert.ToDouble(string.Format("{0:0.000}", Xn - ((newton3.fx(Xn) / (newton3.fxd(Xn))))));
                    error = Math.Abs(Xn1 - Xn);

                    for (int i = 0; i < 50; i++)
                    {

                        if (string.Format("{0:0.000}", error) != string.Format("{0:0.000}", 0.000))
                        {
                            if (i != 0)
                            {

                                Xn = Xn1;
                                Xn1 = Convert.ToDouble(string.Format("{0:0.000}", Xn - ((newton3.fx(Xn) / (newton3.fxd(Xn))))));

                                error = Math.Abs(Xn1 - Xn);
                            }


                            table.Rows.Add((i + 1).ToString(), string.Format("{0:0.000}", Xn), string.Format("{0:0.000}", newton3.fx(Xn)), string.Format("{0:0.000}", newton3.fxd(Xn)), Xn1.ToString(), string.Format("{0:0.000}", error));

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
                MessageBox.Show("Select Question First","Question Selection Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }


             
        }
    }
}
