using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_125_JA_01 : CardInfo
{
    public CardInfo_125_JA_01()
    {
        this.cardNo = "125_JA_01";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "スティッチ";
        this.cardName2 = "ミーガ・ナ・ラ・クエスタ!";
        this.power = 4;
        this.toughness = 6;
        this.lore = 3;
        this.illustrator = "Bil Robinson";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Alien };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
