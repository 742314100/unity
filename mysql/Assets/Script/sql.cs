using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Data;
using MySql.Data.MySqlClient;


public class sql : MonoBehaviour {

    public Text wenzi;
    
	// Use this for initialization
	void Start () {
        string constructorString = "datasource=127.0.0.1;port=3306;database=python_test;user=root;pwd=admin";
        MySqlConnection conn = new MySqlConnection(constructorString);
        try
        {
            conn.Open();
            Debug.Log("建立链接");
            string sql = "select name from students where gender='保密'";
            //string sql = "select name from students where gender='男'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            Debug.Log(rdr);

            while (rdr.Read())
            {
                Debug.Log(rdr.GetString(rdr.GetOrdinal("name")));
                wenzi.text = rdr.GetString(rdr.GetOrdinal("name"));
                //wenzi.text = rdr.GetString(rdr.GetOrdinal("name"));
            }
         }
        catch(MySqlException ex)
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
	
	// Update is called once per frame
	void Update () {
		
	}
}
