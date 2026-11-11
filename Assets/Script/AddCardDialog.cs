using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddCardDialog : MonoBehaviour
{
    public RectTransform Parent;
    public RectTransform CloseButtonHeader;
    public RectTransform CloseButtonHeader_button;
    public RectTransform Button0;
    public RectTransform Button1;
    public RectTransform Button2;
    public RectTransform Button3;
    public RectTransform Button4;

    public Text text0;
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;

    public DialogManager m_DialogManager;
    private EditCardPanel m_EditCardPanel;

    public void Close()
    {
        this.gameObject.SetActive(false);
    }

    public void Open(EditCardPanel paramater)
    {
        m_EditCardPanel = paramater;
        this.gameObject.SetActive(true);
    }

    public void onButton(int paramater)
    {
        if(m_EditCardPanel == null)
        {
            m_DialogManager.AllClose();
            return;
        }
        m_EditCardPanel.SetEditCardPanel(paramater);
        m_DialogManager.AllClose();
    }

    public void onCloseBtn()
    {
        m_DialogManager.AllClose();
    }

    public void UpdateImage(float magnification_x, float magnification_y)
    {
        Parent.sizeDelta = new Vector2(Parent.sizeDelta.x * magnification_x, Parent.sizeDelta.y * magnification_y);
        CloseButtonHeader.sizeDelta = new Vector2(CloseButtonHeader.sizeDelta.x * magnification_x, CloseButtonHeader.sizeDelta.y * magnification_y);
        Button0.sizeDelta = new Vector2(Button0.sizeDelta.x * magnification_x, Button0.sizeDelta.y * magnification_y);
        Button1.sizeDelta = new Vector2(Button1.sizeDelta.x * magnification_x, Button1.sizeDelta.y * magnification_y);
        Button2.sizeDelta = new Vector2(Button2.sizeDelta.x * magnification_x, Button2.sizeDelta.y * magnification_y);
        Button3.sizeDelta = new Vector2(Button3.sizeDelta.x * magnification_x, Button3.sizeDelta.y * magnification_y);
        Button4.sizeDelta = new Vector2(Button4.sizeDelta.x * magnification_x, Button4.sizeDelta.y * magnification_y);

        float magnification = magnification_x;
        if (magnification_x > magnification_y)
        {
            magnification = magnification_y;
        }
        CloseButtonHeader_button.sizeDelta = new Vector2(CloseButtonHeader_button.sizeDelta.x * magnification, CloseButtonHeader_button.sizeDelta.y * magnification);

        int FontSize = (int)(50 * magnification);
        text0.fontSize = FontSize;
        text1.fontSize = FontSize;
        text2.fontSize = FontSize;
        text3.fontSize = FontSize;
        text4.fontSize = FontSize;
    }
}
