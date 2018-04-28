using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComputerLibrary.Computer[] ComputerArray = new ComputerLibrary.Computer[13];
            ComputerLibrary.Motherboard MyMotherboard = new ComputerLibrary.Motherboard();
            ComputerLibrary.CPU MyCPU = new ComputerLibrary.CPU();
            ComputerLibrary.SoundCard MySoundCard = new ComputerLibrary.SoundCard();
            ComputerLibrary.VideoCard MyVideoCard = new ComputerLibrary.VideoCard();
            ComputerLibrary.CDROM MyCDROM = new ComputerLibrary.CDROM();
            ComputerLibrary.CDRW MyCDRW = new ComputerLibrary.CDRW();
            ComputerLibrary.HDD MyHDD = new ComputerLibrary.HDD();
            ComputerLibrary.Floppy MyFloppy = new ComputerLibrary.Floppy();
            ComputerLibrary.Case MyCase = new ComputerLibrary.Case();
            ComputerLibrary.NetworkCard MyNetworkCard = new ComputerLibrary.NetworkCard();
            ComputerLibrary.keyboard Mykeyboard = new ComputerLibrary.keyboard();
            ComputerLibrary.Mouse MyMouse = new ComputerLibrary.Mouse();
            ComputerLibrary.Monitor MyMonitor = new ComputerLibrary.Monitor();


            //demonstrating casting children to their father (or grandfather)
            // or some upstream object
            ComputerArray[0] = MyMotherboard;
            ComputerArray[1] = MyCPU;
            ComputerArray[2] = MySoundCard;
            ComputerArray[3] = MyVideoCard;
            ComputerArray[4] = MyCDROM;
            ComputerArray[5] = MyCDRW;
            ComputerArray[6] = MyHDD;
            ComputerArray[7] = MyFloppy;
            ComputerArray[8] = MyCase;
            ComputerArray[9] = MyNetworkCard;
            ComputerArray[10] = Mykeyboard;
            ComputerArray[11] = MyMouse;
            ComputerArray[12] = MyMonitor;

            // Demonstrating Dynamic Binding 
            int Total = 0;
            for (int i = 0; i < 13; i++)
            {
                richTextBox1.Text = richTextBox1.Text + "Brand: " + ComputerArray[i].GetBrand() + "\n" +
                                                        "Price: " + ComputerArray[i].GetPrice() + "\n";
                Total = Total + ComputerArray[i].GetPrice();                                                       
            }
            richTextBox1.Text = richTextBox1.Text + Total;            
        }
    }
 }

