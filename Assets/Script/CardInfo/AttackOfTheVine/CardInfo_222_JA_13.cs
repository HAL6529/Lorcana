using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_222_JA_13 : CardInfo
{
    public CardInfo_222_JA_13()
    {
        this.cardNo = "222_JA_13";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "100エーカーの森";
        this.cardName2 = "はちみつのキャンプ";
        this.power = 1;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JeremyAdamsAndJaimePuga;
        this.classList = new List<EnumController.Class> { EnumController.Class.Hunny };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Epic;
    }
}
