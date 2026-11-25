using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_153_JA_13 : CardInfo
{
    public CardInfo_153_JA_13()
    {
        this.cardNo = "153_JA_13";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ランドール・ボッグス";
        this.cardName2 = "怖いほど狡猾";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.KendallHale;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Monster };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.MonstersInc;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
