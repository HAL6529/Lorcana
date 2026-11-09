using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_014_JA_02 : CardInfo
{
    public CardInfo_014_JA_02()
    {
        this.cardNo = "014_JA_02";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ムファサ";
        this.cardName2 = "裏切られた指導者";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.StefanoZanchi;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
