using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_015_JA_11 : CardInfo
{
    public CardInfo_015_JA_11()
    {
        this.cardNo = "015_JA_11";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ジョン・スミス";
        this.cardName2 = "雪原の追跡者";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.ValerioBuonfantino;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Pocahontas;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
