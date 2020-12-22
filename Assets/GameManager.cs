using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    [System.Serializable]
    public class Rows
    {
        public GameObject[] col;
    }
    public Rows[] row;
    public Transform imgPanel;
    int new_R, new_C;
    bool canPress = true;
    int totalBoxes = Value.row_value * Value.column_value;
    int deadBoxes = 0;
    public GameObject playAgainButton;
    

    void Start()
    {
        print(Value.row_value); print(Value.column_value);

        for (int i = 0; i < Value.row_value; i++)
        {
            for (int j = 0; j < Value.column_value; j++)
            {
                row[i].col[j].SetActive(true);
            }
        }

        for (int i = 0; i < Value.row_value; i++)
        {
            for (int j = 0; j < Value.column_value; j++)
            {
                row[i].col[j].GetComponent<Pos>().r_index = i;
                row[i].col[j].GetComponent<Pos>().c_index = j;
            }
        }


        imgPanel.localPosition = new Vector3(((10 - Value.column_value) * 15), 35 - ((10 - Value.row_value) * 15), imgPanel.localPosition.z);
    }


    public void ImgPressed(Pos p)
    {
        if (canPress)
        {
            canPress = false;

            new_R = p.r_index;
            new_C = p.c_index;
            print(new_R); print(new_C);

            if (!row[new_R].col[new_C].gameObject.CompareTag("Dead"))
            {
                row[new_R].col[new_C].transform.gameObject.tag = "Dead";
                row[new_R].col[new_C].GetComponent<Image>().color = new Color32 (255, 217, 102, 255);
                row[new_R].col[new_C].GetComponent<Button>().enabled = false;
                row[new_R].col[new_C].GetComponent<Pos>().ChangeColor();
                deadBoxes++;
            }
            ShowHighlighted();


            Invoke("ActivatePress", 1.0f);
        }
        
    }

    void ShowHighlighted()
    {
        int i = 1, j = 1;
        while (new_R - i < Value.row_value && new_C - j < Value.column_value && new_R - i >= 0 && new_C - j >= 0)
        {
            if (!row[new_R - i].col[new_C - j].gameObject.CompareTag("Dead"))
            {
                row[new_R - i].col[new_C - j].transform.gameObject.tag = "Dead";
                row[new_R - i].col[new_C - j].GetComponent<Image>().color = new Color32 (198, 224, 180, 255);
                row[new_R - i].col[new_C - j].GetComponent<Button>().enabled = false;
                row[new_R - i].col[new_C - j].GetComponent<Pos>().ChangeColor();
                deadBoxes++;
            }
            else
            {
                break;
            }

            i++; j++;
        }

        i = 1; j = 1;
        while (new_R + i < Value.row_value && new_C - j < Value.column_value && new_R + i >= 0 && new_C - j >= 0)
        {
            if (!row[new_R + i].col[new_C - j].gameObject.CompareTag("Dead"))
            {
                row[new_R + i].col[new_C - j].transform.gameObject.tag = "Dead";
                row[new_R + i].col[new_C - j].GetComponent<Image>().color = new Color32 (198, 224, 180, 255);
                row[new_R + i].col[new_C - j].GetComponent<Button>().enabled = false;
                row[new_R + i].col[new_C - j].GetComponent<Pos>().ChangeColor();
                deadBoxes++;
            }
            else
            {
                break;
            }

            i++; j++;
        }

        i = 1; j = 1;
        while (new_R + i < Value.row_value && new_C + j < Value.column_value && new_R + i >= 0 && new_C + j >= 0)
        {
            if (!row[new_R + i].col[new_C + j].gameObject.CompareTag("Dead"))
            {
                row[new_R + i].col[new_C + j].transform.gameObject.tag = "Dead";
                row[new_R + i].col[new_C + j].GetComponent<Image>().color = new Color32 (198, 224, 180, 255);
                row[new_R + i].col[new_C + j].GetComponent<Button>().enabled = false;
                row[new_R + i].col[new_C + j].GetComponent<Pos>().ChangeColor();
                deadBoxes++;
            }
            else
            {
                break;
            }

            i++; j++;
        }

        i = 1; j = 1;
        while (new_R - i < Value.row_value && new_C + j < Value.column_value && new_R - i >= 0 && new_C + j >= 0)
        {
            if (!row[new_R - i].col[new_C + j].gameObject.CompareTag("Dead"))
            {
                row[new_R - i].col[new_C + j].transform.gameObject.tag = "Dead";
                row[new_R - i].col[new_C + j].GetComponent<Image>().color = new Color32 (198, 224, 180, 255);
                row[new_R - i].col[new_C + j].GetComponent<Button>().enabled = false;
                row[new_R - i].col[new_C + j].GetComponent<Pos>().ChangeColor();
                deadBoxes++;
            }
            else
            {
                break;
            }

            i++; j++;
        }


        if (deadBoxes == totalBoxes)
        {
            Invoke("ShowPlayAgainButton", 1.5f);
        }
    }

    void ActivatePress()
    {
        canPress = true;
    }

    public void GoHome()
    {
        SceneManager.LoadScene("Input");
    }

    void ShowPlayAgainButton()
    {
        playAgainButton.SetActive(true);
    }
}
