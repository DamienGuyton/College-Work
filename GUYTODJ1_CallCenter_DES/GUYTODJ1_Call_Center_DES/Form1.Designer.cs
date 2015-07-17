namespace GUYTODJ1_Call_Center_DES
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
            this.btnRun = new System.Windows.Forms.Button();
            this.StatsDataGridView = new System.Windows.Forms.DataGridView();
            this.StereoQueueDataGridView = new System.Windows.Forms.DataGridView();
            this.Entity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeginWait = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtherQueueDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalanderDataGrid = new System.Windows.Forms.DataGridView();
            this.CalanderEntity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalanderEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalanderEventTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalanderProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalanderStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalanderBeginWait = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblStereoQueue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
            this.lblCalanderDGV = new System.Windows.Forms.Label();
            this.graphicsSurface = new System.Windows.Forms.Panel();
            this.lblScheduledToArrive = new System.Windows.Forms.Label();
            this.lblProcessIVRUnit = new System.Windows.Forms.Label();
            this.lblOtherProductQueue = new System.Windows.Forms.Label();
            this.lblCarSteroQueue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stereoRepNUD = new System.Windows.Forms.NumericUpDown();
            this.otherRepNUD = new System.Windows.Forms.NumericUpDown();
            this.lblMaxONHold = new System.Windows.Forms.Label();
            this.maxOnHoldNUD = new System.Windows.Forms.NumericUpDown();
            this.lblCallInterval = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.productTypeNUD = new System.Windows.Forms.NumericUpDown();
            this.ivrNUD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.otherProductProcessingTimeNUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.carStereoProcessingTimeNUD = new System.Windows.Forms.NumericUpDown();
            this.lblCarStereoProcessing = new System.Windows.Forms.Label();
            this.callIntervalNUD = new System.Windows.Forms.NumericUpDown();
            this.gBSimulationView = new System.Windows.Forms.GroupBox();
            this.rdoText = new System.Windows.Forms.RadioButton();
            this.rdoGraphical = new System.Windows.Forms.RadioButton();
            this.tBarSpeed = new System.Windows.Forms.TrackBar();
            this.gBoxSpeed = new System.Windows.Forms.GroupBox();
            this.iteration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HangUpCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StereoCompletions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtherCompletions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExcessiveWaitStereo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExcessiveWaitOtherCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgUtilisationStereo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgUtilisationOther = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgQueueLengthStereo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgQueueLengthOther = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgTimeInQueue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgTimeInSystem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StatsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StereoQueueDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtherQueueDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalanderDataGrid)).BeginInit();
            this.graphicsSurface.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stereoRepNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherRepNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxOnHoldNUD)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivrNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherProductProcessingTimeNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carStereoProcessingTimeNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callIntervalNUD)).BeginInit();
            this.gBSimulationView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarSpeed)).BeginInit();
            this.gBoxSpeed.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(9, 164);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(94, 30);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run Simulation";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // StatsDataGridView
            // 
            this.StatsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StatsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iteration,
            this.HangUpCount,
            this.StereoCompletions,
            this.OtherCompletions,
            this.ExcessiveWaitStereo,
            this.ExcessiveWaitOtherCount,
            this.AvgUtilisationStereo,
            this.AvgUtilisationOther,
            this.AvgQueueLengthStereo,
            this.AvgQueueLengthOther,
            this.AvgTimeInQueue,
            this.AvgTimeInSystem});
            this.StatsDataGridView.Location = new System.Drawing.Point(13, 585);
            this.StatsDataGridView.Name = "StatsDataGridView";
            this.StatsDataGridView.RowHeadersVisible = false;
            this.StatsDataGridView.Size = new System.Drawing.Size(981, 135);
            this.StatsDataGridView.TabIndex = 1;
            // 
            // StereoQueueDataGridView
            // 
            this.StereoQueueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StereoQueueDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Entity,
            this.ProductType,
            this.StartTime,
            this.BeginWait});
            this.StereoQueueDataGridView.Location = new System.Drawing.Point(140, 321);
            this.StereoQueueDataGridView.Name = "StereoQueueDataGridView";
            this.StereoQueueDataGridView.RowHeadersVisible = false;
            this.StereoQueueDataGridView.Size = new System.Drawing.Size(305, 247);
            this.StereoQueueDataGridView.TabIndex = 3;
            // 
            // Entity
            // 
            this.Entity.HeaderText = "Entity";
            this.Entity.Name = "Entity";
            this.Entity.Width = 40;
            // 
            // ProductType
            // 
            this.ProductType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ProductType.HeaderText = "Product Type";
            this.ProductType.Name = "ProductType";
            this.ProductType.Width = 96;
            // 
            // StartTime
            // 
            this.StartTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.StartTime.HeaderText = "Start Time";
            this.StartTime.Name = "StartTime";
            this.StartTime.Width = 80;
            // 
            // BeginWait
            // 
            this.BeginWait.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.BeginWait.HeaderText = "Begin Wait";
            this.BeginWait.Name = "BeginWait";
            this.BeginWait.Width = 84;
            // 
            // OtherQueueDataGridView
            // 
            this.OtherQueueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OtherQueueDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.OtherQueueDataGridView.Location = new System.Drawing.Point(507, 321);
            this.OtherQueueDataGridView.Name = "OtherQueueDataGridView";
            this.OtherQueueDataGridView.RowHeadersVisible = false;
            this.OtherQueueDataGridView.Size = new System.Drawing.Size(307, 247);
            this.OtherQueueDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Entity";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.HeaderText = "Product Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 96;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.HeaderText = "Start Time";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn5.HeaderText = "Begin Wait";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 84;
            // 
            // CalanderDataGrid
            // 
            this.CalanderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CalanderDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CalanderEntity,
            this.CalanderEvent,
            this.CalanderEventTime,
            this.CalanderProductType,
            this.CalanderStartTime,
            this.CalanderBeginWait});
            this.CalanderDataGrid.Location = new System.Drawing.Point(280, 103);
            this.CalanderDataGrid.Name = "CalanderDataGrid";
            this.CalanderDataGrid.RowHeadersVisible = false;
            this.CalanderDataGrid.Size = new System.Drawing.Size(450, 196);
            this.CalanderDataGrid.TabIndex = 5;
            // 
            // CalanderEntity
            // 
            this.CalanderEntity.HeaderText = "Entity";
            this.CalanderEntity.Name = "CalanderEntity";
            this.CalanderEntity.Width = 40;
            // 
            // CalanderEvent
            // 
            this.CalanderEvent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CalanderEvent.HeaderText = "Event";
            this.CalanderEvent.Name = "CalanderEvent";
            this.CalanderEvent.Width = 60;
            // 
            // CalanderEventTime
            // 
            this.CalanderEventTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CalanderEventTime.HeaderText = "Event Time";
            this.CalanderEventTime.Name = "CalanderEventTime";
            this.CalanderEventTime.Width = 86;
            // 
            // CalanderProductType
            // 
            this.CalanderProductType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CalanderProductType.HeaderText = "ProductType";
            this.CalanderProductType.Name = "CalanderProductType";
            this.CalanderProductType.Width = 93;
            // 
            // CalanderStartTime
            // 
            this.CalanderStartTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CalanderStartTime.HeaderText = "Start Time";
            this.CalanderStartTime.Name = "CalanderStartTime";
            this.CalanderStartTime.Width = 80;
            // 
            // CalanderBeginWait
            // 
            this.CalanderBeginWait.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CalanderBeginWait.HeaderText = "Begin Wait";
            this.CalanderBeginWait.Name = "CalanderBeginWait";
            this.CalanderBeginWait.Width = 84;
            // 
            // lblStereoQueue
            // 
            this.lblStereoQueue.AutoSize = true;
            this.lblStereoQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStereoQueue.Location = new System.Drawing.Point(245, 302);
            this.lblStereoQueue.Name = "lblStereoQueue";
            this.lblStereoQueue.Size = new System.Drawing.Size(91, 16);
            this.lblStereoQueue.TabIndex = 6;
            this.lblStereoQueue.Text = "Stereo Queue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(614, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Other Queue";
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStats.Location = new System.Drawing.Point(457, 559);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(38, 16);
            this.lblStats.TabIndex = 8;
            this.lblStats.Text = "Stats";
            // 
            // lblCalanderDGV
            // 
            this.lblCalanderDGV.AutoSize = true;
            this.lblCalanderDGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalanderDGV.Location = new System.Drawing.Point(474, 84);
            this.lblCalanderDGV.Name = "lblCalanderDGV";
            this.lblCalanderDGV.Size = new System.Drawing.Size(63, 16);
            this.lblCalanderDGV.TabIndex = 9;
            this.lblCalanderDGV.Text = "Calandar";
            // 
            // graphicsSurface
            // 
            this.graphicsSurface.BackColor = System.Drawing.SystemColors.Window;
            this.graphicsSurface.Controls.Add(this.label8);
            this.graphicsSurface.Controls.Add(this.label7);
            this.graphicsSurface.Controls.Add(this.lblScheduledToArrive);
            this.graphicsSurface.Controls.Add(this.lblProcessIVRUnit);
            this.graphicsSurface.Controls.Add(this.lblOtherProductQueue);
            this.graphicsSurface.Controls.Add(this.lblCarSteroQueue);
            this.graphicsSurface.Location = new System.Drawing.Point(100, 252);
            this.graphicsSurface.Name = "graphicsSurface";
            this.graphicsSurface.Size = new System.Drawing.Size(795, 304);
            this.graphicsSurface.TabIndex = 11;
            this.graphicsSurface.Visible = false;
            // 
            // lblScheduledToArrive
            // 
            this.lblScheduledToArrive.AutoSize = true;
            this.lblScheduledToArrive.Location = new System.Drawing.Point(7, 110);
            this.lblScheduledToArrive.Name = "lblScheduledToArrive";
            this.lblScheduledToArrive.Size = new System.Drawing.Size(104, 13);
            this.lblScheduledToArrive.TabIndex = 3;
            this.lblScheduledToArrive.Text = "Scheduled To Arrive";
            // 
            // lblProcessIVRUnit
            // 
            this.lblProcessIVRUnit.AutoSize = true;
            this.lblProcessIVRUnit.Location = new System.Drawing.Point(121, 110);
            this.lblProcessIVRUnit.Name = "lblProcessIVRUnit";
            this.lblProcessIVRUnit.Size = new System.Drawing.Size(100, 13);
            this.lblProcessIVRUnit.TabIndex = 2;
            this.lblProcessIVRUnit.Text = "In Process IVR Unit";
            // 
            // lblOtherProductQueue
            // 
            this.lblOtherProductQueue.AutoSize = true;
            this.lblOtherProductQueue.Location = new System.Drawing.Point(362, 288);
            this.lblOtherProductQueue.Name = "lblOtherProductQueue";
            this.lblOtherProductQueue.Size = new System.Drawing.Size(163, 13);
            this.lblOtherProductQueue.TabIndex = 1;
            this.lblOtherProductQueue.Text = "Waiting in Other-Products Queue";
            // 
            // lblCarSteroQueue
            // 
            this.lblCarSteroQueue.AutoSize = true;
            this.lblCarSteroQueue.Location = new System.Drawing.Point(366, 3);
            this.lblCarSteroQueue.Name = "lblCarSteroQueue";
            this.lblCarSteroQueue.Size = new System.Drawing.Size(142, 13);
            this.lblCarSteroQueue.TabIndex = 0;
            this.lblCarSteroQueue.Text = "Waiting in Car-Stereo Queue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Car-Stereo Reps";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Other-Products Reps";
            // 
            // stereoRepNUD
            // 
            this.stereoRepNUD.Location = new System.Drawing.Point(10, 46);
            this.stereoRepNUD.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.stereoRepNUD.Name = "stereoRepNUD";
            this.stereoRepNUD.Size = new System.Drawing.Size(82, 20);
            this.stereoRepNUD.TabIndex = 14;
            this.stereoRepNUD.UseWaitCursor = true;
            this.stereoRepNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // otherRepNUD
            // 
            this.otherRepNUD.Location = new System.Drawing.Point(103, 46);
            this.otherRepNUD.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.otherRepNUD.Name = "otherRepNUD";
            this.otherRepNUD.Size = new System.Drawing.Size(103, 20);
            this.otherRepNUD.TabIndex = 15;
            this.otherRepNUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblMaxONHold
            // 
            this.lblMaxONHold.AutoSize = true;
            this.lblMaxONHold.Location = new System.Drawing.Point(215, 23);
            this.lblMaxONHold.Name = "lblMaxONHold";
            this.lblMaxONHold.Size = new System.Drawing.Size(69, 13);
            this.lblMaxONHold.TabIndex = 16;
            this.lblMaxONHold.Text = "Max On Hold";
            // 
            // maxOnHoldNUD
            // 
            this.maxOnHoldNUD.Location = new System.Drawing.Point(218, 46);
            this.maxOnHoldNUD.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.maxOnHoldNUD.Name = "maxOnHoldNUD";
            this.maxOnHoldNUD.Size = new System.Drawing.Size(66, 20);
            this.maxOnHoldNUD.TabIndex = 17;
            this.maxOnHoldNUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblCallInterval
            // 
            this.lblCallInterval.AutoSize = true;
            this.lblCallInterval.Location = new System.Drawing.Point(291, 23);
            this.lblCallInterval.Name = "lblCallInterval";
            this.lblCallInterval.Size = new System.Drawing.Size(62, 13);
            this.lblCallInterval.TabIndex = 18;
            this.lblCallInterval.Text = "Call Interval";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.productTypeNUD);
            this.groupBox1.Controls.Add(this.ivrNUD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.otherProductProcessingTimeNUD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.carStereoProcessingTimeNUD);
            this.groupBox1.Controls.Add(this.lblCarStereoProcessing);
            this.groupBox1.Controls.Add(this.callIntervalNUD);
            this.groupBox1.Controls.Add(this.lblMaxONHold);
            this.groupBox1.Controls.Add(this.lblCallInterval);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.maxOnHoldNUD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.stereoRepNUD);
            this.groupBox1.Controls.Add(this.otherRepNUD);
            this.groupBox1.Location = new System.Drawing.Point(112, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 79);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Papameters";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(748, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Product Type Ratio";
            // 
            // productTypeNUD
            // 
            this.productTypeNUD.DecimalPlaces = 2;
            this.productTypeNUD.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.productTypeNUD.Location = new System.Drawing.Point(751, 46);
            this.productTypeNUD.Name = "productTypeNUD";
            this.productTypeNUD.Size = new System.Drawing.Size(96, 20);
            this.productTypeNUD.TabIndex = 27;
            this.productTypeNUD.Value = new decimal(new int[] {
            167,
            0,
            0,
            65536});
            // 
            // ivrNUD
            // 
            this.ivrNUD.DecimalPlaces = 2;
            this.ivrNUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ivrNUD.Location = new System.Drawing.Point(670, 47);
            this.ivrNUD.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ivrNUD.Name = "ivrNUD";
            this.ivrNUD.Size = new System.Drawing.Size(51, 20);
            this.ivrNUD.TabIndex = 26;
            this.ivrNUD.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(666, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "IVR Delay";
            // 
            // otherProductProcessingTimeNUD
            // 
            this.otherProductProcessingTimeNUD.DecimalPlaces = 2;
            this.otherProductProcessingTimeNUD.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.otherProductProcessingTimeNUD.Location = new System.Drawing.Point(505, 47);
            this.otherProductProcessingTimeNUD.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.otherProductProcessingTimeNUD.Name = "otherProductProcessingTimeNUD";
            this.otherProductProcessingTimeNUD.Size = new System.Drawing.Size(155, 20);
            this.otherProductProcessingTimeNUD.TabIndex = 24;
            this.otherProductProcessingTimeNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Other-Product Processing Delay";
            // 
            // carStereoProcessingTimeNUD
            // 
            this.carStereoProcessingTimeNUD.DecimalPlaces = 2;
            this.carStereoProcessingTimeNUD.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.carStereoProcessingTimeNUD.Location = new System.Drawing.Point(361, 46);
            this.carStereoProcessingTimeNUD.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.carStereoProcessingTimeNUD.Name = "carStereoProcessingTimeNUD";
            this.carStereoProcessingTimeNUD.Size = new System.Drawing.Size(127, 20);
            this.carStereoProcessingTimeNUD.TabIndex = 22;
            this.carStereoProcessingTimeNUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblCarStereoProcessing
            // 
            this.lblCarStereoProcessing.AutoSize = true;
            this.lblCarStereoProcessing.Location = new System.Drawing.Point(358, 23);
            this.lblCarStereoProcessing.Name = "lblCarStereoProcessing";
            this.lblCarStereoProcessing.Size = new System.Drawing.Size(142, 13);
            this.lblCarStereoProcessing.TabIndex = 21;
            this.lblCarStereoProcessing.Text = "Car-Stereo Processing Delay";
            // 
            // callIntervalNUD
            // 
            this.callIntervalNUD.DecimalPlaces = 3;
            this.callIntervalNUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.callIntervalNUD.Location = new System.Drawing.Point(296, 46);
            this.callIntervalNUD.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.callIntervalNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.callIntervalNUD.Name = "callIntervalNUD";
            this.callIntervalNUD.Size = new System.Drawing.Size(51, 20);
            this.callIntervalNUD.TabIndex = 20;
            this.callIntervalNUD.Value = new decimal(new int[] {
            333,
            0,
            0,
            196608});
            // 
            // gBSimulationView
            // 
            this.gBSimulationView.Controls.Add(this.rdoText);
            this.gBSimulationView.Controls.Add(this.rdoGraphical);
            this.gBSimulationView.Location = new System.Drawing.Point(5, 3);
            this.gBSimulationView.Name = "gBSimulationView";
            this.gBSimulationView.Size = new System.Drawing.Size(106, 79);
            this.gBSimulationView.TabIndex = 20;
            this.gBSimulationView.TabStop = false;
            this.gBSimulationView.Text = "view";
            // 
            // rdoText
            // 
            this.rdoText.AutoSize = true;
            this.rdoText.Checked = true;
            this.rdoText.Location = new System.Drawing.Point(28, 47);
            this.rdoText.Name = "rdoText";
            this.rdoText.Size = new System.Drawing.Size(46, 17);
            this.rdoText.TabIndex = 1;
            this.rdoText.TabStop = true;
            this.rdoText.Text = "Text";
            this.rdoText.UseVisualStyleBackColor = true;
            // 
            // rdoGraphical
            // 
            this.rdoGraphical.AutoSize = true;
            this.rdoGraphical.Location = new System.Drawing.Point(28, 21);
            this.rdoGraphical.Name = "rdoGraphical";
            this.rdoGraphical.Size = new System.Drawing.Size(70, 17);
            this.rdoGraphical.TabIndex = 0;
            this.rdoGraphical.TabStop = true;
            this.rdoGraphical.Text = "Graphical";
            this.rdoGraphical.UseVisualStyleBackColor = true;
            // 
            // tBarSpeed
            // 
            this.tBarSpeed.LargeChange = 1;
            this.tBarSpeed.Location = new System.Drawing.Point(13, 18);
            this.tBarSpeed.Minimum = 1;
            this.tBarSpeed.Name = "tBarSpeed";
            this.tBarSpeed.Size = new System.Drawing.Size(167, 45);
            this.tBarSpeed.TabIndex = 21;
            this.tBarSpeed.Value = 7;
            // 
            // gBoxSpeed
            // 
            this.gBoxSpeed.Controls.Add(this.tBarSpeed);
            this.gBoxSpeed.Location = new System.Drawing.Point(6, 90);
            this.gBoxSpeed.Name = "gBoxSpeed";
            this.gBoxSpeed.Size = new System.Drawing.Size(196, 68);
            this.gBoxSpeed.TabIndex = 22;
            this.gBoxSpeed.TabStop = false;
            this.gBoxSpeed.Text = "Simulatiion Speed";
            // 
            // iteration
            // 
            this.iteration.HeaderText = "Number ofCalls";
            this.iteration.Name = "iteration";
            this.iteration.Width = 50;
            // 
            // HangUpCount
            // 
            this.HangUpCount.HeaderText = "HangUps";
            this.HangUpCount.Name = "HangUpCount";
            this.HangUpCount.Width = 60;
            // 
            // StereoCompletions
            // 
            this.StereoCompletions.HeaderText = "Stereo Completions";
            this.StereoCompletions.Name = "StereoCompletions";
            this.StereoCompletions.Width = 80;
            // 
            // OtherCompletions
            // 
            this.OtherCompletions.HeaderText = "Other Completions";
            this.OtherCompletions.Name = "OtherCompletions";
            this.OtherCompletions.Width = 80;
            // 
            // ExcessiveWaitStereo
            // 
            this.ExcessiveWaitStereo.HeaderText = "Excessive Wait Stereo Count";
            this.ExcessiveWaitStereo.Name = "ExcessiveWaitStereo";
            this.ExcessiveWaitStereo.Width = 90;
            // 
            // ExcessiveWaitOtherCount
            // 
            this.ExcessiveWaitOtherCount.HeaderText = "Excessive Wait Other";
            this.ExcessiveWaitOtherCount.Name = "ExcessiveWaitOtherCount";
            this.ExcessiveWaitOtherCount.Width = 80;
            // 
            // AvgUtilisationStereo
            // 
            this.AvgUtilisationStereo.HeaderText = "Avg Utilisation Stereo";
            this.AvgUtilisationStereo.Name = "AvgUtilisationStereo";
            this.AvgUtilisationStereo.Width = 80;
            // 
            // AvgUtilisationOther
            // 
            this.AvgUtilisationOther.HeaderText = "Avg Utilisation Other";
            this.AvgUtilisationOther.Name = "AvgUtilisationOther";
            this.AvgUtilisationOther.Width = 80;
            // 
            // AvgQueueLengthStereo
            // 
            this.AvgQueueLengthStereo.HeaderText = "Avg Queue Length Stereo";
            this.AvgQueueLengthStereo.Name = "AvgQueueLengthStereo";
            this.AvgQueueLengthStereo.Width = 90;
            // 
            // AvgQueueLengthOther
            // 
            this.AvgQueueLengthOther.HeaderText = "Avg Queue Length Other";
            this.AvgQueueLengthOther.Name = "AvgQueueLengthOther";
            this.AvgQueueLengthOther.Width = 95;
            // 
            // AvgTimeInQueue
            // 
            this.AvgTimeInQueue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.AvgTimeInQueue.HeaderText = "Avg Time In Queue";
            this.AvgTimeInQueue.Name = "AvgTimeInQueue";
            this.AvgTimeInQueue.Width = 74;
            // 
            // AvgTimeInSystem
            // 
            this.AvgTimeInSystem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.AvgTimeInSystem.HeaderText = "Avg Time In System";
            this.AvgTimeInSystem.Name = "AvgTimeInSystem";
            this.AvgTimeInSystem.Width = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(546, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Car-Stereo Calls Busy with reps";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(530, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Other-Product Calls Busy with reps";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 728);
            this.Controls.Add(this.gBoxSpeed);
            this.Controls.Add(this.gBSimulationView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.graphicsSurface);
            this.Controls.Add(this.lblCalanderDGV);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStereoQueue);
            this.Controls.Add(this.CalanderDataGrid);
            this.Controls.Add(this.OtherQueueDataGridView);
            this.Controls.Add(this.StereoQueueDataGridView);
            this.Controls.Add(this.StatsDataGridView);
            this.Controls.Add(this.btnRun);
            this.Name = "Form1";
            this.Text = "Damien Guyton Call Center";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StatsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StereoQueueDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtherQueueDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalanderDataGrid)).EndInit();
            this.graphicsSurface.ResumeLayout(false);
            this.graphicsSurface.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stereoRepNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherRepNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxOnHoldNUD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivrNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherProductProcessingTimeNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carStereoProcessingTimeNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callIntervalNUD)).EndInit();
            this.gBSimulationView.ResumeLayout(false);
            this.gBSimulationView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarSpeed)).EndInit();
            this.gBoxSpeed.ResumeLayout(false);
            this.gBoxSpeed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.DataGridView StatsDataGridView;
        private System.Windows.Forms.DataGridView StereoQueueDataGridView;
        private System.Windows.Forms.DataGridView OtherQueueDataGridView;
        private System.Windows.Forms.DataGridView CalanderDataGrid;
        private System.Windows.Forms.Label lblStereoQueue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Label lblCalanderDGV;
        private System.Windows.Forms.Panel graphicsSurface;
        private System.Windows.Forms.Label lblOtherProductQueue;
        private System.Windows.Forms.Label lblCarSteroQueue;
        private System.Windows.Forms.Label lblProcessIVRUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalanderEntity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalanderEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalanderEventTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalanderProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalanderStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalanderBeginWait;
        private System.Windows.Forms.Label lblScheduledToArrive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown stereoRepNUD;
        private System.Windows.Forms.NumericUpDown otherRepNUD;
        private System.Windows.Forms.Label lblMaxONHold;
        private System.Windows.Forms.NumericUpDown maxOnHoldNUD;
        private System.Windows.Forms.Label lblCallInterval;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gBSimulationView;
        private System.Windows.Forms.RadioButton rdoText;
        private System.Windows.Forms.RadioButton rdoGraphical;
        private System.Windows.Forms.NumericUpDown callIntervalNUD;
        private System.Windows.Forms.Label lblCarStereoProcessing;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown productTypeNUD;
        private System.Windows.Forms.NumericUpDown ivrNUD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown otherProductProcessingTimeNUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown carStereoProcessingTimeNUD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeginWait;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TrackBar tBarSpeed;
        private System.Windows.Forms.GroupBox gBoxSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn iteration;
        private System.Windows.Forms.DataGridViewTextBoxColumn HangUpCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn StereoCompletions;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtherCompletions;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExcessiveWaitStereo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExcessiveWaitOtherCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgUtilisationStereo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgUtilisationOther;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgQueueLengthStereo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgQueueLengthOther;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgTimeInQueue;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgTimeInSystem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

