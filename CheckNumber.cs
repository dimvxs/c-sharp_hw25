using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;
using System.Text.RegularExpressions;

namespace hw
{
    public class CheckNumber
    {
        private string[] patterns = { 
                @"^\+380[-\s]?\d{2}[-\s]?\d{3}[-\s]?\d{2}[-\s]?\d{2}$",
                @"^\380[-\s]?\d{2}[-\s]?\d{3}[-\s]?\d{2}[-\s]?\d{2}$",
                @"^\0\d{2}[-\s]?\d{3}[-\s]?\d{2}[-\s]?\d{2}$",
                 @"^\+380\d{9}$",
                 @"^\380\d{9}$",
                 @"^\0\d{9}$"
            };

     


        public CheckNumber(){
            WriteLine("введите номер телефона: ");
            string input = ReadLine();

            bool correct = false;
        
            foreach (string pattern in patterns){
                if(Regex.IsMatch(input, pattern)){
                correct = true;
                Write($"Номер '{input}' соответствует паттерну: {pattern} \n");
                break;
                }
            }

             if(!correct){
                Write("Вы ввели неверный формат номера \n");
               }

           
}
    }
}