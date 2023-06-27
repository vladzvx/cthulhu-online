using Cthulhu.CoreLib.Entities.Character.Stats;

namespace Cthulhu.CoreLib.Entities.Character.Stats
{
    public partial class Stat
    {
        public static class Scientific
        {
            #region Private
            private readonly static Stat _anthropology = new Stat()
            {
                Name = "Антропология",
                StatId = 27,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Scientific,
            };

            private readonly static Stat _archaeology = new Stat()
            {
                Name = "Археология",
                StatId = 28,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Scientific,
            };

            private readonly static Stat _architecture = new Stat()
            {
                Name = "Архитектура",
                StatId = 29,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Scientific,
            };

            private readonly static Stat _biology = new Stat()
            {
                Name = "Биология",
                StatId = 30,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Scientific,
            };

            private readonly static Stat _bookkeeping = new Stat()
            {
                Name = "Бухгалтерское дело",
                StatId = 31,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Scientific,
            };

            private readonly static Stat _geology = new Stat()
            {
                Name = "Геология",
                StatId = 32,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Scientific,
            };

            private readonly static Stat _history = new Stat()
            {
                Name = "История",
                StatId = 33,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Scientific,
            };

            private readonly static Stat _artsHistory = new Stat()
            {
                Name = "История искусств",
                StatId = 34,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Scientific,
            };

            private readonly static Stat _reading = new Stat()
            {
                Name = "Книжные изыскания",
                StatId = 35,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Scientific,
            };

            private readonly static Stat _cryptography = new Stat()
            {
                Name = "Криптография",
                StatId = 36,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Scientific,
            };

            private readonly static Stat _medicine = new Stat()
            {
                Name = "Медицина",
                StatId = 37,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Scientific,
            };

            private readonly static Stat _cthulhuMyth = new Stat()
            {
                Name = "Мифология Ктулху",
                StatId = 38,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Scientific,
            };

            private readonly static Stat _occultysm = new Stat()
            {
                Name = "Оккультизм",
                StatId = 39,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Scientific,
            };

            private readonly static Stat _teology = new Stat()
            {
                Name = "Теология",
                StatId = 40,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Scientific,
            };

            private readonly static Stat _phisics = new Stat()
            {
                Name = "Физика",
                StatId = 41,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Scientific,
            };

            private readonly static Stat _juridical = new Stat()
            {
                Name = "Юриспруденция",
                StatId = 42,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Scientific,
            };

            private readonly static Stat _foreignLanguages = new Stat()
            {
                Name = "Языки",
                StatId = 42,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Scientific,
            };
            #endregion

            #region Public
            /// <summary>
            /// Антропология
            /// </summary>
            public static Stat Anthropology => _anthropology;
            /// <summary>
            /// Археология
            /// </summary>
            public static Stat Archaeology => _archaeology;
            /// <summary>
            /// Архитектура
            /// </summary>
            public static Stat Architecture => _architecture;
            /// <summary>
            /// Биология
            /// </summary>
            public static Stat Biology => _biology;
            /// <summary>
            /// Бухгалтерский учет
            /// </summary>
            public static Stat Bookkeeping => _bookkeeping;
            /// <summary>
            /// Геология
            /// </summary>
            public static Stat Geology => _geology;
            /// <summary>
            /// История
            /// </summary>
            public static Stat History => _history;
            /// <summary>
            /// История искуссты
            /// </summary>
            public static Stat ArtsHistory => _artsHistory;
            /// <summary>
            /// Книжные изыскания
            /// </summary>
            public static Stat Reading => _reading;
            /// <summary>
            /// Криптография
            /// </summary>
            public static Stat Cryptography => _cryptography;
            /// <summary>
            /// Медицина
            /// </summary>
            public static Stat Medicine => _medicine;
            /// <summary>
            /// Мифология ктулху
            /// </summary>
            public static Stat CthulhuMyth => _cthulhuMyth;
            /// <summary>
            /// Оккультизм
            /// </summary>
            public static Stat Occultysm => _occultysm;
            /// <summary>
            /// Теология
            /// </summary>
            public static Stat Teology => _teology;
            /// <summary>
            /// Физика
            /// </summary>
            public static Stat Phisics => _phisics;
            /// <summary>
            /// Юриспруденция
            /// </summary>
            public static Stat Juridical => _juridical;
            /// <summary>
            /// Языки
            /// </summary>
            public static Stat ForeignLanguages => _foreignLanguages;
            #endregion
        }
    }

}
