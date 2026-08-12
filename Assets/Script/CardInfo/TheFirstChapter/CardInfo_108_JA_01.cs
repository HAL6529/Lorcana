using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_108_JA_01 : CardInfo
{
    public CardInfo_108_JA_01()
    {
        this.cardNo = "108_JA_01";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ドナルド・ダック";
        this.cardName2 = "騒々しいアヒル";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = "Kenneth Anderson";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
