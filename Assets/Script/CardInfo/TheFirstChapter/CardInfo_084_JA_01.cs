using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_084_JA_01 : CardInfo
{
    public CardInfo_084_JA_01()
    {
        this.cardNo = "084_JA_01";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "クスコ";
        this.cardName2 = "気分屋の王様";
        this.power = 2;
        this.toughness = 4;
        this.lore = 3;
        this.illustrator = "Grace Tran";
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
