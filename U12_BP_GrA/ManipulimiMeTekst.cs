using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace U12_BP_GrA
{
    class ManipulimiMeTekst
    {
        public int SaEshteNrShkronjave(string teksti)
        {
            int count = 0;
            for (int i = 0; i < teksti.Length; i++)
            {
                if (Char.IsLetter(teksti[i]))
                    count++;
            }
            return count;
        }

        public int SaEshteNrNumrave(string teksti)
        {
            int count = 0;
            for (int i = 0; i < teksti.Length; i++)
            {
                if (Char.IsDigit(teksti[i]))
                    count++;
            }
            return count;
        }

        public int SaEshteNrShkronjaUpper(string teksti)
        {
            int count = 0;
            for (int i = 0; i < teksti.Length; i++)
            {
                if (Char.IsUpper(teksti[i]))
                    count++;
            }
            return count;
        }

        // ref int[]
        public void SaEshteNrShkronjaLower(string teskt,
                            out int nrShkronja)
        {
            nrShkronja = 0;
            for (int i = 0; i < teskt.Length; i++)
            {
                if (Char.IsLower(teskt[i]))
                    nrShkronja++;
            }
        }

        public string CapitalizeFirstWord(string teksti)
        {
            string firstLetter = teksti[0].ToString();
            string otherPartOfText = teksti.Substring(1, teksti.Length-1);

            return firstLetter.ToUpper() + otherPartOfText.ToLower();
        }

        //bazat e programimit

        // zi
        public bool DoesWordExsist(string tekst, string word)
        {
            string pattern = @"" + word;
            Regex regex = new Regex(pattern);
            Match match = regex.Match(tekst);
            if(match.Success)
            {
                return true;
            }
            return false;
        }
    }
}
