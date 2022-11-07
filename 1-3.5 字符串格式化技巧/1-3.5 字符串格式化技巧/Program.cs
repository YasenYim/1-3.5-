using System;

namespace _1_3._5_字符串格式化技巧
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.加号拼接（GC开销大）
            //Console.WriteLine("a=" + ",b=" + 34);

            // 2.序号占位符
            //string fruit = "苹果";
            //Console.WriteLine("{0}吃了{1}", "我", fruit); // 我吃了苹果
            //Console.WriteLine("{1}被{0}吃了", "我", fruit); // 苹果被我吃了

            //Console.WriteLine("{0}吃\n了{1}", "我", fruit); // /n的意思是换行
            //Console.WriteLine("{0}吃\t了{1}", "我", fruit); // /t的最后的距离不一定相同，但是可以起到对齐的作用，可以在记事本尝试（除非对齐位最后一位被占有，只能再往后推一段距离）
            //Console.WriteLine("{0}吃\\了{1}", "我", fruit); // 打印两个\\代表一个\
            //string path = "D:\\a\\b.txt";                   // 电脑中的路径，两个\\代表一个\
            //string text = "我问：\"你吃了吗？\""; // 出现对话中的前后引号的情况
            //Console.WriteLine(text);

            // 制造了一个字符串格式化
            //string s2 = string.Format("{0}吃了{1}", "我", fruit);

            //// 3.利用$字符串格式化（2019后的版本都支持）
            //string game = "黑魂";
            //float score = 9.5f;

            //Console.WriteLine($"{game}在其网站的评分是{score}");

            //// 直接转化为string
            //string s = $"{game}在其网站的评分是{score}";
            //Console.WriteLine(s);

            //string game = "马里奥";
            //Console.WriteLine($"{game}是一个好游戏");


            // 练习1
            /*巴老爷有88棵芭蕉树，来了88个把式要在巴老爷88棵芭蕉树下住。巴老爷拔了88棵芭蕉树，不让88个把式在88棵芭蕉树下住。
             88个把式少了88棵芭蕉树，巴老爷在88棵树边哭。

             现在想让主角"巴老爷"、数量"88"、反派"把式"改为容易替换的变量，以便生成不同的故事。应当如何实现？
             */


            string story = "{0}有{1}棵芭蕉树，来了{1}个{2}要在{0}{1}棵芭蕉树下住。{0}拔了{1}棵芭蕉树，不让{1}个{2}在{1}棵芭蕉树下住。{1}个{2}少了{1}棵芭蕉树，{0}在{1}棵树边哭。";
            string name = "巴老爷";
            int numTrees = 88;
            string enemy = "把式";

            // 序号占位符+string.Format
            string newStory = string.Format(story, name, numTrees, enemy);
            Console.WriteLine(newStory);
            // 利用$字符串格式化
            Console.WriteLine($"{name}有{numTrees}棵芭蕉树，来了{numTrees}个{enemy}要在{name}88棵芭蕉树下住。{name}拔了{numTrees}棵芭蕉树，不让{numTrees}个{enemy}在{numTrees}棵芭蕉树下住。{numTrees}个{enemy}少了{numTrees}棵芭蕉树，{name}在{numTrees}棵树边哭。");
            Console.ReadKey();
        }
    }
}
