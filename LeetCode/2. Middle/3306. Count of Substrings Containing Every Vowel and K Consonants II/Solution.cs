namespace LeetCode._2._Middle._3306._Count_of_Substrings_Containing_Every_Vowel_and_K_Consonants_II;

public class Solution
{
    public long CountOfSubstrings(string word, int k)
    {
        var ruleManager = new RuleManager(word, k);
        var result = 0L;
        var wideVowelLenght = 1;

        while (ruleManager.AddLetter())
        {
            while (ruleManager.Consonant > k)
            {
                wideVowelLenght = 1;
                ruleManager.RemoveLetter();
            }

            if (ruleManager.IsFitString())
            {
                while (ruleManager.CanRemoveLetterToStillFit())
                {
                    wideVowelLenght++;
                    ruleManager.RemoveLetter();
                }

                result += wideVowelLenght;
            }
        }

        return result;
    }

    private bool IsVowel(char letter)
    {
        return letter is 'a' or 'e' or 'i' or 'o' or 'u';
    }

    private class RuleManager
    {
        public readonly string Word;
        private int k;

        public int Consonant { get; private set; }
        public int LeftIndex { get; private set; }
        public int RightIndex { get; private set; }

        private int vowelA = 0;
        private int vowelE = 0;
        private int vowelI = 0;
        private int vowelO = 0;
        private int vowelU = 0;

        public RuleManager(string word, int k)
        {
            Word = word;
            this.k = k;
        }

        public bool IsFitString()
        {
            return IsEveryVowels() && Consonant == k;
        }

        public bool IsEveryVowels()
        {
            return vowelA > 0 && vowelE > 0 && vowelI > 0 && vowelO > 0 && vowelU > 0;
        }

        public bool AddLetter()
        {
            if (RightIndex == Word.Length)
                return false;

            var letter = Word[RightIndex++];
            if (letter == 'a')
                vowelA++;
            else if (letter == 'e')
                vowelE++;
            else if (letter == 'i')
                vowelI++;
            else if (letter == 'o')
                vowelO++;
            else if (letter == 'u')
                vowelU++;
            else
                Consonant++;
            return true;
        }

        public bool CanRemoveLetterToStillFit()
        {
            return Word[LeftIndex] switch
            {
                'a' => vowelA > 1,
                'e' => vowelE > 1,
                'i' => vowelI > 1,
                'o' => vowelO > 1,
                'u' => vowelU > 1,
                _ => false,
            };
        }

        public void RemoveLetter()
        {
            var letter = Word[LeftIndex++];
            if (letter == 'a')
                vowelA--;
            else if (letter == 'e')
                vowelE--;
            else if (letter == 'i')
                vowelI--;
            else if (letter == 'o')
                vowelO--;
            else if (letter == 'u')
                vowelU--;
            else
                Consonant--;
        }
    }
}