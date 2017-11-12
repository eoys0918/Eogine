namespace Client
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
            this.glViewport1 = new Eogine.GLViewport();
            this.SuspendLayout();
            // 
            // glViewport1
            // 
            this.glViewport1.BackColor = System.Drawing.Color.Black;
            this.glViewport1.Location = new System.Drawing.Point(213, 182);
            this.glViewport1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.glViewport1.Name = "glViewport1";
            this.glViewport1.Size = new System.Drawing.Size(859, 758);
            this.glViewport1.TabIndex = 2;
            this.glViewport1.ViewportBackgroundColor = System.Drawing.Color.Black;
            this.glViewport1.VSync = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionEnable = true;
            this.CaptionText = "테스트";
            this.ClientSize = new System.Drawing.Size(1280, 900);
            this.ControlBoxVisible = true;
            this.Controls.Add(this.glViewport1);
            this.FormSize = new System.Drawing.Size(1280, 900);
            this.IconImage = global::Client.Properties.Resources.checkbox00_18x18_sel;
            this.IconVisible = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Controls.SetChildIndex(this.glViewport1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Eogine.GLViewport glViewport1;





    }
}