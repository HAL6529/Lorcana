using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_071_JA_02 : CardInfo
{
    public CardInfo_071_JA_02()
    {
        this.cardNo = "071_JA_02";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ƒxƒ‹";
        this.cardName2 = "–{‚Ì’Ž";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JennaGray;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
