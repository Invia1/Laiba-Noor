namespace Variables
{
        #region Write details of a company by using variables

        public class Variables
        {
            //Declaration of the static, readonly static and const variable

            static readonly string companyName; //Common but not changed frequently
            static string compAddress;//Globally Common for all the object
            static string phoneNumber;
            const int founded = 2007; //Universally common and can't be changed


            //Using Constructor to initialize the values
            static Variables()
            {
                companyName = "Invia Pvt. Ltd. Company";
                compAddress = "Sydney, Australia";
                phoneNumber = "9870123456";
            }

            //By this static method we can get the company details
            public static void CompanyDetails()
            {
                Console.WriteLine("Company Name : " + companyName);
                Console.WriteLine("Address : " + compAddress);
                Console.WriteLine("Contact No : " + phoneNumber);
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Founded : " + founded);
                CompanyDetails();
                Console.ReadLine();

            }
        }
        #endregion
    }
