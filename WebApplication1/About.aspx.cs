using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //Lesson_1();
            //Lesson_2();
            Lesson_3();
            Lesson_4();
        }

        protected void Lesson_1()
        {
            
            StringBuilder text1 = new StringBuilder();
            StringBuilder text2 = new StringBuilder();

            string IC = txtIC.Text;

            string[] ch = new string[IC.Length];
            string[] name = new string[IC.Length];

            for (int i = 0; i < IC.Length; i++)
            {
                ch[i] = IC[i].ToString();
            }

            for (int i = 0; i < IC.Length - 1; i++)
            {
                string front = ch[i].ToString();
                string back = ch[i + 1].ToString();

                if (front == "0")
                {
                    front = ch[i + 1].ToString();
                }
                if (back == "0")
                {
                    back = ch[i].ToString();
                }
                string comb = front + back;

                text1.Append(comb);
                text1.Append(" ");

                string value = Dict_1(comb);

                if (value == "D" && i > 0)
                {
                    value = value.Replace("D", name[0]);
                }
                else
                {
                    name[0] = value;
                }

                string value_1 = Dict_2(value);

                text2.Append(value_1);
                text2.Append(" ");
            }

            Name.Text = text1.ToString();
            Age.Text = text2.ToString();
        }


        protected void Lesson_2()
        {
            StringBuilder text1 = new StringBuilder();
            StringBuilder text2 = new StringBuilder();
            StringBuilder text3 = new StringBuilder();

            string IC = txtIC.Text.Trim();
            string[] ch = new string[IC.Length];
            string[] name = new string[IC.Length];

            string value = "";

            int age_value = 13;

            for (int i = 0; i < IC.Length; i++)
            {
                ch[i] = IC[i].ToString();
            }
            for (int i = 0; i < IC.Length - 1; i++)
            {
                string front = ch[i].ToString();
                string back = ch[i + 1].ToString();
                string mid = "";

                if (front == "0" || front == "5")
                {
                    if(front == "5")
                    {
                        mid = "^";
                    }

                    front = ch[i + 1].ToString();
                }

                if (back == "0" || back == "5")
                {
                    if(back == "5")
                    {
                        if ((i + 2) < IC.Length)
                        {
                            back = ch[i + 2].ToString();
                        }
                        else
                        {
                            mid = "^";
                            back = ch[i - 1].ToString();
                        }

                    }
                    else
                        back = ch[i].ToString();
                }

                string comb = front + back + mid;

                if(comb.Contains("^"))
                {
                    comb = "^";
                }
                else
                {
                    comb = front + back;
                }

                text1.Append(comb);
                text1.Append("  ");
 
                value = Dict_1(comb);

                if (value == "D" && i > 0)
                {
                    value = value.Replace("D", name[0]);
                }
                else
                {
                    name[0] = value;
                }

                string value_1 = Dict_2(value);

                text2.Append(value_1);
                text2.Append("  ");

                text3.Append(age_value);
                text3.Append(" ");
                age_value = age_value + 5;
            }


            IC_1.Text = text1.ToString();
            Name_1.Text = text2.ToString();
            Age_1.Text = text3.ToString();
        }


        protected void Lesson_3()
        {
            StringBuilder text1 = new StringBuilder();
            StringBuilder text2 = new StringBuilder();
            StringBuilder text3 = new StringBuilder();

            var count = ;

            string IC = txtIC.ToString().Replace("159", "19x19").Replace("951", "91x91").Replace("15951", "19x191x91").Replace("95159", "91x919x19");

            //string IC = txtIC.Text.Replace(" ", "").Replace("159", "19x19").Replace("951", "91x91").Replace("15951", "19x191x91").Replace("95159", "91x919x19");
            string[] ch = new string[IC.Length];
            string[] name = new string[IC.Length];

            string value = "";

            int age_value = 13;

            for (int i = 0; i < IC.Length; i++)
            {
                ch[i] = IC[i].ToString();
            }
            
            for (int i = 0; i < IC.Length - 1; i++)
            {
                string comb = "";
                string front = ch[i].ToString();
                string back = ch[i + 1].ToString();
                string mid = "";

                if (front == "0" && back == "0")
                {
                    comb = front + back;

                    text3.Append(age_value);
                    text3.Append(" ");
                    age_value = age_value + 5;
                }
                else if(front == "x" || back == "x")
                {
                    if (front == "x")
                    {
                        ch[i] = ch[i].ToString().Replace("x", ch[i - 1]);
                        front = ch[i].ToString();
                        text3.Append("0 ");
                        i++;
                    }
                    else
                    {
                        ch[i + 1] = ch[i + 1].ToString().Replace("x", ch[i + 2]);
                        back = ch[i + 1].ToString();
                        text3.Append("0 ");
                        i++;
                    }

                    for (int a = 0; a < IC.Length - i; a++)
                    {
                        ch[a] = IC[a].ToString().Replace("x", "");
                    }
                }
                else
                {
                    if (front == "0" || front == "5")
                    {
                        if (front == "0")
                        {
                            if (back == "5")
                            {
                                front = ch[i].ToString();
                            }
                            else
                                front = ch[i + 1].ToString();
                        }
                        else if (front == "5")
                        {
                            mid = "^";
                        }
                        else
                            front = ch[i + 1].ToString();

                    }

                    if (back == "0" || back == "5")
                    {
                        if (back == "5")
                        {
                            if (front == "5" && back == "5")
                            {
                                comb = "^";
                            }
                            else if ((i + 2) < IC.Length)
                            {
                                back = ch[i + 2].ToString();
                                if (back == "5")
                                {
                                    mid = "^";
                                }
                                else if (back == "0")
                                {
                                    if(front != "0")
                                    {
                                        back = ch[i].ToString();
                                    }
                                    else
                                        back = "0";
                                }

                                
                            }
                            else
                            {
                                mid = "^";
                                back = ch[i - 1].ToString();
                            }

                        }
                        else
                            back = ch[i].ToString();
                    }

                    comb = front + back + mid;

                    text3.Append(age_value);
                    text3.Append(" ");
                    age_value = age_value + 5;
                    
                }
                
                if (comb.Contains("^"))
                {
                    comb = "^";
                }
                else
                {
                    comb = front + back;
                }

                text1.Append(comb);
                text1.Append("  ");

                value = Dict_1(comb);

                if (value == "D" && i > 0 && comb != "00" && value == "^")
                {
                    value = value.Replace("D", name[0]);
                }
                else
                {
                    name[0] = value;
                }

                string value_1 = Dict_2(value);

                text2.Append(value_1);
                text2.Append("  ");
            }

            IC_3.Text = text1.ToString();
            Name_3.Text = text2.ToString();
            Age_3.Text = text3.ToString();
        }


        protected void Lesson_4()
        {
            StringBuilder text1 = new StringBuilder();

            string IC = txtIC.Text;
            string[] ch = new string[IC.Length];

            for (int i = 0; i < IC.Length; i++)
            {
                ch[i] = IC[i].ToString();
            }

            for (int i = 0; i < IC.Length; i++)
            {
                string word_1 = ch[i].ToString();
                string word_2 = ch[i + 1].ToString();
                string word_3 = ch[i + 2].ToString();
                string king = word_1 + word_2 + word_3;

                switch (king)
                {
                    case "160":
                        text1.Append(king);
                        break;

                    case "161":
                        text1.Append(king);
                        break;

                    case "165":
                        text1.Append(king);
                        break;

                    case "166":
                        text1.Append(king);
                        break;

                    case "610":
                        text1.Append(king);
                        break;

                    case "611":
                        text1.Append(king);
                        break;

                    case "615":
                        text1.Append(king);
                        break;

                    case "616":
                        text1.Append(king);
                        break;
                }

                i += 3;
                //if (king.Contains("160") || king.Contains("161") || king.Contains("165") || king.Contains("166") ||
                //    king.Contains("610") || king.Contains("611") || king.Contains("615") || king.Contains("616"))
                //{
                //}
            }

            No_4.Text = text1.ToString();

        }

        #region Dic
        public static string Dict_1(string key)
        {
            string value_num = "";

            var Dic_1 = new Dictionary<string, string>()
            {
                {"14", "A" }, {"28", "A" }, {"39", "A" }, {"67", "A" }, {"41", "A" }, {"82", "A" }, {"93", "A" }, {"76", "A" },
                {"13", "B" }, {"27", "B" }, {"49", "B" }, {"68", "B" }, {"31", "B" }, {"72", "B" }, {"94", "B" }, {"86", "B" },
                {"19", "C" }, {"26", "C" }, {"34", "C" }, {"78", "C" }, {"91", "C" }, {"62", "C" }, {"43", "C" }, {"87", "C" },
                {"11", "D" }, {"22", "D" }, {"33", "D" }, {"44", "D" }, {"66", "D" }, {"77", "D" }, {"88", "D" }, {"99", "D" }, {"00", "D" },
                {"12", "E" }, {"37", "E" }, {"48", "E" }, {"69", "E" }, {"21", "E" }, {"73", "E" }, {"84", "E" }, {"96", "E" },
                {"17", "F" }, {"23", "F" }, {"46", "F" }, {"89", "F" }, {"71", "F" }, {"32", "F" }, {"64", "F" }, {"98", "F" },
                {"16", "G" }, {"29", "G" }, {"38", "G" }, {"47", "G" }, {"61", "G" }, {"92", "G" }, {"83", "G" }, {"74", "G" },
                {"18", "H" }, {"24", "H" }, {"36", "H" }, {"79", "H" }, {"81", "H" }, {"42", "H" }, {"63", "H" }, {"97", "H" },
                {"^", "^" }
            };

            value_num = Dic_1[key];

            return value_num;
        }

        public static string Dict_2(string key)
        {
            string value_num = "";

            var Dic_2 = new Dictionary<string, string>()
            {
                { "A", "生" },
                { "B", "天" },
                { "C", "延" },
                { "D", "伏" },
                { "E", "绝" },
                { "F", "祸" },
                { "G", "六" },
                { "H", "五" },
                { "^", "^" }
            };

            value_num = Dic_2[key];

            return value_num;
        }

        #endregion
    }


}