using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pos : MonoBehaviour
{
    public int r_index, c_index;

    public void ChangeColor()
    {
        Invoke("ColorRed", 1.0f);
    }

    void ColorRed()
    {
        GetComponent<Image>().color = new Color32 (192, 0, 0, 255);
    }
}
