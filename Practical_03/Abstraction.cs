using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_03
{
    public class Laptop
    {
        //To Hide details of brand and model, decalred private variables
        private string _brand;
        private string _model;
        //Created properties to access get and set brand and model
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        public string Brand
        {
            get
            {
                return _brand;
            }
            set
            {
                _brand = value;
            }
        }
        public void LaptopDetails()
        {
            Console.WriteLine("Brand: " + _brand);
            Console.WriteLine("Model: " + _model);
        }
        //MotherBoardInfo method is declared private so it is inaccessible outside the class where it is declared
        private void MotherBoardInfo()
        {
            Console.WriteLine("MotherBoard Information");
        }
        //To access this method outside the class and maintain it hidden, we can do this : 
        public void getMotherBoardInfo()
        {
            MotherBoardInfo();
        }
    }
}
