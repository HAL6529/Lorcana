using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_107_JA_14 : CardInfo
{
    public CardInfo_107_JA_14()
    {
        this.cardNo = "107_JA_14";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ヤマ";
        this.cardName2 = "悪名高い犯罪者";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.HaJungSong;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
