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
            this.property1 = new System.Windows.Forms.RadioButton();
            this.property2 = new System.Windows.Forms.RadioButton();
            this.property3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.player = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.score_display = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.property_show = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // property1
            // 
            this.property1.AutoSize = true;
            this.property1.Checked = true;
            this.property1.Location = new System.Drawing.Point(8, 28);
            this.property1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.property1.Name = "property1";
            this.property1.Size = new System.Drawing.Size(35, 16);
            this.property1.TabIndex = 1;
            this.property1.TabStop = true;
            this.property1.Text = "水";
            this.property1.UseVisualStyleBackColor = true;
            this.property1.CheckedChanged += new System.EventHandler(this.property1_CheckedChanged);
            // 
            // property2
            // 
            this.property2.AutoSize = true;
            this.property2.Location = new System.Drawing.Point(8, 55);
            this.property2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.property2.Name = "property2";
            this.property2.Size = new System.Drawing.Size(35, 16);
            this.property2.TabIndex = 2;
            this.property2.Text = "火";
            this.property2.UseVisualStyleBackColor = true;
            this.property2.CheckedChanged += new System.EventHandler(this.property2_CheckedChanged);
            // 
            // property3
            // 
            this.property3.AutoSize = true;
            this.property3.Location = new System.Drawing.Point(8, 84);
            this.property3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.property3.Name = "property3";
            this.property3.Size = new System.Drawing.Size(35, 16);
            this.property3.TabIndex = 3;
            this.property3.Text = "土";
            this.property3.UseVisualStyleBackColor = true;
            this.property3.CheckedChanged += new System.EventHandler(this.property3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.property3);
            this.groupBox1.Controls.Add(this.property2);
            this.groupBox1.Controls.Add(this.property1);
            this.groupBox1.Location = new System.Drawing.Point(243, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(98, 158);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "選擇初始屬性";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 114);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "開始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // player
            // 
            this.player.Location = new System.Drawing.Point(154, 400);
            this.player.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(40, 40);
            this.player.TabIndex = 5;
            this.player.UseVisualStyleBackColor = true;
            this.player.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "剩餘時間:";
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.Location = new System.Drawing.Point(497, 111);
            this.clock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(17, 12);
            this.clock.TabIndex = 7;
            this.clock.Text = "60";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "目前分數:";
            // 
            // score_display
            // 
            this.score_display.AutoSize = true;
            this.score_display.Location = new System.Drawing.Point(497, 82);
            this.score_display.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.score_display.Name = "score_display";
            this.score_display.Size = new System.Drawing.Size(11, 12);
            this.score_display.TabIndex = 9;
            this.score_display.Text = "0";
            this.score_display.TextChanged += new System.EventHandler(this.score_display_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "目前屬性:";
            // 
            // property_show
            // 
            this.property_show.AutoSize = true;
            this.property_show.Location = new System.Drawing.Point(497, 50);
            this.property_show.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.property_show.Name = "property_show";
            this.property_show.Size = new System.Drawing.Size(17, 12);
            this.property_show.TabIndex = 11;
            this.property_show.Text = "水";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 466);
            this.Controls.Add(this.property_show);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.score_display);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton property1;
        private System.Windows.Forms.RadioButton property2;
        private System.Windows.Forms.RadioButton property3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label score_display;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label property_show;
    }
}

