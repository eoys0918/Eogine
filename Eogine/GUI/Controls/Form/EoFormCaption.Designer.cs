namespace Eogine
{
    partial class EoFormCaption
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
            this.panelIcon = new System.Windows.Forms.Panel();
            this.panelCaption = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.ControlBox = new Eogine.EoFormControlBox();
            this.panelCaption.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIcon
            // 
            this.panelIcon.BackColor = System.Drawing.Color.Transparent;
            this.panelIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIcon.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panelIcon.Location = new System.Drawing.Point(0, 0);
            this.panelIcon.Margin = new System.Windows.Forms.Padding(0);
            this.panelIcon.Name = "panelIcon";
            this.panelIcon.Size = new System.Drawing.Size(30, 30);
            this.panelIcon.TabIndex = 1;
            // 
            // panelCaption
            // 
            this.panelCaption.BackColor = System.Drawing.Color.Transparent;
            this.panelCaption.Controls.Add(this.labelTitle);
            this.panelCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCaption.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panelCaption.Location = new System.Drawing.Point(30, 0);
            this.panelCaption.Margin = new System.Windows.Forms.Padding(0);
            this.panelCaption.Name = "panelCaption";
            this.panelCaption.Size = new System.Drawing.Size(480, 30);
            this.panelCaption.TabIndex = 3;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(10, 6);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(54, 17);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Caption";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ControlBox
            // 
            this.ControlBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlBox.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ControlBox.Location = new System.Drawing.Point(510, 0);
            this.ControlBox.Margin = new System.Windows.Forms.Padding(0);
            this.ControlBox.Name = "ControlBox";
            this.ControlBox.Size = new System.Drawing.Size(90, 30);
            this.ControlBox.TabIndex = 5;
            // 
            // EoFormCaption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.panelCaption);
            this.Controls.Add(this.ControlBox);
            this.Controls.Add(this.panelIcon);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EoFormCaption";
            this.Size = new System.Drawing.Size(600, 30);
            this.panelCaption.ResumeLayout(false);
            this.panelCaption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIcon;
        private System.Windows.Forms.Panel panelCaption;
        private System.Windows.Forms.Label labelTitle;
        private EoFormControlBox ControlBox;
    }
}
