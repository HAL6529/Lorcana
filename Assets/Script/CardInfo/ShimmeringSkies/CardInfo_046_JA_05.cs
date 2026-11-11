using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_046_JA_05 : CardInfo
{
    public CardInfo_046_JA_05()
    {
        this.cardNo = "046_JA_05";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "ÉAÉi";
        this.cardName2 = "ê_îÈÇÃèóâ§ï√â∫";
        this.power = 4;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JackieDroujko;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Queen, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift2 };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
