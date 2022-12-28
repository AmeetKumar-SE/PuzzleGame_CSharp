using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2_Lab7
{
    public partial class frmPuzzle : Form
    {
        Random obj = new Random();
        int value;
        int[] store_number = new int[17];
        int incorrect = 0;
        int correct = 0;
        int count = -1;
        int temp;
        int value2;
        int[] same_pic_number = new int[3];
      
        public frmPuzzle()
        {
            InitializeComponent();
        }

        
        private void frmPuzzle_Load(object sender, EventArgs e)
        {
            temp = obj.Next(1, 16);
            btnPic.Image = Image.FromFile(@"D:\\pic_directory\\" + temp + ".jpg");
            
            same_pic_number[0] = obj.Next(3, 18);

            value2 = obj.Next(3, 18);
            for (int i = 0; i < 2; i++)
            {

                if (value2 == same_pic_number[i])
                {
                    value2 = obj.Next(3, 18);
                }

            }
            same_pic_number[1] = value2;
            value2 = obj.Next(3, 18);

            for (int i = 0; i < 3; i++)
            {

                if (value2 == same_pic_number[i])
                {
                    value2 = obj.Next(3, 18);
                }

            }
            same_pic_number[2] = value2;
           

        }
        public void checkWinner()
        {

            for (int i = 0; i <= count; i++)
            {
                if (store_number[i] == temp)
                {
                    correct++;
                }
                else
                {
                    incorrect++;
                }
            }


            if (correct == 3)
            {
                MessageBox.Show("YOU WON");
                Application.Exit();
            }
            else if (incorrect == 3)
            {

                MessageBox.Show("You Lose");
                Application.Exit();
            }

            correct = 0;
            incorrect = 0;

        }

        public void checkNumbers()
        {
            for (int i = 0; i <= count; i++)
            {

                if (value == store_number[i] || value == temp)
                {

                    value = obj.Next(1, 17);
                    i = 0;

                }


            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            count++;
            if (same_pic_number[0] == 5 || same_pic_number[1] == 5 || same_pic_number[2] == 5)
            {
                store_number[count] = temp;
                button5.Image = Image.FromFile(@"D:\\pic_directory\\" + temp + ".jpg");

            }
            else
            {
                value = obj.Next(1, 17);
                checkNumbers();
                store_number[count] = value;
                button5.Image = Image.FromFile(@"D:\\pic_directory\\" + value + ".jpg");

            }
            checkWinner();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            count++;
            if (same_pic_number[0] == 3 || same_pic_number[1] == 3 || same_pic_number[2] == 3)
            {
                store_number[count] = temp;
                button3.Image = Image.FromFile(@"D:\\pic_directory\\" + temp + ".jpg");

            }
            else
            {
                value = obj.Next(1, 17);
                checkNumbers();
                store_number[count] = value;
                button3.Image = Image.FromFile(@"D:\\pic_directory\\" + value + ".jpg");

            }
            checkWinner();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            count++;
            if (same_pic_number[0] == 4 || same_pic_number[1] == 4 || same_pic_number[2] == 4)
            {
                store_number[count] = temp;
                button4.Image = Image.FromFile(@"D:\\pic_directory\\" + temp + ".jpg");

            }
            else
            {
                value = obj.Next(1, 17);
                checkNumbers();
                store_number[count] = value;
                button4.Image = Image.FromFile(@"D:\\pic_directory\\" + value + ".jpg");
            }
            checkWinner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            count++;
            if (same_pic_number[0] == 6 || same_pic_number[1] == 6 || same_pic_number[2] == 6)
            {
                store_number[count] = temp;
                button6.Image = Image.FromFile(@"D:\\pic_directory\\" + temp + ".jpg");

            }
            else
            {
                value = obj.Next(1, 17);
                checkNumbers();
                store_number[count] = value;
                button6.Image = Image.FromFile(@"D:\\pic_directory\\" + value + ".jpg");
            }
            checkWinner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            count++;
            if (same_pic_number[0] == 7 || same_pic_number[1] == 7 || same_pic_number[2] == 7)
            {
                store_number[count] = temp;
                button7.Image = Image.FromFile(@"D:\\pic_directory\\" + temp + ".jpg");

            }
            else
            {
                value = obj.Next(1, 17);
                checkNumbers();
                store_number[count] = value;
                button7.Image = Image.FromFile(@"D:\\pic_directory\\" + value + ".jpg");
            }
            checkWinner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            count++;
            if (same_pic_number[0] == 8 || same_pic_number[1] == 8 || same_pic_number[2] == 8)
            {
                store_number[count] = temp;
                button8.Image = Image.FromFile(@"D:\\pic_directory\\" + temp + ".jpg");

            }
            else
            {
                value = obj.Next(1, 17);
                checkNumbers();
                store_number[count] = value;
                button8.Image = Image.FromFile(@"D:\\pic_directory\\" + value + ".jpg");
            }
            checkWinner();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            count++;
            if (same_pic_number[0] == 9 || same_pic_number[1] == 9 || same_pic_number[2] == 9)
            {
                store_number[count] = temp;
                button9.Image = Image.FromFile(@"D:\\pic_directory\\" + temp + ".jpg");

            }
            else
            {
                value = obj.Next(1, 17);
                checkNumbers();
                store_number[count] = value;
                button9.Image = Image.FromFile(@"D:\\pic_directory\\" + value + ".jpg");
            }
            checkWinner();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            count++;
            if (same_pic_number[0] == 10 || same_pic_number[1] == 10 || same_pic_number[2] == 10)
            {
                store_number[count] = temp;
                button10.Image = Image.FromFile(@"D:\\pic_directory\\" + temp + ".jpg");

            }
            else
            {
                value = obj.Next(1, 17);
                checkNumbers();
                store_number[count] = value;
                button10.Image = Image.FromFile(@"D:\\pic_directory\\" + value + ".jpg");
            }
            checkWinner();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            count++;
            if (same_pic_number[0] == 11 || same_pic_number[1] == 11 || same_pic_number[2] == 11)
            {
                store_number[count] = temp;
                button11.Image = Image.FromFile(@"D:\\pic_directory\\" + temp + ".jpg");

            }
            else
            {
                value = obj.Next(1, 17);
                checkNumbers();
                store_number[count] = value;
                button11.Image = Image.FromFile(@"D:\\pic_directory\\" + value + ".jpg");
            }
            checkWinner();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            count++;
            if (same_pic_number[0] == 12 || same_pic_number[1] == 12 || same_pic_number[2] == 12)
            {
                store_number[count] = temp;
                button12.Image = Image.FromFile(@"D:\\pic_directory\\" + temp + ".jpg");

            }
            else
            {
                value = obj.Next(1, 17);
                checkNumbers();
                store_number[count] = value;
                button12.Image = Image.FromFile(@"D:\\pic_directory\\" + value + ".jpg");
            }
            checkWinner();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            count++;
            if (same_pic_number[0] == 13 || same_pic_number[1] == 13 || same_pic_number[2] == 13)
            {
                store_number[count] = temp;
                button13.Image = Image.FromFile(@"D:\\pic_directory\\" + temp + ".jpg");

            }
            else
            {
                value = obj.Next(1, 17);
                checkNumbers();
                store_number[count] = value;
                button13.Image = Image.FromFile(@"D:\\pic_directory\\" + value + ".jpg");
            }
            checkWinner();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            count++;
            if (same_pic_number[0] == 14 || same_pic_number[1] == 14 || same_pic_number[2] == 14)
            {
                store_number[count] = temp;
                button14.Image = Image.FromFile(@"D:\\pic_directory\\" + temp + ".jpg");

            }
            else
            {
                value = obj.Next(1, 17);
                checkNumbers();
                store_number[count] = value;
                button14.Image = Image.FromFile(@"D:\\pic_directory\\" + value + ".jpg");
            }
            checkWinner();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            count++;
            if (same_pic_number[0] == 15 || same_pic_number[1] == 15 || same_pic_number[2] == 15)
            {
                store_number[count] = temp;
                button15.Image = Image.FromFile(@"D:\\pic_directory\\" + temp + ".jpg");

            }
            else
            {
                value = obj.Next(1, 17);
                checkNumbers();
                store_number[count] = value;
                button15.Image = Image.FromFile(@"D:\\pic_directory\\" + value + ".jpg");
            }
            checkWinner();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            count++;
            if (same_pic_number[0] == 16 || same_pic_number[1] == 16 || same_pic_number[2] == 16)
            {
                store_number[count] = temp;
                button16.Image = Image.FromFile(@"D:\\pic_directory\\" + temp + ".jpg");

            }
            else
            {
                value = obj.Next(1, 17);
                checkNumbers();
                store_number[count] = value;
                button16.Image = Image.FromFile(@"D:\\pic_directory\\" + value + ".jpg");
            }
            checkWinner();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            count++;
            if (same_pic_number[0] == 17 || same_pic_number[1] == 17 || same_pic_number[2] == 17)
            {
                store_number[count] = temp;
                button17.Image = Image.FromFile(@"D:\\pic_directory\\" + temp + ".jpg");

            }
            else
            {
                value = obj.Next(1, 17);
                checkNumbers();
                store_number[count] = value;
                button17.Image = Image.FromFile(@"D:\\pic_directory\\" + value + ".jpg");
            }
            checkWinner();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            count++;
            if (same_pic_number[0] == 18 || same_pic_number[1] == 18 || same_pic_number[2] == 18)
            {
                store_number[count] = temp;
                button18.Image = Image.FromFile(@"D:\\pic_directory\\" + temp + ".jpg");

            }
            else
            {
                value = obj.Next(1, 17);
                checkNumbers();
                store_number[count] = value;
                button18.Image = Image.FromFile(@"D:\\pic_directory\\" + value + ".jpg");
            }
            checkWinner();
        }

     
    }
}
