using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Entities
{
    public class Student
    {
        public int Class { get; set; }
        public IEnumerable<Subject> Subjects { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Check if student has all subjects to get through to next class.
        /// </summary>
        /// <returns>True if rules are satisfied, false another.</returns>
        public bool Verify()
        {
            //For first class there must be 40 credits as minimum
            if (Class == 1)
                return Subjects.Where(k=>k.Finished).Sum(k => k.Credits) >= 40;
            //for other class there must be finished all subjects from previous class and must be 40 credits for current class subjects
            return Subjects.All(k => k.Class == Class - 1 && k.Finished) && Subjects.Where(k => k.Class == Class && k.Finished).Sum(k => k.Credits) >= 40;
        }
        /// <summary>
        /// This method set student to next class
        /// </summary>
        public void WriteToNextClass()
        {
            Class++;
        }
    }
}
