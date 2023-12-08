using System;
using System.Windows.Forms;

class MyPicF
{
    public static void Main()
    {
        // 使用MessageBox.Show方法创建一个信息窗口，显示路径
        MessageBox.Show(
            Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), // 使用Environment类的GetFolderPath方法获取特殊文件夹路径
            "показывающее путь к папке «Мои рисунки»"); // 设置信息窗口的标题
    }
}
