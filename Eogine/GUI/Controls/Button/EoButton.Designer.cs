﻿namespace Eogine
{
    partial class EoButton
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
            this.SuspendLayout();
            // 
            // EoButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EoButton";
            this.Size = new System.Drawing.Size(80, 30);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EoButton_MouseDown);
            this.MouseEnter += new System.EventHandler(this.EoButton_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.EoButton_MouseLeave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EoButton_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
