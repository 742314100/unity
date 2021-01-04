using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;


public class SqlAccess : MonoBehaviour {

    public static MySqlConnection dbConnection;
    static string host = "127.0.0.1";
    static string id = "root";
    static string pwd = "admin";
    static string database = "login";

    public SqlAccess()
    {
        OpenSql();
    }

    public static void OpenSql()
    {
       
            string constructorString = "datasource=127.0.0.1;port=3306;database=python_test;user=root;pwd=admin";
            MySqlConnection conn = new MySqlConnection(constructorString);
            try
            {
                conn.Open();
                Debug.Log("建立链接");
                
            }
            catch (MySqlException ex)
            {
                Debug.Log("失败");
                Debug.Log(ex.Message);
            }
            finally
            {
                conn.Close();
                Debug.Log("关闭");
            }
        
    }


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
