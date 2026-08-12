using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public ViewMode m_ViewMode;
    public EditCardPanelManager m_EditCardPanelManager;
    public Text m_Text;

    private const string SaveFileName = "SaveData.txt";

    public void onCloseBtn()
    {
        this.gameObject.SetActive(false);
    }

    public void onDisplayBtn()
    {
        m_ViewMode.Open();
        this.gameObject.SetActive(false);
    }

    public void onMenuBtn()
    {
        SceneManager.LoadScene("Menu");
    }

    public void onNewSave()
    {
        string SecureDataPass = GetSecureDataPath();
        if(SecureDataPass == "")
        {
            return;
        }
        string pass = SecureDataPass + "/" + SaveFileName;

        if (System.IO.File.Exists(pass))
        {
            m_Text.text = pass;
        }
        else
        {
            System.IO.File.Create(pass);
            m_Text.text = "存在しない";
        }
    }

    public void onAddSave()
    {

    }

    private string CreateSaveData(string DeckName, string FavoriteCard)
    {
        string SaveData = "{" + DeckName + "," + FavoriteCard;
        List<CardInfo> list = m_EditCardPanelManager.DeckList;
        for (int i = 0; i < m_EditCardPanelManager.DeckList.Count; i++)
        {
            SaveData += ",";
            SaveData += list[i].GetCardNo();
        }
        SaveData += "}";
        return SaveData;
    }

    private string GetSecureDataPath()
    {
        try
        {
            using (var unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
            using (var currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity"))
            using (var getFilesDir = currentActivity.Call<AndroidJavaObject>("getFilesDir"))
            {
                string secureDataPathForAndroid = getFilesDir.Call<string>("getCanonicalPath");
                return secureDataPathForAndroid;
            }
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }

        // TODO: 本来は各プラットフォームに対応した処理が必要
        //return Application.persistentDataPath;
        return "";
    }

    private void onSave()
    {

    }
}
