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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loop_check = new System.Windows.Forms.CheckBox();
            this.play_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.select_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(40, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 311);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Playlist";
            // 
            // loop_check
            // 
            this.loop_check.AutoSize = true;
            this.loop_check.Location = new System.Drawing.Point(103, 329);
            this.loop_check.Name = "loop_check";
            this.loop_check.Size = new System.Drawing.Size(59, 19);
            this.loop_check.TabIndex = 1;
            this.loop_check.Text = "Loop";
            this.loop_check.UseVisualStyleBackColor = true;
            this.loop_check.CheckedChanged += new System.EventHandler(this.loop_check_CheckedChanged);
            // 
            // play_button
            // 
            this.play_button.Location = new System.Drawing.Point(102, 383);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(132, 58);
            this.play_button.TabIndex = 2;
            this.play_button.Text = "Play";
            this.play_button.UseVisualStyleBackColor = true;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(287, 383);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(132, 58);
            this.stop_button.TabIndex = 3;
            this.stop_button.Text = "Stop";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // select_button
            // 
            this.select_button.Location = new System.Drawing.Point(466, 383);
            this.select_button.Name = "select_button";
            this.select_button.Size = new System.Drawing.Size(132, 58);
            this.select_button.TabIndex = 4;
            this.select_button.Text = "Select Files";
            this.select_button.UseVisualStyleBackColor = true;
            this.select_button.Click += new System.EventHandler(this.select_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.select_button);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.play_button);
            this.Controls.Add(this.loop_check);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox loop_check;
        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Button select_button;
    }
}

