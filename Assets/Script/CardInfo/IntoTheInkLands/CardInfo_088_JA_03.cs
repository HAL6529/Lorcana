using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_088_JA_03 : CardInfo
{
    public CardInfo_088_JA_03()
    {
        this.cardNo = "088_JA_03";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "スターキー";
        this.cardName2 = "よこしまな海賊";
        this.power = 6;
        this.toughness = 6;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.AdamFord;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Pirate };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
