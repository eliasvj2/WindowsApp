using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARMSDALayer;
using System.IO;

namespace ARMSBOLayer
{
    public class USState
    {
        public int StateID { get; set; }

        public string StateCode { get; set; }

        public string StateName { get; set; }

        public USState()
        {
            this.StateID = 0;
            this.StateCode = "";
            this.StateName = "";
        }

        public USState (int m_StateID, string m_StateCode, string m_StateName)
        {
            this.StateID = m_StateID;
            this.StateCode = m_StateCode;
            this.StateName = m_StateName;
        }

        ~USState()
        {

        }

        public void Print()
        {
            try
            {
                StreamWriter objUSStatefile = new StreamWriter("Network_Printer.txt", true);

                objUSStatefile.WriteLine("US State information");
                objUSStatefile.WriteLine("US State ID = {0}", StateID);
                objUSStatefile.WriteLine("US State Code = {0}", StateCode);
                objUSStatefile.WriteLine("US State Name = {0}", StateName);

                objUSStatefile.WriteLine();

                objUSStatefile.Close();
            }

            catch (Exception objE)
            {
                throw new Exception("Unexpected Error in Print() Method {0}"+ objE.Message);
            }

            
        }

        public static List<USState> GetAllUSStates()
        {
            return DALayer_GetAllUSStates();
        }

        protected static List<USState> DALayer_GetAllUSStates()
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory to get the SQL Server FACTORY Data Access Object
                //using POLYMORPHISM.
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Step 2-now that you have the SQL FACTORY object GET DAO object to do the work
                USStateDAO objUSStateDAO = objDAOFactory.GetUSStateDAO();

                //Step 3-call objUSStateDAO DAO to do the work & return COLLECTION of Data Transfer Objects
                List<USStateDTO> objUSStateDTOList = objUSStateDAO.GetAllRecords();


                //Step 4- test if List<objUSState> DTO collection exists 
                if (objUSStateDTOList != null)
                {

                    //Step 5-Create a LIST Collection of objUSState object to get copy of DTO collection
                    List<USState> objUSStateList = new List<USState>();

                    //Step 6-Loop through List<objUSStateDTO> objobjUSStateDTOList collection
                    foreach (USStateDTO objDTO in objUSStateDTOList)
                    {

                        //Step 6a-Create new objUSState object
                        USState objUSState = new USState();


                        //Step 6b-get the data from DTO object and SET objUSState object
                        objUSState.StateID = objDTO.StateID;
                        objUSState.StateCode = objDTO.StateCode;
                        objUSState.StateName = objDTO.StateName;

                        //Step 6c-Add objUSState Object to the objUSStateList List<objUSState> COLLECTION  
                        objUSStateList.Add(objUSState);

                    }//End of foreach

                    //Step 6d-once copy process ends, Return objobjUSStateList List<objUSState> COLLECTION
                    return objUSStateList;

                }//End of if


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
                throw new Exception("Unexpected Error in DALayer_GetAllUSState Method: {0} " + objE.Message);

            }

        }//End of method

    }
}
