using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Classes
{
    public class ReflectionExample
    {
        public static bool LoadClassFromSQLDataReader(object myClass, SqlDataReader dr)
        {
            if (dr.HasRows)
            {
                dr.Read();
                Type typeOfClass = myClass.GetType();

                for (int columnIndex = 0; columnIndex <= dr.FieldCount; columnIndex++)
                {
                    string columnName = dr.GetName(columnIndex);
                    PropertyInfo propertyInfo = typeOfClass.GetProperty(columnName);

                    if (propertyInfo != null)
                    {
                        propertyInfo.SetValue(myClass, dr.GetValue(columnIndex));
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
