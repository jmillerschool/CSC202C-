using System.Diagnostics.Eventing.Reader;

namespace CSC202Assign3._1
{
    public partial class Geckos : Form
    {
        // create an array of images to hold the gecko images and initialize it
        private Image[] images;
        public Geckos()
        {
            InitializeComponent();

            // initialize the array of images with the size of 10 to hold 10 gecko images
            images = new Image[10];


            // load the gecko images from the file in same directory as the project
            images[0] = Image.FromFile(@"G:\CSC202 C#\CSC202Assign3.1\Gecko10.JPG");
            images[1] = Image.FromFile(@"G:\CSC202 C#\CSC202Assign3.1\Gecko9.JPG");
            images[2] = Image.FromFile(@"G:\CSC202 C#\CSC202Assign3.1\Gecko8.JPG");
            images[3] = Image.FromFile(@"G:\CSC202 C#\CSC202Assign3.1\Gecko7.JPG");
            images[4] = Image.FromFile(@"G:\CSC202 C#\CSC202Assign3.1\Gecko6.JPG");
            images[5] = Image.FromFile(@"G:\CSC202 C#\CSC202Assign3.1\Gecko5.JPG");
            images[6] = Image.FromFile(@"G:\CSC202 C#\CSC202Assign3.1\Gecko4.JPG");
            images[7] = Image.FromFile(@"G:\CSC202 C#\CSC202Assign3.1\Gecko3.JPG");
            images[8] = Image.FromFile(@"G:\CSC202 C#\CSC202Assign3.1\Gecko2.JPG");
            images[9] = Image.FromFile(@"G:\CSC202 C#\CSC202Assign3.1\Gecko1.JPG");
        }

        // fuction to clear picture boxes
        private void clearPictureBoxes()
        {
            // clear the picture boxes 
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
        }

        // function to clear the labels
        private void clearLabels()
        {
            // clear the labels
            lblName1.Visible = false;
            lblName2.Visible = false;
            lblName3.Visible = false;
            lblName4.Visible = false;
            lblName5.Visible = false;
            lblName6.Visible = false;
            lblName7.Visible = false;
            lblName8.Visible = false;
            lblName9.Visible = false;
            lblName10.Visible = false;
        }

        // function to open new form
        private void openNewForm()
        {
            // vreate a new instance of the form and show it
            frmSecret frmSec = new frmSecret();

            // open the new form as a dialog box
            frmSec.ShowDialog();

            // hide the current form
            this.Hide();

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // create a try catch block to handle any exceptions that may occur
            try
            {
                // call my clearPictureBoxes function to clear the picture boxes
                clearPictureBoxes();

                // call my clearLabels function to clear the labels
                clearLabels();

                // create a variable to hold the user input
                string sUserInput = txtPlayersNum.Text;

                // check if the user input is empty or not a number
                if (int.TryParse(sUserInput, out int iUserInput))
                {
                    // use a for loop to iterate through the array of images and display the gecko images in the picture boxes
                    // for example, if the user input is 5, the first 5 picture boxes will display the gecko images
                    if (iUserInput >= 1 && iUserInput <= 10)
                    {
                        for (int i = 0; i < iUserInput; i++)
                        {
                            // using the array of images and the picture boxes 1 -10 to display the gecko images
                            PictureBox pictureBox = (PictureBox)this.Controls["pictureBox" + (i + 1).ToString()];

                            //uing the stetchImage value will make the image fit the picture box
                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                            // set the image of the picture box to the corresponding gecko image from the array
                            pictureBox.Image = images[i];

                            // make the picture box visible
                            pictureBox.Visible = true;

                            // create an array to hold the name of the geckos in the lblName label
                            string[] namesOfGeckos = { "Arrow(F)", "Tom(F)", "Oreyellow(F)", "Sunny(M)", "Velvet(F)", "Red(M)", "Pearl(F)", "Scout(M)", "Roadkill(F)", "Titan(M)" };

                            // set the name of the gecko in the corresponding label (lblName1 - lblName10)
                            Label lblName = (Label)this.Controls["lblName" + (i + 1).ToString()];

                            // set the text of the label to the corresponding gecko name from the names array
                            lblName.Text = namesOfGeckos[i];

                            // make the label visible so that the name of the gecko is displayed
                            lblName.Visible = true;
                        }
                    }
                    else
                    {
                        // show a message box if the user input is not between 1 and 10
                        MessageBox.Show("Please enter a number between 1 and 10.", "Input Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    // clear the existing picture boxes from the form to avoid duplicates
                    txtPlayersNum.Clear();
                }
            }
            // create a catch block to handle any exceptions that may occur
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClickMe_Click(object sender, EventArgs e)
        {
            // call the openNewForm function to open the new form
            openNewForm();
        }







        private void lblInstructions_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPlayersNum_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
