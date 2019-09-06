namespace DragRaceTkes2
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
            this.btnGoTkes = new System.Windows.Forms.Button();
            this.tmrRaceTimerTkes = new System.Windows.Forms.Timer(this.components);
            this.btnResetTkes = new System.Windows.Forms.Button();
            this.mspMainTkes = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serialMonitorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pcbFinishTkes = new System.Windows.Forms.PictureBox();
            this.lblPlace4Tkes = new System.Windows.Forms.Label();
            this.lblPlace3Tkes = new System.Windows.Forms.Label();
            this.lblPlace2Tkes = new System.Windows.Forms.Label();
            this.lblPlace1Tkes = new System.Windows.Forms.Label();
            this.lblTotalTimeTkes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCar2TimeTkes = new System.Windows.Forms.Label();
            this.lblCar3TimeTkes = new System.Windows.Forms.Label();
            this.lblCar4TimeTkes = new System.Windows.Forms.Label();
            this.lblCar1TimeTkes = new System.Windows.Forms.Label();
            this.pcbCar1Tkes = new System.Windows.Forms.PictureBox();
            this.pcbCar3Tkes = new System.Windows.Forms.PictureBox();
            this.pcbCar4Tkes = new System.Windows.Forms.PictureBox();
            this.pcbCar2Tkes = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tbcMainTkes = new System.Windows.Forms.TabControl();
            this.tbpRaceTkes = new System.Windows.Forms.TabPage();
            this.tbpSettingsTkes = new System.Windows.Forms.TabPage();
            this.btnSetNameTkes = new System.Windows.Forms.Button();
            this.lblCar4NameTkes = new System.Windows.Forms.Label();
            this.lblCar3NameTkes = new System.Windows.Forms.Label();
            this.lblCar2NameTkes = new System.Windows.Forms.Label();
            this.lblCar1NameTkes = new System.Windows.Forms.Label();
            this.txbCar4NameTkes = new System.Windows.Forms.TextBox();
            this.txbCar3NameTkes = new System.Windows.Forms.TextBox();
            this.txbCar2NameTkes = new System.Windows.Forms.TextBox();
            this.txbCar1NameTkes = new System.Windows.Forms.TextBox();
            this.tbcScoresTkes = new System.Windows.Forms.TabPage();
            this.lblCar4ScoreTkes = new System.Windows.Forms.Label();
            this.lblPlayer4ScoreNameTkes = new System.Windows.Forms.Label();
            this.lblCar3ScoreTkes = new System.Windows.Forms.Label();
            this.lblCar2ScoreTkes = new System.Windows.Forms.Label();
            this.lblCar1ScoreTkes = new System.Windows.Forms.Label();
            this.lblPlayer3ScoreNameTkes = new System.Windows.Forms.Label();
            this.lblPlayer2ScoreNameTkes = new System.Windows.Forms.Label();
            this.lblPlayer1ScoreNameTkes = new System.Windows.Forms.Label();
            this.mspMainTkes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFinishTkes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCar1Tkes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCar3Tkes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCar4Tkes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCar2Tkes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.tbcMainTkes.SuspendLayout();
            this.tbpRaceTkes.SuspendLayout();
            this.tbpSettingsTkes.SuspendLayout();
            this.tbcScoresTkes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGoTkes
            // 
            this.btnGoTkes.Location = new System.Drawing.Point(149, 400);
            this.btnGoTkes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGoTkes.Name = "btnGoTkes";
            this.btnGoTkes.Size = new System.Drawing.Size(100, 28);
            this.btnGoTkes.TabIndex = 2;
            this.btnGoTkes.Text = "Go";
            this.btnGoTkes.UseVisualStyleBackColor = true;
            this.btnGoTkes.Click += new System.EventHandler(this.btnGoTkes_Click);
            // 
            // tmrRaceTimerTkes
            // 
            this.tmrRaceTimerTkes.Interval = 1000;
            this.tmrRaceTimerTkes.Tick += new System.EventHandler(this.tmrRaceTimerTkes_Tick);
            // 
            // btnResetTkes
            // 
            this.btnResetTkes.Location = new System.Drawing.Point(257, 400);
            this.btnResetTkes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResetTkes.Name = "btnResetTkes";
            this.btnResetTkes.Size = new System.Drawing.Size(100, 28);
            this.btnResetTkes.TabIndex = 7;
            this.btnResetTkes.Text = "Reset";
            this.btnResetTkes.UseVisualStyleBackColor = true;
            this.btnResetTkes.Click += new System.EventHandler(this.btnResetTkes_Click);
            // 
            // mspMainTkes
            // 
            this.mspMainTkes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mspMainTkes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.raceToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.scoresToolStripMenuItem,
            this.viewToolStripMenuItem1});
            this.mspMainTkes.Location = new System.Drawing.Point(0, 0);
            this.mspMainTkes.Name = "mspMainTkes";
            this.mspMainTkes.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mspMainTkes.Size = new System.Drawing.Size(1489, 28);
            this.mspMainTkes.TabIndex = 9;
            this.mspMainTkes.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.locateToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.fileToolStripMenuItem.Text = "File...";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // locateToolStripMenuItem
            // 
            this.locateToolStripMenuItem.Name = "locateToolStripMenuItem";
            this.locateToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.locateToolStripMenuItem.Text = "Locate";
            this.locateToolStripMenuItem.Click += new System.EventHandler(this.locateToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // raceToolStripMenuItem
            // 
            this.raceToolStripMenuItem.Name = "raceToolStripMenuItem";
            this.raceToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.raceToolStripMenuItem.Text = "Race";
            this.raceToolStripMenuItem.Click += new System.EventHandler(this.raceToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // scoresToolStripMenuItem
            // 
            this.scoresToolStripMenuItem.Name = "scoresToolStripMenuItem";
            this.scoresToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.scoresToolStripMenuItem.Text = "Scores";
            this.scoresToolStripMenuItem.Click += new System.EventHandler(this.scoresToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serialMonitorToolStripMenuItem1});
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            this.viewToolStripMenuItem1.Size = new System.Drawing.Size(62, 24);
            this.viewToolStripMenuItem1.Text = "View...";
            // 
            // serialMonitorToolStripMenuItem1
            // 
            this.serialMonitorToolStripMenuItem1.Name = "serialMonitorToolStripMenuItem1";
            this.serialMonitorToolStripMenuItem1.Size = new System.Drawing.Size(174, 26);
            this.serialMonitorToolStripMenuItem1.Text = "SerialMonitor";
            this.serialMonitorToolStripMenuItem1.Click += new System.EventHandler(this.serialMonitorToolStripMenuItem1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pcbFinishTkes);
            this.groupBox1.Controls.Add(this.btnGoTkes);
            this.groupBox1.Controls.Add(this.lblPlace4Tkes);
            this.groupBox1.Controls.Add(this.btnResetTkes);
            this.groupBox1.Controls.Add(this.lblPlace3Tkes);
            this.groupBox1.Controls.Add(this.lblPlace2Tkes);
            this.groupBox1.Controls.Add(this.lblPlace1Tkes);
            this.groupBox1.Controls.Add(this.lblTotalTimeTkes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblCar2TimeTkes);
            this.groupBox1.Controls.Add(this.lblCar3TimeTkes);
            this.groupBox1.Controls.Add(this.lblCar4TimeTkes);
            this.groupBox1.Controls.Add(this.lblCar1TimeTkes);
            this.groupBox1.Controls.Add(this.pcbCar1Tkes);
            this.groupBox1.Controls.Add(this.pcbCar3Tkes);
            this.groupBox1.Controls.Add(this.pcbCar4Tkes);
            this.groupBox1.Controls.Add(this.pcbCar2Tkes);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Location = new System.Drawing.Point(17, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1308, 447);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drag";
            // 
            // pcbFinishTkes
            // 
            this.pcbFinishTkes.BackColor = System.Drawing.Color.White;
            this.pcbFinishTkes.Location = new System.Drawing.Point(1052, 23);
            this.pcbFinishTkes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbFinishTkes.Name = "pcbFinishTkes";
            this.pcbFinishTkes.Size = new System.Drawing.Size(20, 367);
            this.pcbFinishTkes.TabIndex = 1;
            this.pcbFinishTkes.TabStop = false;
            // 
            // lblPlace4Tkes
            // 
            this.lblPlace4Tkes.AutoSize = true;
            this.lblPlace4Tkes.Location = new System.Drawing.Point(1151, 347);
            this.lblPlace4Tkes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace4Tkes.Name = "lblPlace4Tkes";
            this.lblPlace4Tkes.Size = new System.Drawing.Size(18, 17);
            this.lblPlace4Tkes.TabIndex = 17;
            this.lblPlace4Tkes.Text = "--";
            // 
            // lblPlace3Tkes
            // 
            this.lblPlace3Tkes.AutoSize = true;
            this.lblPlace3Tkes.Location = new System.Drawing.Point(1148, 250);
            this.lblPlace3Tkes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace3Tkes.Name = "lblPlace3Tkes";
            this.lblPlace3Tkes.Size = new System.Drawing.Size(18, 17);
            this.lblPlace3Tkes.TabIndex = 16;
            this.lblPlace3Tkes.Text = "--";
            // 
            // lblPlace2Tkes
            // 
            this.lblPlace2Tkes.AutoSize = true;
            this.lblPlace2Tkes.Location = new System.Drawing.Point(1151, 167);
            this.lblPlace2Tkes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace2Tkes.Name = "lblPlace2Tkes";
            this.lblPlace2Tkes.Size = new System.Drawing.Size(18, 17);
            this.lblPlace2Tkes.TabIndex = 15;
            this.lblPlace2Tkes.Text = "--";
            // 
            // lblPlace1Tkes
            // 
            this.lblPlace1Tkes.AutoSize = true;
            this.lblPlace1Tkes.Location = new System.Drawing.Point(1147, 65);
            this.lblPlace1Tkes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace1Tkes.Name = "lblPlace1Tkes";
            this.lblPlace1Tkes.Size = new System.Drawing.Size(18, 17);
            this.lblPlace1Tkes.TabIndex = 8;
            this.lblPlace1Tkes.Text = "--";
            // 
            // lblTotalTimeTkes
            // 
            this.lblTotalTimeTkes.AutoSize = true;
            this.lblTotalTimeTkes.Location = new System.Drawing.Point(105, 406);
            this.lblTotalTimeTkes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalTimeTkes.Name = "lblTotalTimeTkes";
            this.lblTotalTimeTkes.Size = new System.Drawing.Size(18, 17);
            this.lblTotalTimeTkes.TabIndex = 14;
            this.lblTotalTimeTkes.Text = "--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 406);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total Time:";
            // 
            // lblCar2TimeTkes
            // 
            this.lblCar2TimeTkes.AutoSize = true;
            this.lblCar2TimeTkes.Location = new System.Drawing.Point(1147, 187);
            this.lblCar2TimeTkes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCar2TimeTkes.Name = "lblCar2TimeTkes";
            this.lblCar2TimeTkes.Size = new System.Drawing.Size(18, 17);
            this.lblCar2TimeTkes.TabIndex = 13;
            this.lblCar2TimeTkes.Text = "--";
            // 
            // lblCar3TimeTkes
            // 
            this.lblCar3TimeTkes.AutoSize = true;
            this.lblCar3TimeTkes.Location = new System.Drawing.Point(1147, 270);
            this.lblCar3TimeTkes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCar3TimeTkes.Name = "lblCar3TimeTkes";
            this.lblCar3TimeTkes.Size = new System.Drawing.Size(18, 17);
            this.lblCar3TimeTkes.TabIndex = 12;
            this.lblCar3TimeTkes.Text = "--";
            // 
            // lblCar4TimeTkes
            // 
            this.lblCar4TimeTkes.AutoSize = true;
            this.lblCar4TimeTkes.Location = new System.Drawing.Point(1147, 363);
            this.lblCar4TimeTkes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCar4TimeTkes.Name = "lblCar4TimeTkes";
            this.lblCar4TimeTkes.Size = new System.Drawing.Size(18, 17);
            this.lblCar4TimeTkes.TabIndex = 11;
            this.lblCar4TimeTkes.Text = "--";
            // 
            // lblCar1TimeTkes
            // 
            this.lblCar1TimeTkes.AutoSize = true;
            this.lblCar1TimeTkes.Location = new System.Drawing.Point(1147, 81);
            this.lblCar1TimeTkes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCar1TimeTkes.Name = "lblCar1TimeTkes";
            this.lblCar1TimeTkes.Size = new System.Drawing.Size(18, 17);
            this.lblCar1TimeTkes.TabIndex = 10;
            this.lblCar1TimeTkes.Text = "--";
            // 
            // pcbCar1Tkes
            // 
            this.pcbCar1Tkes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pcbCar1Tkes.Location = new System.Drawing.Point(36, 36);
            this.pcbCar1Tkes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbCar1Tkes.Name = "pcbCar1Tkes";
            this.pcbCar1Tkes.Size = new System.Drawing.Size(133, 62);
            this.pcbCar1Tkes.TabIndex = 0;
            this.pcbCar1Tkes.TabStop = false;
            // 
            // pcbCar3Tkes
            // 
            this.pcbCar3Tkes.BackColor = System.Drawing.Color.Yellow;
            this.pcbCar3Tkes.Location = new System.Drawing.Point(36, 224);
            this.pcbCar3Tkes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbCar3Tkes.Name = "pcbCar3Tkes";
            this.pcbCar3Tkes.Size = new System.Drawing.Size(133, 62);
            this.pcbCar3Tkes.TabIndex = 5;
            this.pcbCar3Tkes.TabStop = false;
            // 
            // pcbCar4Tkes
            // 
            this.pcbCar4Tkes.BackColor = System.Drawing.Color.Lime;
            this.pcbCar4Tkes.Location = new System.Drawing.Point(36, 318);
            this.pcbCar4Tkes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbCar4Tkes.Name = "pcbCar4Tkes";
            this.pcbCar4Tkes.Size = new System.Drawing.Size(133, 62);
            this.pcbCar4Tkes.TabIndex = 4;
            this.pcbCar4Tkes.TabStop = false;
            // 
            // pcbCar2Tkes
            // 
            this.pcbCar2Tkes.BackColor = System.Drawing.Color.Red;
            this.pcbCar2Tkes.Location = new System.Drawing.Point(36, 128);
            this.pcbCar2Tkes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbCar2Tkes.Name = "pcbCar2Tkes";
            this.pcbCar2Tkes.Size = new System.Drawing.Size(133, 62);
            this.pcbCar2Tkes.TabIndex = 3;
            this.pcbCar2Tkes.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Location = new System.Drawing.Point(20, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1119, 86);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gray;
            this.pictureBox2.Location = new System.Drawing.Point(20, 117);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1119, 86);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Gray;
            this.pictureBox3.Location = new System.Drawing.Point(20, 210);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1119, 86);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Gray;
            this.pictureBox4.Location = new System.Drawing.Point(20, 304);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1119, 86);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox5.Location = new System.Drawing.Point(20, 23);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(17, 367);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // tbcMainTkes
            // 
            this.tbcMainTkes.Controls.Add(this.tbpRaceTkes);
            this.tbcMainTkes.Controls.Add(this.tbpSettingsTkes);
            this.tbcMainTkes.Controls.Add(this.tbcScoresTkes);
            this.tbcMainTkes.Location = new System.Drawing.Point(17, 34);
            this.tbcMainTkes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbcMainTkes.Name = "tbcMainTkes";
            this.tbcMainTkes.SelectedIndex = 0;
            this.tbcMainTkes.Size = new System.Drawing.Size(1433, 578);
            this.tbcMainTkes.TabIndex = 10;
            // 
            // tbpRaceTkes
            // 
            this.tbpRaceTkes.Controls.Add(this.groupBox1);
            this.tbpRaceTkes.Location = new System.Drawing.Point(4, 25);
            this.tbpRaceTkes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpRaceTkes.Name = "tbpRaceTkes";
            this.tbpRaceTkes.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpRaceTkes.Size = new System.Drawing.Size(1425, 549);
            this.tbpRaceTkes.TabIndex = 0;
            this.tbpRaceTkes.Text = "tabPage1";
            this.tbpRaceTkes.UseVisualStyleBackColor = true;
            // 
            // tbpSettingsTkes
            // 
            this.tbpSettingsTkes.Controls.Add(this.btnSetNameTkes);
            this.tbpSettingsTkes.Controls.Add(this.lblCar4NameTkes);
            this.tbpSettingsTkes.Controls.Add(this.lblCar3NameTkes);
            this.tbpSettingsTkes.Controls.Add(this.lblCar2NameTkes);
            this.tbpSettingsTkes.Controls.Add(this.lblCar1NameTkes);
            this.tbpSettingsTkes.Controls.Add(this.txbCar4NameTkes);
            this.tbpSettingsTkes.Controls.Add(this.txbCar3NameTkes);
            this.tbpSettingsTkes.Controls.Add(this.txbCar2NameTkes);
            this.tbpSettingsTkes.Controls.Add(this.txbCar1NameTkes);
            this.tbpSettingsTkes.Location = new System.Drawing.Point(4, 25);
            this.tbpSettingsTkes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpSettingsTkes.Name = "tbpSettingsTkes";
            this.tbpSettingsTkes.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpSettingsTkes.Size = new System.Drawing.Size(1425, 549);
            this.tbpSettingsTkes.TabIndex = 1;
            this.tbpSettingsTkes.Text = "tabPage2";
            this.tbpSettingsTkes.UseVisualStyleBackColor = true;
            // 
            // btnSetNameTkes
            // 
            this.btnSetNameTkes.Location = new System.Drawing.Point(12, 135);
            this.btnSetNameTkes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSetNameTkes.Name = "btnSetNameTkes";
            this.btnSetNameTkes.Size = new System.Drawing.Size(221, 28);
            this.btnSetNameTkes.TabIndex = 8;
            this.btnSetNameTkes.Text = "Set Name\'s";
            this.btnSetNameTkes.UseVisualStyleBackColor = true;
            this.btnSetNameTkes.Click += new System.EventHandler(this.btnSetNameTkes_Click);
            // 
            // lblCar4NameTkes
            // 
            this.lblCar4NameTkes.AutoSize = true;
            this.lblCar4NameTkes.Location = new System.Drawing.Point(8, 103);
            this.lblCar4NameTkes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCar4NameTkes.Name = "lblCar4NameTkes";
            this.lblCar4NameTkes.Size = new System.Drawing.Size(79, 17);
            this.lblCar4NameTkes.TabIndex = 7;
            this.lblCar4NameTkes.Text = "Car4 Name";
            // 
            // lblCar3NameTkes
            // 
            this.lblCar3NameTkes.AutoSize = true;
            this.lblCar3NameTkes.Location = new System.Drawing.Point(8, 70);
            this.lblCar3NameTkes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCar3NameTkes.Name = "lblCar3NameTkes";
            this.lblCar3NameTkes.Size = new System.Drawing.Size(83, 17);
            this.lblCar3NameTkes.TabIndex = 6;
            this.lblCar3NameTkes.Text = "Car 3 Name";
            // 
            // lblCar2NameTkes
            // 
            this.lblCar2NameTkes.AutoSize = true;
            this.lblCar2NameTkes.Location = new System.Drawing.Point(8, 37);
            this.lblCar2NameTkes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCar2NameTkes.Name = "lblCar2NameTkes";
            this.lblCar2NameTkes.Size = new System.Drawing.Size(83, 17);
            this.lblCar2NameTkes.TabIndex = 5;
            this.lblCar2NameTkes.Text = "Car 2 Name";
            // 
            // lblCar1NameTkes
            // 
            this.lblCar1NameTkes.AutoSize = true;
            this.lblCar1NameTkes.Location = new System.Drawing.Point(8, 4);
            this.lblCar1NameTkes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCar1NameTkes.Name = "lblCar1NameTkes";
            this.lblCar1NameTkes.Size = new System.Drawing.Size(83, 17);
            this.lblCar1NameTkes.TabIndex = 4;
            this.lblCar1NameTkes.Text = "Car 1 Name";
            // 
            // txbCar4NameTkes
            // 
            this.txbCar4NameTkes.Location = new System.Drawing.Point(100, 103);
            this.txbCar4NameTkes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbCar4NameTkes.Name = "txbCar4NameTkes";
            this.txbCar4NameTkes.Size = new System.Drawing.Size(132, 22);
            this.txbCar4NameTkes.TabIndex = 3;
            // 
            // txbCar3NameTkes
            // 
            this.txbCar3NameTkes.Location = new System.Drawing.Point(100, 70);
            this.txbCar3NameTkes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbCar3NameTkes.Name = "txbCar3NameTkes";
            this.txbCar3NameTkes.Size = new System.Drawing.Size(132, 22);
            this.txbCar3NameTkes.TabIndex = 2;
            // 
            // txbCar2NameTkes
            // 
            this.txbCar2NameTkes.Location = new System.Drawing.Point(100, 37);
            this.txbCar2NameTkes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbCar2NameTkes.Name = "txbCar2NameTkes";
            this.txbCar2NameTkes.Size = new System.Drawing.Size(132, 22);
            this.txbCar2NameTkes.TabIndex = 1;
            // 
            // txbCar1NameTkes
            // 
            this.txbCar1NameTkes.Location = new System.Drawing.Point(100, 4);
            this.txbCar1NameTkes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbCar1NameTkes.Name = "txbCar1NameTkes";
            this.txbCar1NameTkes.Size = new System.Drawing.Size(132, 22);
            this.txbCar1NameTkes.TabIndex = 0;
            // 
            // tbcScoresTkes
            // 
            this.tbcScoresTkes.Controls.Add(this.lblCar4ScoreTkes);
            this.tbcScoresTkes.Controls.Add(this.lblPlayer4ScoreNameTkes);
            this.tbcScoresTkes.Controls.Add(this.lblCar3ScoreTkes);
            this.tbcScoresTkes.Controls.Add(this.lblCar2ScoreTkes);
            this.tbcScoresTkes.Controls.Add(this.lblCar1ScoreTkes);
            this.tbcScoresTkes.Controls.Add(this.lblPlayer3ScoreNameTkes);
            this.tbcScoresTkes.Controls.Add(this.lblPlayer2ScoreNameTkes);
            this.tbcScoresTkes.Controls.Add(this.lblPlayer1ScoreNameTkes);
            this.tbcScoresTkes.Location = new System.Drawing.Point(4, 25);
            this.tbcScoresTkes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbcScoresTkes.Name = "tbcScoresTkes";
            this.tbcScoresTkes.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbcScoresTkes.Size = new System.Drawing.Size(1425, 549);
            this.tbcScoresTkes.TabIndex = 2;
            this.tbcScoresTkes.Text = "tabPage1";
            this.tbcScoresTkes.UseVisualStyleBackColor = true;
            // 
            // lblCar4ScoreTkes
            // 
            this.lblCar4ScoreTkes.AutoSize = true;
            this.lblCar4ScoreTkes.Location = new System.Drawing.Point(123, 52);
            this.lblCar4ScoreTkes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCar4ScoreTkes.Name = "lblCar4ScoreTkes";
            this.lblCar4ScoreTkes.Size = new System.Drawing.Size(18, 17);
            this.lblCar4ScoreTkes.TabIndex = 7;
            this.lblCar4ScoreTkes.Text = "--";
            // 
            // lblPlayer4ScoreNameTkes
            // 
            this.lblPlayer4ScoreNameTkes.AutoSize = true;
            this.lblPlayer4ScoreNameTkes.Location = new System.Drawing.Point(8, 52);
            this.lblPlayer4ScoreNameTkes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer4ScoreNameTkes.Name = "lblPlayer4ScoreNameTkes";
            this.lblPlayer4ScoreNameTkes.Size = new System.Drawing.Size(83, 17);
            this.lblPlayer4ScoreNameTkes.TabIndex = 6;
            this.lblPlayer4ScoreNameTkes.Text = "Car 3 Score";
            // 
            // lblCar3ScoreTkes
            // 
            this.lblCar3ScoreTkes.AutoSize = true;
            this.lblCar3ScoreTkes.Location = new System.Drawing.Point(123, 36);
            this.lblCar3ScoreTkes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCar3ScoreTkes.Name = "lblCar3ScoreTkes";
            this.lblCar3ScoreTkes.Size = new System.Drawing.Size(18, 17);
            this.lblCar3ScoreTkes.TabIndex = 5;
            this.lblCar3ScoreTkes.Text = "--";
            // 
            // lblCar2ScoreTkes
            // 
            this.lblCar2ScoreTkes.AutoSize = true;
            this.lblCar2ScoreTkes.Location = new System.Drawing.Point(123, 20);
            this.lblCar2ScoreTkes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCar2ScoreTkes.Name = "lblCar2ScoreTkes";
            this.lblCar2ScoreTkes.Size = new System.Drawing.Size(18, 17);
            this.lblCar2ScoreTkes.TabIndex = 4;
            this.lblCar2ScoreTkes.Text = "--";
            // 
            // lblCar1ScoreTkes
            // 
            this.lblCar1ScoreTkes.AutoSize = true;
            this.lblCar1ScoreTkes.Location = new System.Drawing.Point(123, 4);
            this.lblCar1ScoreTkes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCar1ScoreTkes.Name = "lblCar1ScoreTkes";
            this.lblCar1ScoreTkes.Size = new System.Drawing.Size(18, 17);
            this.lblCar1ScoreTkes.TabIndex = 3;
            this.lblCar1ScoreTkes.Text = "--";
            // 
            // lblPlayer3ScoreNameTkes
            // 
            this.lblPlayer3ScoreNameTkes.AutoSize = true;
            this.lblPlayer3ScoreNameTkes.Location = new System.Drawing.Point(8, 36);
            this.lblPlayer3ScoreNameTkes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer3ScoreNameTkes.Name = "lblPlayer3ScoreNameTkes";
            this.lblPlayer3ScoreNameTkes.Size = new System.Drawing.Size(83, 17);
            this.lblPlayer3ScoreNameTkes.TabIndex = 2;
            this.lblPlayer3ScoreNameTkes.Text = "Car 3 Score";
            // 
            // lblPlayer2ScoreNameTkes
            // 
            this.lblPlayer2ScoreNameTkes.AutoSize = true;
            this.lblPlayer2ScoreNameTkes.Location = new System.Drawing.Point(8, 20);
            this.lblPlayer2ScoreNameTkes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer2ScoreNameTkes.Name = "lblPlayer2ScoreNameTkes";
            this.lblPlayer2ScoreNameTkes.Size = new System.Drawing.Size(83, 17);
            this.lblPlayer2ScoreNameTkes.TabIndex = 1;
            this.lblPlayer2ScoreNameTkes.Text = "Car 2 Score";
            // 
            // lblPlayer1ScoreNameTkes
            // 
            this.lblPlayer1ScoreNameTkes.AutoSize = true;
            this.lblPlayer1ScoreNameTkes.Location = new System.Drawing.Point(8, 4);
            this.lblPlayer1ScoreNameTkes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer1ScoreNameTkes.Name = "lblPlayer1ScoreNameTkes";
            this.lblPlayer1ScoreNameTkes.Size = new System.Drawing.Size(83, 17);
            this.lblPlayer1ScoreNameTkes.TabIndex = 0;
            this.lblPlayer1ScoreNameTkes.Text = "Car 1 Score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 570);
            this.Controls.Add(this.tbcMainTkes);
            this.Controls.Add(this.mspMainTkes);
            this.MainMenuStrip = this.mspMainTkes;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mspMainTkes.ResumeLayout(false);
            this.mspMainTkes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFinishTkes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCar1Tkes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCar3Tkes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCar4Tkes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCar2Tkes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.tbcMainTkes.ResumeLayout(false);
            this.tbpRaceTkes.ResumeLayout(false);
            this.tbpSettingsTkes.ResumeLayout(false);
            this.tbpSettingsTkes.PerformLayout();
            this.tbcScoresTkes.ResumeLayout(false);
            this.tbcScoresTkes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoTkes;
        private System.Windows.Forms.Timer tmrRaceTimerTkes;
        private System.Windows.Forms.Button btnResetTkes;
        private System.Windows.Forms.MenuStrip mspMainTkes;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pcbFinishTkes;
        private System.Windows.Forms.Label lblPlace4Tkes;
        private System.Windows.Forms.Label lblPlace3Tkes;
        private System.Windows.Forms.Label lblPlace2Tkes;
        private System.Windows.Forms.Label lblPlace1Tkes;
        private System.Windows.Forms.Label lblTotalTimeTkes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCar2TimeTkes;
        private System.Windows.Forms.Label lblCar3TimeTkes;
        private System.Windows.Forms.Label lblCar4TimeTkes;
        private System.Windows.Forms.Label lblCar1TimeTkes;
        private System.Windows.Forms.PictureBox pcbCar1Tkes;
        private System.Windows.Forms.PictureBox pcbCar3Tkes;
        private System.Windows.Forms.PictureBox pcbCar4Tkes;
        private System.Windows.Forms.PictureBox pcbCar2Tkes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TabControl tbcMainTkes;
        private System.Windows.Forms.TabPage tbpRaceTkes;
        private System.Windows.Forms.TabPage tbpSettingsTkes;
        private System.Windows.Forms.Button btnSetNameTkes;
        private System.Windows.Forms.Label lblCar4NameTkes;
        private System.Windows.Forms.Label lblCar3NameTkes;
        private System.Windows.Forms.Label lblCar2NameTkes;
        private System.Windows.Forms.Label lblCar1NameTkes;
        private System.Windows.Forms.TextBox txbCar4NameTkes;
        private System.Windows.Forms.TextBox txbCar3NameTkes;
        private System.Windows.Forms.TextBox txbCar2NameTkes;
        private System.Windows.Forms.TextBox txbCar1NameTkes;
        private System.Windows.Forms.TabPage tbcScoresTkes;
        private System.Windows.Forms.Label lblCar4ScoreTkes;
        private System.Windows.Forms.Label lblPlayer4ScoreNameTkes;
        private System.Windows.Forms.Label lblCar3ScoreTkes;
        private System.Windows.Forms.Label lblCar2ScoreTkes;
        private System.Windows.Forms.Label lblCar1ScoreTkes;
        private System.Windows.Forms.Label lblPlayer3ScoreNameTkes;
        private System.Windows.Forms.Label lblPlayer2ScoreNameTkes;
        private System.Windows.Forms.Label lblPlayer1ScoreNameTkes;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem serialMonitorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem scoresToolStripMenuItem;
    }
}

