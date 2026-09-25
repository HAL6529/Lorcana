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
        SceneManager.LoadScene("DeckBuild");
    }
}
