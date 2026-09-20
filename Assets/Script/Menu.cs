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

    }

    private void onSave()
    {

    }
}
