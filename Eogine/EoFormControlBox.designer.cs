namespace Eogine.GUI.Controls.Form
{
    partial class EoFormControlBox
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EoFormControlBox));
            this.MinButton = new Eogine.EoButton();
            this.MaxButton = new Eogine.EoButton();
            this.CloseButton = new Eogine.EoButton();
            this.SuspendLayout();
            // 
            // MinButton
            // 
            this.MinButton.BackColor = System.Drawing.Color.Transparent;
            this.MinButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinButton.BackgroundImage")));
            this.MinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MinButton.ButtonType = Eogine.EoButton.TYPE.IMAGE;
            this.MinButton.DefaultImage = ((System.Drawing.Image)(resources.GetObject("MinButton.DefaultImage")));
            this.MinButton.DisabledImage = null;
            this.MinButton.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MinButton.Location = new System.Drawing.Point(6, 6);
            this.MinButton.Margin = new System.Windows.Forms.Padding(6);
            this.MinButton.Name = "MinButton";
            this.MinButton.OverImage = global::Eogine.Properties.Resources.controlbox_minisize_sel;
            this.MinButton.SelectedImage = global::Eogine.Properties.Resources.controlbox_minisize_dim;
            this.MinButton.Size = new System.Drawing.Size(18, 18);
            this.MinButton.TabIndex = 2;
            this.MinButton.Click += new System.EventHandler(this.MinButton_Click);
            // 
            // MaxButton
            // 
            this.MaxButton.BackColor = System.Drawing.Color.Transparent;
            this.MaxButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MaxButton.BackgroundImage")));
            this.MaxButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MaxButton.ButtonType = Eogine.EoButton.TYPE.IMAGE;
            this.MaxButton.DefaultImage = ((System.Drawing.Image)(resources.GetObject("MaxButton.DefaultImage")));
            this.MaxButton.DisabledImage = null;
            this.MaxButton.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MaxButton.Location = new System.Drawing.Point(36, 6);
            this.MaxButton.Margin = new System.Windows.Forms.Padding(6);
            this.MaxButton.Name = "MaxButton";
            this.MaxButton.OverImage = global::Eogine.Properties.Resources.controlbox_max_sel;
            this.MaxButton.SelectedImage = global::Eogine.Properties.Resources.controlbox_max_dim;
            this.MaxButton.Size = new System.Drawing.Size(18, 18);
            this.MaxButton.TabIndex = 1;
            this.MaxButton.Click += new System.EventHandler(this.MaxButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseButton.ButtonType = Eogine.EoButton.TYPE.IMAGE;
            this.CloseButton.DefaultImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.DefaultImage")));
            this.CloseButton.DisabledImage = null;
            this.CloseButton.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CloseButton.Location = new System.Drawing.Point(66, 6);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(6);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.OverImage = global::Eogine.Properties.Resources.controlbox_close_sel;
            this.CloseButton.SelectedImage = global::Eogine.Properties.Resources.controlbox_close_dim;
            this.CloseButton.Size = new System.Drawing.Size(18, 18);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // EoFormControlBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MinButton);
            this.Controls.Add(this.MaxButton);
            this.Controls.Add(this.CloseButton);
            this.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EoFormControlBox";
            this.Size = new System.Drawing.Size(90, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private EoButton MaxButton;
        private EoButton MinButton;
        private EoButton CloseButton;
    }
}
