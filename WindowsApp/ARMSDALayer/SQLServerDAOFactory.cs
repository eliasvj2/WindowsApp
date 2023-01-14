using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMSDALayer
{
    public class SQLServerDAOFactory: DALObjectFactoryBase
    {
        public static string ConnectionString()
        {
            return "Data Source =.\\SQLExpress; Initial Catalog = EZRentalDB; Integrated Security = True";

        }
        public override CreditCardDAO GetCreditCardDAO()
        {
            //return CreditCardDAO Data Access Object to perform CreditCard class Data Access
            return new CreditCardDAO();

        }
        public override USStateDAO GetUSStateDAO()
        {
            //return USStateDAO Data Access Object to perform USState class Data Access
            return new USStateDAO();

        }
        public override CountryDAO GetCountryDAO()
        {
            //return CountryDAO Data Access Object to perform Country class Data Access
            return new CountryDAO();

        }
    }
}
