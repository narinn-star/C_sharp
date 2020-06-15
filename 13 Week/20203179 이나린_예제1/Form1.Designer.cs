namespace _20203179_이나린_예제1
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.도구ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.출력ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.출력ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.출력ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.종료ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도구ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(452, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 도구ToolStripMenuItem
            // 
            this.도구ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.출력ToolStripMenuItem,
            this.출력ToolStripMenuItem1,
            this.출력ToolStripMenuItem2,
            this.종료ToolStripMenuItem,
            this.종료ToolStripMenuItem1});
            this.도구ToolStripMenuItem.Name = "도구ToolStripMenuItem";
            this.도구ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.도구ToolStripMenuItem.Text = "도구";
            // 
            // 출력ToolStripMenuItem
            // 
            this.출력ToolStripMenuItem.Name = "출력ToolStripMenuItem";
            this.출력ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.출력ToolStripMenuItem.Text = "1출력";
            this.출력ToolStripMenuItem.Click += new System.EventHandler(this.출력ToolStripMenuItem_Click);
            // 
            // 출력ToolStripMenuItem1
            // 
            this.출력ToolStripMenuItem1.Name = "출력ToolStripMenuItem1";
            this.출력ToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.출력ToolStripMenuItem1.Text = "2출력";
            this.출력ToolStripMenuItem1.Click += new System.EventHandler(this.출력ToolStripMenuItem1_Click);
            // 
            // 출력ToolStripMenuItem2
            // 
            this.출력ToolStripMenuItem2.Name = "출력ToolStripMenuItem2";
            this.출력ToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.출력ToolStripMenuItem2.Text = "3출력";
            this.출력ToolStripMenuItem2.Click += new System.EventHandler(this.출력ToolStripMenuItem2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "결과가 나오는 곳입니다";
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(221, 6);
            // 
            // 종료ToolStripMenuItem1
            // 
            this.종료ToolStripMenuItem1.Name = "종료ToolStripMenuItem1";
            this.종료ToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.종료ToolStripMenuItem1.Text = "종료";
            this.종료ToolStripMenuItem1.Click += new System.EventHandler(this.종료ToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 도구ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 출력ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 출력ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 출력ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
    }
}

