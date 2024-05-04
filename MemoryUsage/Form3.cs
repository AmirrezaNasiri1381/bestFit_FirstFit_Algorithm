using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryUsage
{
    public partial class Form3 : Form
    {
        int[] blockSize = {100,100, 100 };
        
        int[] processSize = { 0, 0, 0 };

        
        public Form3()
        {
            
            InitializeComponent();

        }

        
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Number_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Number1.Value == 0||Number2.Value==0||numericUpDown3.Value==0)
            {
                MessageBox.Show("please Enter Number");
            }
        
            else
            {
                processSize[0]    =(int) Number1.Value;
                processSize[1] = (int)Number2.Value;
                processSize[2] = (int)numericUpDown3.Value;



                int m = blockSize.Length;
                int n = processSize.Length;

                bestFit(blockSize, m, processSize,n);

                
            }





        }

      

        private void Form3_Load(object sender, EventArgs e)
        {


        }

        private void lbloutPut_Click(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void bestFit(int[] blockSize, int m,
                     int[] processSize, int n)
        {

            // Stores block id of the block  
            // allocated to a process 
            int[] allocation = new int[n];

            // Initially no block is assigned to 
            // any process 
            for (int i = 0; i < allocation.Length; i++)
                allocation[i] = -1;

            // pick each process and find suitable 
            // blocks according to its size ad 
            // assign to it 
            for (int i = 0; i < n; i++)
            {

                // Find the best fit block for 
                // current process 
                int bestIdx = -1;
                for (int j = 0; j < m; j++)
                {
                    if (blockSize[j] >= processSize[i])
                    {
                        if (bestIdx == -1)
                            bestIdx = j;
                        else if (blockSize[bestIdx]
                                       > blockSize[j])
                            bestIdx = j;
                    }
                }

                // If we could find a block for 
                // current process 
                if (bestIdx != -1)
                {

                    // allocate block j to p[i]  
                    // process 
                    allocation[i] = bestIdx;

                    // Reduce available memory in 
                    // this block. 
                    blockSize[bestIdx] -= processSize[i];
                }
            }

            textBox1.AppendText("\nProcess Number.\tProcess"
                            + " Size\tBlock number.");
            textBox1.AppendText(Environment.NewLine);
            for (int i = 0; i < n; i++)
            {
                textBox1.AppendText(Environment.NewLine);
                textBox1.AppendText(" " + (i + 1) + "\t\t"
                        + processSize[i] + "\t\t");

                if (allocation[i] != -1)
                {
                 
                    textBox1.AppendText(  allocation[i] + 1+"");
                }
                else
                {
                  
                    textBox1.AppendText("Not Allocated");
                }
              
            }

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }
    }

}

