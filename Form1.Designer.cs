namespace Maze
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnup = new System.Windows.Forms.Button();
            this.btndown = new System.Windows.Forms.Button();
            this.btnright = new System.Windows.Forms.Button();
            this.btnleft = new System.Windows.Forms.Button();
            this.lblx = new System.Windows.Forms.Label();
            this.lbly = new System.Windows.Forms.Label();
            this.lblxloc = new System.Windows.Forms.Label();
            this.lblyloc = new System.Windows.Forms.Label();
            this.btncleartrace = new System.Windows.Forms.Button();
            this.txttargety = new System.Windows.Forms.TextBox();
            this.txttargetx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtstartx = new System.Windows.Forms.TextBox();
            this.txtstarty = new System.Windows.Forms.TextBox();
            this.btnstartgame = new System.Windows.Forms.Button();
            this.btnrunrl = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblepisodenum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblstepnumber = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.lblexplosionrate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblminstep = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.CausesValidation = false;
            chartArea1.AxisX.MajorGrid.Interval = 1D;
            chartArea1.AxisX.Maximum = 20D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.MajorGrid.Interval = 1D;
            chartArea1.AxisY.Maximum = 20D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.CursorX.AutoScroll = false;
            chartArea1.CursorX.LineWidth = 20;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 4);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.OrangeRed;
            series1.MarkerSize = 7;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross;
            series1.Name = "Trace";
            series1.YValuesPerPoint = 20;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.DarkViolet;
            series2.MarkerSize = 10;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series2.Name = "Marker";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Legend = "Legend1";
            series3.MarkerColor = System.Drawing.Color.Blue;
            series3.MarkerSize = 20;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star5;
            series3.Name = "Target";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(576, 518);
            this.chart1.TabIndex = 0;
            this.chart1.TabStop = false;
            this.chart1.Text = "chart1";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btnup
            // 
            this.btnup.BackColor = System.Drawing.SystemColors.Control;
            this.btnup.CausesValidation = false;
            this.btnup.Location = new System.Drawing.Point(1047, 71);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(83, 49);
            this.btnup.TabIndex = 0;
            this.btnup.TabStop = false;
            this.btnup.Text = "UP";
            this.btnup.UseVisualStyleBackColor = false;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            this.btnup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btndown
            // 
            this.btndown.BackColor = System.Drawing.SystemColors.Control;
            this.btndown.CausesValidation = false;
            this.btndown.Location = new System.Drawing.Point(1047, 181);
            this.btndown.Name = "btndown";
            this.btndown.Size = new System.Drawing.Size(83, 49);
            this.btndown.TabIndex = 0;
            this.btndown.TabStop = false;
            this.btndown.Text = "DWON";
            this.btndown.UseVisualStyleBackColor = false;
            this.btndown.Click += new System.EventHandler(this.btndown_Click);
            this.btndown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btnright
            // 
            this.btnright.BackColor = System.Drawing.SystemColors.Control;
            this.btnright.CausesValidation = false;
            this.btnright.Location = new System.Drawing.Point(1108, 126);
            this.btnright.Name = "btnright";
            this.btnright.Size = new System.Drawing.Size(83, 49);
            this.btnright.TabIndex = 0;
            this.btnright.TabStop = false;
            this.btnright.Text = "RIGHT";
            this.btnright.UseVisualStyleBackColor = false;
            this.btnright.Click += new System.EventHandler(this.btnright_Click);
            this.btnright.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btnleft
            // 
            this.btnleft.BackColor = System.Drawing.SystemColors.Control;
            this.btnleft.CausesValidation = false;
            this.btnleft.Location = new System.Drawing.Point(982, 126);
            this.btnleft.Name = "btnleft";
            this.btnleft.Size = new System.Drawing.Size(83, 49);
            this.btnleft.TabIndex = 0;
            this.btnleft.TabStop = false;
            this.btnleft.Text = "LEFT";
            this.btnleft.UseVisualStyleBackColor = false;
            this.btnleft.Click += new System.EventHandler(this.btnleft_Click);
            this.btnleft.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.Location = new System.Drawing.Point(983, 259);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(97, 22);
            this.lblx.TabIndex = 3;
            this.lblx.Text = "Marker X : ";
            // 
            // lbly
            // 
            this.lbly.AutoSize = true;
            this.lbly.Location = new System.Drawing.Point(983, 292);
            this.lbly.Name = "lbly";
            this.lbly.Size = new System.Drawing.Size(97, 22);
            this.lbly.TabIndex = 4;
            this.lbly.Text = "Marker Y : ";
            // 
            // lblxloc
            // 
            this.lblxloc.AutoSize = true;
            this.lblxloc.Location = new System.Drawing.Point(1099, 259);
            this.lblxloc.Name = "lblxloc";
            this.lblxloc.Size = new System.Drawing.Size(0, 22);
            this.lblxloc.TabIndex = 5;
            // 
            // lblyloc
            // 
            this.lblyloc.AutoSize = true;
            this.lblyloc.Location = new System.Drawing.Point(1099, 292);
            this.lblyloc.Name = "lblyloc";
            this.lblyloc.Size = new System.Drawing.Size(0, 22);
            this.lblyloc.TabIndex = 6;
            // 
            // btncleartrace
            // 
            this.btncleartrace.Location = new System.Drawing.Point(987, 337);
            this.btncleartrace.Name = "btncleartrace";
            this.btncleartrace.Size = new System.Drawing.Size(143, 41);
            this.btncleartrace.TabIndex = 0;
            this.btncleartrace.Text = "Clear Trace";
            this.btncleartrace.UseVisualStyleBackColor = true;
            this.btncleartrace.Click += new System.EventHandler(this.btncleartrace_Click);
            // 
            // txttargety
            // 
            this.txttargety.Location = new System.Drawing.Point(1091, 431);
            this.txttargety.Name = "txttargety";
            this.txttargety.Size = new System.Drawing.Size(39, 28);
            this.txttargety.TabIndex = 0;
            this.txttargety.Text = "8";
            // 
            // txttargetx
            // 
            this.txttargetx.Location = new System.Drawing.Point(1091, 397);
            this.txttargetx.Name = "txttargetx";
            this.txttargetx.Size = new System.Drawing.Size(39, 28);
            this.txttargetx.TabIndex = 0;
            this.txttargetx.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(975, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Target X :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(975, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Target Y :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(978, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Start Y :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(978, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Start X :";
            // 
            // txtstartx
            // 
            this.txtstartx.Location = new System.Drawing.Point(1094, 6);
            this.txtstartx.Name = "txtstartx";
            this.txtstartx.Size = new System.Drawing.Size(39, 28);
            this.txtstartx.TabIndex = 0;
            this.txtstartx.Text = "0";
            this.txtstartx.TextChanged += new System.EventHandler(this.txtstartx_TextChanged);
            // 
            // txtstarty
            // 
            this.txtstarty.Location = new System.Drawing.Point(1094, 40);
            this.txtstarty.Name = "txtstarty";
            this.txtstarty.Size = new System.Drawing.Size(39, 28);
            this.txtstarty.TabIndex = 0;
            this.txtstarty.Text = "0";
            this.txtstarty.TextChanged += new System.EventHandler(this.txtstarty_TextChanged);
            // 
            // btnstartgame
            // 
            this.btnstartgame.Location = new System.Drawing.Point(1091, 465);
            this.btnstartgame.Name = "btnstartgame";
            this.btnstartgame.Size = new System.Drawing.Size(111, 38);
            this.btnstartgame.TabIndex = 0;
            this.btnstartgame.Text = "Start Game";
            this.btnstartgame.UseVisualStyleBackColor = true;
            this.btnstartgame.Click += new System.EventHandler(this.btnstartgame_Click);
            // 
            // btnrunrl
            // 
            this.btnrunrl.Location = new System.Drawing.Point(974, 465);
            this.btnrunrl.Name = "btnrunrl";
            this.btnrunrl.Size = new System.Drawing.Size(111, 38);
            this.btnrunrl.TabIndex = 0;
            this.btnrunrl.Text = "Run RL";
            this.btnrunrl.UseVisualStyleBackColor = true;
            this.btnrunrl.Click += new System.EventHandler(this.btnrunrl_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 526);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "episode : ";
            // 
            // lblepisodenum
            // 
            this.lblepisodenum.AutoSize = true;
            this.lblepisodenum.Location = new System.Drawing.Point(164, 526);
            this.lblepisodenum.Name = "lblepisodenum";
            this.lblepisodenum.Size = new System.Drawing.Size(0, 22);
            this.lblepisodenum.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 526);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "episode  step: ";
            // 
            // lblstepnumber
            // 
            this.lblstepnumber.AutoSize = true;
            this.lblstepnumber.Location = new System.Drawing.Point(455, 526);
            this.lblstepnumber.Name = "lblstepnumber";
            this.lblstepnumber.Size = new System.Drawing.Size(0, 22);
            this.lblstepnumber.TabIndex = 15;
            // 
            // chart2
            // 
            this.chart2.CausesValidation = false;
            chartArea2.AxisX.MajorGrid.Interval = 1D;
            chartArea2.AxisX.Maximum = 20D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.MajorGrid.Interval = 1D;
            chartArea2.AxisY.Maximum = 20D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.CursorX.AutoScroll = false;
            chartArea2.CursorX.LineWidth = 20;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(587, 4);
            this.chart2.Margin = new System.Windows.Forms.Padding(4);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "stepnumber";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(381, 518);
            this.chart2.TabIndex = 0;
            this.chart2.TabStop = false;
            this.chart2.Text = "chart1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(592, 526);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Explosion Rate : ";
            // 
            // lblexplosionrate
            // 
            this.lblexplosionrate.AutoSize = true;
            this.lblexplosionrate.Location = new System.Drawing.Point(744, 526);
            this.lblexplosionrate.Name = "lblexplosionrate";
            this.lblexplosionrate.Size = new System.Drawing.Size(0, 22);
            this.lblexplosionrate.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(322, 548);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Minimum Step : ";
            // 
            // lblminstep
            // 
            this.lblminstep.AutoSize = true;
            this.lblminstep.Location = new System.Drawing.Point(455, 548);
            this.lblminstep.Name = "lblminstep";
            this.lblminstep.Size = new System.Drawing.Size(0, 22);
            this.lblminstep.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1203, 569);
            this.Controls.Add(this.lblminstep);
            this.Controls.Add(this.lblepisodenum);
            this.Controls.Add(this.lblstepnumber);
            this.Controls.Add(this.lblexplosionrate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnrunrl);
            this.Controls.Add(this.btnstartgame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtstartx);
            this.Controls.Add(this.txtstarty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttargetx);
            this.Controls.Add(this.txttargety);
            this.Controls.Add(this.btncleartrace);
            this.Controls.Add(this.lblyloc);
            this.Controls.Add(this.lblxloc);
            this.Controls.Add(this.lbly);
            this.Controls.Add(this.lblx);
            this.Controls.Add(this.btnleft);
            this.Controls.Add(this.btndown);
            this.Controls.Add(this.btnright);
            this.Controls.Add(this.btnup);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.Button btndown;
        private System.Windows.Forms.Button btnright;
        private System.Windows.Forms.Button btnleft;
        private System.Windows.Forms.Label lblx;
        private System.Windows.Forms.Label lbly;
        private System.Windows.Forms.Label lblxloc;
        private System.Windows.Forms.Label lblyloc;
        private System.Windows.Forms.Button btncleartrace;
        private System.Windows.Forms.TextBox txttargety;
        private System.Windows.Forms.TextBox txttargetx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtstartx;
        private System.Windows.Forms.TextBox txtstarty;
        private System.Windows.Forms.Button btnstartgame;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnrunrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblepisodenum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblstepnumber;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblexplosionrate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblminstep;
    }
}

