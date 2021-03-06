﻿using System;
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
        static Hospitals[] adultHospital;

        static Hospitals[] childrenHospital;

        public static void LoadData()
        {
            string pathToAdultHospitals = Path.Combine(Directory.GetCurrentDirectory(), "AdultHospitals.json");
            string pathToChildHospitals = Path.Combine(Directory.GetCurrentDirectory(), "ChildHospitals.json");

            string adultHospitalsJson = File.ReadAllText(pathToAdultHospitals, Encoding.Default);
            string childHospitalsJson = File.ReadAllText(pathToChildHospitals, Encoding.Default);

            adultHospital = JsonConvert.DeserializeObject<Hospitals[]>(adultHospitalsJson);
            childrenHospital = JsonConvert.DeserializeObject<Hospitals[]>(childHospitalsJson);
        }

        public static Hospitals[] GetChildrenHospitals()
        {
            return childrenHospital;
        }

        public static Hospitals[] GetAdultHospitals()
        {
            return adultHospital;
        }



    }
    public class Hospitals
    {
        public string PaidServiceInfo { get; set; }

        public string Specialization { get; set; }

        public string ChiefName { get; set; }

        public string ChiefPosition { get; set; }

        public List<PublicPhoneItem> PublicPhone { get; set; }

        public List<EmailItem> Email { get; set; }

        public List<OrgInfoItem> OrgInfo { get; set; }

        public List<ObjectAddressItem> ObjectAddress { get; set; }

        public string ShortName { get; set; }
    }

    public class PublicPhoneItem
    {
        public List<string> PublicPhone { get; set; }
    }

    public class EmailItem
    {
        public string Email { get; set; }
    }

    public class OrgInfoItem
    {
        public string OGRN { get; set; }

        public string ChiefPosition { get; set; }

        public string ChiefName { get; set; }

        public string INN { get; set; }

        public string KPP { get; set; }

        public string LegalAddress { get; set; }

        public string FullName { get; set; }
    }

    public class ObjectAddressItem
    {
        public string PostalCode { get; set; }

        public string AdmArea { get; set; }

        public string District { get; set; }

        public string Address { get; set; }

        public string Extrainfo { get; set; }
    }
}
