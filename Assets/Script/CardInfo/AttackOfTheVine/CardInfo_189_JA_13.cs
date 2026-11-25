using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_189_JA_13 : CardInfo
{
    public CardInfo_189_JA_13()
    {
        this.cardNo = "189_JA_13";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "フリン・ライダー";
        this.cardName2 = "塔の上で盗んでる";
        this.power = 3;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LucaPinelli;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
