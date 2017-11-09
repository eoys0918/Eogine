namespace Eogine.GUI.Controls.Form
{
    partial class EoControlBox
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
            this.MinButton = new Eogine.EoButton();
            this.MaxButton = new Eogine.EoButton();
            this.CloseButton = new Eogine.EoButton();
            this.SuspendLayout();
            // 
            // MinButton
            // 
            this.MinButton.ButtonType = Eogine.EoButton.TYPE.IMAGE;
            this.MinButton.DefaultImage = null;
            this.MinButton.DisabledImage = null;
            this.MinButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinButton.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MinButton.Location = new System.Drawing.Point(60, 0);
            this.MinButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinButton.Name = "MinButton";
            this.MinButton.OverImage = null;
            this.MinButton.SelectedImage = null;
            this.MinButton.Size = new System.Drawing.Size(30, 30);
            this.MinButton.TabIndex = 2;
            // 
            // MaxButton
            // 
            this.MaxButton.ButtonType = Eogine.EoButton.TYPE.IMAGE;
            this.MaxButton.DefaultImage = null;
            this.MaxButton.DisabledImage = null;
            this.MaxButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaxButton.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MaxButton.Location = new System.Drawing.Point(90, 0);
            this.MaxButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaxButton.Name = "MaxButton";
            this.MaxButton.OverImage = null;
            this.MaxButton.SelectedImage = null;
            this.MaxButton.Size = new System.Drawing.Size(30, 30);
            this.MaxButton.TabIndex = 1;
            // 
            // CloseButton
            // 
            this.CloseButton.ButtonType = Eogine.EoButton.TYPE.IMAGE;
            this.CloseButton.DefaultImage = null;
            this.CloseButton.DisabledImage = null;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CloseButton.Location = new System.Drawing.Point(120, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.OverImage = null;
            this.CloseButton.SelectedImage = null;
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 0;
            // 
            // EoControlBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MinButton);
            this.Controls.Add(this.MaxButton);
            this.Controls.Add(this.CloseButton);
            this.Name = "EoControlBox";
            this.Size = new System.Drawing.Size(150, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private EoButton CloseButton;
        private EoButton MaxButton;
        private EoButton MinButton;
    }
}
