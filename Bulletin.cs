using System;

namespace bulletins_salaires
{
    public enum MoisEnum
    {
        Janvier,
        Fevrier,
        Mars,
        Avril,
        Mai,
        Juin,
        Juillet, 
        Aout,
        Septembre, 
        Octobre,
        Novembre, 
        Decembre
    }

    public class Bulletin
    {
        //Mois en cours
        private MoisEnum mois;
        //Salaire horaire
        private double salaireHoraire; 

        private double nbHeuresSup;
        
        public MoisEnum Mois{
            get { return mois; }
            set { mois = value;}
        }

        public double SalaireHoraire{
            get { return salaireHoraire;}
            set { salaireHoraire = value;}
        }
        public double NbHeuresSup{
            get { return nbHeuresSup;}
            set { nbHeuresSup = value;}
        }

        public Bulletin(){
            Mois = MoisEnum.Janvier;
            SalaireHoraire = 12;
            NbHeuresSup = 25;  
        }

        public Bulletin(double unSalaireHoraire){
            Mois = MoisEnum.Janvier;
            SalaireHoraire = unSalaireHoraire; 
            NbHeuresSup = 25; 
        }
        public Bulletin(MoisEnum unMois, double unSalaireHoraire){
            Mois = unMois;
            SalaireHoraire = unSalaireHoraire; 
            NbHeuresSup = 25; 
        }
        public Bulletin(string unMois, double unSalaireHoraire){
            Mois =  (MoisEnum) Enum.Parse(typeof(MoisEnum), unMois, true);
            SalaireHoraire = unSalaireHoraire; 
            NbHeuresSup = 25; 
        }

        public Bulletin(MoisEnum unMois, double unSalaireHoraire, double monNbHeuresSup ){
            Mois = unMois;
            SalaireHoraire = unSalaireHoraire; 
            NbHeuresSup = monNbHeuresSup; 
        }

        //Retourner le nombre d'H (valeur décimale) pour le mois
        public double nbBase(){
            return Parametre.horaireMensuelLegal() ;
        }
        public double nbHS(){
            return NbHeuresSup ;
        }

        //Retourner le montant des HS (en € décimaux)
        public double montantHS(){
            double total; 
            if( nbHS() < 8 )
                return nbHS() * Parametre.tauxHSTranche1() * SalaireHoraire ; 
            else{
                total = 8 * Parametre.tauxHSTranche1() * SalaireHoraire ; 
                total += (nbHS()-8) * Parametre.tauxHSTranche2() * SalaireHoraire ; 
                return total;
            }
        }
        public double salaireBase(){
            return nbBase() * SalaireHoraire;
        }  
        //Retourner le salaire brut
        public double salaireBrut(){
            return salaireBase() + montantHS() ;
        }  
        //Retourner la retenue sécurité sociale
        public double retenueSS(){
            return Parametre.tauxRetenueSS() * this.salaireBrut();
        }

        //Retourner la retenue liée à l'assurance chomâge
        public double retenueChomage(){
            return Parametre.tauxRetenueChomage() *salaireBrut();
        }
            
        //Retourner la retenue liée à la retraite complémentaire
        public double retenueRetraite(){
            double resultat = 0;
            if( salaireBrut()  < Parametre.plafond1Retraite())
                resultat = Parametre.tauxRetenueRetraiteTranche1() * salaireBrut();
            
            if ( Parametre.plafond1Retraite() < salaireBrut() && salaireBrut() < Parametre.plafond2Retraite() ){
                resultat = Parametre.tauxRetenueRetraiteTranche1() * Parametre.plafond1Retraite();
                resultat += Parametre.tauxRetenueRetraiteTranche2() * ( salaireBrut() - Parametre.plafond1Retraite()) ;
            }
            return resultat;

        }
        //Retourner la retenue CSG
        public double retenueCSG(){
            return Parametre.tauxRetenueCSG() *salaireBrut();
        }
        //Retourner l'ensemble des retenues 
        public double retenuesTotal(){
            return retenueSS()+retenueChomage()+ retenueRetraite()+retenueCSG();
        }
        //Retourner le salaire net
        public double salaireNet(){
            return salaireBrut() - retenuesTotal();
        }
        // Affiche le bulletin
        public void Affiche(){
            Console.WriteLine("Mon bulletin pour le mois de {0} a un salaire horaire de {1} euros ", Mois, SalaireHoraire);
        }

    }
}