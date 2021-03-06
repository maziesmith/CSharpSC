﻿namespace ConsoleApp
{
    //The classes property and function are used to get string values for hello world etc.
    class HelloWorld
    {
        static public string hello
        {
            get
            {
                return "Hello";
            }
        }
        static public string getLocation(Location l)
        {
            switch (l)
            {
                case Location.World:
                    return "World";
                case Location.Universe:
                    return "Universe";
                case Location.Galaxy:
                    return "Galaxy";
                default:
                    return "Nobody";
            }
        }
    }
}
