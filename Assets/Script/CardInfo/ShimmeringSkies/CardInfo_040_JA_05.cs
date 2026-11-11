using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_040_JA_05 : CardInfo
{
    public CardInfo_040_JA_05()
    {
        this.cardNo = "040_JA_05";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ブルーニ";
        this.cardName2 = "火のサラマンダー";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.KendallHale;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
