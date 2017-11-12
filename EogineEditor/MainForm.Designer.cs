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
            this.BorderPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.glViewport = new Eogine.GLViewport();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.BorderPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BorderPanel
            // 
            this.BorderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.BorderPanel.Controls.Add(this.MainPanel);
            this.BorderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BorderPanel.Location = new System.Drawing.Point(0, 30);
            this.BorderPanel.Name = "BorderPanel";
            this.BorderPanel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.BorderPanel.Size = new System.Drawing.Size(1280, 690);
            this.BorderPanel.TabIndex = 2;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(80)))), ((int)(((byte)(108)))));
            this.MainPanel.Controls.Add(this.glViewport);
            this.MainPanel.Controls.Add(this.RightPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(3, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(3);
            this.MainPanel.Size = new System.Drawing.Size(1274, 687);
            this.MainPanel.TabIndex = 0;
            // 
            // glViewport
            // 
            this.glViewport.BackColor = System.Drawing.Color.Black;
            this.glViewport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glViewport.Location = new System.Drawing.Point(3, 3);
            this.glViewport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.glViewport.Name = "glViewport";
            this.glViewport.Size = new System.Drawing.Size(968, 681);
            this.glViewport.TabIndex = 0;
            this.glViewport.ViewportBackgroundColor = System.Drawing.Color.Black;
            this.glViewport.VSync = false;
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.Transparent;
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(971, 3);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(300, 681);
            this.RightPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionEnable = true;
            this.CaptionText = "Editor";
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBoxVisible = true;
            this.Controls.Add(this.BorderPanel);
            this.FormClientSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Controls.SetChildIndex(this.BorderPanel, 0);
            this.BorderPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BorderPanel;
        private System.Windows.Forms.Panel MainPanel;
        private Eogine.GLViewport glViewport;
        private System.Windows.Forms.Panel RightPanel;
    }
}