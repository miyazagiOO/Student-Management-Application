using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_Application
{
    internal class GPA
    {
        private double sum = 0;
        private int n = 0;
        private double max = 0;
        private double min = 4;
        private string maxname = string.Empty; // ""
        private string minname = string.Empty; // ""
        private string alldata = string.Empty; // ""

        /// <summary>
        /// Add new GPA to class
        /// </summary>
        /// <param name="gpa">gpa score</param>
        public void addGPA(double gpa, string name)
        {
            this.sum += gpa;
            this.n++;

            if (this.max < gpa)
            {
                this.max = gpa;
            }
            if (this.min > gpa)
            {
                this.min = gpa;
            }
        }
        internal void addGPA(double dInput, object name)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Return GPAx of class
        /// </summary>
        /// <returns>GPAx</returns>
        public double gatGPAx()
        {
            double result = this.sum / this.n;
            return result;
        }
        public double getMax()
        {
            return this.max;
        }
        public string getMaxName()
        {
            return maxname;
        }
        public double gatMin()
        {
            return this.min;
        }
        public string getMinName()
        {
            return minname;
        }
        public string gatAlldata()
        {
            return alldata;
        }
    }
}
