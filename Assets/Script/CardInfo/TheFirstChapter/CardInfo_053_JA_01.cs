using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_053_JA_01 : CardInfo
{
    public CardInfo_053_JA_01()
    {
        this.cardNo = "053_JA_01";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "パスカル";
        this.cardName2 = "ラプンツェルの親友";
        this.power = 1;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = "Brian Weisz";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
