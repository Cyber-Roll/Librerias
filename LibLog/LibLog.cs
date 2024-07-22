namespace LibLog
{

    /// Descripcio Uso <summary>
    /// A continuación se tiene la descripcio del uso de esta libreria 
    /// </summary>    
    /*
    string path = "D:\\___Files\\VS\\";
    string file = "EFCore_Activity0402.log";
    Log oLog = new Log(path, file);
    Log oLog = new Log(path);
    oLog.SetFile(file);
    oLog.Add("Mensa a ser impreso");
    */
    public class Log
    {
        private string Path = "";
        private string File = "";


        public Log(string Path, string sFile)
        {
            this.Path = Path;
            this.File = sFile;
        }

        public Log(string Path)
        {
            this.Path = Path;
            File = GetNameFile();
        }

        public void SetFile(string sFile)
        {
            File = sFile;
        }

        public void Add(string sLog)
        {
            CreateDirectory();
            string cadena = "";

            cadena += DateTime.Now.ToString("yyyy.MM.dd hh.mm.ss") + " - " + sLog + Environment.NewLine;

            StreamWriter sw = new StreamWriter(Path + "/" + File, true);
            sw.Write(cadena);
            sw.Close();

        }

        #region HELPER
        private string GetNameFile()
        {
            string nombre = "";

            nombre = "log_" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + ".log";

            return nombre;
        }

        private void CreateDirectory()
        {
            try
            {
                if (!Directory.Exists(Path))
                    Directory.CreateDirectory(Path);


            }
            catch (DirectoryNotFoundException ex)
            {
                throw new Exception(ex.Message);

            }
        }
        #endregion
    }
}
