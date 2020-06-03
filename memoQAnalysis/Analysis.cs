using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

namespace memoQAnalysis
{
    public class Analysis
    {
        public List<MemoQAnalysis> Data { get; }
        public Encoding OutputEncoding = Encoding.Unicode;

        private const string HeaderComma = ",,X-translated,,,,,,,,101%,,,,,,,,Repetitions,,,,,,,,100%,,,,,,,,95% - 99%,,,,,,,,85% - 94%,,,,,,,,75% - 84%,,,,,,,,50% - 74%,,,,,,,,No match,,,,,,,,Fragments,,,,,,,,Total,,,,,,,,";
        private const string HeaderSemicolon =
            ";;X-translated;;;;;;;;101%;;;;;;;;Repetitions;;;;;;;;100%;;;;;;;;95% - 99%;;;;;;;;85% - 94%;;;;;;;;75% - 84%;;;;;;;;50% - 74%;;;;;;;;No match;;;;;;;;Fragments;;;;;;;;Total;;;;;;;;";
        public string Delimiter;

        public string Header
        {
            get
            {
                if (Delimiter.Equals(",")) return HeaderComma;
                if (Delimiter.Equals(";")) return HeaderSemicolon;

                return HeaderComma.Replace(",", Delimiter);
            }
        }

        public Analysis(string path, string delimiter = ",")
        {
            Delimiter = delimiter;
            Data = ReadFromFile(path);
        }

        public Analysis(byte[] data, string delimiter = ";")
        {
            Delimiter = delimiter;
            Data = ReadData(data);
        }

        private List<MemoQAnalysis> ReadFromFile(string path)
        {
            using (var sr = new StreamReader(path))
            {
                return ReadData(sr);
            }
        }

        private List<MemoQAnalysis> ReadData(StreamReader streamReader)
        {
            var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = Delimiter
            };

            using (var csv = new CsvReader(streamReader, configuration))
            {
                var firstLine = streamReader.ReadLine();
                if (!string.IsNullOrWhiteSpace(firstLine) && firstLine.StartsWith("file", StringComparison.InvariantCultureIgnoreCase))
                {
                    streamReader.BaseStream.Position = 0;
                    streamReader.DiscardBufferedData();
                }

                var result = csv.GetRecords<MemoQAnalysis>().ToList();
                return result;
            }
        }

        private List<MemoQAnalysis> ReadData(byte[] data)
        {
            using (var ms = new MemoryStream(data))
            using (var sr = new StreamReader(ms))
            {
                return ReadData(sr);
            }
        }

        public int WordsToTranslateWithoutRepetitions()
        {
            var total = 0;
            foreach (var file in Data)
            {
                total += file.NinentyFiveNineWords;
                total += file.EightyFiveNinentyFourWords;
                total += file.SeventyFiveEightyFourWords;
                total += file.FiftySeventyFourWords;
                total += file.NoMatchWords;
            }

            return total;
        }

        public int WordsToTranslateWithRepetitions()
        {
            var total = WordsToTranslateWithoutRepetitions();
            foreach (var file in Data)
            {
                total += file.RepetitionsWords;
            }

            return total;
        }

        public void Save(string path)
        {
            var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = Delimiter
            };
            configuration.RegisterClassMap<MemoQAnalysisMapping>();

            using (var sw = new StreamWriter(path, false, OutputEncoding))
            using (var csv = new CsvWriter(sw, configuration))
            {
                sw.WriteLine(Header);
                csv.WriteRecords(Data);
            }
        }
    }
}
