using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public NewSaveDialog m_NewSaveDialog;

    public OKDialog m_OKDialog;

    public YesOrNoDialog m_YesOrNoDialog;

    public RectTransform Parent;

    public EditCardPanelManager m_EditCardPanelManager;
    public SaveDataStatic m_SaveDataStatic = new SaveDataStatic();
    private ExtendUtil m_ExtendUtil = new ExtendUtil();

    public string saveDeckName;
    public string saveDeckFile;

    public void AllClose()
    {
        m_NewSaveDialog.Close();
        m_OKDialog.Close();
        m_YesOrNoDialog.Close();
        this.gameObject.SetActive(false);
    }

    public void NewSaveDialog_Open()
    {
        this.gameObject.SetActive(true);
        m_NewSaveDialog.Open();
    }

    public void OKDialog_Open(EnumController.OKBtnParamater paramater)
    {
        this.gameObject.SetActive(true);
        m_OKDialog.Open(paramater);
    }

    public void YesOrNoDialog_Open(EnumController.YesOrNoParamater paramater)
    {
        this.gameObject.SetActive(true);
        m_YesOrNoDialog.Open(paramater);
    }

    public void UpdateImage(float magnification_x, float magnification_y)
    {
        Parent.sizeDelta = new Vector2(Parent.sizeDelta.x * magnification_x, Parent.sizeDelta.y * magnification_y);
        m_NewSaveDialog.UpdateImage(magnification_x, magnification_y);
        m_OKDialog.UpdateImage(magnification_x, magnification_y);
        m_YesOrNoDialog.UpdateImage(magnification_x, magnification_y);
    }

    public void Save()
    {
        string SecureDataPass = m_ExtendUtil.GetSecureDataPath();
        try
        {
            // 文字コードを指定
            Encoding enc = Encoding.GetEncoding("utf-8");

            StreamWriter sw = new StreamWriter(SecureDataPass + "/" + saveDeckFile, false, enc);
            sw.WriteLine(CreateSaveData());
            sw.Close();

            AllClose();
            OKDialog_Open(EnumController.OKBtnParamater.SuccessFileCreate);
            return;
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
        AllClose();
        OKDialog_Open(EnumController.OKBtnParamater.FailedFileCreate);
        return;
    }

    private string CreateSaveData()
    {
        string SaveData = saveDeckName;
        m_EditCardPanelManager.DeckName = saveDeckName;
        SaveData += ",";

        List<EnumController.Colors> colors = new List<EnumController.Colors>();
        for (int i = 0; i < m_EditCardPanelManager.DeckList.Count; i++)
        {
            List<EnumController.Colors> temp = m_EditCardPanelManager.DeckList[i].GetColor();
            for (int k = 0; k < temp.Count; k++)
            {
                if (colors.Contains(temp[k]))
                {
                    continue;
                }
                else
                {
                    colors.Add(temp[k]);
                }
            }
        }

        if (colors.Contains(EnumController.Colors.Amethyst))
        {
            SaveData += "Amethyst";
        }
        else
        {
            SaveData += "None";
        }
        SaveData += ",";

        if (colors.Contains(EnumController.Colors.Amber))
        {
            SaveData += "Amber";
        }
        else
        {
            SaveData += "None";
        }
        SaveData += ",";

        if (colors.Contains(EnumController.Colors.Emerald))
        {
            SaveData += "Emerald";
        }
        else
        {
            SaveData += "None";
        }
        SaveData += ",";

        if (colors.Contains(EnumController.Colors.Sapphire))
        {
            SaveData += "Sapphire";
        }
        else
        {
            SaveData += "None";
        }
        SaveData += ",";

        if (colors.Contains(EnumController.Colors.Steel))
        {
            SaveData += "Steel";
        }
        else
        {
            SaveData += "None";
        }
        SaveData += ",";

        if (colors.Contains(EnumController.Colors.Ruby))
        {
            SaveData += "Ruby";
        }
        else
        {
            SaveData += "None";
        }
        SaveData += ",";

        SaveData += m_SaveDataStatic.GetFavoriteCardInfo().GetCardNo();
        List<CardInfo> list = m_EditCardPanelManager.DeckList;
        for (int i = 0; i < m_EditCardPanelManager.DeckList.Count; i++)
        {
            SaveData += ",";
            SaveData += list[i].GetCardNo();
        }
        SaveData += ",";
        return SaveData;
    }
}
