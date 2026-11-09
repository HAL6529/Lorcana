using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_085_JA_03 : CardInfo
{
    public CardInfo_085_JA_03()
    {
        this.cardNo = "085_JA_03";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "シェンジ";
        this.cardName2 = "ハイエナの頭目";
        this.power = 0;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JochemVanGool;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Hyena };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
