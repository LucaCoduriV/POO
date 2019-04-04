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
            public bool estVivant() {return pointsVie>0; }

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

        public static Monstre creationMonstre()
        {
            int type = rand.Next(1, 7);
            if(type <= 3) { return new Monstre(); }
            else { return new MonstreDifficile(); }
        }

        static void Main(string[] args)
        {
            Joueur stephane = new Joueur(150);
            int numero = 0;
            int coupFacile = 0, coupDifficle = 0;

            while (stephane.estVivant())
            {
                Monstre monstre = creationMonstre();
                var test = monstre.GetType().ToString();
                string[] test2 = new string[2];
                test2 = test.Split('+');

                numero++;
                Console.WriteLine("\n\n\nmonstre numéro: "+ numero +" de type " + test2[1]);

                while (monstre.estVivant && stephane.estVivant())
                {
                    Console.WriteLine("stephane attaque le monstre !");
                    stephane.Attaque(monstre);
                    if (monstre.estVivant)
                    {
                        Console.WriteLine("le monstre est toujours vivant et attaque stephane !");
                        monstre.Attaque(stephane);
                        Console.WriteLine("il reste à stéphane " + stephane.pointsVie + " points de vie");
                    }
                    else { Console.WriteLine("le monstre à été vaincu"); }

                    if (stephane.estVivant())
                    {
                        if(monstre is Monstre)
                        {
                            coupFacile++;
                        }
                        if(monstre is MonstreDifficile)
                        {
                            coupDifficle++;
                        }
                    }
                    
                }
            }
            Console.WriteLine("\nAïe! stephane est mort, il a vaincu {0} monstre et {1} monstre difficle",coupFacile,coupDifficle);
            Console.WriteLine("\nil a donc un score total de {0} points",coupFacile + 2*coupDifficle);
            while (true) { }
        }
    }
}
