using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_009_JA_04 : CardInfo
{
    public CardInfo_009_JA_04()
    {
        this.cardNo = "009_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "フェリックス・マドリガル";
        this.cardName2 = "陽気で家族想い";
        this.power = 2;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.HedvigH_S;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
