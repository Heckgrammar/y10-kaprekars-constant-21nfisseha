namespace Y10_Challenge_Kaprikars_Constant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kaprekar's Constant is 6174
            //1. take a 4 digit start number using at least two different digits...e.g. 9218
            //2. order the digits descending 4321, then ascending to get two 4 digit numbers (add leading zeros if needed)
            //3. subtract smaller number from bigger number e.g. 9821-1289=8532
            //4. Go back to step 2 replacing start number with result of step 3, repeat until numbers converge to 6174

            //Task: Write a program to compute Kaprekar's constant using any four digit start number
            //Ext: Display the number of iterations needed until 6174 is reached

            Console.WriteLine("Hello, Type a four digit number:"); //starter code for students
            int x = Convert.ToInt32(Console.ReadLine()); //starter for students
            //YOUR CODE GOES HERE....
            Console.Writeline(ascendingNumber(x));



        }
        static string ascendingNumber(int number)
        {
            string firstnumber = "";
            string secondnumber = "";
            string thirdnumber = "";
            string fourthnumber = "";
            string numberAscending = "";
            string numberString = number.ToString();
            for(int i = 0; i < 4; i++)
            {
                if (i == 0)
                {
                   firstnumber = numberString[i];
                }
                else if(i == 1)
                {
                    if (firstnumber.ToInt32() > numberString[i].ToInt32())
                    {
                        secondnumber = firstnumber;
                        firstnumber = numberString[i];
                    }
                    else
                    {
                        secondnumber = numberString[i];
                    }
                }
                else if(i == 2)
                {
                    if(firstnumber.ToInt32() > numberString[i].ToInt32())
                    {
                        thirdnumber = secondnumber;
                        secondnumber = firstnumber;
                        firstnumber = numberString[i];
                    }
                    else if(secondnumber.ToInt32() > numberString[i].ToInt32())
                    {
                        thirdnumber = secondnumber;
                        secondnumber = numberString[i];
                    }
                    else
                    {
                        thirdnumber = numberString[i];
                    }

                }
                else if(i == 3)
                {
                    if (firstnumber.ToInt32() > numberString[i].ToInt32())
                    {
                        fourthnumber = thirdnumber;
                        thirdnumber = secondnumber;
                        secondnumber = firstnumber;
                        firstnumber = numberString[i];
                    }
                    else if (secondnumber.ToInt32() > numberString[i].ToInt32())
                    {
                        fourthnumber= thirdnumber;
                        thirdnumber = secondnumber;
                        secondnumber = numberString[i];
                    }
                    else if (thirdnumber.ToInt32() > numberString[i].ToInt32())
                    {
                        fourthnumber = thirdnumber;
                        thirdnumber = numberString[i];
                    }
                    else
                    {
                        fourthnumber = numberString[i];
                    }


                }
            }
            numberAscending = firstnumber + secondnumber + thirdnumber + fourthnumber;
            return numberAscending;

        }
    }
}
