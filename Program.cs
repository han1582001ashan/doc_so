
using System;
using System.Globalization;
namespace Month
{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Type a number: ");
           int input = Int32.Parse(Console.ReadLine());
           string tram="";
           string chuc="";
           string donvi="";

           switch (input/100){
            
            case 1:
            {
                tram= "one hundred";
                break;
            }
             case 2:
            {
                tram= "two hundred";
                break;
            }
             case 3:
            {
                tram= "three hundred";
                break;
            }
             case 4:
            {
                tram= "four hundred";
                break;
            }
             case 5:
            {
                tram= "five hundred";
                break;
            }
             case 6:
            {
                tram= "six hundred";
                break;
            }
             case 7:
            {
                tram= "seven hundred";
                break;
            }
             case 8:
            {
                tram= "eight hundred";
                break;
            }
             case 9:
            {
                tram= "nine hundred";
                break;
            }

           }
           if((input%100) >10 && (input%100)<20 ){
            switch (input%100){
            
            case 11:
            {
                chuc= "eleven";
                break;
            }
             case 12:
            {
                chuc= "twelve";
                break;
            }
             case 13:
            {
                chuc= "thirdteen";
                break;
            }
             case 14:
            {
                chuc= "fourteen";
                break;
            }
             case 15:
            {
                chuc= "fifteen";
                break;
            }
             case 16:
            {
                chuc= "sixteen";
                break;
            }
             case 17:
            {
                chuc= "seventeen";
                break;
            }
             case 18:
            {
                chuc= "eightteen";
                break;
            }
             case 19:
            {
                chuc= "nineteen";
                break;
            }
           }
           }
           else {
            switch((input % 100)/ 10){
            case 1:
            {
                chuc= "ten";
                break;
            }
             case 2:
            {
                chuc= "twenty";
                break;
            }
             case 3:
            {
                chuc= "thirdty";
                break;
            }
             case 4:
            {
                chuc= "fourty";
                break;
            }
             case 5:
            {
                chuc= "fifty";
                break;
            }
             case 6:
            {
                chuc= "sixty";
                break;
            }
             case 7:
            {
                chuc= "seventy";
                break;
            }
             case 8:
            {
                chuc= "eighty";
                break;
            }
             case 9:
            {
                chuc= "ninety";
                break;
            }
            } 
        }
        switch((input % 100)%10){
           case 1:
            {
                donvi= "one";
                break;
            }
             case 2:
            {
                donvi= "two";
                break;
            }
             case 3:
            {
                donvi= "three";
                break;
            }
             case 4:
            {
                donvi= "four";
                break;
            }
             case 5:
            {
                donvi= "five";
                break;
            }
             case 6:
            {
                donvi= "six";
                break;
            }
             case 7:
            {
                donvi= "seven";
                break;
            }
             case 8:
            {
                donvi= "eight";
                break;
            }
             case 9:
            {
                donvi= "nine";
                break;
            }
            default: donvi = ""; break;
        }
        if(input<10){
        Console.WriteLine(donvi);

        }
        else if(input <100){
            Console.WriteLine(chuc + "-"+donvi);
        }
         else if(input <1000){
            Console.WriteLine(tram +" and "+chuc + donvi);
        }

        }
    }
}
