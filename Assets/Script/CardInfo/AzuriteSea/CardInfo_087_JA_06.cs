using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_087_JA_06 : CardInfo
{
    public CardInfo_087_JA_06()
    {
        this.cardNo = "087_JA_06";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "アリステア・クレイ";
        this.cardName2 = "野心家な実業家";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.DiogoSaito;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
