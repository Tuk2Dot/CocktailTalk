using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static Unity.VisualScripting.Antlr3.Runtime.Tree.TreeWizard;

public class Talk_interaction : MonoBehaviour
{
    private string path;

    public string[] VisitorInfo = new string[5];
    public string visitor;   //손님 이름 저장
    public TMP_Text V_Script;
    public TMP_Text Answer1;
    public TMP_Text Answer2;
    public TMP_Text Answer3;
    public string Reaction1;
    public string Reaction2;
    public string Reaction3;
    public int score1;
    public int score2;
    public int score3;
    public int reward = 0;

    // Start is called before the first frame update
    void Start()
    {
        V_Script.gameObject.SetActive(true);
        Answer1.gameObject.SetActive(true);
        Answer2.gameObject.SetActive(true);
        Answer3.gameObject.SetActive(true);


        VisitorInfo = DataManager.instance.GetVisitorData();
        //visitor = "visitor" + VisitorInfo[0] + ".txt";
        visitor = "visitor1" + ".txt";

        path = Application.dataPath;
        path += "/Scripts/"+visitor;

        Debug.Log(path);

        string[] contents = System.IO.File.ReadAllLines(path);
        if (contents.Length > 0)
        {
            for (int i = 0; i < 11; i++)
            {
                switch (i % 10)
                {
                    case 0:
                        V_Script.text = contents[i];
                        break;
                    case 1:
                        Answer1.text = contents[i];
                        Answer1.gameObject.SetActive(false);
                        break;
                    case 2:
                        Answer2.text = contents[i];
                        Answer2.gameObject.SetActive(false);
                        break;
                    case 3:
                        Answer3.text = contents[i];
                        Answer3.gameObject.SetActive(false);
                        break;
                    case 4:
                        Reaction1 = contents[i];
                        break;
                    case 5:
                        Reaction2 = contents[i];
                        break;
                    case 6:
                        Reaction3 = contents[i];
                        break;
                    case 7:
                        score1 = int.Parse(contents[i]);
                        break;
                    case 8:
                        score2 = int.Parse(contents[i]);
                        break;
                    case 9:
                        score3 = int.Parse(contents[i]);
                        break;
                    default:
                        break;

                }
            }
        }

    }

    public void ScriptButton()
    {
        Answer1.gameObject.SetActive(true);
        Answer2.gameObject.SetActive(true);
        Answer3.gameObject.SetActive(true);
    }
    public void SelectButton1()
    {
        V_Script.text = Reaction1;
        reward += score1;
        Answer2.gameObject.SetActive(false);
        Answer3.gameObject.SetActive(false);

    }
    public void SelectButton2()
    {
        V_Script.text = Reaction2;
        reward += score2;
        Answer1.gameObject.SetActive(false);
        Answer3.gameObject.SetActive(false);
    }

    public void SelectButton3()
    {
        V_Script.text = Reaction3;
        reward += score3;
        Answer1.gameObject.SetActive(false);
        Answer2.gameObject.SetActive(false);
    }

}
