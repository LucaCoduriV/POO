using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_MA_24
{
    
    class Program
    {
        public static Random rand = new Random();
        

        public class Monstre
        {
            public bool estVivant { get; private set; }
            public int puissance { get; private set; }
            public Monstre()
            {
                estVivant = true;
            }
            public void SubitDegats()
            {
                estVivant = false;
            }
            public int LancerDe()
            {
                return rand.Next(1, 7);
            }
            public virtual void Attaque(Joueur joueur)
            {
                if(this.LancerDe() > joueur.LancerDe())
                {
                    joueur.SubitDegats(puissance);
                }
            }
        }
        public class MonstreDifficile : Monstre
        {
            private const int degatsSort = 5;

            public MonstreDifficile()
            {

            }
            public override void Attaque(Joueur joueur)
            {
                base.Attaque(joueur);
                joueur.SubitDegats(SortMagique());
            }
            public int SortMagique()
            {
                int lance = this.LancerDe();
                if (lance == 6 || lance == 5) return 0;
                return this.LancerDe() * degatsSort;
            }
        }
        public class Joueur
        {
            public int pointsVie { get; private set; }

            public Joueur(int pointsVie)
            {
                this.pointsVie = pointsVie;
            }
            public void SubitDegats(int points)
            {
                if (!BouclierFonctionne())
                {
                    this.pointsVie -= points;
                }
            }
            public bool BouclierFonctionne()
            {
                return rand.Next(1, 7) <= 2;
            }
            public int LancerDe()
            {
                return rand.Next(1, 7);
            }
            public void Attaque(Monstre monstre)
            {

                if(this.LancerDe() > monstre.LancerDe())
                {
                    monstre.SubitDegats();
                }
            }
        }


        static void Main(string[] args)
        {
            Joueur joueur = new Joueur(150);
            Monstre monstre = new Monstre();
            MonstreDifficile difficile = new MonstreDifficile();

            Console.WriteLine(joueur.LancerDe());
            Console.WriteLine(monstre.LancerDe());
            Console.WriteLine(difficile.LancerDe());

            while (true)
            {

            }
        }
    }
}
