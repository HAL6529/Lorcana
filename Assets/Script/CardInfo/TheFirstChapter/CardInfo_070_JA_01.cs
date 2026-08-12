using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_070_JA_01 : CardInfo
{
    public CardInfo_070_JA_01()
    {
        this.cardNo = "070_JA_01";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ñÏèb";
        this.cardName2 = "òTÇÃìVìG";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = "Jeff Murchie";
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Prince};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
