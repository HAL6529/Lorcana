using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_043_JA_06 : CardInfo
{
    public CardInfo_043_JA_06()
    {
        this.cardNo = "043_JA_06";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ティンカー・ベル";
        this.cardName2 = "すばやい妖精";
        this.power = 1;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MaliaEwart;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Fairy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
