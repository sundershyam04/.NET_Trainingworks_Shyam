using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handson__B_
{

    [StereoDisc(SongName ="Jai Ho",Language ="Hindi",Lyrics ="aAJA AAJA DIL ME ...")]
    internal class Song

    {
        [StereoDisc(SongName = "Ponni nadhi", Language = "Tamil", Lyrics = "ponni nadhi parkanume... ...")]
        public int SongId { get; set; }

        [StereoDisc(SongName = "DHOOM MACHALE", Language = "HINDI", Lyrics = "dhoom machale... ...")]
        public int ReleaseYear { get; set; }

        [StereoDisc(SongName="IRAGAI POLE", Language = "TAMIL")]
        public string CopyRights { get; set; }

    }
}
