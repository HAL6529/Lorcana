using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_205_JA_05 : CardInfo
{
    public CardInfo_205_JA_05()
    {
        this.cardNo = "205_JA_05";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ナヴィーン王子";
        this.cardName2 = "ウクレレ奏者";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AishaDurmagambetova;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Singer6 };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.ThePrincessAndTheFrog;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
