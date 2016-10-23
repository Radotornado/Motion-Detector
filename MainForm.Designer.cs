namespace MotionDetectorSample
{
    partial class MainForm
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code
        
        private void InitializeComponent( )
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.openVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.motionToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.motionDetection = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStrip1 = new System.Windows.Forms.ToolStripMenuItem();
            this.twoFramesDifference = new System.Windows.Forms.ToolStripMenuItem();
            this.motionProcessingAlgorithm = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStrip2 = new System.Windows.Forms.ToolStripMenuItem();
            this.motionAreaHighlighting = new System.Windows.Forms.ToolStripMenuItem();
            this.gridMotionAreaProcessing = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.fpsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.okButton = new System.Windows.Forms.Button();
            this.alarmTimer = new System.Windows.Forms.Timer(this.components);
            this.devicesCombo = new System.Windows.Forms.ComboBox();
            this.menuMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();

            this.menuMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStrip,
            this.motionToolStrip});
            this.menuMenu.Location = new System.Drawing.Point(0, 0);
            this.menuMenu.Name = "menuMenu";
            this.menuMenu.Size = new System.Drawing.Size(660, 26);
            this.menuMenu.TabIndex = 0;

            this.fileToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openVideo});
            this.fileToolStrip.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileToolStrip.Name = "fileToolStrip";
            this.fileToolStrip.Size = new System.Drawing.Size(43, 22);
            this.fileToolStrip.Text = "&File";

            this.openVideo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.openVideo.Name = "openVideo";
            this.openVideo.Size = new System.Drawing.Size(107, 22);
            this.openVideo.Text = "&Open";
            this.openVideo.Click += new System.EventHandler(this.openVideo_Click);

            this.motionToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motionDetection,
            this.motionProcessingAlgorithm});
            this.motionToolStrip.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.motionToolStrip.Name = "motionToolStrip";
            this.motionToolStrip.Size = new System.Drawing.Size(61, 22);
            this.motionToolStrip.Text = "&Motion";
            this.motionToolStrip.DropDownOpening += new System.EventHandler(this.motionToolStrip_DropDownOpening);

            this.motionDetection.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.motionDetection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStrip1,
            this.twoFramesDifference});
            this.motionDetection.Name = "motionDetection";
            this.motionDetection.Size = new System.Drawing.Size(247, 22);
            this.motionDetection.Text = "Motion Detection Algorithm";
            
            this.noneToolStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.noneToolStrip1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.noneToolStrip1.Name = "noneToolStrip1";
            this.noneToolStrip1.Size = new System.Drawing.Size(221, 22);
            this.noneToolStrip1.Text = "None";
            this.noneToolStrip1.Click += new System.EventHandler(this.noneToolStrip1_Click);
            
            this.twoFramesDifference.BackColor = System.Drawing.SystemColors.Highlight;
            this.twoFramesDifference.Name = "twoFramesDifference";
            this.twoFramesDifference.Size = new System.Drawing.Size(221, 22);
            this.twoFramesDifference.Text = "Two Frames Difference";
            this.twoFramesDifference.Click += new System.EventHandler(this.twoFramesDiff_Click);
             
            this.motionProcessingAlgorithm.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.motionProcessingAlgorithm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStrip2,
            this.motionAreaHighlighting,
            this.gridMotionAreaProcessing});
            this.motionProcessingAlgorithm.Name = "motionProcessingAlgorithm";
            this.motionProcessingAlgorithm.Size = new System.Drawing.Size(247, 22);
            this.motionProcessingAlgorithm.Text = "Motion Processing Algorithm";
            
            this.noneToolStrip2.BackColor = System.Drawing.SystemColors.Highlight;
            this.noneToolStrip2.Name = "noneToolStrip2";
            this.noneToolStrip2.Size = new System.Drawing.Size(234, 22);
            this.noneToolStrip2.Text = "None";
            this.noneToolStrip2.Click += new System.EventHandler(this.noneToolStrip2_Click);
            
            this.motionAreaHighlighting.BackColor = System.Drawing.SystemColors.Highlight;
            this.motionAreaHighlighting.Name = "motionAreaHighlighting";
            this.motionAreaHighlighting.Size = new System.Drawing.Size(234, 22);
            this.motionAreaHighlighting.Text = "Motion Area Highlighting";
            this.motionAreaHighlighting.Click += new System.EventHandler(this.motionArea_Click);
            
            this.gridMotionAreaProcessing.BackColor = System.Drawing.SystemColors.Highlight;
            this.gridMotionAreaProcessing.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridMotionAreaProcessing.Name = "gridMotionAreaProcessing";
            this.gridMotionAreaProcessing.Size = new System.Drawing.Size(234, 22);
            this.gridMotionAreaProcessing.Text = "Grid Motion Area Processing";
            this.gridMotionAreaProcessing.Click += new System.EventHandler(this.gridMotion_Click);
             
            this.openFileDialog.Filter = "AVI files (*.avi)|*.avi|All files (*.*)|*.*";
            this.openFileDialog.Title = "Opem movie";
             
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            
            this.statusBar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fpsLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 524);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(660, 27);
            this.statusBar.TabIndex = 3;
            
            this.fpsLabel.AutoSize = false;
            this.fpsLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.fpsLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.fpsLabel.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.fpsLabel.Name = "fpsLabel";
            this.fpsLabel.Size = new System.Drawing.Size(250, 22);
            this.fpsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            
            this.panel1.Controls.Add(this.videoSourcePlayer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 498);
            this.panel1.TabIndex = 4;
            
            this.videoSourcePlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.videoSourcePlayer.AutoSizeControl = true;
            this.videoSourcePlayer.BackColor = System.Drawing.SystemColors.Highlight;
            this.videoSourcePlayer.ForeColor = System.Drawing.Color.White;
            this.videoSourcePlayer.Location = new System.Drawing.Point(169, 128);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(322, 242);
            this.videoSourcePlayer.TabIndex = 0;
            this.videoSourcePlayer.VideoSource = null;
            this.videoSourcePlayer.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSP_NewFrame);
           
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Location = new System.Drawing.Point(538, 526);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(108, 22);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "Ok";
            this.okButton.Click += new System.EventHandler(this.okButtons_Click);
            
            this.alarmTimer.Interval = 200;
            this.alarmTimer.Tick += new System.EventHandler(this.alarmTimer_Tick);
           
            this.devicesCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.devicesCombo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.devicesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.devicesCombo.FormattingEnabled = true;
            this.devicesCombo.Location = new System.Drawing.Point(254, 526);
            this.devicesCombo.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.devicesCombo.Name = "devicesCombo";
            this.devicesCombo.Size = new System.Drawing.Size(281, 23);
            this.devicesCombo.TabIndex = 2;
            
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(660, 551);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.devicesCombo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuMenu);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMenu;
            this.Name = "MainForm";
            this.Text = "Motion Detector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuMenu.ResumeLayout(false);
            this.menuMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMenu;
        private System.Windows.Forms.ToolStripMenuItem motionToolStrip;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel fpsLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem motionDetection;
        private System.Windows.Forms.ToolStripMenuItem noneToolStrip1;
        private System.Windows.Forms.ToolStripMenuItem twoFramesDifference;
        private System.Windows.Forms.ToolStripMenuItem motionProcessingAlgorithm;
        private System.Windows.Forms.ToolStripMenuItem noneToolStrip2;
        private System.Windows.Forms.ToolStripMenuItem gridMotionAreaProcessing;
        private System.Windows.Forms.ToolStripMenuItem motionAreaHighlighting;
        private System.Windows.Forms.Timer alarmTimer;
        private System.Windows.Forms.ToolStripMenuItem fileToolStrip;
        private System.Windows.Forms.ToolStripMenuItem openVideo;
        public AForge.Controls.VideoSourcePlayer videoSourcePlayer;
        private System.Windows.Forms.ComboBox devicesCombo;
        private System.Windows.Forms.Button okButton;
    }
}

