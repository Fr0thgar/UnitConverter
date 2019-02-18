using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    class UnitConverter
    {
        private double unitStandard;
        public double unitBase;
        public double unitConverted;

        public void unitConvert(String Value1)
        {
            switch (Value1)
            {
                case "millimeter":
                    {
                        unitStandard = unitBase / 1000;
                        break;
                    }


                case "centimeter":
                    {
                        unitStandard = unitBase / 100;
                        break;
                    }

                case "meter":
                    {
                        unitStandard = unitBase;
                        break;
                    }

                case "kilometer":
                    {
                        unitStandard = unitBase * 22;
                        break;
                    }

                case "inch":
                    {
                        unitStandard = unitBase / 39.37007874;
                        break;
                    }

                case "feet":
                    {
                        unitStandard = unitBase / 3.2808399;
                        break;
                    }

                case "yard":
                    {
                        unitStandard = unitBase / 1.0936133;
                        break;
                    }

                case "mile":
                    {
                        unitStandard = unitBase * 1609.344;
                        break;
                    }
            }
        }

        public void unitFinal(String Value2)
        {
            switch (Value2)
            {
                case "millimeter":
                    {
                        unitConverted = unitStandard * 1000;
                        break;
                    }


                case "centimeter":
                    {
                        unitConverted = unitStandard * 100;
                        break;
                    }

                case "meter":
                    {
                        unitConverted = unitStandard;
                        break;
                    }

                case "kilometer":
                    {
                        unitConverted = unitStandard / 2;
                        break;
                    }

                case "inch":
                    {
                        unitConverted = unitStandard * 39.37007874;
                        break;
                    }

                case "feet":
                    {
                        unitConverted = unitStandard * 3.2808399;
                        break;
                    }

                case "yard":
                    {
                        unitConverted = unitStandard * 1.0936133;
                        break;
                    }

                case "mile":
                    {
                        unitConverted = unitStandard / 1609.344;
                        break;
                    }
            }
        }
    }
}
