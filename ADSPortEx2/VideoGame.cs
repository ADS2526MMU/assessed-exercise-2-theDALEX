﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx2
{
    //Film class implementation for Assessed Exercise 2

    class VideoGame : IComparable
    {
        private string title;
        private string developer;
        private int releaseyear;
        public VideoGame()
        {
            throw new NotImplementedException();
        }

        public VideoGame(string title, string developer, int releaseyear)
        {
            this.title = title;
            this.developer = developer;
            this.releaseyear = releaseyear;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Developer
        {
            get { return developer; }
            set { developer = value; }
        }

        public int Releaseyear
        {
            get { return releaseyear; }
            set { releaseyear = value; }
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

    }// End of class
}
