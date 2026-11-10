using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_141_JA_04 : CardInfo
{
    public CardInfo_141_JA_04()
    {
        this.cardNo = "141_JA_04";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "オーロラ";
        this.cardName2 = "平穏なるプリンセス";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.Koni;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Ward};
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
