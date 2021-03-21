using System;
using System.Linq;

namespace b2
{
    class Program
    {
        public static void test(int[] par)
        {
            int min = par[0], max = par[0], sum = 0, ave = 0;
            for (int i = 0; i < par.Length; i++)
            {
                if (min > par[i])
                    min = par[i];
                if (max < par[i])
                    max = par[i];
                sum = sum + par[i];
            }
            ave = sum / par.Length;
            Console.WriteLine("最小数：" + min);
            Console.WriteLine("最大数：" + max);
            Console.WriteLine("平均数：" + ave);
            Console.WriteLine("和：" + sum);
        }
    


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] i = { 1, 2, 3, 4, 5, 6, 7, 8, 31, 12, 5, 36, 54, 5, 753, 42, 4, 231, 34, 22, 3 };
            //    test(i);
            Console.Write("\n输入K个初始簇中心点的序号(序号一行输入，以空格隔开，回车结束！)\n");
            string str = Console.ReadLine();//从控制台读入输入
            string[] nums = str.Split(new string[] { " " }, StringSplitOptions.None);//这里是以空格隔开
            int[] num;
            num = new int[nums.Count<string>()];
            int index = 0;
            while (index < nums.Count<string>())
            {
                num[index] = Convert.ToInt32(nums[index]);  //获得数字    

                index++;
            }
            test(num);
        }
    }
}
