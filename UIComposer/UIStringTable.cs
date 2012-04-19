// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using System.Text;
using Sce.Pss.Core.Environment;

namespace PssUI1
{
    public static class UIStringTable
    {
        static string[] currentTable;
        static UILanguage currentLanguageId;
        static UILanguage defaultLanguageId;
        static string[][] textTable;

        public static string Get(UIStringID id)
        {
            return currentTable[(int)id];
        }

        public static UILanguage UILanguage
        {
            get { return currentLanguageId; }
            set
            {
                currentLanguageId = value;
                currentTable = textTable[(int)currentLanguageId];
            }
        }
        static UIStringTable()
        {
            textTable = new string[][]
            {
                new string[]
                {
                    "",
                }
            };
            defaultLanguageId = UILanguage.English;
            currentLanguageId = defaultLanguageId;
            currentTable = textTable[(int)currentLanguageId];
        }
    }

    public enum UIStringID : int
    {
        RESID1 = 0,
    }

    public enum UILanguage : int
    {
        English = 0,
    }

}

