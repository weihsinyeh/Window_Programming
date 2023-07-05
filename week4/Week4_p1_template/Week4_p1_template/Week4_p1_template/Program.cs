using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_p1_template
{
    class Program
    {
        public static int player1_money = 0, player2_money = 0, winner = 0, player_putmoney=0;
        struct card
        {
            public string flower;
            public string num;
        }
        static int Count_point(card[] player_array,string card_list)
        {
            //計算玩家目前的點數
            int player_point = 0;
            for (int i = 0; i < player_array.Length; i++)
            {
                switch (player_array[i].num)
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
            if ((player_point <= 11) && (card_list.Contains("1")))
            {
                player_point += 10; //有出現一點且兩張卡加起來不超過21
            }
            return player_point;
        }
        static card[] draw_card(card [] player_array,string card_list1,string card_list2)
        {
            String[] flower = { "Spade", "Heart", "Diamond", "Club" };
            String[] number = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            int randflower, randnum;
            string newcard;
            Array.Resize(ref player_array, (player_array.Length) + 1);
            do
            {
                Random myObject = new Random();
                randflower = myObject.Next(0, 3);
                randnum = myObject.Next(0, 12);
                newcard = flower[randflower]+" "+ number[randnum];
            } while (card_list1.Contains(newcard)|| card_list2.Contains(newcard));
            player_array[player_array.Length - 1].flower = flower[randflower];
            player_array[player_array.Length - 1].num = number[randnum];
            return player_array;
        }
        static string display(card [] player_array)
        {
            string card_list = "";
            for(int num=0;num<player_array.Length;num++)
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
        static void display_money(int money)
        {
            bool OK = true;
            try
            {
                do
                {
                    Console.Write("請輸入下注金額: ");
                    player_putmoney = int.Parse(Console.ReadLine());
                    //    金錢不足：Console.WriteLine("金錢不足，請重新輸入!");、並重新輸入
                    if (player_putmoney > money)
                    {
                        Console.WriteLine("金錢不足，請重新輸入!");
                        OK = false;
                    }
                    //    下注金額0：Console.WriteLine("金錢不能為零，請重新輸入!");、並重新輸入
                    else if (player_putmoney == 0)
                    {
                        Console.WriteLine("金錢不能為零，請重新輸入!");
                        OK = false;
                    }
                    else
                    {
                        OK = true;
                    }
                } while (OK == false);
            }
            catch (FormatException)
            {
                Console.Write("請輸入正確格式");
                Console.ReadKey();
                return;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                // 程式流程
                // 1. 輸入玩家1、玩家2初始金錢(需要格式檢查)
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
            catch (FormatException)
            {
                Console.Write("請輸入正確格式");
                Console.ReadKey();
                return;
            }
            do
            {
                rounding();
                Console.WriteLine("-----------------------------------------------------------------");
            } while (player1_money > 0 && player2_money > 0);   // 6. 如果雙方都還有錢就回到步驟2，否則結束程式
            Console.ReadKey();
        }
        static void rounding() {
            //現在牌組只有0張牌
            // 3. 顯示玩家2初始手牌、點數、金錢並下注，需檢查下注金額不能為0、金錢不足與格式檢查
            int player1_putmoney, player2_putmoney, player1_point, player2_point;
            card[] player1_array = new card[0];
            string player1_card_list ="",player2_card_list="" ; //player1的卡片數量為0;
            player1_array = draw_card(player1_array,player1_card_list, player2_card_list);
            player1_card_list = display(player1_array);
            player1_array = draw_card(player1_array, player1_card_list, player2_card_list);
            player1_card_list = display(player1_array);
            player1_point = Count_point(player1_array,player1_card_list);
            Console.WriteLine("玩家1手牌: {0}", player1_card_list);
            Console.WriteLine("玩家1目前點數:{0}",player1_point);
            Console.WriteLine("玩家1目前金錢:{0}", player1_money);
            display_money(player1_money);
            player1_putmoney = player_putmoney;
            Console.WriteLine("");
            card[] player2_array = new card[0];
            player2_array = draw_card(player2_array,player2_card_list, player1_card_list);
            player2_card_list = display(player2_array);
            player2_array = draw_card(player2_array,player2_card_list, player1_card_list);
            player2_card_list = display(player2_array);
            player2_point = Count_point(player2_array, player2_card_list);
            Console.WriteLine("玩家2手牌: {0}", player2_card_list);
            Console.WriteLine("玩家2目前點數:{0}", player2_point);
            Console.WriteLine("玩家2目前金錢:{0}", player2_money);
            display_money(player2_money);
            player2_putmoney = player_putmoney;
            Console.WriteLine("");

            // 4. 兩位玩家依序行動(不斷抽牌或停止抽牌)
            //    注意1：抽牌完要顯示玩家手牌與點數
            //    注意2：選擇停止抽牌，需印出當前點數
            int turn = 1;
            bool state1 = true, state2 = true; //true 為活動的狀態，false為break的狀態。
            while (true) {
                Console.WriteLine("玩家{0}行動(輸入1抽1張排、輸入P停止抽牌):", turn);
                String input = Console.ReadLine();
                if (turn == 1)
                {
                    switch (input)
                    {
                        case "1":
                            state1 = true;
                            player1_array = draw_card(player1_array, player1_card_list, player2_card_list);
                            player1_card_list = display(player1_array);
                            Console.WriteLine("玩家{0}手牌:{1}", turn, player1_card_list);
                            player1_point = Count_point(player1_array, player1_card_list);
                            Console.WriteLine("玩家{0}目前點數:{1}", turn, player1_point);
                            break;
                        case "P":
                            state1 = false; 
                            Console.WriteLine("玩家{0}跳過，目前點數: {1}", turn, player1_point);
                            turn = 2;
                            break;
                        default:
                            break;
                    }
                    
                    if ((player1_point > 21))
                    {
                        Console.WriteLine("玩家1爆了，玩家2獲勝!\n");
                        winner = 2;
                        break;
                    }
                }
                else
                {
                    switch (input)
                    {
                        case "1":
                            state2 = true;
                            player2_array = draw_card(player2_array, player2_card_list, player1_card_list);
                            player2_card_list = display(player2_array);
                            Console.WriteLine("玩家{0}手牌:{1}", turn, player2_card_list);
                            player2_point = Count_point(player2_array, player2_card_list);
                            Console.WriteLine("玩家{0}目前點數:{1}", turn, player2_point);
                            break;
                        case "P":
                            state2 = false;
                            Console.WriteLine("玩家{0}跳過，目前點數: {1}", turn, player2_point);
                            turn = 1;
                            break;
                        default:
                            break;
                    }
                    if ((player2_point > 21))
                    {
                        Console.WriteLine("玩家2爆了，玩家1獲勝!\n");
                        winner = 1;
                        break;
                    }
                }
                if((state1 == false )&& (state2 == false))
                {
                    break;
                }
            }

            // 5. 結果判定


            //    case3 : 若雙方都沒超過21點，比較點數大小並判斷勝敗平手
            if (winner == 0)
            {
                if (player2_point > player1_point)
                {
                    winner = 2;
                }
                else if (player2_point < player1_point)
                {
                    winner = 1;
                }
                else
                {
                    winner = 0;
                }
            }
            if(winner == 2)
            {
                    Console.WriteLine("玩家2獲勝，獲得{0}金錢", player1_putmoney);
                player2_money += player1_putmoney;
                player1_money -= player1_putmoney;
            }
            else if(winner ==1)
            {
                Console.WriteLine("玩家1獲勝，獲得{0}金錢", player2_putmoney);
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

