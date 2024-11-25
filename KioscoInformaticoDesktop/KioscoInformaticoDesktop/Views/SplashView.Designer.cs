namespace KioscoInformaticoDesktop.Views
{
    partial class SplashView
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashView));
            progressBar = new ProgressBar();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.Location = new Point(25, 363);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(738, 59);
            progressBar.TabIndex = 0;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 200;
            timer.Tick += timer_Tick;
            // 
            // SplashView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(788, 450);
            ControlBox = false;
            Controls.Add(progressBar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "SplashView";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashView";
            TopMost = true;
            Activated += SplashView_Activated;
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
    }
}