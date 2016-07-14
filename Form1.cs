using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Name_Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadBoyNames(List<string> boysList)
        {
            try
            {
                // Open the BoyNames.txt file.
                StreamReader inputFile = File.OpenText("BoyNames.txt");

                // Read the Names into the list.
                while (!inputFile.EndOfStream)
                {
                    boysList.Add(inputFile.ReadLine());
                }

                // Close the file.
                inputFile.Close();
            }
            catch (Exception ex)
            {
                // Display an error Message
                MessageBox.Show(ex.Message);
            }
        }

        private void ReadGirlNames(List<string> girlsList)
        {
            try
            {
                // Open the GirlNames.txt file.
                StreamReader inputFile = File.OpenText("GirlNames.txt");

                // Read the Names into the list.
                while (!inputFile.EndOfStream)
                {
                    girlsList.Add(inputFile.ReadLine());
                }

                // Close the file.
                inputFile.Close();
            }
            catch (Exception ex)
            {
                // Display an error Message
                MessageBox.Show(ex.Message);
            }
        }

        // Method to display boy names from file to listbox
        private void DisplayBoyNames(List<string> boysList)
        {
            foreach (string name in boysList)
            {
                listBoxBoys.Items.Add(name);
            }
        }
        // Method to display girl names from file to listbox
        private void DisplayGirlNames(List<string> girlsList)
        {
            foreach (string name in girlsList)
            {
                listBoxGirls.Items.Add(name);
            }
        }

              




        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        



        private void checkNames_Click(object sender, EventArgs e)
        {

            // Display the names from boyslist text file
            List<string> boysList = new List<string>();
            ReadBoyNames(boysList);
            DisplayBoyNames(boysList);

            // Display the names from girlslist text file
            List<string> girlsList = new List<string>();
            ReadGirlNames(girlsList);
            DisplayGirlNames(girlsList);

            try
            {
               
               

                // Comparing user input boy name to boy name textbox list

                if(listBoxBoys.Items.Contains(textBoxBoyName.Text))
                {
                     MostPopularBoyLabel.Text = "Yes";
                }
                else
                {
                     MostPopularBoyLabel.Text = "No";
                }

                // Comparing user input girl name to girl name textbox list

                if (listBoxGirls.Items.Contains(textBoxGirlName.Text))
                {
                    MostPopularGirlLabel.Text = "Yes";
                }
                else
                {
                    MostPopularGirlLabel.Text = "No";
                }
                  
             
              

            }


            catch (Exception ex)
            {
                // Display default error message
                MessageBox.Show(ex.Message);
            }





        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();

        }
               
        }
    
}
