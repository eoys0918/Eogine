namespace EogineEditor
{
    partial class MainForm
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
            Eogine.GLCamera glCamera1 = new Eogine.GLCamera();
            this.borderPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.glViewport = new Eogine.GLViewport();
            this.borderPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // borderPanel
            // 
            this.borderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.borderPanel.Controls.Add(this.mainPanel);
            this.borderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borderPanel.Location = new System.Drawing.Point(0, 30);
            this.borderPanel.Name = "borderPanel";
            this.borderPanel.Padding = new System.Windows.Forms.Padding(3);
            this.borderPanel.Size = new System.Drawing.Size(1280, 690);
            this.borderPanel.TabIndex = 2;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(66)))), ((int)(((byte)(93)))));
            this.mainPanel.Controls.Add(this.glViewport);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(3, 3);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(3);
            this.mainPanel.Size = new System.Drawing.Size(1274, 684);
            this.mainPanel.TabIndex = 0;
            // 
            // glViewport
            // 
            this.glViewport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.glViewport.BackColor = System.Drawing.Color.Black;
            this.glViewport.BackgroundColor = System.Drawing.Color.Black;
            this.glViewport.Location = new System.Drawing.Point(9, 7);
            this.glViewport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.glViewport.Name = "glViewport";
            this.glViewport.Size = new System.Drawing.Size(977, 667);
            this.glViewport.TabIndex = 0;
            this.glViewport.ViewportCam = glCamera1;
            this.glViewport.VSync = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CaptionEnable = true;
            this.CaptionText = "Editor";
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBoxVisible = true;
            this.Controls.Add(this.borderPanel);
            this.FormClientSize = new System.Drawing.Size(1280, 720);
            this.IconImage = global::EogineEditor.Properties.Resources.Koala;
            this.IconVisible = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Controls.SetChildIndex(this.borderPanel, 0);
            this.borderPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel borderPanel;
        private System.Windows.Forms.Panel mainPanel;
        private Eogine.GLViewport glViewport;
    }
}