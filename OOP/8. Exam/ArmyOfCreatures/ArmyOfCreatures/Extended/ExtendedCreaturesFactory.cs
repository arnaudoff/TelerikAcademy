
namespace ArmyOfCreatures.Extended
{
    using ArmyOfCreatures.Logic;
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Extended.Creatures;

    public class ExtendedCreaturesFactory : CreaturesFactory, ICreaturesFactory
    {
        public override Creature CreateCreature(string name)
        {
            switch (name)
            {
                case "AncientBehemoth":
                    return new AncientBehemoth();
                case "CyclopsKing":
                    return new CyclopsKing();
                case "Goblin":
                    return new Goblin();
                case "Griffin":
                    return new Griffin();
                case "WolfRaider":
                    return new WolfRaider();
                default:
                    base.CreateCreature(name);
                    break;
            }

            // Not quite sure if this is a good practice but I had to shut the compiler somehow.
            return base.CreateCreature(name);
        }
    }
}
