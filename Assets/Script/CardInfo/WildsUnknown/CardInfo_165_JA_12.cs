using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_165_JA_12 : CardInfo
{
    public CardInfo_165_JA_12()
    {
        this.cardNo = "165_JA_12";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "サルベージ大作戦";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.GustavoChinaide;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Chipmunk;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
