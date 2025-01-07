using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Data_Structures
{
    public class Medicine
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
    }

    public class MedicineStack
    {
        private Stack<Medicine> stack = new Stack<Medicine>();

        public void AddMedicine(string name, int quantity)
        {
            stack.Push(new Medicine { Name = name, Quantity = quantity });
        }

        public Medicine RemoveMedicine()
        {
            return stack.Count > 0 ? stack.Pop() : null;
        }

        public List<Medicine> GetMedicines()
        {
            return stack.ToList();
        }
    }

}
