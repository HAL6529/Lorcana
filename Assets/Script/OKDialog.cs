using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OKDialog : MonoBehaviour
{
    public DialogManager m_DialogManager;

    public Text m_Text;

    public RectTransform Parent;
    public RectTransform header;
    public RectTransform space1;
    public RectTransform text;
    public RectTransform space2;
    public RectTransform btnLine;
    public RectTransform okBtn;
    public RectTransform space3;

    public void Close()
    {
        this.gameObject.SetActive(false);
    }

    public void onCloseBtn()
    {
        m_DialogManager.AllClose();
    }

    public void onOKBtn()
    {
        m_DialogManager.AllClose();
    }

    public void Open(EnumController.OKBtnParamater paramater)
    {
        switch (paramater)
        {
            case EnumController.OKBtnParamater.FailedFileCreate:
                m_Text.text = "Error:デッキの保存に失敗しました";
                break;
            case EnumController.OKBtnParamater.NamelessError:
                m_Text.text = "Error:デッキ名を入力してください";
                break;
            case EnumController.OKBtnParamater.NotFoundSecureDataPass:
                m_Text.text = "AndroidError:内部ストレージが不明です";
                break;
            case EnumController.OKBtnParamater.SuccessFileCreate:
                m_Text.text = "デッキを保存しました";
                break;
            default:
                m_Text.text = "";
                break;
        }

        this.gameObject.SetActive(true);
    }

    public void UpdateImage(float magnification_x, float magnification_y)
    {
        Parent.sizeDelta = new Vector2(Parent.sizeDelta.x * magnification_x, Parent.sizeDelta.y * magnification_y);
        header.sizeDelta = new Vector2(header.sizeDelta.x * magnification_x, header.sizeDelta.y * magnification_y);
        space1.sizeDelta = new Vector2(space1.sizeDelta.x * magnification_x, space1.sizeDelta.y * magnification_y);
        text.sizeDelta = new Vector2(text.sizeDelta.x * magnification_x, text.sizeDelta.y * magnification_y);
        space2.sizeDelta = new Vector2(space2.sizeDelta.x * magnification_x, space2.sizeDelta.y * magnification_y);
        btnLine.sizeDelta = new Vector2(btnLine.sizeDelta.x * magnification_x, btnLine.sizeDelta.y * magnification_y);
        space3.sizeDelta = new Vector2(space3.sizeDelta.x * magnification_x, space3.sizeDelta.y * magnification_y);

        float magnification = magnification_x;
        if (magnification_x > magnification_y)
        {
            magnification = magnification_y;
        }
        okBtn.sizeDelta = new Vector2(okBtn.sizeDelta.x * magnification, okBtn.sizeDelta.y * magnification);
    }
}
