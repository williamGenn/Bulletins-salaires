using System;

namespace bulletins_salaires
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bulletin bulletin = new Bulletin("Janvier", 16);
            //bulletin.Affiche();

            BulletinAnnuel monBulletinAnnuel = new BulletinAnnuel();

            monBulletinAnnuel.AjoutBulletin( new Bulletin("Janvier", 16) ); 
            monBulletinAnnuel.AjoutBulletin( new Bulletin("Fevrier", 16) ); 
            monBulletinAnnuel.AjoutBulletin( new Bulletin("mars", 16) ); 
            monBulletinAnnuel.AjoutBulletin( new Bulletin("avril", 16) ); 
            monBulletinAnnuel.AjoutBulletin( new Bulletin("mai", 16) ); 
            monBulletinAnnuel.AjoutBulletin( new Bulletin("Juin", 16) ); 
            monBulletinAnnuel.AjoutBulletin( new Bulletin("Juillet", 16) ); 
            monBulletinAnnuel.AjoutBulletin( new Bulletin("Aout", 16) );
            monBulletinAnnuel.AjoutBulletin( new Bulletin("Septembre", 16) ); 
            monBulletinAnnuel.AjoutBulletin( new Bulletin("Octobre", 16) ); 
            monBulletinAnnuel.AjoutBulletin( new Bulletin("Novembre", 16) );
            monBulletinAnnuel.AjoutBulletin( new Bulletin("Decembre", 16) );

            foreach( var bull in monBulletinAnnuel.Mesbulletins )
                bull.Affiche(); 

            Tests.TestSalaireBase();
            Tests.TestMontantHS();
            Tests.TestRetenueRetraite(); 
            Tests.TestSalaireBrut(); 
            Tests.TestRetenueSS();
            Tests.TestRetenueChomage();
            Tests.TestRetenueCSG();
            Tests.TestRetenuesTotal();
            Tests.TestSalaireNet();
        }
    }
}
