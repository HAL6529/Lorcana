using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_073_JA_06 : CardInfo
{
    public CardInfo_073_JA_06()
    {
        this.cardNo = "073_JA_06";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ゴー・ゴー・トマゴ";
        this.cardName2 = "ダイナミック・ダイナモ";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlexAccorsi;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
