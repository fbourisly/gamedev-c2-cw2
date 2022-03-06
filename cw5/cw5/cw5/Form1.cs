using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string characterName = "crash";
            string superPower1 = "flying";
            string superPower2 = "night vision";
            int age = 9;
            double speed = 70.5;
            double hight = 1.5;
            int power = 100;
            Console.WriteLine("My name is {0} , My super Powers are {1} , {2}, i'm {3} , My speed is {4} ", characterName, superPower1, superPower2, age, speed);

            //Console.WriteLine("My name is {0} , My super Powers are {1} , {2}, i'm {3} , My speed is {4} ",characterName, superPower1, superPower2, age, speed);


        int heroAge = 12;
        double heroHight = 7.5;
        string heroName = ("gonan");
        string heroSuperPower1 = ("fliyng");
        string heroSuperPower2 = ("night vision");
            int heroPower = 80;

        int ageDifference = heroAge - age;
            Console.WriteLine(ageDifference);

            void hightCheck()
            {
                if (heroHight > hight)
                {
                    Console.WriteLine("i am taller");
                }
                else if (heroHight < hight)
                {
                    Console.WriteLine("i am shorter");
                }

            }
            hightCheck();


            void powerCheck()
            {
                if (power > heroPower)
                {
                    Console.WriteLine("i am stronger");
                }
                else if (power < heroPower)
                {
                    Console.WriteLine("no i am stronger ");
                }

            }
            powerCheck();

        }

       
    }
}
