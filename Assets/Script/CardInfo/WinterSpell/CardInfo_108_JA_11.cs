using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_108_JA_11 : CardInfo
{
    public CardInfo_108_JA_11()
    {
        this.cardNo = "108_JA_11";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ムーラン";
        this.cardName2 = "臨戦態勢";
        this.power = 4;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JulianDelRey;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
