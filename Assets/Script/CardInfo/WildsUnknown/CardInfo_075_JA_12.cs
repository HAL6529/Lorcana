using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_075_JA_12 : CardInfo
{
    public CardInfo_075_JA_12()
    {
        this.cardNo = "075_JA_12";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "女王";
        this.cardName2 = "邪悪な支配者";
        this.power = 2;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LaraCarson;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Queen, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
