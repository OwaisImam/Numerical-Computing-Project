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
    public partial class Form1 : Form
    {
        public Form1()
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
        Double a, b, c, error;
        DataTable table = new DataTable();

        private void regularFalsiMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegularFalsi regular = new RegularFalsi();
            regular.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void secantMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Secant secant = new Secant();
            secant.Show();
            this.Hide();
        }

        private void newtonRaphsonMEthodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Newton newton = new Newton();
            newton.Show();
            this.Hide();
        }

        private void fixedPointMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fixed fixedpoint = new Fixed();
            fixedpoint.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
          
            if (txtA.Text == "" && txtB.Text == "")
            {
                if(questions.SelectedIndex == 0)
                {

                    int row = dataGridView1.Rows.Count;
                    if (row > 0)
                    {
                        table.Rows.Clear();
                    }


                    for (int i = 0; i < 10; i++)
                    {
                        if (ques.bisection1(i) < 0 && ques.bisection1(i + 1) > 0)
                        {
                            a = i;
                            b = i + 1;
                            break;
                        }
                    }

                    c = (a + b) / 2;
                    error = Math.Abs((b - a) / 2);
                  
               

                    for (int i = 0; i < 50; i++)
                    {
                        if (string.Format("{0:0.000}", error) != string.Format("{0:0.000}", 0.000))
                        {

                            table.Rows.Add((i + 1).ToString(), string.Format("{0:0.000}", a), string.Format("{0:0.000}", b), string.Format("{0:0.000}", (ques.bisection1(a))), string.Format("{0:0.000}", (ques.bisection1(b))), string.Format("{0:0.000}", c), string.Format("{0:0.000}", ques.bisection1(c)), string.Format("{0:0.000}", error));

                            if (ques.bisection1(a) * ques.bisection1(c) < 0)
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

                if (questions.SelectedIndex == 1)
                {
                    
                    for(int i = 0; i < 10; i++)
                    {
                        if (ques.bisection2(i) < 0 && ques.bisection2(i + 1) > 0)
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

               
                    c = (a + b) / 2;
                    error = Math.Abs((b - a) / 2);



               

                    for (int i = 0; i < 50; i++)
                    {
                        if (string.Format("{0:0.000}", error) != string.Format("{0:0.000}", 0.000))
                        {
                            table.Rows.Add((i + 1).ToString(), string.Format("{0:0.000}", a), string.Format("{0:0.000}", b), string.Format("{0:0.000}", (ques.bisection2(a))), string.Format("{0:0.000}", (ques.bisection2(b))), string.Format("{0:0.000}", c), string.Format("{0:0.000}", ques.bisection2(c)), string.Format("{0:0.000}", error));
                            

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

                    for (int i = 0; i < 10; i++)
                    {
                        if (ques.bisection3(i) < 0 && ques.bisection3(i + 1) > 0)
                        {
                            a = i;
                            b = i + 1;
                            break;
                        }
                    }

                    c = (a + b) / 2;
                    error = Math.Abs((b - a) / 2);




                    for (int i = 0; i < 50; i++)
                    {
                        if (string.Format("{0:0.000}", error) != string.Format("{0:0.000}", 0.000))
                        {

                            table.Rows.Add((i + 1).ToString(), string.Format("{0:0.000}", a), string.Format("{0:0.000}", b), string.Format("{0:0.000}", (ques.bisection3(a))), string.Format("{0:0.000}", (ques.bisection3(b))), string.Format("{0:0.000}", c), string.Format("{0:0.000}", ques.bisection3(c)), string.Format("{0:0.000}", error));


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


                 
                    c = (a + b) / 2;
                    error = Math.Abs((b - a) / 2);



                    for (int i = 0; i < 50; i++)
                    {
                        if (string.Format("{0:0.000}", error) != string.Format("{0:0.000}", 0.000))
                        {

                            table.Rows.Add((i + 1).ToString(), a.ToString(), b.ToString(), ques.bisection1(a).ToString(), ques.bisection1(b).ToString(), c.ToString(), ques.bisection1(c).ToString(), error.ToString());

                            if (ques.bisection1(a) * ques.bisection1(c) < 0)
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
