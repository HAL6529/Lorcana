using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_160_JA_01 : CardInfo
{
    public CardInfo_160_JA_01()
    {
        this.cardNo = "160_JA_01";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ƒgƒŠƒgƒ“‰¤";
        this.cardName2 = "ŠC‚Ì‰¤—l";
        this.power = 5;
        this.toughness = 9;
        this.lore = 2;
        this.illustrator = "Cristian Romero";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
