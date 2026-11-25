using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_023_JA_13 : CardInfo
{
    public CardInfo_023_JA_13()
    {
        this.cardNo = "023_JA_13";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "カンガ";
        this.cardName2 = "はちみつの吟遊詩人";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CamKendell;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Hunny };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Singer5 };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
