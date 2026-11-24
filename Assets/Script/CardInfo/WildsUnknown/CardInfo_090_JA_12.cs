using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_090_JA_12 : CardInfo
{
    public CardInfo_090_JA_12()
    {
        this.cardNo = "090_JA_12";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "女王";
        this.cardName2 = "欺きの姿";
        this.power = 5;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.EriWelli;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Queen, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
