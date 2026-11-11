using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_158_JA_05 : CardInfo
{
    public CardInfo_158_JA_05()
    {
        this.cardNo = "158_JA_05";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ƒxƒ‹";
        this.cardName2 = "•‘“¥‰ï‚ÌŽå–ð";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.FrenchCarlomagno;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
