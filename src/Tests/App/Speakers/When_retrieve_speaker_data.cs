using System.Linq;
using System.IO;
using NUnit.Framework;
using WebSite.App.Speakers;
using Should.Fluent;
using System;

namespace Tests.App.Speackers
{
    public class When_retrieve_speaker_data
    {

        private SpeakerProvider _provider;

        [TestFixtureSetUp]
        public void Given_source_data()
        {
            var directory = GetDataDirectory();
            _provider = new SpeakerProvider(directory);            
        }

        [Test]
        public void Should_deserialize_something()
        {
            _provider.Should().Not.Be.Empty();
        }

        [Test]
        public void Should_deserialize_id()
        {
            _provider.First().Id.Should().Equal("example1");
        }

        [Test]
        public void Should_deserialize_details()
        {
            _provider.First().FullName.Should().Equal("Example Examploff");
            _provider.First().Bio.Should().StartWith("First line of the bio");
            _provider.First().Email.Should().Equal("example@example.com");
            _provider.First().MainProfileURL.Should().Equal("http://example.com");
        }

        [Test]
        public void Should_deserialize_bio()
        {            
            _provider.First().Bio.Should().StartWith("First line of the bio");
            _provider.First().Bio.Should().Contain("Другий рядок, тепер ще і");
            _provider.First().Bio.Should().Contain("http://example.com");
            _provider.First().Bio.Should().Contain("\n");
        }

        [Test]
        public void Should_deserialize_speaches()
        {
            _provider.First().Speaches.Should().Count.Exactly(2);
            _provider.First().Speaches[0].Title.Should().Equal("Super Speach");
            _provider.First().Speaches[0].AnonceLink.Should().Equal("http://example.com/1-event");
            //_provider.First().Speaches[0].MaterialsLink.Should().Equal("http://example.com/1-event-materials");
        }

        private static DirectoryInfo GetDataDirectory()
        {
            var codeBase = typeof(When_retrieve_speaker_data).Assembly.CodeBase;
            var uri = new UriBuilder(codeBase);
            var path = Uri.UnescapeDataString(uri.Path);
            return new DirectoryInfo(Path.Combine(Path.GetDirectoryName(path), "App\\Speakers\\Data\\"));
        }
    }
}
