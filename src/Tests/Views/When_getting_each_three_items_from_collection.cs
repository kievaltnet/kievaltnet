using System.Linq;
using System.Collections.Generic;

using NUnit.Framework;
using Should.Fluent;
using WebSite.Views;

namespace Tests.Views
{
    public class When_getting_each_three_items_from_collection
    {
        private IList<IEnumerable<string>> _result;

        [TestFixtureSetUp]
        public void Given_collection_with_fore_items()
        {
            var coll = new[] { "1", "2", "3", "4" };
            _result = coll.EachThree().ToList();;
        }

        [Test]
        public void Should_return_two_chanks()
        {
            _result.Should().Count.Exactly(2);
        }

        [Test]
        public void Should_return_tree_items_in_the_first_chank()
        {
            _result[0].Should().Count.Exactly(3);
        }

        [Test]
        public void Should_return_the_rest_one_item_in_the_second_chank()
        {
            _result[1].Should().Count.Exactly(1);
        }
    }
}
