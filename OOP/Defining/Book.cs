using System;

namespace Defining
{
    // classes have a name, unique within the namespace
    public class Book
    {
        // TODO: classes have member variables, or "fields" to hold data
        string _name;
        string _author;
        int _pageCount;

        // TODO: classes have one or more constructors
        public Book(string name, string author, int pageCount)
        {
            _name = name;
            _author = author;
            _pageCount = pageCount;
        }

        // TODO: methods are used to operate on the class and data
        public string getDescription()
        {
            return $"Title: {_name}, Author: {_author}, Page Count: {_pageCount}";
        }
    }
}
