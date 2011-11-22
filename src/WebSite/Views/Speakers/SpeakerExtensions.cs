using System;
using WebSite.App.Speakers;
namespace WebSite.Views.Speakers
{
    public static class SpeakerExtensions
    {
        public static bool CanRenderAvatar(this Speaker speaker) 
        {
            return !String.IsNullOrWhiteSpace(speaker.Avatar)
                || !String.IsNullOrWhiteSpace(speaker.Email);
        }

        public static string GetAvatarLink(this Speaker speaker, int size)
        {
            if (!String.IsNullOrWhiteSpace(speaker.Avatar)) 
            {
                return speaker.Avatar;
            }
            return speaker.Email.ToGravatarLink(size);
        }
    }
}