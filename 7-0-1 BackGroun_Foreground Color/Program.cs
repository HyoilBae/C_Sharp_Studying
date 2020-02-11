using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Media;


namespace _7_0_1_BackGroun_Foreground_Color
{
    enum CookerProcess { None, Riceing, Watering, Washing, Droping, Cooking, Completion, Keeping };
    struct RiceCookerInfo
    {
        public bool CoverOpenClose; // 뚜껑 열기 닫기
        public bool Power;
        public CookerProcess State;
        public int Rice;   // 쌀의 양 g 기준, 출력 때 환산
        public int Water;  // 물의 양 미리 리터 기준, 출력때 환산
        public int Number; // 인원수

        public RiceCookerInfo(int _Rice, int _Water)
        {
            Rice = _Rice;
            Water = _Water;
            State = CookerProcess.None;
            CoverOpenClose = false;
            Power = false;
            Number = 0;
        }
    }


    class Program
    {
        public static int MainMenuIndex = 0;

        //밥솥 출력 메서드
        static void RiceCookerBox(int x, int y)
        {
            int height = 20;
            Console.SetCursorPosition(x, y);
                Console.Write("┌────────────────────────┐");
            for (int i = 1; i < height; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write("|                        |");
            }

            Console.SetCursorPosition(x, y + height);
                Console.Write("└────────────────────────┘");
        }

        //쌀통과 물통 출력 메서드
        static void RiceOrWaterBox(int x, int y)
        {
            int height = 20;
            Console.SetCursorPosition(x, y);
            Console.Write("┌────────────────────────┐");
            for (int i = 1; i < height; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write("|                        |");
            }

            Console.SetCursorPosition(x, y + height);
            Console.Write("└────────────────────────┘");
        }

