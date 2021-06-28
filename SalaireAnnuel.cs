using System;

namespace bulletins_salaires
{
    public class BulletinAnnuel
    {
        private Bulletin[] mesbulletins = new Bulletin[ Enum.GetNames(typeof(MoisEnum)).Length ] ; 
        private double salaireannuel; 

        public Bulletin[] Mesbulletins{
            get => mesbulletins;
            set => mesbulletins = value; 
        }
        public double Salaireannuel{
            get => salaireannuel;
            set => salaireannuel = value; 
        }

        public BulletinAnnuel(){}

        public void AjoutBulletin( Bulletin nouveauBulletin){
            mesbulletins[ (int) nouveauBulletin.Mois ] = nouveauBulletin; 
        }




    } 
}