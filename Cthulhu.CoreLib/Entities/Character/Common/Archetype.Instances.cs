using Cthulhu.CoreLib.Entities.Character.Stats;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace Cthulhu.CoreLib.Entities.Character.Common
{
    /// <summary>
    /// Тип персонажа
    /// </summary>
    public partial class Archetype
    {
        public static class Instances
        {
            public readonly static Archetype Vagabond = new Archetype()
            {
                ArchetypeId = 1,
                Name = "Хобо",
                CommonProfessionalStatsCount = 4,
                InvestigationProfessionalStatsCount = 3,
                ProfessionalStats = new List<Stat>()
                {
                    Stat.Common.Athletics ,
                    Stat.Common.Vigilance ,
                    Stat.Common.SelfDisguise ,
                    Stat.Social.Trading,
                    Stat.Social.CrimeSpeaking,
                    Stat.Common.Stealing ,
                    Stat.Applied.Trapping ,

                }.ToImmutableDictionary(s => s.StatId, s => s),
                Description = "Вы не из тех бедолаг, что лишились всего из-за Дпрессии. Вы король дорог, не желающий идти ко дну и упорно хватающийся за любой шанс. Избегая чужого общества, вы зайцем путешествуете на поездах, живя милостыней и работая лишь при крайней необходимости. Вам приходилось и воровать, но вы не станете профессиональным вором, как и не изберёте себе иную стезю."
            };

            public readonly static Archetype Antiquarian = new Archetype()
            {
                ArchetypeId = 2,
                Name = "Антиквар",
                MinStatusValue = 2,
                MaxStatusValue = 5,
                CommonProfessionalStatsCount = 0,
                InvestigationProfessionalStatsCount = 8,
                TotalProfessionalStatsCount = 8,
                ProfessionalStats = new List<Stat>()
                {
                    Stat.Scientific.Architecture ,
                    Stat.Scientific.ArtsHistory ,
                    Stat.Social.Trading,
                    Stat.Scientific.History ,
                    Stat.Scientific.ForeignLanguages ,
                    Stat.Scientific.Juridical ,
                    Stat.Scientific.Reading ,
                }.ToImmutableDictionary(s => s.StatId, s => s),
                Description = "Это не только профессия, но и состояние души: вы цените прошлое и находите себя, погружаясь в него с головой. Вы можете владеть скромной лавкой, быть штатным специалистом в местном музее или картинной галерее либо же просто увлекаться антиквариатом, древними книгами и произведениями искусства давно минувших дней."
            };

            public readonly static Archetype Archaeologist = new Archetype()
            {
                ArchetypeId = 3,
                Name = "Археолог",
                MinStatusValue = 4,
                MaxStatusValue = 5,
                CommonProfessionalStatsCount = 3,
                InvestigationProfessionalStatsCount = 7,
                TotalProfessionalStatsCount = 10,
                ProfessionalStats = new List<Stat>()
                {
                    Stat.Scientific.Archaeology ,
                    Stat.Common.Athletics ,
                    Stat.Applied.EvidenceCollection ,
                    Stat.Common.FirstAid,
                    Stat.Scientific.History ,
                    Stat.Scientific.ForeignLanguages ,
                    Stat.Scientific.Reading ,
                    Stat.Common.Riding ,
 
                }.ToImmutableDictionary(s => s.StatId, s => s),
                Description = "Раскапывая прошлое, вы путешествуете по далёким и загадочным местам. Вы можете быть старательным учёным, работающим в библиотеках и посвятившим свою жизнь поиску одной конкретной реликвии, или же немногим отличаться от расхитителей гробниц, охотясь за трофеями с кнутом и пистолетом наперевес. Быть может, расходы на ваши экспедиции покрывают продажи тех же самых сокровищ, либо ваши исследования финансируются университетами и заинтересованными организациями."
            };

            public readonly static Archetype Militarian = new Archetype()
            {
                ArchetypeId = 4,
                Name = "Военный",
                MinStatusValue = 2,
                MaxStatusValue = 4,
                CommonProfessionalStatsCount = 7,
                InvestigationProfessionalStatsCount = 2,
                TotalProfessionalStatsCount = 9,
                ProfessionalStats = new List<Stat>()
                {
                    Stat.Common.Athletics ,
                    Stat.Common.Shooting,
                    Stat.Social.Intimidation ,
                    Stat.Applied.Trapping ,
                    Stat.Common.Fighting,
                    Stat.Common.Fencing,

                    Stat.Common.ItemDisguise ,
                    Stat.Common.Driving ,
                    Stat.Common.SelfDisguise ,
                }.ToImmutableDictionary(s => s.StatId, s => s),
                Description = "Вы защищаете других от опасности ради славы, страны, друзей, денег или просто потому, что больше ничего не остаётся. Ваша жизнь полна рутины и зубрёжки, скуки и бюрократии, пыли и грязи. А иногда, разумеется, смерти, ужасов, крови и безумия."
            };

            public readonly static Archetype MilitarianDoctor = new Archetype()
            {
                ArchetypeId = 5,
                Name = "Военный врач",
                MinStatusValue = 2,
                MaxStatusValue = 5,
                CommonProfessionalStatsCount = 5,
                InvestigationProfessionalStatsCount = 4,
                TotalProfessionalStatsCount = 9,
                ProfessionalStats = new List<Stat>()
                {
                    Stat.Common.Athletics ,
                    Stat.Common.Shooting,
                    Stat.Social.Intimidation ,
                    Stat.Applied.Trapping ,
                    Stat.Common.Fighting,
                    Stat.Common.Fencing,

                    Stat.Common.FirstAid ,
                    Stat.Scientific.Medicine ,
                    Stat.Social.Calming ,
                }.ToImmutableDictionary(s => s.StatId, s => s),
                Description = "Вы защищаете других от опасности ради славы, страны, друзей, денег или просто потому, что больше ничего не остаётся. Ваша жизнь полна рутины и зубрёжки, скуки и бюрократии, пыли и грязи. А иногда, разумеется, смерти, ужасов, крови и безумия."
            };

            public readonly static Archetype MilitarianEngineer = new Archetype()
            {
                ArchetypeId = 6,
                Name = "Военный инженер/артиллерист",
                MinStatusValue = 2,
                MaxStatusValue = 4,
                CommonProfessionalStatsCount = 7,
                InvestigationProfessionalStatsCount = 2,
                TotalProfessionalStatsCount = 9,
                ProfessionalStats = new List<Stat>()
                {
                    Stat.Common.Athletics ,
                    Stat.Common.Shooting,
                    Stat.Social.Intimidation ,
                    Stat.Applied.Trapping ,
                    Stat.Common.Fighting,
                    Stat.Common.Fencing,

                    Stat.Common.Mining ,
                    Stat.Common.Driving ,
                    Stat.Common.Mechanics ,
                }.ToImmutableDictionary(s => s.StatId, s => s),
                Description = "Вы защищаете других от опасности ради славы, страны, друзей, денег или просто потому, что больше ничего не остаётся. Ваша жизнь полна рутины и зубрёжки, скуки и бюрократии, пыли и грязи. А иногда, разумеется, смерти, ужасов, крови и безумия."
            };

            public readonly static Archetype MilitarianSailor = new Archetype()
            {
                ArchetypeId = 7,
                Name = "Военный моряк",
                MinStatusValue = 2,
                MaxStatusValue = 4,
                CommonProfessionalStatsCount = 6,
                InvestigationProfessionalStatsCount = 3,
                TotalProfessionalStatsCount = 9,
                ProfessionalStats = new List<Stat>()
                {
                    Stat.Common.Athletics ,
                    Stat.Common.Shooting,
                    Stat.Social.Intimidation ,
                    Stat.Applied.Trapping ,
                    Stat.Common.Fighting,
                    Stat.Common.Fencing,

                    Stat.Applied.Astronomy ,
                    Stat.Common.ExtrimDriving ,
                    Stat.Common.Mechanics ,
                }.ToImmutableDictionary(s => s.StatId, s => s),
                Description = "Вы защищаете других от опасности ради славы, страны, друзей, денег или просто потому, что больше ничего не остаётся. Ваша жизнь полна рутины и зубрёжки, скуки и бюрократии, пыли и грязи. А иногда, разумеется, смерти, ужасов, крови и безумия."
            };

            public readonly static Archetype MilitarianOfficier = new Archetype()
            {
                ArchetypeId = 8,
                Name = "Военный (офицер)",
                MinStatusValue = 2,
                MaxStatusValue = 5,
                CommonProfessionalStatsCount = 5,
                InvestigationProfessionalStatsCount = 4,
                TotalProfessionalStatsCount = 9,
                ProfessionalStats = new List<Stat>()
                {
                    Stat.Common.Athletics ,
                    Stat.Common.Shooting,
                    Stat.Social.Intimidation ,
                    Stat.Applied.Trapping ,
                    Stat.Common.Fighting,
                    Stat.Common.Fencing,

                    Stat.Social.Bureaucracy ,
                    Stat.Social.Calming ,
                    Stat.Common.Riding ,
                }.ToImmutableDictionary(s => s.StatId, s => s),
                Description = "Вы защищаете других от опасности ради славы, страны, друзей, денег или просто потому, что больше ничего не остаётся. Ваша жизнь полна рутины и зубрёжки, скуки и бюрократии, пыли и грязи. А иногда, разумеется, смерти, ужасов, крови и безумия."
            };

            public readonly static Archetype Rentier = new Archetype()
            {
                ArchetypeId = 9,
                Name = "Дилетант",
                MinStatusValue = 3,
                MaxStatusValue = 7,
                CommonProfessionalStatsCount = 1,
                InvestigationProfessionalStatsCount = 2,
                TotalProfessionalStatsCount = 8,
                ProfessionalStats = new List<Stat>()
                {
                    Stat.Social.Status,
                    Stat.Social.Charm,
                    Stat.Common.Riding ,

                }.ToImmutableDictionary(s => s.StatId, s => s),
                Description = "Вы ни в чём себе не отказываете, проматывая нажитое честным трудом состояние, наследство родственников или ещё какой-то внушительный капитал. Не будучи связаны никакими обязательствами ни с работодателем, ни с подчинёнными, вы можете посвящать свою жизнь любым целям, каким только пожелаете."
            };

            public readonly static Archetype Doctor = new Archetype()
            {
                ArchetypeId = 10,
                Name = "Доктор",
                MinStatusValue = 4,
                MaxStatusValue = 6,
                CommonProfessionalStatsCount = 1,
                InvestigationProfessionalStatsCount = 8,
                TotalProfessionalStatsCount = 9,
                ProfessionalStats = new List<Stat>()
                {
                    Stat.Scientific.Bookkeeping,
                    Stat.Scientific.Biology,
                    Stat.Scientific.Medicine,
                    Stat.Common.FirstAid ,
                    Stat.Applied.Forensics,
                    Stat.Applied.Pharm,
                    Stat.Scientific.ForeignLanguages,
                    Stat.Social.Insight,
                    Stat.Social.Calming,
                }.ToImmutableDictionary(s => s.StatId, s => s),
                Description = "Вы видите свою работу как пример всех добродетелей общества: рациональная, человечная, чистая и бескорыстная. Если бы только общество можно было исцелить, как пациента, при помощи лекарств и хирургии! Более богатые и успешные врачи обычно обладают достаточными средствами, чтобы больше не марать руки в крови и грязи, на которых строятся их благородные цели."
            };

            public readonly static Archetype Journalist = new Archetype()
            {
                ArchetypeId = 11,
                Name = "Журналист",
                MinStatusValue = 2,
                MaxStatusValue = 4,
                CommonProfessionalStatsCount = 2,
                InvestigationProfessionalStatsCount = 8,
                TotalProfessionalStatsCount = 10,
                ProfessionalStats = new List<Stat>()
                {
                    Stat.Social.PoliceSpeaking,
                    Stat.Social.Talking,
                    Stat.Social.Insight,
                    Stat.Social.Calming,
                    Stat.Scientific.ForeignLanguages,
                    Stat.Common.ItemDisguise,
                    Stat.Common.Watching,
                    Stat.Applied.EvidenceCollection,
                    Stat.Applied.Photography,
                }.ToImmutableDictionary(s => s.StatId, s => s),
                Description = "Публикуясь в газетах и журналах или выходя в радиоэфир, вы раскрываете народу глаза на окружающий мир и связываете разрозненные факты в цельные истории. Вы можете попытаться остаться в стороне от собственных репортажей, чтобы не окунаться в мир коррупции и эгоизма, но не будет ли это предательством самого себя?"
            };

            public readonly static Archetype Pilot = new Archetype()
            {
                ArchetypeId = 12,
                Name = "Лётчик",
                MinStatusValue = 2,
                MaxStatusValue = 3,
                CommonProfessionalStatsCount = 5,
                InvestigationProfessionalStatsCount = 1,
                TotalProfessionalStatsCount = 6,
                ProfessionalStats = new List<Stat>()
                {
                    Stat.Applied.Astronomy,
                    Stat.Common.Driving,
                    Stat.Common.Electrical,
                    Stat.Common.Mechanics,
                    Stat.Common.ExtrimDriving,
                    Stat.Common.Vigilance,
                }.ToImmutableDictionary(s => s.StatId, s => s),
                Description = "Вы живёте, чтобы летать, и летаете, чтобы жить. Возможно, вы ветеран Первой мировой, переживающий моменты прошлого в полётах на стареньком кукурузнике, или курьер, надеющийся когда-нибудь нажить деньжат и открыть свою собственную компанию воздушных доставок. Быть может, вы водите последние новинки авиации на службе у богатеев либо собрали свою машину из деталей, которые вам удалось отрыть на ближайшей промышленной свалке. Какой бы дорогой вы ни шли, небо — единственное место, где вы чувствуете себя дома."
            };

            public readonly static Archetype Parapsychologist = new Archetype()
            {
                ArchetypeId = 12,
                Name = "Парапсихолог",
                MinStatusValue = 2,
                MaxStatusValue = 3,
                CommonProfessionalStatsCount = 3,
                InvestigationProfessionalStatsCount = 5,
                TotalProfessionalStatsCount = 8,
                ProfessionalStats = new List<Stat>()
                {
                    Stat.Scientific.Anthropology,
                    Stat.Common.Electrical,
                    Stat.Scientific.Reading,
                    Stat.Common.Mechanics,
                    Stat.Scientific.Occultysm,
                    Stat.Applied.Photography,
                    Stat.Social.Interrogation,
                    Stat.Common.Vigilance,
                }.ToImmutableDictionary(s => s.StatId, s => s),
                Description = "Видные учёные смотрят на вас искоса, в то время как ревностные приверженцы теорий о сверхъестественном сомневаются в искренности ваших взглядов. Вы ходите (иногда, возможно, теряя равновесие) по грани между логикой и суеверием, между верой и фактами. Вам кажется, что при помощи научного метода можно постигнуть истину теологии, а сверхъестественное — всего лишь естественное, которое ещё не удалось изучить."
            };
        }
    }

}
