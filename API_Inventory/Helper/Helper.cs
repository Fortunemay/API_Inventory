using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Reflection;

namespace Inventory_API.Helper
{
    public static class Helper
    {
        public static List<TSource> ToList<TSource>(this DataTable dataTable) where TSource : new()
        {
            var dataList = new List<TSource>();

            const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic;
            var objFieldNames = (from PropertyInfo aProp in typeof(TSource).GetProperties(flags)
                                 select new { Name = aProp.Name, Type = Nullable.GetUnderlyingType(aProp.PropertyType) ?? aProp.PropertyType }).ToList();
            var dataTblFieldNames = (from DataColumn aHeader in dataTable.Columns
                                     select new { Name = aHeader.ColumnName, Type = aHeader.DataType }).ToList();
            var commonFields = objFieldNames.Intersect(dataTblFieldNames).ToList();

            foreach (DataRow dataRow in dataTable.AsEnumerable().ToList())
            {
                var aTSource = new TSource();
                foreach (var aField in commonFields)
                {
                    PropertyInfo propertyInfos = aTSource.GetType().GetProperty(aField.Name);

                    if (dataRow[aField.Name] == DBNull.Value)
                    {
                        propertyInfos.SetValue(aTSource, null, null);
                    }
                    else
                    {
                        propertyInfos.SetValue(aTSource, dataRow[aField.Name], null);
                    }
                }
                dataList.Add(aTSource);
            }
            return dataList;
        }

        public static IEnumerable<dynamic> ReaderToAnonymmous(SqlCommand comm)
        {
            using (var reader = comm.ExecuteReader())
            {
                var schemaTable = reader.GetSchemaTable();

                List<string> colnames = new List<string>();
                foreach (DataRow row in schemaTable.Rows)
                {
                    colnames.Add(row["ColumnName"].ToString());
                }

                while (reader.Read())
                {
                    var data = new ExpandoObject() as IDictionary<string, Object>;
                    foreach (string colname in colnames)
                    {
                        var val = reader[colname];
                        data.Add(colname, Convert.IsDBNull(val) ? null : val);
                    }

                    yield return (ExpandoObject)data;
                }
            }
        }
        public static List<T> DataReaderMapToList<T>(IDataReader dr)
        {
            List<T> list = new List<T>();
            string checkpropName = null;
            try
            {
                T obj = default(T);
                while (dr.Read())
                {
                    obj = Activator.CreateInstance<T>();
                    foreach (PropertyInfo prop in obj.GetType().GetProperties())
                    {
                        if (!object.Equals(dr[prop.Name], DBNull.Value))
                        {
                            checkpropName = prop.Name;
                            prop.SetValue(obj, dr[prop.Name], null);
                        }
                    }
                    list.Add(obj);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return list;
        }

        public static T DataReaderMapFirst<T>(IDataReader dr)
        {
            T obj = default(T);
            while (dr.Read())
            {
                obj = Activator.CreateInstance<T>();
                foreach (PropertyInfo prop in obj.GetType().GetProperties())
                {
                    if (!object.Equals(dr[prop.Name], DBNull.Value))
                    {
                        prop.SetValue(obj, dr[prop.Name], null);
                    }
                }
            }
            return obj;
        }

        public static List<T> DataEntityMapToList<T>(List<T> dr)
        {
            List<T> list = new List<T>();
            T obj = default(T);

            obj = Activator.CreateInstance<T>();
            foreach (PropertyInfo prop in obj.GetType().GetProperties())
            {
                if (!object.Equals(dr, DBNull.Value))
                {
                    prop.SetValue(obj, dr, null);
                }
            }
            list.Add(obj);

            return list;
        }
        public static T DeserializeObject<T>(string data)
        {
            var x = JsonConvert.DeserializeObject<T>(data);
            return x;
        }
        public static List<T> DeserializeObjectList<T>(string data)
        {
            var x = JsonConvert.DeserializeObject<List<T>>(data);
            return x;
        }
    }
}
