using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelPicture : MonoBehaviour
{
    public Image m_image;

    public RectTransform Parent;
    public RectTransform Button_Header;
    public RectTransform Button_Favorite;
    public RectTransform Button_Close;
    public RectTransform Image;

    private CardInfo c;

    public SaveDataStatic m_SaveDataStatic = new SaveDataStatic();

    public void SetView(CardInfo m_CardInfo)
    {
        c = m_CardInfo;
        m_image.sprite = m_CardInfo.GetSprite();
        this.gameObject.SetActive(true);
    }

    public void onCloseBtn()
    {
        this.gameObject.SetActive(false);
    }

    public void onFavoriteBtn()
    {
        m_SaveDataStatic.SetFavoriteCardInfo(c);
        Debug.Log(m_SaveDataStatic.GetFavoriteCardInfo());
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
    }
}
