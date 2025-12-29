using System;
using System.Windows.Forms;

namespace PROJ3
{
    public partial class Form1 : Form
    {
        // Arrays to store caterer and business info
       string[] catererNames = { "Hill Catering Co.", "Food in a Flash", "Sally's Sandwiches", "Perry's Pierogis" }; // List of caterer names
        double[] catererDiscounts = { 0.30, 0.20, 0.12, 0.05 }; // Discount percentages for each caterer
       string[] businessNames = { "John's Books", "Office Supplies", "J.B. Car Parts", "Gevalia Coffee", "Ceylon Tea", "My Footwear" }; // List of business names
        double[] contractPrices = { 500, 489, 412, 350, 325, 279 }; // Contract prices for each business
       int[] yearRanges = { 1, 2, 3, 4, 5 }; // Placeholder array for year ranges
        int[] yearDiscountRanges = { 0, 30, 40, 50 }; // Discounts based on contract years

        public Form1()
        {
            InitializeComponent(); 
            this.Load += new EventHandler(Form1_Load); // make sure Form1_Load is subscribed to the Load event 
            CalcBtn.Click += new EventHandler(CalcBtn_Click); // make sure CalcBtn_Click is subscribed to the Click event for the Calc btn
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Populate ComboBoxes with options from arrays
            CatererComboBox.Items.Clear(); // Clear
            BusinessComboBox.Items.Clear(); //Clear 

            CatererComboBox.Items.AddRange(catererNames); // Add caterer names to the Caterer combo box
            BusinessComboBox.Items.AddRange(businessNames); // Add business names to the Business combo box
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
           ContractPriOutput.Text = string.Empty; // Clear previous output

            // Validate caterer selection
            if (CatererComboBox.SelectedIndex < 0) //  If no caterer is selected
            {
             MessageBox.Show("Please select a caterer."); // Prompt th e user to select a caterer
               return; // Exit the method as we cannot proceed without a valid selection
            }

            // Validate business selection
            if (BusinessComboBox.SelectedIndex < 0) // If no business is selected
            {
                MessageBox.Show("Please select a business."); // Prompt the user to select a business
             return; // Exit the method as we cannot proceed without a valid selection
            }

            // Validate years input
            if (!int.TryParse(ContractYrsTextbox.Text, out int years) || years < 1) //Check if input is a valid positive integer
            {
             MessageBox.Show("Please enter a valid number of years."); // Prompt the user to enter a valid number
               return; // Exit the method as we need a valid input to continue
            }

            // Get selected caterer discount
            double discountRate = catererDiscounts[CatererComboBox.SelectedIndex]; //Get the discount rate based on the selected caterer

            // Get selected business contract price
            double basePrice = contractPrices[BusinessComboBox.SelectedIndex]; // Get the contract price based on the selected business

            // Determine additional discount based on contract years
            double additionalDiscount = 0; // start additional discount to zero
            if (years >= 8) // If the contract is for 8 or more years
            {
              additionalDiscount = yearDiscountRanges[3]; // Apply the highest discount
            }
            else if (years >= 5) // If the contract is for 5-7 years
            {
             additionalDiscount = yearDiscountRanges[2]; // Apply a moderate discount
            }
            else if (years >= 2) // If the contract is for 2-4 years
            {
              additionalDiscount = yearDiscountRanges[1]; // Apply a smaller discount
            }

            // Calculate final price
            double discountAmount = basePrice * discountRate; // Calculate the discount amount based on the base price and discount rate
            double finalPrice = basePrice - discountAmount - additionalDiscount; // Calculate the final price after applying all discounts

            // Output contract price
            ContractPriOutput.Text = "$" + finalPrice.ToString("F2"); // show the final price formatted as currency
            ContractPriOutput.Refresh(); // Refresh the output to ensure it updates visually
        }

        private void CatererComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
