namespace WindowsFormsApp1
{
    partial class form
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
            this.simple_mode = new System.Windows.Forms.Button();
            this.general_mode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.current_num = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // simple_mode
            // 
            this.simple_mode.Location = new System.Drawing.Point(290, 133);
            this.simple_mode.Name = "simple_mode";
            this.simple_mode.Size = new System.Drawing.Size(128, 60);
            this.simple_mode.TabIndex = 0;
            this.simple_mode.Text = "簡單模式";
            this.simple_mode.UseVisualStyleBackColor = true;
            this.simple_mode.Click += new System.EventHandler(this.simple_mode_Click);
            // 
            // general_mode
            // 
            this.general_mode.Location = new System.Drawing.Point(290, 256);
            this.general_mode.Name = "general_mode";
            this.general_mode.Size = new System.Drawing.Size(128, 60);
            this.general_mode.TabIndex = 1;
            this.general_mode.Text = "普通模式";
            this.general_mode.UseVisualStyleBackColor = true;
            this.general_mode.Click += new System.EventHandler(this.general_mode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(626, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "你的分數:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(626, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "當前數字:";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(703, 54);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(14, 15);
            this.score.TabIndex = 4;
            this.score.Text = "0";
            // 
            // current_num
            // 
            this.current_num.AutoSize = true;
            this.current_num.Location = new System.Drawing.Point(703, 124);
            this.current_num.Name = "current_num";
            this.current_num.Size = new System.Drawing.Size(14, 15);
            this.current_num.TabIndex = 5;
            this.current_num.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 127);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.current_num);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.general_mode);
            this.Controls.Add(this.simple_mode);
            this.Name = "form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button simple_mode;
        private System.Windows.Forms.Button general_mode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label current_num;
        private System.Windows.Forms.Button button1;
    }
}

