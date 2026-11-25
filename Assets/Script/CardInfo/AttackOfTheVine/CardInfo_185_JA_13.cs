using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_185_JA_13 : CardInfo
{
    public CardInfo_185_JA_13()
    {
        this.cardNo = "185_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "オウル";
        this.cardName2 = "はちみつのレンジャー";
        this.power = 1;
        this.toughness = 1;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.YuNguyen;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Hunny };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
