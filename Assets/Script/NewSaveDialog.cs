using System;
using System.IO;
using System.Text;
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

        string pass = SecureDataPass;
        string file = m_ExtendUtil.ConvertToUTF8FromString(m_InputField.text) + Extension;

        try
        {
            FileStream fs = File.Create(SecureDataPass + "/" + file);
            fs.Close();

            // 文字コードを指定
            Encoding enc = Encoding.GetEncoding("utf-8");

            StreamWriter sw = new StreamWriter(SecureDataPass + "/" + file, false, enc);
            sw.WriteLine(CreateSaveData());
            sw.Close();

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
        string SaveData = m_InputField.text;
        SaveData += ",003_JA_01";
        List<CardInfo> list = m_EditCardPanelManager.DeckList;
        for (int i = 0; i < m_EditCardPanelManager.DeckList.Count; i++)
        {
            SaveData += ",";
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
