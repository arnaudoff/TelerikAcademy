namespace ArmyOfCreatures.Extended.Specialties
{
    using System;
    using System.Globalization;

    using ArmyOfCreatures.Logic.Specialties;
    using ArmyOfCreatures.Logic.Battles;

    // TODO: Implement some static Validator class for the checks
    public class DoubleDamage : Specialty
    {
        private int rounds;

        public DoubleDamage(int rounds)
        {
            if (rounds < 0)
            {
                throw new ArgumentOutOfRangeException("The number of rounds cannot be negative.");
            }

            if (rounds > 10)
            {
                throw new ArgumentOutOfRangeException("The number of rounds cannot exceed 10.");
            }

            this.rounds = rounds;
        }

        public override decimal ChangeDamageWhenAttacking(ICreaturesInBattle attackerWithSpecialty, ICreaturesInBattle defender, decimal currentDamage)
        {
            if (attackerWithSpecialty == null)
            {
                throw new ArgumentNullException("attackerWithSpecialty");
            }

            if (defender == null)
            {
                throw new ArgumentNullException("defender");
            }

            if (this.rounds <= 0)
            {
                return base.ChangeDamageWhenAttacking(attackerWithSpecialty, defender, currentDamage);
            }

            this.rounds--;
            return currentDamage * 2;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.rounds);
        }
    }
}
