using System;
using System.Drawing;
using System.Windows.Forms;

class PaintEvent
{
    public static void Main()
    {
        // 创建一个窗体对象
        Form form = new Form();
        form.Text = "Paint Event"; // 设置窗体标题
        form.BackColor = System.Drawing.Color.Orange;
        // 添加 Paint 事件处理程序
        form.Paint += new PaintEventHandler(MyPaintHandler);

        // 启动应用程序的消息循环
        Application.Run(form);
    }

    // Paint 事件处理程序
    static void MyPaintHandler(object objSender, PaintEventArgs pea)
    {
        // 获取 Graphics 对象
        Graphics grfx = pea.Graphics;

        // 设置绘制文本的字体
        Font font = new Font("Arial", 12);

        // 设置文本的位置和颜色
        PointF point = new PointF(10, 10);
        Brush brush = Brushes.Black;

        // 绘制文本
        grfx.DrawString("这是一段示例文本", font, brush, point);
    }
}
