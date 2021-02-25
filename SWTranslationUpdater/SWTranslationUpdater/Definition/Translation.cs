using SWTranslationUpdater.Definition.Enum;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace SWTranslationUpdater.Definition
{
    public class Translation
    {
        #region Private Variables

        #endregion

        #region Public Variables
        public long Id { get; set; }
        public string Text { get; set; }
        public CountryCode CountryCode { get; set; }

        public static string RegexPattern = @"ID=([0-9]+)([^\)]+.)";
        #endregion

        #region Constructors
        public Translation()
        {

        }

        public Translation(long id, string text, CountryCode countryCode)
        {
            Id = id;
            Text = text;
            CountryCode = countryCode;
        }

        public Translation(CountryCode countryCode)
        {
            CountryCode = countryCode;
        }
        #endregion

        #region Public Methods

        public override string ToString()
        {
            bool endsWithNewLine = Text.EndsWith("\n");
            if (!endsWithNewLine) Text += "\n";
            return $"ID={Id}{Text}\n";
        }

        #region Static Methods
        public static Translation Parse(Match match)
        {
            if (match.Success)
            {
                var translation = new Translation()
                {
                    Id = long.Parse(match.Groups[1].Value),
                    Text = match.Groups[2].Value
                };
                return translation;
            }
            return null;
        }

        public static Dictionary<long, Translation> ParseFile(string file)
        {
            using (var fs = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var sr = new StreamReader(fs))
            {
                return ParseAll(sr.ReadToEnd());
            }
        }

        public static Dictionary<long, Translation> ParseAll(string text)
        {
            Dictionary<long, Translation> translations = new Dictionary<long, Translation>();
            var matches = Regex.Matches(text, RegexPattern, RegexOptions.Multiline);
            if (matches.Count > 0)
            {
                for (int i = 0; i < matches.Count; i++)
                {
                    var match = matches[i];
                    var translation = Parse(match);
                    if (translation != null && !translations.ContainsKey(translation.Id))
                        translations.Add(translation.Id, translation);
                }
            }

            return translations;
        }
        #endregion

        #endregion
    }
}
