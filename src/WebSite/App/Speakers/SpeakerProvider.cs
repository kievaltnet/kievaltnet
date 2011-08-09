using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace WebSite.App.Speakers
{
    public class SpeakerProvider
    {
        private readonly List<Speaker> _speakers;

        public SpeakerProvider(string source)
        {
            _speakers = JsonConvert.DeserializeObject<List<Speaker>>(source);
        }

        public IQueryable<Speaker> Query()
        {
            return _speakers.AsQueryable();
        }
    }
}