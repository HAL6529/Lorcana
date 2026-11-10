using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_160_JA_02 : CardInfo
{
    public CardInfo_160_JA_02()
    {
        this.cardNo = "160_JA_02";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ÉmÉbÉN";
        this.cardName2 = "êÖÇÃê∏óÏ";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.HadjieJoos;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
