using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ipl_2020
{
    public partial class IPL : Form
    {
        public IPL()
        {
            InitializeComponent();
            panel3.Visible = true;
            panel4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel5.Visible = false;
            listView1.Items.Clear();

            string connStr = "server=localhost;user=root;database=ipldb;port=3306;password=8468468";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "select * from points_table order by pos";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                var arlist1 = new System.Collections.ArrayList();
                while (rdr.Read())
                {
                    arlist1.Clear();
                    for (int i = 0; i < 9; i++)
                    {
                        arlist1.Add(rdr[i] + "");
                    }

                    var listViewItem = new ListViewItem(arlist1.ToArray(typeof(string)) as string[]);
                    listView1.Items.Add(listViewItem);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            panel7.Visible = false;
            tabPage3.Text = @"DETAILS";
            tabPage4.Text = @"OWNERS";
            listView4.Items.Clear();

            string connStr = "server=localhost;user=root;database=ipldb;port=3306;password=8468468";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = " select * from team order by owner_id; ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                var arlist1 = new System.Collections.ArrayList();
                while (rdr.Read())
                {
                    arlist1.Clear();
                    for (int i = 0; i < 5; i++)
                    {
                        arlist1.Add(rdr[i] + "");
                    }

                    var listViewItem = new ListViewItem(arlist1.ToArray(typeof(string)) as string[]);
                    listView4.Items.Add(listViewItem);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();

            listView5.Items.Clear();
            MySqlConnection conn1 = new MySqlConnection(connStr);
            try
            {
                conn1.Open();

                string sql = "select * from team_owner order by owner_id";
                MySqlCommand cmd = new MySqlCommand(sql, conn1);
                MySqlDataReader rdr = cmd.ExecuteReader();
                var arlist1 = new System.Collections.ArrayList();
                while (rdr.Read())
                {
                    arlist1.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        arlist1.Add(rdr[i] + "");
                    }

                    var listViewItem = new ListViewItem(arlist1.ToArray(typeof(string)) as string[]);
                    listView5.Items.Add(listViewItem);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn1.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel6.Visible = false;
            tabPage1.Text = @"BATSMEN STATS";
            tabPage2.Text = @"BOWLING STATS";
            listView2.Items.Clear();

            string connStr = "server=localhost;user=root;database=ipldb;port=3306;password=8468468";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "select * from batsmen_stats order by pos";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                var arlist1 = new System.Collections.ArrayList();
                while (rdr.Read())
                {
                    arlist1.Clear();
                    for (int i = 0; i < 14; i++)
                    {
                        arlist1.Add(rdr[i] + "");
                    }

                    var listViewItem = new ListViewItem(arlist1.ToArray(typeof(string)) as string[]);
                    listView2.Items.Add(listViewItem);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();

            listView3.Items.Clear();
            MySqlConnection conn1 = new MySqlConnection(connStr);
            try
            {
                conn1.Open();

                string sql = "select * from bowler_stats order by pos";
                MySqlCommand cmd = new MySqlCommand(sql, conn1);
                MySqlDataReader rdr = cmd.ExecuteReader();
                var arlist1 = new System.Collections.ArrayList();
                while (rdr.Read())
                {
                    arlist1.Clear();
                    for (int i = 0; i < 13; i++)
                    {
                        arlist1.Add(rdr[i] + "");
                    }

                    var listViewItem = new ListViewItem(arlist1.ToArray(typeof(string)) as string[]);
                    listView3.Items.Add(listViewItem);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn1.Close();

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
            tabPage5.Text = @"MI";
            tabPage6.Text = @"DC";
            tabPage7.Text = @"RCB";
            tabPage8.Text = @"SRH";
            tabPage9.Text = @"KKR";
            tabPage10.Text = @"KXIP";
            tabPage11.Text = @"CSK";
            tabPage12.Text = @"RR";

            listView6.Items.Clear();

            string connStr = "server=localhost;user=root;database=ipldb;port=3306;password=8468468";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "select * from players where team_code = 'MI' order by player_id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                var arlist1 = new System.Collections.ArrayList();
                while (rdr.Read())
                {
                    arlist1.Clear();
                    for (int i = 0; i < 6; i++)
                    {
                        arlist1.Add(rdr[i] + "");
                    }

                    var listViewItem = new ListViewItem(arlist1.ToArray(typeof(string)) as string[]);
                    listView6.Items.Add(listViewItem);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();

            listView7.Items.Clear();

            MySqlConnection conn1 = new MySqlConnection(connStr);
            try
            {
                conn1.Open();

                string sql = "select * from players where team_code = 'DC' order by player_id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn1);
                MySqlDataReader rdr = cmd.ExecuteReader();
                var arlist1 = new System.Collections.ArrayList();
                while (rdr.Read())
                {
                    arlist1.Clear();
                    for (int i = 0; i < 6; i++)
                    {
                        arlist1.Add(rdr[i] + "");
                    }

                    var listViewItem = new ListViewItem(arlist1.ToArray(typeof(string)) as string[]);
                    listView7.Items.Add(listViewItem);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn1.Close();

            listView8.Items.Clear();

            MySqlConnection conn2 = new MySqlConnection(connStr);
            try
            {
                conn2.Open();

                string sql = "select * from players where team_code = 'RCB' order by player_id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn2);
                MySqlDataReader rdr = cmd.ExecuteReader();
                var arlist1 = new System.Collections.ArrayList();
                while (rdr.Read())
                {
                    arlist1.Clear();
                    for (int i = 0; i < 6; i++)
                    {
                        arlist1.Add(rdr[i] + "");
                    }

                    var listViewItem = new ListViewItem(arlist1.ToArray(typeof(string)) as string[]);
                    listView8.Items.Add(listViewItem);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn2.Close();


            listView9.Items.Clear();

            MySqlConnection conn3 = new MySqlConnection(connStr);
            try
            {
                conn3.Open();

                string sql = "select * from players where team_code = 'SRH' order by player_id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn3);
                MySqlDataReader rdr = cmd.ExecuteReader();
                var arlist1 = new System.Collections.ArrayList();
                while (rdr.Read())
                {
                    arlist1.Clear();
                    for (int i = 0; i < 6; i++)
                    {
                        arlist1.Add(rdr[i] + "");
                    }

                    var listViewItem = new ListViewItem(arlist1.ToArray(typeof(string)) as string[]);
                    listView9.Items.Add(listViewItem);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn3.Close();

            listView10.Items.Clear();

            MySqlConnection conn4 = new MySqlConnection(connStr);
            try
            {
                conn4.Open();

                string sql = "select * from players where team_code = 'KKR' order by player_id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn4);
                MySqlDataReader rdr = cmd.ExecuteReader();
                var arlist1 = new System.Collections.ArrayList();
                while (rdr.Read())
                {
                    arlist1.Clear();
                    for (int i = 0; i < 6; i++)
                    {
                        arlist1.Add(rdr[i] + "");
                    }

                    var listViewItem = new ListViewItem(arlist1.ToArray(typeof(string)) as string[]);
                    listView10.Items.Add(listViewItem);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn4.Close();

            listView11.Items.Clear();

            MySqlConnection conn5 = new MySqlConnection(connStr);
            try
            {
                conn5.Open();

                string sql = "select * from players where team_code = 'KXIP' order by player_id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn5);
                MySqlDataReader rdr = cmd.ExecuteReader();
                var arlist1 = new System.Collections.ArrayList();
                while (rdr.Read())
                {
                    arlist1.Clear();
                    for (int i = 0; i < 6; i++)
                    {
                        arlist1.Add(rdr[i] + "");
                    }

                    var listViewItem = new ListViewItem(arlist1.ToArray(typeof(string)) as string[]);
                    listView11.Items.Add(listViewItem);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn5.Close();

            listView12.Items.Clear();

            MySqlConnection conn6 = new MySqlConnection(connStr);
            try
            {
                conn6.Open();

                string sql = "select * from players where team_code = 'CSK' order by player_id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn6);
                MySqlDataReader rdr = cmd.ExecuteReader();
                var arlist1 = new System.Collections.ArrayList();
                while (rdr.Read())
                {
                    arlist1.Clear();
                    for (int i = 0; i < 6; i++)
                    {
                        arlist1.Add(rdr[i] + "");
                    }

                    var listViewItem = new ListViewItem(arlist1.ToArray(typeof(string)) as string[]);
                    listView12.Items.Add(listViewItem);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn6.Close();


            listView13.Items.Clear();

            MySqlConnection conn7 = new MySqlConnection(connStr);
            try
            {
                conn7.Open();

                string sql = "select * from players where team_code = 'RR' order by player_id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn7);
                MySqlDataReader rdr = cmd.ExecuteReader();
                var arlist1 = new System.Collections.ArrayList();
                while (rdr.Read())
                {
                    arlist1.Clear();
                    for (int i = 0; i < 6; i++)
                    {
                        arlist1.Add(rdr[i] + "");
                    }

                    var listViewItem = new ListViewItem(arlist1.ToArray(typeof(string)) as string[]);
                    listView13.Items.Add(listViewItem);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn7.Close();

        }

        private void tabControl3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}

