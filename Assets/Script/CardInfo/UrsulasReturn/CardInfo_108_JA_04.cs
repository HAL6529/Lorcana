using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_108_JA_04 : CardInfo
{
    public CardInfo_108_JA_04()
    {
        this.cardNo = "108_JA_04";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ヘラクレス";
        this.cardName2 = "不器用な小僧";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AntoneCouttolenc;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
