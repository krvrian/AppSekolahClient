using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSekolahClient
{
    public class EmployeesMain
    {
        public string id { get; set; }
        public string noUrut { get; set; }
        public string full_name { get; set; }
        public string gender { get; set; }
        public string birth_place { get; set; }
        public string birth_date { get; set; }
        public string religion { get; set; }
        public string nation { get; set; }
        public string marriage_status { get; set; }
        public string school_level { get; set; }
        public EmployeesMarriage employees_marriage { get; set; }
        public List<EmployeesChilds> employees_childs { get; set; }
        public EmployeesHomeHealth employees_homehealth { get; set; }
        public List<EmployeesFormalEducation> employees_formal_education { get; set; }
        public List<EmployeesInformalEducation> employees_informal_education { get; set; }
        public EmployeesInformation employees_information { get; set; }
        public List<EmployeesDetails> employees_detail { get; set; }
        public List<EmployeesActivity> employees_activity { get; set; }
        public List<EmployeesHobby> employees_hobby { get; set; }
    }
    public class EmployeesMarriage
    {
        public string id { get; set; }
        public string main_id { get; set; }
        public string full_name { get; set; }
        public string birth_date { get; set; }
        public string marriage_date { get; set; }
        public string information { get; set; }
    }
    public class EmployeesChilds
    {
        public string id { get; set; }
        public string main_id { get; set; }
        public string full_name { get; set; }
        public string child_status { get; set; }
        public string birth_place { get; set; }
        public string birth_date { get; set; }
        public string parent_name { get; set; }
    }
    public class EmployeesHomeHealth
    {
        public string id { get; set; }
        public string main_id { get; set; }
        public string address { get; set; }
        public string home_status { get; set; }
        public string phone_number { get; set; }
        public string distance { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public string blood_type { get; set; }
        public string sickness { get; set; }
        public string disability { get; set; }
    }
    public class EmployeesFormalEducation
    {
        public string id { get; set; }
        public string main_id { get; set; }
        public string type { get; set; }
        public string certificate { get; set; }
        public string year { get; set; }
    }
    public class EmployeesInformalEducation
    {
        public string id { get; set; }
        public string main_id { get; set; }
        public string type { get; set; }
        public string place { get; set; }
        public string years { get; set; }
        public string months { get; set; }
        public string days { get; set; }
        public string level { get; set; }
        public string information { get; set; }
    }
    public class EmployeesInformation
    {
        public string id { get; set; }
        public string main_id { get; set; }
        public string status_employee { get; set; }
        public string nip { get; set; }
        public string karpeg { get; set; }
        public string taspen { get; set; }
    }
    public class EmployeesDetails
    {
        public string id { get; set; }
        public string main_id { get; set; }
        public string rank_class { get; set; }
        public string position { get; set; }
        public string salary { get; set; }
        public string start_date { get; set; }
        public string information { get; set; }
    }
    public class EmployeesActivity
    {
        public string id { get; set; }
        public string main_id { get; set; }
        public string name_activity { get; set; }
        public string position { get; set; }
        public string status { get; set; }
    }
    public class EmployeesHobby
    {
        public string id { get; set; }
        public string main_id { get; set; }
        public string name_hobby { get; set; }
        public string status { get; set; }
    }
}
