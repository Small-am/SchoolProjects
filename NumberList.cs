using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class NumberList
    {
        int[] numbers = new int[8];
        private readonly int[] NumberFrequency;
        Random randomNum = new Random();
        private NumberRange _range; //instance of struct Number range

        public NumberList(NumberRange range)
        {
            _range = range;
            FillNumberList();
            NumberFrequency = new int[(_range.UpperBound + 1) - _range.LowerBound];

            for (int i = 0; i < 8; i++)
            {
                NumbersFrequency[Numbers[i] - range.LowerBound]++;
            }
        }
        //Readonly property to return frequency of all numbers
        public int[] NumbersFrequency { get { return NumberFrequency; } }

        public int[] Numbers { get => numbers; set => numbers = value; }

        //Method so the number list will be filled with random numbers
        public void FillNumberList()
        {
            for (int i = 0; i < 8; i++)
            {
                Numbers[i] = randomNum.Next(_range.LowerBound, _range.UpperBound + 1);
            }
        }   

        //gets the round numbers
        public string GetRoundNumbers()
        {
            string outString = "";
            for (int i = 0; i < 8; i++)
            {
                outString += Numbers[i].ToString() + " ";
                }
            return outString;
        }
    }
}
