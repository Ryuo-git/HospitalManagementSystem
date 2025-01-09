using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Data_Structures
{
    public class Appointment
    {
        public string PatientName { get; set; }
        public int ID { get; set; }
    }

    public class AppointmentQueue
    {
        private Queue<Appointment> queue = new Queue<Appointment>();

        public void AddAppointment(string patientName, int id)
        {
            queue.Enqueue(new Appointment { PatientName = patientName, ID = id});
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
