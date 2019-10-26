using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Statistics;

namespace Scality
{
    public class EmployeeTreatment
    {
         public List<Employee> employees;



        public EmployeeTreatment(List<Employee> employees)
        {
            this.employees = employees;
        }



        public double DiversityEthnicity()
        {
            List<double> listeCount = new List<double>();
            foreach (Ethnecity item in Enum.GetValues(typeof(Ethnecity)))
            {
                listeCount.Add(this.employees.Where(x => x.ethnicity == item).Count());
            }
            return Math.Round(( KernelDensity.GaussianKernel(1 / Statistics.StandardDeviation(listeCount)))* 100);

        }

        public double DiversityReligion()
        {
            List<double> listeCount = new List<double>();
            foreach (Religion item in Enum.GetValues(typeof(Religion)))
            {
                listeCount.Add(this.employees.Where(x => x.religion == item).Count());
            }

            return Math.Round((KernelDensity.GaussianKernel(1 / Statistics.StandardDeviation(listeCount))) * 100);

        }

        public double DiversityGender()
        {

            List<double> listeCount = new List<double>();
            foreach (Gender item in Enum.GetValues(typeof(Gender)))
            {
                listeCount.Add(this.employees.Where(x => x.gender == item).Count());
            }
            return Math.Round(( KernelDensity.GaussianKernel(1 / Statistics.StandardDeviation(listeCount))) * 100);
        }

        public double DiversityAge()
        {
            List<double> listeCount = new List<double>();
            foreach (Age item in Enum.GetValues(typeof(Age)))
            {
                listeCount.Add(this.employees.Where(x => x.age == item).Count());
            }


            var y = Statistics.StandardDeviation(listeCount);
            return Math.Round((KernelDensity.GaussianKernel(1 /y )) * 100);
        }

        public double DiversityCivilState()
        {
            List<double> listeCount = new List<double>();
            foreach (CivilState item in Enum.GetValues(typeof(CivilState)))
            {
                listeCount.Add(this.employees.Where(x => x.civil_State == item).Count());
            }
            return Math.Round((KernelDensity.GaussianKernel(1 / Statistics.StandardDeviation(listeCount))) * 100);
        }


        public double DiversityDisabilities()
        {
            List<double> listeCount = new List<double>();
            foreach (Disabilities item in Enum.GetValues(typeof(Disabilities)))
            {
                listeCount.Add(this.employees.Where(x => x.disabilities == item).Count());
            }
            return Math.Round((1 - KernelDensity.GaussianKernel(1 / Statistics.StandardDeviation(listeCount))) * 100);
        }


        public double DiversityTotale()
        {
            var z = DiversityAge();
            var a = DiversityCivilState();
            var b = DiversityDisabilities();
            var c = DiversityEthnicity();
            var d = DiversityGender();
            var e = DiversityDisabilities();

            var x = Math.Round((DiversityAge() + DiversityCivilState() + DiversityEthnicity() + DiversityReligion() + DiversityGender() + DiversityDisabilities()) / 6);
            return x;
        }
    }

}
