namespace FindWordsInLargeFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    using Typocalypse.Trie;

    public class Startup
    {
        public const string FilePath = "../../sample_file.txt";

        public static void Main()
        {
            List<string> wordsToSearchInFile = new List<string>() { "one", "two", "three", "four", "five" };

            Trie<string> trie = new Trie<string>();
            BuildTrie(FilePath, trie);

            var result = Find(wordsToSearchInFile, trie);

            foreach (var kvp in result)
            {
                Console.WriteLine("{0} -> {1}", kvp.Key, kvp.Value);
            }
        }

        public static void BuildTrie(string filePath, Trie<string> trie)
        {
            using (FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (BufferedStream bs = new BufferedStream(fs))
            using (StreamReader sr = new StreamReader(bs))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var words = GetWordsFromLine(line);
                    foreach (var word in words)
                    {
                        // Get the next character and search the word through the trie
                        foreach (char ch in word)
                        {
                            trie.Matcher.NextMatch(ch);
                        }

                        // In case the exact same word is found, store its value, remove the word and re-add it incremented
                        if (trie.Matcher.IsExactMatch())
                        {
                            int value = int.Parse(trie.Matcher.GetExactMatch());
                            trie.Remove(word);
                            trie.Put(word, (value + 1).ToString());
                        }
                        else
                        {
                            trie.Put(word, "1");
                        }

                        trie.Matcher.ResetMatch();
                    }
                }
            }
        }

        private static IEnumerable<string> GetWordsFromLine(string line)
        {
            var word = new StringBuilder();
            foreach (char ch in line)
            {
                if (char.IsLetter(ch))
                {
                    word.Append(ch);
                }
                else
                {
                    if (word.Length == 0)
                    {
                        continue;
                    }

                    yield return word.ToString().ToLower();
                    word.Clear();
                }
            }
        }

        public static Dictionary<string, int> Find(ICollection<string> words, Trie<string> trie)
        {
            var result = new Dictionary<string, int>();

            foreach (var word in words)
            {
                foreach (char ch in word) 
                {
                    trie.Matcher.NextMatch(ch);
                }

                if (trie.Matcher.IsExactMatch())
                {
                    result.Add(word, int.Parse(trie.Matcher.GetExactMatch()));
                }
                else
                {
                    result.Add(word, 0);
                }

                trie.Matcher.ResetMatch();
            }

            return result;
        }
    }
}
