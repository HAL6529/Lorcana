using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_094_JA_01 : CardInfo
{
    public CardInfo_094_JA_01()
    {
        this.cardNo = "094_JA_01";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "‚Ü‚½‚â‚é‚Ì‚æ!";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "Ellie Horie";
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Cinderella;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Rare;
    }
}
