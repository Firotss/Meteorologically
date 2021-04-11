using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meteorologically
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AcceptButton = button1; //бутона за търсене винаги активен, което позволява да натиснеш enter след написване(не винаги работи)
        }
        string support1 = "kelvin"; //стави по дефаулт таг за апито, заради който се получават различни мерни единици
        string support2 = "metric"; //същото, но горното за измерение на температура, а това за скорост на вятър

        private static string content; //25-30 ред за да могам да получавам информация в меню, която се сейфа тука на момент на изпращане
        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        private async void button1_Click(object sender, EventArgs e)  //това бутон за търсяне, пуска асинк таск
        {                                                            //(тоест може да има няколко запроса едновременно[лимит на апи- 60 на минута])
            await LoadPopularMovies();
        }
        private async Task<string> LoadPopularMovies() //самия асинк таск
        {
            string api = "8ce601d6df9255ee1b0aeee0203e1331"; //апи(взима се от сайта)
            string city = richTextBox1.Text; //получавам град, който въвел юзер
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&units={support1}&appid={api}";  //линк за запрос на апи
            string url2 = $"https://api.openweathermap.org/data/2.5/weather?q={city}&units={support2}&appid={api}";//обърни внимание на support1/2
            try   //пробва да изпълни запроса към апи, ако не става пише "Wrong City"  //апи има 3 вида изчеслителни системи
            {                                                                         //за да съчетавам различни мерни единици, трябват ми два url
                using (var client = new HttpClient())//получава http протокол        //прочети за инфо -https://openweathermap.org/weather-data
                {
                    var message = await client.GetAsync(url2); //сигурно изпраща заявка към приложение и получава някакъв месседж
                    message.EnsureSuccessStatusCode();        //това дори нямам идея какво прави, но лорд го исползваше
                    this.Content = await message.Content.ReadAsStringAsync(); //получава съобщение от апи
                    JObject json = JObject.Parse(this.Content);              //обработва съобщение и го превръща в json формат
                    double speed = (double)json["wind"]["speed"];           //взима от json параметр скорост на вятър и превръща в дабл
                                                                           //(до превръщане той е стринг)
                    message = await client.GetAsync(url);                 //(малко уточнение- json формат работи като дикшинари)
                    message.EnsureSuccessStatusCode();//52-54 същото което горе, само без взимане на параметри(това ще го правим в Menu.cs)
                    this.Content = await message.Content.ReadAsStringAsync();

                    richTextBox1.Text = ""; //маха написаното от юзер(инфо вече взехме, така че за удобство на юзер ричбокс става празен)

                    Menu menu = new Menu(support1, support2, speed); //това ооп(създаваме обект на меню, изпращайки различно инфо)
                    menu.Show(); //показваме самото меню на юзер
                }
            }
            catch (Exception)
            {
                richTextBox1.Text = "Wrong City"; //ако юзер неправилно въвел град, апи няма да работи, затова прехващаме грешка
            }
            return "";
        }

        private void mph_Click(object sender, EventArgs e)//при натискане на бутон miles/hour пуска тоя код
        {
            kph.Enabled = true;                             //Дава на юзер възможност да натисне на бутон km/hour
            kph.BackColor = System.Drawing.Color.Black;    //поставя черен цвят на бутон km/hour
            mph.Enabled = false;                          //изключва възможност на юзер да натисне бутон miles/hour
            mph.BackColor = System.Drawing.Color.White;  //сменя цват на същия бутон на бял
            support2 = "imperial";                      //това една от трите мерни единици в апи
        }
        private void kph_Click(object sender, EventArgs e)//това като миналия бутон, само тук всичко наобратно
        {
            kph.Enabled = false;
            kph.BackColor = System.Drawing.Color.White;
            mph.Enabled = true;
            mph.BackColor = System.Drawing.Color.Black;
            support2 = "metric";
        }
        private void celsius_Click(object sender, EventArgs e)//Това бутон за мерна единица на температура
        {                                                    //работи почти по същия начин, само че всички изключвания стават в таймер
            celsius.Enabled = false;                        //(можеш да го намериш малко по на долу)
            celsius.BackColor = System.Drawing.Color.White;
            support1 = "metric";
        }

        private void fahrenheit_Click(object sender, EventArgs e)//втори бутон за температура
        {
            fahrenheit.Enabled = false;
            fahrenheit.BackColor = System.Drawing.Color.White;
            support1 = "imperial";
        }

        private void kelvin_Click(object sender, EventArgs e)//трети
        {
            kelvin.Enabled = false;
            kelvin.BackColor = System.Drawing.Color.White;
            support1 = "kelvin";
        }
        private void check_Tick(object sender, EventArgs e)//таймер
        {                                       
            if(support1 != "kelvin") //проверява стойност на support1, включва бутона ако стойност не е равна на тая която той сетва
            {                       //(звучи малко сложно, ако не си разбрал, после ще питаш)
                kelvin.Enabled = true;
                kelvin.BackColor = System.Drawing.Color.Black;
            }
            if(support1 != "imperial")
            {
                fahrenheit.Enabled = true;
                fahrenheit.BackColor = System.Drawing.Color.Black;
            }
            if(support1 != "metric")
            {
                celsius.Enabled = true;
                celsius.BackColor = System.Drawing.Color.Black;
            }
        }
    }
}
