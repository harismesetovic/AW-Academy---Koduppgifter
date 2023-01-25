using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_Fundamental
{
    internal class Car
    {
        //private string licenseNumber;
        //private string color;
        //public void SetLicenseNumber(string newLicenseNumber)
        //{
        //    licenseNumber = newLicenseNumber;
        //}

        //public string GetLicenseNumber()
        //{
        //    return licenseNumber;
        //}

        //public void SetColor(string newColor)
        //{
        //    color = newColor;
        //}

        //public string GetColor()
        //{
        //    return color;
        //}
        private string licenseNumber;


        public string LicenseNumber
        {
            get 
            { 
                return licenseNumber.ToUpper();
            }
            set
            {
                if (value.Length != 6)
                    throw new FormatException("The license number has to be exactly 6 characters long");
                licenseNumber = value;
            }
        }

        private string color;

        public string Color
        {
            get 
            { 
                return color; 
            }
            set 
            {
                if (value != "red" && value != "green" && value != "blue" && value != "yellow")
                    throw new ArgumentException("Invalid color, only red, green, blue or yellow is accepted.");
                color = value; 
            }
        }


    }
}
