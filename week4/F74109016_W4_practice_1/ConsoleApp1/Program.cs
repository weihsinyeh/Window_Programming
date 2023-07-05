/********************************************************************
 F74109016 資訊系113 葉惟欣 weeek4 practice1 21點
 *******************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_p1_template
{
    class Program
    {
        public static int player1_money = 0, player2_money = 0, winner = 0, player_putmoney = 0; //一開始初始錢與投入的錢都是0,winner=0為平手狀態，起初都還未分出勝負
        struct card              //卡片結構含花色與數字
        {
            public string flower;
            public string num;
        }
        /******************************計算卡片點數*********************************************/
        static int Count_point(card[] player_array, string card_list)  //參數要有手牌庫陣列是因為要知道有多少張牌在手牌庫，要有card_
        {
            //計算玩家目前的點數
            int player_point = 0;
            for (int i = 0; i < player_array.Length; i++)              //upper_bound為手牌庫的大小
            {
                switch (player_array[i].num)                           //手牌庫陣列的第二功能，知道每張牌分別代表幾點。
                {
                    case "1":
                        player_point += 1;
                        break;
                    case "2":
                        player_point += 2;
                        break;
                    case "3":
                        player_point += 3;
                        break;
                    case "4":
                        player_point += 4;
                        break;
                    case "5":
                        player_point += 5;
                        break;
                    case "6":
                        player_point += 6;
                        break;
                    case "7":
                        player_point += 7;
                        break;
                    case "8":
                        player_point += 8;
                        break;
                    case "9":
                        player_point += 9;
                        break;
                    case "10":
                    case "J":
                    case "Q":
                    case "K":
                        player_point += 10;
                        break;
                }
            }
            //當卡片中有出現數字1，將1改成11時不會超過21點，就將此1算成11點
            if ((player_point <= 11) && (card_list.Contains("1")))
            {
                player_point += 10; //有出現一點且兩張卡加起來不超過21
            }
            return player_point;
        }
        /*****************************隨機抽卡片****************************************/
        static card[] draw_card(card[] player_array, string card_list1, string card_list2)
        {
            String[] flower = { "Spade", "Heart", "Diamond", "Club" };
            String[] number = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            int randflower, randnum;
            string newcard;
            Array.Resize(ref player_array, (player_array.Length) + 1); //將手牌庫再重新增加一個元素
            do
            {
                /**************************/
                Random myObject = new Random();
                randflower = myObject.Next(0, 4);     //抽取隨機的花色
                randnum = myObject.Next(0, 13);       //抽取隨機的數字
                newcard = flower[randflower] + " " + number[randnum];
            } while (card_list1.Contains(newcard) || card_list2.Contains(newcard)); //當卡片字串裡面含有相同的花色與數字就要重新抽牌
            //確認非重複的牌，才將牌放入卡片字串裡面。
            player_array[player_array.Length - 1].flower = flower[randflower];      
            player_array[player_array.Length - 1].num = number[randnum];
            return player_array; //將整個手牌庫回傳
        }
        /*************************顯示目前所有的手牌*****************************/
        static string display(card[] player_array)
        {
            string card_list = "";
            for (int num = 0; num < player_array.Length; num++)
            {
                card_list += player_array[num].flower;
                card_list += " ";
                card_list += player_array[num].num;
                if (num != player_array.Length - 1)
                {
                    card_list += ",";
                }
            }
            return card_list;
        }
        /*****************************下注金額的顯示的防呆措施*****************************************/
        static void display_money(int money)
        {
            bool OK = true;
            do
            {
                try
                {
                    Console.Write("請輸入下注金額: ");
                    player_putmoney = int.Parse(Console.ReadLine());                               //下注金額為全域變數，這樣寫防呆措施的時候都可以用
                                                                                                   //    Case1金錢不足：Console.WriteLine("金錢不足，請重新輸入!");、並重新輸入
                    if (player_putmoney > money)
                    {
                        Console.WriteLine("金錢不足，請重新輸入!");
                        OK = false;
                    }
                    //    Case2下注金額0：Console.WriteLine("金錢不能為零，請重新輸入!");、並重新輸入
                    else if (player_putmoney == 0)
                    {
                        Console.WriteLine("金錢不能為零，請重新輸入!");
                        OK = false;
                    }
                    else
                    {
                        OK = true;
                    }
                }
                catch (FormatException) //需要格式檢查
                {
                    Console.Write("請輸入正確格式");
                    Console.ReadKey();
                    System.Environment.Exit(0); //這方法可以將程式徹徹底底的退出結束的方法，不會有殘留的線程在那邊煩你，如果要徹底結束程式的話這是最好的方法了
                                                //return 代表调到函数外，不代表主函數結束
                }
            } while (OK == false);
        }
        static void Main(string[] args)
        {
            try
            {
                // 程式流程 1. 輸入玩家1、玩家2初始金錢 (需要格式檢查)
                Console.Write("玩家1初始金錢: ");
                player1_money = int.Parse(Console.ReadLine());
                if (player1_money == 0)
                {
                    Console.WriteLine("金錢不能為零，請重新輸入!");
                }

                Console.Write("玩家2初始金錢: ");
                player2_money = int.Parse(Console.ReadLine());
                if (player2_money == 0)
                {
                    Console.WriteLine("金錢不能為零，請重新輸入!");
                }
                Console.WriteLine("-----------------------------------------------------------------");
            }
            catch (FormatException) //需要格式檢查
            {
                Console.Write("請輸入正確格式");
                Console.ReadKey();
                return;
            }
            /********************開始玩遊戲，玩到有一方沒錢玩*************************************/
            do
            {
                rounding();        //回合的函數
                Console.WriteLine("-----------------------------------------------------------------");
            } while (player1_money > 0 && player2_money > 0);   // 6. 如果雙方都還有錢就再一次rounding()函數，否則結束程式
            Console.ReadKey();
        }
        /******************遊戲的回合函數********************************************************/
        static void rounding()
        {
            // 宣告變數
            int player1_putmoney, player2_putmoney, player1_point, player2_point;
            card[] player1_array = new card[0];                                                           // 現在玩家1與2只有0張牌
            string player1_card_list = "", player2_card_list = ""; //player1的卡片數量為0;

            // 顯示玩家1初始手牌、點數、金錢並下注，需檢查下注金額不能為0、金錢不足與格式檢查
            player1_array = draw_card(player1_array, player1_card_list, player2_card_list);               //抽第一次牌 (更新手牌庫)
            player1_card_list = display(player1_array);                                                   //將現在所有的牌轉成手牌字串
            player1_array = draw_card(player1_array, player1_card_list, player2_card_list);               //抽第二次牌 (更新手牌庫)
            player1_card_list = display(player1_array);                                                   //將現在所有的牌轉成手牌字串
            player1_point = Count_point(player1_array, player1_card_list);                                //算點數，將手牌庫陣列與手牌庫字串作為參數
            Console.WriteLine("玩家1手牌: {0}", player1_card_list);
            Console.WriteLine("玩家1目前點數:{0}", player1_point);
            Console.WriteLine("玩家1目前金錢:{0}", player1_money);
            display_money(player1_money);                                                                 //輸入下注金額，下注金額為全域變數與初始金額一樣，
            player1_putmoney = player_putmoney;                                                           //目前的下注金額為player1的下注金額，要賦值給player1_putmoney，因為等下plaer_putmoney要去接受plaer2的下注金額
            Console.WriteLine("");
            // 3. 顯示玩家2初始手牌、點數、金錢並下注，需檢查下注金額不能為0、金錢不足與格式檢查
            card[] player2_array = new card[0];
            player2_array = draw_card(player2_array, player2_card_list, player1_card_list);               //抽第一次牌
            player2_card_list = display(player2_array);                                                   //將現在所有的牌轉成手牌字串
            player2_array = draw_card(player2_array, player2_card_list, player1_card_list);               //抽第二次牌
            player2_card_list = display(player2_array);                                                   //將現在所有的牌轉成手牌字串
            player2_point = Count_point(player2_array, player2_card_list);                                //算點數，將手牌庫陣列與手牌庫字串作為參數
            Console.WriteLine("玩家2手牌: {0}", player2_card_list);
            Console.WriteLine("玩家2目前點數:{0}", player2_point);
            Console.WriteLine("玩家2目前金錢:{0}", player2_money);
            display_money(player2_money);                                                                 //輸入下注金額，下注金額為全域變數與初始金額一樣，
            player2_putmoney = player_putmoney;                                                           //目前的下注金額為player2的下注金額，要賦值給player2_putmoney。
            Console.WriteLine("");

            /************************* 4. 兩位玩家依序行動(不斷抽牌或停止抽牌)***********************************/
            //    注意1：抽牌完要顯示玩家手牌與點數
            //    注意2：選擇停止抽牌，需印出當前點數
            int turn = 1;                       //當turn = 1是 player1, 當turn = 2是player2
            bool state1 = true, state2 = true;  //true 為活動的狀態，false為pause的狀態。
            while (true)
            {
                Console.WriteLine("玩家{0}行動(輸入1抽1張排、輸入P停止抽牌):", turn);
                String input = Console.ReadLine();
                if (turn == 1)
                {
                    switch (input)
                    {
                        case "1":
                            state1 = true;
                            player1_array = draw_card(player1_array, player1_card_list, player2_card_list); //抽牌
                            player1_card_list = display(player1_array);                       //將現在所有的牌轉成手牌字串
                            Console.WriteLine("玩家{0}手牌:{1}", turn, player1_card_list);    //抽牌完要顯示玩家手牌
                            player1_point = Count_point(player1_array, player1_card_list);    //算現在手牌庫的點數和
                            Console.WriteLine("玩家{0}目前點數:{1}", turn, player1_point);    //顯示當前點數
                            break;
                        case "P":
                            state1 = false;
                            Console.WriteLine("玩家{0}跳過，目前點數: {1}\n", turn, player1_point);  //選擇停止抽牌，需印出當前點數
                             turn = 2;
                            break;
                        default:
                            break;
                    }

                    if ((player1_point > 21))
                    {
                        Console.WriteLine("玩家1爆了，玩家2獲勝!\n");
                        winner = 2;             //勝利者紀錄為player2
                        Console.WriteLine("玩家2獲勝，獲得{0}金錢", player1_putmoney);
                        //金錢交換
                        player2_money += player1_putmoney;
                        player1_money -= player1_putmoney;
                        break;
                    }
                }
                else
                {
                    switch (input)
                    {
                        case "1":
                            state2 = true;
                            player2_array = draw_card(player2_array, player2_card_list, player1_card_list); //抽牌
                            player2_card_list = display(player2_array);                      //將現在所有的牌轉成手牌字串
                            Console.WriteLine("玩家{0}手牌:{1}", turn, player2_card_list);   //抽牌完要顯示玩家手牌
                            player2_point = Count_point(player2_array, player2_card_list);   //算現在手牌庫的點數和
                            Console.WriteLine("玩家{0}目前點數:{1}", turn, player2_point);   //顯示當前點數
                            break;
                        case "P":
                            state2 = false;
                            Console.WriteLine("玩家{0}跳過，目前點數: {1}\n", turn, player2_point); //選擇停止抽牌，需印出當前點數
                            turn = 1;
                            break;
                        default:
                            break;
                    }
                    if ((player2_point > 21))
                    {
                        Console.WriteLine("玩家2爆了，玩家1獲勝!\n");
                        winner = 1;             //勝利者紀錄為player1
                        Console.WriteLine("玩家1獲勝，獲得{0}金錢", player2_putmoney);
                        //金錢交換
                        player1_money += player2_putmoney;
                        player2_money -= player2_putmoney;
                        break;
                    }
                }
                if ((state1 == false) && (state2 == false))
                {
                    winner = 0;
                    break;
                }
            }

            // 5. 結果判定


            //    case3 : 若雙方都沒超過21點，比較點數大小並判斷勝敗平手
            if (winner == 0)             //還未分出勝負
            {
                if (player2_point > player1_point)
                {
                    Console.WriteLine("玩家2獲勝，獲得{0}金錢", player1_putmoney);
                    //金錢交換
                    player2_money += player1_putmoney;
                    player1_money -= player1_putmoney;
                }
                else if (player2_point < player1_point)
                {
                    Console.WriteLine("玩家1獲勝，獲得{0}金錢", player2_putmoney);
                    //金錢交換
                    player1_money += player2_putmoney;
                    player2_money -= player2_putmoney;
                }
                else
                {
                    Console.WriteLine("平手!拿回各自的錢");
                }
            }
        }
    }
}

