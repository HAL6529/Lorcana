using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_148_JA_06 : CardInfo
{
    public CardInfo_148_JA_06()
    {
        this.cardNo = "148_JA_06";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ニック・ワイルド";
        this.cardName2 = "ずぶ濡れのキツネ";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LaurenBarger;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
