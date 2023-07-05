/**************************************************************************************************
資訊系113 F74109016 葉惟欣 practice_2 找迷宮的最短路徑
此程式用的找路方法 : DFS深度優先搜尋
Q1 .如何比較哪個路徑最短? 
A: 比較哪條岔路的方向走過去後會離終點最近
Q2 .如何寫好Recurrence? 
A: 透過不走重複路徑的方法(by新走的每一步都在地圖設為'*')，但最後路徑到終點後又要把路徑都設回' '。
如此一來在接下來討論其他方向的路線就不會被前面的路線干擾。也因為每一條路徑之後都會被清空，
所以我用了一個string path來記錄每一個方向的路線。也同時作為比路線大小的依據，最後留下的一條路線才會return回去。

Recurrence是在每個路線方向新增一個的時候，就會再次呼叫 找最佳路線的函數，此為dfs。
因為程式最一開始就把方向訂為 0:東 1:北 2:西 3:南，所以Recurrence會一直try每一種可能，
倘若path長度太長就會被捨棄，換下一個方向去嘗試就再次呼叫 找最佳路線的函數。
即便dfs是深度優先搜尋，但因為要確認是不是最短的路線，所以其他方向的路線也要一直用recurrence去找最短路線再做比較。
************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int first_row,first_col; //起始位址
        static int [] next_row = { 0, -1, 0, 1 };   //y座標的變化方向
        static int [] next_col = { 1, 0, -1, 0 };   //x座標的變化方向
        static void Main(string[] args)
        {
            int row, col;
            Console.Write("請輸入迷宮大小(底,高): ");
            string input = Console.ReadLine();
            string[] inputnum = input.Split(','); //輸入兩個以空白區隔的整數
            try
            {
                col = int.Parse(inputnum[0]);             //底
                row = int.Parse(inputnum[1]);             //高
                /****************將地圖存輸入***********************/
                Console.WriteLine("輸入迷宮地圖:");
                string[] input_row = new string[row];            //存放每一列的string
                char[,] array = new char[row + 2, col + 2];      //存放讀進來的地圖為 char[,]
                
                for (int i = 0; i < row; i++)                    //讀進每一行的string，所以使用者輸入時要一行一行輸入
                {
                    input_row[i] = Console.ReadLine();
                }
                /****************將輸入的地圖存進array***********************/
                for (int i = 0; i < row + 2; i++)                //將地圖的大小放大，最外圈都設為1，是為了要讓起點的時候走超出地圖陣列。
                {
                    for (int j = 0; j < col + 2; j++)
                    {
                        if ((i == 0) || (i == row + 1) || (j == 0) || (j == col + 1))        
                        {
                            array[i, j] = '1';                   //將最外圈都設為1
                        }
                        else
                        {
                            array[i, j] = char.Parse(input_row[i-1].Substring(j - 1, 1));    //其他部分由剛剛讀進來的一列列字串陣列轉成分開的一個個的字元。
                        }
                    }
                }
                /********************找開始值******************************/
                search_start(array);
                /********************找最短的路徑******************************/
                string path = "";                         //起初路線沒有任何方向
                path = bestpath(array,first_row,first_col,path);
                /****************印出地圖************************************/
                Console.WriteLine("\nOutPut:");
                int counter_step=display(array, path);

                /****************顯示路徑長度(不含起、終點)************************************/
                if (counter_step == 0)
                {
                    Console.Write("沒有路徑");
                }
                else
                {
                    Console.Write("{0}", counter_step);
                }
                /****************************************************************/
                Console.ReadKey();

            }
            catch (FormatException)
            {
                Console.WriteLine("請輸入正確格式");
                Console.ReadKey();
                return;
            }
        }
       
        /**********************繪出路線圖*******************************/
        static int display(char [,] array,string path)
        {
            int counter_step = 0;                              //紀錄路線走了幾步會到
            int now_row = first_row, now_col = first_col;      //起始位置 
            //當包含%代表最後沒有找到最短路徑，也就是說沒有路徑從0通往X，
            //所以也就不須透過傳回來的地圖判斷行徑方向了，因為根本就沒有通，也因此Output就直接再把原始地圖繪製一次即可
            if (path.Contains("%"))
            {
                for (int i = 1; i < array.GetLength(0) - 1; i++)
                {
                    for (int j = 1; j < array.GetLength(1) - 1; j++)
                    {
                        Console.Write("{0}", array[i, j]);
                    }
                    Console.WriteLine("");
                }
                return 0;                     //因為沒有可以通的路線，所以路線走幾步的計算即為0
            }
            else
            {
                for (int i = 0; i < path.Length; i++)
                {
                    now_row += next_row[int.Parse(path.Substring(i, 1))];       //第一步是 "起始位置" 加 "路線裡面的第一個方向 "。最後再從string 轉成整數用作 方向陣列的index
                    now_col += next_col[int.Parse(path.Substring(i, 1))];
                    array[now_row, now_col] = '*';                              //繪製地圖的路線。
                    counter_step++;                                             //紀錄路線走了幾步
                }
                /********************繪製新地圖含路徑*******************************/
                for (int i = 1; i < array.GetLength(0) - 1; i++)
                {
                    for (int j = 1; j < array.GetLength(1) - 1; j++)
                    {
                        Console.Write("{0}", array[i, j]);
                    }
                    Console.WriteLine("");
                }
                return counter_step;                                            //回傳路徑的步數
            }
        }
        /*********************************找起點**************************************/
        static void search_start(char [,] array)
        {
            //因為array宣告大小比使用者輸入大兩個row與col，所以使用者輸入的地圖界線其實是如此
            for (int i = 1; i < array.GetLength(0) - 1; i++)        
            {
                for (int j = 1; j < array.GetLength(1) - 1; j++)
                {
                    if (array[i,j] == '0')
                    {
                        first_row = i;
                        first_col = j;
                    }
                }
            }
        }
        /*******************找到最短路徑******************************************************************/
        //array 傳入 bestpath的參數 為測試地圖會一直隨著路線的增加而調整，但一旦某路徑走到終點後，該測試地圖上的路線就會清空，給下一個方向的路線只有上一步以前的地圖。
        static string bestpath(char[,] array, int start_row, int start_col,string path) //整個recurrence 會在找到終點時做第一次回傳，回傳後再由上一步去判斷同樣到達終點的路線哪個路線最短。
        {
            int direction_count = 0,first_direction = -1;
            string [] path_direction = { "" ,  "" ,  "" ,  ""  }; //先將"東 北 西 南"開始的路線先設為""，每一條路線回在接下來的for迴圈確認是否 case1:到終點 case2:還有路線 case3:碰壁
            char[,] arraytest = array;
            for (int i = 0; i < 4; i++) //4個方向都試過了
            {
                /*************************case1:找到終點******************************************************************/
                if (array[start_row + next_row[i], start_col + next_col[i]] == 'X') 
                {
                    return "";       //直接回傳""，就代表上一步的路徑已經是到終點前面了
                                     //因為在這個方向已經找到路徑且就在眼前，不會再有其他方向的路徑比這條路徑短，所以不需再考慮其他方向了
                }
                /*************************case2:還有路線(當還沒看到終點時，還在繼續找路)**********************************/
                else if (array[start_row + next_row[i], start_col + next_col[i]] == ' ')   
                {
                    direction_count++;  //幾個方向可以走
                    if (direction_count == 1)          //先記錄第一個可以走動的方向，如此一來等下再比較哪條路徑到終點最短時，才不會因有碰壁路線""，而造成程式誤判為最短路徑
                    {
                        first_direction = i;                                            //這個if的判斷式功能會在下面不是死路的狀況出現
                    }
                    //path_direction[i] += Convert.ToString(i);                           //如果另一個' '，就將方向紀錄在新的路線圖。
                    path_direction[i] += i.ToString();
                    arraytest[start_row + next_row[i], start_col + next_col[i]] = '*';  //同時將走過的位置先設為*，用來做之後遞迴時不要走曾經經過的位置，避免路線一直繞來繞去
                    path_direction[i] += bestpath(arraytest, start_row + next_row[i], start_col + next_col[i], path_direction[i]); // path_direction[i] 會一直增加，但到最後會在不是死路的狀況判斷哪條路徑是最短的
                    arraytest[start_row + next_row[i], start_col + next_col[i]] = ' ';  //將新增假想的路徑都先清掉'*'==>' '，這樣其他方向才能規劃其他方向的路線。
                }
                /**************************case3:碰壁，碰壁狀況，直接換下一個方向走*************************************/
                else
                {
                    continue;
                }
            }
            /*************死路**************************/
            if (direction_count == 0)
            {
                //為了避免死路變為一條最短的新路線，刻意把回傳值的string的長度弄很長，如此一來可以在上一個位置的路線方向篩選中被篩掉
                //同時加了 "%" 是死路的標記字串，如果最後回傳的總路徑依然還有 "%" 標記字串，代表最後回傳的總路徑為死路，同時那也代表沒有路徑通往終點。
                return "%                                                                                                        ";
            }

            /*************不是死路*********************/
            else
            {
                //最短路徑直接從第一個有新增路的路徑開始，這樣可以避免掉將碰壁的方向，
                //即為path_direction為函數剛剛宣告的初始值，路徑長度為0視為最短路徑。
                int min = first_direction; 
                /***********************比較哪個路徑為最短路徑***************************************/
                for (int i = first_direction; i < 4; i++)
                {
                    //這裡也有在避免後續的路線是否有碰壁的情形，倘若碰壁路徑回傳是""，但這並非最小的值。
                    if ((path_direction[i].Length < path_direction[min].Length) && (path_direction[i].Length != 0) )
                    {
                        min = i;
                    }
                }
                return path_direction[min];
            }
        }
    }
}
