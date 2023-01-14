 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARMSDALayer;
using System.IO;

namespace ARMSBOLayer
{
    public class Country
    {

        public int CountryID
        {
            get;
            set;
        }
        public string CountryCode2
        {
            get;
            set;
        }
        public string CountryCode3
        {
            get;
            set;
        }
        public string CountryName
        {
            get;
            set;
        }

        public Country()
        {
            this.CountryID = 0;
            this.CountryCode2 = "";
            this.CountryCode3 = "";
            this.CountryName = "";

        }
        public Country(int numCountryID, string strCountryCode2, string strCountryCode3, string strCountryName)
        {
            this.CountryID = numCountryID;
            this.CountryCode2 = strCountryCode2;
            this.CountryCode3 = strCountryCode3;
            this.CountryName = strCountryName;
        }
        ~Country()
        {

        }

        public void Print()
        {
            try
            {
                StreamWriter objCountryfile = new StreamWriter("Network_Printer.txt", true);

                objCountryfile.WriteLine("Country information");
                objCountryfile.WriteLine("Country ID = {0}", CountryID);
                objCountryfile.WriteLine("Country Code 2 Characters = {0}", CountryCode2);
                objCountryfile.WriteLine("Country Code 3 Characters = {0}", CountryCode3);
                objCountryfile.WriteLine("Country Name = {0}", CountryName);

                objCountryfile.WriteLine();

                objCountryfile.Close();
            }

            catch (Exception objE)
            {
                throw new Exception("Unexpected Error in Print() Method {0}" + objE.Message);
            }


        }
        /*
        public bool Load(string key)
        {
            return DALayer_Load(key);
        }

        public bool Insert()
        {

            return DALayer_Insert();
        }


        public bool Update()
        {

            return DALayer_Update();
        }
        public bool Delete(string key)
        {

            return DALayer_Delete(key);
        }
        */
        public static List<Country> GetAllCountries()
        {
            return DALayer_GetAllCountries();
        }
        /*
        protected bool DALayer_Load(string key)
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory to get the SQL Server FACTORY Data Access Object
                //using POLYMORPHISM.
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Step 2-now that you have the sql FACTORY data access object 
                //call the correct Data Access Object to perform the Data Access
                CountryDAO objCountryDAO = objDAOFactory.GetCountryDAO();

                //Step 3-Call DATA ACCESS LAYER CreditCardDAO Data Access Object to do the work
                CountryDTO objCountryDTO = objCountryDAO.GetRecordByID(key);

                //Step 4- test if DTO object exists & populate this object with DTO object's properties
                //and return a true or return a False if no DTO object exists.
                if (objCountryDTO != null)
                {
                    //Step 4a-get the data from the Data Transfer Object
                    this.CountryID = objCountryDTO.CoutryID;
                    this.CountryCode2 = objCountryDTO.CountryCode2;
                    this.CountryCode3 = objCountryDTO.CountryCode3;
                    this.CountryName = objCountryDTO.CountryName;
                    

                    

                    //Step 4c-Returns a true since this class object has been populated.
                    return true;
                }
                else
                {
                    //Step 5- No object returned from DALayer, return a false
                    return false;
                }

            }//End of try
             //Step B-Traps for general exception.  
            catch (Exception objE)
            {
                //Step C-Re-Throw an general exceptions
                throw new Exception("Unexpected Error in DALayer_Load(key) Method: {0} " + objE.Message);
            }
        }//End of method



        protected bool DALayer_Insert()
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory to get the SQL Server FACTORY Data Access Object
                //using POLYMORPHISM.
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Step 2-now that you have the sql FACTORY data access object 
                //call the correct Data Access Object to perform the Data Access
                CountryDAO objCountryDAO = objDAOFactory.GetCountryDAO();

                //Step 3-Create new Data Transfer Object to send to DA Later for DATA ACCESS LAYER
                CountryDTO objCountryDTO = new CountryDTO();

                //Step 4- POPULATE the Data Transfer Object with data from THIS OBJECT to send to database
                objCountryDTO.CountryID = this.CountryID;
                objCountryDTO.CountryCode2 = this.CountryCode2;
                objCountryDTO.CountryCode3 = this.CountryCode3;
                objCountryDTO.CountryName = this.CountryName;
                

                //Step 5-Call DATA ACCESS LAYER CreditCardDAO Data Access Object to do the work
                bool inserted = objCountryDAO.Insert(objCountryDTO);

                //Step 6- test if insert to database was successful return true,
                //otherwise return false
                if (inserted == true)
                {

                    //Step 6b-Returns a true since this class object has been inserted & marked as old.
                    return true;
                }
                else
                {
                    //Step 7- No record inserted, return a false
                    return false;

                }



            }//End of try
             //Step B-Traps for general exception.  
            catch (Exception objE)
            {
                //Step C-Re-Throw an general exceptions
                throw new Exception("Unexpected Error in DALayer_Insert() Method: {0} " + objE.Message);

            }

        }//End of method



        protected bool DALayer_Update()
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory to get the SQL Server FACTORY Data Access Object
                //using POLYMORPHISM.
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Step 2-now that you have the sql FACTORY data access object 
                //call the correct Data Access Object to perform the Data Access
                CountryDAO objCountryDAO = objDAOFactory.GetCountryDAO();

                //Step 3-Create new Data Transfer Object to send to DA Later for DATA ACCESS LAYER
                CountryDTO objCountryDTO = new CountryDTO();

                //Step 4- POPULATE the Data Transfer Object with data from THIS OBJECT to send to database
                objCountryDTO.CountryID = this.CountryID;
                objCountryDTO.CountryCode2 = this.CountryCode2;
                objCountryDTO.CountryCode3 = this.CountryCode3;
                objCountryDTO.CountryName = this.CountryName;
                


                //Step 5-Call DATA ACCESS LAYER CreditCardDAO Data Access Object to do the work
                bool updated = objCountryDAO.Update(objCountryDTO);

                //Step 6- test if update to database was successful & MARK the object as old return true,
                //otherwise return false
                if (updated == true)
                {

                    //Step 6b-Returns a true since this class object has been updated.
                    return true;
                }
                else
                {
                    //Step 7- No record updated, return a false
                    return false;

                }

            }//End of try
             //Step B-Traps for general exception.  
            catch (Exception objE)
            {
                //Step C-Re-Throw an general exceptions
                throw new Exception("Unexpected Error in DALayer_Update() Method: {0} " + objE.Message);

            }

        }//End of method




        protected bool DALayer_Delete(string key)
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory to get the SQL Server FACTORY Data Access Object
                //using POLYMORPHISM.
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Step 2-now that you have the sql FACTORY data access object 
                //call the correct Data Access Object to perform the Data Access
                CountryDAO objCountryDAO = objDAOFactory.GetCountryDAO();

                //Step 3-Call DATA ACCESS LAYER CreditCardDAO Data Access Object to do the work
                bool deleted = objCountryDAO.Delete(key);


                //Step 4- Test if delete to database was successful & MARK the object as NEW since
                //deleted from database and NEW in memory and return a true, otherwise return false
                if (deleted == true)
                {

                    //Step 4b-Returns a true since this class object has been deleted & marked as NEW.
                    return true;
                }
                else
                {
                    //Step 5-No record deleted, return a false
                    return false;

                }

            }//End of try
             //Step B-Traps for general exception.  
            catch (Exception objE)
            {
                //Step C-Re-Throw an general exceptions
                throw new Exception("Unexpected Error in DALayer_Update() Method: {0} " + objE.Message);

            }

        }//End of method
        */

