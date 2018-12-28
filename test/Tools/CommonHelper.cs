using System;
using System.Collections.Generic;

namespace Tools
{
    public static class CommonHelper
    {
        public static string GetRandomStr() {
            List<string> strList = new List<string>();
            strList.Add("这个世界真奇妙！");
            strList.Add("傻人有傻福，傻逼没有！");
            strList.Add("你所遇到的人都是对的人，你所经历的事都是注定的事。不受点伤，怎么知道你的内心有多强大。人性中最坚不可摧的一部分，永远和爱有关，和自己的心灵有关。");
            strList.Add("每个人也许都爱上过不爱他的人，永远忘不了那时掉过的眼泪和受过的委屈。许多年后，回头再看，他又有哪一点配得上我？在人生的长途比赛中，我是比他当时喜欢的任何一个人都要优秀许多，只是他不懂我的好！那时为什么没有告诉他：你总有爱我的一天，但是，到了那天，我早已经不爱你了。");
            strList.Add("简单的事，想深了，就复杂了。复杂的事，看淡了，就简单了。有些事，笑笑就能过去。有些事，过一阵就能让你笑笑。");
            strList.Add("我们总是看得清光鲜，搞不清内涵；看得到结果，猜不出原因；给得了金钱，却拿不出精神；因此，我们羡慕着别人，抱怨着自己。");
            strList.Add("与其花时间想究竟要找个啥样的人，不如先想明白什么样的自己才会被爱情遇上。最好的爱不是对方有多好，而是因为爱上一个人自己变得更可爱。");

            int index = new Random().Next(0, strList.Count - 1);
            return strList[index];
        }
    }
}
