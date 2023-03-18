using System.Diagnostics.Metrics;

namespace Task._05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            /* 1 - 1000 qeder ededlerin cemi 7 bolunurmu ?*/

            //int sum = 0;

            //for (int i = 1; i < 1000; i++)
            //{
            //    sum += i;

            //}
            //Console.WriteLine(sum);
            //if (sum % 7 == 0)
            //{
            //    Console.WriteLine("bolunur");
            //}
            //else
            //    Console.WriteLine("bolunmur");
            #endregion

            #region Task 2

            /* 1 - 1000 qeder ededlerin icerisinde hem 7 - e, hemde 8 - e bolunenlerin siyahisi */
            //for (int i = 1; i < 1000; i++)
            //{
            //    if (i % 7 == 0 && i % 8 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion

            #region Task 3
            /* 1 - 1000 qeder ederlerin icerisinden ele ededleri cap et ki, 
            reqemleri cemi 3 - e bolunsun */

            //for (int i = 1; i < 1000; i++)
            //{
            //    int sum = 0;
            //    int number = i;

            //    while (number != 0)
            //    {
            //        sum += number % 10;
            //        number /= 10;

            //    }
            //    if (sum % 3 == 0)
            //    {
            //        Console.WriteLine(sum);        
            //    }
            //}


            #endregion

            #region Task 4

            /* 1 - 1000 qeder ederlerin icerisinden ele ededleri cap etki
            reqemleri cemi 3 e bolunsun ve sonuncu reqem 3 olmasin. */

            //for (int i = 1; i < 1000; i++)
            //{
            //    int sum = 0;
            //    int number = i;

            //    while (number != 0)
            //    {
            //        sum += number % 10;
            //        number /= 10;

            //    }
            //    if (sum % 3 == 0 && !(sum % 10 == 3))
            //    {
            //        Console.WriteLine(sum);
            //    }
            //}
            #endregion

            #region Task 5
            /* 1 - 1000 qeder ederlerin icerisinden ele ededleri cap etki:
            hem reqemleri cemi 5 - e bolunsun, hem de ozu 5 - e bolunsun */

            //for (int i = 5; i < 1000; i += 5)
            //{
            //    int sum = 0;
            //    int number = i;

            //    while (number != 0)
            //    {
            //        sum += number % 10;
            //        number /= 10;

            //    }
            //    if (sum % 5 == 0)
            //    {
            //        Console.WriteLine($"{i}   {sum}");
            //    }
            //}


            #endregion

            #region Task 6

            /* 1 - 1000 qeder ederlerin icerisinden ele ededleri cap etki:
            hem ozu cut eded olsun, hem reqemleri cemi tek eded olsun,
            hem I reqemi tek eded olsun */

            //for (int i = 2; i < 1000; i += 2)
            //{
            //    int sum = 0;
            //    int number = i;

            //    while (number != 0)
            //    {
            //        sum += number % 10;
            //        number /= 10;

            //    }

            //    int number2 = i;
            //    while (number2 >= 10)
            //    {
            //        number2 /= 10;
            //    }

            //    if (sum % 2 == 1 && number2 % 2 == 1)
            //    {
            //        Console.WriteLine($"{i} {sum}");
            //    }

            //}


            #endregion

            #region Task 7
            /* 1 - 1000 qeder ederlerin icerisinden ele ededleri cap etki:
            hemin ededin daxilinde 3 reqemi umumiyyetle olmasin */

            //for (int i = 1; i < 1000; i++)
            //{
            //    if (i % 10 == 3 || (i / 10) % 10 == 3 || (i / 100) % 10 == 3)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Task 8

            /* 1 - 1000 qeder ederlerin icerisinden,
            daxilinde 3 reqemi olmayib, reqemleri cemi 3 olan en sonuncu eded hansidir ?*/


            //for (int i = 1; i < 1000; i++)
            //{
            //    if (i % 10 == 3 || (i / 10) % 10 == 3 || (i / 100) % 10 == 3)
            //    {
            //        continue;
            //    }
            //    int number = i;
            //    int sum = 0;
            //    while (number != 0)
            //    {
            //        sum += number % 10;
            //        number /= 10;
            //        if (sum == 3)
            //        {
            //            Console.WriteLine($"{i}  {sum}");

            //        }

            //    }

            //}
            #endregion

            #region Task 9 
            /* 1 - 1000 qeder ederlerin icerisinde
            11 - e bolunub reqemleri cemi 11 - den boyuk olan 11 - ci eded hansidir? */

            //int b = 1;
            //for (int i = 11; i < 1000; i += 11)
            //{
            //    int sum = 0;
            //    int number = i;


            //    while (number != 0)
            //    {

            //        sum += number % 10;
            //        number /= 10;

            //    }

            //    if (sum > 11)
            //    {
            //        if (b == 12)
            //        {
            //            break;
            //        }
            //        Console.WriteLine($"{b} {i}   {sum} ");

            //        b++;

            //    }


            //}

            #endregion

            #region Task 10
            /* 1 - 1000 qeder CUT ederlerin icerisinde
            reqemleri cemi 5 ile 7 arasinda olan en boyuk eded hansidir? */

            //for (int i = 0; i < 1000; i += 2)
            //{
            //    int sum = 0;
            //    int number = i;
            //    while (number != 0)
            //    {
            //        sum += number % 10;
            //        number /= 10;
            //    }
            //    //Console.WriteLine($"{i}   {sum}");
            //    if (sum > 5 && sum < 7)
            //    {
            //        Console.WriteLine($"{i}   {sum}");
            //    }

            //}




            #endregion

            #region Task 11
            /* 1 - 1000 qeder ederlerin icerisinden ele ededleri cap etki:
            hem polindrom olsun, hem ededin reqemleri daxilinde 3 olmasin
            hem ededin reqemleri cemi 10 dan boyuk olsun */

            //for (int i = 11; i <= 1000; i++)
            //{
            //    int number = i;
            //    int sum = 0;
            //    int qaliq;

            //    while (number > 0)
            //    {
            //        qaliq = number % 10;
            //        if (qaliq != 3)
            //        {
            //            sum = sum * 10 + qaliq;
            //        }
            //        number /= 10;
            //    }
            //    if (sum == i)
            //    {
            //        int sum2 = sum;
            //        int sum3 = 0;
            //        while (sum2 > 0)
            //        {
            //            sum3 += sum2 % 10;
            //            sum2 /= 10;

            //        }
            //        if (sum3 > 10)
            //        {
            //            Console.WriteLine($"{sum}  cemi: {sum3}");
            //        }

            //    }

            //}
            #endregion

            #region Task 12
            /* 1 - 100000 qeder ederlerin icerisinden ele ededleri cap etki:
            hem butun reqemleri eyni olsun, hem reqemleri cemi 5 den boyuk olsun
            hem reqemleri arasinda 5 reqemi olmasin */

            //for (int i = 11; i < 100000; i++)
            //{
            //    int number = i;
            //    int qaliq = number % 10;

            //    int number1 = number / 10;

            //    while (number1 > 0 && number1 % 10 == qaliq)
            //    {
            //        number1 /= 10;
            //    }

            //    if (number1 == 0)
            //    {
            //        int number2 = i;
            //        if (number2 % 10 == 5)
            //        {
            //            continue;
            //        }
            //        int sum = 0;


            //        while (number2 > 0)
            //        {
            //            sum += number2 % 10;
            //            number2 /= 10;

            //        }
            //        if (sum > 5)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}

            #endregion

            #region Task 15

            /* 1-10000 qeder ederlerin icerisinden  ele ededleri cap etki :
            hem sade eded olsun
            hem ededin ozunun daxilinde 0,1,5,7,9 reqemleri olmasin
            hem ededin reqemleri ceminde 2 reqemi olmasin */

            //int temp, digit, sum;
            //int[] exclude = { 0, 1, 5, 7, 9 };

            //for (int i = 1; i < 10000; i++)
            //{
            //    l1:
            //    sum = 0;
            //    if (i % 2 == 0 || i % 3 == 0 || i % 5 == 0 || i % 7 ==0)
            //    {
            //        continue;
            //    }
            //    temp = i;
            //    while (temp > 0)
            //    {
            //        digit = temp % 10;

            //        if (Array.IndexOf(exclude, digit) != -1) 
            //        {
            //            i++;
            //            goto l1;
            //        }
            //        sum += digit;
            //        temp /= 10;
            //    }

            //    while (sum > 0)
            //    {
            //        digit = sum % 10;
            //        if (digit == 2)
            //        {
            //            i++;
            //            goto l1;
            //        }
            //        sum /= 10;
            //    }
            //    Console.WriteLine(i);
            //}
            

            #endregion

        }
    }
 }
    

    

