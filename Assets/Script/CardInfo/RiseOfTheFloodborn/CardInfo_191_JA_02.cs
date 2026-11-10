using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_191_JA_02 : CardInfo
{
    public CardInfo_191_JA_02()
    {
        this.cardNo = "191_JA_02";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ナヴィーン王子";
        this.cardName2 = "一文無しの王族";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GakuKumatori;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.ThePrincessAndTheFrog;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
