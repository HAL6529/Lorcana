using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_117_JA_05 : CardInfo
{
    public CardInfo_117_JA_05()
    {
        this.cardNo = "117_JA_05";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "タフィタ・マトンファッジ";
        this.cardName2 = "スッパイ・スピードスター";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JiahuiEvaGao;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Ally, EnumController.Class.Racer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift2 };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
