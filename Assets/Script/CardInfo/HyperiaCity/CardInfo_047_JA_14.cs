using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_047_JA_14 : CardInfo
{
    public CardInfo_047_JA_14()
    {
        this.cardNo = "047_JA_14";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ピーター・パンの影";
        this.cardName2 = "神出鬼没のイタズラ小僧";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.OttoParedes;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
