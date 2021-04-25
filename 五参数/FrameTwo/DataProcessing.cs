using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameTwo
{
    public class DataProcessing
    {
        public static double currentValue1 = 0;
    }
    #region 硝酸盐实验数据
    public static class NitrateExpData
    {
        public static double[] LightIn { get; set; } = new double[5];
        public static double[] LightOut { get; set; } = new double[5];
        public static double[] Absorbance { get; set; } = new double[5];

        public static double LightInSample { get; set; }
        public static double LightOutSample { get; set; }
        public static double AbsorbanceSample { get; set; }
    }
    #endregion

    #region 亚硝酸盐实验数据
    public static class NitriteExpData
    {
        public static double[] LightIn { get; set; } = new double[5];
        public static double[] LightOut { get; set; } = new double[5];
        public static double[] Absorbance { get; set; } = new double[5];

        public static double LightInSample { get; set; }
        public static double LightOutSample { get; set; }
        public static double AbsorbanceSample { get; set; }
    }
    #endregion

    #region 氨氮实验数据
    public static class AmmoniaNitrogenExpData
    {
        public static double[] LightIn { get; set; } = new double[5];
        public static double[] LightOut { get; set; } = new double[5];
        public static double[] Absorbance { get; set; } = new double[5];

        public static double LightInSample { get; set; }
        public static double LightOutSample { get; set; }
        public static double AbsorbanceSample { get; set; }
    }
    #endregion

    #region 磷酸盐实验数据
    public static class PhosphateExpData
    {
        public static double[] LightIn { get; set; } = new double[5];
        public static double[] LightOut { get; set; } = new double[5];
        public static double[] Absorbance { get; set; } = new double[5];

        public static double LightInSample { get; set; }
        public static double LightOutSample { get; set; }
        public static double AbsorbanceSample { get; set; }
    }
    #endregion

    #region 硅酸盐实验数据
    public static class PortSilicateExpData
    {
        public static double[] LightIn { get; set; } = new double[5];
        public static double[] LightOut { get; set; } = new double[5];
        public static double[] Absorbance { get; set; } = new double[5];

        public static double LightInSample { get; set; }
        public static double LightOutSample { get; set; }
        public static double AbsorbanceSample { get; set; }
    }
    #endregion
}
