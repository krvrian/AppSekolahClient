using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSekolahClient
{
    public class DataSiswa
    {
        public string nis{ get; set;}
        public string nisn{ get; set;}
        public string full_name{ get; set;}
        public string nickname{ get; set;}
        public string gender{ get; set;}
        public string birth_place{ get; set;}
        public string birth_date{ get; set;}
        public string religion{ get; set;}
        public string nation{ get; set;}
        public string order_family{ get; set;}
        public string siblings{ get; set;}
        public string step_siblings{ get; set;}
        public string foster_siblings{ get; set;}
        public string child_status{ get; set;}
        public string language{ get; set;}
        public HomeHealth studenthome_health{ get; set;}
        public List<Parent> student_parent{ get; set;}
        public Activity student_activity{ get; set;}

    }
    public class HomeHealth
    {
        public string id{ get; set;}
        public string nis{ get; set;}
        public string address{ get; set;}
        public string phone_number{ get; set;}
        public string stay_with{ get; set;}
        public string distance{ get; set;}
        public string blood_type{ get; set;}
        public string sickness{ get; set;}
        public string disability{ get; set;}
        public string height{ get; set;}
        public string weight{ get; set;}
    }
    public class Parent
    {
        public string id{ get; set;}
        public string nis{ get; set;}
        public string parent_type{ get; set;}
        public string name{ get; set;}
        public string birth_place{ get; set;}
        public string birth_date{ get; set;}
        public string religion{ get; set;}
        public string nation{ get; set;}
        public string academy{ get; set;}
        public string occupation{ get; set;}
        public string salary{ get; set;}
        public string address{ get; set;}
        public string phone_number{ get; set;}
        public string status{ get; set;}
    }

    public class Activity
    {
        public string id{ get; set;}
        public string nis { get; set;}
        public string arts { get; set;}
        public string sports { get; set;}
        public string organization { get; set;}
        public string others { get; set;}
        public string date_leave_school { get; set;}
        public string reason_leave_school { get; set;}
        public string graduation_year { get; set;}
        public string certificate { get; set;}
        public string stl_number { get; set;}
        public string score_average { get; set;}
    }
}
