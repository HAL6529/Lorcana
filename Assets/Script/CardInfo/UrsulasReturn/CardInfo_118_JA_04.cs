using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_118_JA_04 : CardInfo
{
    public CardInfo_118_JA_04()
    {
        this.cardNo = "118_JA_04";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ネッソス";
        this.cardName2 = "河の番人";
        this.power = 7;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JustinRunfola;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
