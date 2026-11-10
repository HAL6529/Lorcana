using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_172_JA_02 : CardInfo
{
    public CardInfo_172_JA_02()
    {
        this.cardNo = "172_JA_02";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ñÏèb";
        this.cardName2 = "éÃÇƒêgÇÃï€åÏé“";
        this.power = 2;
        this.toughness = 8;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MatthewRobertDavies;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
