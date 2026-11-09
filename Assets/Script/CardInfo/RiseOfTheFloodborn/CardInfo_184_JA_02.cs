using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_184_JA_02 : CardInfo
{
    public CardInfo_184_JA_02()
    {
        this.cardNo = "184_JA_02";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ジャファー";
        this.cardName2 = "国務大臣";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RobDiSalvo;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
