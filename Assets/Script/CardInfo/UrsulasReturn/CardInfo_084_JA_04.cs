using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_084_JA_04 : CardInfo
{
    public CardInfo_084_JA_04()
    {
        this.cardNo = "084_JA_04";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ペガサス";
        this.cardName2 = "ヘラクレスへの贈り物";
        this.power = 1;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.BrianWeisz;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
