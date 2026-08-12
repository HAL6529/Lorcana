using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_020_JA_01 : CardInfo
{
    public CardInfo_020_JA_01()
    {
        this.cardNo = "020_JA_01";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ƒVƒ“ƒo";
        this.cardName2 = "ŽçŒìŽÒ‚Ì•Ð—Ø";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = "Filipe Laurentino";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
