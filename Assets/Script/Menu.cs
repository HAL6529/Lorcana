using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public ViewMode m_ViewMode;

    public DialogManager m_DialogManager;

    private ExtendUtil m_ExtendUtil = new ExtendUtil();

    public Text m_Text;

    public void onCloseBtn()
    {
        this.gameObject.SetActive(false);
    }

    public void onDisplayBtn()
    {
        m_ViewMode.Open();
        this.gameObject.SetActive(false);
    }

    public void onMenuBtn()
    {
        SceneManager.LoadScene("Menu");
    }

    public void onNewSave()
    {
        m_DialogManager.NewSaveDialog_Open();
    }

    public void onAddSave()
    {
        string SecureDataPass = m_ExtendUtil.GetSecureDataPath();
        if (SecureDataPass == "")
        {
            m_Text.text = "なし";
            return;
        }

        //string pass = SecureDataPass + "/Save";

        string pass = m_ExtendUtil.GetSecureDataPath();
        List<string> SaveDataList = new List<string>(Directory.GetFiles(pass));

        try
        {
            using (AndroidJavaObject fileObject = new AndroidJavaObject("java.io.File", SaveDataList[0]))
            {
                // ファイルが存在するか確認
                if (fileObject.Call<bool>("exists"))
                {
                    // delete() メソッドを呼び出して削除を実行
                    if (fileObject.Call<bool>("delete"))
                    {
                        m_Text.text = "削除成功" + SaveDataList[0];
                    }
                    else
                    {
                        m_Text.text = "削除失敗" + SaveDataList[0];
                    }

                }
            }
        }
        catch (Exception e)
        {
            Debug.Log(e);
            m_Text.text = e.ToString();
        }
    }

    private void onSave()
    {

    }
}
