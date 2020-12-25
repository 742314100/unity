using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MySql.Data.MySqlClient;
using UnityEngine.UI;

public class sql : MonoBehaviour {

    public Text wenzi;
    string id;
	// Use this for initialization
	void Start () {
        string constructorString = "datasource=127.0.0.1;port=3306;database=python_test;user=root;pwd=admin";
        MySqlConnection conn = new MySqlConnection(constructorString);
        try
        {
            conn.Open();
            Debug.Log("建立链接");
            string sql = "select * from students";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                wenzi.text = rdr.GetString("author") + rdr.GetString("content");
            }
            Debug.Log(id);
         }
        catch(MySqlException ex)
        {
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
