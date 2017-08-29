using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class Check
    {
        public static Char checkDigitEncrypt(Char alphabet, int noofpositions)
        {
            int digit = 0;
            String temp = alphabet.ToString().ToUpper();
            switch (temp)
            {
                case "A":
                    digit = 0;
                    break;
                case "B":
                    digit = 1;
                    break;
                case "C":
                    digit = 2;
                    break;
                case "D":
                    digit = 3;
                    break;
                case "E":
                    digit = 4;
                    break;
                case "F":
                    digit = 5;
                    break;
                case "G":
                    digit = 6;
                    break;
                case "H":
                    digit = 7;
                    break;
                case "I":
                    digit = 8;
                    break;
                case "J":
                    digit = 9;
                    break;
                case "K":
                    digit = 10;
                    break;
                case "L":
                    digit = 11;
                    break;
                case "M":
                    digit = 12;
                    break;
                case "N":
                    digit = 13;
                    break;
                case "O":
                    digit = 14;
                    break;
                case "P":
                    digit = 15;
                    break;
                case "Q":
                    digit = 16;
                    break;
                case "R":
                    digit = 17;
                    break;
                case "S":
                    digit = 18;
                    break;
                case "T":
                    digit = 19;
                    break;
                case "U":
                    digit = 20;
                    break;
                case "V":
                    digit = 21;
                    break;
                case "W":
                    digit = 22;
                    break;
                case "X":
                    digit = 23;
                    break;
                case "Y":
                    digit = 24;
                    break;
                case "Z":
                    digit = 25;
                    break;
            }

            int sum = digit + noofpositions;
            
            if(sum > 25)
            {
                int excess = sum - 25;
                sum = -1 + excess;
            }
            else
            {
                sum = digit + noofpositions;
            }

            char whatisit  = ' ';

            switch(sum)
            {
                case 0:
                    whatisit = 'A';
                    break;
                case 1:
                    whatisit = 'B';
                    break;
                case 2:
                    whatisit = 'C';
                    break;
                case 3:
                    whatisit = 'D';
                    break;
                case 4:
                    whatisit = 'E';
                    break;
                case 5:
                    whatisit = 'F';
                    break;
                case 6:
                    whatisit = 'G';
                    break;
                case 7:
                    whatisit = 'H';
                    break;
                case 8:
                    whatisit = 'I';
                    break;
                case 9:
                    whatisit = 'J';
                    break;
                case 10:
                    whatisit = 'K';
                    break;
                case 11:
                    whatisit = 'L';
                    break;
                case 12:
                    whatisit = 'M';
                    break;
                case 13:
                    whatisit = 'N';
                    break;
                case 14:
                    whatisit = 'O';
                    break;
                case 15:
                    whatisit = 'P';
                    break;
                case 16:
                    whatisit = 'Q';
                    break;
                case 17:
                    whatisit = 'R';
                    break;
                case 18:
                    whatisit = 'S';
                    break;
                case 19:
                    whatisit = 'T';
                    break;
                case 20:
                    whatisit = 'U';
                    break;
                case 21:
                    whatisit = 'V';
                    break;
                case 22:
                    whatisit = 'W';
                    break;
                case 23:
                    whatisit = 'X';
                    break;
                case 24:
                    whatisit = 'Y';
                    break;
                case 25:
                    whatisit = 'Z';
                    break;
            }

            return whatisit;
        }

        public static Char checkDigitDecrypt(Char alphabet, int noofpositions)
        {
            int digit = 0;
            String temp = alphabet.ToString().ToUpper();
            switch (temp)
            {
                case "A":
                    digit = 0;
                    break;
                case "B":
                    digit = 1;
                    break;
                case "C":
                    digit = 2;
                    break;
                case "D":
                    digit = 3;
                    break;
                case "E":
                    digit = 4;
                    break;
                case "F":
                    digit = 5;
                    break;
                case "G":
                    digit = 6;
                    break;
                case "H":
                    digit = 7;
                    break;
                case "I":
                    digit = 8;
                    break;
                case "J":
                    digit = 9;
                    break;
                case "K":
                    digit = 10;
                    break;
                case "L":
                    digit = 11;
                    break;
                case "M":
                    digit = 12;
                    break;
                case "N":
                    digit = 13;
                    break;
                case "O":
                    digit = 14;
                    break;
                case "P":
                    digit = 15;
                    break;
                case "Q":
                    digit = 16;
                    break;
                case "R":
                    digit = 17;
                    break;
                case "S":
                    digit = 18;
                    break;
                case "T":
                    digit = 19;
                    break;
                case "U":
                    digit = 20;
                    break;
                case "V":
                    digit = 21;
                    break;
                case "W":
                    digit = 22;
                    break;
                case "X":
                    digit = 23;
                    break;
                case "Y":
                    digit = 24;
                    break;
                case "Z":
                    digit = 25;
                    break;
            }

            int sum = digit - noofpositions;
            if (sum <= 0)
            {
                int insufficient = Math.Abs(sum);
                sum = 25 - insufficient;
            }
            else
            {
                sum = digit - noofpositions;
                if(sum != 0)
                {
                    sum--;
                }
                
            }

            char whatisit = ' ';

            switch (sum)
            {
                case 0:
                    whatisit = 'A';
                    break;
                case 1:
                    whatisit = 'B';
                    break;
                case 2:
                    whatisit = 'C';
                    break;
                case 3:
                    whatisit = 'D';
                    break;
                case 4:
                    whatisit = 'E';
                    break;
                case 5:
                    whatisit = 'F';
                    break;
                case 6:
                    whatisit = 'G';
                    break;
                case 7:
                    whatisit = 'H';
                    break;
                case 8:
                    whatisit = 'I';
                    break;
                case 9:
                    whatisit = 'J';
                    break;
                case 10:
                    whatisit = 'K';
                    break;
                case 11:
                    whatisit = 'L';
                    break;
                case 12:
                    whatisit = 'M';
                    break;
                case 13:
                    whatisit = 'N';
                    break;
                case 14:
                    whatisit = 'O';
                    break;
                case 15:
                    whatisit = 'P';
                    break;
                case 16:
                    whatisit = 'Q';
                    break;
                case 17:
                    whatisit = 'R';
                    break;
                case 18:
                    whatisit = 'S';
                    break;
                case 19:
                    whatisit = 'T';
                    break;
                case 20:
                    whatisit = 'U';
                    break;
                case 21:
                    whatisit = 'V';
                    break;
                case 22:
                    whatisit = 'W';
                    break;
                case 23:
                    whatisit = 'X';
                    break;
                case 24:
                    whatisit = 'Y';
                    break;
                case 25:
                    whatisit = 'Z';
                    break;
            }

            return whatisit;
        }
    }
}
