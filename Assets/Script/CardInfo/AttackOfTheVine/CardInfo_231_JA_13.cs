using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_231_JA_13 : CardInfo
{
    public CardInfo_231_JA_13()
    {
        this.cardNo = "231_JA_13";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "メリダ";
        this.cardName2 = "鬼火使い";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KendallHale;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Brave;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
