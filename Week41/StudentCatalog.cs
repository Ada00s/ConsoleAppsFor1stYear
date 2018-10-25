using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week41
{
    public class StudentCatalog
    {
        private Dictionary<int, Student> _students;

        public StudentCatalog()
        {
            _students = new Dictionary<int, Student>();
        }

        /// <summary>
        /// Return the number of students in the catalog.
        /// </summary>
        public int Count
        {
            // The below must be changed
            get { return _students.Count; }
        }

        /// <summary>
        /// Add a single student to the catalog.
        /// </summary>
        public void AddStudent(Student aStudent)
        {
            _students.Add(aStudent.ID, aStudent);
        }

        /// <summary>
        /// Given an id, return the student with that id.
        /// If no student exists with the given id, return null.
        /// </summary>
        public Student GetStudent(int id)
        {
            Student returned =_students.FirstOrDefault(x => x.Value.ID == id).Value;
            return returned;
        }

        /// <summary>
        /// Given an id, return the score average for the student with that id.
        /// If no student exists with the given id, return -1.
        /// </summary>
        public int GetAverageForStudent(int id)
        {
            Student student = GetStudent(id);
            if (student == null) {return -1; }
            else
            {
                return _students[id].ScoreAverage;
            }
        }

        /// <summary>
        /// Returns the total test score average for ALL students in the catalog.
        /// </summary>
        public int TotalAverage
        {
            // The below must be changed
            get {
                int sum = 0;
                foreach(KeyValuePair<int, Student> KVP in _students)
                {
                    sum = sum + KVP.Value.ScoreAverage;
                }
                return sum / _students.Count;

            }
        }
    }
}
