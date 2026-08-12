using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_117_JA_01 : CardInfo
{
    public CardInfo_117_JA_01()
    {
        this.cardNo = "117_JA_01";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ƒ‚ƒAƒi";
        this.cardName2 = "ŠC‚É‘I‚Î‚ê‚µŽÒ";
        this.power = 2;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = "Tanisha Cherislin";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
