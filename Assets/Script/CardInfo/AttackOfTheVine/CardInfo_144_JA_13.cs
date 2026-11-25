using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_144_JA_13 : CardInfo
{
    public CardInfo_144_JA_13()
    {
        this.cardNo = "144_JA_13";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ダグ";
        this.cardName2 = "お前はわしの犬";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KendallHale;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Up;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
