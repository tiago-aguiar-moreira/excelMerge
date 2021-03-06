﻿using ClosedXML.Excel;
using System.IO;

namespace ExcelTools.Core.Model
{
    public class ParamsMergeModel
    {
        private string _fileName;
        private string _directory;
        public string FileName
        {
            get
            {
                return _fileName;
            }
            set
            {
                _fileName = Path.GetFileName(value);
            }
        }
        public string Directory
        {
            get
            {
                return _directory;
            }
            set
            {
                _directory = Path.GetDirectoryName(value);
            }
        }
        public byte HeaderLength { get; set; }
        public char? SeparatorCSV { get; set; }
        public ParamsMergeModel(string path)
        {
            FileName = path;
            Directory = path;
        }
        public string GetPath() => $"{_directory}\\{_fileName}";
    }
}
