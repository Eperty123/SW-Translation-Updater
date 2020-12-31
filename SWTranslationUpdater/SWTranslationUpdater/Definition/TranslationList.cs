using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SWTranslationUpdater.Definition
{
    public class TranslationList
    {
        #region Public Variables
        public Dictionary<long, Translation> Translations { get; set; }

        public string InputFile { get; set; }
        public string FileName { get; set; }

        public bool Loaded
        {
            get => Translations != null && Translations.Count > 0;
        }
        #endregion

        #region Constructors
        public TranslationList()
        {
            Initialize();
        }

        #endregion

        #region Private Methods
        protected void Initialize()
        {
            Translations = new Dictionary<long, Translation>();
        }
        #endregion

        #region Public Methods
        public void LoadFile(string file)
        {
            if (File.Exists(file))
            {
                Translations = Translation.ParseFile(file);
                FileName = Path.GetFileName(file);
                InputFile = file;
                Sort();
            }
        }

        public void SaveFile(string file)
        {
            Sort();
            File.WriteAllText(file, ToString());
        }

        public void Import(TranslationList importFrom, bool replaceExisting)
        {
            if (importFrom != null && importFrom.Translations.Count > 0)
            {
                foreach (var entry in importFrom.Translations)
                {
                    var id = entry.Key;
                    var translation = entry.Value;

                    if (!HasTranslation(id))
                        AddTranslation(translation);
                    else if (HasTranslation(id) && replaceExisting)
                        UpdateTranslation(translation);
                }
            }
        }

        public void Sort()
        {
            if (Translations != null && Translations.Count > 0)
                Translations = Translations.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var translation in Translations.Values)
                sb.Append(translation.ToString());
            return sb.ToString();
        }

        #region CRUD
        public void AddTranslation(Translation translation)
        {
            if (!HasTranslation(translation.Id))
            {
                Translations.Add(translation.Id, translation);
            }
        }

        public void AddTranslation(long id, Translation translation)
        {
            if (!HasTranslation(translation.Id))
            {
                Translations.Add(id, translation);
            }
        }

        public bool UpdateTranslation(Translation replacement)
        {
            return UpdateTranslation(replacement.Id, replacement);
        }

        public bool UpdateTranslation(long id, Translation replacement)
        {
            if (replacement != null && HasTranslation(id))
            {
                Translations[id] = replacement;
                return true;
            }
            return false;
        }

        public bool HasTranslation(Translation translation)
        {
            return HasTranslation(translation.Id);
        }

        public bool HasTranslation(long id)
        {
            return Translations.ContainsKey(id);
        }

        public Translation GetTranslation(Translation translation)
        {
            return GetTranslation(translation.Id);
        }

        public Translation GetTranslation(long id)
        {
            if (HasTranslation(id))
                return Translations[id];
            return null;
        }

        public bool RemoveTranslation(Translation translation)
        {
            return RemoveTranslation(translation.Id);
        }

        public bool RemoveTranslation(long id)
        {
            if (HasTranslation(id))
            {
                Translations.Remove(id);
                return true;
            }
            return false;
        }
        #endregion

        #endregion
    }
}