        //쌀 출력 메서드
        static void RiceHeight(int x, int y, int Amount)
        {
            int Height = Amount / 1000;

            //지우는 부분
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < 18; i++)
            {
                Console.SetCursorPosition(x, 2 + i);
                Console.Write("                    ");
            }
            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(x, 19 - i);
                Console.Write("Θ Θ Θ Θ Θ Θ Θ");
            }
        }

        //물 출력 메서드
        static void WaterHeight(int x, int y, int Amount)
        {
            int Height = Amount / 1000;

            //지우는 부분
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < 18; i++)
            {
                Console.SetCursorPosition(x, 2 + i);
                Console.Write("                    ");
            }

            Console.BackgroundColor = ConsoleColor.Blue;
            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(x, 19 - i);
                Console.Write("                    ");
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }

        //밥솥 상태 정보 박스와 메뉴 박스 출력 메서드
        static void InfoOrMenuBox(int x, int y)
        {
            int height = 13;
            Console.SetCursorPosition(x, y);
            Console.Write("┌────────────────────────┐");
            for (int i = 1; i < height; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write("|                        |");
            }

            Console.SetCursorPosition(x, y + height);
            Console.Write("└────────────────────────┘");
        }

        //뚜껑 열기 닫기 출력 메서드
        static void Cover(bool bOpen)
        {
            const int x = 16;
            if (bOpen)
            {
                Console.SetCursorPosition(x, 2);
                Console.Write("┌─┐");
                for (int i = 0; i < 7; i++)
                {
                    Console.SetCursorPosition(x, 3 + i);
                    Console.Write("| |");
                }
                Console.SetCursorPosition(x, 10);
                Console.Write("└─┘");
            }
            else
            {
                Console.SetCursorPosition(x, 9);
                Console.Write("┌────────────────────────┐");
                Console.SetCursorPosition(x, 10);
                Console.Write("└────────────────────────┘");
            }
        }

        //밥솥 출력 메서드
        static void RiceBox(int x, int y)
        {
            int height = 7;
            Console.SetCursorPosition(x, y);
            Console.Write("┌────────────────────────┐");
            for (int i = 1; i < height; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write("|                        |");
            }

            Console.SetCursorPosition(x, y + height);
            Console.Write("└────────────────────────┘");
            Console.SetCursorPosition(x + 10, y + 2);
            Console.Write("RiceBox");
            Console.SetCursorPosition(x, y + 6);
            Console.Write("┤");//전원 부분

        }

        static void RiceInfo(RiceCookerInfo Info)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(3, 25);
            if (Info.Power)
                Console.Write("Power Status : On");
            else
                Console.Write("Power Status : Off");

            Console.SetCursorPosition(3, 26);
            if (Info.CoverOpenClose)
                Console.Write("Lid is Open");
            else
                Console.Write("Lie is closed");

            Console.SetCursorPosition(3, 27);
            switch (Info.State)
            {
                case CookerProcess.None:
                    Console.Write("Rice Cooker Status : Standby");
                    break;
                case CookerProcess.Riceing:
                    Console.Write("Rice Cooker Status : Rice is putting");
                    break;
                case CookerProcess.Watering:
                    Console.Write("Rice Cooker Status : Water is putting on");
                    break;
                case CookerProcess.Washing:
                    Console.Write("Rice Cooker Status : Rice is being washed");
                    break;
                case CookerProcess.Droping:
                    Console.Write("Rice Cooker Status : Water is being off");
                    break;
                case CookerProcess.Cooking:
                    Console.Write("Rice Cooker Status : Rice is being cooked");
                    break;
                case CookerProcess.Completion:
                    Console.Write("Rice Cooker Status : Rice Completed");
                    break;
                case CookerProcess.Keeping:
                    Console.Write("Rice Cooker Status : Rice is kept warming");
                    break;
            }

            Console.SetCursorPosition(3, 28);
            Console.Write("Quantity : {0}", Info.Number);
            Console.SetCursorPosition(3, 29);
            Console.Write("Rice Status : {0:f1} Kg", Info.Rice / 1000.0f);
            Console.SetCursorPosition(3, 30);
            Console.Write("Water Status : {0:f1} Litre", Info.Water / 1000.0f);
        }

        static void MessageBox(int x, int y, string Message)
        {
            int height = 3;
            Console.SetCursorPosition(x, y);
            Console.Write("┌────────────────────────┐");
            for (int i = 1; i < height; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write("|                        |");
            }

            Console.SetCursorPosition(x, y + height);
            Console.Write("└────────────────────────┘");
            Console.SetCursorPosition(x + 10, y + 2);
            Console.Write("RiceBox");
            Console.SetCursorPosition(x + 2, y + 1);
            Console.Write(Message);
        }

        static void OutFrame()
        {
            RiceCookerBox(0, 0);
            RiceOrWaterBox(48, 0);
            RiceOrWaterBox(72, 0);
            InfoOrMenuBox(0, 21);
            InfoOrMenuBox(48, 21);
            Console.SetCursorPosition(17, 1);
            Console.Write("Smart Rice Cooker");
            Console.SetCursorPosition(58, 1);
            Console.Write("Rice Box");
            Console.SetCursorPosition(82, 1);
            Console.Write("Water Box");
            Console.SetCursorPosition(18, 23);
            Console.Write("Rice Cooker Info");
            Console.SetCursorPosition(66, 23);
            Console.Write("((Menu))");
          
        }

        static void Menu(int x, int y, string[] MenuItem)
        {
            ConsoleKeyInfo InputKey;

            while (true)
            {
                for (int i = 0; i < MenuItem.Length; i++)
                {
                    if (MainMenuIndex == i)
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(x, y + i);
                        Console.Write(MenuItem[i]);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.SetCursorPosition(x, y + i);
                        Console.Write(MenuItem[i]);
                    }
                }

                InputKey = Console.ReadKey(true);
                if (InputKey.Key == ConsoleKey.Enter)
                    break;
                else if (InputKey.Key == ConsoleKey.UpArrow)
                {
                    MainMenuIndex--;
                    if (MainMenuIndex < 0)
                        MainMenuIndex = 0;
                }
                else if (InputKey.Key == ConsoleKey.DownArrow)
                {
                    MainMenuIndex++;
                    if (MainMenuIndex == MenuItem.Length)
                        MainMenuIndex = MenuItem.Length - 1;
                }

            }
        }

        static void PowerLine(bool Power)
        {
            if (Power)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(4, 17);
                Console.Write("──────");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(4, 17);
                Console.Write("──────");
            }
        }


        static void Main(string[] args)
        {
            Console.SetWindowSize(99, 36);
            RiceCookerInfo RCInfo = new RiceCookerInfo(10000, 5000);
            SoundPlayer Sound = new SoundPlayer();

            string[] MenuItem = {"  power  ", "  Lid  ", "  Cooking  ", "  Warming  ", "  Cancel  ", "  Quatity  ",
                                    "  Rice  ", "  Water  "  };

            while (true)
            {
                OutFrame();
                RiceBox(16, 11);
                Cover(RCInfo.CoverOpenClose);
                RiceInfo(RCInfo);
                PowerLine(RCInfo.Power);
                RiceHeight(50, 2, RCInfo.Rice);
                WaterHeight(72, 2, RCInfo.Water);

                Menu(65, 25, MenuItem);
                if (MainMenuIndex == 9)
                    break;

                switch (MainMenuIndex)
                {
                    case 0: //power
                        RCInfo.Power = !RCInfo.Power;
                        if (RCInfo.Power)
                        {
                            Sound.SoundLocation = "Power_on.wav";
                        }
                        else
                        {
                            Sound.SoundLocation = "power_off.wav";
                        }
                        Sound.Load();
                        Sound.Play();
                        break;
                    case 1: //뚜껑, 취사 중에 뚜겅이 열리면 안된다.
                        if (RCInfo.State == CookerProcess.Cooking)
                        {
                            MessageBox(51, 27, "Lid can't be open while cooking");
                            Console.ReadKey(true);
                        }
                        else
                        {
                            RCInfo.CoverOpenClose = !RCInfo.CoverOpenClose;
                            if (RCInfo.CoverOpenClose)
                                Sound.SoundLocation = "cover_open.wav";
                            else
                                Sound.SoundLocation = "cover_close.wav";
                            Sound.Load();
                            Sound.Play();
                        }
                        break;
                    case 2: //취사
                        if (!RCInfo.Power)
                        {
                            MessageBox(51, 27, "Power is Off");
                            Console.ReadKey(true);
                            break;
                        }
                        if (RCInfo.CoverOpenClose)
                        {
                            MessageBox(51, 27, "Lid is Open");
                            Console.ReadKey(true);
                            break;
                        }
                        if (RCInfo.Number == 0)
                        {
                            MessageBox(51, 27, "Enter the Quantity");
                            Console.ReadKey(true);
                            break;
                        }

                        int Rice = RCInfo.Rice - (RCInfo.Number * 160);
                        if (Rice < 0)
                        {
                            MessageBox(51, 27, " ???Rice not enough");
                            Sound.SoundLocation = "Put more rice.wav";
                            Sound.Load();
                            Sound.Play();
                            Console.ReadKey(true);
                            break;
                        }

                        int Water;
                        Water = RCInfo.Water - (RCInfo.Number * 170) * 5;
                        if (Water < 0)
                        {
                            MessageBox(51, 27, " ???Water is not enough");
                            Sound.SoundLocation = "Put more water.wav";
                            Sound.Load();
                            Sound.Play();
                            Console.ReadKey(true);
                            break;
                        }

                        RCInfo.State = CookerProcess.Riceing;
                        RiceInfo(RCInfo);

                        Sound.SoundLocation = "Putting Rice.wav";
                        Sound.Load();
                        Sound.Play();

                        Console.SetCursorPosition(24, 12);
                        Console.Write("Adding Rice");
                        Console.SetCursorPosition(18, 13);
                        Console.Write("Θ Θ Θ Θ Θ Θ Θ");
                        Console.SetCursorPosition(18, 14);
                        Console.Write("Θ Θ Θ Θ Θ Θ Θ");
                        Console.SetCursorPosition(18, 15);
                        Console.Write("Θ Θ Θ Θ Θ Θ Θ");
                        Console.SetCursorPosition(18, 16);
                        Console.Write("Θ Θ Θ Θ Θ Θ Θ");
                        Console.SetCursorPosition(18, 17);
                        Console.Write("Θ Θ Θ Θ Θ Θ Θ");
                        RCInfo.Rice = RCInfo.Rice - (RCInfo.Number * 160);
                        RiceHeight(50, 2, RCInfo.Rice);
                        Thread.Sleep(3000);

                        for (int i = 0; i < 2; i++)
                        {
                            RCInfo.State = CookerProcess.Watering;
                            RCInfo.Water = RCInfo.Water - (RCInfo.Number * 170 * 2);
                            RiceInfo(RCInfo);


                            Sound.SoundLocation = "Water_in.wav";
                            Sound.Load();
                            Sound.Play();

                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(24, 12);
                            Console.Write("Adding Rice");
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.SetCursorPosition(18, 13);
                            Console.Write("Θ Θ Θ Θ Θ Θ Θ");
                            Console.SetCursorPosition(18, 14);
                            Console.Write("Θ Θ Θ Θ Θ Θ Θ");
                            Console.SetCursorPosition(18, 15);
                            Console.Write("Θ Θ Θ Θ Θ Θ Θ");
                            Console.SetCursorPosition(18, 16);
                            Console.Write("Θ Θ Θ Θ Θ Θ Θ");
                            Console.SetCursorPosition(18, 17);
                            Console.Write("Θ Θ Θ Θ Θ Θ Θ");
                            WaterHeight(74, 2, RCInfo.Water);
                            Thread.Sleep(3000);

                            Sound.SoundLocation = "Washing Rice.wav";
                            Sound.Load();
                            Sound.Play();
                            RCInfo.State = CookerProcess.Washing;
                            RiceInfo(RCInfo);

                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(24, 12);
                            Console.Write("Adding Rice");
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.SetCursorPosition(18, 13);
                            Console.Write("~ ~ ~ ~ ~ ~ ~");
                            Console.SetCursorPosition(18, 14);
                            Console.Write("Θ Θ Θ Θ Θ Θ Θ");
                            Console.SetCursorPosition(18, 15);
                            Console.Write("~ ~ ~ ~ ~ ~ ~");
                            Console.SetCursorPosition(18, 16);
                            Console.Write("Θ Θ Θ Θ Θ Θ Θ");
                            Console.SetCursorPosition(18, 17);
                            Console.Write("~ ~ ~ ~ ~ ~ ~");
                            Thread.Sleep(3000);

                            RCInfo.State = CookerProcess.Droping;
                            RiceInfo(RCInfo);

                            Sound.SoundLocation = "water_out.wav";
                            Sound.Load();
                            Sound.Play();

                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(24, 12);
                            Console.Write(" Droping water");
                            for (int j = 0; j < 5; j++)
                            {
                                Console.BackgroundColor = ConsoleColor.Black;
                                for (int k = 0; k < j; k++)
                                {
                                    Console.SetCursorPosition(18, 13 + k);
                                    Console.Write("Θ Θ Θ Θ Θ Θ Θ");
                                }

                                Console.BackgroundColor = ConsoleColor.Blue;
                                for (int k = j; k < 5; k++)
                                {
                                    Console.SetCursorPosition(18, 13 + k);
                                    Console.Write("Θ Θ Θ Θ Θ Θ Θ");
                                }
                                Thread.Sleep(700);
                            }
                        }

                        // Note: 취사용 물 공급
                        RCInfo.Water = RCInfo.Water - (RCInfo.Number * 170);
                        WaterHeight(74, 2, RCInfo.Water);
                        RiceInfo(RCInfo);

                        // Note: 취사 시작
                        RCInfo.State = CookerProcess.Cooking;
                        RiceInfo(RCInfo);

                        Sound.SoundLocation = "rice.wav";
                        Sound.Load();
                        Sound.Play();

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(24, 12);
                        Console.Write("취사 중");
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(18, 13);
                        Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                        Console.SetCursorPosition(18, 14);
                        Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                        Console.SetCursorPosition(18, 15);
                        Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                        Console.SetCursorPosition(18, 16);
                        Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                        Console.SetCursorPosition(18, 17);
                        Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                        Thread.Sleep(7000); // 7초 정도

                        // Note: 완료 , 사운드 삐리릭...
                        RCInfo.State = CookerProcess.Completion;
                        RiceInfo(RCInfo);
                        Sound.SoundLocation = "Ring10.wav";
                        Sound.Load();
                        Sound.Play();
                        Thread.Sleep(7000); // 3초 정도

                        Sound.SoundLocation = "밥완료.wav";
                        Sound.Load();
                        Sound.Play();

                        Console.SetCursorPosition(24, 12);
                        Console.Write("취사 완료");
                        Thread.Sleep(3000); // 3초 정도

                        // Note: 보온
                        RCInfo.State = CookerProcess.Keeping;
                        RiceInfo(RCInfo);

                        Sound.SoundLocation = "맛있게드세요.wav";
                        Sound.Load();
                        Sound.Play();

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(24, 12);
                        Console.Write("보온 중  ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(18, 13);
                        Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                        Console.SetCursorPosition(18, 14);
                        Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                        Console.SetCursorPosition(18, 15);
                        Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                        Console.SetCursorPosition(18, 16);
                        Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                        Console.SetCursorPosition(18, 17);
                        Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
                        Thread.Sleep(3000); // 3초 정도
                        Console.ForegroundColor = ConsoleColor.White;

                        RCInfo.Number = 0; // Note: 인원수 초기화
                        break;
                    case 3: // Note:보온
                        if (!RCInfo.Power)
                        {
                            // 밧데리로 일부 메시지 전달
                            MessageBox(51, 27, "전원이 꺼져 있습니다");
                            Console.ReadKey(true);
                            break;
                        }

                        RCInfo.State = CookerProcess.Keeping;
                        RiceInfo(RCInfo);
                        break;
                    case 4: // 취소
                        RCInfo.State = CookerProcess.None;
                        RiceInfo(RCInfo);
                        break;
                    case 5: // 인원수
                        if (!RCInfo.Power)
                        {
                            // 밧데리로 일부 메시지 전달
                            MessageBox(51, 27, "전원이 꺼져 있습니다");
                            Console.ReadKey(true);
                            break;
                        }

                        MessageBox(51, 27, " 식사할 인원 수 : ");
                        try
                        {
                            RCInfo.Number = int.Parse(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            RCInfo.Number = 0;
                        }
                        break;

                    case 6: // 쌀통 설정
                        {
                            string Message = "현재 쌀의 양(kg) : " + (RCInfo.Rice / 1000);
                            MessageBox(51, 27, Message);
                            Console.SetCursorPosition(63, 29);
                            Console.Write("추가할 쌀 양(kg) : ");
                            string Amount = Console.ReadLine();
                            try
                            {
                                RCInfo.Rice += int.Parse(Amount) * 1000; // kg 단위
                                if (RCInfo.Rice > 18000) // 18kg 최대
                                {
                                    RCInfo.Rice -= int.Parse(Amount) * 1000;
                                    MessageBox(51, 27, "양이 너무 많습니다");
                                    Console.ReadKey(true);
                                    break;
                                }
                            }
                            catch (Exception e)
                            {
                                break;
                            }
                        }
                        break;
                    case 7: // 뭍통 설정
                        {
                            string Message = "현재 물의 양(리터) : " + (RCInfo.Water / 1000);
                            MessageBox(51, 27, Message);
                            string Amount = string.Empty;
                            Console.SetCursorPosition(63, 29);
                            Console.Write("추가할 물의 양(리터) : ");
                            Amount = Console.ReadLine();
                            try
                            {
                                RCInfo.Water += int.Parse(Amount) * 1000; // 리터를 밀리리터로 
                                if (RCInfo.Water > 18000)
                                {
                                    RCInfo.Water -= int.Parse(Amount) * 1000;
                                    MessageBox(51, 27, "양이 너무 많습니다");
                                    Console.ReadKey(true);
                                    break;
                                }
                            }
                            catch (Exception e)
                            {
                                break;
                            }
                        }
                        break;


                        //RCInfo.Water = RCInfo.Water - (RCInfo.Number * 170);
                        //WaterHeight(74, 2, RCInfo.Water);
                        //RiceInfo(RCInfo);
                }
            }
        }
    }
}
