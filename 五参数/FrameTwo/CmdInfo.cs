using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameTwo
{
    public class CmdInfo
    {
        #region 单例
        private static CmdInfo instance = new CmdInfo();
        private CmdInfo() { }
        public static CmdInfo GetInstance()
        {
            return instance;
        }
        #endregion

        public OpenThermostat OpenThermostat { get; set; } = new OpenThermostat();
        public CloseThermostat CloseThermostat { get; set; } = new CloseThermostat();
        public GetvalueOfTankA GetvalueOfTankA { get; set; } = new GetvalueOfTankA();
        public ClosevalueOfTankA ClosevalueOfTankA { get; set; } = new ClosevalueOfTankA();
        public GetvalueOfTankB GetvalueOfTankB { get; set; } = new GetvalueOfTankB();
        public GetvalueOfTankDual GetvalueOfTankDual { get; set; } = new GetvalueOfTankDual();

        public PortNitrate portNitrate { get; set; } = new PortNitrate();
        public PortNitrite portNitrite { get; set; } = new PortNitrite();
        public PortAmmoniaNitrogen portAmmoniaNitrogen { get; set; } = new PortAmmoniaNitrogen();
        public PortPhosphate portPhosphate { get; set; } = new PortPhosphate();
        public PortSilicate portSilicate { get; set; } = new PortSilicate();
    }
}
