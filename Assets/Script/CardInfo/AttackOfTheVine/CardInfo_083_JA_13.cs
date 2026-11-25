using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_083_JA_13 : CardInfo
{
    public CardInfo_083_JA_13()
    {
        this.cardNo = "083_JA_13";
        this.inkCost = 1;
        this.availableInk = false;
        this.cardName1 = "ルー";
        this.cardName2 = "はちみつのローグ";
        this.power = 1;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GonzaloKenny;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Hunny };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
