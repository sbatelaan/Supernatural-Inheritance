using System;

namespace MagicalInheritance
{
     class Storm
    {
        public string Essence
        { get; private set; }
        public bool IsStrong
        { get; private set; }   

        public string Caster
        { get; private set; }   

        //Storm s = new Storm("wind", false, "your name")
        public Storm(string essence, bool isStrong, string caster)
        {
            Essence = essence;
            IsStrong = isStrong;
            Caster = caster;
        }

        public string Announce()
        {
            if (IsStrong == true)
            {
                return $"{Caster} casts a strong {Essence} storm!";
            }
            else
            {
                return $"{Caster} casts a weak {Essence} storm!";
            }
        }
    }
}