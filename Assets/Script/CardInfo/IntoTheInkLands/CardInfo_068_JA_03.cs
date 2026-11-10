using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_068_JA_03 : CardInfo
{
    public CardInfo_068_JA_03()
    {
        this.cardNo = "068_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ñÇñ@égÇ¢ÇÃìÉ";
        this.cardName2 = "ã¡àŸìIå§ãÜèä";
        this.power = 2;
        this.toughness = 7;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.WietseTreurniet;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Fantasia;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Uncommon;
    }
}
