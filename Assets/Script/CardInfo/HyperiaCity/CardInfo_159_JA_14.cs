using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_159_JA_14 : CardInfo
{
    public CardInfo_159_JA_14()
    {
        this.cardNo = "159_JA_14";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ベルウェザー";
        this.cardName2 = "超優秀";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.BrianKesinger;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
