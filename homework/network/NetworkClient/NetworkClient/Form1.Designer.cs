namespace NetworkClient
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labeldebug = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "접속";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 14);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 194);
            this.textBox1.TabIndex = 1;
            // 
            // labeldebug
            // 
            this.labeldebug.AutoSize = true;
            this.labeldebug.Location = new System.Drawing.Point(462, 238);
            this.labeldebug.Name = "labeldebug";
            this.labeldebug.Size = new System.Drawing.Size(41, 12);
            this.labeldebug.TabIndex = 2;
            this.labeldebug.Text = "디버깅";
            this.labeldebug.Click += new System.EventHandler(this.labeldebug_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "ip";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(307, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 21);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "port";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(307, 55);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 229);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(255, 21);
            this.textBox3.TabIndex = 8;
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(433, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 258);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labeldebug);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labeldebug;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
    }
}

