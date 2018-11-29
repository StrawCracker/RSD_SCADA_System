namespace RSDSCADA
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Time = new System.Windows.Forms.Label();
            this.Ticket = new System.Windows.Forms.Label();
            this.Order = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Yellow = new System.Windows.Forms.Label();
            this.Red = new System.Windows.Forms.Label();
            this.Blue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Hold = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.OrderPoints = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.OEE_PROC = new System.Windows.Forms.Label();
            this.OEE_Quality_Proc = new System.Windows.Forms.Label();
            this.OEE_Performance_Proc = new System.Windows.Forms.Label();
            this.OEE_Availability_Proc = new System.Windows.Forms.Label();
            this.OEE_Quality = new System.Windows.Forms.Label();
            this.OEE_Performance = new System.Windows.Forms.Label();
            this.OEE_Availability = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Uptime = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Lable8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Log = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.redDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yellowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ontime = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CorrectOrder = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.form1ViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1ViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Time);
            this.groupBox1.Controls.Add(this.Ticket);
            this.groupBox1.Controls.Add(this.Order);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Yellow);
            this.groupBox1.Controls.Add(this.Red);
            this.groupBox1.Controls.Add(this.Blue);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(88, 187);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(30, 13);
            this.Time.TabIndex = 12;
            this.Time.Text = "Time";
            // 
            // Ticket
            // 
            this.Ticket.AutoSize = true;
            this.Ticket.Location = new System.Drawing.Point(88, 58);
            this.Ticket.Name = "Ticket";
            this.Ticket.Size = new System.Drawing.Size(37, 13);
            this.Ticket.TabIndex = 11;
            this.Ticket.Text = "Ticket";
            // 
            // Order
            // 
            this.Order.AutoSize = true;
            this.Order.Location = new System.Drawing.Point(88, 34);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(33, 13);
            this.Order.TabIndex = 10;
            this.Order.Text = "Order";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Time";
            // 
            // Yellow
            // 
            this.Yellow.AutoSize = true;
            this.Yellow.Location = new System.Drawing.Point(88, 153);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(38, 13);
            this.Yellow.TabIndex = 8;
            this.Yellow.Text = "Yellow";
            // 
            // Red
            // 
            this.Red.AutoSize = true;
            this.Red.Location = new System.Drawing.Point(88, 130);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(27, 13);
            this.Red.TabIndex = 7;
            this.Red.Text = "Red";
            // 
            // Blue
            // 
            this.Blue.AutoSize = true;
            this.Blue.Location = new System.Drawing.Point(88, 107);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(28, 13);
            this.Blue.TabIndex = 6;
            this.Blue.Text = "Blue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Yellow";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Red";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Blue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bricks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ticket";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Clear);
            this.groupBox2.Controls.Add(this.Stop);
            this.groupBox2.Controls.Add(this.Hold);
            this.groupBox2.Controls.Add(this.Start);
            this.groupBox2.Location = new System.Drawing.Point(357, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 326);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commands";
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Clear.Location = new System.Drawing.Point(6, 254);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(303, 63);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.Red;
            this.Stop.Location = new System.Drawing.Point(6, 175);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(303, 63);
            this.Stop.TabIndex = 4;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Hold
            // 
            this.Hold.BackColor = System.Drawing.Color.Yellow;
            this.Hold.Location = new System.Drawing.Point(6, 95);
            this.Hold.Name = "Hold";
            this.Hold.Size = new System.Drawing.Size(303, 63);
            this.Hold.TabIndex = 3;
            this.Hold.Text = "Hold";
            this.Hold.UseVisualStyleBackColor = false;
            this.Hold.Click += new System.EventHandler(this.Hold_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(106)))));
            this.Start.Location = new System.Drawing.Point(6, 22);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(303, 63);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.OrderPoints);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.OEE_PROC);
            this.groupBox3.Controls.Add(this.OEE_Quality_Proc);
            this.groupBox3.Controls.Add(this.OEE_Performance_Proc);
            this.groupBox3.Controls.Add(this.OEE_Availability_Proc);
            this.groupBox3.Controls.Add(this.OEE_Quality);
            this.groupBox3.Controls.Add(this.OEE_Performance);
            this.groupBox3.Controls.Add(this.OEE_Availability);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.Uptime);
            this.groupBox3.Controls.Add(this.Info);
            this.groupBox3.Controls.Add(this.Status);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.Lable8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 219);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cell status";
            // 
            // OrderPoints
            // 
            this.OrderPoints.AutoSize = true;
            this.OrderPoints.Location = new System.Drawing.Point(220, 181);
            this.OrderPoints.Name = "OrderPoints";
            this.OrderPoints.Size = new System.Drawing.Size(36, 13);
            this.OrderPoints.TabIndex = 29;
            this.OrderPoints.Text = "Points";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Points";
            // 
            // OEE_PROC
            // 
            this.OEE_PROC.AutoSize = true;
            this.OEE_PROC.Location = new System.Drawing.Point(220, 49);
            this.OEE_PROC.Name = "OEE_PROC";
            this.OEE_PROC.Size = new System.Drawing.Size(29, 13);
            this.OEE_PROC.TabIndex = 27;
            this.OEE_PROC.Text = "OEE";
            // 
            // OEE_Quality_Proc
            // 
            this.OEE_Quality_Proc.AutoSize = true;
            this.OEE_Quality_Proc.Location = new System.Drawing.Point(220, 117);
            this.OEE_Quality_Proc.Name = "OEE_Quality_Proc";
            this.OEE_Quality_Proc.Size = new System.Drawing.Size(39, 13);
            this.OEE_Quality_Proc.TabIndex = 26;
            this.OEE_Quality_Proc.Text = "Quality";
            // 
            // OEE_Performance_Proc
            // 
            this.OEE_Performance_Proc.AutoSize = true;
            this.OEE_Performance_Proc.Location = new System.Drawing.Point(220, 94);
            this.OEE_Performance_Proc.Name = "OEE_Performance_Proc";
            this.OEE_Performance_Proc.Size = new System.Drawing.Size(67, 13);
            this.OEE_Performance_Proc.TabIndex = 25;
            this.OEE_Performance_Proc.Text = "Performance";
            // 
            // OEE_Availability_Proc
            // 
            this.OEE_Availability_Proc.AutoSize = true;
            this.OEE_Availability_Proc.Location = new System.Drawing.Point(220, 71);
            this.OEE_Availability_Proc.Name = "OEE_Availability_Proc";
            this.OEE_Availability_Proc.Size = new System.Drawing.Size(56, 13);
            this.OEE_Availability_Proc.TabIndex = 24;
            this.OEE_Availability_Proc.Text = "Availability";
            // 
            // OEE_Quality
            // 
            this.OEE_Quality.AutoSize = true;
            this.OEE_Quality.Location = new System.Drawing.Point(111, 117);
            this.OEE_Quality.Name = "OEE_Quality";
            this.OEE_Quality.Size = new System.Drawing.Size(39, 13);
            this.OEE_Quality.TabIndex = 23;
            this.OEE_Quality.Text = "Quality";
            // 
            // OEE_Performance
            // 
            this.OEE_Performance.AutoSize = true;
            this.OEE_Performance.Location = new System.Drawing.Point(111, 94);
            this.OEE_Performance.Name = "OEE_Performance";
            this.OEE_Performance.Size = new System.Drawing.Size(67, 13);
            this.OEE_Performance.TabIndex = 22;
            this.OEE_Performance.Text = "Performance";
            // 
            // OEE_Availability
            // 
            this.OEE_Availability.AutoSize = true;
            this.OEE_Availability.Location = new System.Drawing.Point(111, 71);
            this.OEE_Availability.Name = "OEE_Availability";
            this.OEE_Availability.Size = new System.Drawing.Size(56, 13);
            this.OEE_Availability.TabIndex = 21;
            this.OEE_Availability.Text = "Availability";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Quality";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Performance";
            // 
            // Uptime
            // 
            this.Uptime.AutoSize = true;
            this.Uptime.Location = new System.Drawing.Point(220, 145);
            this.Uptime.Name = "Uptime";
            this.Uptime.Size = new System.Drawing.Size(40, 13);
            this.Uptime.TabIndex = 18;
            this.Uptime.Text = "Uptime";
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(21, 71);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(56, 13);
            this.Info.TabIndex = 17;
            this.Info.Text = "Availability";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(220, 25);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(37, 13);
            this.Status.TabIndex = 16;
            this.Status.Text = "Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Uptime";
            // 
            // Lable8
            // 
            this.Lable8.AutoSize = true;
            this.Lable8.Location = new System.Drawing.Point(7, 49);
            this.Lable8.Name = "Lable8";
            this.Lable8.Size = new System.Drawing.Size(29, 13);
            this.Lable8.TabIndex = 14;
            this.Lable8.Text = "OEE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Status";
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(12, 456);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            this.Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Log.Size = new System.Drawing.Size(660, 193);
            this.Log.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Super secret function button";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.blueDataGridViewTextBoxColumn,
            this.redDataGridViewTextBoxColumn,
            this.yellowDataGridViewTextBoxColumn,
            this.Ontime,
            this.CorrectOrder,
            this.points});
            this.dataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("DataMember", this.form1ViewModelBindingSource, "AllOrdersDone", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(678, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(417, 627);
            this.dataGridView1.TabIndex = 6;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // blueDataGridViewTextBoxColumn
            // 
            this.blueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.blueDataGridViewTextBoxColumn.DataPropertyName = "blue";
            this.blueDataGridViewTextBoxColumn.HeaderText = "Blue";
            this.blueDataGridViewTextBoxColumn.Name = "blueDataGridViewTextBoxColumn";
            this.blueDataGridViewTextBoxColumn.Width = 53;
            // 
            // redDataGridViewTextBoxColumn
            // 
            this.redDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.redDataGridViewTextBoxColumn.DataPropertyName = "red";
            this.redDataGridViewTextBoxColumn.HeaderText = "Red";
            this.redDataGridViewTextBoxColumn.Name = "redDataGridViewTextBoxColumn";
            this.redDataGridViewTextBoxColumn.Width = 52;
            // 
            // yellowDataGridViewTextBoxColumn
            // 
            this.yellowDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.yellowDataGridViewTextBoxColumn.DataPropertyName = "yellow";
            this.yellowDataGridViewTextBoxColumn.HeaderText = "Yellow";
            this.yellowDataGridViewTextBoxColumn.Name = "yellowDataGridViewTextBoxColumn";
            this.yellowDataGridViewTextBoxColumn.Width = 63;
            // 
            // Ontime
            // 
            this.Ontime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Ontime.DataPropertyName = "Ontime";
            this.Ontime.HeaderText = "Ontime";
            this.Ontime.Name = "Ontime";
            this.Ontime.Width = 46;
            // 
            // CorrectOrder
            // 
            this.CorrectOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CorrectOrder.DataPropertyName = "CorrectOrder";
            this.CorrectOrder.HeaderText = "CorrectOrder";
            this.CorrectOrder.Name = "CorrectOrder";
            this.CorrectOrder.Width = 73;
            // 
            // points
            // 
            this.points.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.points.DataPropertyName = "points";
            this.points.HeaderText = "Points";
            this.points.Name = "points";
            this.points.ReadOnly = true;
            this.points.Width = 61;
            // 
            // form1ViewModelBindingSource
            // 
            this.form1ViewModelBindingSource.DataSource = typeof(RSDSCADA.Form1ViewModel);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(RSDSCADA.Models.Order);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 661);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1ViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Ticket;
        private System.Windows.Forms.Label Order;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Yellow;
        private System.Windows.Forms.Label Red;
        private System.Windows.Forms.Label Blue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Hold;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label Uptime;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Lable8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label OEE_Quality_Proc;
        private System.Windows.Forms.Label OEE_Performance_Proc;
        private System.Windows.Forms.Label OEE_Availability_Proc;
        private System.Windows.Forms.Label OEE_Quality;
        private System.Windows.Forms.Label OEE_Performance;
        private System.Windows.Forms.Label OEE_Availability;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label OEE_PROC;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn redDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yellowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ontime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CorrectOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn points;
        private System.Windows.Forms.BindingSource form1ViewModelBindingSource;
        private System.Windows.Forms.Label OrderPoints;
        private System.Windows.Forms.Label label13;
    }
}

