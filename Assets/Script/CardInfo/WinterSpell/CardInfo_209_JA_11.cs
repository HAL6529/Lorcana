using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_209_JA_11 : CardInfo
{
    public CardInfo_209_JA_11()
    {
        this.cardNo = "209_JA_11";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "アナ";
        this.cardName2 = "小さな妹";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MariaDresden;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Queen };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}
