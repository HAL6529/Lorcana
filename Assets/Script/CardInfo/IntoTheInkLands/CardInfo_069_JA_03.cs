using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_069_JA_03 : CardInfo
{
    public CardInfo_069_JA_03()
    {
        this.cardNo = "069_JA_03";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "カビー";
        this.cardName2 = "ロスト・ボーイズの力持ち";
        this.power = 3;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.WouterBruneel;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
