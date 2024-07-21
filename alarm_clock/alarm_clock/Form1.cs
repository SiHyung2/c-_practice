using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alarm_clock
{
    public partial class Form1 : Form
    {
        bool flag = false;
        int time = 600;		// 기본설정값
        int set_time = 600;	// 사용자설정값 

        private int alarmHour;
        private int alarmMinute;
        private int alarmSecond;
        private bool isAlarmSet = false;


        // 생성자에서 타이머로 이벤트 발생 시킴
        public Form1()
        {
            InitializeComponent();
            timer2.Interval = 1000; // 1초마다 타이머 이벤트 발생
            timer2.Tick += timer2_Tick;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time_textbox2.Text = DateTime.Now.ToString("HH:mm:ss");

            if (isAlarmSet)
            {
                DateTime currentTime = DateTime.Now;
                // 현재 시간과 알람 시간 비교
                if (currentTime.Hour == alarmHour && currentTime.Minute == alarmMinute && currentTime.Second == alarmSecond)
                {
                    isAlarmSet = false; // 알람 재설정을 방지하기 위해 알람 설정 해제
                    MessageBox.Show("알람 시간입니다!");
                }
            }
        }

        private void start2_Click(object sender, EventArgs e)
        {
            try
            {
                // 시간, 분, 초 텍스트박스에서 값을 가져옴
                // 근데 타이머랑 안 헷갈리도록 뒤에 2를 붙였음
                alarmHour = int.Parse(hour_textbox2.Text);
                alarmMinute = int.Parse(minute_textbox2.Text);
                alarmSecond = int.Parse(sec_textbox2.Text);

                // 알람 시간이 유효한지 확인 (0 이상이어야 함)
                if (alarmHour >= 0 && alarmMinute >= 0 && alarmSecond >= 0 &&
                    alarmHour < 24 && alarmMinute < 60 && alarmSecond < 60)
                {
                    isAlarmSet = true;
                    alarm_label2.Text = $"알람이 설정되었습니다: {alarmHour:D2}:{alarmMinute:D2}:{alarmSecond:D2}";
                }
                else
                {
                    MessageBox.Show("시간, 분, 초는 유효한 값을 입력해주세요.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류가 발생했습니다: {ex.Message}");
            }
        }










        private void start_stop_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                timer1.Start();     // 타이머 시작
                flag = true;
                start_stop.Text = "Stop";
            }
            else
            {
                timer1.Stop();      // 타이머 멈춤
                flag = false;
                start_stop.Text = "Start";
            }
        }



        private void set_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0, k = 0;
            try
            {
                if (!int.TryParse(hour_textbox.Text, out i) ||
                    !int.TryParse(minute_textbox.Text, out j) ||
                    !int.TryParse(sec_textbox.Text, out k))
                {
                    MessageBox.Show("숫자만 입력해 주세요", "Warning !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    if (Convert.ToInt32(hour_textbox.Text) < 0 ||
                        Convert.ToInt32(minute_textbox.Text) < 0 ||
                        Convert.ToInt32(sec_textbox.Text) < 0)
                    {
                       MessageBox.Show("음수는 입력하지 말아주세요", "Warning !", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        set_time = Convert.ToInt32(hour_textbox.Text) * 3600 + Convert.ToInt32(minute_textbox.Text) * 60 + Convert.ToInt32(sec_textbox.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("\n예기치않은 오류입니다\n다시시도해주세요" + ex.ToString(), "Exception Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
        

        private void reset_Click(object sender, EventArgs e)
        {
            set_time = 0;
            set_time += int.Parse(hour_textbox.Text)*3600;
            set_time += int.Parse(minute_textbox.Text) * 600;
            set_time += int.Parse(sec_textbox.Text);
            time_textabox.Text = set_time.ToString();

            time = set_time;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hour_textbox.Text = (time / 3600).ToString();
            minute_textbox.Text = ((time % 3600) / 60).ToString();
            sec_textbox.Text = (time % 60).ToString();
            if (time == 0)
            {
                timer1.Stop();
                start_stop.Text = "Start";
                flag = false;
                time = set_time;    // 사용자가 설정한시간으로 시간 초기화, 미설정시 기존값 복원
            }
            time--;
        }

        
    }
}
