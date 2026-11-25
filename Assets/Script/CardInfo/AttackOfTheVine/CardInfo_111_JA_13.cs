using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_111_JA_13 : CardInfo
{
    public CardInfo_111_JA_13()
    {
        this.cardNo = "111_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "クスコ";
        this.cardName2 = "注文の多いお客様";
        this.power = 5;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LissetteCarreraAndBrettOwens;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
