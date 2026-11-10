using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_105_JA_02 : CardInfo
{
    public CardInfo_105_JA_02()
    {
        this.cardNo = "105_JA_02";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ƒgƒ‰ƒ“ƒv•º";
        this.cardName2 = "‚Ð‚ÆŽR‚ÌŽ†‘©";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.BillRobinson;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
