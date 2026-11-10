using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_173_JA_04 : CardInfo
{
    public CardInfo_173_JA_04()
    {
        this.cardNo = "173_JA_04";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "アルゲス";
        this.cardName2 = "サイクロプス";
        this.power = 4;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Titan };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
