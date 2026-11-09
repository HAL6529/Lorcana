using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_124_JA_02 : CardInfo
{
    public CardInfo_124_JA_02()
    {
        this.cardNo = "124_JA_02";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ラーヤ";
        this.cardName2 = "ハートの指導者";
        this.power = 5;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MatthewRobertDavies;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
