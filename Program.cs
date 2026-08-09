using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class runexpression
{



    public static Double total = 0.00; static Double value = 0.00; static string[] signal = { }; static Double[] parcel = { }; static int counter = 0; static Double d = 0.00; static String st;static bool prints = false;

    static void writer()
    {

        if (prints)Console.WriteLine(total);

    }

    static int finders(String s, char s1)
    {
        return s.IndexOf(s1);
    }

    static int returner(String s)
    {
        int i0 = s.Length;
        int i1 = 0;
        int i2 = 0;
        int i3 = 0;
        int i4 = 0;
        i1 = finders(s, '+');
        i2 = finders(s, '-');
        i3 = finders(s, '*');
        i4 = finders(s, '/');
        if (i1 > -1) i0 = Math.Min(i0, i1);
        if (i2 > -1) i0 = Math.Min(i0, i2);
        if (i3 > -1) i0 = Math.Min(i0, i3);
        if (i4 > -1) i0 = Math.Min(i0, i4);
        if (i0 == s.Length) return 0;
        return i0;
    }
    static void parm(String ss)

    {
        ss = ss.Trim();
        if (counter == 0) st = ss;
        if (counter == 1)
        {
            try
            {
                d = Double.Parse(ss);
            }
            catch (Exception e)
            {
                Console.WriteLine("error:");

            }
            if (st == "+") total = total + d;
            if (st == "-") total = total - d;
            if (st == "*") total = total * d;
            if (st == "X") total = total * d;
            if (st == "x") total = total * d;
            if (st == "\\") total = total / d;
            if (st == "/") total = total / d;
            counter = -1;
        }
        counter++;



    }


    public static void splint(String s)
    {
        String[] f = { };
        String[] ss = { };

        int i = 0;
        i = 0;

        while (true)
        {


            i = returner(s);
            if (i == 0)
            {
                Array.Resize(ref ss, ss.Length + 1);

                ss[ss.Length - 1] = s;
                break;
            }
            else
            {
                Array.Resize(ref ss, ss.Length + 2);

                ss[ss.Length - 2] = s.Substring(0, i);
                ss[ss.Length - 1] = s.Substring(i, 1);
                s = s.Substring(i + 1, s.Length - 1 - i);

            }
        }


        try
        {
            total = Double.Parse(ss[0]);
        }
        catch (Exception e)
        {
            Console.WriteLine("error:");

        }
        for (i = 1; i < ss.Length; i++)
        {
            parm(ss[i]);


        }
        writer();

    }
    static String rfinds(String s)

    {
        String ss = "";
        int f1 = s.IndexOf(")") + 1;
        if (f1 == 0) return "";
        ss = s.Substring(0, f1);
        f1 = ss.LastIndexOf("(");
        if (f1 == -1) 
        {
            Console.WriteLine("error:");
            return "";
        }
        ss = ss.Substring(f1);
        return ss;
    }
    public static void expressionLoop(String s) 
    {
        String ss = "";
        String sss = "";
        String ssss = "";
        Console.WriteLine("-------------------------------------------");
        while (true) 
        
        { 
        
            ss=rfinds(s);
            sss = ss.Replace(")", "");
            sss = sss.Replace("(", "");
            if (ss == "")
            {
                total = 0.00;
                prints = true;
                splint(s);
                break;



            }
            else 
            {
                prints = false;
                total = 0.00;
                splint(sss);
                sss=total.ToString();
                total = 0.00;
                s = s.Replace(ss, sss);


            }
        
        
        }
    
       
       
    
    }

}









class ComplexExp
{

    public static void Main()
    {

        String s = "";
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("give me a expression? empty to exit");
        //exemple: 10+20*60
        //
        while (true)
        {


            s = Console.ReadLine();

            s = s.Trim();
            if (s == "") break;
            runexpression.expressionLoop(s);
        }


    }






}
