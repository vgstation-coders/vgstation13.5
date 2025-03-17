using JetBrains.Annotations;
using Robust.Shared.Random;

namespace Content.Server.Maps.NameGenerators;

// stop calling us VG or Vg stop it!!
[UsedImplicitly]
public sealed partial class vgNameGenerator : StationNameGenerator
{
    [DataField("prefixCreator")] public string PrefixCreator = default!;

    // omitting holiday names for now. should be trivial enough to add :^)

    private string[] RarePrefixes =>
        new[]
        {
            "Imperium", "Heretical", "Cuban", "Psychic", "Elegant", "Common", "Uncommon", "Rare", "Unique",
            "Houseruled", "Religious", "Atheist", "Traditional", "Houseruled", "Mad", "Super", "Ultra", "Secret",
            "Top Secret", "Deep", "Death", "Zybourne", "Central", "Main", "Government", "Uoi", "Fat", "Automated",
            "Experimental", "Augmented"
        };

    private string[] Prefixes =>
        new[]
        {
            "", "Stanford", "Dorf", "Alium", "Prefix", "Clowning", "Aegis", "Ishimura", "Scaredy", "Death-World",
            "Mime", "Honk", "Rogue", "MacRagge", "Ultrameens", "Safety", "Paranoia", "Explosive", "Neckbear", "Donk",
            "Muppet", "North", "West", "East", "South", "Slant-ways", "Widdershins", "Rimward", "Expensive",
            "Procreatory", "Imperial", "Unidentified", "Immoral", "Carp", "Ork", "Pete", "Control", "Nettle", "Aspie",
            "Class", "Crab", "Fist", "Corrugated", "Skeleton", "Race", "Fatguy", "Gentleman", "Capitalist", "Communist",
            "Bear", "Beard", "Derp", "Space", "Spess", "Star", "Moon", "System", "Mining", "Neckbeard", "Research",
            "Supply", "Military", "Orbital", "Battle", "Science", "Asteroid", "Home", "Production", "Transport",
            "Delivery", "Extraplanetary", "Orbital", "Correctional", "Robot", "Hats", "Pizza"
        };

    private string[] Suffixes =>
        new[]
        {
            "Station", "Fortress", "Frontier", "Suffix", "Death-trap", "Space-hulk", "Lab", "Hazard", "Spess Junk",
            "Fishery", "No-Moon", "Tomb", "Crypt", "Hut", "Monkey", "Bomb", "Trade Post", "Fortress", "Village", "Town",
            "City", "Edition", "Hive", "Complex", "Base", "Facility", "Depot", "Outpost", "Installation", "Drydock",
            "Observatory", "Array", "Relay", "Monitor", "Platform", "Construct", "Hangar", "Prison", "Center", "Port",
            "Waystation", "Factory", "Waypoint", "Stopover", "Hub", "HQ", "Office", "Object", "Fortification", "Colony",
            "Planet-Cracker", "Roost", "Fat Camp"
        };

    private string[] Greeks =>
        new[]
        {
            "Alpha", "Beta", "Gamma", "Delta", "Epsilon", "Zeta", "Eta", "Theta", "Iota", "Kappa", "Lambda", "Mu", "Nu",
            "Xi", "Omicron", "Pi", "Rho", "Sigma", "Tau", "Upsilon", "Phi", "Chi", "Psi", "Omega"
        };

    private string[] Numerals =>
        new[]
        {
            "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X", "XI", "XII", "XIII", "XIV", "XV", "XVI", "XVII",
            "XVIII", "XIX", "XX"
        };

    private string[] Phonetics =>
        new[]
        {
            "Alpha", "Bravo", "Charlie", "Delta", "Echo", "Foxtrot", "Golf", "Hotel", "India", "Juliet", "Kilo", "Lima",
            "Mike", "November", "Oscar", "Papa", "Quebec", "Romeo", "Sierra", "Tango", "Uniform", "Victor", "Whiskey",
            "X-ray", "Yankee", "Zulu"
        };

    private string[] Cardinals =>
        new[]
        {
            "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve",
            "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"
        };

    public override string FormatName(string input)
    {
        var random = IoCManager.Resolve<IRobustRandom>();

        var prefix = random.Pick(random.Prob(0.1f) ? RarePrefixes : Prefixes);

        var suffix = random.Pick(Suffixes);

        var number = random.Next(1, 5) switch
        {
            1 => random.Next(1, 99).ToString(),
            2 => random.Pick(Greeks),
            3 => random.Pick(Numerals),
            4 => random.Pick(Phonetics),
            5 => random.Pick(Cardinals),
            _ => "YOU_SHOULD_NOT_SEE_THIS"
        };

        return $"{prefix} {suffix} {number}";
    }
}
