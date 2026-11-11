using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_195_JA_05 : CardInfo
{
    public CardInfo_195_JA_05()
    {
        this.cardNo = "195_JA_05";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ピート";
        this.cardName2 = "リングのレフェリー";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LuisHuerta;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
