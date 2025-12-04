using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Nhom03
{
	internal class KetNoiCSDL
	{

		// Chuỗi kết nối cố định
		private readonly string connectionString = "Server=localhost;Port=3306;Database=cskh;Uid=root;Pwd=01072004;";

		// Phương thức trả về đối tượng kết nối MySQL
		public MySqlConnection GetConnection()
		{
			return new MySqlConnection(connectionString);
		}
		//rivate string connectionString = "Your_Connection_String_Here";

		public DataTable ExecuteQuery(string query)
		{
			using (MySqlConnection conn = GetConnection())
			{
				DataTable dt = new DataTable();
				try
				{
					conn.Open();
					MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
					adapter.Fill(dt);
				}
				catch (Exception ex)
				{
					throw new Exception($"Lỗi truy vấn: {ex.Message}");
				}
				return dt;
			}
		}

		public bool ExecuteNonQuery(string query)
		{
			using (MySqlConnection conn = GetConnection())
			{
				try
				{
					conn.Open();
					MySqlCommand cmd = new MySqlCommand(query, conn);
					return cmd.ExecuteNonQuery() > 0;
				}
				catch (Exception ex)
				{
					throw new Exception($"Lỗi thực thi: {ex.Message}");
				}
			}
		}
		public object ExecuteScalar(string query, Dictionary<string, object> parameters = null)
		{
			try
			{
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					// Mở kết nối
					connection.Open();

					using (SqlCommand command = new SqlCommand(query, connection))
					{
						// Thêm tham số vào câu lệnh SQL nếu có
						if (parameters != null)
						{
							foreach (var param in parameters)
							{
								command.Parameters.AddWithValue(param.Key, param.Value);
							}
						}

						// Thực thi câu truy vấn và trả về giá trị đơn
						return command.ExecuteScalar();
					}
				}
			}
			catch (Exception ex)
			{
				// Xử lý lỗi nếu có
				Console.WriteLine("Lỗi khi thực hiện câu truy vấn: " + ex.Message);
				throw;
			}
		}
	}
}
