using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_192_JA_05 : CardInfo
{
    public CardInfo_192_JA_05()
    {
        this.cardNo = "192_JA_05";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "シンバ";
        this.cardName2 = "ムファサの息子";
        this.power = 3;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.ShannonHallstein;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
