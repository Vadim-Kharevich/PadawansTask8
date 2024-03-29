﻿using System.Text;
using System;

namespace PadawansTask8
{
    public static class WordsManipulation
    {
        public static void RemoveDuplicateWords(ref string text)
        {
            if (text == "")
            {
                throw new ArgumentException();
            }
            if(text == null)
            {
                throw new ArgumentNullException();
            }
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '.' || text[i] == ',' || text[i] == '!' || text[i] == '?' || text[i] == '-' || text[i] == ':' || text[i] == ';' || text[i] == ' ')
                {
                    count++;
                }
            }
            string[] mas = new string[count + 1];
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '.' || text[i] == ',' || text[i] == '!' || text[i] == '?' || text[i] == '-' || text[i] == ':' || text[i] == ';' || text[i] == ' ')
                {
                    for (int j = 0; j < i; j++)
                        mas[0] += text[j];
                    break;
                }
            }
            int length = text.Length;
            for (int i = 0; i < length - 1; i++)
            {
                count = 0;
                string str = "";
                if (text[i] == '.' || text[i] == ',' || text[i] == '!' || text[i] == '?' || text[i] == '-' || text[i] == ':' || text[i] == ';' || text[i] == ' ')
                {
                    int k = i + 1;
                    int startindex = i + 1;
                    bool number = false;
                    while (text[k] != '.' && text[k] != ',' && text[k] != '!' && text[k] != '?' && text[k] != '-' && text[k] != ':' && text[k] != ';' && text[k] != ' ')
                    {
                        if (char.IsDigit(text[k]))
                            number = true;
                        str += text[k];
                        count++;
                        k++;
                        if (k == length - 1)
                        {
                            if (char.IsDigit(text[k]))
                                number = true;
                            str += text[k];
                            count++;
                            break;
                        }
                    }
                    bool flag = false;
                    if (number == false)
                    {
                        for (int j = 0; j < mas.Length; j++)
                        {
                            if (str == mas[j])
                            {
                                text = text.Remove(startindex, count);
                                length -= count;
                                flag = true;
                            }
                        }
                    }
                    if (flag == false)
                    {
                        for (int j = 0; j < mas.Length; j++)
                        {
                            if (mas[j] == null)
                            {
                                mas[j] = str;
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}