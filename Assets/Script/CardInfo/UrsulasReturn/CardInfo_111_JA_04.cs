using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_111_JA_04 : CardInfo
{
    public CardInfo_111_JA_04()
    {
        this.cardNo = "111_JA_04";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "リー・シャン";
        this.cardName2 = "将軍の息子";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.BrianKesinger;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
