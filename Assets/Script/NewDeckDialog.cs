using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewDeckDialog : MonoBehaviour
{
    public InputField m_InputField;

    public void onCloseBtn()
    {
        this.gameObject.SetActive(false);
    }

    public void onOpenBtn()
    {
        m_InputField.text = "";
        this.gameObject.SetActive(true);
    }

    public void onNewProject()
    {
        SceneManager.LoadScene("DeckBuild");
    }
}
