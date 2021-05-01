
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace iDAQ
{
    public class iDAQ6009Base
    {
        int DeviceHandle;

        #region DLL
        [DllImport("idaq.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int AddRequest(int Handle, int IOType, int Channel, double Value, int x1, double UserData);
        [DllImport("idaq.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int CloseDAQDevice(int pHandle);
        [DllImport("idaq.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int eAIN(int Handle, int ChannelP, int ChannelN, ref double pVoltage, int Range, int Resolution, int Settling, int Binary = 0, int Reserved1 = 0, int Reserved2 = 0);
        [DllImport("idaq.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int eConfigNV(int Handle, int DIOMask, int DIODir, int DIOState);
        [DllImport("idaq.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int eConfigPWM(int Handle, int Channel, int Frequence, int DutyCycle, int RepeatNumber);
        [DllImport("idaq.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int eDAC(int Handle, int Channel, double Voltage, int Binary = 0, int Reserved1 = 0, int Reserved2 = 0);
        [DllImport("idaq.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int eDI(int Handle, int Channel, ref int State);
        [DllImport("idaq.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int eDO(int Handle, int Channel, int State);
        [DllImport("idaq.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int eGet(int Handle, int IOType, int Channel, ref double pValue, int x1);
        [DllImport("idaq.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int ePut(int Handle, int IOType, int Channel, double Value, int x1);
        [DllImport("idaq.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int eStartPWM(int Handle, int Channel, int StartFlag);
        [DllImport("idaq.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern double GetDriverVersion();
        [DllImport("idaq.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int GetResult(int Handle, int IOType, int Channel, ref double pValue);
        [DllImport("idaq.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int GoOne(int Handle);
        [DllImport("idaq.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int ListAll(int DeviceType, int ConnectionType, ref int pNumFound, ref int pSerialNumbers, ref int pIDs, ref double pAddresses);
        [DllImport("idaq.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int OpenDAQDevice(int DeviceType, int ConnectionType, [MarshalAs(UnmanagedType.LPStr)] string pAddress, int FirstFound, ref int pHandle);
        [DllImport("idaq.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int ResetDAQDevice(int pHandle);
        #endregion

        public bool GetiDAQDeviceNumber(ref int ID)
        {
            try
            {
                int[] serial = new int[128];
                int[] pid = new int[128];
                double[] address = new double[128];

                int status = ListAll(1, 1, ref ID, ref serial[0], ref pid[0], ref address[0]);

                if (status != 0)
                    return false;


                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        // <summary>
        // Obtem informações do dispositivo
        // </summary>
        // <param name="Version">Retorna informações do dispositivo</param>
        // <returns></returns>
        public bool GetiDAQDriverVersion(ref string Version)
        {
            try
            {
                StringBuilder s = new StringBuilder();
                double ver = 0;

                //Read and display the USB DAQ Driver version.
                double dblDriverVersion = GetDriverVersion();
                s.AppendFormat("USB DAQ Driver Version = {0}\n", dblDriverVersion);
                eGet(DeviceHandle, 1001, 0, ref ver, 0);
                s.AppendFormat("Device Local ID =  {0}\n", ver);
                eGet(DeviceHandle, 1001, 10, ref ver, 0);
                s.AppendFormat("Device Hardware Version  =  {0}.{1}\n", (int)(((int)ver & 0xFF00) >> 8), (int)((int)ver & 0x00FF));
                eGet(DeviceHandle, 1001, 12, ref ver, 0);
                s.AppendFormat("Serial Number =  {0}\n", Convert.ToString(Convert.ToInt64(ver), 16));
                eGet(DeviceHandle, 1001, 11, ref ver, 0);
                s.AppendFormat("Device Firmware Version  =  {0}.{1}\n", (int)(((int)ver & 0xFF00) >> 8), (int)((int)ver & 0x00FF));
                eGet(DeviceHandle, 1001, 8, ref ver, 0);
                s.AppendFormat("Device Product ID =  {0}\n", ver);
                eGet(DeviceHandle, 1001, 15, ref ver, 0);
                s.AppendFormat("Device Bootloader Version  =   {0}.{1}\n", (int)(((int)ver & 0xFF00) >> 8), (int)((int)ver & 0x00FF));
                Version = s.ToString();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        // <summary>
        // Liga o dispositivo
        // </summary>
        // <param name="DeviceID">ID do equipamento</param>
        // <returns></returns>
        public bool OpeniDAQDevice(int DeviceID)
        {
            try
            {
                int status = 0;

                if (DeviceID == 0)
                    status = OpenDAQDevice(1, 1, "1", 1, ref DeviceHandle);
                else
                    status = OpenDAQDevice(1, 1, DeviceID.ToString(), 0, ref DeviceHandle);

                if (status != 0)
                    return false;

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }

        // <summary>
        // Desliga o aparelho
        // </summary>
        // <returns></returns>
        public bool CloseiDAQDevice()
        {
            try
            {
                int status = 0;

                if (DeviceHandle == 0)
                {
                    throw new Exception("Device Not open");
                }

                status = CloseDAQDevice(DeviceHandle);
                DeviceHandle = 0;

                if (status != 0)
                    return false;

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        // <summary>
        // Reinicia o dispositivo - Reset
        // </summary>
        // <returns></returns>
        public bool ResetiDAQDevice()
        {
            try
            {
                int status = 0;

                if (DeviceHandle == 0)
                {
                    throw new Exception("Device Not open");
                }

                status = ResetDAQDevice(DeviceHandle);

                if (status != 0)
                    return false;

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        // <summary>
        // Lê um canal de entrada digital
        // </summary>
        // <param name="ChannelNumber">Especifique o número do canal</param>
        // <returns></returns>
        public int ReadiDAQDeviceDI(int ChannelNumber)
        {
            try
            {
                int status = 0;
                int val = 0;

                if (DeviceHandle == 0)
                {
                    throw new Exception("Device Not open");
                }

                if (ChannelNumber < 0 || ChannelNumber > 7)
                {
                    throw new Exception("ChannelNumber is invalid");
                }

                status = eDI(DeviceHandle, ChannelNumber, ref val);

                if (status != 0)
                    return -1;

                return val;
            }
            catch (Exception)
            {
                return -1;
            }

        }

        // <summary>
        // Escreve em uma saída digital
        // </summary>
        // <param name="ChannelNumber">Número do canal</param>
        // <param name="ONOFFtus">Especifica o tipo de saída 0=OFF,1=ON</param>
        // <returns></returns>
        public bool SetiDAQDeviceDO(int ChannelNumber, int ONOFF)
        {
            try
            {
                int status = 0;

                if (DeviceHandle == 0)
                {
                    throw new Exception("Device Not open");
                }

                if (ChannelNumber < 0 || ChannelNumber > 7)
                {
                    throw new Exception("ChannelNumber is invalid");
                }

                if (ONOFF != 1)
                    ONOFF = 0;

                status = eDO(DeviceHandle, ChannelNumber, ONOFF);

                if (status != 0)
                    return false;

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        // <summary>
        // Configura a direção do canal digital
        // </summary>
        // <param name="ChannelNumber">Número do canal</param>
        // <param name="Direction">Especifica a entrada e a saída 0 = entrada, 1 = saída</param>
        // <param name="ONOFFtus">Especifica o tipo de saída 0=OFF,1=ON</param>
        // <returns></returns>
        public bool ConfigiDAQDeviceDIO(int ChannelNumber, int Direction, int ONOFF)
        {
            try
            {
                int status = 0;

                if (DeviceHandle == 0)
                {
                    throw new Exception("Device Not open");
                }

                if (ChannelNumber < 0 || ChannelNumber > 255)
                {
                    throw new Exception("ChannelNumber is invalid");
                }


                status = eConfigNV(DeviceHandle, ChannelNumber, Direction, ONOFF);

                if (status != 0)
                    return false;

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        // <summary>
        // Lê todos os canais digitais
        // </summary>
        // <returns></returns>
        public int[] ReadiDAQDeviceDI()
        {
            int[] vals = new int[8] { -1, -1, -1, -1, -1, -1, -1, -1 };

            try
            {
                int status = 0;
                int val = 0;

                if (DeviceHandle == 0)
                {
                    throw new Exception("Device Not open");
                }

                for (int i = 0; i < 8; i++)
                {
                    status = eDI(DeviceHandle, i, ref val);
                    vals[i] = val;
                }


                if (status != 0)
                    return vals;

                return vals;
            }
            catch (Exception)
            {
                return vals;
            }

        }

        // <summary>
        // Configura uma saída analógica
        // </summary>
        // <param name="ChannelNumber">Número do canal</param>
        // <param name="Voltage">Voltagem 0-5V</param>
        // <returns></returns>
        public bool SetDAQDeviceAO(int ChannelNumber, double Voltage)
        {
            try
            {
                int status = 0;

                if (DeviceHandle == 0)
                {
                    throw new Exception("Aparelho não abre");
                }

                if (ChannelNumber < 0 || ChannelNumber > 1)
                {
                    throw new Exception("Canal inválido");
                }

                if (Voltage < 0 || Voltage > 5)
                {
                    throw new Exception("Voltagem inválida");
                }

                status = eDAC(DeviceHandle, ChannelNumber, Voltage);

                if (status != 0)
                    return false;

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        // <summary>
        // Lê a tensão em um canal analógico
        // </summary>
        // <param name="ChannelNumber">Número do canal</param>
        // <returns></returns>
        public double ReadDAQDeviceAISingle(int ChannelNumber)
        {
            double Voltage = -999;

            try
            {

                int status = 0;

                if (DeviceHandle == 0)
                {
                    throw new Exception("Aparelho não abre");
                }

                if (ChannelNumber < 0 || ChannelNumber > 7)
                {
                    throw new Exception("Número inválido para o canal");
                }

                status = eAIN(DeviceHandle, ChannelNumber, 31, ref Voltage, -1, -1, -1);

                if (status != 0)
                    return Voltage;

                return Voltage;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return Voltage;
            }

        }


        // <summary>
        // Lê uma entrada analógica diferencial
        // </summary>
        // <param name="ChannelNumber1">Número do canal 1</param>
        // <param name="ChannelNumber2">Número do canal 2</param>
        // <returns></returns>
        public double ReadDAQDeviceAIDiffence(int ChannelNumber1, int ChannelNumber2)
        {
            double Voltage = -999;

            try
            {

                int status = 0;

                if (DeviceHandle == 0)
                {
                    throw new Exception("Aparelho não abre");
                }

                if (ChannelNumber1 < 0 || ChannelNumber1 > 7)
                {
                    throw new Exception("Primeiro canal é inválido");
                }

                if (ChannelNumber2 < 0 || ChannelNumber2 > 7)
                {
                    throw new Exception("Segundo canal é inválido");
                }

                status = eAIN(DeviceHandle, ChannelNumber1, ChannelNumber2, ref Voltage, -1, -1, -1);

                if (status != 0)
                    return Voltage;

                return Voltage;
            }
            catch (Exception)
            {
                return Voltage;
            }

        }

        // <summary>
        // Gera uma onda PWM
        // </summary>
        // <param name="ChannelNumber">Número do canal</param>
        // <param name="Frequence">Frequência de saída</param>
        // <param name="DutyCycle">Ciclo de trabalho</param>
        // <param name="RepeatNumber">Número de repetições</param>
        // <returns></returns>
        public bool GeneratorPWM(int ChannelNumber, int Frequence, int DutyCycle, int RepeatNumber)
        {
            try
            {

                int status = 0;

                if (DeviceHandle == 0)
                {
                    throw new Exception("Aparelho não abre");
                }

                if (ChannelNumber < 0 || ChannelNumber > 7)
                {
                    throw new Exception("Número inválido para o canal");
                }

                status = eConfigPWM(DeviceHandle, ChannelNumber, Frequence, DutyCycle, RepeatNumber);

                status = eStartPWM(DeviceHandle, ChannelNumber, 1);

                if (status != 0)
                    return false;

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        // <summary>
        // Parar a forma de onda PWM
        // </summary>
        // <param name="ChannelNumber">Número do canal</param>
        // <returns></returns>
        public bool StopPWM(int ChannelNumber)
        {
            try
            {

                int status = 0;

                if (DeviceHandle == 0)
                {
                    throw new Exception("Aparelho não abre");
                }

                if (ChannelNumber < 0 || ChannelNumber > 7)
                {
                    throw new Exception("Número inválido para o canal");
                }

                status = eStartPWM(DeviceHandle, ChannelNumber, 0);

                if (status != 0)
                    return false;

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        // <summary>
        // Função de contagem
        // </summary>
        // <param name="ChannelNumber">Número do canal</param>
        // <param name="EdgeType">Tipo de borda: ascendente ou descendente</param>
        // <param name="CountTime">Tempo de espera ms</param>
        // <returns></returns>
        public double ReadiDAQDeviceCount(int EdgeType, int CountTime)
        {
            double Value = -999;
            try
            {
                int status = 0;

                if (EdgeType != 1)
                {
                    EdgeType = 0;
                }

                status = ePut(DeviceHandle, 2008, 0, 1, EdgeType);
                Task.Delay(CountTime);
                status = AddRequest(DeviceHandle, 50, 0, 0, 0, 0);
                status = GoOne(DeviceHandle);
                status = GetResult(DeviceHandle, 50, 0, ref Value);
                status = ePut(DeviceHandle, 2008, 0, 0, EdgeType);

                if (status != 0)
                    return Value;

                return Value;
            }
            catch (Exception)
            {
                return Value;
            }

        }

    }
}

