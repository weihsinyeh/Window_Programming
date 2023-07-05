using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_p1_template
{
    class Program
    {
        static string drawcard(string self_card,string another_card)
        {
            string[] flower = { "Spade", "Heart", "Di0amond", "Club" };
            string[] num = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13" };
            Random myObject = new Random();
            string new_card = "";
            int randflower, randnum;
            do
            {
                new_card = "";
                randflower = myObject.Next(0, 4);
                randnum = myObject.Next(0, 13);
                new_card += flower[randflower] + " " + num[randnum];
            } while (self_card.Contains(new_card) || another_card.Contains(new_card));
            return new_card;
        }
        static int count(int[] player_cardnum)
        {
            int count = 0;
            int times_1 = 0;
            for(int i = 0; i < player_cardnum.Length - 1; i++)
            {
                if (player_cardnum[i] == 1) {
                    count += 1;
                    times_1 += 1;
                }
                else { 
                    count += player_cardnum[i];
                }
            }
            if (count <= 11 && times_1 >= 1)
            {
                count += 10;
            }
            return count;
        }
        static int num_count(string new_card)
        {
            if (new_card.Contains("11"))
            {
                return 11;
            }
            else if (new_card.Contains("12"))
            {
                return 12;
            }
            else if (new_card.Contains("13"))
            {
                return 13;
            }
            else if (new_card.Contains("4"))
            {
                return 4;
            }
            else if (new_card.Contains("5"))
            {
                return 5;
            }
            else if (new_card.Contains("6"))
            {
                return 6;
            }
            else if (new_card.Contains("7"))
            {
                return 7;
            }
            else if (new_card.Contains("8"))
            {
                return 8;
            }
            else if (new_card.Contains("9"))
            {
                return 9;
            }
            else if (new_card.Contains("10"))
            {
                return 10;
            }
            else if (new_card.Contains("2"))
            {
                return 2;
            }
            else if (new_card.Contains("3"))
            {
                return 3;
            }
            else
            {
                return 1;
            }
        }
        static void Main(string[] args)
        {
            int player1_money = 0,player2_money=0;
            try
            {
                // 程式流程
                // 1. 輸入玩家1、玩家2初始金錢(需要格式檢查)
                //
                Console.Write("玩家1初始金錢:");
                player1_money = int.Parse(Console.ReadLine());
                Console.Write("玩家2初始金錢:");
                player2_money = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.Write("請輸入正確格式");
                Console.ReadKey();
                return;
            }
            // 2. 顯示玩家1初始手牌、點數、金錢並下注，需檢查下注金額不能為0、金錢不足與格式檢查
            //    手牌花色：Spade, Heart, Di0amond, Club
            //    手牌點數：1~13
            //    手牌顯示格式: "花色 點數"
            do
            {
                string[] flower = { "Spade", "Heart", "Di0amond", "Club" };
                string[] num = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13" };
                int[] player1_cardnum = new int[1];
                int[] player2_cardnum = new int[1];
                string player1_card = "", player2_card = "";
                string new_card = drawcard(player1_card, player2_card);
                player1_cardnum[player1_cardnum.Length-1] = num_count(new_card);
                Array.Resize(ref player1_cardnum, player1_cardnum.Length + 1);
                player1_card += new_card;
                Console.WriteLine("玩家1手牌: " + player1_card);
                int player1_point = count(player1_cardnum);
                Console.WriteLine("玩家1目前點數: " + player1_point.ToString());
                Console.WriteLine("玩家1目前金錢: " + player1_money.ToString());
                Console.Write("請輸入下注金額: ");
                int player1_put = 0, player2_put = 0;
                try
                {
                    bool again = false;
                    do
                    {
                        player1_put = int.Parse(Console.ReadLine());
                        again = false;
                        if (player1_put == 0)
                        {
                            //下注金額0：
                            Console.WriteLine("金錢不能為零，請重新輸入!");
                            again = true;
                        }
                        else if (player1_put > player1_money)
                        {
                            Console.WriteLine("金錢不足，請重新輸入!");
                            again = true;
                        }
                    } while (again == true);
                }
                catch (FormatException)
                {
                    Console.WriteLine("請輸入正確格式");
                    return;
                }

                // 3. 顯示玩家2初始手牌、點數、金錢並下注，需檢查下注金額不能為0、金錢不足與格式檢查
                new_card = drawcard(player1_card, player2_card);
                player2_cardnum[player2_cardnum.Length-1] = num_count(new_card);
                Array.Resize(ref player2_cardnum, player2_cardnum.Length + 1);
                player2_card += new_card;
                
                Console.WriteLine("玩家2手牌: " + player2_card);
                int player2_point = count(player2_cardnum);
                Console.WriteLine("玩家2目前點數: " + player2_point.ToString());
                Console.WriteLine("玩家2目前金錢: " + player2_money.ToString());
                Console.Write("請輸入下注金額: ");
                try
                {
                    bool again = false;
                    do
                    {
                        player2_put = int.Parse(Console.ReadLine());
                        again = false;
                        if (player2_put == 0)
                        {
                            //下注金額0：
                            Console.WriteLine("金錢不能為零，請重新輸入!");
                            again = true;
                        }
                        else if (player2_put > player2_money)
                        {
                            Console.WriteLine("金錢不足，請重新輸入!");
                            again = true;
                        }
                    } while (again == true);
                }
                catch (FormatException)
                {
                    Console.WriteLine("請輸入正確格式");
                    return;
                }
                // 4. 兩位玩家依序行動(不斷抽牌或停止抽牌)
                //    注意1：抽牌完要顯示玩家手牌與點數
                //    注意2：選擇停止抽牌，需印出當前點數
                bool player1 = true, endgame = false;
                while (true)
                {
                    if (player1 == true)
                    {
                        do
                        {
                            Console.WriteLine("玩家1行動(輸入1抽1張排、輸入P停止抽牌):");
                            string input = Console.ReadLine();

                            if (input == "1")
                            {
                                new_card = drawcard(player1_card, player2_card);
                                player1_cardnum[player1_cardnum.Length-1] = num_count(new_card);
                                Array.Resize(ref player1_cardnum, player1_cardnum.Length + 1);
                                player1_card += ", " + new_card;
                                Console.WriteLine("玩家1手牌: " + player1_card);
                                player1_point = count(player1_cardnum);
                                Console.WriteLine("玩家1目前點數: " + player1_point.ToString());
                                if (player1_point > 21)
                                {
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            else if (input == "P")
                            {
                                //            停止抽牌：
                                Console.WriteLine("玩家1跳過，目前點數: " + player1_point.ToString());
                                player1 = false;
                                break;
                            }
                        } while (player1 == true);
                    }
                    else
                    {
                        do
                        {
                            Console.WriteLine("玩家2行動(輸入2抽1張排、輸入P停止抽牌):");
                            string input = Console.ReadLine();

                            if (input == "1")
                            {
                                new_card = drawcard(player2_card, player1_card);
                                player2_cardnum[player2_cardnum.Length-1] = num_count(new_card);
                                Array.Resize(ref player2_cardnum, player2_cardnum.Length + 1);
                                player2_card += ", " + new_card;
                                Console.WriteLine("玩家2手牌: " + player2_card);
                                player2_point = count(player2_cardnum);
                                Console.WriteLine("玩家1目前點數: " + player2_point.ToString());
                                if (player2_point > 21)
                                {
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            else if (input == "P")
                            {
                                //            停止抽牌：
                                Console.WriteLine("玩家2跳過，目前點數: " + player1_point.ToString());
                                endgame = true;
                                break;
                            }
                        } while (endgame == false);
                    }
                    if (player1_point > 21 || player2_point > 21 || endgame == true)
                    {
                        break;
                    }
                }
                // 5. 結果判定
                if (player1_point > 21)
                {
                    Console.WriteLine("玩家1爆了，玩家2獲勝!");
                    player1_money -= player1_put;
                    player2_money += player1_put;
                }
                else if (player2_point > 21)
                {
                    Console.WriteLine("玩家2爆了，玩家1獲勝!");
                    player1_money += player2_put;
                    player2_money -= player2_put;
                }
                else
                {
                    if (player1_point > player2_point)
                    {
                        Console.WriteLine("玩家1獲勝，獲得" + player2_put.ToString() + "金錢");
                    }
                    else if (player2_point > player1_point)
                    {
                        Console.WriteLine("玩家2獲勝，獲得" + player1_put.ToString() + "金錢");
                    }
                    else
                    {
                        Console.WriteLine("平手!拿回各自的錢");
                    }
                }
                Console.WriteLine("----------------------------------------------------");
            // 6. 如果雙方都還有錢就回到步驟2，否則結束程式
            } while (player1_money > 0 && player2_money > 0);
            // 6. 如果雙方都還有錢就回到步驟2，否則結束程式
            Console.ReadKey();
        }
    }
}
