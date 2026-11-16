using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_158_JA_06 : CardInfo
{
    public CardInfo_158_JA_06()
    {
        this.cardNo = "158_JA_06";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ヨウカイ";
        this.cardName2 = "キャラハン教授";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JenniferPark;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
