
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

using Modbus;

namespace 流量计检定上位机
{
    class ComWithS71200DB
    {

        public ComWithS71200DB()
        {
            TypeList.Add(Data0.GetType().ToString());
            TypeList.Add(Data1.GetType().ToString());
            TypeList.Add(Data2.GetType().ToString());
            TypeList.Add(Data3.GetType().ToString());
            TypeList.Add(Data4.GetType().ToString());
            TypeList.Add(Data5.GetType().ToString());
            TypeList.Add(Data6.GetType().ToString());
            TypeList.Add(Data7.GetType().ToString());
            TypeList.Add(Data8.GetType().ToString());
            TypeList.Add(Data9.GetType().ToString());
            TypeList.Add(Data10.GetType().ToString());
            TypeList.Add(Data11.GetType().ToString());
            TypeList.Add(Data12.GetType().ToString());
            TypeList.Add(Data13.GetType().ToString());
            TypeList.Add(Data14.GetType().ToString());
            TypeList.Add(Data15.GetType().ToString());
            TypeList.Add(Data16.GetType().ToString());
            TypeList.Add(Data17.GetType().ToString());
            TypeList.Add(Data18.GetType().ToString());
            TypeList.Add(Data19.GetType().ToString());
            TypeList.Add(Data20.GetType().ToString());
            TypeList.Add(Data21.GetType().ToString());
            TypeList.Add(Data22.GetType().ToString());
            TypeList.Add(Data23.GetType().ToString());
            TypeList.Add(Data24.GetType().ToString());
            TypeList.Add(Data25.GetType().ToString());
            TypeList.Add(Data26.GetType().ToString());
            TypeList.Add(Data27.GetType().ToString());
            TypeList.Add(Data28.GetType().ToString());
            TypeList.Add(Data29.GetType().ToString());
            TypeList.Add(Data30.GetType().ToString());
            TypeList.Add(Data31.GetType().ToString());
            TypeList.Add(Data32.GetType().ToString());
            TypeList.Add(Data33.GetType().ToString());
            TypeList.Add(Data34.GetType().ToString());
            TypeList.Add(Data35.GetType().ToString());
            TypeList.Add(Data36.GetType().ToString());
            TypeList.Add(Data37.GetType().ToString());
            TypeList.Add(Data38.GetType().ToString());
            TypeList.Add(Data39.GetType().ToString());
            TypeList.Add(Data40.GetType().ToString());
            TypeList.Add(Data41.GetType().ToString());
            TypeList.Add(Data42.GetType().ToString());
            TypeList.Add(Data43.GetType().ToString());
            TypeList.Add(Data44.GetType().ToString());
            TypeList.Add(Data45.GetType().ToString());
            TypeList.Add(Data46.GetType().ToString());
            TypeList.Add(Data47.GetType().ToString());
            TypeList.Add(Data48.GetType().ToString());
            TypeList.Add(Data49.GetType().ToString());
            TypeList.Add(Data50.GetType().ToString());
            TypeList.Add(Data51.GetType().ToString());
            TypeList.Add(Data52.GetType().ToString());
            TypeList.Add(Data53.GetType().ToString());
            TypeList.Add(Data54.GetType().ToString());
            TypeList.Add(Data55.GetType().ToString());
            TypeList.Add(Data56.GetType().ToString());
            TypeList.Add(Data57.GetType().ToString());
            TypeList.Add(Data58.GetType().ToString());
            TypeList.Add(Data59.GetType().ToString());
            TypeList.Add(Data60.GetType().ToString());
            TypeList.Add(Data61.GetType().ToString());
            TypeList.Add(Data62.GetType().ToString());
            TypeList.Add(Data63.GetType().ToString());
            TypeList.Add(Data64.GetType().ToString());
            TypeList.Add(Data65.GetType().ToString());
            TypeList.Add(Data66.GetType().ToString());
            TypeList.Add(Data67.GetType().ToString());
            TypeList.Add(Data68.GetType().ToString());
            TypeList.Add(Data69.GetType().ToString());
            TypeList.Add(Data70.GetType().ToString());
            TypeList.Add(Data71.GetType().ToString());
            TypeList.Add(Data72.GetType().ToString());
            TypeList.Add(Data73.GetType().ToString());
            TypeList.Add(Data74.GetType().ToString());
            TypeList.Add(Data75.GetType().ToString());
            TypeList.Add(Data76.GetType().ToString());
            TypeList.Add(Data77.GetType().ToString());
            TypeList.Add(Data78.GetType().ToString());
            TypeList.Add(Data79.GetType().ToString());
            TypeList.Add(Data80.GetType().ToString());
            TypeList.Add(Data81.GetType().ToString());
            TypeList.Add(Data82.GetType().ToString());
            TypeList.Add(Data83.GetType().ToString());
            TypeList.Add(Data84.GetType().ToString());
            TypeList.Add(Data85.GetType().ToString());
            TypeList.Add(Data86.GetType().ToString());
            TypeList.Add(Data87.GetType().ToString());
            TypeList.Add(Data88.GetType().ToString());
            TypeList.Add(Data89.GetType().ToString());
            TypeList.Add(Data90.GetType().ToString());
            TypeList.Add(Data91.GetType().ToString());
            TypeList.Add(Data92.GetType().ToString());
            TypeList.Add(Data93.GetType().ToString());
            TypeList.Add(Data94.GetType().ToString());
            TypeList.Add(Data95.GetType().ToString());
            TypeList.Add(Data96.GetType().ToString());
            TypeList.Add(Data97.GetType().ToString());
            TypeList.Add(Data98.GetType().ToString());
            TypeList.Add(Data99.GetType().ToString());
            TypeList.Add(Data100.GetType().ToString());

            DataList.Add(Data0);
            DataList.Add(Data1);
            DataList.Add(Data2);
            DataList.Add(Data3);
            DataList.Add(Data4);
            DataList.Add(Data5);
            DataList.Add(Data6);
            DataList.Add(Data7);
            DataList.Add(Data8);
            DataList.Add(Data9);
            DataList.Add(Data10);
            DataList.Add(Data11);
            DataList.Add(Data12);
            DataList.Add(Data13);
            DataList.Add(Data14);
            DataList.Add(Data15);
            DataList.Add(Data16);
            DataList.Add(Data17);
            DataList.Add(Data18);
            DataList.Add(Data19);
            DataList.Add(Data20);
            DataList.Add(Data21);
            DataList.Add(Data22);
            DataList.Add(Data23);
            DataList.Add(Data24);
            DataList.Add(Data25);
            DataList.Add(Data26);
            DataList.Add(Data27);
            DataList.Add(Data28);
            DataList.Add(Data29);
            DataList.Add(Data30);
            DataList.Add(Data31);
            DataList.Add(Data32);
            DataList.Add(Data33);
            DataList.Add(Data34);
            DataList.Add(Data35);
            DataList.Add(Data36);
            DataList.Add(Data37);
            DataList.Add(Data38);
            DataList.Add(Data39);
            DataList.Add(Data40);
            DataList.Add(Data41);
            DataList.Add(Data42);
            DataList.Add(Data43);
            DataList.Add(Data44);
            DataList.Add(Data45);
            DataList.Add(Data46);
            DataList.Add(Data47);
            DataList.Add(Data48);
            DataList.Add(Data49);
            DataList.Add(Data50);
            DataList.Add(Data51);
            DataList.Add(Data52);
            DataList.Add(Data53);
            DataList.Add(Data54);
            DataList.Add(Data55);
            DataList.Add(Data56);
            DataList.Add(Data57);
            DataList.Add(Data58);
            DataList.Add(Data59);
            DataList.Add(Data60);
            DataList.Add(Data61);
            DataList.Add(Data62);
            DataList.Add(Data63);
            DataList.Add(Data64);
            DataList.Add(Data65);
            DataList.Add(Data66);
            DataList.Add(Data67);
            DataList.Add(Data68);
            DataList.Add(Data69);
            DataList.Add(Data70);
            DataList.Add(Data71);
            DataList.Add(Data72);
            DataList.Add(Data73);
            DataList.Add(Data74);
            DataList.Add(Data75);
            DataList.Add(Data76);
            DataList.Add(Data77);
            DataList.Add(Data78);
            DataList.Add(Data79);
            DataList.Add(Data80);
            DataList.Add(Data81);
            DataList.Add(Data82);
            DataList.Add(Data83);
            DataList.Add(Data84);
            DataList.Add(Data85);
            DataList.Add(Data86);
            DataList.Add(Data87);
            DataList.Add(Data88);
            DataList.Add(Data89);
            DataList.Add(Data90);
            DataList.Add(Data91);
            DataList.Add(Data92);
            DataList.Add(Data93);
            DataList.Add(Data94);
            DataList.Add(Data95);
            DataList.Add(Data96);
            DataList.Add(Data97);
            DataList.Add(Data98);
            DataList.Add(Data99);
            DataList.Add(Data100);
        }

