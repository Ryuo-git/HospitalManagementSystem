using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Data_Structures
{
    public class HospitalGraph
    {
        private Dictionary<string, List<string>> adjacencyList = new Dictionary<string, List<string>>();

        public void AddRoom(string room)
        {
            if (!adjacencyList.ContainsKey(room))
            {
                adjacencyList[room] = new List<string>();
            }
        }

        public void AddConnection(string room1, string room2)
        {
            if (!adjacencyList.ContainsKey(room1)) AddRoom(room1);
            if (!adjacencyList.ContainsKey(room2)) AddRoom(room2);

            adjacencyList[room1].Add(room2);
            adjacencyList[room2].Add(room1);
        }

        public Dictionary<string, List<string>> GetGraph()
        {
            return adjacencyList;
        }
    }

}
