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
            return speaker.GetRealEmail().ToGravatarLink(size);
        }

        public static string GetRealEmail(this Speaker speaker)
        {
            return IsEmailSpamProtected(speaker.Email) 
                ? RestoreSpamProtectedEmail(speaker.Email)
                : speaker.Email;
        }

        private static bool IsEmailSpamProtected(string email)
        {
            return email != null && email.Contains("#");
        }

        private static string RestoreSpamProtectedEmail(string email)
        {
            char[] charArray = email.ToCharArray();

            Array.Reverse(charArray);

            return new string(charArray).Replace('#', '@');
        }
    }
}