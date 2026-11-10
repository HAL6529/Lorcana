using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_001_JA_02 : CardInfo
{
    public CardInfo_001_JA_02()
    {
        this.cardNo = "001_JA_02";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "てれすけ";
        this.cardName2 = "夢見がちなロマンチスト";
        this.power = 2;
        this.toughness = 5;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.KendallHale;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.SevenDwarfs };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
