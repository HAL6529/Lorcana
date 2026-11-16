using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_146_JA_06 : CardInfo
{
    public CardInfo_146_JA_06()
    {
        this.cardNo = "146_JA_06";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ヘイヘイ";
        this.cardName2 = "トンチキなチキン";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LisanneKoeteeuw;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
