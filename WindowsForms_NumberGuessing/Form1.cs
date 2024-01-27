using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

//Windows Form connected to WCF SOAP service for Number Guessing Game
namespace WindowsForms_NumberGuessing
{
    public partial class Form1 : Form
    {
        public static int secretNumber;             //variable to save the state of generated secret number
        public static bool GeneratedSecret=false;   //variable to define if a secret number has been generated
        public static int counter = 0;              //variable to keep track of guessing attempts
        public static bool winner = false;          //variable to define if user has won
        public Form1()
        {
            InitializeComponent();
            //initializing labels' visibility in the application
            lbl_secret_confirmation.Visible = false;
            lbl_number.Visible = false;
            lblwarningempty_secret.Visible = false;
            lblwarning.Visible= false;
            lblwinner.Visible = false;
            lbl_attempts.Text= counter.ToString();
            lbl_attempts.Visible = true;
        }

        private void btn_GenerateSN_Click(object sender, EventArgs e)
        {
            //Initializing state of labels
            lblwarningul.Visible = false;
            lblwarningll.Visible = false;
            lblwarning.Visible = false;
            //Creating the proxy to the service
            NumberGuessing_ServiceReference1.Service1Client myProxy = new NumberGuessing_ServiceReference1.Service1Client();
            //capturing inputs from user for lower and upper limits
            int lower = Int32.Parse(txt_ll.Text);
            int upper = Int32.Parse(txt_ul.Text);
            //Calling the service and saving response to a variable
            secretNumber = myProxy.SecretNumber(lower, upper); //saving state in a static variable
            //lbl_secret.Text = secretNumber.ToString(); 
            lbl_secret_confirmation.Text = "The secret number has been generated"; //Display of secret number generation confirmation
            lbl_secret_confirmation.Visible = true;
            lblwarningempty_secret.Visible = false;
            txt_ll.Text = "";
            txt_ul.Text = "";
            GeneratedSecret = true; //set status of generation of secret number in boolean variable
               
        }

        //Comparing guess number vs secret number
        private void btn_Play_Click(object sender, EventArgs e)
        {
            //initialization of labels' visibility
            lbl_secret_confirmation.Visible = false;
            lblwarningguess.Visible = false;
            counter++; //increasing variable to define number of attempts
            NumberGuessing_ServiceReference1.Service1Client myProxy = new NumberGuessing_ServiceReference1.Service1Client(); //creating proxy to the service
            lbl_attempts.Text = counter.ToString(); //displaying number of attempts 
            lbl_attempts.Visible = true;
            int guessNumber = Int32.Parse(txt_guess.Text);
            lbl_number.Text = myProxy.checkNumber(guessNumber, secretNumber); //calling the checkNumber operation of the service
            lbl_number.Visible = true;
            if(lbl_number.Text=="correct") //when the user has guessed the number
            {
                lblwinner.Text = "You Won!";
                lblwinner.Visible = true;
                btn_PlayAgain.Visible = true;
                GeneratedSecret = false;
                btn_GenerateSN.Enabled = false; //Disable button
                btn_Play.Enabled = false; //Disable button
                winner = true;
                lblwarningempty_guess.Visible = false;
            }
            //txt_guess.Text = "";
            

        }

        //validation of inputs to enable Generate Secret Number Button
        private void ValidateTextBoxes_GenerateSecret()
        {
            
            if(txt_ll.Text.Length > 0 && txt_ul.Text.Length >0) //checking if there is an input available
            {
                if (Regex.IsMatch(txt_ll.Text, "-?\\d+"))  //checking if lower limit input is an integer
                {
                    if(Regex.IsMatch(txt_ul.Text, "-?\\d+")) //checking if uper limit input is an integer
                    {
                       
                        if(Int32.Parse(txt_ll.Text) < Int32.Parse(txt_ul.Text)) //checking that upper limit is a larger number than lower limit
                        {
                            lblwarningempty_secret.Visible= false;
                            lblwarning.Visible = false;
                            lblwarningll.Visible = false;
                            lblwarningul.Visible = false;
                            btn_GenerateSN.Enabled = true; //if all the conditions are met, then enable generate Secret Number Button
                        }
                        else
                        {
                            lblwarning.Text = "Upper limit should be greater than Lower Limit";
                            lblwarning.Visible = true;
                            btn_GenerateSN.Enabled = false;
                        }
                        

                    }
                    else
                    {
                        lblwarningul.Text = "Please enter a valid integer";
                        lblwarningul.Visible = true;
                    }
                }
                else
                {
                    lblwarningll.Text = "Please enter a valid integer";
                    lblwarningll.Visible = true;
                }
            }
           
        }
        //Validate textbox input on text changes
        private void txt_ll_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes_GenerateSecret();
        }

        private void txt_ul_TextChanged(object sender, EventArgs e)
        {
                ValidateTextBoxes_GenerateSecret();
        }

        //Validate guess number input to enable play button
        private void ValidateTextBox_Play()
        {
            if(GeneratedSecret) //checking that a secret number already exists, so there is a valid number to guess
            { 
                if (txt_guess.Text.Length > 0) //checking that a input has been received
                {
                    if ((Regex.IsMatch(txt_guess.Text, "-?\\d+"))) //checking that guess number is an integer
                    {
                        btn_Play.Enabled = true; //enable play button
                        
                    }
                    else
                    {
                        lblwarningll.Text = "Please enter a valid integer number";
                        lblwarningll.Visible = true;
                    }
                }
                //else
               // {
                 //   lblwarningempty_guess.Text = "Please enter your guess";
                 //   lblwarningempty_guess.Visible = true;
                    
                    
               // }
            }
            else
            {
                btn_Play.Enabled = false;
            }
        }

        //calling of validation method on text changes
        private void txt_guess_TextChanged(object sender, EventArgs e)
        {
            if(!winner)
            {
                ValidateTextBox_Play();
            }
            
        }

        //Exit Game button
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();//close app
        }

        //Play Again Button after the user has won
        private void btn_PlayAgain_Click(object sender, EventArgs e)
        {
            //initialization of labels and variables
            winner = false;
            GeneratedSecret = false;
            counter = 0;
            lbl_attempts.Text = counter.ToString();
            lbl_attempts.Visible = true;
            lbl_number.Visible = false;
            lblwinner.Visible = false;
            btn_PlayAgain.Visible = false;
            txt_guess.Text = "";
           
        }
    }
}
