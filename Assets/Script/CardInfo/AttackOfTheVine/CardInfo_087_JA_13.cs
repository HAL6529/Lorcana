using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_087_JA_13 : CardInfo
{
    public CardInfo_087_JA_13()
    {
        this.cardNo = "087_JA_13";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ミニーマウス";
        this.cardName2 = "調べたがりの冒険家";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RachelElese;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
