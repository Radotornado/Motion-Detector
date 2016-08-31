/*
 MIT License
Copyright (c) [2016] [Radoslav Mandev]
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial SerialPortions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Vision.Motion;
using AForge.Imaging;

namespace MotionDetectorSample
{
    public partial class MainForm : Form
    {
        private IVideoSource videoSource = null;
        MotionDetector detector = new MotionDetector(new TwoFramesDifferenceDetector( ), new MotionAreaHighlighting( ) );
        private int detectionType = 1;
        private int processingType = 1;
        
        private const int statLength = 15;
        private int statIndex = 0;
        private int statReady = 0;
        private int[] statCount = new int[statLength];
        
        private int flash = 0;
        private float motionAlarmLevel = 0.015f;

        private List<float> motionHistory = new List<float>( );

        FilterInfoCollection videoDevices;
        private string device;
        public string VideoDevice
        {
            get { return device; }
        }

        public MainForm( )
        {
            InitializeComponent( );

            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                foreach (FilterInfo device in videoDevices)
                {
                    devicesCombo.Items.Add(device.Name);
                }
            }
            catch (ApplicationException)
            {
                devicesCombo.Items.Add("No local capture devices");
                devicesCombo.Enabled = false;
            }

            devicesCombo.SelectedIndex = 0;
        }

        private void okButtons_Click(object sender, EventArgs e)
        {
            device = videoDevices[devicesCombo.SelectedIndex].MonikerString;
            VideoCaptureDevice videoSource = new VideoCaptureDevice(VideoDevice);
            OpenVideoSource(videoSource);
        }

        private void MainForm_FormClosing( object sender, FormClosingEventArgs e )
        {
            CloseVideoSource( );
        }
        
        private void OpenVideoSource( IVideoSource source )
        {
            this.Cursor = Cursors.WaitCursor;
            CloseVideoSource( );
            videoSourcePlayer.VideoSource = new AsyncVideoSource( source );
            videoSourcePlayer.Start( );
            statIndex = statReady = 0;
            timer.Start( );
            alarmTimer.Start( );
            videoSource = source;
            this.Cursor = Cursors.Default;
        }
        
        private void CloseVideoSource( )
        {
            this.Cursor = Cursors.WaitCursor;
            videoSourcePlayer.SignalToStop( );
            for ( int i = 0; ( i < 50 ) && ( videoSourcePlayer.IsRunning ); i++ )
            {
                Thread.Sleep( 1 );
            }
            if ( videoSourcePlayer.IsRunning )
                videoSourcePlayer.Stop( );
            timer.Stop( );
            alarmTimer.Stop( );
            motionHistory.Clear( );
            if ( detector != null )
                detector.Reset( );
            videoSourcePlayer.BorderColor = Color.Black;
            this.Cursor = Cursors.Default;
        }
        
        private void timer_Tick( object sender, EventArgs e )
        {
            IVideoSource videoSource = videoSourcePlayer.VideoSource;

            if ( videoSource != null )
            {
                statCount[statIndex] = videoSource.FramesReceived+2;
                if ( ++statIndex >= statLength )
                    statIndex = 0;
                if ( statReady < statLength )
                    statReady++;
                float fps = 0;
                for ( int i = 0; i < statReady; i++ )
                {
                    fps += statCount[i];
                }
                fps /= statReady;
                statCount[statIndex] = 0;
                fpsLabel.Text = fps.ToString( "F2" ) + " fps";
            }
        }
        // Set motion detecting algorithm.
        private void SetMDAl( IMotionDetector detectionAlgorithm )
        {
            lock ( this )
            {
                detector.MotionDetectionAlgorithm = detectionAlgorithm;
                motionHistory.Clear( );

                if ( detectionAlgorithm is TwoFramesDifferenceDetector )
                {
                    if (
                        ( detector.MotionProcessingAlgorithm is MotionBorderHighlighting ) ||
                        ( detector.MotionProcessingAlgorithm is BlobCountingObjectsProcessing ) )
                    {
                        processingType = 1;
                        SetMotProAl( new MotionAreaHighlighting( ) );
                    }
                }
            }
        }
        // Set motion processing algorithm.
        private void SetMotProAl( IMotionProcessing processingAlgorithm )
        {
            lock ( this )
            {
                detector.MotionProcessingAlgorithm = processingAlgorithm;
            }
        }

        private void alarmTimer_Tick( object sender, EventArgs e )
        {
            //if ( flash != 0 )
            //{
            //    videoSourcePlayer.BorderColor = ( flash % 2 == 1 ) ? Color.Black : Color.Red;
            //    flash--;
            //}
        }

        private void openVideo_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileVideoSource fileSource = new FileVideoSource(openFileDialog.FileName);
                OpenVideoSource(fileSource);
            }
        }

        private void motionToolStrip_DropDownOpening(object sender, EventArgs e)
        {
            ToolStripMenuItem[] motionDetectionItems = new ToolStripMenuItem[]
            {
                noneToolStrip1, twoFramesDifference
            };
            ToolStripMenuItem[] motionProcessingItems = new ToolStripMenuItem[]
            {
                noneToolStrip2, motionAreaHighlighting,
                gridMotionAreaProcessing
            };

            for (int i = 0; i < motionDetectionItems.Length; i++)
            {
                motionDetectionItems[i].Checked = (i == detectionType);
            }
            for (int i = 0; i < motionProcessingItems.Length; i++)
            {
                motionProcessingItems[i].Checked = (i == processingType);
            }
            bool enabled = (detectionType != 1);
        }

        private void noneToolStrip1_Click(object sender, EventArgs e)
        {
            detectionType = 0;
            SetMDAl(null);
        }

        private void twoFramesDiff_Click(object sender, EventArgs e)
        {
            detectionType = 1;
            SetMDAl(new TwoFramesDifferenceDetector());
        }

        private void noneToolStrip2_Click(object sender, EventArgs e)
        {
            processingType = 0;
            SetMotProAl(null);
        }

        private void motionArea_Click(object sender, EventArgs e)
        {
            processingType = 1;
            SetMotProAl(new MotionAreaHighlighting());
        }

        private void gridMotion_Click(object sender, EventArgs e)
        {
            processingType = 2;
            SetMotProAl(new GridMotionAreaProcessing(32, 32));
        }

        private void videoSP_NewFrame(object sender, ref Bitmap image)
        {
            lock (this)
            {
                if (detector != null)
                {
                    float motionLevel = detector.ProcessFrame(image);

                    if (motionLevel > motionAlarmLevel)
                    {
                        flash = (int)(2 * (1000 / alarmTimer.Interval));
                    }
                    motionHistory.Add(motionLevel);
                    if (motionHistory.Count > 300)
                    {
                        motionHistory.RemoveAt(0);
                    }

                }
            }
        }
    }
}