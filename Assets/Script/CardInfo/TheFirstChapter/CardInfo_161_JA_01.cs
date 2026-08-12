using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_161_JA_01 : CardInfo
{
    public CardInfo_161_JA_01()
    {
        this.cardNo = "161_JA_01";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "–{‚ð“Ç‚Ý‚½‚Ü‚¦";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "Pao Yong";
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Common;
    }
}
