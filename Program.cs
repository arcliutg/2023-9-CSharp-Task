using System;
using System.Windows.Forms;

class RunForm
{
    public static void Main()
    {


        Form form = new Form();
        form.Text = "My first form";
        form.Visible = true;

        // 设置窗体背景颜色为BlanchedAlmond
        form.BackColor = System.Drawing.Color.BlanchedAlmond;

        // 增加窗体宽度2个单位
        form.Width += 2;

        // 减小窗体高度一半
        form.Height /= 2;

        // 设置窗体边框样式为FixedSingle
        form.FormBorderStyle = FormBorderStyle.FixedSingle;

        // 允许最大化窗口
        form.MaximizeBox = true;

        // 设置鼠标样式为Hand
        form.Cursor = Cursors.Hand;

        // 设置窗体启动位置为屏幕中心
        form.StartPosition = FormStartPosition.CenterScreen;

        Application.Run(form);
    }
}
