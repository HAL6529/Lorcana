using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_094_JA_02 : CardInfo
{
    public CardInfo_094_JA_02()
    {
        this.cardNo = "094_JA_02";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ティアナ";
        this.cardName2 = "本当のプリンセス";
        this.power = 5;
        this.toughness = 3;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.CaseyRobin;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.ThePrincessAndTheFrog;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
