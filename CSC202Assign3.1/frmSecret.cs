using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC202Assign3._1
{
    public partial class frmSecret : Form
    {
        public frmSecret()
        {
            InitializeComponent();
        }

        // create a variable to hold the file name for the secret file
        private string fileName = "Secret.txt";

       


        // fuction to close the form
        private void closeNewForm()
        {
            // create a new instance of the Geckos form 
            Geckos frmGeckos = new Geckos();

            // open the Geckos form file operations form as a dialog
            frmGeckos.Show();

            // create a cute message about leaving the secret form
            MessageBox.Show("You are leaving the secret form. Goodbye!");

            // close the current form frmSecret form
            this.Close();
        }

        // fucction to write the data to a file
        private void writeToFile()
        {
            // check if the txtImput text box is empty by using a try catch block
            try
            {
                // check if the cbOverwrite checkbox is checked- if it is, overwrite the file, if not, append to the file              
                if (cbOverride.Checked)
                {
                    // ust the File.WriteAllText method to write the contents of the txtImput text box to the file
                    File.WriteAllText(fileName, txbName.Text);
                }
                else
                {
                    // append the contents of the txtImput text box to the file
                    File.AppendAllText(fileName, "\n" + txbName.Text);
                }
            }
            catch (Exception ex)
            {
                // if an error occurs, display a message box with the error message
                MessageBox.Show("An error occurred while writing to the file: " + ex.Message);
            }
        }

        // function to read the data from the file
        private void readFromFile()
        {
            // create a try catch block to catch any exceptions that may occur
            try
            {
                // check if the file exists by using the File.Exists method
                if (File.Exists(fileName))
                {
                    lblContents.Text = File.ReadAllText(fileName);
                }
                else
                {
                    // if the file does not exist, display a message box
                    MessageBox.Show("The file does not exist.");
                }
            }
            // catch any exceptions that may occur
            catch (Exception ex)
            {
                // if an error occurs, display a message box with the error message
                MessageBox.Show("An error occurred while reading from the file: " + ex.Message);
            }
        }

        // function to get the name of the player and display it with a cute message
        private void cuteMessage()
        {
            // get the name of the player from the playerName variable and display it in a lblDance label
            lblDance.Text = "Hello! ! I hope you enjoy Tom the dancing gecko!";
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            // call the function to close the form
            closeNewForm();
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            // call the function to write the data to the file
            writeToFile();
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            // call the function to read the data from the file
            readFromFile();
        }

        private void btnPressMe_Click(object sender, EventArgs e)
        {
            // call the function to get the name of the player and display it with a cute message
            cuteMessage();
        }
    }
}
