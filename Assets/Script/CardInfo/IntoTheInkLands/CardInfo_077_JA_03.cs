using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_077_JA_03 : CardInfo
{
    public CardInfo_077_JA_03()
    {
        this.cardNo = "077_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "キット・クラウドキッカー";
        this.cardName2 = "タフガイ";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JakeParker;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TaleSpin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
