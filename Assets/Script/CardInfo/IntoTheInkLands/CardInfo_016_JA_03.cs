using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_016_JA_03 : CardInfo
{
    public CardInfo_016_JA_03()
    {
        this.cardNo = "016_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ピグレット";
        this.cardName2 = "プー海賊団の船長";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GraceTran;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Pirate, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
