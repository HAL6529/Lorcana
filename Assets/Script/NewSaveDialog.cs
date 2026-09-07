using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewSaveDialog : MonoBehaviour
{
    public DialogManager m_DialogManager;

    public InputField m_InputField;

    public EditCardPanelManager m_EditCardPanelManager;

    private const string Extension = ".txt";

    private ExtendUtil m_ExtendUtil = new ExtendUtil();

    public void Close()
    {
        this.gameObject.SetActive(false);
    }

    public void onCloseBtn()
    {
        m_DialogManager.AllClose();
    }

    public void onOKBtn()
    {
        string SecureDataPass = m_ExtendUtil.GetSecureDataPath();
        if (SecureDataPass == "")
        {
            m_DialogManager.AllClose();
            m_DialogManager.OKDialog_Open(EnumController.OKBtnParamater.NotFoundSecureDataPass);
            return;
        }

        if (m_InputField.text == "")
        {
            m_DialogManager.AllClose();
            m_DialogManager.OKDialog_Open(EnumController.OKBtnParamater.NamelessError);
            return;
        }

        //string pass = SecureDataPass + "/Save";

        string pass = SecureDataPass;
        string file = m_ExtendUtil.ConvertToUTF8FromString(m_InputField.text) + Extension;

        try
        {
            /*AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
            AndroidJavaObject cacheDir = currentActivity.Call<AndroidJavaObject>("getCacheDir");*/

            // Create a File object pointing to a new file in the cache directory
            using (AndroidJavaObject cachedFile = new AndroidJavaObject("java.io.File", pass, file)) 
            {
                cachedFile.Call<bool>("createNewFile");
            }
            m_DialogManager.AllClose();
            m_DialogManager.OKDialog_Open(EnumController.OKBtnParamater.SuccessFileCreate);
            return;
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
        m_DialogManager.AllClose();
        m_DialogManager.OKDialog_Open(EnumController.OKBtnParamater.FailedFileCreate);
        return;
    }

    private string CreateSaveData()
    {
        string SaveData = "";
        List<CardInfo> list = m_EditCardPanelManager.DeckList;
        for (int i = 0; i < m_EditCardPanelManager.DeckList.Count; i++)
        {
            if (i != 0)
            {
                SaveData += ",";
            }
            SaveData += list[i].GetCardNo();
        }
        return SaveData;
    }

    public void Open()
    {
        m_InputField.text = "";
        this.gameObject.SetActive(true);
    }
}
