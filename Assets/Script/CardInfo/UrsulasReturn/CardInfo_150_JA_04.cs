using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_150_JA_04 : CardInfo
{
    public CardInfo_150_JA_04()
    {
        this.cardNo = "150_JA_04";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ÉIÉâÉt";
        this.cardName2 = "êMóäÇÃÇ®ÇØÇÈíáä‘";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.BrianKesinger;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
