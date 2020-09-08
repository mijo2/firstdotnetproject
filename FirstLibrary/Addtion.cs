using System;

namespace FirstLibrary
{
    public class Addition
    {
        public string display(){
            System.Console.WriteLine("I am in library!");
            return "ok!";
        }

        public int add(int x, int y){
            return x + y;
        }

        public int substract(int x, int y){
            return x - y;
        }

    }
}
