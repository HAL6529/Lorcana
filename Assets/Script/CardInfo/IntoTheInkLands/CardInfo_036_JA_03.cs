using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_036_JA_03 : CardInfo
{
    public CardInfo_036_JA_03()
    {
        this.cardNo = "036_JA_03";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "チェルナボーグの従僕ども";
        this.cardName2 = "邪悪の眷属";
        this.power = 2;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MonicaCatalano;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Fantasia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
