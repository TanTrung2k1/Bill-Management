using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillManagement.Tools
{
    public class Tools
    {
        public static String getString(String msg, String errorMsg)
        {
            String result = "";
            bool check = true;
            do
            {
                Console.Write(msg);
                String tmp = Console.ReadLine();
                if(tmp != null)
                {
                    result = tmp;
                    check = false;
                }
                else
                {
                    Console.WriteLine(errorMsg);
                }
            } while (check);
            return result;
        }

        public static Double getDouble(String msg, String errorMsg)
        {
            while(true){
                try
                {
                    Console.Write(msg);
                    String tmp = Console.ReadLine();
                    if(tmp == null)
                    {
                        Console.WriteLine(errorMsg);
                    }
                    else
                    {
                        Double result = Double.Parse(tmp);
                        return result;
                    }
                }catch(Exception e)
                {
                    Console.WriteLine(errorMsg);
                }
            }
        }

        public static int getInt(String msg, String errorMsg)
        {
            while (true)
            {
                try
                {
                    Console.Write(msg);
                    String tmp = Console.ReadLine();
                    if(tmp == null)
                    {
                        Console.WriteLine(errorMsg);
                    }
                    else
                    {
                        int result = int.Parse(tmp);
                        return result;
                    }
                }catch(Exception e)
                {
                    Console.WriteLine(errorMsg);
                }
            }
        }


    }
}
