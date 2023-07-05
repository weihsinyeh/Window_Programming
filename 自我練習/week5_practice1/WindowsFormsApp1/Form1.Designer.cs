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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.legal_label = new System.Windows.Forms.Label();
            this.random_create = new System.Windows.Forms.Button();
            this.sure = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15F);
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "替換表";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "ABCDEFGHIJKLMNOPQRSTUCWXYZabcdefghijklmnopqrstuvwxyz";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 224);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(485, 25);
            this.textBox1.TabIndex = 2;
            // 
            // legal_label
            // 
            this.legal_label.AutoSize = true;
            this.legal_label.Font = new System.Drawing.Font("新細明體", 15F);
            this.legal_label.Location = new System.Drawing.Point(50, 289);
            this.legal_label.Name = "legal_label";
            this.legal_label.Size = new System.Drawing.Size(87, 25);
            this.legal_label.TabIndex = 3;
            this.legal_label.Text = "替換表";
            // 
            // random_create
            // 
            this.random_create.AutoSize = true;
            this.random_create.Location = new System.Drawing.Point(503, 255);
            this.random_create.Name = "random_create";
            this.random_create.Size = new System.Drawing.Size(93, 44);
            this.random_create.TabIndex = 4;
            this.random_create.Text = "隨機生成";
            this.random_create.UseVisualStyleBackColor = true;
            this.random_create.Click += new System.EventHandler(this.random_create_Click);
            // 
            // sure
            // 
            this.sure.AutoSize = true;
            this.sure.Location = new System.Drawing.Point(503, 325);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(93, 44);
            this.sure.TabIndex = 5;
            this.sure.Text = "確認";
            this.sure.UseVisualStyleBackColor = true;
            this.sure.Click += new System.EventHandler(this.sure_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(650, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "替換表";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(650, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 44);
            this.button2.TabIndex = 7;
            this.button2.Text = "加密";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(650, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 44);
            this.button3.TabIndex = 8;
            this.button3.Text = "解密";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(650, 255);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 44);
            this.button4.TabIndex = 9;
            this.button4.Text = "歷史紀錄";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sure);
            this.Controls.Add(this.random_create);
            this.Controls.Add(this.legal_label);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label legal_label;
        private System.Windows.Forms.Button random_create;
        private System.Windows.Forms.Button sure;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

