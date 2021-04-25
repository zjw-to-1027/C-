using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameTwo
{
    #region 泵命令基类
    public abstract class CmdPumpBase
    {
        public abstract string PortSample { get; set; }//样品进样端口
        public abstract string PortHeater { get; set; }//加热棒端口
        public abstract string PortPureWater { get; set; }//纯水端口
        public abstract string PortWasteLiquid { get; set; }//废液排放端口
        public abstract string PortReactionTank { get; set; }//流通池端口
        public abstract string PortDyeOne { get; set; }//染色剂1端口
        public abstract string PortDyeTwo { get; set; }//染色剂2端口
    }
    #endregion

    #region 硝酸盐命令端口
    public class PortNitrate : CmdPumpBase
    {
        public override string PortSample { get; set; } = PortVariable.PortSample; //样品进样端口
        public override string PortHeater { get; set; } = PortVariable.PortHeater;//加热棒端口
        public override string PortPureWater { get; set; } = PortVariable.PortPureWater;//纯水端口
        public override string PortWasteLiquid { get; set; } = PortVariable.PortWasteLiquid;//废液排放端口
        public override string PortReactionTank { get; set; } = PortVariable.PortReactionTank;//流通池端口
        public override string PortDyeOne { get; set; }//SAM进样端口
        public override string PortDyeTwo { get; set; }//NED进样端口
        public string PortDyeThree { get; set; }//CCl3进样端口
    }
    #endregion

    #region 亚硝酸盐命令端口
    public class PortNitrite : CmdPumpBase
    {
        public override string PortSample { get; set; } = PortVariable.PortSample; //样品进样端口
        public override string PortHeater { get; set; } = PortVariable.PortHeater;//加热棒端口
        public override string PortPureWater { get; set; } = PortVariable.PortPureWater;//纯水端口
        public override string PortWasteLiquid { get; set; } = PortVariable.PortWasteLiquid;//废液排放端口
        public override string PortReactionTank { get; set; } = PortVariable.PortReactionTank;//流通池端口
        public override string PortDyeOne { get; set; } = PortVariable.PortDyeOne;//SAM进样端口
        public override string PortDyeTwo { get; set; } = PortVariable.PortDyeTwo;//NED进样端口
    }
    #endregion

    #region 氨氮命令端口
    public class PortAmmoniaNitrogen : CmdPumpBase
    {
        public override string PortSample { get; set; } = PortVariable.PortSample; //样品进样端口
        public override string PortHeater { get; set; } = PortVariable.PortHeater;//加热棒端口
        public override string PortPureWater { get; set; } = PortVariable.PortPureWater;//纯水端口
        public override string PortWasteLiquid { get; set; } = PortVariable.PortWasteLiquid;//废液排放端口
        public override string PortReactionTank { get; set; } = PortVariable.PortReactionTank;//流通池端口
        public override string PortDyeOne { get; set; } = PortVariable.PortDyeOne;//邻苯基苯酚进样端口
        public override string PortDyeTwo { get; set; } = PortVariable.PortDyeTwo;//二氯乙氰尿酸钠进样端口
        public string PortDyeThree { get; set; } = PortVariable.PortDyeThree;//亚硝基铁氰化钠进样端口
    }
    #endregion

    #region 磷酸盐命令端口
    public class PortPhosphate : CmdPumpBase
    {
        public override string PortSample { get; set; } = PortVariable.PortSample; //样品进样端口
        public override string PortHeater { get; set; } = PortVariable.PortHeater;//加热棒端口
        public override string PortPureWater { get; set; } = PortVariable.PortPureWater;//纯水端口
        public override string PortWasteLiquid { get; set; } = PortVariable.PortWasteLiquid;//废液排放端口
        public override string PortReactionTank { get; set; } = PortVariable.PortReactionTank;//流通池端口
        public override string PortDyeOne { get; set; } = PortVariable.PortDyeOne;//钼酸铵混合溶液进样端口
        public override string PortDyeTwo { get; set; } = PortVariable.PortDyeTwo;//抗坏血酸进样端口
    }
    #endregion

    #region 硅酸盐命令端口
    public class PortSilicate : CmdPumpBase
    {
        public override string PortSample { get; set; } = PortVariable.PortSample; //样品进样端口
        public override string PortHeater { get; set; } = PortVariable.PortHeater;//加热棒端口
        public override string PortPureWater { get; set; } = PortVariable.PortPureWater;//纯水端口
        public override string PortWasteLiquid { get; set; } = PortVariable.PortWasteLiquid;//废液排放端口
        public override string PortReactionTank { get; set; } = PortVariable.PortReactionTank;//流通池端口
        public override string PortDyeOne { get; set; } = PortVariable.PortDyeOne;//钼酸铵进样端口
        public override string PortDyeTwo { get; set; } = PortVariable.PortDyeTwo;//草酸进样端口
        public string PortDyeThree { get; set; } = PortVariable.PortDyeThree;//抗坏血酸进样端口
    }
    #endregion

    #region 检测对象静态类
    public static class TestObject
    {
        public static string _currentNutrients;//当前所检测的营养盐
    }
    #endregion

    #region 命令端口静态类
    public static class PortVariable
    {
        private static string _portSample;//样品进样端口
        private static string _portHeater;//加热棒端口
        private static string _portPureWater;//纯水端口
        private static string _portWasteLiquid;//废液排放端口
        private static string _portReactionTank;//流通池端口
        private static string _portDyeOne;//染色剂1端口
        private static string _portDyeTwo;//染色剂2端口
        private static string _portDyeThree;//染色剂3端口

        public static string PortSample { get => _portSample; set => _portSample = value; }
        public static string PortHeater { get => _portHeater; set => _portHeater = value; }
        public static string PortPureWater { get => _portPureWater; set => _portPureWater = value; }
        public static string PortWasteLiquid { get => _portWasteLiquid; set => _portWasteLiquid = value; }
        public static string PortReactionTank { get => _portReactionTank; set => _portReactionTank = value; }
        public static string PortDyeOne { get => _portDyeOne; set => _portDyeOne = value; }
        public static string PortDyeTwo { get => _portDyeTwo; set => _portDyeTwo = value; }
        public static string PortDyeThree { get => _portDyeThree; set => _portDyeThree = value; }
    }
    #endregion

    #region 标液浓度静态类
    public static class StandSolution
    {
        public static int StandNumber { get; set; }
        public static int StandSol1 { get; set; }
        public static int StandSol2 { get; set; }
        public static int StandSol3 { get; set; }
        public static int StandSol4 { get; set; }
        public static int StandSol5 { get; set; }

        public static int TestStandSol { get; set; }
    }
    #endregion
}
