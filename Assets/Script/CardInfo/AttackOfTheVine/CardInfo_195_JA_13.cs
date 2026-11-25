using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_195_JA_13 : CardInfo
{
    public CardInfo_195_JA_13()
    {
        this.cardNo = "195_JA_13";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "マキシマス";
        this.cardName2 = "足蹴る葦毛";
        this.power = 4;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.ThereseVildefall;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
