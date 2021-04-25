using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameTwo
{
    public class CmdEntity
    {
        public byte[] GetSentArray(string strcmd, byte pumpAddress)
        {
            byte xorCheck = 0;
            List<byte> listArray = new List<byte>();
            listArray.Add(0x02);//STX(02h)
            listArray.Add(pumpAddress);//泵地址
            listArray.Add(0x31);//顺序号
            byte[] byteArray1 = Encoding.Default.GetBytes(strcmd);//数据块
            listArray.AddRange(byteArray1);//添加数据块
            listArray.Add(0x03);//(03h)
            foreach (var item in listArray)//异或校验
            {
                xorCheck ^= item;
            }
            listArray.Add(xorCheck);//添加校验结果
            return listArray.ToArray();//返回要发送的字节数组
        }
    }


    #region 硝酸盐
    public class CmdNitrate
    {
        private int scale = 1200;//  1200步/mL
        private string _speed1 = "V500";
        private string _speed2 = "V2100";
        private string _speed3 = "V3000";
        private string _speed4 = "V6000";
        public static double[] solutionArray2 = new double[StandSolution.StandNumber];
        public string GetCmdWash()
        {
            StringBuilder sbWash = new StringBuilder();
            sbWash.Append("g");//添加循环头
            sbWash.Append(_speed3);//设置速度3000
            sbWash.Append(PortVariable.PortPureWater + "A2760");//吸入纯水2.3mL
            sbWash.Append("O" + PortVariable.PortHeater + "A0");//把2.3mL纯水推进加热棒，加热棒端口前要加“I”或“O”
            sbWash.Append("I" + PortVariable.PortHeater + "A3000");//从加热棒吸入2.5mL水（包含0.2mL空气)
            sbWash.Append(_speed2);//设置速度2100
            sbWash.Append(PortVariable.PortWasteLiquid + "A2400");//废液口排出0.5mL
            sbWash.Append(_speed4);//设置速度6000
            sbWash.Append(PortVariable.PortReactionTank + "A0");//流通池口排出2mL
            sbWash.Append("G3R");//添加循环尾，循环3次，指令结束
            return sbWash.ToString();
        }
        
        public string GetCmdInit()
        {
            //管路填充，防止首次标定吸入过量空气
            StringBuilder sbInit = new StringBuilder();
            sbInit.Append("V2000");//设置速度2000
            sbInit.Append(PortVariable.PortSample + "P60");//吸入0.05mL样品，填充样品管路
            sbInit.Append(PortVariable.PortDyeOne + "P60");//吸入0.05mLSAM，填充SAM管路
            sbInit.Append(PortVariable.PortDyeTwo + "P60");//吸入0.05mLNED，填充NED管路
            sbInit.Append(PortVariable.PortDyeThree + "P60");//吸入0.05mLVCl3，填充VCl3管路
            sbInit.Append(PortVariable.PortWasteLiquid + "A0R");//混合液全部从废液口排出，本条指令结束
            return sbInit.ToString();
        }

        public string[] GetCmdMixed()
        {
            StringBuilder sbMixed = new StringBuilder();
            List<int> solutionList = new List<int>();
            solutionList.Add(StandSolution.StandSol1);
            solutionList.Add(StandSolution.StandSol2);
            solutionList.Add(StandSolution.StandSol3);
            solutionList.Add(StandSolution.StandSol4);
            solutionList.Add(StandSolution.StandSol5);
            int[] solutionArray = solutionList.ToArray();
            string[] cmdMixed = new string[StandSolution.StandNumber];
            for (int i = 0; i < StandSolution.StandNumber; i++)
            {
                sbMixed.Clear();
                sbMixed.Append(PortVariable.PortPureWater);
                sbMixed.Append(_speed3);//速度设置为3000
                if (i == 0 && StandSolution.StandSol1 == 0)
                    sbMixed.Append("P" + ((int)(1 * scale)).ToString());//若i=0(浓度为0)，则吸入1mL超纯水
                else
                    sbMixed.Append("P" + ((int)(solutionArray[i] * 0.125 * scale)).ToString());//吸入样品
                sbMixed.Append(_speed1);//速度设置为500
                sbMixed.Append(PortVariable.PortDyeOne + "P" + ((int)(scale * 0.075)).ToString());//吸入0.075mLSAM
                sbMixed.Append(PortVariable.PortDyeTwo + "P" + ((int)(scale * 0.0625)).ToString());//吸入0.0625mLNED
                sbMixed.Append(PortVariable.PortDyeThree + "P" + ((int)(scale * 0.125)).ToString());//吸入0.125mL三氯化钒
                sbMixed.Append(_speed3);//速度设置为3000
                if (i == 0 && StandSolution.StandSol1 == 0)
                    sbMixed.Append("P" + ((int)(0.5 * scale)).ToString());//若i=0(浓度为0)，则吸入0.5mL超纯水
                else
                    sbMixed.Append(PortVariable.PortPureWater + "P" + ((int)((1.5 - solutionArray[i] * 0.125) * scale)).ToString());
                sbMixed.Append("g");//添加循环头
                sbMixed.Append("O" + PortVariable.PortHeater + "A0");//把1.7625mL混合液推进加热棒
                sbMixed.Append("I" + PortVariable.PortHeater + "A2072");//把1.7625mL混合液吸进注射器
                sbMixed.Append("G2");//添加循环尾，循环2次
                sbMixed.Append("O" + PortVariable.PortHeater + "A0");//把1.7625mL混合液推进加热棒
                sbMixed.Append("M90000");//在加热棒中加热反应90秒
                sbMixed.Append("I" + PortVariable.PortHeater + "A2400");//从加热棒中洗出2mL混合液（包含空气）
                sbMixed.Append(PortVariable.PortWasteLiquid + "D" + ((int)(scale * 0.5)).ToString());//废液口排出0.5mL
                sbMixed.Append(_speed2);//速度设置为2100
                sbMixed.Append(PortVariable.PortReactionTank + "A0R");//全部排入流通池，本条指令结束
                cmdMixed[i] = sbMixed.ToString();
            }
            return cmdMixed;
        }
    }
    #endregion

    #region 亚硝酸盐
    public class CmdNitrite
    {
        private int scale = 1200;//  1200步/mL
        private string _speed1 = "V500";
        private string _speed2 = "V2100";
        private string _speed3 = "V3000";
        private string _speed4 = "V6000";
        public static double[] solutionArray2 = new double[StandSolution.StandNumber];
        public string GetCmdWash()
        {
            StringBuilder sbWash = new StringBuilder();
            sbWash.Append("g");//添加循环头
            sbWash.Append(_speed3);//设置速度3000
            sbWash.Append(PortVariable.PortPureWater + "A3000");//吸入纯水2.5mL
            sbWash.Append(_speed2);//设置速度2100
            sbWash.Append(PortVariable.PortWasteLiquid + "A2400");//废液口排出0.5mL
            sbWash.Append(_speed4);//设置速度6000
            sbWash.Append(PortVariable.PortReactionTank + "A0");//流通池口排出2mL
            sbWash.Append("G3R");//添加循环尾，循环3次，指令结束
            return sbWash.ToString();
        }
        public string GetCmdInit()
        {
            //管路填充，防止首次标定吸入过量空气
            StringBuilder sbInit = new StringBuilder();
            sbInit.Append("V2000");//设置速度2000
            sbInit.Append(PortVariable.PortSample + "P60");//吸入0.05mL样品，填充样品管路
            sbInit.Append(PortVariable.PortDyeOne + "P60");//吸入0.05mLSAM，填充SAM管路
            sbInit.Append(PortVariable.PortDyeTwo + "P60");//吸入0.05mLNED，填充NED管路
            sbInit.Append(PortVariable.PortWasteLiquid + "A0R");//混合液全部从废液口排出，本条指令结束
            return sbInit.ToString();
        }
        public string[] GetCmdMixed()
        {
            StringBuilder sb = new StringBuilder();
            List<int> solutionList = new List<int>();
            solutionList.Add(StandSolution.StandSol1);
            solutionList.Add(StandSolution.StandSol2);
            solutionList.Add(StandSolution.StandSol3);
            solutionList.Add(StandSolution.StandSol4);
            solutionList.Add(StandSolution.StandSol5);
            int[] solutionArray = solutionList.ToArray();
            for (int i = 0; i < StandSolution.StandNumber; i++)
            {
                solutionArray2[i] = (double)solutionArray[i];
            }
            string[] cmdMixed = new string[StandSolution.StandNumber];

            for (int i = 0; i < StandSolution.StandNumber; i++)
            {
                sb.Clear();
                if (i == 0 && StandSolution.StandSol1 == 0)
                {
                    sb.Append(PortVariable.PortPureWater);
                    sb.Append(_speed3);//速度设置为3000
                    sb.Append("P" + ((int)(1 * scale)).ToString());//若i=0(浓度为0)，则吸入1mL超纯水
                }
                else
                {
                    sb.Append(PortVariable.PortSample);
                    sb.Append(_speed3);//速度设置为3000
                    sb.Append("P" + ((int)(solutionArray[i] * 0.125 * scale)).ToString());//吸入样品 
                }
                sb.Append(_speed1);//速度设置为500
                sb.Append(PortVariable.PortDyeTwo + "P" + ((int)(scale * 0.0375)).ToString());//吸入NED
                sb.Append(PortVariable.PortDyeOne + "P" + ((int)(scale * 0.0625)).ToString());//吸入SAM
                sb.Append(_speed3);//速度设置为3000
                if (i == 0 && StandSolution.StandSol1 == 0)
                    sb.Append("P" + ((int)(0.25 * scale)).ToString());//若i=0(浓度为0)，则吸入0.25mL超纯水
                else
                    sb.Append(PortVariable.PortPureWater + "P" + ((int)((1.25 - solutionArray[i] * 0.125) * scale)).ToString());
                sb.Append("M15000");//延时15秒
                sb.Append(PortVariable.PortWasteLiquid + "D" + ((int)(scale * 0.1)).ToString());//废液口排出0.1mL
                sb.Append(_speed2);//速度设置为2100
                sb.Append(PortVariable.PortReactionTank + "A0R");//全部排入流通池，本条指令结束
                cmdMixed[i] = sb.ToString();
            }
            return cmdMixed;
        }
        public string Testing()
        {
            StringBuilder sbTest = new StringBuilder();
            sbTest.Append(PortVariable.PortSample);
            sbTest.Append(_speed3);//速度设置为3000
            sbTest.Append("P" + (StandSolution.TestStandSol * 0.125 * scale).ToString());//吸入样品
            sbTest.Append(_speed1);//速度设置为500
            sbTest.Append(PortVariable.PortDyeTwo + "P" + ((int)(scale * 0.0375)).ToString());//吸入NED
            sbTest.Append(PortVariable.PortDyeOne + "P" + ((int)(scale * 0.0625)).ToString());//吸入SAM
            sbTest.Append(_speed3);//速度设置为3000
            sbTest.Append(PortVariable.PortPureWater + "P" + ((int)((1.25 - StandSolution.TestStandSol * 0.125) * scale)).ToString());
            sbTest.Append("M15000");//延时15秒
            sbTest.Append(PortVariable.PortWasteLiquid + "D" + ((int)(scale * 0.1)).ToString());//废液口排出0.1mL
            sbTest.Append(_speed2);//速度设置为2100
            sbTest.Append(PortVariable.PortReactionTank + "A0R");//全部排入流通池，本条指令结束
            return sbTest.ToString();
        }
    }
    #endregion

    #region 氨氮
    public class CmdAmmoniaNitrogen
    {
        private int scale = 1200;//  1200步/mL
        private string _speed1 = "V500";
        private string _speed2 = "V2100";
        private string _speed3 = "V3000";
        private string _speed4 = "V6000";
        public static double[] solutionArray2 = new double[StandSolution.StandNumber];
        public string GetCmdWash()
        {
            StringBuilder sbWash = new StringBuilder();
            sbWash.Append("g");//添加循环头
            sbWash.Append(_speed3);//设置速度3000
            sbWash.Append(PortVariable.PortPureWater + "A2760");//吸入纯水2.3mL
            sbWash.Append("O" + PortVariable.PortHeater + "A0");//把2.3mL纯水推进加热棒，加热棒端口前要加“I”或“O”
            sbWash.Append("I" + PortVariable.PortHeater + "A3000");//从加热棒吸入2.5mL水（包含0.2mL空气)
            sbWash.Append(_speed2);//设置速度2100
            sbWash.Append(PortVariable.PortWasteLiquid + "A2400");//废液口排出0.5mL
            sbWash.Append(_speed4);//设置速度6000
            sbWash.Append(PortVariable.PortReactionTank + "A0");//流通池口排出2mL
            sbWash.Append("G3R");//添加循环尾，循环3次，指令结束
            return sbWash.ToString();
        }

        public string GetCmdInit()
        {
            //管路填充，防止首次标定吸入过量空气
            StringBuilder sbInit = new StringBuilder();
            sbInit.Append("V2000");//设置速度2000
            sbInit.Append(PortVariable.PortSample + "P60");//吸入0.05mL样品，填充样品管路
            sbInit.Append(PortVariable.PortDyeOne + "P60");//吸入0.05mLSAM，填充SAM管路
            sbInit.Append(PortVariable.PortDyeTwo + "P60");//吸入0.05mLNED，填充NED管路
            sbInit.Append(PortVariable.PortDyeThree + "P60");//吸入0.05mLVCl3，填充VCl3管路
            sbInit.Append(PortVariable.PortWasteLiquid + "A0R");//混合液全部从废液口排出，本条指令结束
            return sbInit.ToString();
        }
        public string[] GetCmdMixed()
        {
            StringBuilder sb = new StringBuilder();
            List<int> solutionList = new List<int>();
            solutionList.Add(StandSolution.StandSol1);
            solutionList.Add(StandSolution.StandSol2);
            solutionList.Add(StandSolution.StandSol3);
            solutionList.Add(StandSolution.StandSol4);
            solutionList.Add(StandSolution.StandSol5);
            int[] solutionArray = solutionList.ToArray();
            string[] cmdMixed = new string[StandSolution.StandNumber];
            for (int i = 0; i < StandSolution.StandNumber; i++)
            {
                sb.Clear();
                sb.Append(PortVariable.PortPureWater);
                sb.Append(_speed3);//速度设置为3000
                if (i == 0 && StandSolution.StandSol1 == 0)
                    sb.Append("P" + ((int)(0.625 * scale)).ToString());//若i=0(浓度为0)，则吸入0.625mL超纯水
                else
                    sb.Append("P" + ((int)(solutionArray[i] * 0.15625 * scale)).ToString());//吸入样品
                sb.Append(_speed1);//速度设置为500
                sb.Append(PortVariable.PortDyeOne + "P" + ((int)(scale * 0.05)).ToString());//吸入0.05mL邻苯基苯酚
                sb.Append(PortVariable.PortDyeTwo + "P" + ((int)(scale * 0.05)).ToString());//吸入0.05mL二氯乙氰尿酸钠
                sb.Append(PortVariable.PortDyeThree + "P" + ((int)(scale * 0.5)).ToString());//吸入0.05mL硝普钠
                sb.Append(_speed3);//速度设置为3000
                if (i == 0 && StandSolution.StandSol1 == 0)
                    sb.Append("P" + ((int)(0.9375 * scale)).ToString());//若i=0(浓度为0)，则吸入0.9375mL超纯水
                else
                    sb.Append(PortVariable.PortPureWater + "P" + ((int)((0.15625 - solutionArray[i] * 0.15625) * scale)).ToString());
                sb.Append("g");//添加循环头
                sb.Append("O" + PortVariable.PortHeater + "A0");//把1.7125mL混合液推进加热棒
                sb.Append("I" + PortVariable.PortHeater + "A2055");//把1.7125mL混合液吸进注射器
                sb.Append("G2");//添加循环尾，循环2次
                sb.Append("O" + PortVariable.PortHeater + "A0");//把1.7125mL混合液推进加热棒
                sb.Append("M90000");//在加热棒中加热反应90秒
                sb.Append("I" + PortVariable.PortHeater + "A2400");//从加热棒中洗出2mL混合液（包含空气）
                sb.Append(PortVariable.PortWasteLiquid + "D" + ((int)(scale * 0.5)).ToString());//废液口排出0.5mL
                sb.Append(_speed2);//速度设置为2100
                sb.Append(PortVariable.PortReactionTank + "A0R");//全部排入流通池，本条指令结束
                cmdMixed[i] = sb.ToString();
            }
            return cmdMixed;
        }
    }
    #endregion

    #region 磷酸盐
    public class CmdPhosphate
    {
        private int scale = 1200;//1200步/mL
        private string _speed1 = "V500";
        private string _speed2 = "V1500";
        private string _speed3 = "V3000";
        private string _speed4 = "V6000";
        public static double[] solutionArray2 = new double[StandSolution.StandNumber];
        public string GetCmdWash()
        {
            StringBuilder sbWash = new StringBuilder();
            sbWash.Append("g");//添加循环头
            sbWash.Append(_speed3);//设置速度3000
            sbWash.Append(PortVariable.PortPureWater + "A3000");//吸入纯水2.5mL
            sbWash.Append(_speed2);//设置速度2100
            sbWash.Append(PortVariable.PortWasteLiquid + "A2400");//废液口排出0.5mL
            sbWash.Append(_speed4);//设置速度6000
            sbWash.Append(PortVariable.PortReactionTank + "A0");//流通池口排出2mL
            sbWash.Append("G3R");//添加循环尾，循环3次，指令结束
            return sbWash.ToString();
        }
        public string GetCmdInit()
        {
            //管路填充，防止首次标定吸入过量空气
            StringBuilder sbInit = new StringBuilder();
            sbInit.Append("V2000");//设置速度2000
            sbInit.Append(PortVariable.PortSample + "P60");//吸入0.05mL样品，填充样品管路
            sbInit.Append(PortVariable.PortDyeOne + "P60");//吸入0.05mLSAM，填充SAM管路
            sbInit.Append(PortVariable.PortDyeTwo + "P60");//吸入0.05mLNED，填充NED管路
            sbInit.Append(PortVariable.PortWasteLiquid + "A0R");//混合液全部从废液口排出，本条指令结束
            return sbInit.ToString();
        }
        public string[] GetCmdMixed()
        {
            StringBuilder sb = new StringBuilder();
            List<int> solutionList = new List<int>();
            solutionList.Add(StandSolution.StandSol1);
            solutionList.Add(StandSolution.StandSol2);
            solutionList.Add(StandSolution.StandSol3);
            solutionList.Add(StandSolution.StandSol4);
            solutionList.Add(StandSolution.StandSol5);
            int[] solutionArray = solutionList.ToArray();
            string[] cmdMixed = new string[StandSolution.StandNumber];
            for (int i = 0; i < StandSolution.StandNumber; i++)
            {
                sb.Clear();
                sb.Append(PortVariable.PortPureWater);
                sb.Append(_speed2);//速度设置为1500
                if (i == 0 && StandSolution.StandSol1 == 0)
                    sb.Append("P" + ((int)(1.2 * scale)).ToString());//若i=0(浓度为0)，则吸入1.2mL超纯水
                else
                    sb.Append("P" + ((int)(solutionArray[i] * 0.12 * scale)).ToString());//吸入样品 
                sb.Append(_speed1);//速度设置为500
                sb.Append(PortVariable.PortDyeTwo + "P" + ((int)(scale * 0.05)).ToString());//吸入0.05mL钼酸铵混合液
                sb.Append(PortVariable.PortDyeOne + "P" + ((int)(scale * 0.05)).ToString());//吸入0.05mL抗坏血酸
                sb.Append(_speed3);//速度设置为3000
                sb.Append(PortVariable.PortPureWater + "A3000");//吸入纯水至量程最大
                sb.Append("M15000");//延时15秒
                sb.Append(PortVariable.PortWasteLiquid + "D" + ((int)(scale * 0.5)).ToString());//废液口排出0.5mL
                sb.Append(_speed4);//速度设置为6000
                sb.Append(PortVariable.PortReactionTank + "A0R");//全部排入流通池，本条指令结束
                cmdMixed[i] = sb.ToString();
            }
            return cmdMixed;
        }
    }
    #endregion

    #region 硅酸盐
    public class CmdSilicate
    {
        private int scale = 1200;//1200步/mL
        private string _speed1 = "V500";
        private string _speed2 = "V1500";
        private string _speed3 = "V3000";
        private string _speed4 = "V6000";
        public static double[] solutionArray2 = new double[StandSolution.StandNumber];
        public string GetCmdWash()
        {
            StringBuilder sbWash = new StringBuilder();
            sbWash.Append("g");//添加循环头
            sbWash.Append(_speed3);//设置速度3000
            sbWash.Append(PortVariable.PortPureWater + "A3000");//吸入纯水2.5mL
            sbWash.Append(_speed2);//设置速度2100
            sbWash.Append(PortVariable.PortWasteLiquid + "A2400");//废液口排出0.5mL
            sbWash.Append(_speed4);//设置速度6000
            sbWash.Append(PortVariable.PortReactionTank + "A0");//流通池口排出2mL
            sbWash.Append("G3R");//添加循环尾，循环3次，指令结束
            return sbWash.ToString();
        }
        public string GetCmdInit()
        {
            //管路填充，防止首次标定吸入过量空气
            StringBuilder sbInit = new StringBuilder();
            sbInit.Append("V2000");//设置速度2000
            sbInit.Append(PortVariable.PortSample + "P60");//吸入0.05mL样品，填充样品管路
            sbInit.Append(PortVariable.PortDyeOne + "P60");//吸入0.05mLSAM，填充SAM管路
            sbInit.Append(PortVariable.PortDyeTwo + "P60");//吸入0.05mLNED，填充NED管路
            sbInit.Append(PortVariable.PortWasteLiquid + "A0R");//混合液全部从废液口排出，本条指令结束
            return sbInit.ToString();
        }
        public string[] GetCmdMixed()
        {
            StringBuilder sb = new StringBuilder();
            List<int> solutionList = new List<int>();
            solutionList.Add(StandSolution.StandSol1);
            solutionList.Add(StandSolution.StandSol2);
            solutionList.Add(StandSolution.StandSol3);
            solutionList.Add(StandSolution.StandSol4);
            solutionList.Add(StandSolution.StandSol5);
            int[] solutionArray = solutionList.ToArray();
            string[] cmdMixed = new string[StandSolution.StandNumber];
            for (int i = 0; i < StandSolution.StandNumber; i++)
            {
                sb.Clear();
                sb.Append(PortVariable.PortPureWater);
                sb.Append(_speed2);//速度设置为1500
                if (i == 0 && StandSolution.StandSol1 == 0)
                    sb.Append("P" + ((int)(0.5 * scale)).ToString());//若i=0(浓度为0)，则吸入0.5mL超纯水
                else
                    sb.Append("P" + ((int)(solutionArray[i] * 0.1 * scale)).ToString());//吸入样品
                sb.Append(_speed1);//速度设置为500
                sb.Append(PortVariable.PortDyeTwo + "P" + ((int)(scale * 0.2)).ToString());//吸入0.2mL钼酸盐
                sb.Append(PortVariable.PortDyeOne + "P" + ((int)(scale * 0.05)).ToString());//吸入0.05mL抗坏血酸
                sb.Append(_speed3);//速度设置为3000
                if (i == 0 && StandSolution.StandSol1 == 0)
                    sb.Append("P" + ((int)(0.5 * scale)).ToString());//若i=0(浓度为0)，则吸入0.5mL超纯水
                else
                    sb.Append(PortVariable.PortPureWater + "P" + ((int)((1 - solutionArray[i] * 0.1) * scale)).ToString());
                sb.Append("M360000");//延时360秒
                sb.Append(PortVariable.PortWasteLiquid + "D" + ((int)(scale * 0.25)).ToString());//废液口排出0.25mL
                sb.Append(_speed4);//速度设置为6000
                sb.Append(PortVariable.PortReactionTank + "A0R");//全部排入流通池，本条指令结束
                cmdMixed[i] = sb.ToString();
            }
            return cmdMixed;
        }
    }
    #endregion
}
