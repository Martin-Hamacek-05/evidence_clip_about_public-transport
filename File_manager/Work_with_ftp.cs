﻿using evidence_clip_about_public_transport.Work_with_ftp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
//Author: Martin Hamacek
namespace evidence_clip_about_public_transport.File_manager
{
    /// <summary>
    /// Work a files on FTP Server. <b>WARNING: FTP protocol is not encrypted</b>
    /// </summary>
    public class Work_with_ftp : I_File_type
    {
        public string copy_file_from_one_location_to_another(string from_, string file, string to_, string alternative)
        {
            
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(from_ + file);
                request.Credentials = ftp_connection.ftp_connect().User_login;
                request.Method = WebRequestMethods.Ftp.DownloadFile;

                using (Stream ftpStream = request.GetResponse().GetResponseStream())
                using (Stream fileStream = File.Create(to_ + '\\' + alternative + "_" + file))
                {
                    ftpStream.CopyTo(fileStream);
                }
                return "stáhnuto";
            
        }

        public string delete_file(string name_of_file, string from)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(from +"/"+ name_of_file);
                request.Credentials = ftp_connection.ftp_connect().User_login;
                request.Method = WebRequestMethods.Ftp.DeleteFile;

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                response.Close();

                return "smazáno";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public List<string> list_of_directories(string path)
        {
            try
            {
                List<string> list_of_directories = new List<string>();
                FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(path);
                ftpRequest.Credentials = ftp_connection.ftp_connect().User_login;
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;
                FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse();
                StreamReader streamReader = new StreamReader(response.GetResponseStream());

                string line = streamReader.ReadLine();
                while (!string.IsNullOrEmpty(line))
                {
                    line = streamReader.ReadLine();
                    list_of_directories.Add(line);
                }
                streamReader.Close();
                return list_of_directories;
            }
            catch (Exception exc) 
            {
                MessageBox.Show(exc.Message);
                return null;
            }
        }

        public string load_file(string name_of_file, string from)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = name_of_file;
                
                if (saveFileDialog.ShowDialog() == DialogResult.OK) 
                {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(from+"//"+ name_of_file);

                request.Credentials = ftp_connection.ftp_connect().User_login;
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                
                
                using (Stream ftpStream = request.GetResponse().GetResponseStream())
                using (Stream fileStream = File.Create(Path.GetFullPath(saveFileDialog.FileName)))
                {
                    ftpStream.CopyTo(fileStream);
                }

                    var p = new Process();
                    p.StartInfo = new ProcessStartInfo(saveFileDialog.FileName)
                    {
                        UseShellExecute = true
                    };
                    p.Start();

                    return "stáhnuto";
                }
                return "funkce nebyla provedena";
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
                string response = "";
                WebRequest request = WebRequest.Create(path+"\\" + name);
                request.Method = WebRequestMethods.Ftp.MakeDirectory;
                request.Credentials = ftp_connection.ftp_connect().User_login;
                using (var resp = (FtpWebResponse)request.GetResponse())
                {
                    response = resp.StatusCode.ToString();
                }
                return response;
            }
            catch (Exception exc) 
            {
                return exc.Message;
            }
        }

        public string move_file(string from_, string to, string file)
        {
            throw new NotImplementedException();
        }

        public string record_file(string name_of_file, string from, string to)
        {
            try
            {
                using (var client = new WebClient())
                {
                    client.Credentials = ftp_connection.ftp_connect().User_login;
                    client.UploadFile(to+"/"+name_of_file, WebRequestMethods.Ftp.UploadFile, from+"/"+name_of_file);
                }
                return "úspěšně nahráno";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string rename_file(string previours_name_of_file, string new_name_of_file, string path)
        {
            try
            {
                FtpWebResponse ftpResponse = null;
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftp_connection.ftp_connect().Server + previours_name_of_file);
                request.Credentials = ftp_connection.ftp_connect().User_login;
                request.Method = WebRequestMethods.Ftp.Rename;
                request.RenameTo = path+new_name_of_file;
                ftpResponse = (FtpWebResponse)request.GetResponse();
                ftpResponse.Close();

                return "přejmenováno";
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }
    }
}
