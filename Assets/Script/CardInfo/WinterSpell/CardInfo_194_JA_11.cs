using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_194_JA_11 : CardInfo
{
    public CardInfo_194_JA_11()
    {
        this.cardNo = "194_JA_11";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ジュディ・ホップス";
        this.cardName2 = "スノーボール・パトロール";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MatteoMarzocco;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Resist1 };
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
