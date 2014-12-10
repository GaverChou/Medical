using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Common
{
    public class MD5Provider
    {
        private MD5Provider()
        { }

        //计算指定字符串的MD5哈希值
        public static string Hash(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                return string.Empty;
            }
            else
            {
                //创建MD5算法的默认实例
                MD5 md5 = MD5.Create();
                byte[] source = Encoding.Unicode.GetBytes(message);
                byte[] result = md5.ComputeHash(source); //加密
                StringBuilder buffer = new StringBuilder(result.Length);
                for (int i = 0; i < result.Length; i++)
                {
                    //将byte值转换成十六进制字符串
                    buffer.Append(result[i].ToString("x"));
                }
                return buffer.ToString();
            }
        }
    }
}
