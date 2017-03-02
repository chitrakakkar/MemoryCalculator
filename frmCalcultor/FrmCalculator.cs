using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmCalcultor
{
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
        }
//*************globally defined variables)******************************        
        int count = 0;
        Calculator gotthis = new Calculator(); // created an instance of Calculator class. 
        char result = ' ';
        int count1 = 0;
        MemoryCalculator MemCal = new MemoryCalculator();


//*************clears everything in the text display************************** 
        private void btn_clear_Click(object sender, EventArgs e)
        {
            
            txt_display.Text = "";
            count = 0;
            gotthis.currentValue = 0m;
            lbl_MemVal.Text = "";
            
        }
//******************** clears the string one by one on the click event of the back button*******************

        private void btn_back_Click(object sender, EventArgs e)
        {
            int i = txt_display.Text.Length;
            if (i > 0)
            {
                txt_display.Text = txt_display.Text.Substring(0, i - 1);  //  strips off the character one by one.
            }
        }
        //*****************
        public void Enter_Value(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Text)
            {
                case "MR":
                    txt_display.Text = MemCal.MemoryRecall(gotthis).ToString();
                 
                    
                    break;
                case "MC":
                    gotthis = MemCal.Memoryclear(gotthis);
                    txt_display.Text = gotthis.currentValue.ToString();
                    break;
                case "MS":
                    if (gotthis.currentValue == 0)
                    { gotthis.currentValue = Convert.ToDecimal(txt_display.Text); }
                    else
                    {
                        txt_display.Text = MemCal.MemoryStore(gotthis).ToString();
                    }
                    break;
                case "M+":
                    gotthis.currentValue = Convert.ToDecimal(txt_display.Text);
                    txt_display.Text = MemCal.MemoryAdd(gotthis).ToString();
                    break;
                default:
                    txt_display.Text = txt_display.Text + button.Text;
                    break;

            }
            if (MemCal.memoryCurrentValue != 0)
            {
                lbl_MemVal.Text = "M";
            }
            else
            {
                lbl_MemVal.Text = "";
            
            }
       }

        public void btn_equalto_Click(object sender, EventArgs e)
        {

           count++;
            
            if (count == 1)
            {
                result = gotthis.splitting_thedisplay(txt_display.Text);
                txt_display.Text = gotthis.Enter_value(result).ToString();
            }

            if (count > 1)
            {
                  // checks if the = button is clicked more than once and if yes, then repeats the operation according the operator sent;
                
                    
                    gotthis.operand1 = gotthis.currentValue;
                    txt_display.Text = gotthis.Enter_value(result).ToString();
                    
            }
               
            }
    
        private void btn_sqrt_Click(object sender, EventArgs e)
        {
            count++;
            char result = gotthis.splitting_thedisplay(txt_display.Text+'s');
            txt_display.Text = gotthis.Enter_value(result).ToString();
        }

        private void btn_reciprocal_Click(object sender, EventArgs e)
        {
            count++;
            char result = gotthis.splitting_thedisplay(txt_display.Text + 'R');
            txt_display.Text = gotthis.Enter_value(result).ToString();
        }

        private void txt_display_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_sign_Click(object sender, EventArgs e)
        {
            count1++;
            if (count1 % 2 == 0)
            {
                txt_display.Text = "";
            }
            else { txt_display.Text = "-"; }
            
            
        }
        

        
    }
}



        

        
    

