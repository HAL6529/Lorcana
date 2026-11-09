using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_006_JA_02 : CardInfo
{
    public CardInfo_006_JA_02()
    {
        this.cardNo = "006_JA_02";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "‚¨‚Æ‚Ú‚¯";
        this.cardName2 = "‚¢‚Â‚Å‚à—z‹C";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
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
