//F74109016_W5_practice_2  葉惟欣
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class bird
    {
        private string name;               //名子
        private int Money;                 //錢
        private int Health;                //健康
        private int Weight;                //體重
        private int Satisfaction;          //飽足感
        private int Emotion;               //心情
        private int Age = 1;
        private bool event_happen = false; //剛開始沒有事件發生
        private bool IsDirty = false;      //大便的有無
        private bool IsSick = false;       //生病的有無
        private bool IsDead = false;       //死掉的有無
        private string event_happen_tomorrow = ""; //在事件的字串
        private string calendar = "";              //日歷字串
        Random random_create;                      //宣告隨機的物件
        /*****************建構子***********************************/
        public bird(string name)
        {
            random_create = new Random();          //建立隨機的物件
            //設定初始值
            set_Money(100);                        //初始金錢為100元
            set_Health(70);
            set_Weight(700);
            set_Satisfaction(70);
            set_Emotion(50);
            set_Name(name);
            event_happen_tomorrow += get_Name()+"出生了";
            calendar +="你開始養小雞了" + Environment.NewLine + "第" + get_Age().ToString() + "天" + Environment.NewLine;
        }
        /*****************服務方法*********************************/
        public void set_Name(string name)
        {
            this.name = name;
        }
        public void set_Money(int Money)
        {
            this.Money = Money;
        }
        public void set_Health(int Health)
        {
            this.Health = Health;
        }
        public void set_Weight(int Weight)
        {
            this.Weight = Weight;
        }
        public void set_Satisfaction(int Satisfaction)
        {
            this.Satisfaction = Satisfaction;
        }
        public void set_Age(int Age)
        {
            this.Age = Age;
        }
        public void set_Emotion(int Emotion)
        {
            this.Emotion = Emotion;
        }
        public string get_Name()
        {
            return name;
        }
        public int get_Money()
        {
            return Money;
        }
        public int get_Health()
        {
            return Health;
        }
        public int get_Weight()
        {
            return Weight;
        }
        public int get_Satisfaction()
        {
            return Satisfaction;
        }
        public int get_Emotion()
        {
            return Emotion;
        }
        public int get_Age()
        {
            return Age;
        }
        public string get_Event()
        {
            return event_happen_tomorrow;
        }
        public bool get_IsDead()
        {
            return IsDead;
        }
        public string get_Calendar()
        {
            return calendar;
        }
        /**************************功能方法***************************/
        public void change_Money(int change)
        {
            Money += change;
        }
        public void change_Health(int change)       //Health的值範圍在(0 ~ 100)
        {
            if (Health + change < 0)
            {
                Health = 0;
            }
            else if (Health + change > 100)
            {
                Health = 00;
            }
            else
            {
                Health += change;
            }
        }
        public void change_Weight(int change)       //Weight的值範圍在(600 ~ 4000)
        {
            if (Weight + change < 600)
            {
                Weight = 600;
            }
            else if (Weight + change>4000)
            {
                Weight = 4000;
            }
            else
            {
                Weight += change;
            }
        }
        public void change_Satisfaction(int change)  //Satisfaction的值範圍在(0 ~ 100)
        {
            if (Satisfaction + change < 0)
            {
                Satisfaction = 0;
            }
            else if(Satisfaction + change > 100)
            {
                Satisfaction = 100;
            }
            else
            {
                Satisfaction += change;
            }
        }
        public void change_Emotion(int change)      //Emotion的值範圍在(0 ~ 100)
        {
            if (Emotion + change < 0)
            {
                Emotion = 0;
            }
            else if(Emotion + change > 100)
            {
                Emotion = 100;
            }
            else
            {
                Emotion += change;
            }
        }
        public void change_Age(int change){
            Age += change;
        }
        /*****************************餵食******************************/
        public void Feed()                                          
        {
            if (get_Money() >= 10)
            {
                change_Money(-10);                                                   //每次十塊
                change_Satisfaction(random_create.Next(0, 21));                      //飽足感隨機增加(0~20)
                change_Weight(random_create.Next(50, 101));                          //體重隨機增加(50~100)
                if (IsDirty == true)                                                 //當存在排泄物，餵食後健康減少 10
                {
                    change_Health(-10);
                }
                calendar+= "餵食了" + get_Name() + Environment.NewLine;//日歷內容
            }
            //當金錢為 0 時，在按下互動按鈕時請根據按的按鈕顯示訊息
            else                                                                     
            {
                calendar += "金額不足無法餵食" + Environment.NewLine;
            }
        }
        /*********************玩耍**************************************/
        public void Play()                                        
        {
            if (get_Money() >= 5)
            {
                change_Money(-5);                                                   //每次 5 塊
                change_Health(random_create.Next(0, 21));                           //健康隨機增加(0~20)
                change_Emotion(random_create.Next(0, 21));                          //心情隨機增加(0~20)
                change_Satisfaction(-random_create.Next(0, 21));                    //飽足感隨機減少(0~20)
                calendar += "與" + get_Name() + "玩耍了" + Environment.NewLine;     //日歷內容
            }
            //當金錢為 0 時，在按下互動按鈕時請根據按的按鈕顯示訊息
            else
            {
                calendar += "金額不足無法玩耍" + Environment.NewLine;               
            }
        }
        public void Clean()
        {
            if (get_Money() >= 5)                                   //每次花費 5 塊
            {
                change_Money(-5);                                   
                //清除排泄物
                if (IsDirty == true)
                {
                    int first = event_happen_tomorrow.IndexOf(get_Name() + "大便了 ");
                    int count = get_Name().Length + 4;
                    event_happen_tomorrow = event_happen_tomorrow.Remove(first,count);
                    IsDirty = false;
                    calendar += "清理了大便" + Environment.NewLine;
                }
                //沒有排泄物就甚麼都不用清
                else
                {
                    calendar += "";
                }
            }
            //當金錢為 0 時，在按下互動按鈕時請根據按的按鈕顯示訊息
            else
            {
                calendar += "金額不足無法打掃" + Environment.NewLine;                  
            }
        }
        /****************看醫生********************************************************/
        public void GoToDoctor()
        {
            if (get_Money() >= 20) {
                change_Money(-20);                                     //每次花費 20 塊
                change_Health(+30);                                    //健康加 30
                change_Emotion(-20);                                   //心情減 20
                //移除生病狀態                                      
                if (IsSick == true)
                {
                    int first = event_happen_tomorrow.IndexOf(get_Name() + "生病了 ");
                    int count = get_Name().Length + 4;
                    event_happen_tomorrow = event_happen_tomorrow.Remove(first, count);
                    IsSick = false;
                }
                calendar += "帶" + get_Name() + "去看醫生" + Environment.NewLine;
            }
            //當金錢為 0 時，在按下互動按鈕時請根據按的按鈕顯示訊息
            else
            {
                calendar += "金額不足無法看醫生" + Environment.NewLine;
            }
        }
        /**************長大**************************************************************/
        public void Grow()
        {
            change_Age(1);
            calendar += Environment.NewLine+"第" + get_Age().ToString() + "天" + Environment.NewLine;
        }
        /***************結束這天**************************************************/
        public void end_day()
        {
            //飽足感減少 20
            change_Satisfaction(-20);                                    
            //養 10 天後健康每天減少 10
            if (get_Age() >= 10)                                         
            {
                change_Health(-10);
            }
            //飽足感歸零後每天體重減少200
            if (get_Satisfaction() == 0)
            {
                change_Weight(-200);                                    
            }        
            if(IsSick == true)          //如果今天結束時是生病的狀態==>體重減150，心情減 20。 之後再以新的數值計算明天會發生的事件
            {
                change_Weight(-150);
                change_Emotion(-20);
            }
            if (IsDirty == true)        //如果今天結束時是存在排泄物的狀態==>健康減 30 。  之後再以新的數值計算明天會發生的事件
            {
                change_Health(-30);
            }
            //計算隔天的事件
            event_tomorrow();    
        }
        /************************計算明天會發生的事情***************************/
        public void event_tomorrow()
        {
            Grow();                                                   //計算明天禮拜幾
            event_happen = false;                                     //明天會發生的事情預設為false，用以計算明天是否沒有事情發生
            event_happen_tomorrow = "";                               //明天會發生的事件目前還沒有，也就是將昨天的事件刪掉
            /****************排泄***********************************/
            if (get_Satisfaction() >= 50)                             //排泄條件: 當飽足感大於等於 50，今天就會大(事件與日歷都會顯示)
            {                                                         //排泄不會健康減 30，大便沒清隔天才會有數值的變化。
                event_happen_tomorrow += name + "大便了 ";            //事件就會顯示今天大便了
                IsDirty = true;                                       //大便了，如果今天沒清掃的話就留給明天看確認是否是髒的
                event_happen = true;                                  //事件發生
                calendar += "牠大便了" + Environment.NewLine;         //日歷就會顯示今天大便了
            }
            else                                                      //如果今天沒大的話，看今天是否是髒的(有大便沒掃得話)
            {
                if (IsDirty == true)                                  //如果是昨天有大沒清(依然是髒的) 今天沒大的話 日歷不會顯示大便 但事件的大便還會在
                {                                                     //不用再做 體重減150，心情減 20，因為剛剛已經減了，現在是以新數值來看
                    event_happen_tomorrow += name + "大便了 ";        //事件顯示
                    event_happen = true;                              //事件發生
                }
            }
            /****************下蛋***********************************/
            if ((get_Weight() > 1000) && (get_Health() > 60))         //下蛋條件: 體重大於 1000且健康大於 60
            {
                if (random_create.Next(1, 101) <= get_Emotion())      //以心情(%)為機率下蛋
                {
                    change_Health(-5);                                //下蛋後健康減少 5
                    int gain_money = random_create.Next(15, 26);      //留做日歷的收入顯示，賣出隨機獲得 15 ~ 25 塊錢
                    change_Money(gain_money);                         //錢的收入改變
                    event_happen_tomorrow += name + "下蛋了 ";        //事件顯示
                    calendar += name + "下蛋了，賣掉蛋後獲得"+gain_money.ToString()+"塊錢"+Environment.NewLine; //日歷顯示
                    event_happen = true;                              //事件發生
                }
            }
            /****************生病***********************************/
            if (IsSick == true)                                                    //生病狀態未移除
            {
                event_happen_tomorrow += name + "生病了 ";                         //事件顯示
                calendar += get_Name() + "牠生病了" + Environment.NewLine;         //日歷顯示，不像大便有分今天大的還是昨天大的，生病的狀態會一直留著
                event_happen = true;                                               //事件發生
            }
            else if ((get_Health() <= 50) && (get_Emotion() <= 50))                //如果現在還沒生病，但健康少等於 50且心情少於等於 50 
            { 
                if(random_create.Next(1, 101) <= 100 - get_Health())               //以(100 - 健康)(%)機率產生生病狀態，生病可能的機率
                {
                    event_happen_tomorrow += name + "生病了 ";                     //事件顯示
                    calendar += get_Name() + "牠生病了" + Environment.NewLine;     //日歷顯示，不像大便有分今天大的還是昨天大的，生病的狀態會一直留著
                    event_happen = true;                                           //事件發生
                    IsSick = true;                                                 //生病了
                }
            }
            /****************死亡***********************************/
            if (((get_Health() <= 10) && (get_Weight() <= 1000))||(IsDead == true))       //健康小於 10且體重小於 1000g
            {
                if (random_create.Next(1, 101) <= 100 - get_Emotion())                    //以(100 - 心情)(%)機率死亡
                {
                    event_happen_tomorrow += name + "死掉了 ";                            //事件顯示
                    calendar +="死掉了，遊戲結束" + Environment.NewLine;                  //日歷顯示
                    event_happen = true;                                                  //事件發生
                    IsDead = true;                                                        //死掉了，用來禁用所有按鈕的判斷
                }
            }
            /***************如果今天沒有事情發生*******************/
            if (event_happen == false)
            {
                event_happen_tomorrow = name + "今天很乖";
                calendar += "一天平安的過去了" + Environment.NewLine;
            }
        }
    }
}
