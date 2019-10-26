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
using System.Windows.Controls.Primitives;

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
        ToggleButton toggle = new ToggleButton();

        public MainWindow()
        {

            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            employeeTreatment = new EmployeeTreatment(new List<Employee>
            {
               new Employee (Age.Fifties, Religion.Christian,Ethnecity.White,Gender.Female, CivilState.Single, Disabilities.Nothing),
               new Employee (Age.Fifties, Religion.Buddhist,Ethnecity.White,Gender.Male, CivilState.Married, Disabilities.Visual),
               new Employee (Age.Fifties, Religion.Musulim,Ethnecity.Africain,Gender.Male, CivilState.Single, Disabilities.Nothing),
               new Employee (Age.Fifties, Religion.Christian,Ethnecity.Black,Gender.Female, CivilState.Divorced, Disabilities.Cognitive),
               new Employee (Age.Fifties, Religion.Christian,Ethnecity.White,Gender.Male, CivilState.Married, Disabilities.Cognitive),
               new Employee (Age.Fifties, Religion.Musulim,Ethnecity.Arab,Gender.Male, CivilState.Single, Disabilities.Physical),
               new Employee (Age.Fifties, Religion.Jewish,Ethnecity.Asian_Indian,Gender.Female, CivilState.Divorced, Disabilities.Hearing),


               new Employee (Age.Twenties, Religion.Musulim,Ethnecity.Arab,Gender.Male, CivilState.Married, Disabilities.Nothing),
               new Employee (Age.Twenties, Religion.Jewish,Ethnecity.White,Gender.Male, CivilState.Married, Disabilities.Nothing),
               new Employee (Age.Twenties, Religion.Jewish,Ethnecity.Asian_Indian,Gender.Male, CivilState.Single, Disabilities.Physical),
               new Employee (Age.Twenties, Religion.Sikh,Ethnecity.Asian_Indian,Gender.Female, CivilState.Single, Disabilities.Hearing),
               new Employee (Age.Twenties, Religion.Christian,Ethnecity.Black,Gender.Male, CivilState.Single, Disabilities.Visual),


               new Employee (Age.Thirties, Religion.Christian,Ethnecity.Other,Gender.Male, CivilState.Divorced, Disabilities.Nothing),
               new Employee (Age.Thirties, Religion.Christian,Ethnecity.White,Gender.Female, CivilState.Single, Disabilities.Nothing),
               new Employee (Age.Thirties, Religion.Christian,Ethnecity.Black,Gender.Male, CivilState.Married, Disabilities.Nothing),
               new Employee (Age.Thirties, Religion.Jewish,Ethnecity.White,Gender.Female, CivilState.Married, Disabilities.Cognitive),
               new Employee (Age.Thirties, Religion.Musulim,Ethnecity.Africain,Gender.Male, CivilState.Married, Disabilities.Physical),
               new Employee (Age.Thirties, Religion.Sikh,Ethnecity.Asian_Chinese,Gender.Male, CivilState.Widow, Disabilities.Hearing),
               new Employee (Age.Thirties, Religion.Hindu,Ethnecity.Asian_Indian,Gender.Male, CivilState.Divorced, Disabilities.Nothing),


               new Employee (Age.Forties, Religion.Other,Ethnecity.White,Gender.Female, CivilState.Widow, Disabilities.Nothing),
               new Employee (Age.Forties, Religion.Jewish,Ethnecity.White,Gender.Male, CivilState.Single, Disabilities.Hearing),
               new Employee (Age.Forties, Religion.Musulim,Ethnecity.Black,Gender.Male, CivilState.Divorced, Disabilities.Cognitive),
               new Employee (Age.Forties, Religion.Christian,Ethnecity.Black,Gender.Male, CivilState.Married, Disabilities.Physical),
               new Employee (Age.Forties, Religion.Christian,Ethnecity.Asian_Chinese,Gender.Female, CivilState.Married, Disabilities.Nothing),


               new Employee (Age.Other, Religion.Buddhist,Ethnecity.Africain,Gender.Female, CivilState.Widow, Disabilities.Hearing),
               new Employee (Age.Other, Religion.Sikh,Ethnecity.Africain,Gender.Male, CivilState.Single, Disabilities.Nothing),
               new Employee (Age.Other, Religion.Hindu,Ethnecity.Asian_Indian,Gender.Male, CivilState.Married, Disabilities.Nothing),

            });
            UpdateProgressBar(employeeTreatment.DiversityTotale());
        }


        /// /////////////////////////////  Chcked ///////////////////////////////////////

        private void GenderBtn_Checked(object sender, RoutedEventArgs e)
        {
            if (can)
                addHyst("Gender");
            else
            {
                Erreur fenetere = new Erreur();
                fenetere.Show();
                GenderBtn.IsChecked = false;
                can = false;
            }
        }

        private void GenderBtn_Unchecked(object sender, RoutedEventArgs e)
        {
            DeleteHyst("Gender");
        }


        private void EthnicityBtn_Checked(object sender, RoutedEventArgs e)
        {
            if (can)
                addHyst("Ethnecity");
            else
            {
                Erreur fenetere = new Erreur();
                fenetere.Show();
                EthnicityBtn.IsChecked = false;
                can = false;
            }
        }

         private void EthnicityBtn_Unhecked(object sender, RoutedEventArgs e)
        {
            DeleteHyst("Ethnecity");
        }


        private void DisabilitiesBtn_Checked(object sender, RoutedEventArgs e)
        {
            if (can)
                addHyst("Disabilities");
            else
            {
                Erreur fenetere = new Erreur();
                fenetere.ShowDialog();
               DisabilitiesBtn.IsChecked = false;
                can = false;
            }
        }

        private void DisabilitiesBtn_Unchecked(object sender, RoutedEventArgs e)
        {
            DeleteHyst("Disabilities");
        }

        private void AgeBtn_Checked(object sender, RoutedEventArgs e)
        {
            if (can)
                addHyst("Age");
            else
            {
                Erreur fenetere = new Erreur();
                fenetere.Show();
                AgeBtn.IsChecked = false;
                can = false;
            }
        }
        private void AgeBtn_Unchecked(object sender, RoutedEventArgs e)
        {
            DeleteHyst("Age");
        }

        private void ReligionBtn_Checked(object sender, RoutedEventArgs e)
        {
            if (can)
                addHyst("Religion");
            else
            {
                Erreur fenetere = new Erreur();
                fenetere.Show();
                ReligionBtn.IsChecked = false;
                can = false;
            }
        }

        private void ReligionBtn_Unchecked(object sender, RoutedEventArgs e)
        {
            DeleteHyst("Religion");
        }

        private void CivilStateBtn_Checked(object sender, RoutedEventArgs e)
        {
            if (can)
                addHyst("Civil State");
            else
            {
                Erreur fenetere = new Erreur();
                fenetere.Show();
                CivilStateBtn.IsChecked = false;
                can = false;
            }
        }

        private void CivilStateBtn_Unchecked(object sender, RoutedEventArgs e)
        {
            DeleteHyst("Civil State");
        }


        /// /////////////////////////////  methodes ///////////////////////////////////////
        private void addHyst(string nomParam)
        {
            List<double> Donnes = new List<double>();
                var converter = new BrushConverter();
                var brush = this.first ? (Brush)converter.ConvertFromString("#21717E") : (Brush)converter.ConvertFromString("#707070");            

                switch (nomParam)
                {
                    case "Gender":
                        foreach (Gender item in Enum.GetValues(typeof(Gender)))
                        {
                            Donnes.Add(this.employeeTreatment.employees.Where(x => x.gender == item).Count());
                        }
                        break;

                    case "Ethnecity":
                        foreach (Ethnecity item in Enum.GetValues(typeof(Ethnecity)))
                        {
                            Donnes.Add(this.employeeTreatment.employees.Where(x => x.ethnicity == item).Count());
                        }
                        break;

                    case "Civil State":
                        foreach (CivilState item in Enum.GetValues(typeof(CivilState)))
                        {
                            Donnes.Add(this.employeeTreatment.employees.Where(x => x.civil_State == item).Count());
                        }
                        break;

                    case "Religion":
                        foreach (Religion item in Enum.GetValues(typeof(Religion)))
                        {
                            Donnes.Add(this.employeeTreatment.employees.Where(x => x.religion == item).Count());
                        }
                        break;

                    case "Age":
                        foreach (Age item in Enum.GetValues(typeof(Age)))
                        {
                            Donnes.Add(this.employeeTreatment.employees.Where(x => x.age == item).Count());
                        }
                        break;
                    case "Disabilities":
                        foreach (Disabilities item in Enum.GetValues(typeof(Disabilities)))
                        {
                            Donnes.Add(this.employeeTreatment.employees.Where(x => x.disabilities == item).Count());
                        }
                        break;
                    default: break;
                }

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

            toggle.IsChecked = false;
            switch (nomParam)
            {
                case "Gender": toggle = GenderBtn; break;
                case "Ethnecity": toggle = EthnicityBtn; break;
                case "Civil State": toggle = CivilStateBtn; break;
                case "Religion": toggle = ReligionBtn; break;
                case "Age": toggle = AgeBtn; break;
                case "Disabilities": toggle = DisabilitiesBtn; break;
            }
        }

        private void DeleteHyst (string nomParam)
        {
            var serie1 = Hysto.Series[0];
            if(serie1.Title==nomParam )
            {
                if (can)
                {
                    Hysto.Series.Clear();
                    AxisX.Labels.Clear();
                    first = true;
                }
                else
                {
                    var serie2 = Hysto.Series[1];
                    Hysto.Series.Clear();
                    var converter = new BrushConverter();
                    var brush = (Brush)converter.ConvertFromString("#21717E");
   
                        this.Hysto.Series = new SeriesCollection
                        {
                            new ColumnSeries
                            {
                                Title = serie2.Title,
                                Values =serie2.Values,
                                Stroke=brush,
                                Fill=brush
                            }
                    };
                    getLabels(serie2.Title);
                    can = true;
                }
            }
            else
            {
                if(!can)
                { 
                    var serie2 = Hysto.Series[1];
                    if (serie2.Title == nomParam)
                    {
                        Hysto.Series.Remove(serie2);
                    }
                    can = true;
                }
            }
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
                    break;

                case "Ethnecity":
                    foreach (var item in Enum.GetValues(typeof(Ethnecity)))
                    {
                        Labels.Add(item.ToString());
                    }
                    break;

                case "Civil State":
                    foreach (var item in Enum.GetValues(typeof(CivilState)))
                    {
                        Labels.Add(item.ToString());
                    }
                    break;

                case "Religion":
                    foreach (var item in Enum.GetValues(typeof(Religion)))
                    {
                        Labels.Add(item.ToString());
                    }
                    break;

                case "Age":
                    foreach (var item in Enum.GetValues(typeof(Age)))
                    {
                        Labels.Add(item.ToString());
                    }
                    break;

                case "Disabilities":
                    foreach (var item in Enum.GetValues(typeof(Disabilities)))
                    {
                        Labels.Add(item.ToString());
                    }
                    break;


                default: break;
            }

            AxisX.Labels = Labels;
            AxisX.Title = nomParam;

        }


        public void UpdateProgressBar(double diversity)
        {
            DiversityProgressBar.Value = diversity;
            divercityPercentage.Text = diversity.ToString() + "%";
            if (diversity>50)
            {
                DiversityProgressBar.Foreground = (Brush)App.Current.Resources["DarkGreen"];
                divercityPercentage.Foreground =(Brush) App.Current.Resources["DarkGreen"];
                comment.Foreground =(Brush) App.Current.Resources["DarkGreen"];
                comment.Text = "Good";
            }
            else
            {
                comment.Foreground = Brushes.Red;
                comment.Text = "Not Good";
                DiversityProgressBar.Foreground = Brushes.Red;
                divercityPercentage.Foreground = Brushes.Red;
            }
        }



    }


}