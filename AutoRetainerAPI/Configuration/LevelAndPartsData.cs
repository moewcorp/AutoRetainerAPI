using System;
using System.Reflection;

namespace AutoRetainerAPI.Configuration
{
    [Obfuscation(Exclude = true, ApplyToMembers = true)]

    public class LevelAndPartsData
    {
        public string GUID     = Guid.NewGuid().ToString();
        public int    MinLevel = 1;
        public int    MaxLevel = 2;
        public Hull   Part1    = Hull.Shark;
        public Stern  Part2    = Stern.Shark;
        public Bow    Part3    = Bow.Shark;
        public Bridge Part4    = Bridge.Shark;

        public VesselBehavior VesselBehavior     = VesselBehavior.Unlock;
        public UnlockMode     UnlockMode         = UnlockMode.SpamOne;
        public string         SelectedUnlockPlan = Guid.Empty.ToString();
        public string         SelectedPointPlan  = Guid.Empty.ToString();

        public bool           FirstSubDifferent;
        public VesselBehavior FirstSubVesselBehavior; 
        public UnlockMode     FirstSubUnlockMode;
        public string         FirstSubSelectedUnlockPlan = Guid.Empty.ToString();
        public string         FirstSubSelectedPointPlan  = Guid.Empty.ToString();
    }

    public enum Hull
    {
        Shark = 21794,
        Unkiu = 21798,
        Whale = 22528,
        Coelacanth = 23905
    }

    public enum Stern
    {
        Shark      = 21795,
        Unkiu      = 21799,
        Whale      = 22529,
        Coelacanth = 23906
    }

    public enum Bow
    {
        Shark      = 21792,
        Unkiu      = 21796,
        Whale      = 22526,
        Coelacanth = 23903
    }

    public enum Bridge
    {
        Shark      = 21793,
        Unkiu      = 21797,
        Whale      = 22527,
        Coelacanth = 23904
    }
}
