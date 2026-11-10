using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_086_JA_02 : CardInfo
{
    public CardInfo_086_JA_02()
    {
        this.cardNo = "086_JA_02";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ÉyÉCÉì";
        this.cardName2 = "ñªäEÇÃè¨à´ñÇ";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KristinaChouriAndMarianaMoreno;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
