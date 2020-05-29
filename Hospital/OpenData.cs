using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Hospital
{
    static class OpenData
    {
        static Hospital[] adultHospital;

        static Hospital[] childHospital;

        public static void LoadData()
        {
            string pathToAdultHospitals = Path.Combine(Directory.GetCurrentDirectory(), "AdultHospitals.json");
            string pathToChildHospitals = Path.Combine(Directory.GetCurrentDirectory(), "ChildHospitals.json");

            string adultHospitalsJson = File.ReadAllText(pathToAdultHospitals);
            string childHospitalsJson = File.ReadAllText(pathToChildHospitals);

            adultHospital = JsonConvert.DeserializeObject<Hospital[]>(adultHospitalsJson);
            childHospital = JsonConvert.DeserializeObject<Hospital[]>(childHospitalsJson);
        }

        public static Hospital[] GetChildHospitals()
        {
            return childHospital;
        }

        public static Hospital[] GetAdultHospitals()
        {
            return adultHospital;
        }



    }
    public class Hospital
    {
        public string PaidServiceInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<WorkingHoursItem> WorkingHours { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Specialization { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CloseFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ChiefName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ChiefPosition { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ChiefGender { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ChiefPhoneItem> ChiefPhone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<PublicPhoneItem> PublicPhone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<FaxItem> Fax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<EmailItem> Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> AmbulanceStationPhone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<OrgInfoItem> OrgInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ObjectAddressItem> ObjectAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ShortName { get; set; }
    }

    public class WorkingHoursItem
    {

        /// <summary>
        /// 
        /// </summary>
        public string WorkHours { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DayWeek { get; set; }
    }

    public class ChiefPhoneItem
    {

        /// <summary>
        /// 
        /// </summary>
        public List<string> ChiefPhone { get; set; }
    }

    public class PublicPhoneItem
    {

        /// <summary>
        /// 
        /// </summary>
        public List<string> PublicPhone { get; set; }
    }

    public class FaxItem
    {

        /// <summary>
        /// 
        /// </summary>
        public string Fax { get; set; }
    }

    public class EmailItem
    {

        /// <summary>
        /// 
        /// </summary>
        public string Email { get; set; }
    }

    public class OrgInfoItem
    {

        /// <summary>
        /// 
        /// </summary>
        public string OGRN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ChiefPosition { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ChiefName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ChiefPhoneItem> ChiefPhone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string INN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string KPP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string LegalAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ChiefGender { get; set; }
    }

    public class Available_elementItem
    {

        /// <summary>
        /// 
        /// </summary>
        public string available_index { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Area_mgn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Element_mgn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string available_degree { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Group_mgn { get; set; }
    }

    public class AvailabilityItem
    {

        /// <summary>
        /// 
        /// </summary>
        public List<Available_elementItem> available_element { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string available_o { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string available_z { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string available_s { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string available_k { get; set; }
    }

    public class ObjectAddressItem
    {

        /// <summary>
        /// 
        /// </summary>
        public string PostalCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AdmArea { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string District { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<AvailabilityItem> Availability { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Extrainfo { get; set; }
    }

    public class GeoData
    {

        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<List<double>> coordinates { get; set; }
    }
}
