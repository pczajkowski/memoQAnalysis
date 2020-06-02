using System.IO;
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
        public void SaveFile()
        {
            var test = new Analysis(MainTestFile);
            Assert.Equal(3, test.Data.Count);

            var path = "testSave.csv";
            test.Save(path);
            File.Delete(path);
        }
    }
}
