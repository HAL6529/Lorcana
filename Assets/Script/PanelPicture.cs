using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelPicture : MonoBehaviour
{
    public GameObject ScrollView;
    public Image m_image;

    public void SetView(CardInfo m_CardInfo)
    {
        m_image.sprite = m_CardInfo.GetSprite();
        this.gameObject.SetActive(true);
    }

    public void onCloseBtn()
    {
        this.gameObject.SetActive(false);
        ScrollView.SetActive(true);
    }
}
