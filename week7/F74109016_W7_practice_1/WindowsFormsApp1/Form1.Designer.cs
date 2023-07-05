namespace WindowsFormsApp1
{
    partial class Form
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
            this.simple_mode = new System.Windows.Forms.Button();
            this.score = new System.Windows.Forms.Label();
            this.current_number = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Label();
            this.general_mode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // simple_mode
            // 
            this.simple_mode.Location = new System.Drawing.Point(221, 90);
            this.simple_mode.Name = "simple_mode";
            this.simple_mode.Size = new System.Drawing.Size(198, 134);
            this.simple_mode.TabIndex = 0;
            this.simple_mode.Text = "簡單模式";
            this.simple_mode.UseVisualStyleBackColor = true;
            this.simple_mode.Click += new System.EventHandler(this.simple_mode_Click);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(620, 70);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(0, 15);
            this.score.TabIndex = 1;
            // 
            // current_number
            // 
            this.current_number.AutoSize = true;
            this.current_number.Location = new System.Drawing.Point(620, 116);
            this.current_number.Name = "current_number";
            this.current_number.Size = new System.Drawing.Size(0, 15);
            this.current_number.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "當前分數";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(547, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "當前數字";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "倒數計時";
            this.label3.Visible = false;
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.Location = new System.Drawing.Point(636, 165);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(14, 15);
            this.clock.TabIndex = 8;
            this.clock.Text = "3";
            this.clock.Visible = false;
            // 
            // general_mode
            // 
            this.general_mode.Location = new System.Drawing.Point(221, 257);
            this.general_mode.Name = "general_mode";
            this.general_mode.Size = new System.Drawing.Size(198, 134);
            this.general_mode.TabIndex = 9;
            this.general_mode.Text = "普通模式";
            this.general_mode.UseVisualStyleBackColor = true;
            this.general_mode.Click += new System.EventHandler(this.general_mode_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.general_mode);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.current_number);
            this.Controls.Add(this.score);
            this.Controls.Add(this.simple_mode);
            this.KeyPreview = true;
            this.Name = "Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button simple_mode;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label current_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Button general_mode;
    }
}

