using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Data_Structures
{
    public class Doctor
    {
        public string Name { get; set; }
        public int Experience { get; set; }
        public string Specialization { get; set; }
        public Doctor Left { get; set; }
        public Doctor Right { get; set; }
    }

    public class DoctorTree
    {
        private Doctor root;

        public void AddDoctor(string name, int experience, string specialization)
        {
            var newDoctor = new Doctor { Name = name, Experience = experience, Specialization = specialization };
            if (root == null)
            {
                root = newDoctor;
            }
            else
            {
                AddDoctorRecursive(root, newDoctor);
            }
        }

        private void AddDoctorRecursive(Doctor current, Doctor newDoctor)
        {
            if (newDoctor.Experience < current.Experience)
            {
                if (current.Left == null) current.Left = newDoctor;
                else AddDoctorRecursive(current.Left, newDoctor);
            }
            else
            {
                if (current.Right == null) current.Right = newDoctor;
                else AddDoctorRecursive(current.Right, newDoctor);
            }
        }

        public List<Doctor> GetAllDoctors()
        {
            var result = new List<Doctor>();
            GetAllDoctorsRecursive(root, result);
            return result;
        }

        private void GetAllDoctorsRecursive(Doctor current, List<Doctor> result)
        {
            if (current == null) return;
            GetAllDoctorsRecursive(current.Left, result);
            result.Add(current);
            GetAllDoctorsRecursive(current.Right, result);
        }
    }

}
