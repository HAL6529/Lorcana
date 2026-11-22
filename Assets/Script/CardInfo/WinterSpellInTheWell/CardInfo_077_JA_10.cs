using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_077_JA_10 : CardInfo
{
    public CardInfo_077_JA_10()
    {
        this.cardNo = "077_JA_10";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ジェットサム";
        this.cardName2 = "ぬけ目のないウツボ";
        this.power = 6;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.RicardoCaria;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
