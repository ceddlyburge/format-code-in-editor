/*...*/ namespace BeerSong {
public class BeerSongGenerator {
    public string Verses(int begin, int end) { /*...*/ return string.Join("\n", VersesList(begin, end)); }

    IEnumerable<string> VersesList(int begin, int end) {
        for (int verse = begin; verse >= end; verse--)
            yield return Verse(verse); }

    string Verse(int verse) => new VerseGenerator(verse).Verse; }

public class VerseGenerator {
    readonly int verse;

    public VerseGenerator(int verse) { /*...*/ this.verse = verse; }

    public string Verse => (verse == 0) ? VerseZero : VerseOneOrLater;

    string VerseZero =>
        $"No more bottles of beer on the wall, no more bottles of beer.\n" +
        $"Go to the store and buy some more, 99 bottles of beer on the wall.\n";

    string VerseOneOrLater =>
        $"{NumberOfBottles} of beer on the wall, {NumberOfBottles} of beer.\n" +
        $"Take {oneOrIt} down and pass it around, {OneLessBottle} of beer on the wall.\n";

    string NumberOfBottles => HowManyBottles(verse);

    string HowManyBottles(int bottles) {
        if (bottles == 0) return "no more bottles";
        else if (bottles == 1) return "1 bottle";
        else return $"{bottles} bottles"; }

    string oneOrIt { get { /*...*/ return (verse == 1) ? "it" : "one"; } }

    string OneLessBottle { get { /*...*/ return HowManyBottles(verse - 1); } } } }
