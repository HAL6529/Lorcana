using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_045_JA_14 : CardInfo
{
    public CardInfo_045_JA_14()
    {
        this.cardNo = "045_JA_14";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ティンカー・ベル";
        this.cardName2 = "好奇心旺盛な妖精";
        this.power = 0;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.VictorYanoCovarrubias;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Fairy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
