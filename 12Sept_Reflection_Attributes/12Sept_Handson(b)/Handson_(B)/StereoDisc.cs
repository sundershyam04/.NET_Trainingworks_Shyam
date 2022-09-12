using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handson__B_
{
    [System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    sealed class StereoDisc : Attribute
    {
        // See the attribute guidelines at 
        //  http://go.microsoft.com/fwlink/?LinkId=85236
        readonly string positionalString;

        // This is a positional argument
        //public StereoDisc(string positionalString)
        //{
        //    this.positionalString = positionalString;

        //    // TODO: Implement code here

        //    throw new NotImplementedException();
        //}

        //public string PositionalString
        //{
        //    get { return positionalString; }
        //}

        // Prop
        public string SongName { get; set; }

        public string Language { get; set; }

        public string Lyrics { get; set; }
    }

}
