using Microsoft.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalAndroid.Scripts.Models
{
    class PokemonGOAutoSwiper : ScriptModel
    {
        public PokemonGOAutoSwiper() : base(
            name:         "Pokemon GO automated spot swiper", 
            description:  "Unlocks phone -> checks pokespot activity and swipes if active -> locks phone", 
            image_icon:   global::UniversalAndroid.Properties.Resources.pokeball
        ){}

        public override void Main()
        {
            Console.WriteLine("started?");
            this.addLogMessage("test");
        }
    }
}
