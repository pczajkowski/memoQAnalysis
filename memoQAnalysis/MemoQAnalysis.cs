using CsvHelper.Configuration.Attributes;

namespace memoQAnalysis
{
    public class MemoQAnalysis
    {
        [Index(0)]
        public string File { get; set; }

        [Index(1)]
        public double CharWord { get; set; }

        [Index(2)]
        public int XtranslatedSegments { get; set; }

        [Index(3)]
        public int XtranslatedWords { get; set; }

        [Index(4)]
        public int XtranslatedCharacters { get; set; }

        [Index(5)]
        public int XtranslatedAsianCharacters { get; set; }

        [Index(6)]
        public int XtranslatedTags { get; set; }

        [Index(7)]
        public int XtranslatedReserved1 { get; set; }

        [Index(8)]
        public int XtranslatedReserved2 { get; set; }

        [Index(9)]
        public int XtranslatedReserved3 { get; set; }

        [Index(10)]
        public int HundredOneSegments { get; set; }

        [Index(11)]
        public int HundredOneWords { get; set; }

        [Index(12)]
        public int HundredOneCharacters { get; set; }

        [Index(13)]
        public int HundredOneAsianCharacters { get; set; }

        [Index(14)]
        public int HundredOneTags { get; set; }

        [Index(15)]
        public int HundredOneReserved1 { get; set; }

        [Index(16)]
        public int HundredOneReserved2 { get; set; }

        [Index(17)]
        public int HundredOneReserved3 { get; set; }

        [Index(18)]
        public int RepetitionsSegments { get; set; }

        [Index(19)]
        public int RepetitionsWords { get; set; }

        [Index(20)]
        public int RepetitionsCharacters { get; set; }

        [Index(21)]
        public int RepetitionsAsianCharacters { get; set; }

        [Index(22)]
        public int RepetitionsTags { get; set; }

        [Index(23)]
        public int RepetitionsReserved1 { get; set; }

        [Index(24)]
        public int RepetitionsReserved2 { get; set; }

        [Index(25)]
        public int RepetitionsReserved3 { get; set; }

        [Index(26)]
        public int HundredSegments { get; set; }

        [Index(27)]
        public int HundredWords { get; set; }

        [Index(28)]
        public int HundredCharacters { get; set; }

        [Index(29)]
        public int HundredAsianCharacters { get; set; }

        [Index(30)]
        public int HundredTags { get; set; }

        [Index(31)]
        public int HundredReserved1 { get; set; }

        [Index(32)]
        public int HundredReserved2 { get; set; }

        [Index(33)]
        public int HundredReserved3 { get; set; }

        [Index(34)]
        public int NinentyFiveNineSegments { get; set; }

        [Index(35)]
        public int NinentyFiveNineWords { get; set; }

        [Index(36)]
        public int NinentyFiveNineCharacters { get; set; }

        [Index(37)]
        public int NinentyFiveNineAsianCharacters { get; set; }

        [Index(38)]
        public int NinentyFiveNineTags { get; set; }

        [Index(39)]
        public int NinentyFiveNineReserved1 { get; set; }

        [Index(40)]
        public int NinentyFiveNineReserved2 { get; set; }

        [Index(41)]
        public int NinentyFiveNineReserved3 { get; set; }

        [Index(42)]
        public int EightyFiveNinentyFourSegments { get; set; }

        [Index(43)]
        public int EightyFiveNinentyFourWords { get; set; }

        [Index(44)]
        public int EightyFiveNinentyFourCharacters { get; set; }

        [Index(45)]
        public int EightyFiveNinentyFourAsianCharacters { get; set; }

        [Index(46)]
        public int EightyFiveNinentyFourTags { get; set; }

        [Index(47)]
        public int EightyFiveNinentyFourReserved1 { get; set; }

        [Index(48)]
        public int EightyFiveNinentyFourReserved2 { get; set; }

        [Index(49)]
        public int EightyFiveNinentyFourReserved3 { get; set; }

        [Index(50)]
        public int SeventyFiveEightyFourSegments { get; set; }

        [Index(51)]
        public int SeventyFiveEightyFourWords { get; set; }

        [Index(52)]
        public int SeventyFiveEightyFourCharacters { get; set; }

        [Index(53)]
        public int SeventyFiveEightyFourAsianCharacters { get; set; }

        [Index(54)]
        public int SeventyFiveEightyFourTags { get; set; }

        [Index(55)]
        public int SeventyFiveEightyFourReserved1 { get; set; }

        [Index(56)]
        public int SeventyFiveEightyFourReserved2 { get; set; }

        [Index(57)]
        public int SeventyFiveEightyFourReserved3 { get; set; }

        [Index(58)]
        public int FiftySeventyFourSegments { get; set; }

        [Index(59)]
        public int FiftySeventyFourWords { get; set; }

        [Index(60)]
        public int FiftySeventyFourCharacters { get; set; }

        [Index(61)]
        public int FiftySeventyFourAsianCharacters { get; set; }

        [Index(62)]
        public int FiftySeventyFourTags { get; set; }

        [Index(63)]
        public int FiftySeventyFourReserved1 { get; set; }

        [Index(64)]
        public int FiftySeventyFourReserved2 { get; set; }

        [Index(65)]
        public int FiftySeventyFourReserved3 { get; set; }

        [Index(66)]
        public int NoMatchSegments { get; set; }

        [Index(67)]
        public int NoMatchWords { get; set; }

        [Index(68)]
        public int NoMatchCharacters { get; set; }

        [Index(69)]
        public int NoMatchAsianCharacters { get; set; }

        [Index(70)]
        public int NoMatchTags { get; set; }

        [Index(71)]
        public int NoMatchReserved1 { get; set; }

        [Index(72)]
        public int NoMatchReserved2 { get; set; }

        [Index(73)]
        public int NoMatchReserved3 { get; set; }

        [Index(74)]
        public int FragmentsSegments { get; set; }

        [Index(75)]
        public int FragmentsWords { get; set; }

        [Index(76)]
        public int FragmentsCharacters { get; set; }

        [Index(77)]
        public int FragmentsAsianCharacters { get; set; }

        [Index(78)]
        public int FragmentsTags { get; set; }

        [Index(79)]
        public int FragmentsReserved1 { get; set; }

        [Index(80)]
        public int FragmentsReserved2 { get; set; }

        [Index(81)]
        public int FragmentsReserved3 { get; set; }

        [Index(82)]
        public int TotalSegments { get; set; }

        [Index(83)]
        public int TotalWords {
            get
            {
                var total = XtranslatedWords + HundredOneWords + RepetitionsWords + HundredWords +
                            NinentyFiveNineWords + EightyFiveNinentyFourWords + SeventyFiveEightyFourWords +
                            FiftySeventyFourWords + NoMatchWords + FragmentsWords;
                return total;
            }
        }

        [Index(84)]
        public int TotalCharacters { get; set; }

        [Index(85)]
        public int TotalAsianCharacters { get; set; }

        [Index(86)]
        public int TotalTags { get; set; }

        [Index(87)]
        public int TotalReserved1 { get; set; }

        [Index(88)]
        public int TotalReserved2 { get; set; }

        [Index(89)]
        public int TotalReserved3 { get; set; }
    }
}
