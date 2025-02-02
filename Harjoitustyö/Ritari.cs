using Harjoitustyö;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitustyö
{
    class Ritari
    {
        private int kulta;
        public int hp;
        public Ase ase;
        public Haarniska haarniska;
        public Taikajuoma[] taikajuomat;
        public Ritari()
        {
            kulta = 30;
            hp = 50;
            haarniska = new Haarniska(1);
            ase = new Ase(1);
            taikajuomat = new Taikajuoma[5];
            taikajuomat[0] = new Taikajuoma(5);
        }
        public void VahennaHP(int maara)
        {
            int vahinko = maara;
            if (haarniska.Vahvuus >= maara)
            {
                vahinko = 1;
            }
            else
            {
                vahinko = maara - haarniska.Vahvuus;
            }
            hp -= vahinko;
            Console.WriteLine("Ritari otti " + vahinko + " vahinkoa");
            Console.WriteLine("Ritarilla on nyt " + hp + " HP.");
        }
        public void MeneKauppaan()
        {
            Console.WriteLine("Mennään kauppaan.");

            Kauppa kauppa = new Kauppa();
            kauppa.NaytaTavarat(this);
            int valinta = Convert.ToInt32(Console.ReadLine());
            kauppa.OstaTavara(this, valinta);
        }

        public void GetAttackDamage(Vihollinen vihollinen)
        {
            Console.WriteLine("Hyökätään vihollista vastaan!");
            vihollinen.VahennaHP(ase.vahinkomäärä);
        }

        public void Paranna(Taikajuoma taikajuoma)
        {
            Console.WriteLine("Ritari Paransi " + taikajuoma.parannusMaara + "hp");
            hp += taikajuoma.parannusMaara;
        }
        public void VahennaKultaa(int maara)
        {
            kulta -= maara;
        }

        public void LisaaKultaa(int maara)
        {
            Console.WriteLine("Ritari Sai kultaa " + maara);
            kulta += maara;
        }

        public int Kulta
        {
            get { return kulta; }
        }
    }
}