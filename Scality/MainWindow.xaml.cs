using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using LiveCharts;
using LiveCharts.Wpf;

namespace Scality
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        public EmployeeTreatment employeeTreatment;

        bool first = true;
        bool can = true;

        public MainWindow()
        {

            InitializeComponent();
            Serie1 = null;
            Serie2 = null;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            employeeTreatment = new EmployeeTreatment(new List<Employee>
            {
               new Employee (Age.Fifties, Religion.Buddhist,Ethnecity.Africain,Gender.Female, CivilState.Single, Disabilities.Cognitive),
               new Employee (Age.Fifties, Religion.Buddhist,Ethnecity.Africain,Gender.Female, CivilState.Single, Disabilities.Cognitive),
               new Employee (Age.Fifties, Religion.Buddhist,Ethnecity.Africain,Gender.Female, CivilState.Single, Disabilities.Cognitive),
               new Employee (Age.Fifties, Religion.Buddhist,Ethnecity.Africain,Gender.Female, CivilState.Single, Disabilities.Cognitive),
               new Employee (Age.Fifties, Religion.Buddhist,Ethnecity.Africain,Gender.Female, CivilState.Single, Disabilities.Cognitive),
               new Employee (Age.Fifties, Religion.Buddhist,Ethnecity.Africain,Gender.Female, CivilState.Single, Disabilities.Cognitive),
               new Employee (Age.Fifties, Religion.Buddhist,Ethnecity.Africain,Gender.Female, CivilState.Single, Disabilities.Cognitive),
               new Employee (Age.Fifties, Religion.Buddhist,Ethnecity.Africain,Gender.Female, CivilState.Single, Disabilities.Cognitive),
               new Employee (Age.Fifties, Religion.Buddhist,Ethnecity.Africain,Gender.Female, CivilState.Single, Disabilities.Cognitive),
               new Employee (Age.Fifties, Religion.Buddhist,Ethnecity.Africain,Gender.Female, CivilState.Single, Disabilities.Cognitive),
               new Employee (Age.Fifties, Religion.Buddhist,Ethnecity.Africain,Gender.Female, CivilState.Single, Disabilities.Cognitive),
               new Employee (Age.Fifties, Religion.Buddhist,Ethnecity.Africain,Gender.Female, CivilState.Single, Disabilities.Cognitive),
               new Employee (Age.Fifties, Religion.Buddhist,Ethnecity.Africain,Gender.Female, CivilState.Single, Disabilities.Cognitive),
               new Employee (Age.Fifties, Religion.Buddhist,Ethnecity.Africain,Gender.Female, CivilState.Single, Disabilities.Cognitive),
               new Employee (Age.Fifties, Religion.Buddhist,Ethnecity.Africain,Gender.Female, CivilState.Single, Disabilities.Cognitive),
               new Employee (Age.Fifties, Religion.Buddhist,Ethnecity.Africain,Gender.Female, CivilState.Single, Disabilities.Cognitive),
               new Employee (Age.Fifties, Religion.Buddhist,Ethnecity.Africain,Gender.Female, CivilState.Single, Disabilities.Cognitive),
               new Employee (Age.Fifties, Religion.Buddhist,Ethnecity.Africain,Gender.Female, CivilState.Single, Disabilities.Cognitive),
               new Employee (Age.Fifties, Religion.Buddhist,Ethnecity.Africain,Gender.Female, CivilState.Single, Disabilities.Cognitive),
               new Employee (Age.Fifties, Religion.Buddhist,Ethnecity.Africain,Gender.Female, CivilState.Single, Disabilities.Cognitive),
               new Employee (Age.Fifties, Religion.Buddhist,Ethnecity.Africain,Gender.Female, CivilState.Single, Disabilities.Cognitive),
               new Employee (Age.Fifties, Religion.Buddhist,Ethnecity.Africain,Gender.Female, CivilState.Single, Disabilities.Cognitive),
               new Employee (Age.Fifties, Religion.Buddhist,Ethnecity.Africain,Gender.Female, CivilState.Single, Disabilities.Cognitive),
               new Employee (Age.Fifties, Religion.Buddhist,Ethnecity.Africain,Gender.Female, CivilState.Single, Disabilities.Cognitive),
               new Employee (Age.Fifties, Religion.Buddhist,Ethnecity.Africain,Gender.Female, CivilState.Single, Disabilities.Cognitive),
               new Employee (Age.Fifties, Religion.Buddhist,Ethnecity.Africain,Gender.Female, CivilState.Single, Disabilities.Cognitive),
               new Employee (Age.Fifties, Religion.Buddhist,Ethnecity.Africain,Gender.Female, CivilState.Single, Disabilities.Cognitive),

            });
            DiversityProgressBar.Value = employeeTreatment.DiversityTotale();
            divercityPercentage.Text = employeeTreatment.DiversityTotale().ToString() + "%";
        }

        private void GenderBtn_Checked(object sender, RoutedEventArgs e)
        {
            addHyst("Gender");
        }

         private void GenderBtn_Unchecked(object sender, RoutedEventArgs e)
        {
            DeleteHyst("Gender");
        }



        private void addHyst(string nomParam)
        {
            if(can)
            {
                List<double> Donnes = new List<double>();
                var converter = new BrushConverter();
                var brush = this.first ? (Brush)converter.ConvertFromString("#21717E") : (Brush)converter.ConvertFromString("#707070");

                foreach (Gender item in Enum.GetValues(typeof(Gender)))
                {
                    Donnes.Add(this.employeeTreatment.employees.Where(x => x.gender == item).Count());
                }

                if (first)
                {
                    this.Hysto.Series = new SeriesCollection
                    {
                        new ColumnSeries
                        {
                            Title = nomParam,
                            Values =GetValues(Donnes),
                            Stroke=brush,
                            Fill=brush
                        }
                    };
                    getLabels(nomParam);
                    first = false;
                }
                else
                {
                    this.Hysto.Series = new SeriesCollection
                    {
                        new ColumnSeries
                        {
                            Title = nomParam,
                            Values =GetValues(Donnes),
                            Stroke=brush,
                            Fill=brush
                        }
                    };
                    getLabels(nomParam);
                    can = false;
                }
            }

        }

        private void DeleteHyst (string nomParam)
        {
            can = true;
            
        }



        ChartValues<double> GetValues(List<double> liste)
        {
            ChartValues<double> returnList = new ChartValues<double>();
            foreach (var item in liste)
            {
                returnList.Add(item);
            }
            return returnList;
        }

        void getLabels (string nomParam)
        {
            List<string> Labels = new List<string>();
            switch (nomParam )
            {
                case "Gender":
                    foreach (var item in Enum.GetValues(typeof (Gender)))
                    {
                        Labels.Add(item.ToString());
                    }
                    AxisX.Labels = Labels;
                    AxisX.Title = nomParam;
                    break;
                default: break; 
            } 

        }
    }

}