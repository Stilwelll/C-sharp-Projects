﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_App
{
    class Book
    {
        public string title;
        public string category;
        public int pageCount;
        public int bookIndex;
        public bool isItCheckedOut;
        
        public Book(string atitle, string acategory, int apageCount, int abookIndex, bool aisItCheckedOut)
        {
            title = atitle;
            category = acategory;
            pageCount = apageCount;
            isItCheckedOut = aisItCheckedOut;
            bookIndex = abookIndex;
        }

        public string CheckedOutStatus()
        {
            if (isItCheckedOut == true)
            {
                return "This Book is Not Available";
            }
            else
            {
                return "This Book is Available";
            }
        }
    }
}
