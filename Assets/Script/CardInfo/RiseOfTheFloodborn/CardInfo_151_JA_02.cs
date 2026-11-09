using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_151_JA_02 : CardInfo
{
    public CardInfo_151_JA_02()
    {
        this.cardNo = "151_JA_02";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ジャスミン";
        this.cardName2 = "アグラバーの継承者";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.R_laBarberaAndL_Giammichele;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
