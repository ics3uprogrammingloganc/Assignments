/*
 * Created by: Logan Cantin
 * Created on: March 26, 2019
 * Created for: ICS3U Programming
 * Assignment #5b - Pizza Order
 * This program allows the user to order a pizza. It is easy to use and actually
 * impossible to break. Here is the extra functionality:
 * - Extra order options (extra size, 0 topping option, drinks + sauces option)
 * - Receipt format with detailed summary of all pizzas
 * - Requiring name and phone number to order
 * - Regex on phone number, making sure it is an ottawa-area only phone number and no characters
 * - Running totals and subtotals with live changes as you order
 * - intuitive layout, easy to stay focused as all other areas are hidden
 * - OOP Pizza class with a print method
 * - Rounding to 2 decimal places
 * - Upper limit to number of pizzas and sides/drinks that can be bought
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderLoganC
{
    public partial class frmPizzaOrder : Form
    {
        // VARIABLES
        
        public enum Sizes
        {
            MEDIUM, LARGE, XLARGE, NONE
        }
        static public double[] TOPPING_COSTS = { 0.0, 0.75, 1.35, 2.15, 2.75 };
        static public double[] SIZE_COSTS = { 7.99, 9.99, 12.99, 0.00 };
        public const double TAX = 1.13;

        private List<Pizza> order = new List<Pizza>();
        private double total = 0.0;
        private double subtotal = 0.0;
        private int toppings = 0;
        private Sizes size = Sizes.NONE;
        private string name;
        private long phone;
        private int numPizzas = 1;
        private int drinks;
        private int sauces;

        Random rndNumGen = new Random();
        
        public frmPizzaOrder()
        {
            InitializeComponent();
            btnOrder.Enabled = false;
        }

        // Disables all checkboxes when a size has not been selected
        private void disableCheckboxes()
        {
            chkMushroom.Enabled = false;
            chkOlive.Enabled = false;
            chkPepperoni.Enabled = false;
            chkOnion.Enabled = false;
        }

        private void checkFields()
        {
            // Checking if it is an ottawa number
            if (tbxPhone.TextLength == 10 && !System.Text.RegularExpressions.Regex.IsMatch(tbxPhone.Text, "^(613|343)[0-9]+$"))
            {
                // Not an ottawa number. Tell the user to enter a valid phone number and clear the text box.
                MessageBox.Show("Enter an ottawa number.");
                tbxPhone.Clear();
            }
            else if (tbxName.TextLength > 0 && tbxPhone.TextLength == 10)
            {
                // Valid ottawa phone number and name that's one character or more. Let them order
                btnOrder.Enabled = true;
            }
            else
            {
                // One of the fields is incomplete. Don't let them order.
                btnOrder.Enabled = false;
            }
        }

        // Makes sure only number characters are inputted and restricts order button unless fields are completed
        private void tbxPhone_TextChanged(object sender, EventArgs e)
        {
            // Making sure that all characters are number characters and the phone number
            if (System.Text.RegularExpressions.Regex.IsMatch(tbxPhone.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                tbxPhone.Clear();
            }

            //Checking to see if they can order now
            checkFields();
        }

        private void tbxName_TextChanged(object sender, EventArgs e)
        {
            // checking if they can order now
            checkFields();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            // Hide all of the items from the initial personal info page.
            tbxPhone.Hide();
            tbxName.Hide();
            lblNamePrompt.Hide();
            lblPhonePrompt.Hide();
            lblWelcome.Hide();
            btnOrder.Hide();

            // save name and phone number
            name = tbxName.Text;
            phone = Convert.ToInt64(tbxPhone.Text);

            // Show Pizza order form. Disable checkboxes until they choose a size.
            grbPizza.Show();
            disableCheckboxes();
        }

        //Updates pizza form's subtotal and total text boxes
        private void updateTotals()
        {
            // reset subtotal. Add the cost of the pizza and toppings
            subtotal = 0.0;
            subtotal += (size != Sizes.NONE) ? SIZE_COSTS[(int)size] : 0; // if size is none, cost is zero, otherwise cost of size
            subtotal += TOPPING_COSTS[toppings];

            // Changing text boxes to reflect new totals
            tbxSubtotal.Text = "$" + Convert.ToString(subtotal);
            tbxTotal.Text = "$" + Convert.ToString(subtotal + total);
        }

        // Size has been selected
        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Update size. Update totals. Enable check boxes.
            size = (Sizes)cmbSize.SelectedIndex;
            updateTotals();
            chkMushroom.Enabled = true;
            chkOlive.Enabled = true;
            chkPepperoni.Enabled = true;
            chkOnion.Enabled = true;
        }

        // update number of toppings. update totals
        #region toppingChanged
        private void chkMushroom_CheckedChanged(object sender, EventArgs e)
        {
            toppings += (chkMushroom.Checked) ? 1 : -1;
            updateTotals();
        }

        private void chkPepperoni_CheckedChanged(object sender, EventArgs e)
        {
            toppings += (chkPepperoni.Checked) ? 1 : -1;
            updateTotals();
        }

        private void chkOlive_CheckedChanged(object sender, EventArgs e)
        {
            toppings += (chkOlive.Checked) ? 1 : -1;
            updateTotals();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            toppings += (chkOnion.Checked) ? 1 : -1;
            updateTotals();
        }
        #endregion

        // Add a new pizza
        private void btnNewPizza_Click(object sender, EventArgs e)
        {
            if (size != Sizes.NONE && numPizzas < 10)
            {
                // Add the old pizza to the order
                order.Add(new Pizza(grbPizza.Text, size, subtotal,
                    chkMushroom.Checked, chkPepperoni.Checked, chkOlive.Checked, chkOnion.Checked));
                grbPizza.Text = "Pizza #" + Convert.ToString(++numPizzas);

                // Update total. Reset subtotal.
                total += subtotal;
                subtotal = 0.0;

                //Reset size, uncheck all toppings, and disable checkboxes.
                cmbSize.SelectedIndex = 3;
                chkMushroom.Checked = false;
                chkOlive.Checked = false;
                chkPepperoni.Checked = false;
                chkOnion.Checked = false;
                disableCheckboxes();
            }
            else
            {
                btnDone_Click(this, new EventArgs());
            }
        }

        // Move on to the sides form
        private void btnDone_Click(object sender, EventArgs e)
        {
            // add last pizza to order
            order.Add(new Pizza(grbPizza.Text, size, subtotal,
                chkMushroom.Checked, chkPepperoni.Checked, chkOlive.Checked, chkOnion.Checked));

            //reset subtotal. Hide pizza form, show sides form
            subtotal = 0;
            grbPizza.Hide();
            grbSides.Show();
        }

        // rounding function
        private double round(double n, int p)
        {
            n *= Math.Pow(10, p);
            n = Math.Round(n);
            n /= Math.Pow(10, p);
            return n;
        }

        // Calculate an display subtotal and total
        private void recalculateSidesSubtotal()
        {
            subtotal = (double)nudDrinks.Value * 2.5 + (double)nudSauces.Value * 0.75;
            tbxSubtotalSides.Text = "$" + Convert.ToString(round(subtotal, 2));
            tbxTotalSides.Text = "$" + Convert.ToString(round(subtotal + total, 2));
        }

        private void nudDrinks_ValueChanged(object sender, EventArgs e)
        {
            recalculateSidesSubtotal();
        }

        private void nudSauces_ValueChanged(object sender, EventArgs e)
        {
            recalculateSidesSubtotal();
        }

        // Finish order
        private void btnSidesDone_Click(object sender, EventArgs e)
        {
            // Save drinks and sauces
            drinks = (int)nudDrinks.Value;
            sauces = (int)nudSauces.Value;
            
            //Update total
            total += subtotal;

            //Hide sides form and print receipt.
            grbSides.Hide();
            printReceipt();
        }

        // Prints receipt.
        private void printReceipt()
        {
            // New line
            string nl = Environment.NewLine;

            //Clear receipt. Add header with pizza place name, your name, phone number, and order number
            tbxReceipt.Clear();
            tbxReceipt.Text += "***** LUIGI PIZZA *****" + nl;
            tbxReceipt.Text += "Name: " + name + nl;
            tbxReceipt.Text += "Phone: " + Convert.ToString(phone) + nl;
            tbxReceipt.Text += "Order #" + Convert.ToString(rndNumGen.Next(200)) + nl + nl; // order number is random up to 200

            // Print all pizzas using the Pizza class print function
            tbxReceipt.Text += "-- Pizza(s) --" + nl;
            foreach (Pizza p in order)
            {
                tbxReceipt.Text += p.print();
            }

            // Printing all sides
            tbxReceipt.Text += "-- Sides --" + nl;
            tbxReceipt.Text += "Drinks: " + Convert.ToString(drinks) + nl;
            tbxReceipt.Text += "Sauces: " + Convert.ToString(sauces) + nl ;
            tbxReceipt.Text += "Subtotal: " + Convert.ToString(subtotal) + nl + nl;

            // Print total and thank user
            tbxReceipt.Text += "Order subtotal: $" + Convert.ToString(round(total, 2)) + nl;
            tbxReceipt.Text += "Tax: 13%" + nl;
            tbxReceipt.Text += "TOTAL = $" + Convert.ToString(round(total * TAX, 2)) + nl;
            tbxReceipt.Text += "Thanks for order from LUIGI's Pizza!";
        }

        // Restart application
        private void mniRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //Exit application
        private void mniExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    // Pizza class to store a completed Pizza
    class Pizza {
        frmPizzaOrder.Sizes size;
        string name;
        bool mushroom;
        bool pepperoni;
        bool olive;
        bool onion;
        double cost;

        string nl = Environment.NewLine;

        public Pizza(string n, frmPizzaOrder.Sizes s, double c, bool m, bool p, bool ol, bool on)
        {
            name = n;
            size = s;
            mushroom = m;
            pepperoni = p;
            olive = ol;
            onion = on;
            cost = c;
        }

        // Print function that turns all of the variables into string format for easy reading in receipt
        public string print()
        {
            string receipt = "";
            receipt += name + nl;
            receipt += " * " + size.ToString() + nl;
            if (mushroom)
            {
                receipt += " * Mushroom" + nl;
            }
            if (pepperoni)
            {
                receipt += " * Pepperoni" + nl;
            }
            if (olive)
            {
                receipt += " * Olive" + nl;
            }
            if (onion)
            {
                receipt += " * Onion" + nl;
            }

            receipt += "Subtotal: " + Convert.ToString(cost) + nl + nl;

            return receipt;
        }
    }

}
