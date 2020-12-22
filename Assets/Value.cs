using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Value : MonoBehaviour
{
    public static Value v;

    public static int row_value = 10, column_value = 10;

    void Awake()
    {   
        if (v == null)
        {
            v = this;
        }
    }
    
}
