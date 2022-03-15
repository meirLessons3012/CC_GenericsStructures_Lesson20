using System;
using System.Collections;
using System.Collections.Generic;

namespace CC_GenericsStructures_Lesson20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List

            List<string> myStrList = new List<string>();
            myStrList.Add("hello");
            myStrList.Clear();
            List<string> myStrList2 = new List<string> { "hello","hackeru", "all", "!!!!" };
            myStrList.AddRange(myStrList2);

            List<Book> secondList = new List<Book>();
            secondList.Add(new Book());

            MyList<string> myList = new MyList<string>();
            myList.Add("hello");
            MyList<Book> myList2 = new MyList<Book>();
            myList2.Add(new Book());

            #endregion

            #region Dictionary

            //Hashtable hashtable = new Hashtable();
            //hashtable.Add(new object(), new object());
            Dictionary<int, string> mapIdToNameWithDict = new Dictionary<int, string>();
            mapIdToNameWithDict.Add(1, "Yossi");
            mapIdToNameWithDict.TryAdd(2, "Ran");
            Dictionary<long, Person> mapIdToPersonWithDict = new Dictionary<long, Person>();
            mapIdToPersonWithDict.TryAdd(2984719237, new Person());

            MyDictionary<int, string> mapIdToNameWithMyDict = new MyDictionary<int, string>();
            mapIdToNameWithMyDict.Add(1, "yossi");
            mapIdToNameWithMyDict.TryAdd(1, "yossi");
            MyDictionary<long, Person> mapIdToPersonWithMyDict = new MyDictionary<long, Person>();
            mapIdToPersonWithMyDict.TryAdd(2984719237, new Person());

            Book bb1 = new Book 
            { 
                Author = "Jhon",
                Title = "C# Guide",
                Pages = 537 
            };
            Dictionary<int, Book> mapIdToBook = new Dictionary<int, Book>();
            mapIdToBook.Add(100, bb1);
            mapIdToBook.Add(1, new Book { Author = "Mark", Title = "Java Guide", Pages = 344 });
            mapIdToBook.Add(22, new Book { Author = "Marcel", Title = "JavaScript Guide", Pages = 632 });
            mapIdToBook.Add(15, new Book { Author = "Meir", Title = "Stam Guide", Pages = 321 });

            //dictionary indexer return value by KEY (AND NOT BY INDEX!!!!)
            Book b2 = mapIdToBook[1];
            mapIdToBook[22] = new Book();//set exist value
            mapIdToBook[15].Pages++;
            Book b = new Book { Author = "Marcel", Title = "JavaScript Guide", Pages = 632 };
            mapIdToBook[222] = new Book { Author = "Marcel", Title = "JavaScript Guide", Pages = 632 }; //try set unfound value
            //Book notExistsBook = mapIdToBook[999];//ERROR

            if (mapIdToBook.ContainsKey(15)) 
            {
                Console.WriteLine("key exists");
            }

            if (mapIdToBook.ContainsValue(b))
            {
                Console.WriteLine("value exists");
            }

            Book bOut;
            if(mapIdToBook.TryGetValue(222, out bOut))
            {
                bOut.Pages *= 2;
            }



            #endregion

            #region foreach with dictionary

            Console.WriteLine();
            Console.WriteLine("loop on keys:");
            foreach (int bookId in mapIdToBook.Keys)
            {
                Console.WriteLine(bookId);
            }

            Console.WriteLine();
            Console.WriteLine("loop in values: ");
            foreach (Book book in mapIdToBook.Values)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("loop in Keys And values: ");
            foreach (KeyValuePair<int,Book> curKeyValue in mapIdToBook)
            {
                Console.WriteLine(curKeyValue.Key + ": \n" + curKeyValue.Value);
                Console.WriteLine();
            }
            #endregion        


            Queue<string> myQueue = new Queue<string>();//FIFO First In First Out
            Stack<string> myStack = new Stack<string>();//LIFO Last In First Out

            #region Tuple And ValueTuple

            Tuple<string, string, int> userDetails = Tuple.Create("user1", "1234", 24);

            var v = (1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1);
            (int Id, string FirstName, string LastName) person = (1, "Bill", "Gates");
            var person1 = (Id: 1, FName: "Bill", LName: "Gates");
            person1.FName = "";

            var prsFromMethod = GetPersonDetails();
            (string,string,int) prs = GetPersonDetails();
            #endregion
            //Library library = new Library();
            //Book book1 = new Book();
            //Book book2 = new Book();
            //Book book3 = new Book();
            //Book book4 = new Book();
            //Book book5 = new Book();
            //library.AddBook(book1);
            //library.AddBook(book2);
            //library.AddBook(book3);
            //library.AddBook(book4);
            //library.AddBook(book5);

            //foreach (Book book in library)
            //{
            //    Console.WriteLine(book);
            //}
        }

        public static (string,string,int) GetPersonDetails()
        {
            return ("1", "1", 1);
        }
    }

    class MyList<T>
    {
        public void Add(T item)
        {

        }
    }

    class MyDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {
            //
            //
            //
        }

        public bool TryAdd(TKey key, TValue value)
        {
            //
            //
            //
            return true;
        }
    }
}
