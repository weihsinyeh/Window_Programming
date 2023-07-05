namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.start = new System.Windows.Forms.Button();
            this.round_show = new System.Windows.Forms.Label();
            this.player_next = new System.Windows.Forms.Label();
            this.P2_score = new System.Windows.Forms.Label();
            this.P1_score = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(291, 213);
            this.start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(203, 71);
            this.start.TabIndex = 0;
            this.start.Text = "開始遊戲";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // round_show
            // 
            this.round_show.AutoSize = true;
            this.round_show.Font = new System.Drawing.Font("新細明體", 15F);
            this.round_show.Location = new System.Drawing.Point(260, 31);
            this.round_show.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.round_show.Name = "round_show";
            this.round_show.Size = new System.Drawing.Size(99, 25);
            this.round_show.TabIndex = 1;
            this.round_show.Text = "第1回合";
            this.round_show.Visible = false;
            this.round_show.Click += new System.EventHandler(this.label1_Click);
            // 
            // player_next
            // 
            this.player_next.AutoSize = true;
            this.player_next.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_next.Location = new System.Drawing.Point(391, 31);
            this.player_next.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player_next.Name = "player_next";
            this.player_next.Size = new System.Drawing.Size(93, 27);
            this.player_next.TabIndex = 2;
            this.player_next.Text = "輪到P1";
            this.player_next.Visible = false;
            // 
            // P2_score
            // 
            this.P2_score.AutoSize = true;
            this.P2_score.Font = new System.Drawing.Font("新細明體", 15F);
            this.P2_score.Location = new System.Drawing.Point(29, 127);
            this.P2_score.Name = "P2_score";
            this.P2_score.Size = new System.Drawing.Size(93, 25);
            this.P2_score.TabIndex = 4;
            this.P2_score.Text = "P2: 0 分";
            this.P2_score.Visible = false;
            // 
            // P1_score
            // 
            this.P1_score.AutoSize = true;
            this.P1_score.Font = new System.Drawing.Font("新細明體", 15F);
            this.P1_score.Location = new System.Drawing.Point(762, 127);
            this.P1_score.Name = "P1_score";
            this.P1_score.Size = new System.Drawing.Size(93, 25);
            this.P1_score.TabIndex = 5;
            this.P1_score.Text = "P1: 0 分";
            this.P1_score.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 562);
            this.Controls.Add(this.P1_score);
            this.Controls.Add(this.P2_score);
            this.Controls.Add(this.player_next);
            this.Controls.Add(this.round_show);
            this.Controls.Add(this.start);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label round_show;
        private System.Windows.Forms.Label player_next;
        private System.Windows.Forms.Label P2_score;
        private System.Windows.Forms.Label P1_score;
        private System.Windows.Forms.Timer timer1;
    }
}

