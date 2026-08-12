using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_021_JA_01 : CardInfo
{
    public CardInfo_021_JA_01()
    {
        this.cardNo = "021_JA_01";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "スティッチ";
        this.cardName2 = "お気楽サーファー";
        this.power = 4;
        this.toughness = 8;
        this.lore = 2;
        this.illustrator = "Marcel Berg";
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Alien };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
