using evidence_clip_about_public_transport.Entits;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Author: Martin Hamacek
namespace evidence_clip_about_public_transport.DAO
{
    /// <summary>
    /// This interface reprezent the most used functions in database entit: clip
    /// </summary>
    public interface I_DAO_Author
    {
        /// <summary>
        /// Insert a new record to table Author
        /// </summary>
        /// <param name="author">new Author</param>
        public void new_author(Author author);

        /// <summary>
        /// Remove selected record from table Author
        /// </summary>
        /// <param name="id">id of Author</param>
        public void delete_author(int id);

        /// <summary>
        /// Edit the exist now record in table Author
        /// </summary>
        /// <param name="author">replace Author</param>
        public void update_author(Author author);

        /// <summary>
        /// Load all data from table Author
        /// </summary>
        /// <returns>loaded data from database table Author</returns>
        public DataSet get_all_authors();

        /// <summary>
        /// Load selected Author
        /// </summary>
        /// <param name="id">id of author</param>
        /// <returns>loaded author</returns>
        public Author get_author(int id);

        /// <summary>
        /// Load Author for login
        /// </summary>
        /// <param name="author">author</param>
        /// <returns>loaded author</returns>
        public Author set_author_for_login(Author author);

        /// <summary>
        /// Set count of access to selected Author
        /// </summary>
        /// <param name="id">id of author</param>
        public void change_count_of_access(int id);

        /// <summary>
        /// Load all unique author for filter - not used
        /// </summary>
        /// <returns>list for filter</returns>
        public CheckedListBox distict_author();


        /// <summary>
        /// Load all author for backup
        /// </summary>
        /// <returns>loaded author</returns>
        public List<Author> get_all_for_backup();

        /// <summary>
        /// load backup of author
        /// </summary>
        /// <param name="list">list of authors</param>
        /// <returns>string</returns>
        public string load_file(List<Author> list);
    }
}
