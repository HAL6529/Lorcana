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
    //public List<Menu_SelectDeckPanel> list = new List<Menu_SelectDeckPanel>();

    private ExtendUtil m_ExtendUtil = new ExtendUtil();

    public RectTransform CanvasRectTransform;

    public RectTransform ScrollView_Parent;
    public RectTransform ScrollView_Space;
    public RectTransform ScrollView;
    public RectTransform content;
    public RectTransform Header_Parent_Parent;
    public RectTransform Header_Parent;
    public RectTransform Header_Header_CreateBtn;
    public RectTransform Header_CreateBtn;

    private List<string> SaveData_stringList = new List<string>();
    private List<SaveData> SaveDataList = new List<SaveData>();

    public void Start()
    {
        float magnification_x = CanvasRectTransform.sizeDelta.x / 890;
        float magnification_y = CanvasRectTransform.sizeDelta.y / 1920;

        ScrollView_Parent.sizeDelta = new Vector2(ScrollView_Parent.sizeDelta.x * magnification_x, ScrollView_Parent.sizeDelta.y * magnification_y);
        ScrollView_Space.sizeDelta = new Vector2(ScrollView_Space.sizeDelta.x * magnification_x, ScrollView_Space.sizeDelta.y * magnification_y);
        ScrollView.sizeDelta = new Vector2(ScrollView.sizeDelta.x * magnification_x, ScrollView.sizeDelta.y * magnification_y);
        content.sizeDelta = new Vector2(content.sizeDelta.x * magnification_x, content.sizeDelta.y * magnification_y);
        Header_Parent_Parent.sizeDelta = new Vector2(Header_Parent_Parent.sizeDelta.x * magnification_x, Header_Parent_Parent.sizeDelta.y * magnification_y);
        Header_Parent.sizeDelta = new Vector2(Header_Parent.sizeDelta.x * magnification_x, Header_Parent.sizeDelta.y * magnification_y);
        Header_Header_CreateBtn.sizeDelta = new Vector2(Header_Header_CreateBtn.sizeDelta.x * magnification_x, Header_Header_CreateBtn.sizeDelta.y * magnification_y);
        //Header_Text.sizeDelta = new Vector2(Header_Text.sizeDelta.x * magnification_x, Header_Text.sizeDelta.y * magnification_y);

        float magnification = magnification_x;
        if (magnification_x > magnification_y)
        {
            magnification = magnification_y;
        }
        Header_CreateBtn.sizeDelta = new Vector2(Header_CreateBtn.sizeDelta.x * magnification, Header_CreateBtn.sizeDelta.y * magnification);

        Load();
    }

    public int GetSaveDataListCount()
    {
        return SaveDataList.Count;
    }

    public SaveData GetSaveDataList(int index)
    {
        if(index > SaveData_stringList.Count - 1)
        {
            return new SaveData();
        }
        return SaveDataList[index];
    }

    public void Load()
    {
        try
        {
            SaveDataList = new List<SaveData>();
            //string pass = m_ExtendUtil.GetSecureDataPath() + "/Save";
            string pass = m_ExtendUtil.GetSecureDataPath();
            if (pass == "")
            {
                SaveData_stringList = new List<string>();
                return;
            }

            SaveData_stringList = new List<string>(Directory.GetFiles(pass));

            for (int i = 0; i < SaveData_stringList.Count; i++)
            {
                StreamReader sr = new StreamReader(SaveData_stringList[i]);
                string s = sr.ReadToEnd();
                SaveDataList.Add(new SaveData(s, SaveData_stringList[i]));
                sr.Close();
            }
        }
        catch (Exception e)
        {

        }
    }

    public void onNewProjectBtn()
    {
        SaveData m_SaveData = new SaveData();
        SaveDataStatic m_SaveDataStatic = new SaveDataStatic(m_SaveData);
        StartCoroutine(LoadSceneCoroutine("DeckBuild"));
    }

    private IEnumerator LoadSceneCoroutine(string sceneName)
    {
        // 非同期でシーン読み込み開始
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

        // 読み込みが完了するまで待機（進捗率をUIに反映することも可能）
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
