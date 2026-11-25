using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_194_JA_13 : CardInfo
{
    public CardInfo_194_JA_13()
    {
        this.cardNo = "194_JA_13";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "スカー";
        this.cardName2 = "ヴァインズの創造物";
        this.power = 5;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.ThereseVildefall;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Vineling };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
