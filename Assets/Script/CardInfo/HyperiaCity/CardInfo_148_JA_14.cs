using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_148_JA_14 : CardInfo
{
    public CardInfo_148_JA_14()
    {
        this.cardNo = "148_JA_14";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "プリシラ";
        this.cardName2 = "最速の職員";
        this.power = 0;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MarioOscarGabriele;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
