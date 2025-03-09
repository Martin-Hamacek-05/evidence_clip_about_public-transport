using evidence_clip_about_public_transport.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* author Martin Hamacek, C4c, 2024/2025*/
namespace evidence_clip_about_public_transport.Entits
{
    /// <summary>
    /// Reprezentation entit formats in database
    /// </summary>
    public class Formats:I_Work_with_Csv
    {
        private int id;
        private string name_;
        private int height;
        private int width;
        private int fps;
        private int audio_counttrack;
        private Type_frame type_Frame;
        public Formats() 
        { 
        
        }
        public Formats(int id, string name_, int height, int width, int fps, int audio_counttrack, Type_frame type_Frame)
        {
            if (name_ == null)
            {
                throw new IndexOutOfRangeException("název neobsahuje text");
            }

            if (name_.Length > 100)
            {
                throw new IndexOutOfRangeException("délka názvu je delší než 100");
            }

            if (height < 1)
            {
                throw new IndexOutOfRangeException("výška je menší než 2");
            }

            if (width < 1)
            {
                throw new IndexOutOfRangeException("šířka je menší než 2");
            }

            if (fps < 0)
            {
                throw new IndexOutOfRangeException("počet snímků za sekundu je menší než 0");
            }

            if (audio_counttrack < 0)
            {
                throw new IndexOutOfRangeException("počet audio stop je menší než 0");
            }


            this.Id = id;
            this.Name_ = name_;
            this.Height = height;
            this.Width = width;
            this.Fps = fps;
            this.Audio_counttrack = audio_counttrack;
            this.Type_Frame = type_Frame;
        }

        public int Id { get => id; set => id = value; }
        public string Name_ { get => name_; set => name_ = value; }
        public int Height { get => height; set => height = value; }
        public int Width { get => width; set => width = value; }
        public int Fps { get => fps; set => fps = value; }
        public int Audio_counttrack { get => audio_counttrack; set => audio_counttrack = value; }
        internal Type_frame Type_Frame { get => type_Frame; set => type_Frame = value; }


        public string to_csv()
        {
            if (type_Frame == Type_frame.progressive)
            {
                return id + ";" + name_ + ";" + height + ";" + width + ";" + fps + ";" + audio_counttrack + ";1";
            }
            else 
            {
                return id + ";" + name_ + ";" + height + ";" + width + ";" + fps + ";" + audio_counttrack + ";2";
            }
            
        }
        public object from_csv(string row)
        {
            row = row.Trim();
            string[] splited = row.Split(';');

            return new Formats(Int32.Parse(splited[0]), splited[1], Int32.Parse(splited[2]), Int32.Parse(splited[3]), Int32.Parse(splited[4]), Int32.Parse(splited[5]), (Type_frame)Int32.Parse(splited[6]));   
        }
    }
}
