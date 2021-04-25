using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameTwo
{
    #region 连接器基类
    public class CmdConnector
    {
        #region 校验和求值
        /// <summary>
        /// 校验和求值
        /// </summary>
        /// <param name="byteData"></param>
        /// <returns></returns>
        public byte CheckSum(byte[] byteData)
        {
            byte sum = 0;
            foreach (var item in byteData)
            {
                sum += item;
            }
            return sum;
        }
        #endregion

        #region 获得完整的指令字节数组
        public byte[] GetCommandArray(byte dataLength, byte dataFlow, byte commandID, byte[] commandParam = null)
        {
            List<byte> arrayList = new List<byte>();
            List<byte> checkList = new List<byte>();//存放求校验和的byte字节数组参数
            arrayList.Add(CmdInfo.GetInstance().OpenThermostat.FrameHeader);//添加协议头
            checkList.Add(CmdInfo.GetInstance().OpenThermostat.FrameHeader);
            arrayList.Add(dataLength);//添加数据帧长度
            checkList.Add(dataLength);
            arrayList.Add(dataFlow);//添加数据流向
            checkList.Add(dataFlow);
            arrayList.Add(commandID);//添加指令编号
            checkList.Add(commandID);
            if (commandParam != null)
            {
                arrayList.AddRange(commandParam);//添加指令参数
                checkList.AddRange(commandParam);
            }
            arrayList.Add(CheckSum(checkList.ToArray()));//添加检验和
            arrayList.Add(CmdInfo.GetInstance().OpenThermostat.EndOfFrame);
            return arrayList.ToArray(); ;
        }
        #endregion
    }
    #endregion

    #region 打开温控器指令
    public class CmdOpenThermostat : CmdConnector
    {
        public OpenThermostat ObjOpenThermostat = CmdInfo.GetInstance().OpenThermostat;//获取打开温控器指令实体类对象
        public byte[] GetCmdArray()//获得完整的指令字节数组
        {
            return base.GetCommandArray(ObjOpenThermostat.DataLength, ObjOpenThermostat.DataFlow, ObjOpenThermostat.CommandID);
        }
    }
    #endregion

    #region 关闭温控器指令
    public class CmdCloseThermostat : CmdConnector
    {
        public CloseThermostat ObjCloseThermostat = CmdInfo.GetInstance().CloseThermostat;//获取关闭温控器指令实体类对象
        public byte[] GetCmdArray()//获得完整的指令字节数组
        {
            return base.GetCommandArray(ObjCloseThermostat.DataLength, ObjCloseThermostat.DataFlow, ObjCloseThermostat.CommandID);
        }
    }
    #endregion

    #region 获取A流通池光强指令
    public class CmdGetvalueOfTankA : CmdConnector
    {
        public GetvalueOfTankA ObjGetvalueA = CmdInfo.GetInstance().GetvalueOfTankA;//获取A流通池光强指令实体类对象
        public byte[] GetCmdArray()//获得完整的指令字节数组
        {
            return base.GetCommandArray(ObjGetvalueA.DataLength, ObjGetvalueA.DataFlow, ObjGetvalueA.CommandID);
        }
    }
    #endregion

    #region 关闭A流通池光强指令
    public class CmdClosevalueOfTankA : CmdConnector
    {
        public ClosevalueOfTankA ObjClosevalueA = CmdInfo.GetInstance().ClosevalueOfTankA;//关闭A流通池光强指令实体类对象
        public byte[] GetCmdArray()//获得完整的指令字节数组
        {
            return base.GetCommandArray(ObjClosevalueA.DataLength, ObjClosevalueA.DataFlow, ObjClosevalueA.CommandID);
        }
    }
    #endregion

    #region 获取B流通池光强指令
    public class CmdGetvalueOfTankB : CmdConnector
    {
        public GetvalueOfTankB ObjGetvalueB = CmdInfo.GetInstance().GetvalueOfTankB;//获取B流通池光强指令实体类对象
        public byte[] GetCmdArray()//获得完整的指令字节数组
        {
            return base.GetCommandArray(ObjGetvalueB.DataLength, ObjGetvalueB.DataFlow, ObjGetvalueB.CommandID);
        }
    }
    #endregion

    #region 获取双流通池光强指令
    public class CmdGetvalueOfTankDual : CmdConnector
    {
        public GetvalueOfTankDual ObjGetvalueDual = CmdInfo.GetInstance().GetvalueOfTankDual;//获取双流通池光强指令实体类对象
        public byte[] GetCmdArray()//获得完整的指令字节数组
        {
            return base.GetCommandArray(ObjGetvalueDual.DataLength, ObjGetvalueDual.DataFlow, ObjGetvalueDual.CommandID);
        }
    }
    #endregion
}
