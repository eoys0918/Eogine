namespace Eogine
{
    partial class EoForm
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
            this.CaptionBar = new Eogine.EoCaption();
            this.SuspendLayout();
            // 
            // CaptionBar
            // 
            this.CaptionBar.BackColor = System.Drawing.Color.DimGray;
            this.CaptionBar.ControlBoxVisible = true;
            this.CaptionBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.CaptionBar.IconVisible = true;
            this.CaptionBar.Location = new System.Drawing.Point(0, 0);
            this.CaptionBar.Margin = new System.Windows.Forms.Padding(0);
            this.CaptionBar.Name = "CaptionBar";
            this.CaptionBar.Size = new System.Drawing.Size(300, 30);
            this.CaptionBar.TabIndex = 0;
            // 
            // EoForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.CaptionBar);
            this.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EoForm";
            this.Text = "EoForm";
            this.Resize += new System.EventHandler(this.EoForm_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private EoCaption CaptionBar;

    }
}