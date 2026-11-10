using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_021_JA_02 : CardInfo
{
    public CardInfo_021_JA_02()
    {
        this.cardNo = "021_JA_02";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ƒ‰ƒvƒ“ƒcƒFƒ‹";
        this.cardName2 = "‚¤‚Æ‚¤‚Æ";
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
        this.rare = EnumController.Rare.Common;
    }
}
