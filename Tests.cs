using System;


namespace bulletins_salaires
{
    public class Tests
    {
        public Tests(){}

        public static void TestSalaireBase(){
            double resultat = 2275.05; 
            double tauxHoraire = 15;
            Bulletin monBulletin = new Bulletin(tauxHoraire ); 

            if( Math.Abs( monBulletin.salaireBase() - resultat ) < 0.0001 ){
                Console.WriteLine( " Test TestSalaireBase OK");
            }
            else{
                Console.WriteLine( " Salaire calculé = {0} différent de {1} ", monBulletin.salaireBase(), resultat );
                Console.WriteLine( " Test TestSalaireBase KO");
            }
        }
        public static void TestMontantHS(){
            double resultat = 532.5; 
            double tauxHoraire = 15;
            Bulletin monBulletin = new Bulletin(tauxHoraire ); 
            if( Math.Abs( monBulletin.montantHS() - resultat ) < 0.0001 ){
                Console.WriteLine( " Test TestMontantHS OK");
            }
            else{
                Console.WriteLine( " Montant calculé = {0} différent de {1} ", monBulletin.montantHS(), resultat );
                Console.WriteLine( " Test TestMontantHS KO");
            }

        }
        public static void TestRetenueRetraite(){
            double resultat = 97.4885; 
            double tauxHoraire = 15;
            Bulletin monBulletin = new Bulletin(tauxHoraire ); 
            if( Math.Abs( monBulletin.retenueRetraite() - resultat ) < 0.0001 ){
                Console.WriteLine( " Test retenueRetraite OK");
            }
            else{
                Console.WriteLine( " Montant calculé = {0} différent de {1} ", monBulletin.retenueRetraite(), resultat );
                Console.WriteLine( " Test retenueRetraite KO");
            }

        }
        public static void TestSalaireBrut(){
            double resultat = 2807.55; 
            double tauxHoraire = 15;
            Bulletin monBulletin = new Bulletin(tauxHoraire ); 
            if( Math.Abs( monBulletin.salaireBrut() - resultat ) < 0.0001 ){
                Console.WriteLine( " Test salaireBrut OK");
            }
            else{
                Console.WriteLine( " Montant calculé = {0} différent de {1} ", monBulletin.salaireBrut(), resultat );
                Console.WriteLine( " Test salaireBrut KO");
            }

        }
        public static void TestRetenueSS(){
            double resultat = 207.7587; 
            double tauxHoraire = 15;
            Bulletin monBulletin = new Bulletin(tauxHoraire ); 
            if( Math.Abs( monBulletin.retenueSS() - resultat ) < 0.0001 ){
                Console.WriteLine( " Test retenueSS OK");
            }
            else{
                Console.WriteLine( " Montant calculé = {0} différent de {1} ", monBulletin.retenueSS(), resultat );
                Console.WriteLine( " Test retenueSS KO");
            }

        }
        public static void TestRetenueChomage(){
            double resultat = 140.3775; 
            double tauxHoraire = 15;
            Bulletin monBulletin = new Bulletin(tauxHoraire ); 
            if( Math.Abs( monBulletin.retenueChomage() - resultat ) < 0.0001 ){
                Console.WriteLine( " Test retenueChomage OK");
            }
            else{
                Console.WriteLine( " Montant calculé = {0} différent de {1} ", monBulletin.retenueChomage(), resultat );
                Console.WriteLine( " Test retenueChomage KO");
            }
        }
        public static void TestRetenueCSG(){
            double resultat = 81.41895; 
            double tauxHoraire = 15;
            Bulletin monBulletin = new Bulletin(tauxHoraire ); 
            if( Math.Abs( monBulletin.retenueCSG() - resultat ) < 0.0001 ){
                Console.WriteLine( " Test retenueCSG OK");
            }
            else{
                Console.WriteLine( " Montant calculé = {0} différent de {1} ", monBulletin.retenueCSG(), resultat );
                Console.WriteLine( " Test retenueCSG KO");
            }

        }
        public static void TestRetenuesTotal(){
            double resultat = 527.04365; 
            double tauxHoraire = 15;
            Bulletin monBulletin = new Bulletin(tauxHoraire ); 
            if( Math.Abs( monBulletin.retenuesTotal() - resultat ) < 0.0001 ){
                Console.WriteLine( " Test retenuesTotal OK");
            }
            else{
                Console.WriteLine( " Montant calculé = {0} différent de {1} ", monBulletin.retenuesTotal(), resultat );
                Console.WriteLine( " Test retenuesTotal KO");
            }

        }
        public static void TestSalaireNet(){
            double resultat = 2280.50635; 
            double tauxHoraire = 15;
            Bulletin monBulletin = new Bulletin(tauxHoraire ); 
            if( Math.Abs( monBulletin.salaireNet() - resultat ) < 0.0001 ){
                Console.WriteLine( " Test salaireNet OK");
            }
            else{
                Console.WriteLine( " Montant calculé = {0} différent de {1} ", monBulletin.salaireNet(), resultat );
                Console.WriteLine( " Test salaireNet KO");
            }

        }

    }
}