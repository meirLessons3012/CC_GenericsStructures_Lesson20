using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CC_GenericsStructures_Lesson20
{
    internal class Book
    {
        public Category Category { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        public Book()
        {
            Category = (Category)CreateRandomInteger(0, 3);
            Title = CreateRandomString(7);
            Author = CreateRandomString(4) + " " + CreateRandomString(4);
            Pages = CreateRandomInteger(20, 400);
        }


        public static string CreateRandomString(int length)
        {
            Random r = new Random();
            System.Text.StringBuilder str_build = new System.Text.StringBuilder();

            char letter;

            for (int i = 0; i < length; i++)
            {
                double flt = r.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            return str_build.ToString();
        }


        public static int CreateRandomInteger(int from, int to)
        {
            Random r = new Random();
            return r.Next(from, to);
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }

    public enum Category
    {
        Drama,
        Action,
        Adventure,
    }
}
