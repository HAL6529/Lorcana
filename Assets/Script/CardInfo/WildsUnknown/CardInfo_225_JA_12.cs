using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_225_JA_12 : CardInfo
{
    public CardInfo_225_JA_12()
    {
        this.cardNo = "225_JA_12";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "YOU'VE GOT A FRIEND IN ME";
        this.cardName2 = "君はともだち";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.AubreyArcher;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.ToyStory;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
