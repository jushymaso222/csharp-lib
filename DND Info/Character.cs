using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DND_Info
{
    internal class Character
    {
        private Double strength;
        private Double dexterity;
        private Double constitution;
        private Double charisma;
        private Double wisdom;
        private Double intelligence;
        private string name;
        private string sex; //F, M or N
        private string creature; //Human, dragon, etc.
        private string language; //Common, Draconic, etc.
        private string size; //Small, large, etc.
        private string race; //Human, orc, etc.
        private string subrace; //Will be filled in by user
        private string pclass; //Warlock, brute, etc.
        private string subclass; //Will be filled in by user (too many to list)
        private string skills; //Skills
        private string proficiency; 
        private string armor;
        private int hp;

        public string Strength { get { return strength.ToString(); } set
            {
                if (ValidationLibrary.IsANumber(value))
                {
                    strength = Double.Parse(value);
                }
            } 
        }
        public string Dexterity
        {
            get { return dexterity.ToString(); }
            set
            {
                if (ValidationLibrary.IsANumber(value))
                {
                    dexterity = Double.Parse(value);
                }
            }
        }
        public string Constitution
        {
            get { return constitution.ToString(); }
            set
            {
                if (ValidationLibrary.IsANumber(value))
                {
                    constitution = Double.Parse(value);
                }
            }
        }
        public string Charisma
        {
            get { return charisma.ToString(); }
            set
            {
                if (ValidationLibrary.IsANumber(value))
                {
                    charisma = Double.Parse(value);
                }
            }
        }
        public string Wisdom
        {
            get { return wisdom.ToString(); }
            set
            {
                if (ValidationLibrary.IsANumber(value))
                {
                    wisdom = Double.Parse(value);
                }
            }
        }
        public string Intelligence
        {
            get { return intelligence.ToString(); }
            set
            {
                if (ValidationLibrary.IsANumber(value))
                {
                    intelligence = Double.Parse(value);
                }
            }
        }
        public string Name { get { return name; } set 
            {  
                if (ValidationLibrary.IsMaxLength(value, 60))
                {
                    name = value;
                }
            } 
        }
        public string Sex { get {  return sex; } set 
            {
                if (ValidationLibrary.IsMaxLength(value, 60))
                {
                    sex = value;
                }
            } 
        }
        public string Creature { get { return creature; } set { creature = value; } }
        public string Race { get { return race; } set { race = value; } }
        public string Subclass { get {  return subclass; } set {  subclass = value; } }
        public string Language { get { return language;  } set { language = value;  } }
        public string Size { get { return size; } set { size = value; } }
        public string Subrace { get { return subrace;  } set { subrace = value;  } }
        public string Pclass { get { return pclass;  } set { pclass = value;  } }   
        public string Skills { get { return skills; } set { skills = value; } }
        public string HP { get { return hp.ToString(); } set 
            { 
                if (ValidationLibrary.IsANumber(value))
                {
                    hp = Int32.Parse(value);
                }
            } 
        }
        public string Proficiency { get { return proficiency; } set { proficiency = value; } }
        public string Armor { get { return armor; } set {  armor = value; } }

        public Character()
        {
            name = "";
            strength = 0;
            constitution = 0;
            wisdom = 0;
            intelligence = 0;
            dexterity = 0;
            charisma = 0;
            sex = "";
            creature = "";
            language = "";
            size = "";
            race = "";
            subrace = "";
            pclass = "";
            subclass = "";
            skills = "";
            proficiency = "";
            armor = "";
            hp = 0;
        }

        public string AddRecord()
        {
            string strResult = "";

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = GetConnected();

            string strSQL = "INSERT INTO Characters (Strength, Dexterity, Constitution, Charisma, Wisdom, Intelligence, Name, Sex, Creature, Language, Size, Race, Subrace, Class, Subclass, Skills, Proficiencies, Armor, Hp) VALUES (@Strength, @Dexterity, @Constitution, @Charisma, @Wisdom, @Intelligence, @Name, @Sex, @Creature, @Language, @Size, @Race, @Subrace, @Class, @Subclass, @Skills, @Proficiencies, @Armor, @Hp)";
            SqlCommand comm = new SqlCommand();

            comm.CommandText = strSQL;
            comm.Connection = conn;
            
            comm.Parameters.AddWithValue("@Strength", Strength);
            comm.Parameters.AddWithValue("@Dexterity", Dexterity);
            comm.Parameters.AddWithValue("@Constitution", Constitution);
            comm.Parameters.AddWithValue("@Charisma", Charisma);
            comm.Parameters.AddWithValue("@Wisdom", Wisdom);
            comm.Parameters.AddWithValue("@Intelligence", Intelligence);
            comm.Parameters.AddWithValue("@Name", Name);
            comm.Parameters.AddWithValue("@Sex", Sex);
            comm.Parameters.AddWithValue("@Creature", Creature);
            comm.Parameters.AddWithValue("@Language", Language);
            comm.Parameters.AddWithValue("@Size", Size);
            comm.Parameters.AddWithValue("@Race", Race);
            comm.Parameters.AddWithValue("@Subrace", Subrace);
            comm.Parameters.AddWithValue("@Class", Pclass);
            comm.Parameters.AddWithValue("@Subclass", Subclass);
            comm.Parameters.AddWithValue("@Skills", Skills);
            comm.Parameters.AddWithValue("@Proficiencies", Proficiency);
            comm.Parameters.AddWithValue("@Armor", Armor);
            comm.Parameters.AddWithValue("@Hp", HP);

            try
            {
                conn.Open();
                int intRecs = comm.ExecuteNonQuery();
                strResult = $"SUCCESS: Inserted {intRecs} records.";
            }
            catch (Exception err)
            {
                strResult = "ERROR: " + err.Message;
            }
            finally
            {
                conn.Close();
            }

            return strResult;
        }

        public SqlDataReader FindRecord(int intID)
        {
            SqlCommand comm = new SqlCommand();
            SqlConnection conn = new SqlConnection();

            string strConn = GetConnected();
            conn.ConnectionString = strConn;

            string sqlString = "SELECT * FROM Characters WHERE ID = @ID";

            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@ID", intID);

            conn.Open();

            return comm.ExecuteReader();
        }

        public DataSet SearchSmall()
        {
            DataSet ds = new DataSet();

            SqlCommand comm = new SqlCommand();
            SqlConnection conn = new SqlConnection();

            string strSQL = "SELECT ID, Name FROM Characters WHERE 0=0";

            string strConn = GetConnected();
            conn.ConnectionString = strConn;

            comm.Connection = conn;
            comm.CommandText = strSQL;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;

            conn.Open();
            da.Fill(ds, "Records_Temp");
            conn.Close();

            return ds;
        }

        public DataSet SearchLarge(string mode, string text)
        {
            DataSet ds = new DataSet ();

            SqlCommand comm = new SqlCommand();
            SqlConnection conn = new SqlConnection();

            string strSQL = "SELECT * FROM Characters WHERE 0=0";

            if (mode.Length > 0)
            {
                strSQL += "AND "+mode+" LIKE @Text";
                comm.Parameters.AddWithValue("@Text", "%" + text + "%");
            }

            string strConn = GetConnected();
            conn.ConnectionString = strConn;

            comm.Connection = conn;
            comm.CommandText = strSQL;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;

            conn.Open();
            da.Fill(ds, "Records_temp");
            conn.Close();

            return ds;
        }

        public string DeleteRecord(int intID)
        {
            Int32 intRecords = 0;
            string strResult = "";

            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            string sqlString = "DELETE FROM Characters WHERE ID = @ID";
            conn.ConnectionString = GetConnected();

            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@ID", intID);

            try
            {
                conn.Open();
                intRecords = comm.ExecuteNonQuery();
                strResult = intRecords.ToString() + " Records Deleted.";
            }
            catch (Exception err)
            {
                strResult = "ERROR: " + err.Message;
            }
            finally
            {
                conn.Close();
            }

            return strResult;
        }

        public string UpdateRecord(int intID)
        {
            Int32 intRecords = 0;
            string strResult = "";

            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            string strSQL = "UPDATE Characters SET Strength = @Strength, Dexterity = @Dexterity, Constitution = @Constitution, Charisma = @Charisma, Wisdom = @Wisdom, Intelligence = @Intelligence, Name = @Name, Sex = @Sex, Creature = @Creature, Language = @Language, Size = @Size, Race = @Race, Subrace = @Subrace, Class = @Class, Subclass = @Subclass, Skills = @Skills, Proficiencies = @Proficiencies, Armor = @Armor, Hp = @Hp WHERE ID = @ID";
            conn.ConnectionString = GetConnected();

            comm.CommandText = strSQL;
            comm.Connection = conn;

            comm.Parameters.AddWithValue("@ID", intID);
            comm.Parameters.AddWithValue("@Strength", Strength);
            comm.Parameters.AddWithValue("@Dexterity", Dexterity);
            comm.Parameters.AddWithValue("@Constitution", Constitution);
            comm.Parameters.AddWithValue("@Charisma", Charisma);
            comm.Parameters.AddWithValue("@Wisdom", Wisdom);
            comm.Parameters.AddWithValue("@Intelligence", Intelligence);
            comm.Parameters.AddWithValue("@Name", Name);
            comm.Parameters.AddWithValue("@Sex", Sex);
            comm.Parameters.AddWithValue("@Creature", Creature);
            comm.Parameters.AddWithValue("@Language", Language);
            comm.Parameters.AddWithValue("@Size", Size);
            comm.Parameters.AddWithValue("@Race", Race);
            comm.Parameters.AddWithValue("@Subrace", Subrace);
            comm.Parameters.AddWithValue("@Class", Pclass);
            comm.Parameters.AddWithValue("@Subclass", Subclass);
            comm.Parameters.AddWithValue("@Skills", Skills);
            comm.Parameters.AddWithValue("@Proficiencies", Proficiency);
            comm.Parameters.AddWithValue("@Armor", Armor);
            comm.Parameters.AddWithValue("@Hp", HP);

            try
            {
                conn.Open();
                intRecords = comm.ExecuteNonQuery();
                strResult = intRecords.ToString() + " Records Updated.";
            }
            catch (Exception err)
            {
                strResult = "ERROR: " + err.Message;
            }
            finally
            {
                conn.Close();
            }

            return strResult;
        }


        private string GetConnected()
        {
            return
                @"Server=sql.neit.edu\studentsqlserver,4500;Database=Dev_202430_JMason;User Id=Dev_202430_JMason;Password=008021377;";
        }
    }
}
