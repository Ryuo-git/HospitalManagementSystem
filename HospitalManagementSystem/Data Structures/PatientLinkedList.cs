//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HospitalManagementSystem.Data_Structures
//{
//    public class Patient
//    {
//        public string Name { get; set; }
//        public int Age { get; set; }
//        public int ID { get; set; }
//        public string Illness { get; set; }
//        public Patient Next { get; set; }
//    }

//    public class PatientLinkedList
//    {
//        private Patient head;

//        public void AddPatient(string name, int age, int id, string illness)
//        {
//            var newPatient = new Patient { Name = name, Age = age, ID = id, Illness = illness };
//            if (head == null)
//            {
//                head = newPatient;
//            }
//            else
//            {
//                var current = head;
//                while (current.Next != null)
//                {
//                    current = current.Next;
//                }
//                current.Next = newPatient;
//            }
//        }

//        public List<Patient> GetPatients()
//        {
//            var result = new List<Patient>();
//            var current = head;
//            while (current != null)
//            {
//                result.Add(current);
//                current = current.Next;
//            }
//            return result;
//        }

//        public void DeletePatient(int id)
//        {
//            if (head == null) return;
//            if (head.ID == id)
//            {
//                head = head.Next;
//                return;
//            }

//            var current = head;
//            while (current.Next != null && current.Next.ID != id)
//            {
//                current = current.Next;
//            }

//            if (current.Next != null)
//            {
//                current.Next = current.Next.Next;
//            }
//        }
//    }

//}
