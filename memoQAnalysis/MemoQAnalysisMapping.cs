using CsvHelper.Configuration;

namespace memoQAnalysis
{
    public sealed class MemoQAnalysisMapping : ClassMap<MemoQAnalysis>
    {
        public MemoQAnalysisMapping()
        {
            Map(m => m.File).Index(0);
            Map(m => m.CharWord).Index(1).Name("Char/Word");
            Map(m => m.XtranslatedSegments).Index(2).Name("Segments");
            Map(m => m.XtranslatedWords).Index(3).Name("Words");
            Map(m => m.XtranslatedCharacters).Index(4).Name("Characters");
            Map(m => m.XtranslatedAsianCharacters).Index(5).Name("Asian characters");
            Map(m => m.XtranslatedTags).Index(6).Name("Tags");
            Map(m => m.XtranslatedReserved1).Index(7).Name("Reserved1");
            Map(m => m.XtranslatedReserved2).Index(8).Name("Reserved2");
            Map(m => m.XtranslatedReserved3).Index(9).Name("Reserved3");
            Map(m => m.HundredOneSegments).Index(10).Name("Segments");
            Map(m => m.HundredOneWords).Index(11).Name("Words");
            Map(m => m.HundredOneCharacters).Index(12).Name("Characters");
            Map(m => m.HundredOneAsianCharacters).Index(13).Name("Asian characters");
            Map(m => m.HundredOneTags).Index(14).Name("Tags");
            Map(m => m.HundredOneReserved1).Index(15).Name("Reserved1");
            Map(m => m.HundredOneReserved2).Index(16).Name("Reserved2");
            Map(m => m.HundredOneReserved3).Index(17).Name("Reserved3");
            Map(m => m.RepetitionsSegments).Index(18).Name("Segments");
            Map(m => m.RepetitionsWords).Index(19).Name("Words");
            Map(m => m.RepetitionsCharacters).Index(20).Name("Characters");
            Map(m => m.RepetitionsAsianCharacters).Index(21).Name("Asian characters");
            Map(m => m.RepetitionsTags).Index(22).Name("Tags");
            Map(m => m.RepetitionsReserved1).Index(23).Name("Reserved1");
            Map(m => m.RepetitionsReserved2).Index(24).Name("Reserved2");
            Map(m => m.RepetitionsReserved3).Index(25).Name("Reserved3");
            Map(m => m.HundredSegments).Index(26).Name("Segments");
            Map(m => m.HundredWords).Index(27).Name("Words");
            Map(m => m.HundredCharacters).Index(28).Name("Characters");
            Map(m => m.HundredAsianCharacters).Index(29).Name("Asian characters");
            Map(m => m.HundredTags).Index(30).Name("Tags");
            Map(m => m.HundredReserved1).Index(31).Name("Reserved1");
            Map(m => m.HundredReserved2).Index(32).Name("Reserved2");
            Map(m => m.HundredReserved3).Index(33).Name("Reserved3");
            Map(m => m.NinentyFiveNineSegments).Index(34).Name("Segments");
            Map(m => m.NinentyFiveNineWords).Index(35).Name("Words");
            Map(m => m.NinentyFiveNineCharacters).Index(36).Name("Characters");
            Map(m => m.NinentyFiveNineAsianCharacters).Index(37).Name("Asian characters");
            Map(m => m.NinentyFiveNineTags).Index(38).Name("Tags");
            Map(m => m.NinentyFiveNineReserved1).Index(39).Name("Reserved1");
            Map(m => m.NinentyFiveNineReserved2).Index(40).Name("Reserved2");
            Map(m => m.NinentyFiveNineReserved3).Index(41).Name("Reserved3");
            Map(m => m.EightyFiveNinentyFourSegments).Index(42).Name("Segments");
            Map(m => m.EightyFiveNinentyFourWords).Index(43).Name("Words");
            Map(m => m.EightyFiveNinentyFourCharacters).Index(44).Name("Characters");
            Map(m => m.EightyFiveNinentyFourAsianCharacters).Index(45).Name("Asian characters");
            Map(m => m.EightyFiveNinentyFourTags).Index(46).Name("Tags");
            Map(m => m.EightyFiveNinentyFourReserved1).Index(47).Name("Reserved1");
            Map(m => m.EightyFiveNinentyFourReserved2).Index(48).Name("Reserved2");
            Map(m => m.EightyFiveNinentyFourReserved3).Index(49).Name("Reserved3");
            Map(m => m.SeventyFiveEightyFourSegments).Index(50).Name("Segments");
            Map(m => m.SeventyFiveEightyFourWords).Index(51).Name("Words");
            Map(m => m.SeventyFiveEightyFourCharacters).Index(52).Name("Characters");
            Map(m => m.SeventyFiveEightyFourAsianCharacters).Index(53).Name("Asian characters");
            Map(m => m.SeventyFiveEightyFourTags).Index(54).Name("Tags");
            Map(m => m.SeventyFiveEightyFourReserved1).Index(55).Name("Reserved1");
            Map(m => m.SeventyFiveEightyFourReserved2).Index(56).Name("Reserved2");
            Map(m => m.SeventyFiveEightyFourReserved3).Index(57).Name("Reserved3");
            Map(m => m.FiftySeventyFourSegments).Index(58).Name("Segments");
            Map(m => m.FiftySeventyFourWords).Index(59).Name("Words");
            Map(m => m.FiftySeventyFourCharacters).Index(60).Name("Characters");
            Map(m => m.FiftySeventyFourAsianCharacters).Index(61).Name("Asian characters");
            Map(m => m.FiftySeventyFourTags).Index(62).Name("Tags");
            Map(m => m.FiftySeventyFourReserved1).Index(63).Name("Reserved1");
            Map(m => m.FiftySeventyFourReserved2).Index(64).Name("Reserved2");
            Map(m => m.FiftySeventyFourReserved3).Index(65).Name("Reserved3");
            Map(m => m.NoMatchSegments).Index(66).Name("Segments");
            Map(m => m.NoMatchWords).Index(67).Name("Words");
            Map(m => m.NoMatchCharacters).Index(68).Name("Characters");
            Map(m => m.NoMatchAsianCharacters).Index(69).Name("Asian characters");
            Map(m => m.NoMatchTags).Index(70).Name("Tags");
            Map(m => m.NoMatchReserved1).Index(71).Name("Reserved1");
            Map(m => m.NoMatchReserved2).Index(72).Name("Reserved2");
            Map(m => m.NoMatchReserved3).Index(73).Name("Reserved3");
            Map(m => m.FragmentsSegments).Index(74).Name("Segments");
            Map(m => m.FragmentsWords).Index(75).Name("Words");
            Map(m => m.FragmentsCharacters).Index(76).Name("Characters");
            Map(m => m.FragmentsAsianCharacters).Index(77).Name("Asian characters");
            Map(m => m.FragmentsTags).Index(78).Name("Tags");
            Map(m => m.FragmentsReserved1).Index(79).Name("Reserved1");
            Map(m => m.FragmentsReserved2).Index(80).Name("Reserved2");
            Map(m => m.FragmentsReserved3).Index(81).Name("Reserved3");
            Map(m => m.TotalSegments).Index(82).Name("Segments");
            Map(m => m.TotalWords).Index(83).Name("Words");
            Map(m => m.TotalCharacters).Index(84).Name("Characters");
            Map(m => m.TotalAsianCharacters).Index(85).Name("Asian characters");
            Map(m => m.TotalTags).Index(86).Name("Tags");
            Map(m => m.TotalReserved1).Index(87).Name("Reserved1");
            Map(m => m.TotalReserved2).Index(88).Name("Reserved2");
            Map(m => m.TotalReserved3).Index(89).Name("Reserved3");
        }
    }
}
