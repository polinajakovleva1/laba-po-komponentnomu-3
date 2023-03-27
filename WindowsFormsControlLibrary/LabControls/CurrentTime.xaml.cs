using System;
using System.Timers;
using System.Windows.Controls;
using System.Windows.Threading;

namespace LabControls
{
    /// <summary>
    /// Логика взаимодействия для CurrentTime.xaml
    /// </summary>
    public partial class CurrentTime : UserControl
    {
        private DispatcherTimer timer = new DispatcherTimer();

        public CurrentTime()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(dispatcherTimer_Tick);
            //значение Interval задается равным 1 секунде с помощью TimeSpan объекта и запускается таймер
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            var time = DateTime.Now;

            //положение секундной стрелки
            //угол секундной стрелки от кол-ва полных секунд
            RotateSecond.Angle = 6 * (time.Second);

            //положение минутной стрелки
            //угол минутной стрелки от кол-ва полных минут + угол секунд, приведенный к долям текущей минуты
            RotateMinute.Angle = 6 * time.Minute + RotateSecond.Angle / 60;

            //положение часовой стрелки
            //данные часа конвертируем в 12-ти часовой вид, вычисляем угол полных часов + угол минут, приведенный к долям текущего часа
            RotateHour.Angle = 30 * (time.Hour % 12) + RotateMinute.Angle / 12;
        }
    }
}
