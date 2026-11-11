using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_190_JA_05 : CardInfo
{
    public CardInfo_190_JA_05()
    {
        this.cardNo = "190_JA_05";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "アーサー";
        this.cardName2 = "ワート";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.KasiaBrzezinska;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
