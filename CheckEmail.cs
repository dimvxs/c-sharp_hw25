using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;
using System.Text.RegularExpressions;

namespace hw
{
    public class CheckEmail
    {
        private string pattern = @"^[a-z][a-z0-9]+@gmail\.com$";

        public CheckEmail(){
            WriteLine("Введите адрес электронной почты: ");
            string input = ReadLine();

            bool correct = false;

            Regex regex = new Regex(pattern);

            if(regex.IsMatch(input)){
                correct = true;
            }
            if(correct){
                Write("Адрес электронной почты " + $"{input}" + " соответствует всем требованиям \n");
            }
            if(!correct){
                WriteLine("Адрес электронной почты " + $"{input}" + " не соответствует требованиям \n");
            }
        }
    }
}