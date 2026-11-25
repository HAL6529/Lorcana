using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_002_JA_13 : CardInfo
{
    public CardInfo_002_JA_13()
    {
        this.cardNo = "002_JA_13";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ミン・リー";
        this.cardName2 = "誇らしげな母親";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MariaDresden;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Mentor, EnumController.Class.RedPanda };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TurningRed;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
