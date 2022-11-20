using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Microsoft.VisualBasic;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Bitmap[] pic = { WindowsFormsApp1.Properties.Resources.hangman1, WindowsFormsApp1.Properties.Resources.hangman4 };

        static int count = 3;
        bool y, z;
        string input,content;
        string a = "APPLE";
        string b = "DHAKA";
        string c = "ABSURD";
        string d = "AWKWARD";
        string e = "LARYNX";
        string f = "SKRETCH";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Dispose();
            this.textBox1.Location = new System.Drawing.Point(43, 213);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(470, 22);
            this.textBox1.TabIndex = 3;
        
            play();
           
        }

      

        public void play()
        {
            label1.Text = "A red fruit and have 5 letters: ";//Apple
            content = Interaction.InputBox("A red fruit and have 5 letters: :", "HANGMAN", "Type answer here", 500, 300);
            textBox1.Text = content;
            content = content.ToUpper();
           y= result(content);
            while (y == false)
            {
                count--;
                if (count == 0)
                {
                    break;
                }
                else
                {
                    MessageBox.Show("Wrong ans " + count + " chance left");
                    content = Interaction.InputBox("A red fruit and have 5 letters: ", "HANGMAN", "Type answer here", 500, 300);
                    textBox1.Text = content;
                    content = content.ToUpper();
                    y = result(content);
                }
            }
            if (count == 0)
            {

            }
            else
            {
                label1.Text = "Capital of Bangladesh and have 5 letters: ";//Dhaka
                content = Interaction.InputBox("Capital of Bangladesh and have 5 letters: ", "HANGMAN", "Type answer here", 500, 300);
                textBox1.Text = content;
                content = content.ToUpper();
                y = result(content);
                while (y == false)
                {
                    count--;
                    if (count == 0)
                        break;
                    else
                    {
                        MessageBox.Show("Wrong ans " + count + " chance left");
                        content = Interaction.InputBox("Capital of Bangladesh and have 5 letters: ", "HANGMAN", "Type answer here", 500, 300);
                        textBox1.Text = content;
                        content = content.ToUpper();
                        y = result(content);

                    }
                }

            }
            if (count == 0)
            {

            }
            else
            {
                label1.Text = "Doing something not logical and 6 letters: ";//absurd
                content = Interaction.InputBox("Doing something not logical and 6 letters:  ", "HANGMAN", "Type answer here", 500, 300);
                textBox1.Text = content;
                content = content.ToUpper();
                y = result(content);
                while (y == false)
                {
                    count--;
                    if (count == 0)
                        break;
                    else
                    {
                        MessageBox.Show("Wrong ans " + count + " chance left");
                        content = Interaction.InputBox("Doing something not logical and 6 letters:  ", "HANGMAN", "Type answer here", 500, 300);
                        textBox1.Text = content;
                        content = content.ToUpper();
                        y = result(content);

                    }
                }
            }
            if (count == 0)
            {

            }
            else
            {
                label1.Text = "Feeling uncomfortable and 7 letters: _ _ _ _ _ _ _ ";//awkward
                content = Interaction.InputBox("Feeling uncomfortable and 7 letters: _ _ _ _ _ _ _  ", "HANGMAN", "Type answer here", 500, 300);
                textBox1.Text = content;
                content = content.ToUpper();
                y = result(content);
                while (y == false)
                {
                    count--;
                    if (count == 0)
                        break;
                    else
                    {
                        MessageBox.Show("Wrong ans " + count + " chance left");
                        content = Interaction.InputBox("Feeling uncomfortable and 7 letters: _ _ _ _ _ _ _  ", "HANGMAN", "Type answer here", 500, 300);
                        textBox1.Text = content;
                        content = content.ToUpper();
                        y = result(content);

                    }
                }

            }
            if (count == 0)
            {

            }
            else
            {
                label1.Text = "Making a plan to do something bad and length of 6 ";//larynx
                content = Interaction.InputBox("Making a plan to do something bad and length og 6 ", "HANGMAN", "Type answer here", 500, 300);
                textBox1.Text = content;
                content = content.ToUpper();
                y = result(content);
                while (y == false)
                {
                    count--;
                    if (count == 0)
                        break;
                    else
                    {
                        MessageBox.Show("Wrong ans " + count + " chance left");
                        content = Interaction.InputBox("Making a plan to do something bad and length of 6 ", "HANGMAN", "Type answer here", 500, 300);
                        textBox1.Text = content;
                        content = content.ToUpper();
                        y = result(content);

                    }
                }

            }
            if (count == 0)
            {

            }
            else
            {
                label1.Text = "Making something big:";//stretch
                content = Interaction.InputBox("Making something big: ", "HANGMAN", "Type answer here", 500, 300);
                textBox1.Text = content;
                content = content.ToUpper();
                y = result(content);
                while (y == false)
                {
                    count--;
                    if (count == 0)
                        break;
                    else
                    {
                        MessageBox.Show("Wrong ans "+count+" chance left");
                        content = Interaction.InputBox("Making something big:", "HANGMAN", "Type answer here", 500, 300);
                        textBox1.Text = content;
                        content = content.ToUpper();
                        y = result(content);

                    }
                }
        }
            if (count == 0)
            {
                label1.Text = "You lost the game!!";
                pictureBox1.Image = pic[1];
            }
            else
            {
                label1.Text = "Congratulations!!!!!";
                MessageBox.Show("You Won!!!");
                pictureBox1.Image = pic[0];
            }

    }
        public Boolean result(string n)
        {
            if (n == a)
            {
                return true;
            }
            else if (n == b)
                return true;
            else if (n == c)
                return true;
            else if (n == d)
                return true;
            else if (n == e)
                return true;
            else if (n == f)
                return true;
            else
                return false;

        }
    }
    
    }






