using Cthulhu.CoreLib.Entities.Character.Stats;

namespace Cthulhu.CoreLib.Entities.Character.Stats
{
    public partial class Stat
    {
        public static class Common
        {
            #region Privates
            private readonly static Stat _anyCommon = new Stat()
            {
                Name = "Любая общая способность",
                StatId = 70,
                RestoringSpec = StatRestoringSpec.Unspec,
                Type = StatType.Unspec,
            };

            private readonly static Stat _sanity = new Stat()
            {
                Name = "Рассудок",
                StatId = 1,
                RestoringSpec = StatRestoringSpec.Never,
                Type = StatType.Common,
            };

            private readonly static Stat _health = new Stat()
            {
                Name = "Здоровье",
                StatId = 2,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Common,
            };

            private readonly static Stat _composure = new Stat()
            {
                Name = "Самообладание",
                StatId = 3,
                RestoringSpec = StatRestoringSpec.BetweenGames,
                Type = StatType.Common,
            };

            private readonly static Stat _athletics = new Stat()
            {
                Name = "Атлетика",
                StatId = 4,
                RestoringSpec = StatRestoringSpec.Nightly,
                Type = StatType.Common,
            };

            private readonly static Stat _vigilance = new Stat()
            {
                Name = "Бдительность",
                StatId = 5,
                RestoringSpec = StatRestoringSpec.Nightly,
                Type = StatType.Common,
            };

            private readonly static Stat _running = new Stat()
            {
                Name = "Бегство",
                StatId = 6,
                RestoringSpec = StatRestoringSpec.Nightly,
                Type = StatType.Common,
            };

            private readonly static Stat _riding = new Stat()
            {
                Name = "Верховая езда",
                StatId = 7,
                RestoringSpec = StatRestoringSpec.Nightly,
                Type = StatType.Common,
            };

            private readonly static Stat _mining = new Stat()
            {
                Name = "Взрывотехника",
                StatId = 8,
                RestoringSpec = StatRestoringSpec.Nightly,
                Type = StatType.Common,
            };

            private readonly static Stat _driving = new Stat()
            {
                Name = "Вождение",
                StatId = 9,
                RestoringSpec = StatRestoringSpec.Nightly,
                Type = StatType.Common,
            };

            private readonly static Stat _stealing = new Stat()
            {
                Name = "Воровство",
                StatId = 10,
                RestoringSpec = StatRestoringSpec.Nightly,
                Type = StatType.Common,
            };

            private readonly static Stat _hipnosis = new Stat()
            {
                Name = "Гипноз",
                StatId = 11,
                RestoringSpec = StatRestoringSpec.Nightly,
                Type = StatType.Common,
            };

            private readonly static Stat _fighting = new Stat()
            {
                Name = "Драка",
                StatId = 12,
                RestoringSpec = StatRestoringSpec.Nightly,
                Type = StatType.Common,
            };

            private readonly static Stat _itemDisguise = new Stat()
            {
                Name = "Маскировка",
                StatId = 13,
                RestoringSpec = StatRestoringSpec.Nightly,
                Type = StatType.Common,
            };

            private readonly static Stat _mechanics = new Stat()
            {
                Name = "Механика",
                StatId = 14,
                RestoringSpec = StatRestoringSpec.Nightly,
                Type = StatType.Common,
            };

            private readonly static Stat _firstAid = new Stat()
            {
                Name = "Первая помощь",
                StatId = 15,
                RestoringSpec = StatRestoringSpec.Nightly,
                Type = StatType.Common,
            };

            private readonly static Stat _extrimDriving = new Stat()
            {
                Name = "Пилотирование",
                StatId = 16,
                RestoringSpec = StatRestoringSpec.Nightly,
                Type = StatType.Common,
            };

            private readonly static Stat _foresight = new Stat()
            {
                Name = "Предусмотрительность",
                StatId = 17,
                RestoringSpec = StatRestoringSpec.Nightly,
                Type = StatType.Common,
            };

            private readonly static Stat _acting = new Stat()
            {
                Name = "Притворство",
                StatId = 18,
                RestoringSpec = StatRestoringSpec.Nightly,
                Type = StatType.Common,
            };

