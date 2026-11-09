using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_154_JA_02 : CardInfo
{
    public CardInfo_154_JA_02()
    {
        this.cardNo = "154_JA_02";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ニック・ワイルド";
        this.cardName2 = "悪賢いキツネ";
        this.power = 2;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.BrianWeisz;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
