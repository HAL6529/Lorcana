using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_022_JA_01 : CardInfo
{
    public CardInfo_022_JA_01()
    {
        this.cardNo = "022_JA_01";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "スティッチ";
        this.cardName2 = "あたしの犬";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = "Alex Accorsi";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Alien };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
