using DVLD_DataAccess;
using System.Data;

public class clsLicenseClass
{
    
    
    public enum enMode { AddrNew = 0, Update = 1 };
    public enMode Mode = enMode.AddrNew;

    public int LicenseClassID { set; get; }
    public string ClassName { set; get; }
    public string ClassDescription { set; get; }
    public byte MinimumAllowedAge { set; get; }
    public byte DefaultValidityLength { set; get; }
    public decimal ClassFees { set; get; }

    public clsLicenseClass()
    {
        this.LicenseClassID = -1;
        this.ClassName = "";
        this.ClassDescription = "";
        this.MinimumAllowedAge = 18;
        this.DefaultValidityLength = 10;
        this.ClassFees = 0;

        Mode = enMode.AddrNew;
    }

    private clsLicenseClass(int licenseClassID, string className, string classDescription,
                            byte minimumAllowedAge, byte defaultValidityLength, decimal classFees)
    {
        this.LicenseClassID = licenseClassID;
        this.ClassName = className;
        this.ClassDescription = classDescription;
        this.MinimumAllowedAge = minimumAllowedAge;
        this.DefaultValidityLength = defaultValidityLength;
        this.ClassFees = classFees;

        Mode = enMode.Update;
    }

    public static clsLicenseClass Find(int licenseClassID)
    {
        string className = "";
        string classDescription = "";
        byte minimumAllowedAge = 18;
        byte defaultValidityLength = 10;
        decimal classFees = 0;

        bool isFound = clsLicensesClassesData.GetLicenseClassInfoByID(
            licenseClassID, ref className, ref classDescription,
            ref minimumAllowedAge, ref defaultValidityLength, ref classFees
        );

        if (isFound)
        {
            return new clsLicenseClass(licenseClassID, className, classDescription,
                                      minimumAllowedAge, defaultValidityLength, classFees);
        }
        else
        {
            return null;
        }
    }

    public static clsLicenseClass Find(string className)
    {
        int licenseClassID = -1;
        string classDescription = "";
        byte minimumAllowedAge = 18;
        byte defaultValidityLength = 10;
        decimal classFees = 0;

        bool isFound = clsLicensesClassesData.GetLicenseClassInfoByName(
            className, ref licenseClassID, ref classDescription,
            ref minimumAllowedAge, ref defaultValidityLength, ref classFees
        );

        if (isFound)
        {
            return new clsLicenseClass(licenseClassID, className, classDescription,
                                      minimumAllowedAge, defaultValidityLength, classFees);
        }
        else
        {
            return null;
        }
    }

    public static bool IsLicenseExistByPersonID(int PersonID, int LicenseClassID)
    {
        return clsLicensesClassesData.IsLicenseExistByPersonID(PersonID, LicenseClassID);
    }

    public static DataTable GetAllLicenseClasses()
    {
        return clsLicensesClassesData.GetAllLicenseClasses();
    }
}

