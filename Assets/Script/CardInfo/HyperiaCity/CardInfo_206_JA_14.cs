using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_206_JA_14 : CardInfo
{
    public CardInfo_206_JA_14()
    {
        this.cardNo = "206_JA_14";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ジュディ・ホップス";
        this.cardName2 = "用心深い警官";
        this.power = 4;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.Noukah;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift2 };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}
