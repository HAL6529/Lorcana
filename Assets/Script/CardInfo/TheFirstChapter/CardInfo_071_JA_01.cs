using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_071_JA_01 : CardInfo
{
    public CardInfo_071_JA_01()
    {
        this.cardNo = "071_JA_01";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "チェシャ猫";
        this.cardName2 = "ヘンテコ";
        this.power = 0;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = "Caner Soylu";
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
