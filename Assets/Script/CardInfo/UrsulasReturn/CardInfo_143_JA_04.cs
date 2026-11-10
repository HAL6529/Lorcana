using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_143_JA_04 : CardInfo
{
    public CardInfo_143_JA_04()
    {
        this.cardNo = "143_JA_04";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ファ・リー";
        this.cardName2 = "ムーランの母";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SarahSchmidt;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
