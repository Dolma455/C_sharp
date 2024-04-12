// using System;
// using System.Data;
// using System.Data.MysqlClient;
// namespace DatabaseTest {
//     class Program {
//         SqlConnection conn;
//         SqlCommand cmd;

//         void CreateConnection() {
//             string constr= "Server=localhost,Database=CRUD_C_Sharp, user=root, password=root;
//             conn=new MySqlConnection(cobstr);
//             conn.Open();
//         }

//         void InsertUdateDelete(string sql) {
//             command=new MySqlCommand(sql,conn);
//             command.ExecuteNonQuery();
//             Console.WriteLine("Operation Performed Successfully")
//         }
//     }
// }
