using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_001_JA_01 : CardInfo
{
    public CardInfo_001_JA_01()
    {
        this.cardNo = "001_JA_01";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ÉAÉäÉGÉã";
        this.cardName2 = "êlä‘Ç…ÇÕÇ»ÇÍÇΩÇØÇ«";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = "Matthew Robert Davies";
        this.classList = new List<EnumController.Class> { EnumController.Class.Hero, EnumController.Class.Princess, EnumController.Class.StoryBorn};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
