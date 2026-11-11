using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_015_JA_05 : CardInfo
{
    public CardInfo_015_JA_05()
    {
        this.cardNo = "015_JA_05";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ミニーマウス";
        this.cardName2 = "楽隊長";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.RogerPerezAndLeonardoGiammichele;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
