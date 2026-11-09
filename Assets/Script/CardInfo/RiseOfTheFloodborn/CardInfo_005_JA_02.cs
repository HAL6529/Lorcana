using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_005_JA_02 : CardInfo
{
    public CardInfo_005_JA_02()
    {
        this.cardNo = "005_JA_02";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "êÊê∂";
        this.cardName2 = "7êlÇÃÇ±Ç—Ç∆ÇÃÇ®Ç©ÇµÇÁ";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
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
