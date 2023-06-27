using Cthulhu.CoreLib.Entities.Character.Stats;

namespace Cthulhu.CoreLib.Entities.Character.Stats
{
    public partial class Stat
    {
        public static class Applied
        {
            private readonly static Stat _astronomy = new Stat()
            {
                Name = "Астрономия",
                StatId = 54,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Applied,
            };

            private readonly static Stat _lockpiking = new Stat()
            {
                Name = "Взлом",
                StatId = 55,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Applied,
            };

            private readonly static Stat _trapping = new Stat()
            {
                Name = "Естествознание",
                StatId = 56,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Applied,
            };

            private readonly static Stat _craft = new Stat()
            {
                Name = "Ремесло",
                StatId = 57,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Applied,
            };

            private readonly static Stat _evidenceCollection = new Stat()
            {
                Name = "Сбор улик",
                StatId = 58,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Applied,
            };

            private readonly static Stat _forensics = new Stat()
            {
                Name = "Судмедэкспертиза",
                StatId = 59,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Applied,
            };

            private readonly static Stat _pharm = new Stat()
            {
                Name = "Фармацевтика",
                StatId = 60,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Applied,
            };

            private readonly static Stat _photography = new Stat()
            {
                Name = "Фотография",
                StatId = 61,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Applied,
            };

            private readonly static Stat _chemistry = new Stat()
            {
                Name = "Химия",
                StatId = 62,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Applied,
            };

            /// <summary>
            /// Астрономия
            /// </summary>
            public static Stat Astronomy => _astronomy;
            /// <summary>
            /// Взлом
            /// </summary>
            public static Stat Lockpiking => _lockpiking;
            /// <summary>
            /// Естествознание
            /// </summary>
            public static Stat Trapping => _trapping;
            /// <summary>
            /// Ремесло
            /// </summary>
            public static Stat Craft => _craft;
            /// <summary>
            /// Сбор улик
            /// </summary>
            public static Stat EvidenceCollection => _evidenceCollection;
            /// <summary>
            /// Судмедэкспертиза
            /// </summary>
            public static Stat Forensics => _forensics;
            /// <summary>
            /// Фармацевтика
            /// </summary>
            public static Stat Pharm => _pharm;
            /// <summary>
            /// Фотография
            /// </summary>
            public static Stat Photography => _photography;
            /// <summary>
            /// Химия
            /// </summary>
            public static Stat Chemistry => _chemistry;
        }
    }

}
