﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Resources;
using System.Reflection;

namespace CNPM_ver3
{


    public static class ChangeLanguageClass
    {

        //public static ResourceManager _rm;
        
        // static constructor
        /*static ChangeLanguageClass()
        {
            _rm = new ResourceManager("CNPM_ver3.Language.strings", Assembly.GetExecutingAssembly());
        }

        public static string GetString(string name)
        {
            return _rm.GetString(name);
        }*/


        public static void UpdateLanguage(string key, string value)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            foreach (XmlElement xmlElement in xmlDoc.DocumentElement)
            {
                if (xmlElement.Name.Equals("appSettings"))
                {
                    foreach (XmlNode xNode in xmlElement.ChildNodes)
                    {
                        if (xNode.Attributes[0].Value.Equals(key))
                        {
                            xNode.Attributes[1].Value = value;
                        }
                    }
                }
            }

            ConfigurationManager.RefreshSection("appSettings");
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        }

    }
}
