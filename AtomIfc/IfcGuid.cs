/*
    Copyright (c) 2022 Qonic
*/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtomIfc
{

    /// <summary>
    ///Based on : 
    ///https://technical.buildingsmart.org/resources/ifcimplementationguidance/ifc-guid/
    /// </summary>
    public static class IfcGuid
    {
        private static string cConversionTable = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz_$";
        
        //
        // Conversion of an integer into a number with base 64
        // using the coside table cConveronTable
        //
        private static string cv_to_64(uint number, int nDigits)
        {
            uint act;
            int iDigit;
            char[] result = new char[nDigits];

            act = number;

            for (iDigit = 0; iDigit < nDigits; iDigit++)
            {
                result[nDigits - iDigit - 1] = cConversionTable[(int)(act % 64)];
                act /= 64;
            }

            if (act != 0)
            {
                throw new ArgumentException("Number out of range");
            }

            return new string(result);
        }

        /// <summary>
        /// Conversion of a GUID to a string 
        /// representing the GUID 
        /// </summary>
        /// <param name="guid">The GUID to convert</param>
        /// <returns>IFC encoded GUID string</returns>
        public static string ToIfcGuid(Guid guid)
        {
            uint[] num = new uint[6];
            int i, n;

            byte[] comp = guid.ToByteArray();
            uint Data1 = BitConverter.ToUInt32(comp, 0);
            ushort Data2 = BitConverter.ToUInt16(comp, 4);
            ushort Data3 = BitConverter.ToUInt16(comp, 6);
            byte Data4_0 = comp[8];
            byte Data4_1 = comp[9];
            byte Data4_2 = comp[10];
            byte Data4_3 = comp[11];
            byte Data4_4 = comp[12];
            byte Data4_5 = comp[13];
            byte Data4_6 = comp[14];
            byte Data4_7 = comp[15];

            //
            // Creation of six 32 Bit integers from the components of the GUID structure
            //
            num[0] = (uint)(Data1 / 16777216);                                                 //    16. byte  (pGuid->Data1 / 16777216) is the same as (pGuid->Data1 >> 24)
            num[1] = (uint)(Data1 % 16777216);                                                 // 15-13. bytes (pGuid->Data1 % 16777216) is the same as (pGuid->Data1 & 0xFFFFFF)
            num[2] = (uint)(Data2 * 256 + Data3 / 256);                                 // 12-10. bytes
            num[3] = (uint)((Data3 % 256) * 65536 + Data4_0 * 256 + Data4_1);  // 09-07. bytes
            num[4] = (uint)(Data4_2 * 65536 + Data4_3 * 256 + Data4_4);       // 06-04. bytes
            num[5] = (uint)(Data4_5 * 65536 + Data4_6 * 256 + Data4_7);       // 03-01. bytes

            StringBuilder buf = new StringBuilder();

            //
            // Conversion of the numbers into a system using a base of 64
            //
            n = 2;
            for (i = 0; i < 6; i++)
            {
                string temp = cv_to_64(num[i], n);
                buf.Append(temp);
                n = 4;
            }

            return buf.ToString();
        }

    } 
}



