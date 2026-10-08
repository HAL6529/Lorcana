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

    public RectTransform Parent;
    public RectTransform Btn_header;
    public RectTransform CloseBtn;
    public RectTransform space1;
    public RectTransform text;
    public RectTransform space2;
    public RectTransform inputField_parent;
    public RectTransform inputField;
    public RectTransform inputField_Btn;
    public RectTransform space3;

    //private const string Extension = ".txt";

    private ExtendUtil m_ExtendUtil = new ExtendUtil();

    public SaveDataStatic m_SaveDataStatic = new SaveDataStatic();

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
        string deckName = m_InputField.text;
        if (SecureDataPass == "")
        {
            m_DialogManager.AllClose();
            m_DialogManager.OKDialog_Open(EnumController.OKBtnParamater.NotFoundSecureDataPass);
            return;
        }

        if (deckName == "")
        {
            m_DialogManager.AllClose();
            m_DialogManager.OKDialog_Open(EnumController.OKBtnParamater.NamelessError);
            return;
        }

        string pass = SecureDataPass;
        m_DialogManager.saveDeckName = deckName;

        List<string> SaveDataList = new List<string>(Directory.GetFiles(SecureDataPass));
        List<string> nameList = new List<string>();

        for(int i = 0; i < SaveDataList.Count; i++)
        {
            StreamReader sr = new StreamReader(SaveDataList[i]);
            string s = sr.ReadToEnd();
            sr.Close();
            string[] array = s.Split(',');
            nameList.Add(array[0]);
        }

        for(int i = 0; i < nameList.Count; i++)
        {
            if (deckName == nameList[i])
            {
                m_DialogManager.YesOrNoDialog_Open(EnumController.YesOrNoParamater.ConfirmOverWrite);
                return;
            }
        }

        m_EditCardPanelManager.DeckName = m_DialogManager.saveDeckName;
        m_DialogManager.Save();
    }

    public void Open()
    {
        m_InputField.text = "";
        this.gameObject.SetActive(true);
    }

    public void UpdateImage(float magnification_x, float magnification_y)
    {
        Parent.sizeDelta = new Vector2(Parent.sizeDelta.x * magnification_x, Parent.sizeDelta.y * magnification_y);
        Btn_header.sizeDelta = new Vector2(Btn_header.sizeDelta.x * magnification_x, Btn_header.sizeDelta.y * magnification_y);
        space1.sizeDelta = new Vector2(space1.sizeDelta.x * magnification_x, space1.sizeDelta.y * magnification_y);
        text.sizeDelta = new Vector2(text.sizeDelta.x * magnification_x, text.sizeDelta.y * magnification_y);
        space2.sizeDelta = new Vector2(space2.sizeDelta.x * magnification_x, space2.sizeDelta.y * magnification_y);
        inputField_parent.sizeDelta = new Vector2(inputField_parent.sizeDelta.x * magnification_x, inputField_parent.sizeDelta.y * magnification_y);
        inputField.sizeDelta = new Vector2(inputField.sizeDelta.x * magnification_x, inputField.sizeDelta.y * magnification_y);
        space3.sizeDelta = new Vector2(space3.sizeDelta.x * magnification_x, space3.sizeDelta.y * magnification_y);

        float magnification = magnification_x;
        if (magnification_x > magnification_y)
        {
            magnification = magnification_y;
        }
        CloseBtn.sizeDelta = new Vector2(CloseBtn.sizeDelta.x * magnification, CloseBtn.sizeDelta.y * magnification);
        inputField_Btn.sizeDelta = new Vector2(inputField_Btn.sizeDelta.x * magnification, inputField_Btn.sizeDelta.y * magnification);
    }
}
