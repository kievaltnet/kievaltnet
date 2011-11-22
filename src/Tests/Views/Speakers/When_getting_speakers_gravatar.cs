using NUnit.Framework;
using Should.Fluent;
using WebSite.App.Speakers;
using WebSite.Views.Speakers;

namespace Tests.Views.Speakers
{
    public class When_getting_speakers_gravatar
    {
        private bool _canRednerAvatar;
        private string _avatarUrl;

        [TestFixtureSetUp]
        public void Given_speaker_without_avatar_defined() 
        {
            var speaker = new Speaker
            {
                Email = "example@example.com"
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
        public void Should_return_correct_gravatar_url()
        {
            _avatarUrl.Should().Equal("http://www.gravatar.com/avatar/23463b99b62a72f26ed677cc556c44e8?s=45");
        }          
    }
}
