/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyProgram
{
    class Timmer
    {
        private static Timer timer; // Thêm một biến để giữ tham chiếu đến Timer

        public static void PrintTime(object state)
        {
            Console.WriteLine("Time is " + DateTime.Now.ToShortTimeString() + " Message: " + state);
        }

        static void Main(string[] args)
        {
            TimerCallback timerCallback = new TimerCallback(PrintTime);

            // Lưu tham chiếu đến đối tượng Timer trong biến timer
            timer = new Timer(
                timerCallback,
                "Hi",
                100,
                2000);

            // Để chương trình không kết thúc ngay lập tức
            // Bạn có thể sử dụng một lời gọi Thread.Sleep() hoặc Console.ReadLine() để chờ
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
*/