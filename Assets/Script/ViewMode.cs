using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewMode : MonoBehaviour
{
    public EditCardPanelManager m_EditCardPanelManager;
    public List<Image> deckImageList = new List<Image>();
    public GameObject DeckName;
    public Text DeckNameText;

    public void Open()
    {
        this.gameObject.SetActive(true);
        UpdateDeckName();
        UpdateDeckList();
    }

    public void UpdateDeckList()
    {
        List<CardInfo> DeckList = m_EditCardPanelManager.DeckList;
        for (int i = 0; i < deckImageList.Count; i++)
        {
            if(i < DeckList.Count)
            {
                deckImageList[i].sprite = DeckList[i].m_sprite;
                deckImageList[i].color = new Color(1, 1, 1, 1);
            }
            else
            {
                deckImageList[i].sprite = null;
                deckImageList[i].color = new Color(0, 0, 0, 0);
            }
        }
    }

    private void UpdateDeckName()
    {
        if(m_EditCardPanelManager.DeckName == "")
        {
            DeckNameText.text = "--–¼‘O‚È‚µ--";
        }
        else
        {
            DeckNameText.text = m_EditCardPanelManager.DeckName;
        }
    }

    public void onCloseBtn()
    {
        this.gameObject.SetActive(false);
    }

    public void onEditDeckNameBtn()
    {
        DeckName.SetActive(true);
    }

    public void onDeckName_CloseBtn()
    {
        DeckName.SetActive(false);
    }
}
