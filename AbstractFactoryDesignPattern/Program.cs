using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    //Abstract product
    interface IBike {

        void manufactureBike();
    
    }
    interface ICar
    {
        void manufactureCar();

    }
    //Concrete product
    class HondaCar : ICar
    {
        public void manufactureCar()
        {
            Console.WriteLine("Honda Car is Manufactered..") ;
        }
    }
    class HondaBike : IBike
    {
        public void manufactureBike()
        {
            Console.WriteLine("Honda Bike is Manufactered..");
        }
    }
    class SuzukiCar : ICar
    {
        public void manufactureCar()
        {
            Console.WriteLine("Suzuki Car is Manufactered..");
        }
    }
    class SuzukiBike : IBike
    {
        public void manufactureBike()
        {
            Console.WriteLine("Suzuki Bike is Manufactered..");
        }
    }
    interface Vehicle
    {
        //Bastract factory or super factory
        ICar GetCar();
        IBike GetBike();
    }
    //other factory or concrete factory
    class Honda : Vehicle
    {
        public IBike GetBike()
        {
           return new HondaBike();
        }

        public ICar GetCar()
        {
            return new HondaCar();
        }
    }
    class Suzuki : Vehicle
    {
       
        public IBike GetBike()
        {
            return new SuzukiBike();
        }

        public ICar GetCar()
        {
            return new SuzukiCar();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //client
            // how to use 
            Vehicle honda = new Honda();
            ICar Hondacar =honda.GetCar() ;// new HondaCar()
            IBike HondaBike= honda.GetBike() ; //new HondaBike()
            //Console.WriteLine();
            Hondacar.manufactureCar() ;
            HondaBike.manufactureBike() ;
            Vehicle SUZUKI = new Suzuki();
            ICar Suzukicar = SUZUKI.GetCar();// new SuzukiCar()
            IBike SuzukiBike = SUZUKI.GetBike(); //new SuzukiBike()
            Suzukicar.manufactureCar();
            SuzukiBike.manufactureBike();
           //Console.WriteLine();
            



        }
    }
}
