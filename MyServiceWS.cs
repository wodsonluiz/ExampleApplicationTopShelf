using System;
using System.Timers;

namespace ApplicationExampleTopShelf
{
    public class MyServiceWS
    {
        const string description = "My Service initiated";
        public void Start()
        {
            
            var timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Elapsed += new ElapsedEventHandler(timer1_Tick);
            timer1.Enabled = true;

            Console.WriteLine($"My Service initiated ");
        }
        public void Stop()
        {
            Console.WriteLine("My Service stop!");
        }

        private void timer1_Tick(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine($"{description} hora: {DateTime.Now.ToString("s")}");
        }

    }
}
