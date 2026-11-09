using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_051_JA_04 : CardInfo
{
    public CardInfo_051_JA_04()
    {
        this.cardNo = "051_JA_04";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "マシュマロウ";
        this.cardName2 = "恐るべき雪の巨人";
        this.power = 0;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SimoneBuonfantino;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
