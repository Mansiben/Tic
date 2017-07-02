using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tic
{
    public partial class TicTacToe : System.Web.UI.Page
    {
        public static List<string> listOfButtons = new List<string>();
        public static bool winner;
        public static int count;
        public static int randomnum,index;
        public static string CompChoice,d;
        public static Random r = new Random();
        //public static Dictionary<int, string> values = new Dictionary<int, string>();
        public static LinkedList<string> names = new LinkedList<string>();
        public static LinkedList<int> scores = new LinkedList<int>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                addButtons();
                scores.AddLast(0);
                scores.AddLast(0);
                scores.AddLast(0);
                scores.AddLast(0);
                scores.AddLast(0);
                names.AddLast("User");
                names.AddLast("User");
                names.AddLast("User");
                names.AddLast("User");
                names.AddLast("User");
            }

        }
        public void addButtons()
        {
            if(!listOfButtons.Contains("T1"))
            {
                listOfButtons.Add("T1");
            }
            if (!listOfButtons.Contains("T2"))
            {
                listOfButtons.Add("T2");
            }
            if (!listOfButtons.Contains("T3"))
            {
                listOfButtons.Add("T3");
            }
            if (!listOfButtons.Contains("T4"))
            {
                listOfButtons.Add("T4");
            }
            if (!listOfButtons.Contains("T5"))
            {
                listOfButtons.Add("T5");
            }
            if (!listOfButtons.Contains("T6"))
            {
                listOfButtons.Add("T6");
            }
            if (!listOfButtons.Contains("T7"))
            {
                listOfButtons.Add("T7");
            }
            if (!listOfButtons.Contains("T8"))
            {
                listOfButtons.Add("T8");
            }
            if (!listOfButtons.Contains("T9"))
            {
                listOfButtons.Add("T9");
            }
        }
        public void computer()
        {
            if (listOfButtons.Count>1)
            {
                randomnum = r.Next(listOfButtons.Count);
                CompChoice=listOfButtons.ElementAt(randomnum);
                switch(CompChoice)
                {
                    case "T1":
                        T1.Text = "O";
                        T1.Enabled = false;
                        index = listOfButtons.FindIndex(s => s.Equals("T1"));
                        listOfButtons.RemoveAt(index);
                        listOfButtons.TrimExcess();
                        break;
                        case "T2":
                        T2.Text = "O";
                        T2.Enabled = false;
                        index = listOfButtons.FindIndex(s => s.Equals("T2"));
                        listOfButtons.RemoveAt(index);
                        listOfButtons.TrimExcess();
                        break;
                    case "T3":
                        T3.Text = "O";
                        T3.Enabled = false;
                        index = listOfButtons.FindIndex(s => s.Equals("T3"));
                        listOfButtons.RemoveAt(index);
                        listOfButtons.TrimExcess();
                        break;
                    case "T4":
                        T4.Text = "O";
                        T4.Enabled = false;
                        index = listOfButtons.FindIndex(s => s.Equals("T4"));
                        listOfButtons.RemoveAt(index);
                        listOfButtons.TrimExcess();
                        break;
                    case "T5":
                        T5.Text = "O";
                        T5.Enabled = false;
                        index = listOfButtons.FindIndex(s => s.Equals("T5"));
                        listOfButtons.RemoveAt(index);
                        listOfButtons.TrimExcess();
                        break;
                    case "T6":
                        T6.Text = "O";
                        T6.Enabled = false;
                        index = listOfButtons.FindIndex(s => s.Equals("T6"));
                        listOfButtons.RemoveAt(index);
                        listOfButtons.TrimExcess();
                        break;
                    case "T7":
                        T7.Text = "O";
                        T7.Enabled = false;
                        index = listOfButtons.FindIndex(s => s.Equals("T7"));
                        listOfButtons.RemoveAt(index);
                        listOfButtons.TrimExcess();
                        break;
                    case "T8":
                        T8.Text = "O";
                        T8.Enabled = false;
                        index = listOfButtons.FindIndex(s => s.Equals("T8"));
                        listOfButtons.RemoveAt(index);
                        listOfButtons.TrimExcess();
                        break;
                    case "T9":
                        T9.Text = "O";
                        T9.Enabled = false;
                        index = listOfButtons.FindIndex(s => s.Equals("T9"));
                        listOfButtons.RemoveAt(index);
                        listOfButtons.TrimExcess();
                        break;
                }
            }
           
        }
        public void checkScores()
        {
            for(int i=0;i<5;i++)
            {
                if(count>scores.ElementAt(i))
                {
                    name.Visible = true;
                    TextBox_name.Visible = true;
                    Button_Add.Visible = true;
                    break;
                }
                
            }
        }
        public void checkWinner()
        {
            winner = false;
            if ((T1.Text == T2.Text) && (T2.Text == T3.Text) && (!T1.Enabled))
            {
                winner = true;
                 d = T1.Text;
            }
                    
            else if ((T4.Text == T5.Text) && (T5.Text == T6.Text) && (!T4.Enabled))
            {
            winner = true;
               d= T4.Text;
            }
                
            else if ((T7.Text == T8.Text) && (T8.Text == T9.Text) && (!T7.Enabled))
            {
                winner = true;
                d = T7.Text;
            }
            else if ((T1.Text == T4.Text) && (T4.Text == T7.Text) && (!T1.Enabled))
            {
                winner = true;
                d = T1.Text;
            }
            else if ((T2.Text == T5.Text) && (T5.Text == T8.Text) && (!T2.Enabled))
            {
                winner = true;
                d = T2.Text;
            }
            else if ((T3.Text == T6.Text) && (T6.Text == T9.Text) && (!T3.Enabled))
            {
                winner = true;
                d = T3.Text;
            }
            else if ((T1.Text == T5.Text) && (T5.Text == T9.Text) && (!T1.Enabled))
            {
                winner = true;
                d = T1.Text;
            }
            else if ((T3.Text == T5.Text) && (T5.Text == T7.Text) && (!T3.Enabled))
            {
                winner = true;
                d = T3.Text;
            }
            if (winner)
            {
                string win = "";
                if(d=="X")
                {
                    win = "USer";
                    count++;
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "Congratulations..." + win + "\tYou won " +count+ " number of games" + "');", true);
                    T1.Enabled = false;
                    T2.Enabled = false;
                    T3.Enabled = false;
                    T4.Enabled = false;
                    T5.Enabled = false;
                    T6.Enabled = false;
                    T7.Enabled = false;
                    T8.Enabled = false;
                    T9.Enabled = false;

                }
                else if(d=="O")
                {
                    
                    win = "Computer";
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "Congratulations..." + win + "\tYou won " + "');", true);
                    checkScores();
                    T1.Enabled = false;
                    T2.Enabled = false;
                    T3.Enabled = false;
                    T4.Enabled = false;
                    T5.Enabled = false;
                    T6.Enabled = false;
                    T7.Enabled = false;
                    T8.Enabled = false;
                    T9.Enabled = false;
                }
            }
            else
            {
                if((!T1.Enabled)&&(!T2.Enabled)&&(!T3.Enabled)&&(!T4.Enabled)&&(!T5.Enabled)&&(!T6.Enabled)&&(!T7.Enabled)&&(!T8.Enabled)&&(!T9.Enabled))
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "Draw..Bummer!!" + "');", true);
                }
            }
        }
        protected void T1_Click(object sender, EventArgs e)
        {
            
            T1.Text = "X";
            T1.Enabled = false;
            int indexValue = listOfButtons.FindIndex(s => s.Equals("T1"));
            listOfButtons.RemoveAt(indexValue);
            listOfButtons.TrimExcess();
            computer();
            checkWinner();
           


        }
        protected void T2_Click(object sender, EventArgs e)
        {
            T2.Text = "X";
            T2.Enabled = false;
            int indexValue = listOfButtons.FindIndex(s => s.Equals("T2"));
            listOfButtons.RemoveAt(indexValue);
            listOfButtons.TrimExcess();
            computer();
            checkWinner();

        }

        protected void T3_Click(object sender, EventArgs e)
        {
            T3.Text = "X";
            T3.Enabled = false;
            int indexValue = listOfButtons.FindIndex(s => s.Equals("T3"));
            listOfButtons.RemoveAt(indexValue);
            listOfButtons.TrimExcess();
            computer();
            checkWinner();
        }

        protected void T4_Click(object sender, EventArgs e)
        {
          
            T4.Text = "X";
            T4.Enabled = false;
            int indexValue = listOfButtons.FindIndex(s => s.Equals("T4"));
            listOfButtons.RemoveAt(indexValue);
            listOfButtons.TrimExcess();
            computer();
            checkWinner();
        }

        protected void T5_Click(object sender, EventArgs e)
        {
            T5.Text = "X";
            T5.Enabled = false;
            int indexValue = listOfButtons.FindIndex(s => s.Equals("T5"));
            listOfButtons.RemoveAt(indexValue);
            listOfButtons.TrimExcess();
            computer();
            checkWinner();
        }

        protected void T6_Click(object sender, EventArgs e)
        {
            T6.Text = "X";
            T6.Enabled = false;
            int indexValue = listOfButtons.FindIndex(s => s.Equals("T6"));
            listOfButtons.RemoveAt(indexValue);
            listOfButtons.TrimExcess();
            computer();
            checkWinner();
        }

        protected void T7_Click(object sender, EventArgs e)
        {
            T7.Text = "X";
            T7.Enabled = false;
            int indexValue = listOfButtons.FindIndex(s => s.Equals("T7"));
            listOfButtons.RemoveAt(indexValue);
            listOfButtons.TrimExcess();
            computer();
            checkWinner();
        }

        protected void T8_Click(object sender, EventArgs e)
        {
            T8.Text = "X";
            T8.Enabled = false;
            int indexValue = listOfButtons.FindIndex(s => s.Equals("T8"));
            listOfButtons.RemoveAt(indexValue);
            listOfButtons.TrimExcess();
            computer();
            checkWinner();
        }

        protected void T9_Click(object sender, EventArgs e)
        {
            T9.Text = "X";
            T9.Enabled = false;
            int indexValue = listOfButtons.FindIndex(s => s.Equals("T9"));
            listOfButtons.RemoveAt(indexValue);
            listOfButtons.TrimExcess();
            computer();
            checkWinner();
        }

        protected void Button_Add_Click(object sender, EventArgs e)
        {
            for(int i=0;i<5;i++)
            {
                if(scores.Count.Equals(0))
                {
                    scores.AddFirst(count);
                    names.AddFirst(TextBox_name.Text);
                    break;
                }
                if(count>scores.ElementAt(i))
                {
                    int pos = scores.ElementAt(i);
                    LinkedListNode<int> nn = scores.Find(pos);
                    scores.AddBefore(nn, count);
                    string posname = names.ElementAt(i);
                    LinkedListNode<string> mm = names.Find(posname);
                    names.AddBefore(mm,TextBox_name.Text);
                    break;
                }
            }
            Label1.Visible = true;
            Label1.Text = names.ElementAt(0) + " " + scores.ElementAt(0);
            Label2.Visible = true;
            Label2.Text = names.ElementAt(1) + " " + scores.ElementAt(1);
            Label3.Visible = true;
            Label3.Text = names.ElementAt(2) + " " + scores.ElementAt(2);
            Label4.Visible = true;
            Label4.Text = names.ElementAt(3) + " " + scores.ElementAt(3);
            Label5.Visible = true;
            Label5.Text = names.ElementAt(4) + " " + scores.ElementAt(4);

        }

        protected void PlayGame(object sender, EventArgs e)
        {
            addButtons();
            T1.Visible = true;
            T2.Visible = true;
            T3.Visible = true;
            T4.Visible = true;
            T5.Visible = true;
            T6.Visible = true;
            T7.Visible = true;
            T8.Visible = true;
            T9.Visible = true;
            T1.Enabled = true;
            T2.Enabled = true;
            T3.Enabled = true;
            T4.Enabled = true;
            T5.Enabled = true;
            T6.Enabled = true;
            T7.Enabled = true;
            T8.Enabled = true;
            T9.Enabled = true;
            T1.Text = " ";
            T2.Text = " ";
            T3.Text = " ";
            T4.Text = " ";
            T5.Text = " ";
            T6.Text = " ";
            T7.Text = " ";
            T8.Text = " ";
            T9.Text = " ";
            Button_Reset.Visible = true;
            Label1.Visible = false;
            Label2.Visible = false;
            Label3.Visible = false;
            Label4.Visible = false;
            Label5.Visible = false;
            TextBox_name.Visible = false;
            Button_Add.Visible = false;
            HighScore.Visible = false;
            name.Visible = false;
           // User_Label.Visible = true;
           // Computer_Label.Visible = true;
        }

        protected void Reset_Event(object sender, EventArgs e)
        {
            T1.Visible = false;
            T2.Visible = false;
            T3.Visible = false;
            T4.Visible = false;
            T5.Visible = false;
            T6.Visible = false;
            T7.Visible = false;
            T8.Visible = false;
            T9.Visible = false;
            T1.Text = " ";
            T2.Text = " ";
            T3.Text = " ";
            T4.Text = " ";
            T5.Text = " ";
            T6.Text = " ";
            T7.Text = " ";
            T8.Text = " ";
            T9.Text = " ";
            count = 0;
            Label1.Visible = false;
            Label2.Visible = false;
            Label3.Visible = false;
            Label4.Visible = false;
            Label5.Visible = false;
            TextBox_name.Visible = false;
            Button_Add.Visible = false;
            HighScore.Visible = false;
            name.Visible = false;
            //User_Label.Visible = false;
            // Computer_Label.Visible = false;

        }

       
    }
}