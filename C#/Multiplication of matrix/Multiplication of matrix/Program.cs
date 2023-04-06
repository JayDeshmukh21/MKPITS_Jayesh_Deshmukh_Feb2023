using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_of_matrix
{
    internal class Program
    {  
public class Exercise22 
        {  
          public static void Main()
          { 
            int i,j,r,c;
      	    
		    int[,] arr1 = new int[10,10];

  
            Console.Write("\n\nTranspose of a Matrix :\n");
            Console.Write("---------------------------\n"); 
   
            Console.Write("\nInput the number of rows and columns of the first matrix :\n");	   
            Console.Write("Rows : ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Columns : ");  
            c = Convert.ToInt32(Console.ReadLine());	   
	   

            Console.Write("Input elements in the matrix :\n");
            for(i=0;i<r;i++)
            {
                for(j=0;j<c;j++)
                {
	                Console.Write("element - [{0}],[{1}] : ",i,j);
			        arr1[i,j]=Convert.ToInt32(Console.ReadLine());	 
                }
            } 

 	        Console.Write("\nThe First matrix is :\n");
  		    for(i=0;i<r;i++)
    		{

                    for (j = 0; j < c; j++)
                    {
                        Console.Write("{0}\t", arr1[i, j]);
                    }
                    Console.WriteLine();
    		}
  
            

            Console.Write("\n\nThe Transpose of a matrix is : ");
            for(i=0;i<r;i++)
	        {
                 Console.Write("\n");
                    for(j=0;j<c;j++)
	                {
                        Console.Write("{0}\t",arr1[j,i]);
                    }
                    Console.WriteLine();
            }
            Console.ReadLine();
	      }
        }

    }
}
