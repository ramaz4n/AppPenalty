using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using AppPenalty.Models;
using System.Xml.Serialization;


namespace AppPenalty.Shared.Repos
{
    public class RepoOsago
    {
        private string _fileName;

        private List<OsagoModel> _osagos;
        protected List<OsagoModel> Osagos { get => _osagos; set => _osagos = value; }

        public RepoOsago(string fileName)
        {
            _fileName = fileName;
            if (!File.Exists(_fileName))
            {
                using (var writer = new StreamWriter(_fileName))
                {
                    writer.WriteLine(" ");
                    writer.Close();
                }
            }
        }
        public void Create(OsagoModel osago)
        {
            Osagos.Add(osago);

            var osagos = new List<OsagoModel>();
            foreach (var e in Osagos)
                osagos.Add(new OsagoModel(e.Number));

            var xmlSerializer = new XmlSerializer(typeof(List<OsagoModel>));
            using (var fs = new FileStream(_fileName, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, osagos);
                fs.Close();
            }
        }


        public List<OsagoModel> Read()
        {
            var osagos = new List<OsagoModel>();
            var xmlSerializer = new XmlSerializer(typeof(List<OsagoModel>));
            using (var fs = new FileStream(_fileName, FileMode.OpenOrCreate))
            {
                osagos = xmlSerializer.Deserialize(fs) as List<OsagoModel> ?? new List<OsagoModel>();
                fs.Close();
            };

            Osagos.Clear();
            foreach (var c in osagos)
                Osagos.Add(new OsagoModel(c.Number));
            return Osagos;
        }

    }
}
