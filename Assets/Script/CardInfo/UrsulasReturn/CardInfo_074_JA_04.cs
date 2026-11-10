using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_074_JA_04 : CardInfo
{
    public CardInfo_074_JA_04()
    {
        this.cardNo = "074_JA_04";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ハデス";
        this.cardName2 = "ダブル・ディーラー";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlanBatson;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Deity };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
