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
                ProfessionalStats = new List<Stat>()
                {
                    Stat.Scientific.Architecture ,
                    Stat.Scientific.ArtsHistory ,
                    Stat.Social.Trading,
                    Stat.Scientific.History ,
                    Stat.Scientific.ForeignLanguages ,
                    Stat.Scientific.Juridical ,
                    Stat.Scientific.Reading ,
                    Stat.AnyInvestigate,
                }.ToImmutableDictionary(s => s.StatId, s => s),
                Description = "Это не только профессия, но и состояние души: вы цените прошлое и находите себя, погружаясь в него с головой. Вы можете владеть скромной лавкой, быть штатным специалистом в местном музее или картинной галерее либо же просто увлекаться антиквариатом, древними книгами и произведениями искусства давно минувших дней."
            };

            public readonly static Archetype Archaeologist = new Archetype()
            {
                ArchetypeId = 3,
                Name = "Археолог",
                MinStatusValue = 4,
                MaxStatusValue = 5,

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
                    Stat.AnyInvestigate,
                    Stat.AnyInvestigate,
 
                }.ToImmutableDictionary(s => s.StatId, s => s),
                Description = "Раскапывая прошлое, вы путешествуете по далёким и загадочным местам. Вы можете быть старательным учёным, работающим в библиотеках и посвятившим свою жизнь поиску одной конкретной реликвии, или же немногим отличаться от расхитителей гробниц, охотясь за трофеями с кнутом и пистолетом наперевес. Быть может, расходы на ваши экспедиции покрывают продажи тех же самых сокровищ, либо ваши исследования финансируются университетами и заинтересованными организациями."
            };

            public readonly static Archetype Militarian = new Archetype()
            {
                ArchetypeId = 4,
                Name = "Военный",
                MinStatusValue = 2,
                MaxStatusValue = 4,

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
                    Stat.GetOneOf(
                        Stat.Common.Riding,
                        Stat.Common.ExtrimDriving
                        ) ,
                }.ToImmutableDictionary(s => s.StatId, s => s),
                Description = "Вы защищаете других от опасности ради славы, страны, друзей, денег или просто потому, что больше ничего не остаётся. Ваша жизнь полна рутины и зубрёжки, скуки и бюрократии, пыли и грязи. А иногда, разумеется, смерти, ужасов, крови и безумия."
            };

            public readonly static Archetype Rentier = new Archetype()
            {
                ArchetypeId = 9,
                Name = "Дилетант",
                MinStatusValue = 3,
                MaxStatusValue = 7,

                ProfessionalStats = new List<Stat>()
                {
                    Stat.Social.Status,
                    Stat.Social.Charm,
                    Stat.Common.Riding,
                    Stat.Any,
                    Stat.Any,
                    Stat.Any,
                    Stat.Any,
                    Stat.Any,
                }.ToImmutableDictionary(s => s.StatId, s => s),
                Description = "Вы ни в чём себе не отказываете, проматывая нажитое честным трудом состояние, наследство родственников или ещё какой-то внушительный капитал. Не будучи связаны никакими обязательствами ни с работодателем, ни с подчинёнными, вы можете посвящать свою жизнь любым целям, каким только пожелаете."
            };

            public readonly static Archetype Doctor = new Archetype()
            {
                ArchetypeId = 10,
                Name = "Доктор",
                MinStatusValue = 4,
                MaxStatusValue = 6,

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
                    Stat.Social.Any,
                }.ToImmutableDictionary(s => s.StatId, s => s),
                Description = "Публикуясь в газетах и журналах или выходя в радиоэфир, вы раскрываете народу глаза на окружающий мир и связываете разрозненные факты в цельные истории. Вы можете попытаться остаться в стороне от собственных репортажей, чтобы не окунаться в мир коррупции и эгоизма, но не будет ли это предательством самого себя?"
            };

            public readonly static Archetype Pilot = new Archetype()
            {
                ArchetypeId = 12,
                Name = "Лётчик",
                MinStatusValue = 2,
                MaxStatusValue = 3,
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

            public readonly static Archetype Writer = new Archetype()
            {
                ArchetypeId = 13,
                Name = "Писатель",
                MinStatusValue = 1,
                MaxStatusValue = 3,
                ProfessionalStats = new List<Stat>()
                {
                    Stat.Scientific.ArtsHistory,
                    Stat.Scientific.ForeignLanguages,
                    Stat.Scientific.Reading,
                    Stat.Applied.Art,
                    Stat.Social.Insight,
                    Stat.Social.Talking,
                    Stat.Social.Any,
                    Stat.Social.Any,
                    Stat.Social.Any,

                }.ToImmutableDictionary(s => s.StatId, s => s),
                Description = "Вы используете слова, чтобы переносить на бумагу окружающий мир, срывать покровы с истины или продавать свои фантазии обедневшим от Депрессии читателям. Возможно, — для всего перечисленного выше. Вы работаете в одиночку и получаете жалкие центы. Нередко вам приходится ломать голову над финалом рассказа лишь для того, чтобы не умереть с голоду на следующей неделе. Однако обладая хотя бы толикой таланта и разумно распоряжаясь своим временем, даже последний писатель десятицентовых романов сможет держать голову над водой."
            };

            public readonly static Archetype Policeman = new Archetype()
            {
                ArchetypeId = 14,
                Name = "Полицейский детектив",
                MinStatusValue = 3,
                MaxStatusValue = 4,

                ProfessionalStats = new List<Stat>()
                {
                    Stat.Common.Vigilance,
                    Stat.Common.Athletics,
                    Stat.Common.Driving,
                    Stat.Common.Shooting,
                    Stat.Social.Interrogation,
                    Stat.Applied.EvidenceCollection,
                    Stat.Social.PoliceSpeaking,
                    Stat.Scientific.Juridical,
                    Stat.Social.Insight,

                }.ToImmutableDictionary(s => s.StatId, s => s),
                Description = "Вы живёте по закону копа — тому, что вам вбили в голову в академии, или тому, которому вы научились во время пешего патрулирования злачных районов. Вы проводите черту между полицией, преступниками и гражданскими, и лучше бы никому не пересекать её. Когда закон и правосудие расходятся во мнениях, именно вам достаётся право решать, где проходит эта черта."
            };

            public readonly static Archetype Criminal = new Archetype()
            {
                ArchetypeId = 15,
                Name = "Преступник",
                MinStatusValue = 0,
                MaxStatusValue = 4,
                ProfessionalStats = new List<Stat>()
                {
                    Stat.Social.Trading,
                    Stat.Social.Intimidation,
                    Stat.Applied.Lockpiking,
                    Stat.Common.Fighting,
                    Stat.Common.Vigilance,
                    Stat.Common.Watching,
                    Stat.Common.SelfDisguise,
                    Stat.Social.CrimeSpeaking,
                    Stat.GetOneOf(
                        Stat.Social.Any,
                        Stat.Applied.Any
                        )
                }.ToImmutableDictionary(s => s.StatId, s => s),
                Description = "Живущие по ту сторону закона прекрасно осведомлены о тайном мире подлости, отчаяния и предательства, который находится вне поля зрения законопослушных граждан. Некоторые преступники сформировали собственные понятия чести и ведут дела по своим правилам, чтобы огородиться от осознания того, что даже самый строгий порядок цивилизации может рухнуть под гнётом корысти и своеволия отдельных людей. Другие же упиваются этим открытием."
            };

            public readonly static Archetype Professor = new Archetype()
            {
                ArchetypeId = 16,
                Name = "Профессор",
                MinStatusValue = 3,
                MaxStatusValue = 5,

                ProfessionalStats = new List<Stat>()
                {
                    Stat.Social.Bureaucracy,
                    Stat.Scientific.Reading,
                    Stat.Social.Any,
                    Stat.GetOneOf(
                        Stat.Scientific.Any,
                        Stat.Applied.Chemistry,
                        Stat.Applied.Astronomy
                        ),
                    Stat.GetOneOf(
                        Stat.Scientific.Any,
                        Stat.Applied.Chemistry,
                        Stat.Applied.Astronomy
                        ),
                    Stat.GetOneOf(
                        Stat.Scientific.Any,
                        Stat.Applied.Chemistry,
                        Stat.Applied.Astronomy
                        )
                }.ToImmutableDictionary(s => s.StatId, s => s),
                Description = "Вы можете быть спокойным одиночкой, любящим осмыслять мудрость тысячелетий среди колечек дыма из вашей трубки. А можете — наивным ребёнком в теле взрослого, неумелым во всём, кроме средневерхненемецкого языка, из-за владения которым вы важничаете и задираете нос. Вы можете быть вторым, но считать себя первым, тем самым доставляя несказанную радость всем вокруг."
            };

            public readonly static Archetype Psychiatrist = new Archetype()
            {
                ArchetypeId = 17,
                Name = "Психиатр",
                MinStatusValue = 3,
                MaxStatusValue = 4,

                ProfessionalStats = new List<Stat>()
                {
                    Stat.Scientific.Biology,
                    Stat.Scientific.ForeignLanguages,
                    Stat.Scientific.Reading,
                    Stat.Scientific.Medicine,
                    Stat.Applied.Pharm,
                    Stat.Common.Psychoanalysis,
                    Stat.Social.Insight,
                    Stat.Social.Any,
                    Stat.Social.Any,
                }.ToImmutableDictionary(s => s.StatId, s => s),
                Description = "Вы специалист по болезням души. Быть может, вас обучали психоанализу в Вене, вы занимаетесь неврологией и функциями мозга человека, либо же вы простой врач, интересующийся науками о человеческом поведении. Несмотря на то, что в последнее время среди психиатров всё больше последователей набирает учение Фрейда, пока что ему далеко до всеобщего признания."
            };

            public readonly static Archetype Priest = new Archetype()
            {
                ArchetypeId = 18,
                Name = "Священник",
                MinStatusValue = 2,
                MaxStatusValue = 5,

                ProfessionalStats = new List<Stat>()
                {
                    Stat.Scientific.History,
                    Stat.Scientific.ForeignLanguages,
                    Stat.Scientific.Reading,
                    Stat.Common.Psychoanalysis,
                    Stat.Social.Insight,
                    Stat.Social.Calming,
                    Stat.Scientific.Teology,
                    Stat.Social.Any,
                }.ToImmutableDictionary(s => s.StatId, s => s),
                Description = "Будь то странствующий проповедник, приходской пастор, учёный раввин или ярый миссионер, каждому священнику ежедневно приходится сталкиваться с испытаниями, которым Господь подвергает тех, кто внемлет голосу свыше. Быть может, вы и склонны к вере в сверхъестественное, но эта же вера делает вас особенно уязвимым к нечестивым откровениям Мифов."
            };

            public readonly static Archetype Scientist = new Archetype()
            {
                ArchetypeId = 19,
                Name = "Ученый",
                MinStatusValue = 3,
                MaxStatusValue = 5,

                ProfessionalStats = new List<Stat>()
                {
                    Stat.Common.Electrical,
                    Stat.Applied.EvidenceCollection,
                    Stat.Scientific.ForeignLanguages,
                    Stat.Scientific.Reading,
                    Stat.Applied.Photography,
                    Stat.GetOneOf(
                        Stat.Applied.Astronomy,
                        Stat.Scientific.Biology,
                        Stat.Applied.Chemistry,
                        Stat.Scientific.Cryptography,
                        Stat.Applied.Forensics,
                        Stat.Scientific.Geology,
                        Stat.Scientific.Phisics
                        ),
                    Stat.GetOneOf(
                        Stat.Applied.Astronomy,
                        Stat.Scientific.Biology,
                        Stat.Applied.Chemistry,
                        Stat.Scientific.Cryptography,
                        Stat.Applied.Forensics,
                        Stat.Scientific.Geology,
                        Stat.Scientific.Phisics
                        )
                }.ToImmutableDictionary(s => s.StatId, s => s),
                Description = "Вы работаете во имя продвижения науки, быть может, с целью изменить мир или ради познания какой-то неуловимой истины. Вы считаете себя умелым практиком, и в лаборатории вы, как рыба в воде, а тот пожар мог произойти у кого угодно. Вам просто нужно больше снаряжения, больше времени, больше образцов, больше понимающих коллег. Те глупцы посмеялись над вами в университете. Ничего, вы им ещё покажете."
            };

            public readonly static Archetype Paramedic = new Archetype()
            {
                ArchetypeId = 20,
                Name = "Фельдшер/медсестра",
                MinStatusValue = 2,
                MaxStatusValue = 4,

                ProfessionalStats = new List<Stat>()
                {
                    Stat.Scientific.Biology,
                    Stat.Common.FirstAid,
                    Stat.Scientific.Medicine,
                    Stat.Applied.Pharm,
                    Stat.Social.Insight,
                    Stat.Social.Calming,
                }.ToImmutableDictionary(s => s.StatId, s => s),
                Description = "Фельдшеры и медсёстры — это медики, специально обученные оказывать первую помощь и работать ассистентами при сложных операциях. Они обычно менее образованны, меньше получают и более склонны к состраданию, нежели доктора медицины."
            };

            public readonly static Archetype Artist = new Archetype()
            {
                ArchetypeId = 21,
                Name = "Художник",
                MinStatusValue = 1,
                MaxStatusValue = 4,

                ProfessionalStats = new List<Stat>()
                {
                    Stat.Scientific.Architecture,
                    Stat.Applied.Art,
                    Stat.Scientific.ArtsHistory,
                    Stat.Applied.Craft,
                    Stat.Common.ItemDisguise,
                    Stat.Social.Charm,
                    Stat.Applied.Photography,
                    Stat.Social.Insight,
                    Stat.GetOneOf(
                        Stat.Scientific.Any,
                        Stat.Social.Any
                        ),
                    Stat.GetOneOf(
                        Stat.Scientific.Any,
                        Stat.Social.Any
                        )
                }.ToImmutableDictionary(s => s.StatId, s => s),
                Description = "Живописец ли вы, музыкант, скульптор, архитектор или даже актёр, вы следуете за вашей музой, куда бы она вас ни повела. Все знают, что вы чувственная и темпераментная личность, обитающая в никому не понятном мире, и, возможно, это даже правда."
            };

            public readonly static Archetype PrivateInvestigator  = new Archetype()
            {
                ArchetypeId = 22,
                Name = "Частный сыщик",
                MinStatusValue = 2,
                MaxStatusValue = 3,

                ProfessionalStats = new List<Stat>()
                {
                    Stat.Scientific.Bookkeeping,
                    Stat.Common.ItemDisguise,
                    Stat.Common.Driving,
                    Stat.Scientific.Juridical,
                    Stat.Applied.Lockpiking,
                    Stat.Applied.Photography,
                    Stat.Social.Insight,
                    Stat.Social.Calming,
                    Stat.Common.Fighting,
                    Stat.Common.Watching,

                }.ToImmutableDictionary(s => s.StatId, s => s),
                Description = "Есть вещи, которые не под силу копам, а также вещи, за которые они не возьмутся, а вы возьмётесь только за деньги. Иногда вы влипаете в дело, в котором копы вам совсем не рады, но вам нужно довести его до конца. Зачем? Вот это уже настоящая загадка, не правда ли?"
            };
        }
    }

}
