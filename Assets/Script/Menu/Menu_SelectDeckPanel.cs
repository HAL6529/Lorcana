using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu_SelectDeckPanel : MonoBehaviour
{
    public Text m_Text;

    public Image FavoriteImage; 

    private SaveData m_SaveData;

    public Menu_Menu m_Menu_Menu;

    public Menu_ConvertSpriteFromCardNo m_Menu_ConvertSpriteFromCardNo;

    public RectTransform Parent;
    public RectTransform Image_Parent;
    public RectTransform Image_Child;
    public RectTransform Middle_Parent;
    public RectTransform Name;
    public RectTransform Colors;
    public RectTransform Button_Parent;
    public List<RectTransform> ButtonList = new List<RectTransform>();

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
        SceneManager.LoadScene("DeckBuild");
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
                    }
                    else
                    {
                        m_Menu_Menu.Load();
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
        CardInfo c = m_SaveData.GetCardInfo();
        FavoriteImage.sprite = m_Menu_ConvertSpriteFromCardNo.ConvertSpriteFromCardNo(c.GetCardNo());
    }
    
    public void UpdateImage(float magnification_x, float magnification_y)
    {
        Parent.sizeDelta = new Vector2(Parent.sizeDelta.x * magnification_x, Parent.sizeDelta.y * magnification_y);
        Image_Parent.sizeDelta = new Vector2(Image_Parent.sizeDelta.x * magnification_x, Image_Parent.sizeDelta.y * magnification_y);
        Middle_Parent.sizeDelta = new Vector2(Middle_Parent.sizeDelta.x * magnification_x, Middle_Parent.sizeDelta.y * magnification_y);
        Name.sizeDelta = new Vector2(Name.sizeDelta.x * magnification_x, Name.sizeDelta.y * magnification_y);
        Colors.sizeDelta = new Vector2(Colors.sizeDelta.x * magnification_x, Colors.sizeDelta.y * magnification_y);
        Button_Parent.sizeDelta = new Vector2(Button_Parent.sizeDelta.x * magnification_x, Button_Parent.sizeDelta.y * magnification_y);

        float magnification = magnification_x;
        if (magnification_x < magnification_y)
        {
            magnification = magnification_y;
        }
        Image_Child.sizeDelta = new Vector2(Image_Child.sizeDelta.x * magnification, Image_Child.sizeDelta.y * magnification);

        for(int i = 0; i < ButtonList.Count; i++)
        {
            ButtonList[i].sizeDelta = new Vector2(ButtonList[i].sizeDelta.x * magnification, ButtonList[i].sizeDelta.y * magnification);
        }
    }
}
