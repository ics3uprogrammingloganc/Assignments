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
    public enum Sizes { MEDIUM, LARGE, XLARGE };

    public partial class frmPizzaOrder : Form
    {
        public const double tax = 1.13;
        public Pizza[] pizzas = new Pizza[10];
        public int numPizzas = 0;
        public Pizza currentPizza;
        public double subtotal, total;
        public int index = 0;

        public frmPizzaOrder()
        {
            InitializeComponent();

            // Add the first pizza to the order and select it
            currentPizza = new Pizza();
            currentPizza.name = "Pizza 1";
            cmbPizza.Items.Add("Pizza 1");
            cmbPizza.SelectedItem = "Pizza 1";
            

            // Increase number of pizzas
            numPizzas += 1;

            // Disable remove button (can't have less than one pizza)
            btnRemovePizza.Enabled = false;
        }

        public void ReloadPrices()
        {
            tbxPizzaCost.Text = Convert.ToString(currentPizza.cost);
            subtotal = 0;
            foreach (Pizza p in pizzas)
            {
                if (p != null)
                    subtotal += p.cost;
            }
            total = subtotal * tax;

            tbxSubtotal.Text = Convert.ToString(subtotal);
            tbxTotal.Text = Convert.ToString(total);
        }

        private void tbxTotal_TextChanged(object sender, EventArgs e)
        {
            // this.Text = (string)cmbPizza.SelectedItem;
        }

        public void UpdateFields()
        {
            currentPizza = pizzas[cmbPizza.SelectedIndex];

            tbxReceipt.Text = currentPizza.name + Environment.NewLine + currentPizza.size;

            try
            {
                

                cmbSize.SelectedItem = currentPizza.size;
                chkBacon.Checked = currentPizza.bacon;
                chkOlives.Checked = currentPizza.olives;
                chkPepperoni.Checked = currentPizza.pepperoni;
                chkPepper.Checked = currentPizza.pepper;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in update fields.");
            }
            
        }

        // Adding a new pizza to the order
        private void btnAddPizza_Click(object sender, EventArgs e)
        {
            // Name of the pizza
            string pizzaName = "Pizza " + Convert.ToString(numPizzas + 1);

            // Add a new pizza to the order and select it
            currentPizza = new Pizza();
            currentPizza.name = pizzaName;

            // Increase the number of pizzas for the next order
            numPizzas += 1;

            // Change the pizza index
            index = numPizzas - 1;

            // Enable the ability to remove pizzas
            btnRemovePizza.Enabled = true;

            pizzas[index] = currentPizza;

            cmbPizza.Items.Add(pizzaName);
            cmbPizza.SelectedItem = pizzaName;
            
            
            
        }

        // Removes currently selected pizza
        private void btnRemovePizza_Click(object sender, EventArgs e)
        {
            cmbPizza.Items.Remove(cmbPizza.SelectedItem);
            numPizzas -= 1;

            Console.WriteLine("Pizza removed");

            cmbPizza.SelectedIndex = numPizzas - 1;
            currentPizza = pizzas[numPizzas - 1];

            if (numPizzas < 2)
            {
                btnRemovePizza.Enabled = false;
            }

        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPizza.size = (Sizes)cmbSize.SelectedIndex;
            ReloadPrices();
        }

        private void chkPepperoni_CheckedChanged(object sender, EventArgs e)
        {
            currentPizza.Topping("pepperoni", chkPepperoni.Checked);
            ReloadPrices();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            currentPizza.Topping("olives", chkOlives.Checked);
            ReloadPrices();
        }

        private void chkBacon_CheckedChanged(object sender, EventArgs e)
        {
            currentPizza.Topping("bacon",chkBacon.Checked);
            ReloadPrices();
        }

        private void cmbPizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Saving the previous pizza, and loading the new pizza
            pizzas[index] = currentPizza;
            currentPizza = pizzas[cmbPizza.SelectedIndex];
            UpdateFields();
        }

        private void chkPepper_CheckedChanged(object sender, EventArgs e)
        {
            currentPizza.Topping("pepper", chkBacon.Checked);
            ReloadPrices();
        }
    }

    public class Pizza
    {
        public string name;
        public Sizes size;
        public bool pepperoni, bacon, olives, pepper;
        public double cost;
        private readonly double[] sizeCost = { 7.99, 9.99, 12.99 };
        private readonly double[] toppingCharges = { 0.0, 0.75, 1.35, 2.15, 2.65 };
        int numToppings;

        public Pizza()
        {
            size = Sizes.LARGE;
            pepperoni = false;
            bacon = false;
            olives = false;
            pepper = false;
            numToppings = 0;
            cost = 9.99;
            name = "abc";
        }

        public void Topping(string name, bool action)
        {
            if (name == "pepperoni")
            {
                pepperoni = action;
                numToppings += action ? 1 : -1;
            } else if (name == "bacon")
            {
                bacon = action;
                numToppings += action ? 1 : -1;
            } else if (name == "olives")
            {
                olives = action;
                numToppings += action ? 1 : -1;
            } else if (name == "pepper")
            {
                pepper = action;
                numToppings += action ? 1 : -1;
            }

            cost = sizeCost[(int)size] + toppingCharges[numToppings];
        }

        public void Size(Sizes s)
        {
            size = s;
            cost = sizeCost[(int)size] + toppingCharges[numToppings];
        }
    }
}
