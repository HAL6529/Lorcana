using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_059_JA_12 : CardInfo
{
    public CardInfo_059_JA_12()
    {
        this.cardNo = "059_JA_12";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "フロゾン";
        this.cardName2 = "氷も滴るいい男";
        this.power = 6;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JuanDiegoLeon;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.TheIncredibles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
