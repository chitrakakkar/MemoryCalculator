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
    class MemoryCalculator: Calculator
    {

        public decimal memoryCurrentValue;

        public MemoryCalculator() {}

        public decimal MemoryCurrentValue
        {
            get
            {
                return memoryCurrentValue;
            }
            set
            {
                memoryCurrentValue = currentValue;
                //MessageBox.Show("ck"+memoryCurrentValue.ToString());
            }

        }
        Calculator ck = new Calculator();


        public decimal MemoryStore(Calculator ck)
        {
            memoryCurrentValue = ck.currentValue;
          MessageBox.Show(memoryCurrentValue.ToString());
            return memoryCurrentValue;
      
         }
        
    public decimal MemoryRecall( Calculator ck)
    {
        currentValue = memoryCurrentValue;
        
        return memoryCurrentValue;
    
    }
    public decimal MemoryAdd(Calculator ck)
    {
        memoryCurrentValue += ck.currentValue;
        MessageBox.Show("M+ "+memoryCurrentValue.ToString());
        return memoryCurrentValue;
    }

    public Calculator Memoryclear(Calculator ck)
    {
      ck.currentValue = 0m;
      memoryCurrentValue = 0m;
      return ck;
    }
        




    }
   

















    }
    

    



