using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

// ننشئ كلاس جديد يرث من Panel العادية
public class GradientPanel : Panel  // : Panel تعني "يرث من"
{
    // خاصية للون الأعلى - يمكن تعديلها من خصائص العنصر
    public Color ColorTop { get; set; } = Color.FromArgb(102, 126, 234);

    // خاصية للون الأسفل - يمكن تعديلها من خصائص العنصر
    public Color ColorBottom { get; set; } = Color.FromArgb(118, 75, 162);

    // دالة ترسم العنصر على الشاشة
    protected override void OnPaint(PaintEventArgs e)
    {
        // ننشئ فرشاة بتدرج لوني
        var gradientBrush = new LinearGradientBrush(
            this.ClientRectangle,   // المساحة المراد تعبئتها
            ColorTop,               // اللون الأول
            ColorBottom,            // اللون الثاني
            45F);                   // زاوية التدرج (45 درجة)

        // نملأ المساحة بالتدرج اللوني
        e.Graphics.FillRectangle(gradientBrush, this.ClientRectangle);

        // ننفذ الرسم العادي للـ Panel
        base.OnPaint(e);
    }
}