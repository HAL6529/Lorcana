using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_056_JA_14 : CardInfo
{
    public CardInfo_056_JA_14()
    {
        this.cardNo = "056_JA_14";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "デモーナ";
        this.cardName2 = "隠蔽する呪文使い";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MariaDresden;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Gargoyle, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Gargoyles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
