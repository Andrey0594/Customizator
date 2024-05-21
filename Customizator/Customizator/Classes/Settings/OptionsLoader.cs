using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;


namespace Customizator.Classes.Settings
{
    [Serializable]
    public static class OptionsLoader<TCustomOptions> where TCustomOptions : class
    {
      

        /// <summary>
        /// Полный путь к месту хранения файла XML с параметрами
        /// </summary>
        private static string XmlFileName =>
            Path.Combine(AppContext.BaseDirectory, $"{typeof(TCustomOptions).Name}.xml");


       
        

        /// <summary>
        /// Сериализация параметров в файл XML (сохранения параметров)
        /// </summary>
        public static void SaveOptionsToXml(TCustomOptions options)
        {
            if (options != null)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(TCustomOptions));
                using (FileStream stream = new FileStream(XmlFileName, FileMode.Create))
                {
                    serializer.Serialize(stream, options);
                }
            }
        }

        
      
        /// <summary>
        /// Десериализация параметров из файла XML (чтение параметров)
        /// </summary>
        public static TCustomOptions LoadOptionsFromXml()
        {
            if (!File.Exists(XmlFileName))
                return null;

            XmlSerializer serializer = new XmlSerializer(typeof(TCustomOptions));
            using (FileStream stream = new FileStream(XmlFileName, FileMode.OpenOrCreate))
            {
                return serializer.Deserialize(stream) as TCustomOptions;
            }
        }
    }
}
