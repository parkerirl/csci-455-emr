﻿//Code for connecting application to MySQL Database
//based off of https://www.codeproject.com/Articles/43438/Connect-C-to-MySQL

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
      server = "localhost"; //connect to localhost
      database = "emrs_csci_455"; //schema to connect to in MySQL
      uid = "root"; //MySQL Server Username !!!THIS IS HARDCODED, MUST CHANGE TO YOUR CONFIGURATION'S USERNAME BEFORE IT WILL WORK!!!
      password = "password"; //MySQL Server Password !!!THIS IS HARDCODED, MUST CHANGE TO YOUR CONFIGURATION'S PASSWORD BEFORE IT WILL WORK!!!

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
        String ssn, //varchar(11)
        String first_name, //varchar(45)
        String last_name, //varchar(45)
        String address, //varchar(45)
        String email, //varchar(45)
        String phone, //varchar(45)
        String sex, //varchar(1)
        String birthday, //date
        String blood_type, //varchar(45)
        String primary_physician, //varchar(45)
        String ins_provider, //varchar(45)
        String ins_number //varchar(45)
      )
    {
      string query = $"INSERT INTO patients (ssn, first_name, last_name, address, email, phone, sex, birthday, blood_type, primary_physician, ins_provider, ins_number) " +
        $"VALUES('{ssn}', '{first_name}', '{last_name}', '{address}', '{email}', '{phone}', '{sex}', '{birthday}', '{blood_type}', '{primary_physician}', '{ins_provider}', '{ins_number}');";

      //open connection
      if (this.OpenConnection() == true)
      {

        //create command and assign the query and connection from the constructor
        MySqlCommand cmd = new MySqlCommand(query, connection);

        try
        {
          //Execute command
          cmd.ExecuteNonQuery();
        }
        catch (MySqlException ex)
        {
          MessageBox.Show(ex.Message);
        }

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
    public void Delete() { }

    //select
    public List<string>[] Select(String ssn)
    {
      string query = $"SELECT first_name, last_name, birthday, ins_provider, address, email, phone, sex, primary_physician, blood_type, ins_number, ssn FROM patients WHERE patients.ssn = {ssn}";

      //Create a list to store the result
      List<string>[] list = new List<string>[12];
      list[0] = new List<string>(); //first_name
      list[1] = new List<string>(); //last_name
      list[2] = new List<string>(); //birthday
      list[3] = new List<string>(); //ins_provider
      list[4] = new List<string>(); //address
      list[5] = new List<string>(); //email
      list[6] = new List<string>(); //phone
      list[7] = new List<string>(); //sex
      list[8] = new List<string>(); //primary_physician
      list[9] = new List<string>(); //blood_type
      list[10] = new List<string>(); //ins_number
      list[11] = new List<string>(); //ssn

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
          list[0].Add(dataReader["first_name"].ToString());
          list[1].Add(dataReader["last_name"].ToString());
          list[2].Add(dataReader["birthday"].ToString().Split(' ')[0] + "");
          list[3].Add(dataReader["ins_provider"].ToString());
          list[4].Add(dataReader["address"].ToString());
          list[5].Add(dataReader["email"].ToString());
          list[6].Add(dataReader["phone"].ToString());
          list[7].Add(dataReader["sex"].ToString());
          list[8].Add(dataReader["primary_physician"].ToString());
          list[9].Add(dataReader["blood_type"].ToString());
          list[10].Add(dataReader["ins_number"].ToString());
          list[11].Add(dataReader["ssn"].ToString());
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

    public List<string>[] SelectByName(String name)
    {
      string query = $"SELECT first_name, last_name, birthday, ins_provider, address, email, phone, sex, primary_physician, blood_type, ins_number, ssn FROM patients WHERE patients.first_name = '{name}'";

      //Create a list to store the result
      List<string>[] list = new List<string>[12];
      list[0] = new List<string>(); //first_name
      list[1] = new List<string>(); //last_name
      list[2] = new List<string>(); //birthday
      list[3] = new List<string>(); //ins_provider
      list[4] = new List<string>(); //address
      list[5] = new List<string>(); //email
      list[6] = new List<string>(); //phone
      list[7] = new List<string>(); //sex
      list[8] = new List<string>(); //primary_physician
      list[9] = new List<string>(); //blood_type
      list[10] = new List<string>(); //ins_number
      list[11] = new List<string>(); //ssn
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
          list[0].Add(dataReader["first_name"].ToString());
          list[1].Add(dataReader["last_name"].ToString());
          list[2].Add(dataReader["birthday"].ToString().Split(' ')[0]);
          list[3].Add(dataReader["ins_provider"].ToString());
          list[4].Add(dataReader["address"].ToString());
          list[5].Add(dataReader["email"].ToString());
          list[6].Add(dataReader["phone"].ToString());
          list[7].Add(dataReader["sex"].ToString());
          list[8].Add(dataReader["primary_physician"].ToString());
          list[9].Add(dataReader["blood_type"].ToString());
          list[10].Add(dataReader["ins_number"].ToString());
          list[11].Add(dataReader["ssn"].ToString());
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

    public void AddPrescription(String ssn, String dosage, String medication, String exp)
    {
      if (this.OpenConnection() == true)
      {
        string query = $"INSERT INTO prescriptions VALUES ({ssn}, {dosage}, {medication}, {exp})";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        try
        {
          cmd.ExecuteNonQuery();
        }
        catch (MySqlException ex)
        {
          MessageBox.Show(ex.Message);
        }
        this.CloseConnection();
      }
    }

    public void RemovePrescription(String ssn, String dosage, String medication, String exp)
    {
      if (this.OpenConnection() == true)
      {
        string query = $"DELETE FROM prescriptions WHERE prescriptions.patient_ssn = {ssn} AND prescriptions.dosage = {dosage} AND prescriptions.medication = {medication} AND prescriptions.expiration = {exp}";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        try
        {
          cmd.ExecuteNonQuery();
        }
        catch (MySqlException ex)
        {
          MessageBox.Show(ex.Message);
        }
        this.CloseConnection();
      }
    }

    public List<string>[] ViewAllPrescription(String ssn)
    {
      List<string>[] list = new List<string>[3];
      list[0] = new List<string>(); //dosage
      list[1] = new List<string>(); //medication
      list[2] = new List<string>(); //expiration

      if (this.OpenConnection() == true)
      {
        string query = $"SELECT dosage, medication, expiration FROM prescriptions WHERE prescriptions.patient_ssn = {ssn}";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        MySqlDataReader dataReader = cmd.ExecuteReader();

        //Read the data and store them in the list
        while (dataReader.Read())
        {
          list[0].Add(dataReader["dosage"].ToString());
          list[1].Add(dataReader["medication"].ToString());
          list[2].Add(dataReader["expiration"].ToString());
        }
        this.CloseConnection();
      }
      return list;
    }

    public void AddAllergies(String ssn, String allergy, String date)
    {
      if (this.OpenConnection() == true)
      {
        string query = $"INSERT INTO allergies VALUES ({ssn}, {allergy}, {date})";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        try
        {
          cmd.ExecuteNonQuery();
        }
        catch (MySqlException ex)
        {
          MessageBox.Show(ex.Message);
        }
        this.CloseConnection();
      }
    }

    public void RemoveAllergies(String ssn, String allergy, String date)
    {
      if (this.OpenConnection() == true)
      {
        string query = $"DELETE FROM allergies WHERE allergies.patient_ssn = {ssn} AND allergies.allergy = {allergy} AND allergies.date_discovered = {date}";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        try
        {
          cmd.ExecuteNonQuery();
        }
        catch (MySqlException ex)
        {
          MessageBox.Show(ex.Message);
        }
        this.CloseConnection();
      }
    }

    public List<string>[] ViewAllAllergies(String ssn)
    {
      List<string>[] list = new List<string>[2];
      list[0] = new List<string>(); //allergy
      list[1] = new List<string>(); //date

      if (this.OpenConnection() == true)
      {
        string query = $"SELECT allergy, date_discovered FROM allergies WHERE allergies.patient_ssn = {ssn}";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        MySqlDataReader dataReader = cmd.ExecuteReader();

        //Read the data and store them in the list
        while (dataReader.Read())
        {
          list[0].Add(dataReader["allergy"].ToString());
          list[1].Add(dataReader["date_discovered"].ToString());
        }
        this.CloseConnection();
      }
      return list;
    }

    public void AddEmerContact(String ssn, String relationship, String fName, String lName, String phone)
    {
      if (this.OpenConnection() == true)
      {
        string query = $"INSERT INTO emergency_contact VALUES ({ssn}, {relationship}, {fName}, {lName}, {phone})";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        try
        {
          cmd.ExecuteNonQuery();
        }
        catch (MySqlException ex)
        {
          MessageBox.Show(ex.Message);
        }
        this.CloseConnection();
      }
    }

    public void RemoveEmerContact(String ssn, String relationship, String fName, String lName, String phone)
    {
      if (this.OpenConnection() == true)
      {
        string query = $"DELETE FROM emergency_contact WHERE emergency_contact.patient_ssn = {ssn} AND emergency_contact.relationship = {relationship} AND emergency_contact.first_name = {fName} AND emergency_contact.last_name = {lName} AND emergency_contact.phone = {phone}";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        try
        {
          cmd.ExecuteNonQuery();
        }
        catch (MySqlException ex)
        {
          MessageBox.Show(ex.Message);
        }
        this.CloseConnection();
      }
    }

    public List<string>[] ViewEmerContacts(String ssn)
    {
      List<string>[] list = new List<string>[4];
      list[0] = new List<string>(); //relationship
      list[1] = new List<string>(); //first
      list[2] = new List<string>(); //last
      list[3] = new List<string>(); //phone

      if (this.OpenConnection() == true)
      {
        string query = $"SELECT relationship, first_name, last_name, phone FROM emergency_contact WHERE emergency_contact.patient_ssn = {ssn}";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        MySqlDataReader dataReader = cmd.ExecuteReader();

        //Read the data and store them in the list
        while (dataReader.Read())
        {
          list[0].Add(dataReader["relationship"].ToString());
          list[1].Add(dataReader["first_name"].ToString());
          list[2].Add(dataReader["last_name"].ToString());
          list[3].Add(dataReader["phone"].ToString());
        }
        this.CloseConnection();
      }
      return list;
    }

    public void AddFamilyMedHistory(String ssn, String relationship, String disease, String age)
    {
      int _age = Int32.Parse(age);
      if (this.OpenConnection() == true)
      {
        string query = $"INSERT INTO family_medical_history VALUES ({ssn}, {relationship}, {disease}, {_age})";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        try
        {
          cmd.ExecuteNonQuery();
        }
        catch (MySqlException ex)
        {
          MessageBox.Show(ex.Message);
        }
        this.CloseConnection();
      }
    }

    public void RemoveFamilyMedHistory(String ssn, String relationship, String disease, String age)
    {
      int _age = Int32.Parse(age);
      if (this.OpenConnection() == true)
      {
        string query = $"DELETE FROM family_medical_history WHERE family_medical_history.patient_ssn = {ssn} AND family_medical_history.relationship = {relationship} AND family_medical_history.disease = {disease} AND family_medical_history.age = {_age}";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        try
        {
          cmd.ExecuteNonQuery();
        }
        catch (MySqlException ex)
        {
          MessageBox.Show(ex.Message);
        }
        this.CloseConnection();
      }
    }

    public List<string>[] ViewFamilyMedHistory(String ssn)
    {
      List<string>[] list = new List<string>[3];
      list[0] = new List<string>(); //relationship
      list[1] = new List<string>(); //disease
      list[2] = new List<string>(); //age

      if (this.OpenConnection() == true)
      {
        string query = $"SELECT relationship, disease, age FROM family_medical_history WHERE family_medical_history.patient_ssn = {ssn}";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        MySqlDataReader dataReader = cmd.ExecuteReader();

        //Read the data and store them in the list
        while (dataReader.Read())
        {
          list[0].Add(dataReader["relationship"].ToString());
          list[1].Add(dataReader["disease"].ToString());
          list[2].Add(dataReader["age"].ToString());
        }
        this.CloseConnection();
      }
      return list;
    }

    public void AddMedHistory(String ssn, String injury, bool hospitalized, bool surgery, String date)
    {
      if (this.OpenConnection() == true)
      {
        string query = $"INSERT INTO medical_history VALUES ({ssn}, {injury}, {hospitalized}, {surgery}, {date})";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        try
        {
          cmd.ExecuteNonQuery();
        }
        catch (MySqlException ex)
        {
          MessageBox.Show(ex.Message);
        }
        this.CloseConnection();
      }
    }

    public void RemoveMedHistory(String ssn, String injury, bool hospitalized, bool surgery, String date)
    {
      if (this.OpenConnection() == true)
      {
        string query = $"DELETE FROM medical_history WHERE medical_history.patient_ssn = {ssn} AND medical_history.injury = {injury} AND medical_history.hospitalized = {hospitalized} AND medical_history.surgery = {surgery} AND medical_history.date = {date}";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        try
        {
          cmd.ExecuteNonQuery();
        }
        catch (MySqlException ex)
        {
          MessageBox.Show(ex.Message);
        }
        this.CloseConnection();
      }
    }

    public List<string>[] ViewMedHistory(String ssn)
    {
      List<string>[] list = new List<string>[4];
      list[0] = new List<string>(); //injury
      list[1] = new List<string>(); //hospitalized
      list[2] = new List<string>(); //surgery
      list[3] = new List<string>(); //date

      if (this.OpenConnection() == true)
      {
        string query = $"SELECT injury, hospitalized, surgery, date FROM medical_history WHERE medical_history.patient_ssn = {ssn}";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        MySqlDataReader dataReader = cmd.ExecuteReader();

        //Read the data and store them in the list
        while (dataReader.Read())
        {
          list[0].Add(dataReader["injury"].ToString());
          list[1].Add((bool)dataReader["hospitalized"] ? "True" : null);
          list[2].Add((bool)dataReader["surgery"] ? "True" : null);
          list[3].Add(dataReader["date"].ToString().Split(' ')[0]);
        }
        this.CloseConnection();
      }
      return list;
    }

    public void AddUser(String ssn, String fName, String lName, String email, String address, String phone, String position)
    {
      if (this.OpenConnection() == true)
      {
        string query = $"INSERT INTO users VALUES ({ssn}, {fName}, {lName}, {email}, {address}, {phone}, {position})";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        try
        {
          cmd.ExecuteNonQuery();
        }
        catch (MySqlException ex)
        {
          MessageBox.Show(ex.Message);
        }
        this.CloseConnection();
      }
    }

    public void RemoveUser(String ssn)
    {
      if (this.OpenConnection() == true)
      {
        string query = $"DELETE FROM users WHERE users.ssn = {ssn}";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        try
        {
          cmd.ExecuteNonQuery();
        }
        catch (MySqlException ex)
        {
          MessageBox.Show(ex.Message);
        }
        this.CloseConnection();
      }
    }

    public List<string>[] ViewUser(String ssn)
    {
      List<string>[] list = new List<string>[7];
      list[0] = new List<string>(); //ssn
      list[1] = new List<string>(); //first
      list[2] = new List<string>(); //last
      list[3] = new List<string>(); //email
      list[4] = new List<string>(); //address
      list[5] = new List<string>(); //phone
      list[6] = new List<string>(); //position

      if (this.OpenConnection() == true)
      {
        string query = $"SELECT ssn, first_name, last_name, email, address, phone, position FROM users WHERE users.ssn = {ssn}";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        MySqlDataReader dataReader = cmd.ExecuteReader();

        //Read the data and store them in the list
        while (dataReader.Read())
        {
          list[0].Add(dataReader["ssn"].ToString());
          list[1].Add(dataReader["first_name"].ToString());
          list[2].Add(dataReader["last_name"].ToString());
          list[3].Add(dataReader["email"].ToString());
          list[4].Add(dataReader["address"].ToString());
          list[5].Add(dataReader["phone"].ToString());
          list[6].Add(dataReader["position"].ToString());
        }
        this.CloseConnection();
      }
      return list;
    }

    public List<string>[] ViewAllUsers()
    {
      List<string>[] list = new List<string>[4];
      list[0] = new List<string>(); //ssn
      list[1] = new List<string>(); //first
      list[2] = new List<string>(); //last
      list[3] = new List<string>(); //position

      if (this.OpenConnection() == true)
      {
        string query = $"SELECT ssn, first_name, last_name, position FROM users";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        MySqlDataReader dataReader = cmd.ExecuteReader();

        //Read the data and store them in the list
        while (dataReader.Read())
        {
          list[0].Add(dataReader["ssn"].ToString());
          list[1].Add(dataReader["first_name"].ToString());
          list[2].Add(dataReader["last_name"].ToString());
          list[3].Add(dataReader["position"].ToString());
        }
        this.CloseConnection();
      }
      return list;
    }


    public void AddUserAccount(String ssn, String username, String password, String privilege, String status)
    {
      if (this.OpenConnection() == true)
      {
        string query = $"INSERT INTO accounts VALUES ({ssn}, {username}, {password}, {privilege}, {status})";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        try
        {
          cmd.ExecuteNonQuery();
        }
        catch (MySqlException ex)
        {
          MessageBox.Show(ex.Message);
        }
        this.CloseConnection();
      }
    }

    public void RemoveUserAccount(String ssn)
    {
      if (this.OpenConnection() == true)
      {
        string query = $"DELETE FROM accounts WHERE accounts.user_ssn = {ssn}";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        try
        {
          cmd.ExecuteNonQuery();
        }
        catch (MySqlException ex)
        {
          MessageBox.Show(ex.Message);
        }
        this.CloseConnection();
      }
    }

    public List<string>[] ViewAccount(String ssn)
    {
      List<string>[] list = new List<string>[4];
      list[0] = new List<string>(); //username
      list[1] = new List<string>(); //password
      list[2] = new List<string>(); //privilege
      list[3] = new List<string>(); //status

      if (this.OpenConnection() == true)
      {
        string query = $"SELECT username, password, privilege, status FROM accounts WHERE accounts.user_ssn = {ssn}";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        MySqlDataReader dataReader = cmd.ExecuteReader();

        //Read the data and store them in the list
        while (dataReader.Read())
        {
          list[0].Add(dataReader["username"].ToString());
          list[1].Add(dataReader["password"].ToString());
          list[2].Add(dataReader["privilege"].ToString());
          list[3].Add(dataReader["status"].ToString());
        }
        this.CloseConnection();
      }
      return list;
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