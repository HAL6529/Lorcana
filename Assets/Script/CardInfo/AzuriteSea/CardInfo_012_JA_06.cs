using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_012_JA_06 : CardInfo
{
    public CardInfo_012_JA_06()
    {
        this.cardNo = "012_JA_06";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "チップ";
        this.cardName2 = "レンジャーのリーダー";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.FrenchCarlomagno;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Chipmunk;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
