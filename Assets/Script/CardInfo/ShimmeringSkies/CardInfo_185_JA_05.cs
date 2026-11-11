using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_185_JA_05 : CardInfo
{
    public CardInfo_185_JA_05()
    {
        this.cardNo = "185_JA_05";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "クロンク";
        this.cardName2 = "最高セキュリティ責任者";
        this.power = 6;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.NicholasKole;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Ally, EnumController.Class.Captain};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift5 };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
