using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu_Menu : MonoBehaviour
{
    public Text m_Text;

    public List<Menu_SelectDeckPanel> list = new List<Menu_SelectDeckPanel>();

    private ExtendUtil m_ExtendUtil = new ExtendUtil();

    public void Start()
    {
        Load();
    }

    public void Load()
    {
        try
        {
            //string pass = m_ExtendUtil.GetSecureDataPath() + "/Save";
            string pass = m_ExtendUtil.GetSecureDataPath();
            List<string> SaveDataList = new List<string>(Directory.GetFiles(pass));
            if (SaveDataList.Count == 0)
            {
                m_Text.text = "ëŒè€Ç»Çµ";
            }
            else
            {
                m_Text.text = "ëŒè€Ç†ÇË:" + SaveDataList.Count;
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (i > SaveDataList.Count - 1)
                {
                    list[i].SetSaveData(new SaveData());
                    continue;
                }

                list[i].SetSaveData(new SaveData("testDeck,171_JA_01,171_JA_01", SaveDataList[i]));
            }
        }catch(Exception e)
        {
            m_Text.text = e.ToString();
            for (int i = 0; i < list.Count; i++)
            {
                list[i].SetText("");
            }
        }
    }

    public void onNewProjectBtn()
    {
        SceneManager.LoadScene("DeckBuild");
    }
}
