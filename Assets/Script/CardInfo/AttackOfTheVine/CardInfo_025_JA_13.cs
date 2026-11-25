using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_025_JA_13 : CardInfo
{
    public CardInfo_025_JA_13()
    {
        this.cardNo = "025_JA_13";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ミラベル・マドリガル";
        this.cardName2 = "家族の守り手";
        this.power = 3;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.VeronicaDiLorenzoAndLivioCacciatore;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
