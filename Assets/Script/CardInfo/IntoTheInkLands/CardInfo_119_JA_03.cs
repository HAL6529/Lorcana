using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_119_JA_03 : CardInfo
{
    public CardInfo_119_JA_03()
    {
        this.cardNo = "119_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ピーター・パン";
        this.cardName2 = "ネバーランドのヒーロー";
        this.power = 1;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AubreyArcher;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
