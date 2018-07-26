using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MiniClashOfClans
{
    public partial class MiniCoC : Form
    {
        Timer timer = new Timer();
        //Timer timerBarb = new Timer();
        //Timer timerBarbUp = new Timer();
        //Timer timerArcherUp = new Timer();
        //Timer timerWBUp = new Timer();
        Village village = new Village();
        Barbarian barb = new Barbarian();
        Archer archer = new Archer();
        WallBreaker wb = new WallBreaker();

        public MiniCoC()
        {
            InitializeComponent();
        }

        private void MiniCoC_Load(object sender, EventArgs e)
        {
            //Barbarian barb = new Barbarian();
            //barb.LevelUp(2);

            //MessageBox.Show("Level: " + barb.Level + "\nDamage: " + barb.Damage + "\nHealth: " + barb.Health + "\nTraining Cost: " + barb.TrainCost);
            //barb.LevelUp(6);
            //archer.LevelUp(6);
            //wb.LevelUp(6);
            //village.BarbCount = 100;
            timer.Interval = 5000;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();

            display();
        }

       

        private void display()
        {
            //=========Train Tab==========
            //add button handler

            if (village.Resources >= barb.TrainCost && !village.IsFullArmy() && ((village.CurrentArmy + 1) <= village.ArmyCamp))
                button1.Enabled = true;
            else button1.Enabled = false;
            if (village.Resources >= archer.TrainCost && !village.IsFullArmy() && ((village.CurrentArmy + 1) <= village.ArmyCamp))
                button2.Enabled = true;
            else button2.Enabled = false;
            if (village.Resources >= wb.TrainCost && !village.IsFullArmy() && ((village.CurrentArmy + 2) <= village.ArmyCamp))
                button3.Enabled = true;
            else button3.Enabled = false;
            //remove button handler
            if (village.BarbCount>0)
                button4.Enabled = true;
            else button4.Enabled = false;
            if (village.ArcherCount > 0)
                button5.Enabled = true;
            else button5.Enabled = false;
            if (village.WBCount > 0)
                button6.Enabled = true;
            else button6.Enabled = false;

            //right pane
            txtBoxReso.Text = village.Resources.ToString();
            labelAc.Text = village.CurrentArmy.ToString() + "/" + village.ArmyCamp.ToString();
            label2.Text = "x " + village.BarbCount;
            label3.Text = "x " + village.ArcherCount;
            label4.Text = "x " + village.WBCount;

            //left pane
            labelBarb.Text = barb.Name + 
                "\nDamage: " + barb.Damage + 
                "\nHealth: " + barb.Health + 
                "\nTarget: " + barb.Target ;
            label11.Text = "Level: " + barb.Level +
                "\nTrain Cost:" + barb.TrainCost +
                "\nHousing Cost: " + barb.HousingCost +
                "\nTraining Time: " +  barb.TrainingTime;
            labelArcher.Text = archer.Name +
                "\nDamage: " + archer.Damage +
                "\nHealth: " + archer.Health +
                "\nTarget: " + archer.Target;
            label12.Text = "Level: " + archer.Level +
                "\nTrain Cost:" + archer.TrainCost +
                "\nHousing Cost: " + archer.HousingCost +
                "\nTraining Time: " + archer.TrainingTime;
            labelWB.Text = wb.Name +
                "\nDamage: " + wb.Damage +
                "\nHealth: " + wb.Health +
                "\nTarget: " + wb.Target;
            label13.Text = "Level: " + wb.Level +
                "\nTrain Cost:" + wb.TrainCost +
                "\nHousing Cost: " + wb.HousingCost +
                "\nTraining Time: " + wb.TrainingTime;

            //==========Research tab===========
            label5.Text = "Level: " + barb.Level + "\n" + barb.Name;
            label6.Text = "Level: " + archer.Level + "\n" + archer.Name;
            label7.Text = "Level: " + wb.Level + "\n" + wb.Name;

            label8.Text = 
                "Damage: " + barb.Damage +
                "\nHealth: " + barb.Health +
                "\nTraining Cost: " + barb.TrainCost;
           
            label9.Text = 
                "Damage: " + archer.Damage +
                "\nHealth: " + archer.Health +
                "\nTraining Cost: " + archer.TrainCost;
           
            label10.Text = 
                "Damage: " + wb.Damage +
                "\nHealth: " + wb.Health +
                "\nTraining Cost: " + wb.TrainCost;

            //upgrade buttons handler
            if (barb.Level >= 7)
                button7.Enabled = false;
            if (archer.Level >= 7)
                button8.Enabled = false;
            if (wb.Level >= 6)
                button9.Enabled = false;

            //upgrade previews
            //barb
            switch (barb.Level)
            {
                case 1:
                    label19.Text = "Level: " + (barb.Level+1) +
                       "\nDamage: " + barb.Damage + " " + "+ 3" +
                       "\nHealth: " + barb.Health + " " + "+ 9" + 
                        "\nTraining Cost: " + barb.TrainCost + " " + "+ 15";
                    break;
                case 2:
                    label19.Text = "Level: " + (barb.Level + 1) +
                       "\nDamage: " + barb.Damage + " " + "+ 3" +
                       "\nHealth: " + barb.Health + " " + "+ 11" +
                        "\nTraining Cost: " + barb.TrainCost + " " + "+ 20";
                    
                    break;
                case 3:
                    label19.Text = "Level: " + (barb.Level + 1) +
                       "\nDamage: " + barb.Damage + " " + "+ 4" +
                       "\nHealth: " + barb.Health + " " + "+ 13" +
                        "\nTraining Cost: " + barb.TrainCost + " " + "+ 40";
                    
                    break;
                case 4:
                    label19.Text = "Level: " + (barb.Level + 1) +
                       "\nDamage: " + barb.Damage + " " + "+ 5" +
                       "\nHealth: " + barb.Health + " " + "+ 17" +
                        "\nTraining Cost: " + barb.TrainCost + " " + "+ 50";
                    
                    break;
                case 5:
                    label19.Text = "Level: " + (barb.Level + 1) +
                       "\nDamage: " + barb.Damage + " " + "+ 3" +
                       "\nHealth: " + barb.Health + " " + "+ 15" +
                        "\nTraining Cost: " + barb.TrainCost + " " + "+ 50";
                    
                    break;
                case 6:
                    label19.Text = "Level: " + (barb.Level + 1) +
                       "\nDamage: " + barb.Damage + " " + "+ 4" +
                       "\nHealth: " + barb.Health + " " + "+ 15" +
                        "\nTraining Cost: " + barb.TrainCost + " " + "+ 50";
                    
                    break;
                case 7:
                    label19.Text = "\nLevel: Max ";
                    break;
                default:
                    break;
            }

            //archer
            switch (archer.Level)
            {
                case 1:
                    label17.Text = "Level: " + (archer.Level + 1) +
                       "\nDamage: " + archer.Damage + " " + "+ 2" +
                       "\nHealth: " + archer.Health + " " + "+ 3" +
                        "\nTraining Cost: " + archer.TrainCost + " " + "+ 30";
                    break;
                case 2:
                    label17.Text = "Level: " + (archer.Level + 1) +
                       "\nDamage: " + archer.Damage + " " + "+ 3" +
                       "\nHealth: " + archer.Health + " " + "+ 5" +
                        "\nTraining Cost: " + archer.TrainCost + " " + "+ 40";

                    break;
                case 3:
                    label17.Text = "Level: " + (archer.Level + 1) +
                       "\nDamage: " + archer.Damage + " " + "+ 4" +
                       "\nHealth: " + archer.Health + " " + "+ 5" +
                        "\nTraining Cost: " + archer.TrainCost + " " + "+ 80";

                    break;
                case 4:
                    label17.Text = "Level: " + (archer.Level + 1) +
                       "\nDamage: " + archer.Damage + " " + "+ 4" +
                       "\nHealth: " + archer.Health + " " + "+ 7" +
                        "\nTraining Cost: " + archer.TrainCost + " " + "+ 100";

                    break;
                case 5:
                    label17.Text = "Level: " + (archer.Level + 1) +
                       "\nDamage: " + archer.Damage + " " + "+ 2" +
                       "\nHealth: " + archer.Health + " " + "+ 4" +
                        "\nTraining Cost: " + archer.TrainCost + " " + "+ 100";

                    break;
                case 6:
                    label17.Text = "Level: " + (archer.Level + 1) +
                       "\nDamage: " + archer.Damage + " " + "+ 3" +
                       "\nHealth: " + archer.Health + " " + "+ 4" +
                        "\nTraining Cost: " + archer.TrainCost + " " + "+ 100";

                    break;
                case 7:
                    label17.Text = "\nLevel: Max ";
                    break;
                default:
                    break;
            }

            //walll breaker
            switch (wb.Level)
            {
                case 1:
                    label18.Text = "Level: " + (wb.Level + 1) +
                       "\nDamage: " + wb.Damage + " " + "+ 4" +
                       "\nHealth: " + wb.Health + " " + "+ 4" +
                        "\nTraining Cost: " + wb.TrainCost + " " + "+ 500";
                    break;
                case 2:
                    label18.Text = "Level: " + (wb.Level + 1) +
                       "\nDamage: " + wb.Damage + " " + "+ 8" +
                       "\nHealth: " + wb.Health + " " + "+ 5" +
                        "\nTraining Cost: " + wb.TrainCost + " " + "+ 500";

                    break;
                case 3:
                    label18.Text = "Level: " + (wb.Level + 1) +
                       "\nDamage: " + wb.Damage + " " + "+ 8" +
                       "\nHealth: " + wb.Health + " " + "+6" +
                        "\nTraining Cost: " + wb.TrainCost + " " + "+ 500";

                    break;
                case 4:
                    label18.Text = "Level: " + (wb.Level + 1) +
                       "\nDamage: " + wb.Damage + " " + "+ 14" +
                       "\nHealth: " + wb.Health + " " + "+ 7" +
                        "\nTraining Cost: " + wb.TrainCost + " " + "+ 500";

                    break;
                case 5:
                    label18.Text = "Level: " + (wb.Level + 1) +
                       "\nDamage: " + wb.Damage + " " + "+ 14" +
                       "\nHealth: " + wb.Health + " " + "+ 12" +
                        "\nTraining Cost: " + wb.TrainCost + " " + "+ 500";

                    break;
                case 6:
                    label18.Text = "\nLevel: Max ";
                    break;
                default:
                    break;
            }
            
        }

        

        

        //buttons and eventhandlers
        private void btnCollect_Click(object sender, EventArgs e)
        {
            btnCollect.Enabled = false;
            village.Resources += (1000*wb.Level);
            display();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnCollect.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //button1.Enabled = false;
            village.BarbCount++;
            village.Resources -= barb.TrainCost;
            display();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //button1.Enabled = true;
            village.BarbCount++;
            
            display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            village.ArcherCount++;
            village.Resources -= archer.TrainCost;
            display();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            village.WBCount++;
            village.Resources -= wb.TrainCost;
            display();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            village.BarbCount--;

            display();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            village.ArcherCount--;

            display();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            village.WBCount--;

            display();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //button7.Text = "Upgrading..";
            //button7.Enabled = false;
            //timerBarbUp.Interval = 10000;
            //timerBarbUp.Enabled = true;
            //timerBarbUp.Tick += new EventHandler(timer3_Tick);
            //timerBarbUp.Start();
            barb.LevelUp();
            display();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            //timerBarbUp.Stop();
            barb.LevelUp();
            button7.Text = "Upgrade";
            button7.Enabled = true;
            display();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //button8.Text = "Upgrading..";
            //button8.Enabled = false;
            //timerArcherUp.Interval = 10000;
            //timerArcherUp.Enabled = true;
            //timerArcherUp.Tick += new EventHandler(timer4_Tick);
            //timerArcherUp.Start();
            archer.LevelUp();
            display();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            //timerArcherUp.Stop();
            archer.LevelUp();
            button8.Text = "Upgrade";
            button8.Enabled = true;
            display();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //button9.Text = "Upgrading..";
            //button9.Enabled = false;
            //timerWBUp.Interval = 10000;
            //timerWBUp.Enabled = true;
            //timerWBUp.Tick += new EventHandler(timer5_Tick);
            //timerWBUp.Start();
            wb.LevelUp();
            display();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            //timerWBUp.Stop();
            wb.LevelUp();
            button9.Text = "Upgrade";
            button9.Enabled = true;
            display();
        }

    }
}
