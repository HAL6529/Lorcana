using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_123_JA_03 : CardInfo
{
    public CardInfo_123_JA_03()
    {
        this.cardNo = "123_JA_03";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "シンバ";
        this.cardName2 = "やんちゃな仔ライオン";
        this.power = 1;
        this.toughness = 1;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.OggyChristiansson;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
