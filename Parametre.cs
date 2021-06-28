namespace bulletins_salaires
{
    // Classe utitaire
    public class Parametre
    {
        public static double horaireMensuelLegal(){
            return 151.67 ; 
        }
        public static double tauxHSTranche1(){
            return 1.25 ; 
        }
        public static double tauxHSTranche2(){
            return 1.5 ; 
        }
         //Retourner la retenue sécurité sociale
        public static double tauxRetenueSS(){
            return 0.074 ; 
        }

        //Retourner la retenue liée à l'assurance chomâge
        public static double tauxRetenueChomage(){
            return 0.05 ; 
        }
        //Retourner la retenue liée à la retraite complémentaire
        public static double tauxRetenueRetraiteTranche1(){
            return  0.03;
        }
        //Retourner la retenue liée à la retraite complémentaire
        public static double tauxRetenueRetraiteTranche2(){
            return 0.07;
        }
        //Retourner la retenue CSG
        public static double tauxRetenueCSG(){
            return 0.029;
        }
        public static double plafond1Retraite(){
            return  2476.0; 
        }
        public static double plafond2Retraite(){
            return  7296.0; 
        }

    }
}