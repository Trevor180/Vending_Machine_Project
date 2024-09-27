using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WootenT_DrinkMch
{



    public partial class Form1 : Form
    {

        //Creating struct for the drinks
        struct Drink
        {
            //Fields
            public string name;
            public decimal cost;
            public int numOfDrinks;
        }

        //Accumulator for sales label
        decimal total = 0m;

        //Subtracting from quantity
        int colaQuantity = 20;

        //Making soft drink array for structure objects
        const int SIZE = 5;
        Drink[] softDrink = new Drink[SIZE];


        //Putting each instance in the array
        public Form1()
        {
            InitializeComponent();

            // Making cola instance and adding fields to it
            Drink cola = new Drink();
            cola.name = "Cola";
            cola.cost = 1.00m;
            cola.numOfDrinks = 20;


            // Making Lemon Lime instance and adding fields to it
            Drink lemonLime = new Drink();
            lemonLime.name = "Lemon Lime";
            lemonLime.cost = 1.00m;
            lemonLime.numOfDrinks = 20;

            // Making Lemon Lime instance and adding fields to it
            Drink creamSoda = new Drink();
            creamSoda.name = "Cream Soda";
            creamSoda.cost = 1.50m;
            creamSoda.numOfDrinks = 20;

            // Making Root Beer instance and adding fields to it
            Drink rootBeer = new Drink();
            rootBeer.name = "Root Beer";
            rootBeer.cost = 1.00m;
            rootBeer.numOfDrinks = 20;

            // Making Grape Soda instance and adding fields to it
            Drink grapeSoda = new Drink();
            grapeSoda.name = "Grape Soda";
            grapeSoda.cost = 1.50m;
            grapeSoda.numOfDrinks = 20;




            //Addig drinks to the soft drink array
            softDrink[0] = cola;
            softDrink[1] = lemonLime;
            softDrink[2] = creamSoda;
            softDrink[3] = rootBeer;
            softDrink[4] = grapeSoda;

        }

        private void ColaLabel_Click(object sender, EventArgs e)
        {
  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }




        private void colaPicture_Click(object sender, EventArgs e)
        {
            //Try/catch 
            try
            {

                //Making sure the quantity isn't at 20
                if (softDrink[0].numOfDrinks > 0)
                {

                    //Decreasing cola limit
                    softDrink[0].numOfDrinks -= 1;

                    //Adding cost to the total
                    total += softDrink[0].cost;

                    //Adding $1 to sales label
                    totalSalesLabel.Text = total.ToString("c");

                    //Showing quantity 
                    colaQuantityLabel.Text = softDrink[0].numOfDrinks.ToString();

                }

                //If cola is == to 0
                if (softDrink[0].numOfDrinks == 0)
                {
                    //If cola is 0
                    MessageBox.Show("Cola is sold out.");
                }


            }
            catch 
            {

                //Error message
                MessageBox.Show("An error has occurred");
            
            
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Closinf the application
            this.Close();
        }

        private void colaQuantityLabel_Click(object sender, EventArgs e)
        {

        }

        private void lemonLimePicture_Click(object sender, EventArgs e)
        {

            //Try/catch 
            try
            {

                //Making sure the quantity isn't at 20
                if (softDrink[1].numOfDrinks > 0)
                {

                    //Decreasing drink limit
                    softDrink[1].numOfDrinks -= 1;

                    //Adding cost to the total
                    total += softDrink[1].cost;

                    //Adding $1 to sales label
                    totalSalesLabel.Text = total.ToString("c");

                    //Showing quantity 
                    lemonLimeQuantityLabel.Text = softDrink[1].numOfDrinks.ToString();

                }

                //If drink is == to 0
                if (softDrink[1].numOfDrinks == 0)
                {
                    //If drink is 0
                    MessageBox.Show("Lemon Lime is sold out.");
                }


            }
            catch
            {

                //Error message
                MessageBox.Show("An error has occurred");


            }
        }

        private void creamSodaPicture_Click(object sender, EventArgs e)
        {
            //Try/catch 
            try
            {

                //Making sure the quantity isn't at 20
                if (softDrink[2].numOfDrinks > 0)
                {

                    //Decreasing drink limit
                    softDrink[2].numOfDrinks -= 1;

                    //Adding cost to the total
                    total += softDrink[2].cost;

                    //Adding $1 to sales label
                    totalSalesLabel.Text = total.ToString("c");

                    //Showing quantity of drink
                    creamSodaQuantityLabel.Text = softDrink[2].numOfDrinks.ToString();

                }

                //If drink is == to 0
                if (softDrink[2].numOfDrinks == 0)
                {
                    //If drink is 0
                    MessageBox.Show("Cream Soda is sold out.");
                }


            }
            catch
            {

                //Error message
                MessageBox.Show("An error has occurred");


            }

        }

        private void rootBearPicture_Click(object sender, EventArgs e)
        {
            //Try/catch 
            try
            {

                //Making sure the quantity isn't at 20
                if (softDrink[3].numOfDrinks > 0)
                {

                    //Decreasing drink limit
                    softDrink[3].numOfDrinks -= 1;

                    //Adding cost to the total
                    total += softDrink[3].cost;

                    //Adding $1 to sales label
                    totalSalesLabel.Text = total.ToString("c");

                    //Showing quantity of drink
                    rootBeerQuantityLabel.Text = softDrink[3].numOfDrinks.ToString();

                }

                //If drink is == to 0
                if (softDrink[3].numOfDrinks == 0)
                {
                    //If drink is 0
                    MessageBox.Show("Root Beer is sold out.");
                }


            }
            catch
            {

                //Error message
                MessageBox.Show("An error has occurred");


            }

        }

        private void grapeSodaPicture_Click(object sender, EventArgs e)
        {

            //Try/catch 
            try
            {

                //Making sure the quantity isn't at 20
                if (softDrink[4].numOfDrinks > 0)
                {

                    //Decreasing drink limit
                    softDrink[4].numOfDrinks -= 1;

                    //Adding cost to the total
                    total += softDrink[4].cost;

                    //Adding $1 to sales label
                    totalSalesLabel.Text = total.ToString("c");

                    //Showing quantity of drink
                    grapeSodaQuantityLabel.Text = softDrink[4].numOfDrinks.ToString();

                }

                //If drink is == to 0
                if (softDrink[4].numOfDrinks == 0)
                {
                    //If drink is 0
                    MessageBox.Show("Grape Soda is sold out.");
                }


            }
            catch
            {

                //Error message
                MessageBox.Show("An error has occurred");


            }

        }
    }
}
