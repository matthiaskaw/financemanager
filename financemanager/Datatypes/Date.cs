using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using financemanager.Exceptions;

namespace financemanager.Datatypes
{
    public enum EMonth {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12
    }

    public static class Extensions{

        public const string CSV = ".csv";
        
        

    
    
    }

    

    public enum DateFormat {
        DDMMYYYY = 0,
        DDMONTHYYYY = 1
    }
    public class Date
    {
        //Private variable/properties
        private int day;
        private EMonth Month;
        private int year;


        public int Day { get {
                return this.day;
            }
            set{
                if (value > 0 && value <= 31)
                {
                    this.day = value;
                }
                else {
                    //throw exception
                    throw new InvalidDayException("Invalid day input");
                }
            }
        }

       

        public EMonth getMonth() { return this.Month; }

        public void setMonth(int month) {

            if (month >= 1 || month <= 12)
            {

                Month = (EMonth)month;
                Console.WriteLine($"Date.setMonth(int month): month = {month}; Date.Month = {this.Month}");
            }
            else {
                //throw exception
                throw new InvalidMonthException("Invalid month input");
            }
        }

        public void setMonth(EMonth month) {
            this.Month = month;

            Console.WriteLine($"Date.setMonth(EMonth month): month = {month}; Date.Month = {this.Month}");


        }

        public int Year { get { return this.year; }
            set{
                if (value <= 2200 || value >= 1900)
                {
                    this.year = value;
                }
                else {
                    throw new InvalidYearException("Invalid year input");
                }
            } 
        }

        public void setDate(int day, EMonth month, int year) {
            this.Day = day;
            this.setMonth(month);
            this.Year = year;

        }

        public void setDate(int day, int month, int year) {

            this.Day = day;
            this.setMonth(month);
            this.Year = year;
        }

        public void setDate(string day, string month, string year) { }

        public void setDate(string date) { }


        public string toString() {
            string day = this.Day.ToString();
            string month = this.getMonth().ToString();
            string year = this.Year.ToString();

            return day + "." + month + "." + year;
        }


    }
}
