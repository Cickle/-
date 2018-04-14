using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 批量处理文件
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("批量处理文件程序");
            A();
        }

        private static void A()
        {
            Console.WriteLine("1.将目标文件夹复制到指定目录中的每个文件夹中");
            string a = Console.ReadLine();
            switch (a)
            {
                case "1":
                    CopyFile();
                    break;
            }
        }

        static void CopyFile()
        {
            Console.WriteLine("请输入源文件夹地址，输入0返回上一步");
            string a = Console.ReadLine();
            switch (a)
            {
                case "0":
                    A();
                    break;
            }
        }
    }
}
