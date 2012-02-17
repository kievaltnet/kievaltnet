﻿namespace WebSite.App.Speakers
{
    public class Speaker
    {
        public string Id { get; set; }
        public string FullName { get; set; }

        public string ShortAbout { get; set; }
        public string Bio { get; set; }
        public string Email { get; set; }
        public string Twitter { get; set; }
        public string MainProfileURL { get; set; }
        public string Avatar { get; set; }

        public Speach[] Speaches { get; set; }
    }

    public class Speach 
    {
        public string Title { get; set; }
        public string AnnounceLink { get; set; }
        public string MaterialsLink { get; set; }
    }
}