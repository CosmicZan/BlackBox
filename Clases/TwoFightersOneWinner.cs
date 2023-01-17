using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Clases
{
    //Create a function that returns the name of the winner in a fight between two fighters.

    //Each fighter takes turns attacking the other and whoever kills the other first is victorious.Death is defined as having health <= 0.

    //Each fighter will be a Fighter object/instance.See the Fighter class below in your chosen language.

    //Both health and damagePerAttack(damage_per_attack for python) will be integers larger than 0. You can mutate the Fighter objects.

    //Your function also receives a third argument, a string, with the name of the fighter that attacks first.
    public static class TwoFightersOneWinner
    {
        public static string DeclareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
        {
            // Your code goes here. Have fun!
            string _winner = "";
            if (firstAttacker == fighter1.Name)
                fighter2.Health -= fighter1.DamagePerAttack;
            if (firstAttacker == fighter2.Name && fighter1.Health > 0)
                fighter1.Health -= fighter2.DamagePerAttack;
            do
            {
                fighter1.Health -= fighter2.DamagePerAttack; 
                if (fighter1.Health <= 0 && fighter2.Health > 0)
                    _winner = fighter2.Name;
                fighter2.Health -= fighter1.DamagePerAttack;
                if (fighter2.Health <= 0 && fighter1.Health > 0)
                    _winner = fighter1.Name;
            } while (_winner == "");
            return _winner;
        }
    }
    public class Fighter
    {
        public string Name;
        public int Health, DamagePerAttack;
        public Fighter(string name, int health, int damagePerAttack)
        {
            this.Name = name;
            this.Health = health;
            this.DamagePerAttack = damagePerAttack;
        }
    }
}

