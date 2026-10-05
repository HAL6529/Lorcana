using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu_Menu : MonoBehaviour
{
    public List<Menu_SelectDeckPanel> list = new List<Menu_SelectDeckPanel>();

    private ExtendUtil m_ExtendUtil = new ExtendUtil();

    public RectTransform CanvasRectTransform;

    public RectTransform ScrollView_Parent;
    public RectTransform ScrollView_Space;
    public RectTransform ScrollView;
    public RectTransform Header_Parent_Parent;
    public RectTransform Header_Parent;
    public RectTransform Header_Text;
    public RectTransform Header_CreateBtn;

    public void Start()
    {
        float magnification_x = CanvasRectTransform.sizeDelta.x / 890;
        float magnification_y = CanvasRectTransform.sizeDelta.y / 1920;

        ScrollView_Parent.sizeDelta = new Vector2(ScrollView_Parent.sizeDelta.x * magnification_x, ScrollView_Parent.sizeDelta.y * magnification_y);
        ScrollView_Space.sizeDelta = new Vector2(ScrollView_Space.sizeDelta.x * magnification_x, ScrollView_Space.sizeDelta.y * magnification_y);
        ScrollView.sizeDelta = new Vector2(ScrollView.sizeDelta.x * magnification_x, ScrollView.sizeDelta.y * magnification_y);
        Header_Parent_Parent.sizeDelta = new Vector2(Header_Parent_Parent.sizeDelta.x * magnification_x, Header_Parent_Parent.sizeDelta.y * magnification_y);
        Header_Parent.sizeDelta = new Vector2(Header_Parent.sizeDelta.x * magnification_x, Header_Parent.sizeDelta.y * magnification_y);
        Header_Text.sizeDelta = new Vector2(Header_Text.sizeDelta.x * magnification_x, Header_Text.sizeDelta.y * magnification_y);

        float magnification = magnification_x;
        if (magnification_x > magnification_y)
        {
            magnification = magnification_y;
        }
        Header_CreateBtn.sizeDelta = new Vector2(Header_CreateBtn.sizeDelta.x * magnification, Header_CreateBtn.sizeDelta.y * magnification);

        for (int i = 0; i < list.Count; i++)
        {
            list[i].UpdateImage(magnification_x, magnification_y);
        }
        Load();
    }

    public void Load()
    {
        try
        {
            //string pass = m_ExtendUtil.GetSecureDataPath() + "/Save";
            string pass = m_ExtendUtil.GetSecureDataPath();
            List<string> SaveDataList = new List<string>(Directory.GetFiles(pass));

            for (int i = 0; i < list.Count; i++)
            {
                if (i > SaveDataList.Count - 1)
                {
                    list[i].SetSaveData(new SaveData());
                    continue;
                }
                StreamReader sr = new StreamReader(SaveDataList[i]);
                string s = sr.ReadToEnd();
                list[i].SetSaveData(new SaveData(s, SaveDataList[i]));
                sr.Close();
            }
        }catch(Exception e)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i].SetText("");
            }
        }
    }

    public void onNewProjectBtn()
    {
        SaveData m_SaveData = new SaveData();
        SaveDataStatic m_SaveDataStatic = new SaveDataStatic(m_SaveData);
        SceneManager.LoadScene("DeckBuild");
    }
}
