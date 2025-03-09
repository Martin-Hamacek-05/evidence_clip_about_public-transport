using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace evidence_clip_about_public_transport.File_manager
{
    public class Work_with_local : I_File_type
    {
        public string copy_file_from_one_location_to_another(string from_, string file, string to_, string alternative)
        {
            
                File.Copy(from_ + file, to_ + '\\' + alternative + "_" + file, true);
                return "ok";
            
        }

        public string delete_file(string name_of_file, string from)
        {
            try 
            { 
                File.Delete(from + name_of_file);
                return "smazáno";
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }

        public List<string> list_of_directories(string path)
        {
            try
            {
                DirectoryInfo d = new DirectoryInfo(path); //Assuming Test is your Folder

                FileInfo[] Files = d.GetFiles(); //Getting Text files
                List<string> list = new List<string>();

                foreach (FileInfo file in Files)
                {
                    list.Add(file.Name);
                }
                return list;
            }
            catch (Exception exc) 
            {
                MessageBox.Show(exc.Message);
                return new List<string>();
            }
        }

        public string load_file(string name_of_file, string from)
        {
            try
            {
                Process.Start(from + name_of_file);
                return "spuštěno";
            }
            catch (Exception exc) 
            {
                return exc.Message;
            }
        }

        public string make_directory(string name, string path)
        {
            try
            {
                DirectoryInfo create_directory = Directory.CreateDirectory(path+"\\"+name);
                return "Úspěšně vytvořeno";
            }
            catch (Exception exc) 
            {
                return exc.Message;
            }
        }

        public string record_file(string name_of_file, string from, string to)
        {
            
            try
            {
                File.Copy(from, to + "\\" + name_of_file, true);
                return "úspěšně zkopírováno";
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }

        public string rename_file(string previours_name_of_file, string new_name_of_file, string path)
        {
            try
            {
                MessageBox.Show(path + previours_name_of_file, path + new_name_of_file);
                System.IO.File.Move(path + previours_name_of_file, path + new_name_of_file);
                return "úspěšně přejmenováno";
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }
    }
}
