using System.IO;
using System.Linq;
using memoQAnalysis;
using Xunit;

namespace memoQAnalysisTests
{
    public class AnalysisTests
    {
        private const string MainTestFile = "./testFiles/utf8.csv";
        private const string UTF16TestFile = "./testFiles/utf16.csv";
        private const string UTF16NoHeaderTestFile = "./testFiles/utf16NoHeader.csv";

        [Fact]
        public void ReadAnalysisUTF8Comma()
        {
            var test = new Analysis(MainTestFile);
            Assert.Equal(3, test.Data.Count);
        }

        [Fact]
        public void ReadAnalysisUTF16Semicolon()
        {
            var test = new Analysis(UTF16TestFile, ";");
            Assert.Equal(3, test.Data.Count);
        }

        [Fact]
        public void ReadAnalysisUTF16SemicolonNoHeader()
        {
            var test = new Analysis(UTF16NoHeaderTestFile, ";");
            Assert.Equal(3, test.Data.Count);
        }

        [Fact]
        public void WordsToTranslateWithoutRepetitions()
        {
            var test = new Analysis(MainTestFile);
            Assert.Equal(0, test.WordsToTranslateWithoutRepetitions());
        }

        [Fact]
        public void WordsToTranslateWithRepetitions()
        {
            var test = new Analysis(MainTestFile);
            Assert.Equal(601, test.WordsToTranslateWithRepetitions());
        }
        
        [Fact]
        public void ReadAnalysisFromBytes()
        {
            var data = File.ReadAllBytes(UTF16TestFile);
            var test = new Analysis(data);
            Assert.Equal(3, test.Data.Count);
        }

        [Fact]
        public void TotalWords()
        {
            var test = new Analysis(MainTestFile);
            var total = test.Data.Sum(x => x.TotalWords);

            var originalFirstFile = test.Data.FirstOrDefault();
            Assert.NotNull(originalFirstFile);
            originalFirstFile.NinentyFiveNineWords = 1050;

            var expectedTotal = total + 1050;
            var newTotal = test.Data.Sum(x => x.TotalWords);
            Assert.Equal(expectedTotal, newTotal);
        }

        [Fact]
        public void TotalSegments()
        {
            var test = new Analysis(MainTestFile);
            var total = test.Data.Sum(x => x.TotalSegments);

            var originalFirstFile = test.Data.FirstOrDefault();
            Assert.NotNull(originalFirstFile);
            originalFirstFile.FiftySeventyFourSegments += 1050;

            var expectedTotal = total + 1050;
            var newTotal = test.Data.Sum(x => x.TotalSegments);
            Assert.Equal(expectedTotal, newTotal);
        }

        [Fact]
        public void TotalCharacters()
        {
            var test = new Analysis(MainTestFile);
            var total = test.Data.Sum(x => x.TotalCharacters);

            var originalFirstFile = test.Data.FirstOrDefault();
            Assert.NotNull(originalFirstFile);
            originalFirstFile.RepetitionsCharacters += 1050;

            var expectedTotal = total + 1050;
            var newTotal = test.Data.Sum(x => x.TotalCharacters);
            Assert.Equal(expectedTotal, newTotal);
        }

        [Fact]
        public void TotalAsianCharacters()
        {
            var test = new Analysis(MainTestFile);
            var total = test.Data.Sum(x => x.TotalAsianCharacters);

            var originalFirstFile = test.Data.FirstOrDefault();
            Assert.NotNull(originalFirstFile);
            originalFirstFile.HundredAsianCharacters += 1050;

            var expectedTotal = total + 1050;
            var newTotal = test.Data.Sum(x => x.TotalAsianCharacters);
            Assert.Equal(expectedTotal, newTotal);
        }

        [Fact]
        public void TotalTags()
        {
            var test = new Analysis(MainTestFile);
            var total = test.Data.Sum(x => x.TotalTags);

            var originalFirstFile = test.Data.FirstOrDefault();
            Assert.NotNull(originalFirstFile);
            originalFirstFile.HundredOneTags += 1050;

            var expectedTotal = total + 1050;
            var newTotal = test.Data.Sum(x => x.TotalTags);
            Assert.Equal(expectedTotal, newTotal);
        }

        [Fact]
        public void TotalReserved1()
        {
            var test = new Analysis(MainTestFile);
            var total = test.Data.Sum(x => x.TotalReserved1);

            var originalFirstFile = test.Data.FirstOrDefault();
            Assert.NotNull(originalFirstFile);
            originalFirstFile.NoMatchReserved1 += 1050;

            var expectedTotal = total + 1050;
            var newTotal = test.Data.Sum(x => x.TotalReserved1);
            Assert.Equal(expectedTotal, newTotal);
        }

        [Fact]
        public void ReadModifySaveCheck()
        {
            var test = new Analysis(MainTestFile);
            var originalFirstFile = test.Data.FirstOrDefault();
            Assert.NotNull(originalFirstFile);
            originalFirstFile.NinentyFiveNineWords = 1050;

            var path = "testSave.csv";
            test.Save(path);

            var readTest = new Analysis(path);
            var readFirstFile = readTest.Data.FirstOrDefault();
            Assert.NotNull(readFirstFile);
            Assert.Equal(originalFirstFile.NinentyFiveNineWords, readFirstFile.NinentyFiveNineWords);

            File.Delete(path);
        }
    }
}
