using Cthulhu.CoreLib.Entities.Character.Stats;

namespace Cthulhu.CoreLib.Entities.Character.Stats
{
    public partial class Stat
    {
        public static class Social
        {
            #region Private
            private readonly static Stat _bureaucracy = new Stat()
            {
                Name = "Бюрократия",
                StatId = 43,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Social,
            };

            private readonly static Stat _interrogation = new Stat()
            {
                Name = "Допрос",
                StatId = 44,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Social,
            };

            private readonly static Stat _intimidation = new Stat()
            {
                Name = "Запугивание",
                StatId = 45,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Social,
            };

            private readonly static Stat _talking = new Stat()
            {
                Name = "Изустная история",
                StatId = 46,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Social,
            };

            private readonly static Stat _charm = new Stat()
            {
                Name = "Лесть",
                StatId = 47,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Social,
            };

            private readonly static Stat _policeSpeaking = new Stat()
            {
                Name = "Полицейский жаргон",
                StatId = 48,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Social,
            };

            private readonly static Stat _insight = new Stat()
            {
                Name = "Проницательность",
                StatId = 49,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Social,
            };

            private readonly static Stat _status = new Stat()
            {
                Name = "Статус",
                StatId = 50,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Social,
            };

            private readonly static Stat _trading = new Stat()
            {
                Name = "Торговля",
                StatId = 51,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Social,
            };

            private readonly static Stat _crimeSpeaking = new Stat()
            {
                Name = "Уличное чутье",
                StatId = 52,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Social,
            };

            private readonly static Stat _calming = new Stat()
            {
                Name = "Успокаивание",
                StatId = 53,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Social,
            };

            private readonly static Stat _any = new Stat()
            {
                Name = "Любая межличностная способность",
                StatId = -4,
                RestoringSpec = StatRestoringSpec.Unspec,
                Type = StatType.Social,
                OneOf = new System.Collections.Generic.HashSet<Stat>()
                {
                    _bureaucracy,
                    _interrogation,
                    _intimidation,
                    _talking,
                    _charm,
                    _policeSpeaking,
                    _insight,
                    _status,
                    _trading,
                    _crimeSpeaking,
                    _calming,
                }
            };
            #endregion

            #region Public
            /// <summary>
            /// Любая межличностная способность
            /// </summary>
            public static Stat Any => _any;

            /// <summary>
            /// Бюрократия
            /// </summary>
            public static Stat Bureaucracy => _bureaucracy;
            /// <summary>
            /// Допрос
            /// </summary>
            public static Stat Interrogation => _interrogation;
            /// <summary>
            /// Запугивание
            /// </summary>
            public static Stat Intimidation => _intimidation;
            /// <summary>
            /// Изустная история
            /// </summary>
            public static Stat Talking => _talking;
            /// <summary>
            /// Лесть
            /// </summary>
            public static Stat Charm => _charm;
            /// <summary>
            /// Полицейский жаргон
            /// </summary>
            public static Stat PoliceSpeaking => _policeSpeaking;
            /// <summary>
            /// Проницательность
            /// </summary>
            public static Stat Insight => _insight;
            /// <summary>
            /// Статус
            /// </summary>
            public static Stat Status => _status;
            /// <summary>
            /// Торговля
            /// </summary>
            public static Stat Trading => _trading;
            /// <summary>
            /// Уличное чутье
            /// </summary>
            public static Stat CrimeSpeaking => _crimeSpeaking;
            /// <summary>
            /// Успокаивание
            /// </summary>
            public static Stat Calming => _calming;
            #endregion
        }
    }

}
