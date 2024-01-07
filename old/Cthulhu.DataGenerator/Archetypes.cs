using Cthulhu.CoreLib.Entities.Character;
using Cthulhu.CoreLib.Entities.Character.Common;

namespace Cthulhu.DataGenerator
{
    public static class Archetypes
    {
        public static Archetype Policeman => new Archetype()
        {
            //ArchetypeId = 1,
            //Name = "Полицеский"
        };

        public static InvestigatorTablet GetInvestigatorTablet(long archetypeId)
        {
            var result = new InvestigatorTablet()
            {
                Archetype = Policeman,
                CommonStatsTotal = 65,
                InvestigationStatsTotal = 20,
            };
            return result;
        }

    }
}
