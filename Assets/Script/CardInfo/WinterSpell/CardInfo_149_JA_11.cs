using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_149_JA_11 : CardInfo
{
    public CardInfo_149_JA_11()
    {
        this.cardNo = "149_JA_11";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ゴサリン・マラード";
        this.cardName2 = "好奇心ガール";
        this.power = 1;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.FrenchCarlomagno;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.DarkwingDuck;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
