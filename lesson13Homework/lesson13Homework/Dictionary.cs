using System;
using System.Collections.Generic;
using System.Text;

namespace lesson13Homework
{
    class Dictionary
    {
        private string[] key = new string[10];
        private string[] value = new string[10];

        public Dictionary()
        {
            key[0] = "телефон"; value[0] = "phone";
            key[1] = "басейн"; value[1] = "pool";
            key[2] = "зошит"; value[2] = "copybook";
            key[3] = "дощ"; value[3] = "rain";
            key[4] = "вікно"; value[4] = "window";
            key[5] = "телефон"; value[0] = "phone";
            key[6] = "басcейн"; value[1] = "pool";
            key[7] = "тетрадь"; value[2] = "copybook";
            key[8] = "дощ"; value[3] = "rain";
            key[9] = "окно"; value[4] = "window";
        }
        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i] == index)
                    {
                        return key[i] + "-" + value[i];
                    }
                }
                return string.Format("{0} - нема перекладу для цього слова.", index);
                
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                {
                    return key[index] + "-" + value[index];
                }
                else
                {
                    return "Спроба звернення за Межі масиву.";
                }
            }
        }
    }
}