        int ComDataNum = 64;
        int ByteOffsetTotal { get { return getDataOffset(ComDataNum); } }
        byte WordDataNumber {get {return (byte)(ByteOffsetTotal/2);}}
        const int SlaveID = 1;

        List<string> TypeList = new List<string>();
        public List<object> DataList = new List<object>();
        //类型必须与DB块中对应，否则会出现错误

        // FROM PLC
        short Data0 { get; set; }    //状态字
        short Data1 { get; set; } = 666;   //服务器通信状态字
        short Data2 { get; set; } = 666;   //初始化串口状态字
        short Data3 { get; set; } = 666;   //工作表通信状态字
        short Data4 { get; set; } = 666;   //标准表通信状态字
        Single Data5 { get; set; }   //工作表诊断数据1
        Single Data6 { get; set; }   //工作表诊断数据2
        Single Data7 { get; set; }   //工作表诊断数据3
        Single Data8 { get; set; }   //工作表诊断数据4
        Single Data9 { get; set; }   //工作表诊断数据5
        Single Data10 { get; set; }  //工作表诊断数据6
        Single Data11 { get; set; }  //工作表诊断数据7
        Single Data12 { get; set; }  //工作表诊断数据8
        Single Data13 { get; set; }  //工作表诊断数据9
        Single Data14 { get; set; }  //工作表诊断数据10
        Single Data15 { get; set; }  //标准表诊断数据1
        Single Data16 { get; set; }  //标准表诊断数据2
        Single Data17 { get; set; }  //标准表诊断数据3
        Single Data18 { get; set; }  //标准表诊断数据4
        Single Data19 { get; set; }  //标准表诊断数据5
        Single Data20 { get; set; }  //标准表诊断数据6
        Single Data21 { get; set; }  //标准表诊断数据7
        Single Data22 { get; set; }  //标准表诊断数据8
        Single Data23 { get; set; }  //标准表诊断数据9
        Single Data24 { get; set; }  //标准表诊断数据10
        Int32 Data25 { get; set; } = 50000; //工作表脉冲数1
        Int32 Data26 { get; set; } = 50000; //工作表脉冲数2
        Int32 Data27 { get; set; } = 50000; //工作表脉冲数3
        Int32 Data28 { get; set; } = 50000; //工作表脉冲数4
        Int32 Data29 { get; set; } = 50000; //工作表脉冲数5
        Int32 Data30 { get; set; } = 50000; //工作表脉冲数6
        Int32 Data31 { get; set; } = 50000; //工作表脉冲数7
        Int32 Data32 { get; set; } = 50000; //工作表脉冲数8
        Int32 Data33 { get; set; } = 50000; //工作表脉冲数9
        Int32 Data34 { get; set; } = 50000; //工作表脉冲数10
        Int32 Data35 { get; set; } = 50000; //工作表脉冲数11
        Int32 Data36 { get; set; } = 50000; //工作表脉冲数12
        Int32 Data37 { get; set; } = 50000; //标准表脉冲数1
        Int32 Data38 { get; set; } = 50000; //标准表脉冲数2
        Int32 Data39 { get; set; } = 50000; //标准表脉冲数3
        Int32 Data40 { get; set; } = 50000; //标准表脉冲数4
        Int32 Data41 { get; set; } = 50000; //标准表脉冲数5 
        Int32 Data42 { get; set; } = 50000; //标准表脉冲数6
        Int32 Data43 { get; set; } = 50000; //标准表脉冲数7
        Int32 Data44 { get; set; } = 50000; //标准表脉冲数8
        Int32 Data45 { get; set; } = 50000; //标准表脉冲数9
        Int32 Data46 { get; set; } = 50000; //标准表脉冲数10
        Int32 Data47 { get; set; } = 50000; //标准表脉冲数11
        Int32 Data48 { get; set; } = 50000; //标准表脉冲数12
        short Data49 { get; set; }  //采集当前次数
        short Data50 { get; set; }  //当前次采集时间
        Int32 Data51 { get; set; }  //工作表脉冲
        Int32 Data52 { get; set; }  //标准表脉冲
        short Data53 { get; set; }  //Reserved
        short Data54 { get; set; }  //Reserved
        short Data55 { get; set; }  //Reserved
        short Data56 { get; set; }  //Reserved
        short Data57 { get; set; }  //Reserved
        short Data58 { get; set; }  //Reserved
        short Data59 { get; set; }  //Reserved
        // to PLC
        short Data60 { get; set; }  //控制字
        short Data61 { get; set; }  //检定次数
        short Data62 { get; set; }  //检定时间
        short Data63 { get; set; }  //间隔时间
        Int16 Data64 { get; set; }  //Reserved
        Int16 Data65 { get; set; }
        Int16 Data66 { get; set; }
        Int16 Data67 { get; set; }
        Int16 Data68 { get; set; }
        Int16 Data69 { get; set; }
        Int16 Data70 { get; set; }
        Int16 Data71 { get; set; }
        Int16 Data72 { get; set; }
        Int16 Data73 { get; set; }
        Int16 Data74 { get; set; }
        Int16 Data75 { get; set; }
        Int16 Data76 { get; set; }
        Int16 Data77 { get; set; }
        Int16 Data78 { get; set; }
        Int16 Data79 { get; set; }
        Int16 Data80 { get; set; }
        Int16 Data81 { get; set; }
        Int16 Data82 { get; set; }
        Int16 Data83 { get; set; }
        Int16 Data84 { get; set; }
        Int16 Data85 { get; set; }
        Int16 Data86 { get; set; }
        Int16 Data87 { get; set; }
        Int16 Data88 { get; set; }
        Int16 Data89 { get; set; }
        Int16 Data90 { get; set; }
        Int16 Data91 { get; set; }
        Int16 Data92 { get; set; }
        Int16 Data93 { get; set; }
        Int16 Data94 { get; set; }
        Int16 Data95 { get; set; }
        Int16 Data96 { get; set; }
        Int16 Data97 { get; set; }
        Int16 Data98 { get; set; }
        Int16 Data99 { get; set; }
        Int16 Data100 { get; set; }

