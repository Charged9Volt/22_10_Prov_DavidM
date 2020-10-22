
using System.Runtime.CompilerServices;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System;

namespace Program
{
    public class Book
    {

        //vi vet vad dehär är 
        private Random generator = new Random();


        // Catagory slumper 1 av 3 potensiela sorters böcker. Där de fins Magic, Discovery och religion; 
        public string Catagory
        {
            
            int Chanse = sss.Next(1,4)

            string[] bCatagory = new string{"Magic", "Discovery", "Religion"};
            
            //skulle kunat göra en mer effectiv metod istället där värdet bara går rakt in i bCatagory
            if (Chanse == 1)
            {
            return bCatagory[1];
            }
            if (Chanse == 2)
            {
            return bCatagory[2];
            }
            
            if (Chanse == 3){
            Return bCatagory[3];
            }
        }

        private int actualValue{
            int acualValue = generator.Next(11);
            System.Console.WriteLine(acualValue);
            Console.ReadLine();
        }

        // private bool curse = true (acualValue)
        // {
        //     int currsed = generator.Next(11)
        //     if currsed > 8;
        //     {
        //     bool curse = true 
        //     acualValue -= 5;
        //     }
        //     else
        //     {
        //     bool curse = false;
        //     }
        // }

        public int Price
        {
            int price = generator.Next(11);
            System.Console.WriteLine(price);
            Console.readline();
        }


        private string bName;

        private int rare;

        public void Book;
        
        


    public string spooky = "SPOOOKY";


    }
}
