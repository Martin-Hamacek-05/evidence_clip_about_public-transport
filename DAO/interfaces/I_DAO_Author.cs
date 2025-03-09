using evidence_clip_about_public_transport.Entits;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evidence_clip_about_public_transport.DAO
{
    public interface I_DAO_Author
    {
        public void new_author(Author author);
        public void delete_author(int id);
        public void update_author(Author author);
        public DataSet get_all_authors();
        public Author get_author(int id);
        public Author set_author_for_login(Author author);
        public void change_count_of_access(int id);
        public CheckedListBox distict_author();
        public List<Author> get_all_for_backup();
        public string load_file(List<Author> list);
    }
}
