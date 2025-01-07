using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Data_Structures
{
    public class Appointment
    {
        public int ID { get; set; }
        public string PatientName { get; set; }
    }

    public class AppointmentQueue
    {
        private Queue<Appointment> queue = new Queue<Appointment>();

        public void AddAppointment(int id, string patientName)
        {
            queue.Enqueue(new Appointment { ID = id, PatientName = patientName });
        }

        public Appointment ProcessAppointment()
        {
            return queue.Count > 0 ? queue.Dequeue() : null;
        }

        public List<Appointment> GetAppointments()
        {
            return queue.ToList();
        }
    }

}
