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
    public partial class RegularFalsi : Form
    {
        public RegularFalsi()
        {
            InitializeComponent();
            dataGridView1.DataSource = table;
            table.Columns.Add("S.NO", typeof(double));
            table.Columns.Add("A", typeof(double));
            table.Columns.Add("B", typeof(double));
            table.Columns.Add("F(A)", typeof(double));
            table.Columns.Add("F(B)", typeof(double));
            table.Columns.Add("C=(A+B)/2", typeof(double));
            table.Columns.Add("F(C)", typeof(double));
            table.Columns.Add("E=|(B-A)/2|", typeof(double));

        }

        Questions ques = new Questions();
        Double a, b, c, error, ctemp;
        public double regular1(double x)
        {

            return (Math.Pow(Math.E, -x)) - x;
        }

        private void regularFalsiMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
               MessageBox.Show("This Section Is Already Opened!", "Window Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
       
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void questions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        DataTable table = new DataTable();
        private void bisectionMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 bisection = new Form1();
            bisection.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtA.Text == "" && txtB.Text == "")
            {
                if (questions.SelectedIndex == 0)
                {
                   
                    for (int i = 0; i < 10; i++)
                    {
                        if (regular1(i) < 0 && regular1(i + 1) > 0)
                        {
                            a = i;
                            b = i + 1;
                            break;
                        }
                    }

                    int row = dataGridView1.Rows.Count;
                    if (row > 0)
                    {
                        table.Rows.Clear();

                    }
                    MessageBox.Show(a.ToString());
                    MessageBox.Show(b.ToString());

                    ctemp = Convert.ToDouble(string.Format("{0:0.000}", ((a * ques.regular1(b) - b * ques.regular1(a)) / (ques.regular1(b) - ques.regular1(a)))));

                    error = Math.Abs(ctemp);

                    for (int i = 0; i < 50; i++)
                    {

                        if (string.Format("{0:0.000}", error) != string.Format("{0:0.000}", 0.000))
                        {

                            table.Rows.Add((i + 1).ToString(), string.Format("{0:0.000}", a), string.Format("{0:0.000}", b), string.Format("{0:0.000}", ques.regular1(a)), string.Format("{0:0.000}", ques.regular1(b)), ctemp.ToString(), string.Format("{0:0.000}", ques.regular1(ctemp)), string.Format("{0:0.000}", error));

                            if (ques.regular1(a) * ques.regular1(c) < 0)
                            {
                                b = ctemp;
                                c = Convert.ToDouble(string.Format("{0:0.000}", (a * ques.regular1(b) - ctemp * ques.regular1(a)) / (ques.regular1(b) - ques.regular1(a))));

                                error = Convert.ToDouble(string.Format("{0:0.000}", Math.Abs(c - ctemp)));
                                ctemp = c;
                            }
                            else
                            {
                                a = ctemp;
                                c = Convert.ToDouble(string.Format("{0:0.000}", (ctemp * ques.regular1(b) - b * ques.regular1(a)) / (ques.regular1(b) - ques.regular1(a))));

                                error = Convert.ToDouble(string.Format("{0:0.000}", Math.Abs(c - ctemp)));
                                ctemp = c;
                            }


                        }
                        else
                        {
                            break;
                        }

                    }
                 
                }

                if (questions.SelectedIndex == 1)
                {



                    for (int i = 0; i < 10; i++)
                    {
                        if (ques.regular2(i) < 0 && ques.regular2(i + 1) > 0)
                        {
                            a = i;
                            b = i + 1;
                            break;
                        }
                    }

                    int row = dataGridView1.Rows.Count;
                    if (row > 0)
                    {
                        table.Rows.Clear();
                      
                    }
                    MessageBox.Show(a.ToString());
                    MessageBox.Show(b.ToString());

                    ctemp = Convert.ToDouble(string.Format("{0:0.000}", ((a * ques.regular2(b) - b * ques.regular2(a)) / (ques.regular2(b) - ques.regular2(a)))));

                    error = Math.Abs(ctemp);

                    for (int i = 0; i < 50; i++)
                    {

                        if (string.Format("{0:0.000}", error) != string.Format("{0:0.000}", 0.000))
                        {

                            table.Rows.Add((i + 1).ToString(), string.Format("{0:0.000}", a), string.Format("{0:0.000}", b), string.Format("{0:0.000}", ques.regular2(a)), string.Format("{0:0.000}", ques.regular2(b)), ctemp.ToString(), string.Format("{0:0.000}", ques.regular2(ctemp)), string.Format("{0:0.000}", error));

                            if (ques.regular2(a) * ques.regular2(c) < 0)
                            {
                                b = ctemp;
                                c = Convert.ToDouble(string.Format("{0:0.000}", (a * ques.regular2(b) - ctemp * ques.regular2(a)) / (ques.regular2(b) - ques.regular2(a))));

                                error = Convert.ToDouble(string.Format("{0:0.000}", Math.Abs(c - ctemp)));
                                ctemp = c;
                            }
                            else
                            {
                                a = ctemp;
                                c = Convert.ToDouble(string.Format("{0:0.000}", (ctemp * ques.regular2(b) - b * ques.regular2(a)) / (ques.regular2(b) - ques.regular2(a))));

                                error = Convert.ToDouble(string.Format("{0:0.000}", Math.Abs(c - ctemp)));
                                ctemp = c;
                            }


                        }
                        else
                        {
                            break;
                        }

                    }
                }

                if (questions.SelectedIndex == 2)
                {
                    int row = dataGridView1.Rows.Count;
                    if (row > 0)
                    {
                        table.Rows.Clear();
                      
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        if (ques.regular3(i) < 0 && ques.regular3(i + 1) > 0)
                        {
                            a = i;
                            b = i + 1;
                            break;
                        }
                    }
                    MessageBox.Show(a.ToString());
                    MessageBox.Show(b.ToString());
                    ctemp = Convert.ToDouble(string.Format("{0:0.000}", ((a * ques.regular3(b) - b * ques.regular3(a)) / (ques.regular3(b) - ques.regular3(a)))));

                    error = Math.Abs(ctemp);

                    for (int i = 0; i < 50; i++)
                    {

                        if (string.Format("{0:0.000}", error) != string.Format("{0:0.000}", 0.000))
                        {

                            table.Rows.Add((i + 1).ToString(), string.Format("{0:0.000}", a), string.Format("{0:0.000}", b), string.Format("{0:0.000}", ques.regular3(a)), string.Format("{0:0.000}", ques.regular3(b)), ctemp.ToString(), string.Format("{0:0.000}", ques.regular3(ctemp)), string.Format("{0:0.000}", error));

                            if (ques.regular3(a) * ques.regular3(c) < 0)
                            {
                                b = ctemp;
                                c = Convert.ToDouble(string.Format("{0:0.000}", (a * ques.regular3(b) - ctemp * ques.regular3(a)) / (ques.regular3(b) - ques.regular3(a))));

                                error = Convert.ToDouble(string.Format("{0:0.000}", Math.Abs(c - ctemp)));
                                ctemp = c;
                            }
                            else
                            {
                                a = ctemp;
                                c = Convert.ToDouble(string.Format("{0:0.000}", (ctemp * ques.regular3(b) - b * ques.regular3(a)) / (ques.regular3(b) - ques.regular3(a))));

                                error = Convert.ToDouble(string.Format("{0:0.000}", Math.Abs(c - ctemp)));
                                ctemp = c;
                            }


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
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                if (questions.SelectedIndex == 0)
                {

                    int row = dataGridView1.Rows.Count;
                    if (row > 0)
                    {
                        table.Rows.Clear();
                     
                    }



                    ctemp = Convert.ToDouble(string.Format("{0:0.000}", ((a * Convert.ToDouble(string.Format("{0:0.000}", ques.regular1(b))) - b * Convert.ToDouble(string.Format("{0:0.000}", ques.regular1(a)))) / (Convert.ToDouble(string.Format("{0:0.000}", ques.regular1(b))) - Convert.ToDouble(string.Format("{0:0.000}", ques.regular1(a)))))));

                    error = Math.Abs(ctemp);

                    for (int i = 0; i < 50; i++)
                    {

                        if (string.Format("{0:0.000}", error) != string.Format("{0:0.000}", 0.000))
                        {

                            table.Rows.Add((i + 1).ToString(), string.Format("{0:0.000}", a), string.Format("{0:0.000}", b), string.Format("{0:0.000}", ques.regular1(a)), string.Format("{0:0.000}", ques.regular1(b)), ctemp.ToString(), string.Format("{0:0.000}", ques.regular1(ctemp)), string.Format("{0:0.000}", error));

                            if (ques.regular1(a) * ques.regular1(c) < 0)
                            {
                                b = ctemp;
                                c = Convert.ToDouble(string.Format("{0:0.000}", (a * ques.regular1(b) - ctemp * ques.regular1(a)) / (ques.regular1(b) - ques.regular1(a))));

                                error = Convert.ToDouble(string.Format("{0:0.000}", Math.Abs(c - ctemp)));
                                ctemp = c;
                            }
                            else
                            {
                                a = ctemp;
                                c = Convert.ToDouble(string.Format("{0:0.000}", (ctemp * ques.regular1(b) - b * ques.regular1(a)) / (ques.regular1(b) - ques.regular1(a))));

                                error = Convert.ToDouble(string.Format("{0:0.000}", Math.Abs(c - ctemp)));
                                ctemp = c;
                            }


                        }
                        else
                        {
                            break;
                        }

                    }


                }

                if (questions.SelectedIndex == 1)
                {


                    int row = dataGridView1.Rows.Count;
                    if (row > 0)
                    {
                        table.Rows.Clear();
                    }


                    c = (a + b) / 2;
                    error = Math.Abs((b - a) / 2);


                    for (int i = 0; i < 50; i++)
                    {
                        if (string.Format("{0:0.000}", error) != string.Format("{0:0.000}", 0.000))
                        {

                            table.Rows.Add((i + 1).ToString(), a.ToString(), b.ToString(), ques.bisection2(a).ToString(), ques.bisection2(b).ToString(), c.ToString(), ques.bisection2(c).ToString(), error.ToString());

                            if (ques.bisection2(a) * ques.bisection2(c) < 0)
                            {
                                b = c;
                                c = (a + b) / 2;
                                error = Math.Abs((b - a) / 2);
                            }
                            else
                            {
                                a = c;
                                c = (a + b) / 2;
                                error = Math.Abs((b - a) / 2);

                            }
                             

                        }
                        else
                        {
                            break;
                        }

                    }
                }

                if (questions.SelectedIndex == 2)
                {
                    int row = dataGridView1.Rows.Count;
                    if (row > 0)
                    {
                        table.Rows.Clear();
                    }



                    c = (a + b) / 2;
                    error = Math.Abs((b - a) / 2);


                    for (int i = 0; i < 50; i++)
                    {
                        if (string.Format("{0:0.000}", error) != string.Format("{0:0.000}", 0.000))
                        {

                            table.Rows.Add((i + 1).ToString(), a.ToString(), b.ToString(), ques.bisection3(a).ToString(), ques.bisection3(b).ToString(), c.ToString(), ques.bisection3(c).ToString(), error.ToString());

                            if (ques.bisection3(a) * ques.bisection3(c) < 0)
                            {
                                b = c;
                                c = (a + b) / 2;
                                error = Math.Abs((b - a) / 2);
                            }
                            else
                            {
                                a = c;
                                c = (a + b) / 2;
                                error = Math.Abs((b - a) / 2);

                            }

                          
                        }
                        else
                        {
                            break;
                        }

                    }

                }
            }
        }
    }
}
