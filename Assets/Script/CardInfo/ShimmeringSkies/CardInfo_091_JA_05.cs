using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_091_JA_05 : CardInfo
{
    public CardInfo_091_JA_05()
    {
        this.cardNo = "091_JA_05";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "シェンジ";
        this.cardName2 = "ハイエナたちのリーダー";
        this.power = 3;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.OttoParedes;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Hyena };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
