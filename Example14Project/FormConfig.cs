using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Example14Project
{
    static class FormConfig
    {
        public static Window FrmSolid { get; set; } = new SolidWindow();
        public static Window FrmLinearGradient { get; set; } = new LinearGradientWindow();
        public static Window FrmRadialGradient { get; set; } = new RadialGradientWindow();
        public static Window FrmImage { get; set; } = new ImageBrushWindow();
        public static Window FrmVisual { get; set; } = new VisualBrushWindow();

        public static Window FrmStack { get; set; } = new StackPanelWindow();
        public static Window FrmGrid { get; set; } = new GridWindow();
        public static Window FrmDockPanel { get; set; } = new DockPanelWindow();
        public static Window FrmCanvas { get; set; } = new CanvasWindow();
        public static Window FrmWrap { get; set; } = new WrapPanelWindow();




    }
}
