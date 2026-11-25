using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_103_JA_13 : CardInfo
{
    public CardInfo_103_JA_13()
    {
        this.cardNo = "103_JA_13";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "とにかくそれを送り返そう";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.KevinSidharta;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.MonstersInc;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Uncommon;
    }
}
