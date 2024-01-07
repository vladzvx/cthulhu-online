using Cthulhu.CoreLib.Entities.Character;
using Cthulhu.CoreLib.Entities.Character.Stats;

namespace Cthulhu.CoreLib.Tests
{
    [TestClass]
    public class InvestigatorTabletTests
    {
        [TestMethod]
        public void UnwrapStatsForSelection_Any()
        {
            var res = new List<Stat>();
            InvestigatorTablet.UnwrapStatsForSelection(Stat.Any, res);
            Assert.IsFalse(res.Any(r => r.StatId <= 0));
            Assert.IsNotNull(Stat.Any.OneOf);
        }

        [TestMethod]
        public void UnwrapStatsForSelection_AnyScientific()
        {
            var res = new List<Stat>();
            InvestigatorTablet.UnwrapStatsForSelection(Stat.Scientific.Any, res);
            Assert.IsFalse(res.Any(r => r.StatId <= 0));
            Assert.IsNotNull(Stat.Scientific.Any.OneOf);
            Assert.IsTrue(Stat.Scientific.Any.OneOf.Count==res.Count);
        }

        [TestMethod]
        public void UnwrapStatsForSelection_AnySocial()
        {
            var res = new List<Stat>();
            InvestigatorTablet.UnwrapStatsForSelection(Stat.Social.Any, res);
            Assert.IsFalse(res.Any(r => r.StatId <= 0));
            Assert.IsNotNull(Stat.Social.Any.OneOf);
            Assert.IsTrue(Stat.Social.Any.OneOf.Count == res.Count);
        }

        [TestMethod]
        public void UnwrapStatsForSelection_OneOfTwo()
        {
            var stat = Stat.GetOneOf(Stat.Common.Driving, Stat.Social.Interrogation);
            var res = new List<Stat>();
            InvestigatorTablet.UnwrapStatsForSelection(stat, res);
            Assert.IsFalse(res.Any(r => r.StatId <= 0));
            Assert.IsNotNull(stat.OneOf);
            Assert.IsTrue(res.Count == stat.OneOf.Count);
        }

        [TestMethod]
        public void UnwrapStatsForSelection_OneOfTargetAndAny()
        {
            var stat = Stat.GetOneOf(Stat.Common.Driving, Stat.Social.Any);
            var res = new List<Stat>();
            InvestigatorTablet.UnwrapStatsForSelection(stat, res);
            Assert.IsFalse(res.Any(r => r.StatId <= 0));
            Assert.IsNotNull(Stat.Social.Any.OneOf);
            Assert.IsTrue(res.Count == Stat.Social.Any.OneOf.Count + 1);
        }

        [TestMethod]
        public void UnwrapStatsForSelection_TwoAny()
        {
            var stat = Stat.GetOneOf(Stat.Common.Any, Stat.Social.Any);
            var res = new List<Stat>();
            InvestigatorTablet.UnwrapStatsForSelection(stat, res);
            Assert.IsFalse(res.Any(r => r.StatId <= 0));
            Assert.IsNotNull(Stat.Social.Any.OneOf);
            Assert.IsNotNull(Stat.Common.Any.OneOf);
            Assert.IsTrue(res.Count == Stat.Social.Any.OneOf.Count + Stat.Common.Any.OneOf.Count);
        }

        [TestMethod]
        public void UnwrapStatsForSelection_ThreeAny()
        {
            var stat = Stat.GetOneOf(Stat.Common.Any, Stat.Social.Any, Stat.Applied.Any);
            var res = new List<Stat>();
            InvestigatorTablet.UnwrapStatsForSelection(stat, res);
            Assert.IsFalse(res.Any(r => r.StatId <= 0));
            Assert.IsNotNull(Stat.Social.Any.OneOf);
            Assert.IsNotNull(Stat.Common.Any.OneOf);
            Assert.IsNotNull(Stat.Applied.Any.OneOf);
            Assert.IsTrue(res.Count == Stat.Social.Any.OneOf.Count + Stat.Common.Any.OneOf.Count + Stat.Applied.Any.OneOf.Count);
        }
    }
}