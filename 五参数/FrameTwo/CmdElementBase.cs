using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameTwo
{
    #region 指令基类
    public abstract class CmdElementBase
    {
        public byte FrameHeader { get; set; } = 0x81;//帧头
        public abstract byte DataLength { get; set; }//数据长度
        public abstract byte DataFlow { get; set; }//数据流向
        public abstract byte CommandID { get; }//指令编号
        public byte EndOfFrame { get; set; } = 0x82;//帧尾
    }
    #endregion

    #region 打开温控
    public class OpenThermostat : CmdElementBase
    {
        public override byte DataLength { get; set; } = 0x06;//数据长度
        public override byte DataFlow { get; set; } = 0x12;//数据流向
        public override byte CommandID { get; } = 0x11;//指令编号
    }
    #endregion

    #region 关温控关闭
    public class CloseThermostat : CmdElementBase
    {
        public override byte DataLength { get; set; } = 0x06;//数据长度
        public override byte DataFlow { get; set; } = 0x12;//数据流向
        public override byte CommandID { get; } = 0x22;//指令编号
    }
    #endregion

    #region 获取A流通池光强
    public class GetvalueOfTankA : CmdElementBase
    {
        public override byte DataLength { get; set; } = 0x06;//数据长度
        public override byte DataFlow { get; set; } = 0x12;//数据流向
        public override byte CommandID { get; } = 0x0a;//指令编号
    }
    #endregion

    #region 关闭A流通池光强
    public class ClosevalueOfTankA : CmdElementBase
    {
        public override byte DataLength { get; set; } = 0x06;//数据长度
        public override byte DataFlow { get; set; } = 0x12;//数据流向
        public override byte CommandID { get; } = 0xfa;//指令编号
    }
    #endregion

    #region 获取B流通池光强
    public class GetvalueOfTankB : CmdElementBase
    {
        public override byte DataLength { get; set; } = 0x06;//数据长度
        public override byte DataFlow { get; set; } = 0x12;//数据流向
        public override byte CommandID { get; } = 0x0b;//指令编号
    }
    #endregion

    #region 获取双流通池光强
    public class GetvalueOfTankDual : CmdElementBase
    {
        public override byte DataLength { get; set; } = 0x06;//数据长度
        public override byte DataFlow { get; set; } = 0x12;//数据流向
        public override byte CommandID { get; } = 0xab;//指令编号
    }
    #endregion
}
