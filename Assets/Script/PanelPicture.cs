using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelPicture : MonoBehaviour
{
    public Image m_image;
    public Image favoriteBtn_image;

    public Sprite FavoriteOn;
    public Sprite FavoriteOff;

    public RectTransform Parent;
    public RectTransform Button_Header;
    public RectTransform Button_Favorite;
    public RectTransform Button_Close;
    public RectTransform Image;

    private const int Parent_X = 890;
    private const int Parent_Y = 1920;
    private const int Button_Header_X = 890;
    private const int Button_Header_Y = 80;
    private const int Button_Favorite_X = 80;
    private const int Button_Favorite_Y = 80;
    private const int Button_Close_X = 80;
    private const int Button_Close_Y = 80;
    private const int Image_X = 890;
    private const int Image_Y = 1243;

    private CardInfo c;

    public SaveDataStatic m_SaveDataStatic = new SaveDataStatic();

    private bool favoriteBtn = false;

    public void SetView(CardInfo m_CardInfo)
    {
        c = m_CardInfo;
        m_image.sprite = m_CardInfo.GetSprite();
        this.gameObject.SetActive(true);
        if(m_CardInfo.GetCardNo() == m_SaveDataStatic.GetFavoriteCardInfo().GetCardNo())
        {
            favoriteBtn = true;
        }
        else
        {
            favoriteBtn = false;
        }
        ChangeFavoriteBtnSprite();
    }

    public void onCloseBtn()
    {
        this.gameObject.SetActive(false);
    }

    public void onFavoriteBtn()
    {
        if (favoriteBtn)
        {
            favoriteBtn = false;
            CardInfo favoriteCard = new CardInfo();
            m_SaveDataStatic.SetFavoriteCardInfo(favoriteCard);
        }
        else
        {
            favoriteBtn = true;
            m_SaveDataStatic.SetFavoriteCardInfo(c);
        }
        ChangeFavoriteBtnSprite();
    }

    private void ChangeFavoriteBtnSprite()
    {
        if (favoriteBtn)
        {
            favoriteBtn_image.sprite = FavoriteOn;
        }
        else
        {
            favoriteBtn_image.sprite = FavoriteOff;
        }
    }

    public void UpdateImage(float magnification_x, float magnification_y)
    {
        Parent.sizeDelta = new Vector2(Parent_X * magnification_x, Parent_Y * magnification_y);
        Button_Header.sizeDelta = new Vector2(Button_Header_X * magnification_x, Button_Header_Y * magnification_y);

        float magnification = magnification_x;
        if (magnification_x > magnification_y)
        {
            magnification = magnification_y;
        }

        Button_Favorite.sizeDelta = new Vector2(Button_Favorite_X * magnification, Button_Favorite_Y * magnification);
        Button_Close.sizeDelta = new Vector2(Button_Close_X * magnification, Button_Close_Y * magnification);
        Image.sizeDelta = new Vector2(Image_X * magnification, Image_Y * magnification);

        Vector2 left_position = new Vector2(0, 1);
        Vector2 right_position = new Vector2(1, 1);
        float ButtonHeader_Y = (Parent.sizeDelta.y - (Button_Header.sizeDelta.y + Image.sizeDelta.y)) / 2;
        Button_Header.anchorMin = left_position;
        Button_Header.anchorMax = left_position;
        Button_Header.pivot = left_position;
        Button_Header.anchoredPosition = new Vector2(0, ButtonHeader_Y * (-1));

        ButtonHeader_Y += Button_Header.sizeDelta.y;
        Image.anchorMin = left_position;
        Image.anchorMax = left_position;
        Image.pivot = left_position;
        Image.anchoredPosition = new Vector2((Parent.sizeDelta.x - Image.sizeDelta.x) / 2, ButtonHeader_Y * (-1));

        Button_Close.anchorMin = right_position;
        Button_Close.anchorMax = right_position;
        Button_Close.pivot = right_position;
        Button_Close.anchoredPosition = Vector2.zero;

        Button_Favorite.anchorMin = right_position;
        Button_Favorite.anchorMax = right_position;
        Button_Favorite.pivot = right_position;
        Button_Favorite.anchoredPosition = new Vector2(Button_Close.sizeDelta.x * (-1), 0);
    }
}
