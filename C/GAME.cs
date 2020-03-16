using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_7_GAME_DOAN_SO
{
    class GAME
    {
        static void thietLap()
        {
            Random rd = new Random();
            int x = rd.Next(101);
        //    Console.WriteLine(x);
            int soCuaNguoi;
            int soLanDoan = 0;
            Console.WriteLine("Máy đã tạo ra 1 số ngẫu nhiên [0...100],mới bạn đoán: ");
            while(true)
            {
              soCuaNguoi = int.Parse(Console.ReadLine());
              soLanDoan++;
              Console.WriteLine("BẠN ĐOÁN LẦN THỨ {0}",soLanDoan);
              if (soCuaNguoi == x)
              {
                  Console.WriteLine("BẠN ĐÃ CHIẾN THẮNG, SỐ CỦA MÁY {0}",x);
                  break;
              }
              else if (soCuaNguoi < x)
              {
                  Console.WriteLine("Số của bạn đoán nhỏ hơn số của máy!!!!!");
              }
              else
              {
                  Console.WriteLine("Số của bạn đoán lớn hơn số của máy!!!!!");
              }
              if(soLanDoan==7)
              {
                  Console.WriteLine("GAME OVER!!!!. BẠN ĐÃ ĐOÁN QUÁ 7 LẦN");
                  Console.WriteLine("SỐ CỦA MÁY LÀ {0}", x);
                  break;
              }

            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while(true)
            {
                thietLap();
                Console.WriteLine("Bạn có muốn chơi tiếp không?(y/n)");
                String s = Console.ReadLine();
                if (s == "n")
                    break;
            }
            
            Console.ReadLine();
        }
    }
}
