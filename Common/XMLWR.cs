using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Common
{

    public class XmlRW
    {

        private static XmlRW instance;

        private XmlRW()
        {
        }

        public static XmlRW GetXmlRW()
        {
            if (instance == null)
            {
                instance = new XmlRW();
            }
            return instance;
        }

        //WriteXml 完成对User的修改密码操作
        //FileName 当前xml文件的存放位置
        //Check
        //UserPassword 欲修改用户的密码

        public bool UpdateXML(string FileName, string Check,string UserName, string UserPassword)
        {
            try
            {
                //初始化XML文档操作类
                XmlDocument myDoc = new XmlDocument();
                //加载XML文件
                myDoc.Load(FileName);

                //搜索指定的节点
                System.Xml.XmlNodeList nodes = myDoc.SelectNodes("//User");

                if (nodes != null)
                {
                    foreach (System.Xml.XmlNode xn in nodes)
                    {
                        xn.SelectSingleNode("Check").InnerText = Check;
                        xn.SelectSingleNode("UserPwd").InnerText = UserPassword;
                        xn.SelectSingleNode("UserName").InnerText = UserName;
                    }
                }

                myDoc.Save(FileName);
            }
            catch (Exception exp)
            {
                return false;
            }
            return true;

        }

        public bool UpdateXML(string FileName,string name, string value)
        {
            try
            {
            //初始化XML文档操作类
            XmlDocument myDoc = new XmlDocument();
            //加载XML文件
            myDoc.Load(FileName);

            //搜索指定的节点
            System.Xml.XmlNodeList nodes = myDoc.SelectNodes("//User");

            if (nodes != null)
            {
                foreach (System.Xml.XmlNode xn in nodes)
                {
                    xn.SelectSingleNode(name).InnerText = value;
                }
            }

            myDoc.Save(FileName);
            }
            catch (Exception exp)
            {
                return false;
            }
            return true;
        }

        public string getValueByName(string FileName,string name)
        {
            string value = "0";
            XmlTextReader reader = null;
            try
            {
                reader = new XmlTextReader(FileName);
                while (reader.Read())
                {
                    if (reader.LocalName.Equals(name))
                    {
                        value = reader.ReadString();
                        break;
                    }
                }
            }
            catch (Exception exp)
            {
                return value;
            }
            finally
            {
                reader.Close();
            }
            return value;
        }
    }
}
