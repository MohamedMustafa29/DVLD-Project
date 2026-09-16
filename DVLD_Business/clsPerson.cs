using DVLD_DataAccess;
using System.Data;
using System.Net;
using System.Reflection;

namespace DVLD_Business
{
    public class clsPerson
    {
        enum enMode {Update,Add };
        enMode Mode = enMode.Add;

        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public clsCountries NationalityInfo { get; set; }
        public string ImagePath { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + SecondName + " " + ThirdName + " " + LastName;
            }
        }


        private clsPerson(int personID, string nationalNo, string firstName, string secondName, string thirdName, string lastName, DateTime dateOfBirth, byte gender, string address, string phone, string email, int nationalityCountryID, string imagePath)
        {
            PersonID = personID;
            NationalNo = nationalNo;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Address = address;
            Phone = phone;
            Email = email;
            NationalityCountryID = nationalityCountryID;
            this.NationalityInfo=clsCountries.Find(nationalityCountryID);
            ImagePath = imagePath;

            Mode = enMode.Update;
        }

        public clsPerson()
        {
            PersonID = -1;
            NationalNo = "";
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";
            DateOfBirth =DateTime.Now;
            Gender = 0;
            Address = "";
            Phone = "";
            Email = "";
            NationalityCountryID = 0;
            ImagePath = "";


            Mode = enMode.Add;
        }

        public static DataTable FindAllPeople()
        {
            return clsPeopleData.Getallcontacts();

        }


        private bool AddNewPerson()
        {
            this.PersonID = clsPeopleData.AddPerson(
                this.NationalNo,
                this.FirstName,
                this.SecondName,
                this.ThirdName,
                this.LastName,
                this.DateOfBirth,
                this.Gender,
                this.Address,
                this.Phone,
                this.Email,
                this.NationalityCountryID,
                this.ImagePath);

            return (this.PersonID != -1);
         
        }

        private bool UpdatePerson()
        {
            return clsPeopleData.UpdatePerson(
                this.PersonID,
                this.NationalNo,
                this.FirstName,
                this.SecondName,
                this.ThirdName,
                this.LastName,
                this.DateOfBirth,
                this.Gender,
                this.Address,
                this.Phone,
                this.Email,
                this.NationalityCountryID,
                this.ImagePath);
         }

        public static bool DeletePerson(int PersonID)
        {
            return clsPeopleData.Delete(PersonID);
        }

        public static clsPerson FindPeopleByID(int PersonID)
        {
            string firstName = "", secondName = "",
            thirdName = "", lastName = "", nationalNo = "", address = "", phone = "", email = "", imagePath = "";
            byte gender = 0;
            int nationalityCountryID = 0;
            DateTime dateOfBirth = DateTime.Now;

           if(clsPeopleData.GetPersonByPersonID(PersonID,ref nationalNo,ref firstName,ref secondName,ref thirdName,ref lastName,ref dateOfBirth,
               ref gender,ref address,ref phone,ref email,ref nationalityCountryID,ref imagePath))
            {
                return new clsPerson(
                    PersonID,
                    nationalNo,
                    firstName, 
                    secondName,
                    thirdName,
                    lastName, 
                    dateOfBirth,
                    gender,
                    address,
                    phone,
                    email,
                    nationalityCountryID,
                    imagePath);
            }
            else
            {
                return null;
            }

        }


        public static clsPerson FindPeopleByNationalNo(string NationalNo)
        {
            string firstName = "", secondName = "", thirdName = "", lastName = "",
                   address = "", phone = "", email = "", imagePath = "";
            byte gender = 0;
            int nationalityCountryID = 0;
            int personID = -1;
            DateTime dateOfBirth = DateTime.Now;

            if (clsPeopleData.GetPersonByNationalNo(NationalNo, ref personID, ref firstName, ref secondName, ref thirdName, ref lastName, ref dateOfBirth,
                ref gender, ref address, ref phone, ref email, ref nationalityCountryID, ref imagePath))
            {
                return new clsPerson(
                    personID,
                    NationalNo,
                    firstName,
                    secondName,
                    thirdName,
                    lastName,
                    dateOfBirth,
                    gender,
                    address,
                    phone,
                    email,
                    nationalityCountryID,
                    imagePath);
            }
            else
            {
                return null;
            }
        }



        public bool Save()
        {
            switch(Mode)
            {
                case enMode.Add:
                    if (AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return UpdatePerson();
                default:
                    return false;
            }

        }



        public static bool IsPersonExist(string nationalNo)
        {
            return clsPeopleData.IsPersonExist(nationalNo);
        }

    }
}
