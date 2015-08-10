using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Convert
    {
        public static DataTable CreateTable<T>(IEnumerable<T> varList)
        {

            var dataTable = new DataTable();

           // ---- Danh sách các Dựng Hàm public để tạo các cột cho bảng

            PropertyInfo[] tableColumns = null;



            // Với mỗi phần tử từ trong list

            foreach (T rec in varList)
            {

                // Sử dụng Reflection để lấy tên từng các cột

                if (tableColumns == null)
                {

                    tableColumns = ((Type)rec.GetType()).GetProperties();

                    foreach (PropertyInfo pi in tableColumns)
                    {

                        Type columnType = pi.PropertyType;

                        if ((columnType.IsGenericType) && (columnType.GetGenericTypeDefinition() == typeof(Nullable<>)) && (!columnType.IsClass))
                        {

                            columnType = columnType.GetGenericArguments()[0];

                        }

                        dataTable.Columns.Add(new DataColumn(pi.Name, columnType));

                    }

                }



                // ---- Chuyển dữ liệu thành các hàng

                DataRow dataRow = dataTable.NewRow();

                foreach (PropertyInfo pi in tableColumns)
                {
                    dataRow[pi.Name] = pi.GetValue(rec, null) ?? DBNull.Value;

                }

                dataTable.Rows.Add(dataRow);

            }

            return (dataTable);

        }
    }
}