        public byte[] DataByte
        {
            set
            {
                int lenth = value.Length;
                if (lenth < ByteOffsetTotal) return;
                int index = 0;int count = WordDataNumber;
                for(int i = 0; i<count;i++)
                {
                    switch (TypeList[i])
                    {
                            
                        case "System.Byte":
                            DataList[i] = value[index];index++; break;
                        case "System.Int16": DataList[i] = BitConverterHelper.ToInt16(value, index); index += 2; break;
                        case "System.Int32": DataList[i] = BitConverterHelper.ToInt32(value, index); index += 4; break;
                        case "System.Single": DataList[i] = BitConverterHelper.ToSingle(value, index); index += 4; break;
                        default: throw new Exception("Type is not correct!");
                    }
                    if (index >= lenth)
                        break;
                }
            }
        }
        
        int getDataOffset(int index)
        {
            int offset = 0;
            for(int i = 0;i<index ;++i)
            {
                switch (TypeList[i])
                {
                    case "System.Byte": offset += 1; break;
                    case "System.Int16":; offset += 2; break;
                    case "System.Int32":; offset += 4; break;
                    case "System.Single":; offset += 4; break;
                    default: throw new Exception("Type is not correct!");
                }
            }
            return offset;
        }

        /// <summary>
        /// 获取PLC中ModbusTCP HoldReg DB块 第index个数的大小，可以是任意类型
        /// </summary>
        public object GetVal(int index)
        {
            return DataList[index];
        }
        /// <summary>
        /// 设置PLC中ModbusTCP HoldReg DB块 第index个数的大小，可以是任意类型
        /// </summary>
        public bool SetVal(int index,float val, ModbusTCPMaster MBmaster)
        {
            byte[] bytes;
            switch (TypeList[index])
            {
                case "System.Byte":
                    var data1 = (byte)val;
                    bytes = new byte[] { data1 };
                    break;
                case "System.Int16":
                    var data2 = (Int16)val;
                    bytes = BitConverterHelper.Int16ToBytes(data2);
                    break;
                case "System.Int32":
                    var data3 = (Int32)val;
                    bytes = BitConverterHelper.Int32ToBytes(data3);
                    break;
                case "System.Single":
                    var data4 = (Single)val;
                    bytes = BitConverterHelper.SingleToBytes(data4);
                    break;
                default: throw new Exception("Type is not correct!");
            }
            ushort address = (ushort)(getDataOffset(index) / 2);
            MBmaster?.WriteMultipleRegister(ModbusTCPMaster.WriteMultipleRegisterFucID, SlaveID, address, bytes);
            Thread.Sleep(20);
            return true;
        }

