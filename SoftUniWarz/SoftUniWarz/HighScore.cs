﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace SoftUniWarz
{
    public class HighScore
    {
        private SortedDictionary<int,string> data;
        private string path = @"..\..\..\highscore.txt";
        public HighScore()
        {
            data = new SortedDictionary<int, string>();
        } 
        
        public SortedDictionary<int,string> Read()
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    int score = int.Parse(line.Split()[0]);
                    string name = line.Split()[1];
                    data.Add(score, name);
                }
            }
            return data;
        }

        public void Write()
        {
            using (StreamWriter writer = new StreamWriter("highscore.txt"))
            {
            }
        }

    }
}