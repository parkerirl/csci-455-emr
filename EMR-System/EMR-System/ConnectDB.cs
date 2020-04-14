//Code for connecting application to MySQL Database
//based off of https://www.codeproject.com/Articles/43438/Connect-C-to-MySQL

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EMR_System
{
	public class ConnectDB
	{
		private MySqlConnection connection;
		private string server;
		private string database;
		private string uid;
		private string password;

		//constructor
		public ConnectDB()
		{
			Initialize();
		}

		//init values
		private void Initialize()
		{
			server = "localhost";       //connect to localhost
			database = "emrs_csci_455"; //schema to connect to in MySQL
			uid = "root";				//MySQL Server Username !!!THIS IS HARDCODED, MUST CHANGE TO YOUR CONFIGURATION'S USERNAME BEFORE IT WILL WORK!!!
			password = "Jigjag$0";      //MySQL Server Password !!!THIS IS HARDCODED, MUST CHANGE TO YOUR CONFIGURATION'S PASSWORD BEFORE IT WILL WORK!!!

			string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
				database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

			connection = new MySqlConnection(connectionString);
		}

		//open connection to DB
		private bool OpenConnection()
		{
			try
			{
				connection.Open();
				return true;
			}
			catch (MySqlException ex)
			{
				//When handling errors, you can your application's response based 
				//on the error number.
				//The two most common error numbers when connecting are as follows:
				//0: Cannot connect to server.
				//1045: Invalid user name and/or password.
				switch (ex.Number)
				{
					case 0:
						MessageBox.Show("Cannot connect to server.  Contact administrator");
						break;

					case 1045:
						MessageBox.Show("Invalid username/password, please try again");
						break;
				}
				return false;
			}
		}

		//close connection to DB
		private bool CloseConnection()
		{
			try
			{
				connection.Close();
				return true;
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message);
				return false;
			}
		}

		//insert
		public void InsertPatient
			(
				String ssn,					//varchar(11)
				String first_name,			//varchar(45)
				String last_name,           //varchar(45)
				String address,             //varchar(45)
				String email,               //varchar(45)
				String phone,               //varchar(45)
				String sex,					//varchar(1)
				String birthday,			//date
				String blood_type,          //varchar(45)
				String primary_physician,   //varchar(45)
				String ins_provider,        //varchar(45)
				String ins_number           //varchar(45)
			)
		{
			string query = $"INSERT INTO patients (ssn, first_name, last_name, address, email, phone, sex, birthday, blood_type, primary_physician, ins_provider, ins_number) " +
				$"VALUES('{ssn}', '{first_name}', '{last_name}', '{address}', '{email}', '{phone}', '{sex}', '{birthday}', '{blood_type}', '{primary_physician}', '{ins_provider}', '{ins_number}');";

			//open connection
			if (this.OpenConnection() == true)
			{
				//create command and assign the query and connection from the constructor
				MySqlCommand cmd = new MySqlCommand(query, connection);

				//Execute command
				cmd.ExecuteNonQuery();

				//close connection
				this.CloseConnection();
			}
		}

		//update
		public void Update(String table)
		{
			string query = $"UPDATE { table } SET name='Joe', age='22' WHERE name='John Smith'";

			//Open connection
			if (this.OpenConnection() == true)
			{
				//create mysql command
				MySqlCommand cmd = new MySqlCommand();
				//Assign the query using CommandText
				cmd.CommandText = query;
				//Assign the connection using Connection
				cmd.Connection = connection;

				//Execute query
				cmd.ExecuteNonQuery();

				//close connection
				this.CloseConnection();
			}
		}

		//delete
		public void Delete()
		{
		}

		
		//select
		public List <string> [] Select(String ssn)
		{
			string query = $"SELECT first_name, last_name, birthday, ins_provider FROM patients WHERE patients.ssn = {ssn}";

			//Create a list to store the result
			List<string>[] list = new List<string>[4];
			list[0] = new List<string>();	//first_name
			list[1] = new List<string>();	//last_name
			list[2] = new List<string>();	//birthday
			list[3] = new List<string>();	//ins_provider

			//Open connection
			if (this.OpenConnection() == true)
			{
				//Create Command
				MySqlCommand cmd = new MySqlCommand(query, connection);
				//Create a data reader and Execute the command
				MySqlDataReader dataReader = cmd.ExecuteReader();

				//Read the data and store them in the list
				while (dataReader.Read())
				{
					list[0].Add(dataReader["first_name"]   + "");
					list[1].Add(dataReader["last_name"]    + "");
					list[2].Add(dataReader["birthday"]     + "");
					list[3].Add(dataReader["ins_provider"] + "");
				}

				//close Data Reader
				dataReader.Close();

				//close Connection
				this.CloseConnection();

				//return list to be displayed
				return list;
			}
			else
			{
				return list;
			}
		}
		
		/*
		//count
		public int Count()
		{
		}

		//backup
		public void Backup()
		{
		}

		//restore
		public void Restore()
		{
		}
		*/
	}
}