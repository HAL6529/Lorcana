using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_070_JA_03 : CardInfo
{
    public CardInfo_070_JA_03()
    {
        this.cardNo = "070_JA_03";
        this.inkCost = 1;
        this.availableInk = false;
        this.cardName1 = "呪われた人魚";
        this.cardName2 = "アースラの被害者";
        this.power = 0;
        this.toughness = 1;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MassimilianoNarcisoAndMariekeFerrari;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
