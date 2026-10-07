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
    public Image Mark1;
    public Image Mark2;
    public Image Mark3;
    public Image Mark4;
    public Image Mark5;
    public Image Mark6;
    public Sprite Amethyst;
    public Sprite Amber;
    public Sprite Emerald;
    public Sprite Ruby;
    public Sprite Sapphire;
    public Sprite Steel;

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
    public RectTransform Colors_space1;
    public RectTransform Colors_mark1;
    public RectTransform Colors_space2;
    public RectTransform Colors_mark2;
    public RectTransform Colors_space3;
    public RectTransform Colors_mark3;
    public RectTransform Colors_space4;
    public RectTransform Colors_mark4;
    public RectTransform Colors_space5;
    public RectTransform Colors_mark5;
    public RectTransform Colors_space6;
    public RectTransform Colors_mark6;
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
        UpdateColorMark();
    }

    private void UpdateBackground()
    {
        bool flg1 = false;
        bool flg2 = false;
        string flg_s = "";

        if (m_SaveData.GetIsAmethyst())
        {
            flg1 = true;
            background1.color = new Color(160f / 255f, 0, 185f / 255f, 145f / 255f);
            flg_s = "Amethyst";
        }

        if (m_SaveData.GetIsAmber() && (!flg1 || !flg2))
        {
            if (flg1)
            {
                flg2 = true;
                background2.color = new Color(220f / 255f, 180f / 255f, 0, 145f / 255f);
            }
            else
            {
                flg1 = true;
                background1.color = new Color(220f / 255f, 180f / 255f, 0, 145f / 255f);
                flg_s = "Amber";
            }
        }

        if (m_SaveData.GetIsEmerald() && (!flg1 || !flg2))
        {
            if (flg1)
            {
                flg2 = true;
                background2.color = new Color(0, 150f / 255f, 40f / 255f, 145f / 255f);
            }
            else
            {
                flg1 = true;
                background1.color = new Color(0, 150f / 255f, 40f / 255f, 145f / 255f);
                flg_s = "Emerald";
            }
        }

        if (m_SaveData.GetIsSapphire() && (!flg1 || !flg2))
        {
            if (flg1)
            {
                flg2 = true;
                background2.color = new Color(25f / 255f, 130f / 255f, 200f / 255f, 145f / 255f);
            }
            else
            {
                flg1 = true;
                background1.color = new Color(25f / 255f, 130f / 255f, 200f / 255f, 145f / 255f);
                flg_s = "Sapphire";
            }
        }

        if (m_SaveData.GetIsSteel() && (!flg1 || !flg2))
        {
            if (flg1)
            {
                flg2 = true;
                background2.color = new Color(145f / 255f, 150f / 255f, 160f / 255f, 145f / 255f);
            }
            else
            {
                flg1 = true;
                background1.color = new Color(145f / 255f, 150f / 255f, 160f / 255f, 145f / 255f);
                flg_s = "Steel";
            }
        }

        if (m_SaveData.GetIsRuby() && (!flg1 || !flg2))
        {
            if (flg1)
            {
                flg2 = true;
                background2.color = new Color(215f / 255f, 0, 40f / 255f, 145f / 255f);
            }
            else
            {
                flg1 = true;
                background1.color = new Color(215f / 255f, 0, 40f / 255f, 145f / 255f);
                flg_s = "Ruby";
            }
        }

        if (!flg1)
        {
            background1.color = new Color(1, 1, 1, 0);
        }
        if (!flg2)
        {
            switch (flg_s)
            {
                case "Amethyst":
                    background2.color = new Color(160f / 255f, 0, 185f / 255f, 145f / 255f);
                    break;
                case "Amber":
                    background2.color = new Color(220f / 255f, 180f / 255f, 0, 145f / 255f);
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
    }

    public void UpdateColorMark()
    {
        List<EnumController.Colors> colors = new List<EnumController.Colors>();
        if (m_SaveData.GetIsAmethyst())
        {
            colors.Add(EnumController.Colors.Amethyst);
        }
        if (m_SaveData.GetIsAmber())
        {
            colors.Add(EnumController.Colors.Amber);
        }
        if (m_SaveData.GetIsEmerald())
        {
            colors.Add(EnumController.Colors.Emerald);
        }
        if (m_SaveData.GetIsSapphire())
        {
            colors.Add(EnumController.Colors.Sapphire);
        }
        if (m_SaveData.GetIsSteel())
        {
            colors.Add(EnumController.Colors.Steel);
        }
        if (m_SaveData.GetIsRuby())
        {
            colors.Add(EnumController.Colors.Ruby);
        }

        if (colors.Count == 0)
        {
            Mark1.sprite = null;
            Mark1.color = new Color(1, 1, 1, 0);
        }
        else
        {
            Mark1.sprite = ConvertToSpriteFromColors(colors[0]);
            Mark1.color = new Color(1, 1, 1, 1);
        }

        if (colors.Count > 1)
        {
            Mark2.sprite = ConvertToSpriteFromColors(colors[1]);
            Mark2.color = new Color(1, 1, 1, 1);
        }
        else
        {
            Mark2.sprite = null;
            Mark2.color = new Color(1, 1, 1, 0);
        }

        if (colors.Count > 2)
        {
            Mark3.sprite = ConvertToSpriteFromColors(colors[2]);
            Mark3.color = new Color(1, 1, 1, 1);
        }
        else
        {
            Mark3.sprite = null;
            Mark3.color = new Color(1, 1, 1, 0);
        }

        if (colors.Count > 3)
        {
            Mark4.sprite = ConvertToSpriteFromColors(colors[3]);
            Mark4.color = new Color(1, 1, 1, 1);
        }
        else
        {
            Mark4.sprite = null;
            Mark4.color = new Color(1, 1, 1, 0);
        }

        if (colors.Count > 4)
        {
            Mark5.sprite = ConvertToSpriteFromColors(colors[4]);
            Mark5.color = new Color(1, 1, 1, 1);
        }
        else
        {
            Mark5.sprite = null;
            Mark5.color = new Color(1, 1, 1, 0);
        }

        if (colors.Count > 5)
        {
            Mark6.sprite = ConvertToSpriteFromColors(colors[5]);
            Mark6.color = new Color(1, 1, 1, 1);
        }
        else
        {
            Mark6.sprite = null;
            Mark6.color = new Color(1, 1, 1, 0);
        }
    }

    private Sprite ConvertToSpriteFromColors(EnumController.Colors paramater)
    {
        switch (paramater)
        {
            case EnumController.Colors.Amber:
                return Amber;
            case EnumController.Colors.Amethyst:
                return Amethyst;
            case EnumController.Colors.Emerald:
                return Emerald;
            case EnumController.Colors.Sapphire:
                return Sapphire;
            case EnumController.Colors.Steel:
                return Steel;
            case EnumController.Colors.Ruby:
                return Ruby;
            default:
                return null;
        }
    }

    public void UpdateImage(float magnification_x, float magnification_y)
    {
        Parent.sizeDelta = new Vector2(Parent.sizeDelta.x * magnification_x, Parent.sizeDelta.y * magnification_y);
        Image_Parent.sizeDelta = new Vector2(Image_Parent.sizeDelta.x * magnification_x, Image_Parent.sizeDelta.y * magnification_y);
        Middle_Parent.sizeDelta = new Vector2(Middle_Parent.sizeDelta.x * magnification_x, Middle_Parent.sizeDelta.y * magnification_y);
        Name.sizeDelta = new Vector2(Name.sizeDelta.x * magnification_x, Name.sizeDelta.y * magnification_y);
        Colors.sizeDelta = new Vector2(Colors.sizeDelta.x * magnification_x, Colors.sizeDelta.y * magnification_y);
        Colors_space1.sizeDelta = new Vector2(Colors_space1.sizeDelta.x * magnification_x, Colors_space1.sizeDelta.y * magnification_y);
        Colors_space2.sizeDelta = new Vector2(Colors_space2.sizeDelta.x * magnification_x, Colors_space2.sizeDelta.y * magnification_y);
        Colors_space3.sizeDelta = new Vector2(Colors_space3.sizeDelta.x * magnification_x, Colors_space3.sizeDelta.y * magnification_y);
        Colors_space4.sizeDelta = new Vector2(Colors_space4.sizeDelta.x * magnification_x, Colors_space4.sizeDelta.y * magnification_y);
        Colors_space5.sizeDelta = new Vector2(Colors_space5.sizeDelta.x * magnification_x, Colors_space5.sizeDelta.y * magnification_y);
        Colors_space6.sizeDelta = new Vector2(Colors_space6.sizeDelta.x * magnification_x, Colors_space6.sizeDelta.y * magnification_y);
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

        Colors_mark1.sizeDelta = new Vector2(Colors_mark1.sizeDelta.x * magnification, Colors_mark1.sizeDelta.y * magnification);
        Colors_mark2.sizeDelta = new Vector2(Colors_mark2.sizeDelta.x * magnification, Colors_mark2.sizeDelta.y * magnification);
        Colors_mark3.sizeDelta = new Vector2(Colors_mark3.sizeDelta.x * magnification, Colors_mark3.sizeDelta.y * magnification);
        Colors_mark4.sizeDelta = new Vector2(Colors_mark4.sizeDelta.x * magnification, Colors_mark4.sizeDelta.y * magnification);
        Colors_mark5.sizeDelta = new Vector2(Colors_mark5.sizeDelta.x * magnification, Colors_mark5.sizeDelta.y * magnification);
        Colors_mark6.sizeDelta = new Vector2(Colors_mark6.sizeDelta.x * magnification, Colors_mark6.sizeDelta.y * magnification);
    }
}