        protected static List<Country> DALayer_GetAllCountries()
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory to get the SQL Server FACTORY Data Access Object
                //using POLYMORPHISM.
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Step 2-now that you have the SQL FACTORY object GET DAO object to do the work
                CountryDAO objCountryDAO = objDAOFactory.GetCountryDAO();

                //Step 3-call CountryDAO DAO to do the work & return COLLECTION of Data Transfer Objects
                List<CountryDTO> objCountryDTOList = objCountryDAO.GetAllRecords();


                //Step 4- test if List<CountryDTO> DTO collection exists 
                if (objCountryDTOList != null)
                {

                    //Step 5-Create a LIST Collection of Country object to get copy of DTO collection
                    List<Country> objCountryList = new List<Country>();

                    //Step 6-Loop through List<CountryDTO> objCountryDTOList collection
                    foreach (CountryDTO objDTO in objCountryDTOList)
                    {

                        //Step 6a-Create new Country object
                        Country objCountry = new Country();


                        //Step 6b-get the data from DTO object and SET Country object
                        objCountry.CountryID = objDTO.CountryID;
                        objCountry.CountryCode2 = objDTO.CountryCode2;
                        objCountry.CountryCode3 = objDTO.CountryCode3;
                        objCountry.CountryName = objDTO.CountryName;

                        //Step 6c-Add Country Object to the objCountryList List<Country> COLLECTION  
                        objCountryList.Add(objCountry);

                    }//End of foreach

                    //Step 6d-once copy process ends, Return objCountryList List<Country> COLLECTION
                    return objCountryList;

                }


                else
                {
                    //Step 6e- No DTO collection object returned from DALayer, return a null
                    return null;
                }

            }//End of try

            //Step B-Traps for general exception.  
            catch (Exception objE)
            {
                //Step C-Re-Throw a general exceptions
                throw new Exception("Unexpected Error in DALayer_GetAllCountries Method: {0} " + objE.Message);

            }

        }//End of method

    }
}
