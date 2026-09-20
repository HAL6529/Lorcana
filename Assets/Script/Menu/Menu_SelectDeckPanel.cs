using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_SelectDeckPanel : MonoBehaviour
{
    public Text m_Text;

    public Image FavoriteImage; 

    private SaveData m_SaveData;

    public Menu_Menu m_Menu_Menu;

    public Menu_ConvertSpriteFromCardNo m_Menu_ConvertSpriteFromCardNo;

    public void SetSaveData(SaveData paramater)
    {
        m_SaveData = paramater;
        SetText(m_SaveData.GetDeckTitle());
        FixImage();
    } 

    public void SetText(string s)
    {
        if(s == "")
        {
            m_Text.text = "";
            this.gameObject.SetActive(false);
        }
        else
        {
            m_Text.text = s;
            this.gameObject.SetActive(true);
        }
    }

    public void onFixBtn()
    {
        SaveDataStatic m_SaveDataStatic = new SaveDataStatic(m_SaveData);
    }

    public void onDeleteBtn()
    {
        string DataPass = m_SaveData.GetSaveDataPass();
        if (DataPass == "")
        {
            return;
        }

        try
        {
            using (AndroidJavaObject fileObject = new AndroidJavaObject("java.io.File", DataPass))
            {
                // ファイルが存在するか確認
                if (fileObject.Call<bool>("exists"))
                {
                    // delete() メソッドを呼び出して削除を実行
                    if (fileObject.Call<bool>("delete"))
                    {
                        m_Menu_Menu.Load();
                        m_Menu_Menu.m_Text.text = "削除成功";
                    }
                    else
                    {
                        m_Menu_Menu.Load();
                        m_Menu_Menu.m_Text.text = "削除失敗:" + DataPass;
                    }

                }
            }
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
    }

    private void FixImage()
    {
        CardInfo c = m_SaveData.GetFavoriteCardInfo();
        FavoriteImage.sprite = m_Menu_ConvertSpriteFromCardNo.ConvertSpriteFromCardNo(c.GetCardNo());
    }   
}
