using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_142_JA_13 : CardInfo
{
    public CardInfo_142_JA_13()
    {
        this.cardNo = "142_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "カールの家";
        this.cardName2 = "空中家屋";
        this.power = 0;
        this.toughness = 6;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.WietseTreurniet;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Up;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}
