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
        Parent.sizeDelta = new Vector2(Parent.sizeDelta.x * magnification_x, Parent.sizeDelta.y * magnification_y);
        Button_Header.sizeDelta = new Vector2(Button_Header.sizeDelta.x * magnification_x, Button_Header.sizeDelta.y * magnification_y);

        float magnification = magnification_x;
        if (magnification_x > magnification_y)
        {
            magnification = magnification_y;
        }

        Button_Favorite.sizeDelta = new Vector2(Button_Favorite.sizeDelta.x * magnification, Button_Favorite.sizeDelta.y * magnification);
        Button_Close.sizeDelta = new Vector2(Button_Close.sizeDelta.x * magnification, Button_Close.sizeDelta.y * magnification);
        Image.sizeDelta = new Vector2(Image.sizeDelta.x * magnification, Image.sizeDelta.y * magnification);

        float ButtonHeader_Y = (Parent.sizeDelta.y - (Button_Header.sizeDelta.y + Image.sizeDelta.y)) / 2;
        Button_Header.anchorMin = new Vector2(0, 1);
        Button_Header.anchorMax = new Vector2(0, 1);
        Button_Header.pivot = new Vector2(0, 1);
        Button_Header.anchoredPosition = new Vector2(0, ButtonHeader_Y * (-1));

        ButtonHeader_Y += Button_Header.sizeDelta.y;
        Image.anchorMin = new Vector2(0, 1);
        Image.anchorMax = new Vector2(0, 1);
        Image.pivot = new Vector2(0, 1);
        Image.anchoredPosition = new Vector2((Parent.sizeDelta.x - Image.sizeDelta.x) / 2, ButtonHeader_Y * (-1));

        Button_Close.anchorMin = new Vector2(1, 1);
        Button_Close.anchorMax = new Vector2(1, 1);
        Button_Close.pivot = new Vector2(1, 1);
        Button_Close.anchoredPosition = Vector2.zero;

        Button_Favorite.anchorMin = new Vector2(1, 1);
        Button_Favorite.anchorMax = new Vector2(1, 1);
        Button_Favorite.pivot = new Vector2(1, 1);
        Button_Favorite.anchoredPosition = new Vector2(Button_Close.sizeDelta.x * (-1), 0);
    }
}
