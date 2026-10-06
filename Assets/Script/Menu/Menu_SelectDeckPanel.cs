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
    public Image background1;
    public Image background2;

    private SaveData m_SaveData;

    public Menu_Menu m_Menu_Menu;

    public Menu_ConvertSpriteFromCardNo m_Menu_ConvertSpriteFromCardNo;

    public RectTransform Parent;
    public RectTransform Image_Parent;
    public RectTransform Image_Child;
    public RectTransform Middle_Parent_Header;
    public RectTransform Middle_Parent_Header_background;
    public RectTransform Middle_Parent_Header_background_background1;
    public RectTransform Middle_Parent_Header_background_background2;
    public RectTransform Middle_Parent_Header_background_white;
    public RectTransform Middle_Parent;
    public RectTransform space1;
    public RectTransform Name;
    public RectTransform space2;
    public RectTransform Colors;
    public RectTransform space3;
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
        UpdateBackground();
    }

    private void UpdateBackground()
    {
        string colors1 = m_SaveData.GetColors1();
        string colors2 = m_SaveData.GetColors2();

        if (colors1 != "None" && colors2 != "None")
        {
            switch (colors1)
            {
                case "Amber":
                    background1.color = new Color(220f / 255f, 180f / 255f, 0, 145f / 255f);
                    break;
                case "Amethyst":
                    background1.color = new Color(160f / 255f, 0, 185f / 255f, 145f / 255f);
                    break;
                case "Emerald":
                    background1.color = new Color(0, 150f / 255f, 40f / 255f, 145f / 255f);
                    break;
                case "Sapphire":
                    background1.color = new Color(25f / 255f, 130f / 255f, 200f / 255f, 145f / 255f);
                    break;
                case "Steel":
                    background1.color = new Color(145f / 255f, 150f / 255f, 160f / 255f, 145f / 255f);
                    break;
                case "Ruby":
                    background1.color = new Color(215f / 255f, 0, 40f / 255f, 145f / 255f);
                    break;
                default:
                    background1.color = new Color(1, 1, 1, 0);
                    break;
            }

            switch (colors2)
            {
                case "Amber":
                    background2.color = new Color(220f / 255f, 180f / 255f, 0, 145f / 255f);
                    break;
                case "Amethyst":
                    background2.color = new Color(160f / 255f, 0, 185f / 255f, 145f / 255f);
                    break;
                case "Emerald":
                    background2.color = new Color(0, 150f / 255f, 40f / 255f, 145f / 255f);
                    break;
                case "Sapphire":
                    background2.color = new Color(25f / 255f, 130f / 255f, 200f / 255f, 145f / 255f);
                    break;
                case "Steel":
                    background2.color = new Color(145f / 255f, 150f / 255f, 160f / 255f, 145f / 255f);
                    break;
                case "Ruby":
                    background2.color = new Color(215f / 255f, 0, 40f / 255f, 145f / 255f);
                    break;
                default:
                    background2.color = new Color(1, 1, 1, 0);
                    break;
            }
        }
        else if (colors1 != "None" && colors2 == "None")
        {
            switch (colors1)
            {
                case "Amber":
                    background1.color = new Color(220f / 255f, 180f / 255f, 0, 145f / 255f);
                    background2.color = new Color(220f / 255f, 180f / 255f, 0, 145f / 255f);
                    break;
                case "Amethyst":
                    background1.color = new Color(160f / 255f, 0, 185f / 255f, 145f / 255f);
                    background2.color = new Color(160f / 255f, 0, 185f / 255f, 145f / 255f);
                    break;
                case "Emerald":
                    background1.color = new Color(0, 150f / 255f, 40f / 255f, 145f / 255f);
                    background2.color = new Color(0, 150f / 255f, 40f / 255f, 145f / 255f);
                    break;
                case "Sapphire":
                    background1.color = new Color(25f / 255f, 130f / 255f, 200f / 255f, 145f / 255f);
                    background2.color = new Color(25f / 255f, 130f / 255f, 200f / 255f, 145f / 255f);
                    break;
                case "Steel":
                    background1.color = new Color(145f / 255f, 150f / 255f, 160f / 255f, 145f / 255f);
                    background2.color = new Color(145f / 255f, 150f / 255f, 160f / 255f, 145f / 255f);
                    break;
                case "Ruby":
                    background1.color = new Color(215f / 255f, 0, 40f / 255f, 145f / 255f);
                    background2.color = new Color(215f / 255f, 0, 40f / 255f, 145f / 255f);
                    break;
                default:
                    background1.color = new Color(1, 1, 1, 0);
                    background2.color = new Color(1, 1, 1, 0);
                    break;
            }
        }
        else
        {
            background1.color = new Color(1, 1, 1, 0);
            background2.color = new Color(1, 1, 1, 0);
        }
    }

    public void UpdateImage(float magnification_x, float magnification_y)
    {
        Parent.sizeDelta = new Vector2(Parent.sizeDelta.x * magnification_x, Parent.sizeDelta.y * magnification_y);
        Image_Parent.sizeDelta = new Vector2(Image_Parent.sizeDelta.x * magnification_x, Image_Parent.sizeDelta.y * magnification_y);
        Middle_Parent.sizeDelta = new Vector2(Middle_Parent.sizeDelta.x * magnification_x, Middle_Parent.sizeDelta.y * magnification_y);
        Name.sizeDelta = new Vector2(Name.sizeDelta.x * magnification_x, Name.sizeDelta.y * magnification_y);
        Colors.sizeDelta = new Vector2(Colors.sizeDelta.x * magnification_x, Colors.sizeDelta.y * magnification_y);
        Button_Parent.sizeDelta = new Vector2(Button_Parent.sizeDelta.x * magnification_x, Button_Parent.sizeDelta.y * magnification_y);
        Middle_Parent_Header.sizeDelta = new Vector2(Middle_Parent_Header.sizeDelta.x * magnification_x, Middle_Parent_Header.sizeDelta.y * magnification_y);
        Middle_Parent_Header_background.sizeDelta = new Vector2(Middle_Parent_Header_background.sizeDelta.x * magnification_x, Middle_Parent_Header_background.sizeDelta.y * magnification_y);
        Middle_Parent_Header_background_background1.sizeDelta = new Vector2(Middle_Parent_Header_background_background1.sizeDelta.x * magnification_x, Middle_Parent_Header_background_background1.sizeDelta.y * magnification_y);
        Middle_Parent_Header_background_background2.sizeDelta = new Vector2(Middle_Parent_Header_background_background2.sizeDelta.x * magnification_x, Middle_Parent_Header_background_background2.sizeDelta.y * magnification_y);
        Middle_Parent_Header_background_white.sizeDelta = new Vector2(Middle_Parent_Header_background_white.sizeDelta.x * magnification_x, Middle_Parent_Header_background_white.sizeDelta.y * magnification_y);
        space1.sizeDelta = new Vector2(space1.sizeDelta.x * magnification_x, space1.sizeDelta.y * magnification_y);
        space2.sizeDelta = new Vector2(space2.sizeDelta.x * magnification_x, space2.sizeDelta.y * magnification_y);
        space3.sizeDelta = new Vector2(space3.sizeDelta.x * magnification_x, space3.sizeDelta.y * magnification_y);

        float magnification = magnification_x;
        if (magnification_x > magnification_y)
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
