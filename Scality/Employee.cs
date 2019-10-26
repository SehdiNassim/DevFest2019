using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scality
{
   
        public enum Ethnecity { White, Asian_Chinese, Asian_Indian, Arab, Black, Africain, Other  };
        public enum Gender { Male, Female, Other };
        public enum CivilState { Married,Divorced, Single, Widow };
        public enum Religion { Musulim, Christian, Jewish, Buddhist, Sikh, Hindu, Other };
        public enum Age { Twenties, Thirties, Forties, Fifties, Other };
        public enum Disabilities { Visual, Physical, Hearing, Cognitive, Nothing }
        public class Employee



    {
            public int id;
            public string nomComplet;
            public Age age;
            public string niveauScolaire;
            public string skills;
            public Religion religion;
            public Ethnecity ethnicity;
            public Gender gender;
            public CivilState civil_State;
             public Disabilities disabilities;

        public Employee(Age age, Religion religion, Ethnecity ethnicity, Gender gender, CivilState civil_State, Disabilities disabilities)
        {
            this.age = age;
            this.religion = religion;
            this.ethnicity = ethnicity;
            this.gender = gender;
            this.civil_State = civil_State;
            this.disabilities = disabilities;
        }
        }
    
}
