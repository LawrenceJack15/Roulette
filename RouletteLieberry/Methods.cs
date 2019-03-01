using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteLieberry
{
    class Methods
    {
        int[] first = { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
        int[] second = { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
        int[] third = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };

        public string EvenOdd(int ANumber)
        {
            if ((ANumber % 2) != 0)
            {
                return "Odd";
            }
            return "Even";
        }
        public string RedBlack(int ANumber, int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (ANumber == Array[i])
                {
                    return "Red Number";
                }
            }
            return "Black Number";
        }
        public string LowsHighs(int ANumber)
        {
            if (ANumber >= 19 && ANumber <= 36)
            {
                return "High";
            }
            return "Low";
        }
        public string Dozens(int ANumber)
        {
            if (ANumber <= 12)
            {
                return "The 1st dozen";
            }
            else if (ANumber > 12 && ANumber < 25)
            {
                return "The 2nd dozen";
            }
            return "The 3rd dozen";
        }
        public string Columns(int ANumber)
        {
            for (int i = 0; i < first.Length; i++)
            {
                if (ANumber == first[i])
                {
                    return "The 1st column";
                }
            }
            for (int i = 0; i < second.Length; i++)
            {
                if (ANumber == second[i])
                {
                    return "The 2nd column";
                }
            }
            return "The 3rd column";
        }
        public string Street(int ANumber)
        {
            for (int i = 0; i < first.Length; i++)
            {
                if (ANumber == first[i])
                {
                    return $"Street: {ANumber}, {second[i]}, {third[i]}";
                }
            }
            for (int i = 0; i < second.Length; i++)
            {
                if (ANumber == second[i])
                {
                    return $"Street: {first[i]}, {ANumber}, {third[i]}";
                }
            }
            for (int i = 0; i < third.Length; i++)
            {
                if (ANumber == third[i])
                {
                    return $"Street: {first[i]}, {second[i]}, {ANumber}";
                }
            }
            return "";
        }
        public string DoubleRows(int ANumber)
        {
            for (int i = 0; i < first.Length; i++)
            {
                if (ANumber == first[0])
                {
                    return $"Double Row: {ANumber}/{second[i]}/{third[i]}/{first[i + 1]}/{second[i + 1]}/{third[i + 1]} ";
                }
                else if (ANumber == first[11])
                {
                    return $"Double Row: {first[10]}/{second[10]}/{third[10]}/{ANumber}/{second[11]}/{third[11]} ";
                }
                else if (ANumber == first[i])
                {
                    return $"Double Row: {first[i - 1]}/{second[i - 1]}/{third[i - 1]}/{ANumber}/{second[i]}/{third[i]}   OR   " +
                        $" {ANumber}/{second[i]}/{third[i]}/{first[i + 1]}/{second[i + 1]}/{third[i + 1]} ";
                }
            }
            for (int i = 0; i < second.Length; i++)
            {
                if (ANumber == second[0])
                {
                    return $"Double Row: {first[i]}/{ANumber}/{third[i]}/{first[i + 1]}/{second[i + 1]}/{third[i + 1]} ";
                }
                else if (ANumber == second[11])
                {
                    return $"Double Row: {first[10]}/{second[10]}/{third[10]}/{first[11]}/{ANumber}/{third[11]} ";
                }
                else if (ANumber == second[i])
                {
                    return $"Double Row: {first[i - 1]}/{second[i - 1]}/{third[i - 1]}/{first[i]}/{ANumber}/{third[i]}   OR   " +
                        $" {first[i]}/{ANumber}/{third[i]}/{first[i + 1]}/{second[i + 1]}/{third[i + 1]} ";
                }
            }
            for (int i = 0; i < third.Length; i++)
            {
                if (ANumber == third[0])
                {
                    return $"Double Row: {first[i]}/{second[i]}/{ANumber}/{first[i + 1]}/{second[i + 1]}/{third[i + 1]} ";
                }
                else if (ANumber == third[11])
                {
                    return $"Double Row: {first[10]}/{second[10]}/{third[10]}/{first[11]}/{second[11]}/{ANumber} ";
                }
                if (ANumber == third[i])
                {
                    return $"Double Row: {first[i - 1]}/{second[i - 1]}/{third[i - 1]}/{first[i]}/{second[i]}/{ANumber}   OR   " +
                        $" {first[i]}/{second[i]}/{ANumber}/{first[i + 1]}/{second[i + 1]}/{third[i + 1]} ";
                }
            }
            return "";
        }
        public string Split(int ANumber)
        {
            for (int i = 0; i < first.Length; i++)
            {
                if (ANumber == first[0])
                {
                    return $"{ANumber}/{ANumber + 1}   OR   {ANumber}/{ANumber + 3}";
                }
                else if (ANumber == first[11])
                {
                    return $"{ANumber - 3}/{ANumber}   OR   {ANumber}/{ANumber + 1}";
                }
                else if (ANumber == first[i])
                {
                    return $"{ANumber - 3}/{ANumber}   OR   {ANumber}/{ANumber + 1}   OR   {ANumber}/{ANumber + 3}";
                }
            }
            for (int i = 0; i < second.Length; i++)
            {
                if (ANumber == second[0])
                {
                    return $"{ANumber - 1}/{ANumber}   OR   {ANumber}/{ANumber + 3}   OR   {ANumber}/{ANumber + 1}";
                }
                else if (ANumber == second[11])
                {
                    return $"{ANumber - 1}/{ANumber}   OR   {ANumber - 3}/{ANumber}   OR   {ANumber}/{ANumber + 1}";
                }
                else if (ANumber == second[i])
                {
                    return $"{ANumber - 3}/{ANumber}   OR   {ANumber - 1}/{ANumber}   OR   {ANumber}/{ANumber + 1}   OR   {ANumber}/{ANumber + 3}";
                }
            }
            for (int i = 0; i < third.Length; i++)
            {
                if (ANumber == third[0])
                {
                    return $"{ANumber - 1}/{ANumber}   OR   {ANumber}/{ANumber + 3}";
                }
                else if (ANumber == third[11])
                {
                    return $"{ANumber - 3}/{ANumber}   OR   {ANumber - 1}/{ANumber}";
                }
                else if (ANumber == third[i])
                {
                    return $"{ANumber - 3}/{ANumber}   OR  {ANumber - 1}/{ANumber}   OR   {ANumber}/{ANumber + 3}";
                }
            }
            return "";
        }
        public string Corner(int ANumber)
        {
            for (int i = 0; i < first.Length; i++)
            {
                if(ANumber == first[0])
                {
                    return $"Corner: {ANumber}/{ANumber + 1}/{ANumber + 4}/{ANumber + 3}";
                }
                else if (ANumber == first[11])
                {
                    return $"Corner : {ANumber - 3}/{ANumber - 2}/{ANumber + 1}/{ANumber}";
                }
                else if (ANumber == first[i])
                {
                    return $"Corner: {ANumber - 3}/{ANumber - 2}/{ANumber + 1}/{ANumber}   OR   {ANumber}/{ANumber + 1}/{ANumber + 4}/{ANumber + 3}";
                }
            }
            for (int i = 0; i < second.Length; i++)
            {
                if (ANumber == second[0])
                {
                    return $"Corner: {ANumber - 1}/{ANumber}/{ANumber + 3}/{ANumber + 2}   OR   {ANumber}/{ANumber + 1}/{ANumber + 4}/{ANumber + 3}";
                }
                else if (ANumber == second[11])
                {
                    return $"Corner: {ANumber - 4}/{ANumber - 3}/{ANumber}/{ANumber - 1}   OR   {ANumber - 3}/{ANumber - 2}/{ANumber + 1}/{ANumber}";
                }
                else if (ANumber == second[i])
                {
                    return $"Corner: {ANumber - 4}/{ANumber - 3}/{ANumber}/{ANumber - 1}   OR   {ANumber - 3}/{ANumber - 2}/{ANumber + 1}/{ANumber}   OR   {ANumber - 1}/{ANumber}/{ANumber + 3}/{ANumber + 2}   OR   {ANumber}/{ANumber + 1}/{ANumber + 4}/{ANumber + 3}";
                }
            }
            for (int i = 0; i < third.Length; i++)
            {
                if (ANumber == third[0])
                {
                    return $"Corner: { ANumber - 1}/{ ANumber}/{ ANumber + 3}/{ ANumber + 2}";
                }
                else if (ANumber == third[11])
                {
                    return $"Corner : {ANumber - 4}/{ANumber - 3}/{ANumber}/{ANumber - 1}";
                }
                else if (ANumber == third[i])
                {
                    return $"Corner: {ANumber - 4}/{ANumber - 3}/{ANumber}/{ANumber - 1}   OR   {ANumber - 1}/{ANumber}/{ANumber + 3}/{ANumber + 2}";
                }
            }
            return "";
        }
    }
}
