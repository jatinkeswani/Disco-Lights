using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InputController : MonoBehaviour
{
    public GameObject error_msg;
    public GameObject row_field, column_field;
    string r, c;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ContinueButton()
    {
        r = row_field.GetComponent<Text>().text;
        c = column_field.GetComponent<Text>().text;
        
        int a = int.Parse(r);
        int b = int.Parse(c);
        
        if (a >= 2 && a <= 10 && b >= 2 && b <= 10)
        {
            Value.row_value = a;
            Value.column_value = b;
            print(Value.row_value);
            print(Value.column_value);
            StartGame();
        }
        else
        {
            error_msg.SetActive(true);
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
