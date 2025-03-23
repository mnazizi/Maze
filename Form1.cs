using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Maze
{

    public partial class Form1 : Form
    {
        double x = 0 , y = 0 ;
        double tarx , tary ;
        double[, , ] Q_table = new double[101 , 101 , 4];
        double[,,] N = new double[101 , 101 , 4];
        double alpha = 0.7;
        double gamma = 0.9;
        double epsilon = 0.99;
        double num_episodes = 30000;
        double reward = 0;
        bool done = false;
        Random rand = new Random();

        private BackgroundWorker RL_worker = new BackgroundWorker();

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;  // Ensures the form captures key events first
            this.KeyDown += Form1_KeyDown;
            RL_worker.DoWork += backgroundWorker1_DoWork;

        }

        private int Random_action()
        {
            Int32 temp = rand.Next(4);
                return temp;
        }
        private (double , int) Max_action(double xloc ,  double yloc)
        {
            double max_action = 0;
            int max_action_index = 0 ;
            max_action = Q_table[(int)xloc, (int)yloc, 0];
            max_action_index = 0;

            for (int i = 0; i < 3; i++)
            {
                if (max_action < Q_table[(int)xloc, (int)yloc, i+1])
                {
                    max_action = Q_table[(int)xloc, (int)yloc, i + 1];
                    max_action_index = i+1;
                }
            }
            return (max_action , max_action_index);
        }
        double step_with(int a)
        {
            double c_x = x , c_y = y ;
            double temp_rew;
            switch (a)
            {
                case 0:
                    btndown.Invoke(new Action(() => btndown_Click(this, new EventArgs())));
                    break;
                case 1:
                    btnup.Invoke(new Action(() => btnup_Click(this, new EventArgs())));
                    break;
                case 2:
                    btnright.Invoke(new Action(() => btnright_Click(this, new EventArgs())));
                    break;
                case 3:
                    btnleft.Invoke(new Action(() => btnleft_Click(this, new EventArgs())));
                    break;
            }
            if (done)
                temp_rew = 1000;
            else if (c_x == x && c_y == y)
                temp_rew = -1000;
            else
                temp_rew = -100;

                return temp_rew;
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int a = 4;
            double current_x , current_y ;
            double max_action_value;
            int min_step = Q_table.GetLength(0)* Q_table.GetLength(1);
            chart2.Invoke(new Action(() => chart2.Series["stepnumber"].Points.Clear()));
            for (int i = 0; i < num_episodes; i++)
            {
                lblepisodenum.Invoke(new Action(() => lblepisodenum.Text = i.ToString()));
                int j = 0;
                while(!done)
                { 
                    double randomDouble = rand.NextDouble();
                    if (randomDouble < epsilon)
                        a = Random_action();
                    else
                        (max_action_value  , a) = Max_action(x , y);
                    current_x = x;
                    current_y = y;
                    reward = step_with(a);
                    (max_action_value, a) = Max_action(x, y);
                    N[(int)current_x, (int)current_y, a]++;

                    double bonus = 0.1 * (1.0 / Math.Sqrt(N[(int)current_x, (int)current_y, a] + 1));
                    Q_table[(int)current_x, (int)current_y, a] += alpha * (reward  /*bonus*/ + gamma * max_action_value - Q_table[(int)current_x, (int)current_y, a]);
                    j++;
                    if (j % 1000 == 0)
                    {
                        lblstepnumber.Invoke(new Action(() => lblstepnumber.Text = j.ToString()));
                        chart1.Invoke(new Action(() => chart1.Series["Trace"].Points.Clear()));

                    }
                }
                if(min_step>j)
                    { min_step = j; }
                alpha = Math.Max(0.1, 0.7 * (Math.Pow(0.999, i)));
                epsilon = Math.Max(0.01, 0.5 * (Math.Pow(0.999, i)));
                lblminstep.Invoke(new Action(() => lblminstep.Text = min_step.ToString()));
                lblexplosionrate.Invoke(new Action(() => lblexplosionrate.Text = epsilon.ToString()));
                Thread.Sleep(1);
                chart2.Invoke(new Action(()=> chart2.Series["stepnumber"].Points.AddXY(i, j)));
                done = false;
                
                //Q[s, a] = Q[s, a] + alpha * (reward + gamma * max_action_value) - Q[s, a])

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tarx = Convert.ToDouble(txttargetx.Text);
            tary = Convert.ToDouble(txttargety.Text);
            x = Convert.ToDouble(txtstartx.Text);
            y = Convert.ToDouble(txtstarty.Text);
            btnleft.Enabled = false;
            btnright.Enabled = false;
            btnup.Enabled = false;
            btndown.Enabled = false;
            Set_marker(x , y);
            for (int i = 0; i < Q_table.GetLength(0); i++)
            {
                for (int j = 0; j < Q_table.GetLength(1); j++)
                {
                    for (int k = 0; k < Q_table.GetLength(2); k++)
                    {
                        Q_table[i, j, k] = 0;
                    }
                }
            }
            chart1.ChartAreas[0].AxisX.Maximum = Q_table.GetLength(0)-1;
            chart1.ChartAreas[0].AxisY.Maximum = Q_table.GetLength(1)-1;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart2.ChartAreas[0].AxisX.Maximum = num_episodes;
            chart2.ChartAreas[0].AxisY.Maximum =  100000;
            chart2.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart2.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

        }

        private void btnup_Click(object sender, EventArgs e)
        {
            Set_marker(x, y+1);
        }

        private void btnleft_Click(object sender, EventArgs e)
        {
            Set_marker(x-1, y);
        }

        private void btnright_Click(object sender, EventArgs e)
        {
            Set_marker(x+1, y);
        }

        private void btndown_Click(object sender, EventArgs e)
        {
            Set_marker(x, y-1);
        }

        private void btncleartrace_Click(object sender, EventArgs e)
        {
            chart1.Series["Trace"].Points.Clear();
        }

        private void btnstartgame_Click(object sender, EventArgs e)
        {
            if (btnstartgame.Text == "Start Game")
            {
                btnup.Enabled = true;
                btnleft.Enabled = true;
                btnright.Enabled = true;
                btndown.Enabled = true;
                txtstartx.Enabled = false;
                txtstarty.Enabled = false;
                txttargetx.Enabled = false;
                txttargety.Enabled = false;
                tarx = Convert.ToDouble(txttargetx.Text);
                tary = Convert.ToDouble(txttargety.Text);
                x = Convert.ToDouble(txtstartx.Text);
                y = Convert.ToDouble(txtstarty.Text);
                btnstartgame.Text = "Stop Game";
                chart1.Series["Target"].Points.Clear();
                chart1.Series["Target"].Points.AddXY(tarx, tary);
                done = false;

            }
            else if (btnstartgame.Text == "Stop Game")
            {
                btnup.Enabled = false;
                btnleft.Enabled = false;
                btnright.Enabled = false;
                btndown.Enabled = false;
                txtstartx.Enabled = true;
                txtstarty.Enabled = true;
                txttargetx.Enabled = true;
                txttargety.Enabled = true;
                tarx = Convert.ToDouble(txttargetx.Text);
                tary = Convert.ToDouble(txttargety.Text);
                x = Convert.ToDouble(txtstartx.Text);
                y = Convert.ToDouble(txtstarty.Text);
                btnstartgame.Text = "Start Game";
                done = true;

            }
        }
        object temp_sender;

        private void txtstartx_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtstartx.Text) > chart1.ChartAreas[0].AxisX.Maximum || Convert.ToDouble(txtstartx.Text) < chart1.ChartAreas[0].AxisX.Minimum)
                txtstartx.Text = "";
        }

        private void txtstarty_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtstarty.Text) > chart1.ChartAreas[0].AxisY.Maximum || Convert.ToDouble(txtstarty.Text) < chart1.ChartAreas[0].AxisY.Minimum)
                txtstarty.Text = "";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    btnup.PerformClick();
                    break;
                case Keys.Down:
                    btndown.PerformClick();
                    break;
                case Keys.Left:
                    btnleft.PerformClick();
                    break;
                case Keys.Right:
                    btnright.PerformClick();
                    break;
            }
        }

        private void btnrunrl_Click(object sender, EventArgs e)
        {
            if(btnrunrl.Text == "Run RL")
            {
                if (!RL_worker.IsBusy)
                {
                    RL_worker.RunWorkerAsync(); // Start background task
                }
                btnrunrl.Text = "Stop RL";
            }
            else if (btnrunrl.Text == "Stop RL")
            {
                if (RL_worker.IsBusy)
                {
                    RL_worker.CancelAsync(); // Request cancellation
                }
                btnrunrl.Text = "Run RL";
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        EventArgs temp_e;
        private void Set_marker(double xloc, double yloc)
        {
            if (xloc > chart1.ChartAreas[0].AxisX.Maximum || xloc < chart1.ChartAreas[0].AxisX.Minimum)
                return;
            if (yloc > chart1.ChartAreas[0].AxisY.Maximum || yloc < chart1.ChartAreas[0].AxisY.Minimum)
                return;

            x = xloc; y = yloc;
            lblxloc.Text = x.ToString();
            lblyloc.Text = y.ToString();
            chart1.Series["Trace"].Points.AddXY(x, y);
            chart1.Series["Marker"].Points.Clear();
            chart1.Series["Marker"].Points.AddXY(x, y);
            if ((Math.Pow((tarx - x), 2) + Math.Pow((tary - y),2)) <= 1)
            {
                //MessageBox.Show("You Win the Game!");
                done = true;
                btncleartrace_Click(temp_sender, temp_e);
                x = Convert.ToDouble(txtstartx.Text);
                y = Convert.ToDouble(txtstarty.Text);

            }

        }

    }
}
