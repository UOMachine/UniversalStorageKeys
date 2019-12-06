//CliLocDAO.cs - the data access object used to read/write cliloc files
using Server;
using System;
using System.Collections;
using System.IO;

namespace Solaris.CliLocHandler
{
    //this is an entry which holds the loaded cliloc index/text pair
    public class CliLocEntry
    {
        protected int _Index;
        protected string _Text;

        public int Index => _Index;

        public string Text => _Text;

        public override string ToString()
        {
            return _Text;
        }

        public CliLocEntry(int index, string text)
        {
            _Index = index;
            _Text = text;
        }
    }

    //the data access object for reading in the cliloc data file
    class CliLocDAO
    {
        static string _FilePath;
        static string _Filename;

        //private static FileStream _Index, _Stream;
        private static readonly GenericReader _Reader;

        public static string FilePath
        {
            get => _FilePath;
            set => _FilePath = value;
        }

        //default filename
        public CliLocDAO() : this("cliloc.enu")
        {
        }

        //find the file path
        public CliLocDAO(string filename) : this(filename, Core.FindDataFile(filename))
        {
        }

        //master constructor, where you can specify the filename and file path
        public CliLocDAO(string filename, string filepath)
        {
            _Filename = filename;
            _FilePath = filepath;
        }

        //read operation, which loads all the data into the specified cliloc entry hashtable
        public Hashtable Read()
        {
            Hashtable clilocs = new Hashtable();

            if (_Filename == null || _Filename == "")
            {
                _Filename = "cliloc.enu";       //default filename
            }

            if (File.Exists(_FilePath))
            {
                using (FileStream stream = new FileStream(_FilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    //here's where the reader is set up
                    BinaryReader reader = new BinaryReader(stream);

                    //first, read in the six header bytes to seek forward
                    for (int i = 0; i < 6; i++)
                    {
                        reader.ReadByte();
                    }

                    //now begin reading the cliloc contents.  text is encoded in UTF8 format
                    System.Text.Encoding encoding = System.Text.Encoding.UTF8;

                    int index = 0;

                    //this is the highest visible index in the file.  At least, as of the version I used to make this!					
                    while (index != CliLoc.MaxEntry)
                    {
                        //Read string from binary file with UTF8 encoding
                        index = reader.ReadInt32();

                        //read unused byte to seek reader ahead
                        reader.ReadByte();

                        //read in string length and then read the string
                        short strlen = reader.ReadInt16();
                        byte[] buffer = new byte[strlen];
                        reader.Read(buffer, 0, strlen);

                        //parse the string from the UTF8 encoded format
                        string text = encoding.GetString(buffer);

                        clilocs.Add(index, new CliLocEntry(index, text));
                    }
                }
            }
            else
            {
                Console.WriteLine("CliLoc load error: file doesn't exist");
                return null;
            }

            return clilocs;
        }
    }
}