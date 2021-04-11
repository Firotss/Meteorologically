using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meteorologically
{
    public partial class Menu : Form
    {
        string unit_temp;
        string wind_speed;
        double speed;
        public Menu(string support1,string support2, double speed) //това стойности, които сме получели от първия прозорец
        {
            InitializeComponent();
            this.unit_temp = support1; //сетваме ги тука на глобално, те да могат да се ползват в целия код
            this.wind_speed = support2;
            this.speed = speed;
        }
        private void Menu_Load(object sender, EventArgs e) //това зарежда при пускането на меню, а горе е конструктор 
        {
            Form1 form = new Form1(); //създава обект на първи прозорец
            JObject json = JObject.Parse(form.Content); //парсва съобщение получено от апи и го превръща в json формат

            string icon = (string)json["weather"][0]["icon"]; //както вече казах, json прилича на дикшинари, затова просто взимам нужни неща по име
            description.Text = json["weather"][0]["description"] +""; //сетвам текст на един от лейбли

            string sym = "K"; //температура да изглежда по красиво(пример: 15°C)
            if (unit_temp == "metric") //тук просто проверява саппорт2 да сложи подходящ символ
            {
                sym = "°C";
            }
            else if(unit_temp == "imperial")
            {
                sym = "°F";
            }

            string unit_speed = " miles/hour"; //съща тактика но за скорост на вятър
            if(wind_speed == "metric")
            {
                this.speed = Math.Round(this.speed * 3.6,2); //оригинална стойност в метри/секунда, затова я превръщаме в км/ч
                unit_speed = " km/hour";                    //мат раунд нужен задари переодични бъгвания
            }                                              //(понякога се случваше нещо подобно- 17,00000000000000000000000000000000000000001)

            wind_label.Text = speed + unit_speed; //сетвам лейбл
            humidity.Text = json["main"]["humidity"] + "%"; //и тук
            temperature.Text = json["main"]["temp"] +sym;  //и няма да повярваш, тук също!

            double timezone = ((double)json["timezone"])/3600; //получена стойност в секунди, затова деля на 3600, да получа часове
            if(timezone > 0) //това да изписва '+', ако числото положително
            {
                city_label.Text = json["name"] + " +" + timezone + "UTC";
            }
            else
            {
                city_label.Text = json["name"] + " " + timezone + "UTC";
            }

            string img = $"http://openweathermap.org/img/wn/{icon}@2x.png"; //слага картинка от линк, исползвайки специално id от апи
            pictureBox1.ImageLocation = (img);                             //и специален линк от сайта на апи
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;       //прави магии с пикчер(мисля че и сам си разбрал)
                                                                         //p.s но ако не, просто питай...
        }
    }
}
