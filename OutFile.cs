using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using Newtonsoft.Json;

namespace TestProject
{
    class OutFile
    {
        [JsonIgnore]
        public string FileName;
        public int count;
        public Dictionary<int, string> top;
        [JsonIgnore]
        public List<Word> Words;
        public OutFile()
        {
            count = 0;
            Words = new List<Word>();
        }

        public void ParseText(string text)
        {
            Regex regex = new Regex(@"[а-яА-Яa-zA-Z]+");

            foreach (Match match in regex.Matches(text.ToLower()))
            {
                count++;
                int index = SearchWord(match.Value);
                if (index == -1)
                {
                    Word Temp_Word = new Word();
                    Temp_Word.count = 1;
                    Temp_Word.word = match.Value;
                    Words.Add(Temp_Word);
                }
                else
                {
                    Words[index].count++;
                }
            }
        }
        private int SearchWord(string word)
        {
            for (int i = 0; i < Words.Count; i++)
            {
                if (Words[i].word == word)
                    return i;
            }

            return -1;
        }

        //не совсем json будет возвращаться, но такое условие задачи
        public string GetJson(int Top)
        {
            top = new Dictionary<int, string>();
            Words = Words.OrderByDescending(val => val.count).ToList();

            for (int i = 0; i < Top && i < Words.Count; i++)
            {
                top.Add((i + 1), Words[i].word);
            }

            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
