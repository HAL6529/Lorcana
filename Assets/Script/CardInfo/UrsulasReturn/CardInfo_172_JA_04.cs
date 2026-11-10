using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_172_JA_04 : CardInfo
{
    public CardInfo_172_JA_04()
    {
        this.cardNo = "172_JA_04";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ÉAÉâÉWÉì";
        this.cardName2 = "åàêSÇµÇΩåïém";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RandyBishop;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
