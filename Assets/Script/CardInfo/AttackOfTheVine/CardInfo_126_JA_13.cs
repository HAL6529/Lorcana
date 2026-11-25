using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_126_JA_13 : CardInfo
{
    public CardInfo_126_JA_13()
    {
        this.cardNo = "126_JA_13";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ティガー";
        this.cardName2 = "はちみつのバーバリアン";
        this.power = 5;
        this.toughness = 4;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.SimoneGiovanardi;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Tigger, EnumController.Class.Hunny };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Reckless };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
