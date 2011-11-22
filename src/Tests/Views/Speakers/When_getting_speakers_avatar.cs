using NUnit.Framework;
using Should.Fluent;
using WebSite.App.Speakers;
using WebSite.Views.Speakers;

namespace Tests.Views.Speakers
{
    public class When_getting_speakers_avatar
    {
        private bool _canRednerAvatar;
        private string _avatarUrl;

        [TestFixtureSetUp]
        public void Given_speaker_without_avatar_defined() 
        {
            var speaker = new Speaker
            {
                Email = "example@example.com",
                Avatar = "http://example.com/ava.png"
            };

            _canRednerAvatar = speaker.CanRenderAvatar();
            _avatarUrl = speaker.GetAvatarLink(45);
        }

        [Test]
        public void Should_report_that_can_render_avatar() 
        {
            _canRednerAvatar.Should().Be.True();
        }

        [Test]
        public void Should_return_correct_avatar_url()
        {
            _avatarUrl.Should().Equal("http://example.com/ava.png");
        }          
    }
}
