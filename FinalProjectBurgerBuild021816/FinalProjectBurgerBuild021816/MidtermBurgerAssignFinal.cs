using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinalProjectBurgerBuild021816
{
    public partial class Order : Form
    {
        bool takeOut;
        int pattyNum;
        string orderstep;

        string [] optionsArray = new string[4];
        string chooseBun;
        string Cheese;
        string[] toppings = new string[] { };
        string[] sauce = new string[] { };

        
        public Order()
        {
            InitializeComponent();

        }
        /* Application Load Event*/

        private void Order_Load (object sender, EventArgs e)
        {

            pnlStart.Visible = true;

            //Hide all panels
            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;
            pnlBuild.Visible = false;
            pnlChooseBun.Visible = false;
            pnlCheese.Visible = false;
            pnlToppings.Visible = false;
            pnlSauce.Visible = false;
            pnlSummary.Visible = false;
            pnlComplete.Visible = false;
            pnlprevnext.Visible = true;
            pnlStack.Visible = true;    
            topNav.Visible = true;

            lblStack.Text = "";





        }
        /* Panel Visible Change Events*/
        private void Order_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        
        private void pnlStart_VisibleChanged(object sender, EventArgs e)
        {
            if (
                pnlStart.Visible == true)
            {
                orderstep = "start";
            }
        }

        private void pnlLocation_VisibleChanged(object sender, EventArgs e)
        {
            if (
                pnlLocation.Visible == true)
            {
                orderstep = "location";
            }

        }

        private void pnlOrderType_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlOrderType.Visible == true)
            {
                orderstep = "OrderType";
            }
        }

        private void pnlBuild_VisibleChanged(object sender, EventArgs e)
        {
            if (
                pnlBuild.Visible == true)
            {
                orderstep = "build";
                
            }

        }

        private void pnlChooseBun_VisibleChanged(object sender, EventArgs e)
        {
            if (
                pnlChooseBun.Visible == true)
            {
                orderstep = "ChooseBun";
                btnNext.Enabled = false;

                while (optionsArray[0] == "")
                {
                    btnNext.Enabled = false;
                }
            }

        

        }


       //Yes Button Events 
        private void btnYes_Click(object sender, EventArgs e)
        {
            pnlComplete.Visible = true;
            pnlSummary.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = false;
            pnlLocation.Visible = true;

        }

        //NextButton Click
        private void btnNext_Click(object sender, EventArgs e)
        {

            switch (orderstep)
            {
                case "location":
                    pnlStart.Visible = true;
                    pnlLocation.Visible = false;
                    break;

                case "orderType":
                    pnlOrderType.Visible = true;
                    pnlLocation.Visible = false;
                    break;
                
                case "build":
                    pnlBuild.Visible = false;
                    pnlChooseBun.Visible = true;
                    break;
                case "ChooseBun":
                    pnlChooseBun.Visible = false;
                    pnlCheese.Visible = true;
                    break;
                case "Cheese":
                    pnlCheese.Visible = false;
                    pnlToppings.Visible = true;
                    break;
                case "Toppings":
                    pnlToppings.Visible = false;
                    pnlSauce.Visible = true;
                    break;
                case "Sauce":
                    pnlSauce.Visible = false;
                    pnlSummary.Visible = true;
                    break;
                case "Summary":
                    pnlSummary.Visible = false;
                    pnlComplete.Visible = true;
                    break;



                default:
                    pnlStart.Visible = true;
                    break;

            }
        }
        //PreviousButton Click

        private void btnprevious_Click(object sender, EventArgs e)
        {
            switch (orderstep)
            {
               

                case "location":
                    pnlStart.Visible = true;
                    pnlLocation.Visible = false;
                    break;
                
                case "orderType":
                    pnlOrderType.Visible = true;
                    pnlLocation.Visible = false;
                    break;
                
               case "build":
                    pnlBuild.Visible = true;
                    pnlChooseBun.Visible = false;
                    break;
                case "chooseBun":
                    pnlChooseBun.Visible = true;
                    pnlCheese.Visible = false;
                    break;
                case "Cheese":
                    pnlCheese.Visible = true;
                    pnlToppings.Visible = false;
                    break;
                case "Toppings":
                    pnlToppings.Visible = true;
                    pnlSauce.Visible = false;
                    break;
                case "Sauce":
                    pnlSauce.Visible = true;
                    pnlSummary.Visible = false;
                    break;
                case "Summary":
                    pnlSummary.Visible = true;
                    pnlComplete.Visible = false;
                    break;


                
                default:
                    pnlStart.Visible = false;
                    break;
            }


        }


        // Eat In and Take Out Click Events 
        private void btnEatIN_Click(object sender, EventArgs e)
        {
            takeOut = false;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = true;
            pnlprevnext.Visible = true;
           
        }

        private void btnTakeOut_Click(object sender, EventArgs e)
        {
            takeOut = true;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = true;
            pnlprevnext.Visible = true;

        }

        // Click events

        private void btnSpecialty_Click(object sender, EventArgs e)
        {
            pnlOrderType.Visible = false;
        }

        private void btnBuilt_Click(object sender, EventArgs e)
        {
            pnlOrderType.Visible = false;
            pnlBuild.Visible = true;

        }

        private void btnwhitebun_Click(object sender, EventArgs e)
        {
            optionsArray[0] = "whitebun\n";
            lblStack.Text = optionsArray[0];
            btnNext.Enabled = true;
        }

        private void btnWheatBun_Click(object sender, EventArgs e)
        {
            optionsArray[0] = "WheatBun\n";
            lblStack.Text = optionsArray[0];
            btnNext.Enabled = true;
        }

        private void btnPotatoBun_Click(object sender, EventArgs e)
        {
            optionsArray[0] = "PotatoBun\n";
            lblStack.Text = optionsArray[0];
            btnNext.Enabled = true;
        }

        private void btnAmericanCheese_Click(object sender, EventArgs e)
        {
            optionsArray[1] = "AmericanCheese\n";
            lblStack.Text += optionsArray[1];
           
        }

        private void btnCheddar_Click(object sender, EventArgs e)
        {

            optionsArray[1] = "Cheddar\n";
            if (optionsArray[1] != "")
            {
                lblStack.Text += optionsArray[1];
            }
        }

        private void btnSwiss_Click(object sender, EventArgs e)
        {
            optionsArray[1] = "Swiss\n";
            lblStack.Text += optionsArray[1];

        }

        /*Panel Visible Change Events*/
        private void pnlCheese_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlCheese.Visible == true)
            {
                orderstep = "Cheese";
            }
        }

        private void pnlToppings_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlToppings.Visible == true)
            {
                orderstep = "Toppings";
            }

        }

        private void pnlSauce_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlSauce.Visible == true)
            {
                orderstep = "Sauce";
            }


        }

        //Button Click Events//
        private void btnNoCheese_Click(object sender, EventArgs e)
        {
            optionsArray[1] = "noCheese\n";
            lblStack.Text += optionsArray[1];
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            pnlBuild.Visible = false;
            pnlChooseBun.Visible = true;
        }

        private void btntomato_Click(object sender, EventArgs e)
        {
            optionsArray[2] = "tomato\n";
            lblStack.Text += optionsArray[2];
        }

        private void btnLettuce_Click(object sender, EventArgs e)
        {
            optionsArray[2] = "lettuce\n";
            lblStack.Text += optionsArray[2];
        }

        private void btnONION_Click(object sender, EventArgs e)
        {
            optionsArray[2] = "onion\n";
            lblStack.Text += optionsArray[2];
        }

        private void btnKetchup_Click(object sender, EventArgs e)
        {
            optionsArray[3] = "ketchup\n";
            lblStack.Text += optionsArray[3];
        }

        private void btnMustard_Click(object sender, EventArgs e)
        {
            optionsArray[3] = "mustard\n";
            lblStack.Text += optionsArray[3];
        }

        private void btnMayo_Click(object sender, EventArgs e)
        {
            optionsArray[3] = "mayo\n";
            lblStack.Text += optionsArray[3];
        }

        private void pnlSummary_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlSummary.Visible == true)
            {
                orderstep = "Summary";
                btnNext.Enabled = false;

            }
        }

        private void pnlComplete_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlComplete.Visible == true)
            {
                orderstep = "Complete";
                btnNext.Enabled = false;
            }

        }

        private void btnThankYou_Click(object sender, EventArgs e)
        {
            {

                pnlStart.Visible = true;

                //Hide all panels
                pnlLocation.Visible = false;
                pnlOrderType.Visible = false;
                pnlBuild.Visible = false;
                pnlChooseBun.Visible = false;
                pnlCheese.Visible = false;
                pnlToppings.Visible = false;
                pnlSauce.Visible = false;
                pnlSummary.Visible = false;
                pnlComplete.Visible = false;
                pnlprevnext.Visible = true;
                pnlStack.Visible = true;
                topNav.Visible = true;

                lblStack.Text = "";
            }

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            pnlSummary.Visible = false;
            pnlLocation.Visible = true;
        }

        private void btnNavBun_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = false;

           
            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;
            pnlBuild.Visible = false;
            pnlChooseBun.Visible = true;
            pnlCheese.Visible = false;
            pnlToppings.Visible = false;
            pnlSauce.Visible = false;
            pnlSummary.Visible = false;
            pnlComplete.Visible = false;
            pnlprevnext.Visible = true;
            pnlStack.Visible = true;
            topNav.Visible = true;
        }

        private void btnNavCheese_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = false;

            
            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;
            pnlBuild.Visible = false;
            pnlChooseBun.Visible = false;
            pnlCheese.Visible = true;
            pnlToppings.Visible = false;
            pnlSauce.Visible = false;
            pnlSummary.Visible = false;
            pnlComplete.Visible = false;
            pnlprevnext.Visible = true;
            pnlStack.Visible = true;
            topNav.Visible = true;
        }

        private void btnNavToppings_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = false;

            
            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;
            pnlBuild.Visible = false;
            pnlChooseBun.Visible = false;
            pnlCheese.Visible = false;
            pnlToppings.Visible = true;
            pnlSauce.Visible = false;
            pnlSummary.Visible = false;
            pnlComplete.Visible = false;
            pnlprevnext.Visible = true;
            pnlStack.Visible = true;
            topNav.Visible = true;
        }

        private void btnNavSauce_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = false;

            //Hide all panels
            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;
            pnlBuild.Visible = false;
            pnlChooseBun.Visible = false;
            pnlCheese.Visible = false;
            pnlToppings.Visible = false;
            pnlSauce.Visible = true;
            pnlSummary.Visible = false;
            pnlComplete.Visible = false;
            pnlprevnext.Visible = true;
            pnlStack.Visible = true;
            topNav.Visible = true;
        }

        

        private void btnBigMac_Click(object sender, EventArgs e)
        {

        }

       
        
 
    }
}
