using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_049_JA_13 : CardInfo
{
    public CardInfo_049_JA_13()
    {
        this.cardNo = "049_JA_13";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ミン・リー";
        this.cardName2 = "超過保護な母親";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LeonardoGiammichele;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.RedPanda };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TurningRed;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
