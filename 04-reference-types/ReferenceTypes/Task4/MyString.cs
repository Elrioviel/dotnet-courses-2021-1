using System;
using System.Collections.Generic;
using System.Text;


namespace Task4
{
    class MyString
    {
        private Char[] _charArray;

        public MyString()
        { }
        public MyString(string stringFromString)
        {
            int lengthOfString = stringFromString.Length;
            this._charArray = new char[lengthOfString];
            for (int i = 0; i < lengthOfString; i++)
            {
                _charArray[i] = stringFromString[i];
            }
            
        }
        public MyString(char[] stringFromChar)
        {
            int lengthOfCharArray = stringFromChar.Length;
            this._charArray = new char[lengthOfCharArray];
            for (int i = 0; i < lengthOfCharArray; i++)
            {
                _charArray[i] = stringFromChar[i];
            }
        }
        public char this[int index]
        {
            get
            {
                return _charArray[index];
            }
            set
            {
                _charArray[index] = value;
            }
        }
        public static string operator +(MyString firstString, MyString secondString)
        {
            var newLength = firstString._charArray.Length + secondString._charArray.Length;
            var sumStrings = new char[newLength];
            for (var i = 0; i < firstString._charArray.Length; i++)
            {
                sumStrings[i] = firstString[i];
            }
            for (var j = 0; j < secondString._charArray.Length; j++)
            {
                sumStrings[firstString._charArray.Length + j] = secondString[j];
            }
            return new string(sumStrings);
        }
        public static bool operator !=(MyString firstString, MyString secondString)
        {
            if (firstString._charArray.Length != secondString._charArray.Length)
            {
                return true;
            }
            for (var i = 0; i < firstString._charArray.Length; i++)
            {
                if (firstString[i] != secondString[i])
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator == (MyString firstString, MyString secondString)
        {
            if (firstString._charArray.Length != secondString._charArray.Length)
            {
                return false;
            }
            for (int i = 0; i < firstString._charArray.Length; i++)
            {
                if (firstString[i] != secondString[i])
                {
                    return false;
                }
            }
            return true;
        }
        public static string operator -(MyString firstString, MyString secondString)
        {
            {
                int tmp;
                int check = 0;
                for (int i = 0; i < firstString._charArray.Length; i++)
                {
                    if (firstString._charArray[i] == secondString._charArray[check])
                    {
                        if (check == secondString._charArray.Length - 1)
                        {
                            tmp = i - secondString._charArray.Length + 1;
                            char[] newChar = new char[firstString._charArray.Length - secondString._charArray.Length];

                            for (int l = 0; l < tmp; l++)
                            {
                                newChar[l] = firstString._charArray[l];
                            }

                            for (int l = 0; l < firstString._charArray.Length - secondString._charArray.Length - i + check; l++)
                            {
                                newChar[l + tmp] = firstString._charArray[i + l + 1];
                            }

                            return new string(newChar);
                        }
                        check++;
                    }
                    else { check = 0; }
                }
                return new string(firstString._charArray);
            }
        }
        new public string ToString()
        {
            return new string(_charArray);
        }
    }

}
