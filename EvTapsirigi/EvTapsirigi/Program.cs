namespace EvTapsirigi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 reqemli eded verilib. Bu ededin eveline 7 reqemini , axirinada 8 reqemini artir.
            int a = 2367;
            string a1 = "7" + a + "8";
            Console.WriteLine(a1);

            //3 reqemli eded verilib. Bu ededin axirina hemin ededdin ozunu yapishdir.
            int b = 745;
            string b1 = b + "745";
            Console.WriteLine(b1);

            //5 reqemli eded verilib. Bu ededin evvel 18 % sonra ise 3 % tap.
            double c = 4590;
           double p = 18;
            double p1 = 3;

            double answer1 = (p * c) / 100;
            double answer2 =  (p1 * c) / 100; 
        

            Console.WriteLine(answer1);
            Console.WriteLine(answer2);


            //3 reqemli eded verilib. Bu ededin axirina 7 artir. Sonra cavabin 7% tap;
            double d = 250;
            double d1 = 7;

            string d2 = d + "7";
            Console.WriteLine(d2);

            double d3 = 2507;
           

            double pr=(d3*d1) / 100;

            Console.WriteLine(pr);



            //4 reqemli eded verilib. Bu ededin evvelin 4 reqemi , axirina ise 44 ededini artir. Alinan cavabin 44 % tap.

            double aa = 8000;
            string aa1 = "4" + aa + "44";
            Console.WriteLine(aa1);

            double aa2 = 4800044;
            double aa3 = 44;
            double aa4= (aa2 * aa3) / 100;

            Console.WriteLine(aa4);

            // 4 reqemli eded verilib. Bu ededin evvel 20%-ni , sonra ise cavabin 10% tap. Alinan cavabin kvadratini tap.

            double f = 3000;
            double f1 = 20;
            double f2 = 10;

            double f3 = (f1 * f) / 100;
            double f4= (f3 * f2) / 100;

            double sum1 = f4 * f4;

            Console.WriteLine(sum1);


            //2 dene 5 reqemli eded verilib. Bu ededleri toplayib. Alinan cavabin evveline ve axirina 5 artir. Neticenin 5 % tap

            double h = 50000;
            double u = 60000;
            double k = 5;

            double g= h + u;

            string g1 = "5" + g + "5";
            Console.WriteLine(g1);

            double g2 = 51100005;
            double g3=(g2 * k) / 100;

            //2 dene eded verilib. I eded 4 reqemli II eded 7 reqemlidir. I ededin 4 % -ni tap.Sonra II ededin 9 % ni tap.
            //Sonra Cavalari toplayib 10 % ni tap.

            double j = 4444;
            double o = 1000000;
            double j1 = 4;
            double o1 = 9;

            double j2 = (j * j1) / 100;
            double o2=(o * o1) / 100;

            double sum2= j2 + o2;
            double l = 10;

            double finish=(sum2 * l) / 100;

            Console.WriteLine(finish);

            //3 dene 6 reqemli eded verilib. Her birinin 10 faizini tapib neticeleri topla. Alinan cavabin 10% tap.

            double v = 300000;
            double s = 400000;
            double z = 500000;
            double precentage = 10;

            double v1=(v * precentage) / 100;
            double s1 = (s * precentage) / 100;
            double z1 = (z * precentage) / 100;

            double sum3= v1 + s1+ z1;

            double final = (sum3 * precentage) / 100;
            Console.WriteLine(final);


            // 3 dene 4 reqemli eded verilib. I ededin 1%-ni, II ededin 2% , III ededin 3 % tap.
            //Neticeleri bir birinden cix. Alinan cavabin ustune III ededin 7 % faizini gel

            double number = 7600;
            double number1 = 6500;
            double number2 = 3900;

            double numberp = 1;
            double number1p = 2;
            double number2p = 3;
            double pre = 7;

            double nmb=(number*numberp) / 100;
            double nmb1 = (number1 * number1p) / 100;
            double nmb2 = (number2 * number2p) / 100;
            double nmb3 =(number2*pre) / 100; //3 ededin 7 faizi

            double minus = nmb - nmb1- nmb2;
            double final1 = (minus * nmb3) / 100;

           Console.WriteLine(final1);











        }
    }
}
