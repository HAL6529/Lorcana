using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OKDialog : MonoBehaviour
{
    public DialogManager m_DialogManager;

    public Text m_Text;

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
}
