using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_013_JA_12 : CardInfo
{
    public CardInfo_013_JA_12()
    {
        this.cardNo = "013_JA_12";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ボー・ピープ";
        this.cardName2 = "やさしい羊飼い";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.HyunaLee;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Toy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.ToyStory;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
