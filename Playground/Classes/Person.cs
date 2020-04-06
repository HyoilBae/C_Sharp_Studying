using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Classes
{
    public class Person : IEquatable<Person>
    {
        private const string DbConnection = "Data Source=mcsd-sql.database.windows.net;Initial Catalog=MCSD;Integrated Security=False;User ID=tkmyers46;Password=!!**5439mmKK;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public Country CountryOfBirth { get; set; }

        public Person()
        {

        }

        public Person(string lastname)
        {
            if (String.IsNullOrEmpty(lastname))
            {
                throw new ArgumentOutOfRangeException(lastname, "LastName cannot be null or empty");
            }

            Lastname = lastname;
        }
        public Person(string firstname, string lastname) : this (lastname)
        {
            if (String.IsNullOrEmpty(firstname))
            {
                throw new ArgumentOutOfRangeException(firstname, "FirstName cannot be null or empty");
            }

            FirstName = firstname;
        }

        public bool Equals(Person other)
        {
            if (this.FirstName == other.FirstName && this.Lastname == other.Lastname)
                return true;

            return false;
        }

        public enum Country
        {
            USA = 1,
            Canada,
            India
        }

        public bool GetPerson(int personId)
        {
            SqlConnection cn = new SqlConnection(DbConnection);

            cn.Open();

            SqlCommand cmd = new SqlCommand(String.Format("SELECT * FROM Person WHERE PersonId = {0}", personId), cn);

            SqlDataReader dr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            return ReflectionExample.LoadClassFromSQLDataReader(this, dr);
        }

        public static bool PutPerson(Person p)
        {
            try
            {
                SqlConnection cn = new SqlConnection(DbConnection);

                cn.Open();

                string cmdText = String.Format("INSERT INTO Person (PersonId, FirstName, LastName) VALUES ({0},'{1}','{2}');", p.PersonId, p.FirstName, p.Lastname);

                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = cmdText;

                int rowsAffected = cmd.ExecuteNonQuery();
                cn.Close();
                return rowsAffected > 0;
            }
            catch (Exception)
            {   
                return false;
            }
        }
    }
}
