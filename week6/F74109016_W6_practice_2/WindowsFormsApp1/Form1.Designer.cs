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
            this.Text_change = new System.Windows.Forms.Label();
            this.first_style = new System.Windows.Forms.RadioButton();
            this.second_style = new System.Windows.Forms.RadioButton();
            this.third_style = new System.Windows.Forms.RadioButton();
            this.topleft = new System.Windows.Forms.RadioButton();
            this.topcenter = new System.Windows.Forms.RadioButton();
            this.topright = new System.Windows.Forms.RadioButton();
            this.buttonleft = new System.Windows.Forms.RadioButton();
            this.buttoncenter = new System.Windows.Forms.RadioButton();
            this.buttonright = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.input_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Boldbutton = new System.Windows.Forms.CheckBox();
            this.ItalicButton = new System.Windows.Forms.CheckBox();
            this.textsize = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Text_change
            // 
            this.Text_change.Location = new System.Drawing.Point(38, 43);
            this.Text_change.Name = "Text_change";
            this.Text_change.Size = new System.Drawing.Size(339, 355);
            this.Text_change.TabIndex = 0;
            this.Text_change.Text = "label1";
            // 
            // first_style
            // 
            this.first_style.AutoSize = true;
            this.first_style.Checked = true;
            this.first_style.Location = new System.Drawing.Point(51, 27);
            this.first_style.Name = "first_style";
            this.first_style.Size = new System.Drawing.Size(59, 16);
            this.first_style.TabIndex = 1;
            this.first_style.TabStop = true;
            this.first_style.Text = "標楷體";
            this.first_style.UseVisualStyleBackColor = true;
            this.first_style.CheckedChanged += new System.EventHandler(this.first_style_CheckedChanged);
            // 
            // second_style
            // 
            this.second_style.AutoSize = true;
            this.second_style.Location = new System.Drawing.Point(162, 27);
            this.second_style.Name = "second_style";
            this.second_style.Size = new System.Drawing.Size(71, 16);
            this.second_style.TabIndex = 2;
            this.second_style.TabStop = true;
            this.second_style.Text = "新細明體";
            this.second_style.UseVisualStyleBackColor = true;
            this.second_style.CheckedChanged += new System.EventHandler(this.second_style_CheckedChanged);
            // 
            // third_style
            // 
            this.third_style.AutoSize = true;
            this.third_style.Location = new System.Drawing.Point(51, 67);
            this.third_style.Name = "third_style";
            this.third_style.Size = new System.Drawing.Size(83, 16);
            this.third_style.TabIndex = 3;
            this.third_style.TabStop = true;
            this.third_style.Text = "微軟正黑體";
            this.third_style.UseVisualStyleBackColor = true;
            this.third_style.CheckedChanged += new System.EventHandler(this.third_style_CheckedChanged);
            // 
            // topleft
            // 
            this.topleft.AutoSize = true;
            this.topleft.Checked = true;
            this.topleft.Location = new System.Drawing.Point(6, 46);
            this.topleft.Name = "topleft";
            this.topleft.Size = new System.Drawing.Size(47, 16);
            this.topleft.TabIndex = 4;
            this.topleft.TabStop = true;
            this.topleft.Text = "上左";
            this.topleft.UseVisualStyleBackColor = true;
            this.topleft.CheckedChanged += new System.EventHandler(this.topleft_CheckedChanged);
            // 
            // topcenter
            // 
            this.topcenter.AutoSize = true;
            this.topcenter.Location = new System.Drawing.Point(110, 46);
            this.topcenter.Name = "topcenter";
            this.topcenter.Size = new System.Drawing.Size(47, 16);
            this.topcenter.TabIndex = 5;
            this.topcenter.TabStop = true;
            this.topcenter.Text = "上中";
            this.topcenter.UseVisualStyleBackColor = true;
            this.topcenter.CheckedChanged += new System.EventHandler(this.topcenter_CheckedChanged);
            // 
            // topright
            // 
            this.topright.AutoSize = true;
            this.topright.Location = new System.Drawing.Point(201, 46);
            this.topright.Name = "topright";
            this.topright.Size = new System.Drawing.Size(47, 16);
            this.topright.TabIndex = 6;
            this.topright.TabStop = true;
            this.topright.Text = "上右";
            this.topright.UseVisualStyleBackColor = true;
            this.topright.CheckedChanged += new System.EventHandler(this.topright_CheckedChanged);
            // 
            // buttonleft
            // 
            this.buttonleft.AutoSize = true;
            this.buttonleft.Location = new System.Drawing.Point(6, 86);
            this.buttonleft.Name = "buttonleft";
            this.buttonleft.Size = new System.Drawing.Size(47, 16);
            this.buttonleft.TabIndex = 7;
            this.buttonleft.TabStop = true;
            this.buttonleft.Text = "下左";
            this.buttonleft.UseVisualStyleBackColor = true;
            this.buttonleft.CheckedChanged += new System.EventHandler(this.buttonleft_CheckedChanged);
            // 
            // buttoncenter
            // 
            this.buttoncenter.AutoSize = true;
            this.buttoncenter.Location = new System.Drawing.Point(110, 86);
            this.buttoncenter.Name = "buttoncenter";
            this.buttoncenter.Size = new System.Drawing.Size(47, 16);
            this.buttoncenter.TabIndex = 8;
            this.buttoncenter.TabStop = true;
            this.buttoncenter.Text = "下中";
            this.buttoncenter.UseVisualStyleBackColor = true;
            this.buttoncenter.CheckedChanged += new System.EventHandler(this.buttoncenter_CheckedChanged);
            // 
            // buttonright
            // 
            this.buttonright.AutoSize = true;
            this.buttonright.Location = new System.Drawing.Point(201, 86);
            this.buttonright.Name = "buttonright";
            this.buttonright.Size = new System.Drawing.Size(47, 16);
            this.buttonright.TabIndex = 9;
            this.buttonright.TabStop = true;
            this.buttonright.Text = "下右";
            this.buttonright.UseVisualStyleBackColor = true;
            this.buttonright.CheckedChanged += new System.EventHandler(this.buttonright_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.third_style);
            this.groupBox1.Controls.Add(this.second_style);
            this.groupBox1.Controls.Add(this.first_style);
            this.groupBox1.Location = new System.Drawing.Point(401, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 95);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "字體";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttoncenter);
            this.groupBox2.Controls.Add(this.buttonleft);
            this.groupBox2.Controls.Add(this.buttonright);
            this.groupBox2.Controls.Add(this.topcenter);
            this.groupBox2.Controls.Add(this.topright);
            this.groupBox2.Controls.Add(this.topleft);
            this.groupBox2.Location = new System.Drawing.Point(401, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 123);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "位置";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(58, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "前一張";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 37);
            this.button2.TabIndex = 14;
            this.button2.Text = "下一張";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // input_text
            // 
            this.input_text.Location = new System.Drawing.Point(401, 358);
            this.input_text.Multiline = true;
            this.input_text.Name = "input_text";
            this.input_text.Size = new System.Drawing.Size(295, 59);
            this.input_text.TabIndex = 15;
            this.input_text.Text = "早安";
            this.input_text.TextChanged += new System.EventHandler(this.input_text_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "字體大小";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "文字";
            // 
            // Boldbutton
            // 
            this.Boldbutton.AutoSize = true;
            this.Boldbutton.Location = new System.Drawing.Point(422, 157);
            this.Boldbutton.Name = "Boldbutton";
            this.Boldbutton.Size = new System.Drawing.Size(48, 16);
            this.Boldbutton.TabIndex = 18;
            this.Boldbutton.Text = "粗體";
            this.Boldbutton.UseVisualStyleBackColor = true;
            this.Boldbutton.CheckedChanged += new System.EventHandler(this.Boldbutton_CheckedChanged);
            // 
            // ItalicButton
            // 
            this.ItalicButton.AutoSize = true;
            this.ItalicButton.Location = new System.Drawing.Point(510, 157);
            this.ItalicButton.Name = "ItalicButton";
            this.ItalicButton.Size = new System.Drawing.Size(48, 16);
            this.ItalicButton.TabIndex = 19;
            this.ItalicButton.Text = "斜體";
            this.ItalicButton.UseVisualStyleBackColor = true;
            this.ItalicButton.CheckedChanged += new System.EventHandler(this.ItalicButton_CheckedChanged);
            // 
            // textsize
            // 
            this.textsize.Location = new System.Drawing.Point(466, 314);
            this.textsize.Name = "textsize";
            this.textsize.Size = new System.Drawing.Size(168, 22);
            this.textsize.TabIndex = 20;
            this.textsize.Text = "12";
            this.textsize.TextChanged += new System.EventHandler(this.textsize_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textsize);
            this.Controls.Add(this.ItalicButton);
            this.Controls.Add(this.Boldbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_text);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Text_change);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Text_change;
        private System.Windows.Forms.RadioButton first_style;
        private System.Windows.Forms.RadioButton second_style;
        private System.Windows.Forms.RadioButton third_style;
        private System.Windows.Forms.RadioButton topleft;
        private System.Windows.Forms.RadioButton topcenter;
        private System.Windows.Forms.RadioButton topright;
        private System.Windows.Forms.RadioButton buttonleft;
        private System.Windows.Forms.RadioButton buttoncenter;
        private System.Windows.Forms.RadioButton buttonright;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox input_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Boldbutton;
        private System.Windows.Forms.CheckBox ItalicButton;
        private System.Windows.Forms.TextBox textsize;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}

