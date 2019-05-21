using System;
namespace OOPS
{
    public class License
    {
        private string firstName { get; set; }
        private string lastName { get; set; }
        private int number { get; set; }
        private bool isMale { get; set; }
        public License()
        {
        }
        public string getName()
        {
            return firstName + " " + lastName;
        }
        public string getGender()
        {
            if (isMale)
            {
                return "Male";
            }
            else
            {
                return "Female";
            }
        }
        public int getNumber()
        {
            return this.number;
        }
    }
}
