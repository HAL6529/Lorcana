using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_039_JA_03 : CardInfo
{
    public CardInfo_039_JA_03()
    {
        this.cardNo = "039_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ハイドロス";
        this.cardName2 = "アイスタイタン";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Titan };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