            private readonly static Stat _psychoanalysis = new Stat()
            {
                Name = "Психоанализ",
                StatId = 20,
                RestoringSpec = StatRestoringSpec.Nightly,
                Type = StatType.Common,
            };

            private readonly static Stat _selfDisguise = new Stat()
            {
                Name = "Скрытность",
                StatId = 21,
                RestoringSpec = StatRestoringSpec.Nightly,
                Type = StatType.Common,
            };

            private readonly static Stat _watching = new Stat()
            {
                Name = "Слежка",
                StatId = 22,
                RestoringSpec = StatRestoringSpec.Nightly,
                Type = StatType.Common,
            };

            private readonly static Stat _shooting = new Stat()
            {
                Name = "Стрельба",
                StatId = 23,
                RestoringSpec = StatRestoringSpec.Nightly,
                Type = StatType.Common,
            };

            private readonly static Stat _fencing = new Stat()
            {
                Name = "Фехтование",
                StatId = 24,
                RestoringSpec = StatRestoringSpec.Nightly,
                Type = StatType.Common,
            };

            private readonly static Stat _electrical = new Stat()
            {
                Name = "Электротехника",
                StatId = 25,
                RestoringSpec = StatRestoringSpec.Nightly,
                Type = StatType.Common,
            };

            private readonly static Stat _magic = new Stat()
            {
                Name = "Магия",
                StatId = 26,
                RestoringSpec = StatRestoringSpec.Nightly,
                Type = StatType.Common,
            };

            #endregion

            #region Public

            /// <summary>
            /// Любая общая способность
            /// </summary>
            public static Stat AnyCommon => _anyCommon;
            /// <summary>
            /// Рассудок
            /// </summary>
            public static Stat Sanity => _sanity;
            /// <summary>
            /// Здоровье
            /// </summary>
            public static Stat Health => _health;
            /// <summary>
            /// Самообладание
            /// </summary>
            public static Stat Composure => _composure;
            /// <summary>
            /// Атлетика
            /// </summary>
            public static Stat Athletics => _athletics;
            /// <summary>
            /// Бдительность
            /// </summary>
            public static Stat Vigilance => _vigilance;
            /// <summary>
            /// Бегство
            /// </summary>
            public static Stat Running = _running;
            /// <summary>
            /// Верховая езда
            /// </summary>
            public static Stat Riding => _riding;
            /// <summary>
            /// Взрывотехника
            /// </summary>
            public static Stat Mining => _mining;
            /// <summary>
            /// Вождение
            /// </summary>
            public static Stat Driving => _driving;
            /// <summary>
            /// Воровство
            /// </summary>
            public static Stat Stealing => _stealing;
            /// <summary>
            /// Гипноз
            /// </summary>
            public static Stat Hipnosis => _hipnosis;
            /// <summary>
            /// Драка
            /// </summary>
            public static Stat Fighting => _fighting;
            /// <summary>
            /// Маскировка
            /// </summary>
            public static Stat ItemDisguise => _itemDisguise;
            /// <summary>
            /// Механика
            /// </summary>
            public static Stat Mechanics => _mechanics;
            /// <summary>
            /// Первая помощь
            /// </summary>
            public static Stat FirstAid => _firstAid;
            /// <summary>
            /// Пилотирование
            /// </summary>
            public static Stat ExtrimDriving => _extrimDriving;
            /// <summary>
            /// Предусмотрительность
            /// </summary>
            public static Stat Foresight => _foresight;
            /// <summary>
            /// Притворство
            /// </summary>
            public static Stat Acting => _acting;
            /// <summary>
            /// Психоанализ
            /// </summary>
            public static Stat Psychoanalysis => _psychoanalysis;
            /// <summary>
            /// Скрытность
            /// </summary>
            public static Stat SelfDisguise => _selfDisguise;
            /// <summary>
            /// Слежка
            /// </summary>
            public static Stat Watching => _watching;
            /// <summary>
            /// Стрельба
            /// </summary>
            public static Stat Shooting => _shooting;
            /// <summary>
            /// Фехтование
            /// </summary>
            public static Stat Fencing => _fencing;
            /// <summary>
            /// Электротехника
            /// </summary>
            public static Stat Electrical => _electrical;
            /// <summary>
            /// Магия
            /// </summary>
            public static Stat Magic => _magic;

            #endregion
        }
    }

}
