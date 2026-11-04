using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditCardPanelTemp : MonoBehaviour
{
    [SerializeField] private bool isSerachHit;
    [SerializeField] private CardInfo m_CardInfo;
    [SerializeField] private int cardCount;
    [SerializeField] private int index;

    public EditCardPanelTemp(CardInfo m_CardInfo, int cardCount)
    {
        this.isSerachHit = true;
        this.m_CardInfo = m_CardInfo;
        this.cardCount = cardCount;
        this.index = 0;
    }

    public int GetCardCount()
    {
        return cardCount;
    }

    public CardInfo GetCardInfo()
    {
        return m_CardInfo;
    }

    public bool GetIsSerachHit()
    {
        return isSerachHit;
    }

    public int GetIndex()
    {
        return index;
    }

    public void SetCardCount(int paramater)
    {
        cardCount = paramater;
    }

    public void SetCardInfo(CardInfo paramater)
    {
        m_CardInfo = paramater;
    }

    public void SetIsSerachHit(bool paramater)
    {
        isSerachHit = paramater;
    }

    public void SetIndex(int paramater)
    {
        index = paramater;
    }
}
