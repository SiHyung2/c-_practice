namespace alarm_clock
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
            this.components = new System.ComponentModel.Container();
            this.hour_textbox = new System.Windows.Forms.TextBox();
            this.minute_textbox = new System.Windows.Forms.TextBox();
            this.sec_textbox = new System.Windows.Forms.TextBox();
            this.start_stop = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.set = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time_textabox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sec_textbox2 = new System.Windows.Forms.TextBox();
            this.minute_textbox2 = new System.Windows.Forms.TextBox();
            this.hour_textbox2 = new System.Windows.Forms.TextBox();
            this.start2 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.alarm_label2 = new System.Windows.Forms.Label();
            this.time_textbox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hour_textbox
            // 
            this.hour_textbox.Location = new System.Drawing.Point(102, 263);
            this.hour_textbox.Name = "hour_textbox";
            this.hour_textbox.Size = new System.Drawing.Size(100, 21);
            this.hour_textbox.TabIndex = 0;
            // 
            // minute_textbox
            // 
            this.minute_textbox.Location = new System.Drawing.Point(329, 263);
            this.minute_textbox.Name = "minute_textbox";
            this.minute_textbox.Size = new System.Drawing.Size(100, 21);
            this.minute_textbox.TabIndex = 1;
            // 
            // sec_textbox
            // 
            this.sec_textbox.Location = new System.Drawing.Point(571, 263);
            this.sec_textbox.Name = "sec_textbox";
            this.sec_textbox.Size = new System.Drawing.Size(100, 21);
            this.sec_textbox.TabIndex = 2;
            // 
            // start_stop
            // 
            this.start_stop.Location = new System.Drawing.Point(111, 309);
            this.start_stop.Name = "start_stop";
            this.start_stop.Size = new System.Drawing.Size(75, 23);
            this.start_stop.TabIndex = 3;
            this.start_stop.Text = "start";
            this.start_stop.UseVisualStyleBackColor = true;
            this.start_stop.Click += new System.EventHandler(this.start_stop_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(320, 302);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(109, 36);
            this.reset.TabIndex = 4;
            this.reset.Text = "시간 입력후 누르시오(reset)";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // set
            // 
            this.set.Location = new System.Drawing.Point(562, 296);
            this.set.Name = "set";
            this.set.Size = new System.Drawing.Size(109, 42);
            this.set.TabIndex = 5;
            this.set.Text = "이버튼은 잘 안됨(set)";
            this.set.UseVisualStyleBackColor = true;
            this.set.Click += new System.EventHandler(this.set_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time_textabox
            // 
            this.time_textabox.Location = new System.Drawing.Point(268, 351);
            this.time_textabox.Name = "time_textabox";
            this.time_textabox.Size = new System.Drawing.Size(240, 21);
            this.time_textabox.TabIndex = 6;
            this.time_textabox.Text = "[디버깅] 입력된 시간(초 단위)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "타이머";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "자명종";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "시";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "분";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(677, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "초";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(677, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "초";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "분";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "시";
            // 
            // sec_textbox2
            // 
            this.sec_textbox2.Location = new System.Drawing.Point(571, 28);
            this.sec_textbox2.Name = "sec_textbox2";
            this.sec_textbox2.Size = new System.Drawing.Size(100, 21);
            this.sec_textbox2.TabIndex = 14;
            // 
            // minute_textbox2
            // 
            this.minute_textbox2.Location = new System.Drawing.Point(329, 28);
            this.minute_textbox2.Name = "minute_textbox2";
            this.minute_textbox2.Size = new System.Drawing.Size(100, 21);
            this.minute_textbox2.TabIndex = 13;
            // 
            // hour_textbox2
            // 
            this.hour_textbox2.Location = new System.Drawing.Point(102, 28);
            this.hour_textbox2.Name = "hour_textbox2";
            this.hour_textbox2.Size = new System.Drawing.Size(100, 21);
            this.hour_textbox2.TabIndex = 12;
            // 
            // start2
            // 
            this.start2.Location = new System.Drawing.Point(585, 71);
            this.start2.Name = "start2";
            this.start2.Size = new System.Drawing.Size(75, 23);
            this.start2.TabIndex = 18;
            this.start2.Text = "start2";
            this.start2.UseVisualStyleBackColor = true;
            this.start2.Click += new System.EventHandler(this.start2_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // alarm_label2
            // 
            this.alarm_label2.AutoSize = true;
            this.alarm_label2.Location = new System.Drawing.Point(361, 82);
            this.alarm_label2.Name = "alarm_label2";
            this.alarm_label2.Size = new System.Drawing.Size(29, 12);
            this.alarm_label2.TabIndex = 19;
            this.alarm_label2.Text = "알람";
            // 
            // time_textbox2
            // 
            this.time_textbox2.Location = new System.Drawing.Point(278, 107);
            this.time_textbox2.Name = "time_textbox2";
            this.time_textbox2.Size = new System.Drawing.Size(240, 21);
            this.time_textbox2.TabIndex = 20;
            this.time_textbox2.Text = "[디버깅] 현재 시간";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(150, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "[디버깅] 현재 시간";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 383);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.time_textbox2);
            this.Controls.Add(this.alarm_label2);
            this.Controls.Add(this.start2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sec_textbox2);
            this.Controls.Add(this.minute_textbox2);
            this.Controls.Add(this.hour_textbox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time_textabox);
            this.Controls.Add(this.set);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.start_stop);
            this.Controls.Add(this.sec_textbox);
            this.Controls.Add(this.minute_textbox);
            this.Controls.Add(this.hour_textbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hour_textbox;
        private System.Windows.Forms.TextBox minute_textbox;
        private System.Windows.Forms.TextBox sec_textbox;
        private System.Windows.Forms.Button start_stop;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button set;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox time_textabox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox sec_textbox2;
        private System.Windows.Forms.TextBox minute_textbox2;
        private System.Windows.Forms.TextBox hour_textbox2;
        private System.Windows.Forms.Button start2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label alarm_label2;
        private System.Windows.Forms.TextBox time_textbox2;
        private System.Windows.Forms.Label label9;
    }
}

