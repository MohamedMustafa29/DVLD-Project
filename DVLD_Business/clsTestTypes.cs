using System;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsTestTypes
    {
        public enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3 };

        public enTestType ID { set; get; }
        public string TestTypeTitle { set; get; }
        public string TestTypeDescription { set; get; }
        public decimal TestTypeFees { set; get; }

        private clsTestTypes(enTestType testTypeID, string testTypeTitle, string testTypeDescription, decimal testTypeFees)
        {
            this.ID = testTypeID;
            this.TestTypeTitle = testTypeTitle;
            this.TestTypeDescription = testTypeDescription;
            this.TestTypeFees = testTypeFees;
        }

        public clsTestTypes()
        {
            this.ID = enTestType.VisionTest;
            this.TestTypeTitle = "";
            this.TestTypeDescription = "";
            this.TestTypeFees = 0;
        }

        public static DataTable GetAllTestTypes()
        {
            return clsTestTypesData.GetAllTestTypes();
        }

        private bool _UpdateTestType()
        {
            return clsTestTypesData.UpdateTestType(
                (int)this.ID,
                this.TestTypeTitle,
                this.TestTypeDescription,
                this.TestTypeFees
            );
        }

        public static clsTestTypes Find(enTestType testTypeID)
        {
            string testTypeTitle = "";
            string testTypeDescription = "";
            decimal testTypeFees = 0;

            if (clsTestTypesData.GetTestTypeInfoByID((int)testTypeID, ref testTypeTitle, ref testTypeDescription, ref testTypeFees))
            {
                return new clsTestTypes(
                    testTypeID,
                    testTypeTitle,
                    testTypeDescription,
                    testTypeFees);
            }
            else
            {
                return null;
            }
        }

        public bool Save()
        {
            return _UpdateTestType();
        }
    }
}