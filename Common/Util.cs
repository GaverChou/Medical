using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Xml;

namespace Common
{
    public class Util
    {
        //检查号码是否符合规范
        public static bool CheckIDCard(string idcard)
        {
            bool check = true;
            if (idcard != "")
            {
                if (idcard.Length != 18 )
                {
                    check = false;
                }
            }
            return check;
        }

        public static bool CheckTheSame(string str1,string str2)
        {
            return str1 == str2;
        }

        public static byte[] GetImageByte(string FileName)
        {
            FileStream fs = default(FileStream);
            //定义一个I/O流对象file 
            byte[] B = null;
            //============下面为照片字段赋值=========================================== 
            fs = new FileStream(FileName, FileMode.Open);
            //为流对象赋值 
            int imgLen = (int)fs.Length;
            B = (byte[])Array.CreateInstance(typeof(byte), imgLen);
            int nBytesRead = fs.Read(B, 0, imgLen);
            return B;
        }

        public static bool RemPassWd(string name,string passwd)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(@"user.xml");
                XmlElement node = doc.GetElementById("user");
                XmlNode nameNode = (XmlNode)doc.GetElementById("username");
                XmlNode passWdNode = (XmlNode)doc.GetElementById("passwd");
                nameNode.InnerText = name;
                passWdNode.InnerText = passwd;
                //node.AppendChild(nameNode);
                //node.AppendChild(passWdNode);
                //doc.DocumentElement.InsertAfter(node, doc.DocumentElement.LastChild);
                doc.Save(@"user.xml");
            }
            catch (Exception exp)
            {
                return false;
            }
            return true;
        }

        public static Model.User GetUser()
        {
            Model.User user = new Model.User();
            XmlTextReader reader = new XmlTextReader(@"user.xml");
            while (reader.Read())
            {
                if (reader.LocalName.Equals("username"))
                {
                     user.UserName=reader.ReadString();
                }
                if (reader.LocalName.Equals("passwd"))
                {
                    user.Password = reader.ReadString();
                }
            }
            reader.Close();
            return user;
        }

        public static bool saveCheck(string str)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(@"user.xml");
                XmlElement node = doc.GetElementById("user");
                XmlNode check = (XmlNode)doc.GetElementById("check");
                check.InnerText = str;
                //node.AppendChild(check);
                //doc.DocumentElement.InsertAfter(node, doc.DocumentElement.LastChild);
                doc.Save(@"user.xml");
            }
            catch (Exception exp)
            {
                return false;
            }
            return true;
        }

        public static string getCheck()
        {
            string check = "0";
            XmlTextReader reader = new XmlTextReader(@"user.xml");
            while (reader.Read())
            {
                if (reader.LocalName.Equals("check"))
                {
                    check = reader.ReadString();
                    break;
                }
            }
            reader.Close();
            return check;
        }
    }
}