        public bool SetVals(int startindex,float[] vals, ModbusTCPMaster MBmaster)
        {
            byte[] bytes;
            byte[] returnbytes = { };
            int count = vals.Length;
            for(int i = 0; i<count;++i)
            {
                switch (TypeList[startindex + i])
                {
                    case "System.Byte":
                        var data1 = (byte)vals[i];
                        bytes = new byte[] { data1 };
                        break;
                    case "System.Int16":
                        var data2 = (Int16)vals[i];
                        bytes = BitConverterHelper.Int16ToBytes(data2);
                        break;
                    case "System.Int32":
                        var data3 = (Int32)vals[i];
                        bytes = BitConverterHelper.Int32ToBytes(data3);
                        break;
                    case "System.Single":
                        var data4 = (Single)vals[i];
                        bytes = BitConverterHelper.SingleToBytes(data4);
                        break;
                    default: throw new Exception("Type is not correct!");
                }
                returnbytes = BitConverterHelper.BytesConnect(returnbytes, bytes);
            }

            ushort address = (ushort)(getDataOffset(startindex) / 2);
            MBmaster?.WriteMultipleRegister(ModbusTCPMaster.WriteMultipleRegisterFucID, SlaveID, address, returnbytes);
            Thread.Sleep(20);
            return true;
        }

        private void ModbusTCPReadHoldReg(byte Lenth, ushort StartAddress, ModbusTCPMaster MBmaster)
        {
            ushort ID = ModbusTCPMaster.ReadHoldingRegisterFucID;
            byte unit = SlaveID;
            MBmaster?.ReadHoldingRegister(ID, unit, StartAddress, Lenth);
        }

        public void ReadAllDB(ModbusTCPMaster MBmaster)
        {
            ModbusTCPReadHoldReg(WordDataNumber, 0,MBmaster);
        }

    }
}
