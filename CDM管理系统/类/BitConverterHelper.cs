using System;
using System.Collections.Generic;
using System.Text;

namespace 流量计检定上位机
{
    public class BitConverterHelper
    {
        public static Int16 ToInt16(byte[] values,int startindex)
        {
            byte[] bytes = { values[startindex + 1], values[startindex] };
            return BitConverter.ToInt16(bytes, 0);
        }
        public static Int32 ToInt32(byte[] values, int startindex)
        {
            byte[] bytes = { values[startindex + 3], values[startindex+2],values[startindex + 1], values[startindex] };
            return BitConverter.ToInt32(bytes, 0);
        }
        public static Single ToSingle(byte[] values, int startindex)
        {
            byte[] bytes = { values[startindex + 1], values[startindex + 0], values[startindex + 3], values[startindex + 2 ] };
            return BitConverter.ToSingle(bytes, 0);
        }
          
        public static byte[] Int16ToBytes(Int16 data)
        {
            byte[] bytes = new byte[2];
            byte[] tmp = BitConverter.GetBytes(data);
            bytes[0] = tmp[1];
            bytes[1] = tmp[0];
            return bytes;
        }

        public static byte[] Int32ToBytes(Int32 data)
        {
            byte[] bytes = new byte[4];
            byte[] tmp = BitConverter.GetBytes(data);
            bytes[0] = tmp[3];
            bytes[1] = tmp[2];
            bytes[2] = tmp[1];
            bytes[3] = tmp[0];
            return bytes;
        }

        public static byte[] SingleToBytes(Single data)
        {
            byte[] bytes = new byte[4];
            byte[] tmp = BitConverter.GetBytes(data);
            bytes[0] = tmp[3];
            bytes[1] = tmp[2];
            bytes[2] = tmp[1];
            bytes[3] = tmp[0];
            return bytes;
        }

        public static byte[] BytesConnect(byte[] one, byte[] two)
        {
            byte[] goal = new byte[one.Length + two.Length];
            for (int i = 0; i < one.Length; ++i)
                goal[i] = one[i];
            for (int i = 0; i < two.Length; ++i)
                goal[i + one.Length] = two[i];
            return goal;
        }

        public static byte[] BytesConnect(byte[] one, byte[] two,byte[] three)
        {
            byte[] goal = new byte[one.Length + two.Length + three.Length];
            for (int i = 0; i < one.Length; ++i)
                goal[i] = one[i];
            for (int i = 0; i <  two.Length; ++i)
                goal[i + one.Length] = two[i];
            for (int i = 0; i <  three.Length; ++i)
                goal[i + one.Length + two.Length] = three[i];
            return goal;
        }

        public static short BoolToShort(bool val)
        {
            if (val == true)
                return 1;
            return 0;
        }

    }
}
