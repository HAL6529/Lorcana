using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_056_JA_13 : CardInfo
{
    public CardInfo_056_JA_13()
    {
        this.cardNo = "056_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ティンカー・ベル";
        this.cardName2 = "未知の道探し";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GiuliaRiva;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Fairy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
