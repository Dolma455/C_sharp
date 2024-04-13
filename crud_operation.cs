// using System;
// using System.Data;
// using MySql.Data.MySqlClient;

// namespace DatabaseTest
// {
//     class Program
//     {
//         MySqlConnection conn;
//         MySqlCommand cmd;

//         void CreateConnection()
//         {
//             string constr = "Server=localhost;Database=CRUD_C_Sharp;Uid=root;Pwd=root;";
//             conn = new MySqlConnection(constr);
//             conn.Open();
//         }

//         void InsertUpdateDelete(string sql, MySqlParameter[] parameters)
//         {
//             cmd = new MySqlCommand(sql, conn);
//             cmd.Parameters.AddRange(parameters);
//             cmd.ExecuteNonQuery();
//             Console.WriteLine("Operation Performed Successfully");
//         }


//         void SelectRecords(string sql)
//         {
//             cmd = new MySqlCommand(sql, conn);
//             MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
//             DataTable dt = new DataTable();
//             adapter.Fill(dt);
//             if (dt.Rows.Count != 0)
//             {
//                 Console.WriteLine("Sid\tName\tAddress");
//                 for (int i = 0; i < dt.Rows.Count; i++)
//                 {
//                     string id = dt.Rows[i]["Sid"].ToString();
//                     string name = dt.Rows[i]["name"].ToString();
//                     string address = dt.Rows[i]["address"].ToString();
//                     Console.WriteLine(id + "\t" + name + "\t" + address);
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("No records found.");
//             }
//         }

//         static void Main(string[] args)
//         {
//             Program obj = new Program();
//             try
//             {
//                 obj.CreateConnection();
//             Start:
//                 Console.WriteLine("1.Insert\t2.Update\t3.Delete\t4.Select");
//                 Console.WriteLine("Enter your choice:");
//                 int n = Convert.ToInt32(Console.ReadLine());
//                 string sql = "", name = "", add = "";
//                 int id = 0;
//                 switch (n)
//                 {
//                     case 1:
//                         Console.WriteLine("Enter Name of Student:");
//                         name = Console.ReadLine();
//                         Console.WriteLine("Enter Address of Student:");
//                         add = Console.ReadLine();
//                         sql = "INSERT INTO tblStudent(name,address) VALUES ('" + name + "','" + add + "')";
//                         obj.InsertUpdateDelete(sql);
//                         break;

//                     case 2:
//                         Console.WriteLine("Enter ID to be updated:");
//                         id = Convert.ToInt32(Console.ReadLine());
//                         Console.WriteLine("Enter name of student:");
//                         name = Console.ReadLine();
//                         Console.WriteLine("Enter address of Student:");
//                         add = Console.ReadLine();
//                         sql = "UPDATE tblStudent SET name='" + name + "', address='" + add + "' WHERE sid=" + id;
//                         obj.InsertUpdateDelete(sql);
//                         break;

//                     case 3:
//                         Console.WriteLine("Enter id to be deleted:");
//                         id = Convert.ToInt32(Console.ReadLine());
//                         sql = "DELETE FROM tblStudent WHERE sid=" + id;
//                         obj.InsertUpdateDelete(sql);
//                         break;

//                     case 4:
//                         sql = "SELECT * FROM tblStudent";
//                         obj.SelectRecords(sql);
//                         break;

//                     default:
//                         Console.WriteLine("Invalid Choice");
//                         break;
//                 }
//                 goto Start;
//             }
//             catch (Exception e)
//             {
//                 Console.WriteLine(e.Message);
//                 Console.WriteLine("Connection Failed !");
//             }
//             Console.ReadKey();
//         }
//     }
// }
