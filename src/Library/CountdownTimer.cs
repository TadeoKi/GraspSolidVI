using System;
using System.Threading;

namespace Full_GRASP_And_SOLID
{
    public interface TimerClient
    {
        void TimeOut();
    }

    public class CountdownTimer
    {
        private TimerClient client;

        private Timer timer;

        public void Register(int timeOut, TimerClient client)
        {
            this.client = client;
            this.timer = new Timer(this.OnTimedEvent, null, timeOut, Timeout.Infinite);
        }

        private void OnTimedEvent(object state)
        {
            this.client.TimeOut();
            this.timer.Change(Timeout.Infinite, Timeout.Infinite);
        }
    }
}