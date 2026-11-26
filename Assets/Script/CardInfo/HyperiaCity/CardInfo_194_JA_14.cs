using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_194_JA_14 : CardInfo
{
    public CardInfo_194_JA_14()
    {
        this.cardNo = "194_JA_14";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "Mr. ビッグ";
        this.cardName2 = "流通王";
        this.power = 0;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LuisHuerta;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
