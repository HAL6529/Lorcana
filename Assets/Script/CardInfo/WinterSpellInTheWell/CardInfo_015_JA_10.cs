using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_015_JA_10 : CardInfo
{
    public CardInfo_015_JA_10()
    {
        this.cardNo = "015_JA_10";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ターラン";
        this.cardName2 = "豚の世話係";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AlejandroHernandez;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber};
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.TheBlackCauldron;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
