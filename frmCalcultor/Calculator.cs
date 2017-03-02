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
    public class Calculator
    {
        public decimal currentValue;  /// the property which would hold the current value after the calculation.
        public decimal operand1;
        public decimal operand2;
        char operatorclicked;
        decimal result = 0;
        int count1 = 0;
      
      
        public Calculator() {}  // an empty constructor
           
       
        public decimal CurrentValue   /// defining the property
        {
            get
            {
                return currentValue;
            }
            set
            {
                currentValue = value;
            }
        }

        public char Operatorclicked   /// defining the property
        {
            get
            {
                return operatorclicked;
            }
            set
            {
                operatorclicked = value;
            }
        }
     

        public decimal Enter_value(char operatorclicked)   // it should enter value into the calculator display
        {
                switch (operatorclicked)
                {
                    case '+':
                        currentValue = Addition(operand1, operand2);
                        break;
                    case '-':
                        if (currentValue < 0)
                        {
                       operand1 = -1 * currentValue;
                       operand2 = -1 * operand2;
                       currentValue =-1 * substraction(operand1, operand2);}
                        else
                        {
                        
                        currentValue = substraction(operand1, operand2);
                        
                        }
                       break;

                    case '*':
                        currentValue = mutliplication(operand1, operand2);
                        break;
                    case '/':
                        currentValue = Division(operand1, operand2);
                        break;
                    case 's':
                        currentValue = (decimal)Math.Sqrt((double)operand1);
                        break;
                    case 'R':
                        currentValue = 1 / operand1;
                        break;
                    default:
                        break;

                }
                return currentValue;
        }
    
        public char splitting_thedisplay (string text )  /// splits the text displayed in the txt_display(user enter)
        {
            try
            {
                if (text.Contains('+'))
                {
                    operatorclicked = '+';
                    string[] text1 = text.Split(operatorclicked);
                    operand1 = Convert.ToDecimal(text1[0]);
                    operand2 = Convert.ToDecimal(text1[1]);
                   // MessageBox.Show(operatorclicked.ToString());
                }
                else if (text.Contains('*'))
                {
                    operatorclicked = '*';
                    string[] text1 = text.ToString().Split(operatorclicked);
                    operand1 = Convert.ToDecimal(text1[0]);
                    operand2 = Convert.ToDecimal(text1[1]);

                }
                else if (text.Contains('/'))
                {
                    operatorclicked = '/';
                    string[] text1 = text.ToString().Split(operatorclicked);
                    operand1 = Convert.ToDecimal(text1[0]);
                    operand2 = Convert.ToDecimal(text1[1]);

                }
                else if (text.Contains('-'))
                {
                    count1 = text.Count(c => c == '-');
                    if (count1 == 2)
                    {
                        operatorclicked = '-';
                        string[] text1 = text.ToString().Split(operatorclicked); // -|2|-|3 ==> 0,2,3
                        operand1 = Convert.ToDecimal(text1[1]) * -1;
                        operand2 = Convert.ToDecimal(text1[2]);


                    }
                    else
                    {

                        operatorclicked = '-';
                        string[] text1 = text.ToString().Split(operatorclicked);
                        operand1 = Convert.ToDecimal(text1[0]);
                        operand2 = Convert.ToDecimal(text1[1]);

                    }
                }

                if (text.Contains('s'))
                {
                    operatorclicked = 's';
                    string[] text1 = text.ToString().Split(operatorclicked);
                    operand1 = Convert.ToDecimal(text1[0]);
                    operand2 = 0m;

                }
                if (text.Contains('R'))
                {
                    operatorclicked = 'R';
                    string[] text1 = text.ToString().Split(operatorclicked);
                    operand1 = Convert.ToDecimal(text1[0]);
                    operand2 = 0m;

                }
            
                return operatorclicked;

            }
            catch (FormatException)
            {
                MessageBox.Show("invalid input", "Entry Error");
                return ' ';

            }
        }
        

        public  decimal Addition(decimal operand1, decimal operand2)
        {
            result = operand1 + operand2;
            return result;
           

        }
        public decimal substraction(decimal operand1, decimal operand2)
        {
            result = operand1 - operand2;
            return result;

        }
        public  decimal mutliplication(decimal operand1, decimal operand2)
        {
            result = operand1 * operand2;
            return result;

        }
        public  decimal Division(decimal operand1, decimal operand2)
        {
            try
            {
             result = operand1 / operand2;
             return result;

            }
           
            catch (DivideByZeroException)
            {
                MessageBox.Show("cannt divide by zero", "Entry Error");
                
            }
            return 0;
        } 
    }
    }





