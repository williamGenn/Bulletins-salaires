using System;

namespace bulletins_salaires
{
    public class Ecran
    {
        public static void Afficher(Bulletin b){

        Console.WriteLine("salare de base {0}",  b.salaireBase() );

        //Retourner le montant des HS (en € décimaux)
        Console.WriteLine(" nombre d'HS {0}", b.nbHS() );

        //Retourner le montant des HS (en € décimaux)
        Console.WriteLine(" montan  d'HS {0}", b.montantHS() );

        //Retourner le salaire brut
        Console.WriteLine("salair brut {0}", b.salaireBrut());
 
        //Retourner la retenue sécurité sociale
        Console.WriteLine("la retenue sécurité sociale {0}", b.retenueSS());

        //Retourner la retenue liée à l'assurance chomâge
        Console.WriteLine("la retenue liée à l'assurance chomâge {0}", b.retenueChomage());

                //Retourner la retenue CSG
         Console.WriteLine(" la retenue CSG  {0}", b.retenueCSG());

        //Retourner la retenue liée à la retraite complémentaire
         Console.WriteLine("la retenue liée à la retraite complémentaire {0}", b.retenueRetraite());

        //Retourner l'ensemble des retenues 
         Console.WriteLine("l'ensemble des retenues  {0}", b.retenuesTotal());

        //Retourner le salaire net
         Console.WriteLine("le salaire net {0}", b.salaireNet());

        }
    }
}